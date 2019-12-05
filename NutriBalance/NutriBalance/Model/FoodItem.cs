using System;
using System.Collections.Generic;
using System.Text;

namespace NutriBalance.Model
{
    class FoodItem
    {
        public int Id;
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public FoodCategory Category;
        public FoodSubcategory Subcategory;
        public double Kcal { get; set; }
        public double Weight;
        public double Price;
    }

    public enum FoodCategory
    {
        Proteina,
        Hidratos_de_carbono,
        Grasas,
    }

    public enum FoodSubcategory
    {
        Frutas,
        Verduras,
        Carnes,
        Legumbres,
        Frutos_secos,
        Aceites,
    }
}
