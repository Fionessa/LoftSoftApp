using System;

using LoftSoftApp.Models;

namespace LoftSoftApp.ViewModels
{
    public class EmployeeDetailViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }
        public EmployeeDetailViewModel(Employee currEmployee = null)
        {
            Title = currEmployee?.Title;
            Employee = currEmployee;
        }
    }
}
