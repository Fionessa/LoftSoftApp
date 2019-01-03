using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace LoftSoftApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Über Loftsoft";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://loftsoft.ch")));
        }

        public ICommand OpenWebCommand { get; }
    }
}