using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NutriBalance.Model
{
    class DataSource
    {
        private ObservableCollection<FoodItem> _items;

        public DataSource()
        {
            _items = new ObservableCollection<FoodItem>();
        }

        public void Add(FoodItem item)
        {
            _items.Add(item);
        }

        public ObservableCollection<FoodItem> FoodItems
        {
            get { return _items; }
        }
    }
}
