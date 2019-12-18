using lelab.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab
{
    public partial class App : Application
    {
        /// <summary>
        /// Page of application
        /// </summary>
        public static MenuPage MenuPage = new MenuPage();
        /// <summary>
        /// Page of application
        /// </summary>
        public static CountPage CountPage = new CountPage();
        /// <summary>
        /// Page of application
        /// </summary>
        public static TabsPage TabsPage = new TabsPage();
        /// <summary>
        /// Page of application
        /// </summary>
        public static ListPage ListPage = new ListPage();
        /// <summary>
        /// Page of application
        /// </summary>
        public static Forms_3_5_Page Forms_3_5_Page = new Forms_3_5_Page();

        /// <summary>
        /// Instance new object
        /// </summary>
        public App()
        {
            InitializeComponent();

            // Define view as first page
            MainPage =  new NavigationPage(MenuPage);
        }

        /// <summary>
        /// On application start
        /// </summary>
        protected override void OnStart()
        {
            // TODO
        }

        /// <summary>
        /// On application sleep
        /// </summary>
        protected override void OnSleep()
        {
            // TODO
        }

        /// <summary>
        /// On application resume
        /// </summary>
        protected override void OnResume()
        {
            // TODO
        }
    }
}
