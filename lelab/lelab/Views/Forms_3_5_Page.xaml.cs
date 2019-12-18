using lelab.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forms_3_5_Page : ContentPage
    {
        public Forms_3_5_Page()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        public ICommand ClickCommand => new Command<string>(
                                            (url) => {
                                                // Display default browser of device with url
                                                //Device.OpenUri(new System.Uri(url));

                                                // Got ot page
                                                Navigation.PushAsync(
                                                    new WebViewPage(url)
                                                );
                                            }
                                        );
    }
}