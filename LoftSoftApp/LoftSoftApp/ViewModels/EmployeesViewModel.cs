using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using LoftSoftApp.Models;
using LoftSoftApp.Views;

namespace LoftSoftApp.ViewModels
{
    public class EmployeesViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public Command LoadEmployeesCommand { get; set; }

        public EmployeesViewModel()
        {
            Title = "Loftsoft IT GmbH";
            Employees = new ObservableCollection<Employee>();
            LoadEmployeesCommand = new Command(async () => await ExecuteLoadEmployeesCommand());

            MessagingCenter.Subscribe<NewEmployeePage, Employee>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Employee;
                Employees.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadEmployeesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Employees.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Employees.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}