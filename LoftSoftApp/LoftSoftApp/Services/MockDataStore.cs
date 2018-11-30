using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoftSoftApp.Models;

namespace LoftSoftApp.Services
{
    public class MockDataStore : IDataStore<Employee>
    {
        List<Employee> items;

        public MockDataStore()
        {
            items = new List<Employee>();
            var mockItems = new List<Employee>
            {
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Beat Bianchi", PicName="https://loftsoft.ch/assets/team/beat-bianchi.jpg", Title="Chef", Description="Baumeisterlicher Karateka" },
                new Employee { Id = Guid.NewGuid().ToString(), Name = "André Achermann", PicName="https://loftsoft.ch/assets/team/andre-achermann.jpg", Title="No en Chef", Description="Forschender Schnüffelhund" },
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Raphael Brun", PicName="https://loftsoft.ch/assets/team/raphael-brun.jpg", Title="Und widr en Chef", Description="Bahnbrechender Unihockeyaner" },
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Pascal Pfister", PicName="https://loftsoft.ch/assets/team/pascal-pfister.jpg", Title="Ken Chef", Description="Dauerzockender Pfotograf" },
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Hanspeter Vogt", PicName="https://loftsoft.ch/assets/team/hanspeter-vogt.jpg", Title="O ken Chef", Description="Harpunierender Wandervogel" },
                new Employee { Id = Guid.NewGuid().ToString(), Name = "Matthias Tschumi", PicName="https://loftsoft.ch/assets/team/matthias-tschumi.jpg", Title="Kuchichef", Description="Heimwerkender Familientyp" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Employee item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Employee item)
        {
            var oldItem = items.Where((Employee arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Employee arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Employee> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}