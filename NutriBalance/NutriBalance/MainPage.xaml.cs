using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using NutriBalance.ViewModel;
using NutriBalance.View;
using NutriBalance.Model;
using NutriBalance.EdanamApi;
using System.Collections.ObjectModel;

namespace NutriBalance
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        RestService _restService;
        MainPageViewModel model;

        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
            model = new MainPageViewModel();
            listView.ItemsSource = model.Items.FoodItems; 
            Title = "ALIMENTOS";
        }

        string GenerateRequestUri(string endpoint, string ingredients)
        {
            string requestUri = endpoint;
            requestUri += $"&ingr={ingredients}";
            return requestUri;
        }

        private async void Item_Tapped(object sender, EventArgs e)
        {
            var item = sender as ViewCell;

            Label ingredient = (Label)item.FindByName("lblIngredient");

            listView.SelectedItem = false;

            _timeToresponse.IsRunning = true;
            _timeToresponse.IsVisible = true;

            NutritionalFacts nutritionalFactsData = await _restService.GetNutritionalData(GenerateRequestUri(Constants.EdanamAPIEndPoind, "100 gr " + ingredient.Text));

            _timeToresponse.IsRunning = false;
            _timeToresponse.IsVisible = false;

            await Navigation.PushAsync(new NutritionalDataView()
            {
                Title = ingredient.Text,
                BindingContext = nutritionalFactsData.totalNutrients

            }) ;

        }

        private void btn_frutas_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = model.Items.FoodItems.Where(i => i.Subcategory == FoodSubcategory.Frutas);          
        }

        private void btn_verduras_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = model.Items.FoodItems.Where(i => i.Subcategory == FoodSubcategory.Verduras);
        }

        private void btn_carnes_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = model.Items.FoodItems.Where(i => i.Subcategory == FoodSubcategory.Carnes);
        }

        private void btn_Legumbres_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = model.Items.FoodItems.Where(i => i.Subcategory == FoodSubcategory.Legumbres);
        }

        private void btn_Aceites_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = model.Items.FoodItems.Where(i => i.Subcategory == FoodSubcategory.Aceites);
        }

        private void btn_frutos_secos_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = model.Items.FoodItems.Where(i => i.Subcategory == FoodSubcategory.Frutos_secos);
        }

        private void btn_todos_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = model.Items.FoodItems;
        }
    }
}
