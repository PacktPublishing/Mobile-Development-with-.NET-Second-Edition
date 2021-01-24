using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OpenApi.Models;

using ShopAcross.Web.Data;

namespace ShopAcross.Web.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Auctions API", Version = "v1"});
                });

            services.AddDbContext<AuctionsStoreContext>(option => option.UseInMemoryDatabase("AuctionsContext"));
            services.AddOData();
            services.AddODataQueryFilter();

            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddStackExchangeRedisCache(
                option =>
                    {
                        option.Configuration = Configuration.GetConnectionString("AzureRedisConnection");
                        option.InstanceName = "master";
                    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});

            app.UseMvc(
                builder =>
                    {
                        builder.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
                        builder.EnableDependencyInjection();
                        builder.MapODataServiceRoute("odata", "odata", GetEdmModel());
                    });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Auctions Api");
                });

        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            var auctionsSet = builder.EntitySet<Auction>("Auctions");
            var usersSet = builder.EntitySet<User>("Users");
            builder.ComplexType<Vehicle>();
            builder.ComplexType<Engine>();
            //usersSet.EntityType.ContainsMany(item => item.Auctions);
            //usersSet.EntityType.ContainsRequired(item => item.Address);
            //usersSet.HasManyBinding(item => item.Auctions, auctionsSet);
            //builder.EntityType<Auction>();
            return builder.GetEdmModel();
        }
    }
}
