using Avalonia.Media.Imaging;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;

namespace Tama.ViewModels
{
    public class ParamViewModel : ViewModelBase
    {
        private Bitmap _image; //Image to be displayed

        public Bitmap Img {
            get => _image;
            set => this.RaiseAndSetIfChanged(ref _image, value);
        }

        private int _val; //Value of parameter

        public int Val {
            get => _val;
            set {
                if (value >= 0 && value <= 100)
                {
                    this.RaiseAndSetIfChanged(ref _val, value);
                    if (Val == 0) { //Param is 0
                        Img = new Bitmap("");
                    }
                    else if (Val is <= 25 and > 0) { //Food is from 0 through 25
                        Img = new Bitmap("");
                    }
                    //...
                    else { //Image if food not in range
                        Img = new Bitmap("");
                    }
                }
            }
        }
    }
}