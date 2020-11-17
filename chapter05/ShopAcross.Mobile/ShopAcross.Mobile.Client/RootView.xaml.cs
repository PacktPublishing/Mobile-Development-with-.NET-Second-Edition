using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopAcross.Mobile.Client
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootView : MasterDetailPage
    {
        public RootView()
        {
            InitializeComponent();

            var list = new List<NavigationItem>();
            list.Add(new NavigationItem { Id = 0, Title = "Home", Icon = "xamarin.png" });
            list.Add(new NavigationItem { Id = 1, Title = "Settings", Icon = "xamarin.png" });

            BindingContext = list;
        }
    }

public class NavigationItem
{
        public int Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }
}
}
