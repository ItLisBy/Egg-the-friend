using Avalonia.Media.Imaging;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;

namespace Tama.ViewModels
{
    public class ParamViewModel : ViewModelBase
    {

        private string _type = "base";

        public string Type {
            get => _type;
            set => this.RaiseAndSetIfChanged(ref _type, value);
        }

        private string _image; //Image to be displayed

        public string Img {
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
                        Img = "";
                    }
                    else if (Val is <= 25 and > 0) { //Food is from 0 through 25
                        Img = "";
                    }
                    //...
                    else { //Image if food not in range
                        Img = "";
                    }
                }
            }
        }
    }
}