using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LoftSoftApp.Models;

namespace LoftSoftApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEmployeePage : ContentPage
    {
        public Employee Employee { get; set; }

        public NewEmployeePage()
        {
            InitializeComponent();

            Employee = new Employee
            {
                Name = "Cörele Fischter",
                Title = "HR und so",
                PicName = "http://perfect-pictures.ch/pics/portraits/nicole/nicole-sommershooting-2018-016-lrg.jpg",
                Description = ""
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Employee);
            await Navigation.PopModalAsync();
        }
    }
}