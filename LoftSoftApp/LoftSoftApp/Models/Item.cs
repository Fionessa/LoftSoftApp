using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace LoftSoftApp.Models
{
    public class Item
    {
        public Item(string name)
        {
            this.Name = name;
            this.Children = new ObservableCollection<Item>();
        }

        public string Name { get; set; }
        public IList<Item> Children { get; set; }
    }
}
