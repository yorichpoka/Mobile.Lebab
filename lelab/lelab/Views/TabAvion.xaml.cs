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
    public partial class TabAvion : ContentPage
    {
        private const uint LENGTH = 800;

        /// <summary>
        /// Instance new object
        /// </summary>
        public TabAvion()
        {
            InitializeComponent();
            // Set opacity
            avionImage.Opacity = 0;
        }

        /// <summary>
        /// When the image is appearing
        /// </summary>
        protected override void OnAppearing()
        {
            // Call base method
            base.OnAppearing();

            avionImage.TranslationX = -250;
            avionImage.TranslationY= -150;
            avionImage.Rotation = 45;
            avionImage.Scale = 0.7;
            avionImage.Opacity = 0;

            avionImage.FadeTo(1, 100);
            avionImage.TranslateTo(0, 0, LENGTH, Easing.SinInOut);
            avionImage.RotateTo(0, LENGTH, Easing.SinInOut);
            avionImage.ScaleTo(1, LENGTH, Easing.SinInOut);
        }
    }
}