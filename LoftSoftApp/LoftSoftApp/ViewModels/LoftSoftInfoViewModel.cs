using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace LoftSoftApp.ViewModels
{
    public class LoftSoftInfoViewModel : BaseViewModel
    {
        public LoftSoftInfoViewModel()
        {
            Title = "Über Loftsoft";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}