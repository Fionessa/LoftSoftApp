using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace LoftSoftApp.ViewModels
{
    public class LoftSoftReferencesViewModel : BaseViewModel
    {
        public LoftSoftReferencesViewModel()
        {
            Title = "Loftsofts Referenzen";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}