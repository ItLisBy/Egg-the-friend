using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Media.Imaging;
using ReactiveUI;

namespace Tama.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Bitmap? _background_img;
        public Bitmap? Background {
            get => _background_img;
            set => this.RaiseAndSetIfChanged(ref _background_img, value);
        } 
        public string Greeting => "Welcome to Avalonia!";
    }
}