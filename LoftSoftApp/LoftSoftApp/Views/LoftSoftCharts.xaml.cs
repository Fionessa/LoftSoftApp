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
using Telerik.XamarinForms.Input;


namespace LoftSoftApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoftSoftCharts : ContentPage
    {
        //LoftSoftReferencesViewModel viewModel;

        //ItemViewModel itemViewModel;

        public LoftSoftCharts()
        {
            InitializeComponent();

            //BindingContext = viewModel = new LoftSoftReferencesViewModel();

            this.BindingContext = new ItemViewModel();

        }

    }
}