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
    public partial class RootTabbedView : TabbedPage
    {
        public RootTabbedView()
        {
            InitializeComponent();
        }
    }
}
