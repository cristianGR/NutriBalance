using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NutriBalance.ViewModel;
using NutriBalance.View;
using NutriBalance.EdanamApi;

namespace NutriBalance
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        RestService _restService;
        
        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
            BindingContext = new MainPageViewModel();
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
    }
}
