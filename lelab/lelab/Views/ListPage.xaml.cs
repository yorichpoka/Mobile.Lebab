using lelab.Models;
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
    public partial class ListPage : ContentPage
    {
        /// <summary>
        /// Array list of articles
        /// </summary>
        public List<Article> Articles { get; set; }

        /// <summary>
        /// Instance new object
        /// </summary>
        public ListPage()
        {
            InitializeComponent();

            this.Articles = new List<Article>()
            {
                new Article
                {
                    Nom = "Lait",
                    Prix = "4 €",
                    Description = "Pack de lait"
                },
                new Article
                {
                    Nom = "Chocolat",
                    Prix = "2.5 €",
                    Description = "70% de cacao"
                },
                new Article
                {
                    Nom = "Pain",
                    Prix = "2 €",
                    Description = "Des baguettes"
                },
                new Article
                {
                    Nom = "Beurre",
                    Prix = "1.2 €",
                    Description = "Demi-sel"
                }
            };

            this.LstView.ItemsSource = this.Articles;
        }

        /// <summary>
        /// When elemetn is clikecd on list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Check if object is selected 
            if (e.SelectedItem == null)
                return;

            // Get and cast object selected
            var articleSelected = e.SelectedItem as Article;

            // Display message
            DisplayAlert(articleSelected.Nom, articleSelected.Description, "OK");
            // Reset item selected
            this.LstView.SelectedItem = null;
        }
    }
}