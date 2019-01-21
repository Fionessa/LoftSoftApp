using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using LoftSoftApp.Models;

namespace LoftSoftApp.ViewModels
{
    public class ItemViewModel
    {
        public ItemViewModel()
        {
            Source = new ObservableCollection<Item>();
            Source.Add(new Item("Entwicklung")
            {
                Children = new List<Item>()
            {
                new Item("Swisscom")
                {
                    Children = new ObservableCollection<Item>()
                    {
                        new Item("ESW"),
                        new Item("Order Entry"),
                        new Item("BIT sUCCess"),
                        new Item("Profile Switching"),
                        new Item("VOIP Gate")
                    }
                },
                new Item("Schweizerisches Rotes Kreuz")
                {
                    Children = new ObservableCollection<Item>()
                    {
                        new Item("Prospektiva"),
                        new Item("Personenverwaltung"),
                        new Item("2 Mal Weihnachten"),
                        new Item("Interne Leistungsverrechnung")
                    }
                },
                new Item("SLRG")
                {
                    Children = new ObservableCollection<Item>()
                    {
                        new Item("Brevet-Administration"),
                        new Item("Datenmigration")
                    }
                }
            }
            });
            Source.Add(new Item("Beratung")
            {
                Children = new List<Item>()
            {
                new Item("Kanton Zürich")
                {
                    Children = new List<Item>()
                    {
                        new Item("Leunet Portal Services")
                    }
                },
                new Item("Schweizerische Post")
                {
                    Children = new List<Item>()
                    {
                        new Item("Kaderinformationssystem"),
                        new Item("Briefmarkenabschleckassistent")
                    }
                },
                new Item("Axpo")
                {
                    Children = new List<Item>()
                    {
                        new Item("Energy Tool")
                    }
                },
            }
            });
        }
        public ObservableCollection<Item> Source { get; set; }
    }
}

