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

        public DataSource Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public MainPageViewModel()
        {
            LoadAll();
        }

        private void LoadAll()
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


            _items.Add(new FoodItem { Id = 23, Name = "Ajo", ImageSource = "ajo.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 24, Name = "Berenjena", ImageSource = "berenjena.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 25, Name = "Brocoli", ImageSource = "brocoli.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 26, Name = "Cebolla", ImageSource = "cebolla.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 27, Name = "chaucha", ImageSource = "chaucha.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 28, Name = "Choclo", ImageSource = "choclo.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 29, Name = "Espinaca", ImageSource = "espinaca.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 30, Name = "Morron rojo", ImageSource = "morron_rojo.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 31, Name = "Pimienta cayena", ImageSource = "pimienta_cayena.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 32, Name = "Remolacha", ImageSource = "remolacha.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 33, Name = "Repollo", ImageSource = "repollo.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 34, Name = "Tomate", ImageSource = "tomate.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 35, Name = "Zanahoria", ImageSource = "zanahoria.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 36, Name = "Zapallo", ImageSource = "zapallo.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 37, Name = "Caquis", ImageSource = "caquis.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 38, Name = "Papa", ImageSource = "papa.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Verduras, Kcal = 10, Weight = 100, Price = 10 });


            _items.Add(new FoodItem { Id = 39, Name = "Soja", ImageSource = "soja.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Legumbres, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 40, Name = "Frijoles", ImageSource = "frijoles.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Legumbres, Kcal = 10, Weight = 100, Price = 10 });

            _items.Add(new FoodItem { Id = 41, Name = "Anacardo", ImageSource = "castania_de_caju.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutos_secos, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 42, Name = "Almendra", ImageSource = "almendra.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutos_secos, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 43, Name = "Mani", ImageSource = "mani.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutos_secos, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 44, Name = "Nuez", ImageSource = "nuez.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutos_secos, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 45, Name = "Pistacho", ImageSource = "pistacho.png", Category = FoodCategory.Hidratos_de_carbono, Subcategory = FoodSubcategory.Frutos_secos, Kcal = 10, Weight = 100, Price = 10 });

            _items.Add(new FoodItem { Id = 46, Name = "Aceite de Oliva", ImageSource = "aceituna.png", Category = FoodCategory.Grasas, Subcategory = FoodSubcategory.Aceites, Kcal = 10, Weight = 100, Price = 10 });

            _items.Add(new FoodItem { Id = 47, Name = "Carne de Vaca", ImageSource = "bife.png", Category = FoodCategory.Proteina, Subcategory = FoodSubcategory.Carnes, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 48, Name = "Cerdo", ImageSource = "cerdo.png", Category = FoodCategory.Proteina, Subcategory = FoodSubcategory.Carnes, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 49, Name = "Huevo", ImageSource = "huevo.png", Category = FoodCategory.Proteina, Subcategory = FoodSubcategory.Carnes, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 50, Name = "Pavo", ImageSource = "pavo.png", Category = FoodCategory.Proteina, Subcategory = FoodSubcategory.Carnes, Kcal = 10, Weight = 100, Price = 10 });
            _items.Add(new FoodItem { Id = 51, Name = "Pollo", ImageSource = "pollo.png", Category = FoodCategory.Proteina, Subcategory = FoodSubcategory.Carnes, Kcal = 10, Weight = 100, Price = 10 });

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
