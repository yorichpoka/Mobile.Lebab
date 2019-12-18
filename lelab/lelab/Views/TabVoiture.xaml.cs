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
    public partial class TabVoiture : ContentPage
    {
        /// <summary>
        /// Instance of new object
        /// </summary>
        public TabVoiture()
        {
            InitializeComponent();
            // Set opacity
            voitureImage.Opacity = 0;
            // Set TranslationX
            voitureImage.TranslationX = 0;
        }

        /// <summary>
        /// When page is appearing
        /// </summary>
        protected override void OnAppearing()
        {
            // Call base method
            base.OnAppearing();

            // Set opacity
            voitureImage.Opacity = 0;
            // Set TranslationX
            voitureImage.TranslationX = 0;
            // Apply fade animation
            voitureImage.FadeTo(1, 1000);
            voitureImage.TranslateTo(50, 0, 1000,Easing.SinInOut);
        }

        protected override void OnDisappearing()
        {
            // Call base method
            base.OnDisappearing();
            // Set opacity
            voitureImage.Opacity = 0;
            // Set TranslationX
            voitureImage.TranslationX = 0;
        }
    }
}