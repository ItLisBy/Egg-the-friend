using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

namespace Tama.Views
{
    public class ParamImage : UserControl
    {
        public static readonly StyledProperty<string> TypeProperty =
            AvaloniaProperty.Register<ParamImage, string>(nameof(ParamType));

        public string ParamType {
            get => GetValue(TypeProperty);
            set => SetValue(TypeProperty, value);
        }

        public static readonly StyledProperty<int> ValueProperty =
            AvaloniaProperty.Register<ParamImage, int>(nameof(Value));
        
        public int Value {
            get => GetValue(ValueProperty);
            set {
                SetValue(ValueProperty, value);
                if (value is >= 0 and <= 100) {
                    if (Value == 0) { //Param is 0
                        Path = $"/Assets/4_{ParamType}.svg";
                    }
                    else if (Value is <= 25 and > 0) { //Food is from 0 through 25
                        Path = $"/Assets/3_{ParamType}.svg";
                    }
                    else if (Value is <= 50 and > 25) { //Food is from 25 through 50
                        Path = $"/Assets/2_{ParamType}.svg";
                    }
                    else if (Value is <= 75 and > 50) { //Food is from 50 through 75
                        Path = $"/Assets/1_{ParamType}.svg";
                    }
                    else if (Value is <= 100 and > 75) { //Food is from 75 through 100
                        Path = $"/Assets/0_{ParamType}.svg";
                    }
                    else { //Image if food not in range
                        Path = "/Assets/Error.svg";
                    }
                }
            }
        }

        public static readonly StyledProperty<string> PathProperty =
            AvaloniaProperty.Register<ParamImage, string>(nameof(Path));

        public string Path {
            get => GetValue(PathProperty);
            set => SetValue(PathProperty, value);
        }

        public ParamImage() {
            Path = "Base";
            InitializeComponent();
            
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}