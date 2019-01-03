using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LoftSoftApp.Models;
using LoftSoftApp.Views;
using LoftSoftApp.ViewModels;

namespace LoftSoftApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoftSoftReferences : ContentPage
    {
        LoftSoftReferencesViewModel viewModel;

        public LoftSoftReferences()
        {
            InitializeComponent();

            BindingContext = viewModel = new LoftSoftReferencesViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var employee = args.SelectedItem as Employee;
            if (employee == null)
                return;

            await Navigation.PushAsync(new EmployeeDetailPage(new EmployeeDetailViewModel(employee)));

            // Manually deselect item.
            //EmployeeCopyListView.SelectedItem = null;
        }
        
        async void AddLoftSoftInfo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewEmployeePage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //if (viewModel.Employees.Count == 0)
            //    viewModel.LoadEmployeesCommand.Execute(null);
        }
    }
}