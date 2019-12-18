using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        /// <summary>
        /// Instance new object
        /// </summary>
        public MenuPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CounterButtonClicked(object sender, EventArgs e)
        {
            // Go to CountPage
            this.Navigation.PushAsync(App.CountPage);
        }

        /// <summary>
        /// When tabs clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabsButtonClicked(object sender, EventArgs e)
        {
            // Go to CountPage
            this.Navigation.PushAsync(App.TabsPage);
        }

        /// <summary>
        /// When liste clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeButtonClicked(object sender, EventArgs e)
        {
            // Go to CountPage
            this.Navigation.PushAsync(App.ListPage);
        }

        /// <summary>
        /// When nouveautés clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewsButtonClicked(object sender, EventArgs e)
        {
            // Go to CountPage
            this.Navigation.PushAsync(App.Forms_3_5_Page);
        }
    }
}