using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LoftSoftApp.Models;
using LoftSoftApp.ViewModels;

namespace LoftSoftApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeDetailPage : ContentPage
    {
        EmployeeDetailViewModel viewModel;

        public EmployeeDetailPage(EmployeeDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public EmployeeDetailPage()
        {
            InitializeComponent();

            var employee = new Employee
            {
                Name = "Employee name",
                Description = "This is an item description."
            };

            viewModel = new EmployeeDetailViewModel(employee);
            BindingContext = viewModel;
        }
    }
}