using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NutriBalance.ViewModel;
using NutriBalance.EdamanApi;

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
            await DisplayAlert("ENVIANDO...", "Análisis  para : 100 gr "  + ingredient.Text, "Aceptar");

            NutritionalFacts nutritionalFactsData= await _restService.GetNutritionalData(GenerateRequestUri(Constants.EdanamAPIEndPoind, "100 gr " + ingredient.Text));

            await DisplayAlert("RESPUESTA", 
                " Kcal: " + nutritionalFactsData.calories + "\n" +
                " Calcio: " + nutritionalFactsData.totalNutrients._CA.quantity+ " " +
                nutritionalFactsData.totalNutrients._CA.unit + "\n"+
                " Vitamina C: " + nutritionalFactsData.totalNutrients._VITC.quantity + " " +
                nutritionalFactsData.totalNutrients._VITC.unit + "\n" +
                " Hierro: " + nutritionalFactsData.totalNutrients._FE.quantity + " " +
                nutritionalFactsData.totalNutrients._FE.unit ,
                "Aceptar");

        }
    }
}
