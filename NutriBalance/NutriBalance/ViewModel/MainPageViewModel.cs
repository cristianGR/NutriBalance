using NutriBalance.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NutriBalance.ViewModel
{
    class MainPageViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DataSource _items = new DataSource();

        public MainPageViewModel()
        {
            LoadFoodItems();
        }

        private void LoadFoodItems()
        {
            _items.Add(new FoodItem { Id = 1, Name = "Aguacate", ImageSource = "aguacate.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 2, Name = "Arandano", ImageSource = "arandano.png ", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 3, Name = "Banana", ImageSource = "banana.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 4, Name = "Ciruela", ImageSource = "ciruela.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 5, Name = "Coco", ImageSource = "coco.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 6, Name = "Damasco", ImageSource = "damasco.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 7, Name = "Durazno", ImageSource = "durazno.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 8, Name = "Frutilla", ImageSource = "frutilla.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 9, Name = "Granada", ImageSource = "granada.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 10, Name = "Guinda", ImageSource = "guinda.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 11, Name = "Kiwi", ImageSource = "kiwi.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 12, Name = "Lima", ImageSource = "lima.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 13, Name = "Limon", ImageSource = "limon.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 14, Name = "Mandarina", ImageSource = "mandarina.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 15, Name = "Mango", ImageSource = "mango.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 16, Name = "Manzana", ImageSource = "manzana.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 17, Name = "Granada", ImageSource = "granada.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 18, Name = "Melon", ImageSource = "melon.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 19, Name = "Mora negra", ImageSource = "mora_negra.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 20, Name = "Naranja", ImageSource = "naranja.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 21, Name = "Pera", ImageSource = "pera.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 22, Name = "Sandia", ImageSource = "sandia.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutas, Kcal = 10, Weight = 100, Price = 10 });
            
        }

        public ObservableCollection<FoodItem> Items
        {
            get { return _items.FoodItems; }
        }

        private void OnPropertyChanged([CallerMemberName] string NombrePropiedad = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NombrePropiedad));
            }

        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


    }
}
