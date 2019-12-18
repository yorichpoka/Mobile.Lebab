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
    public partial class CountPage : ContentPage
    {
        /// <summary>
        /// Value of count number
        /// </summary>
        private int _CountNumber { get; set; }

        /// <summary>
        /// Instance object
        /// </summary>
        public CountPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountButtonClick(object sender, EventArgs e)
        {
            // Increment count
            this._CountNumber++;

            // Display value of count
            lblCount.Text = this._CountNumber.ToString();
        }
    }
}