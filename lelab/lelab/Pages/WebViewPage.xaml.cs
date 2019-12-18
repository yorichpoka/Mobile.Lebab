using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage(string url = "https://google.fr")
        {
            InitializeComponent();

            // Get value of url browser
            this.webView.Source = url;
        }
    }
}