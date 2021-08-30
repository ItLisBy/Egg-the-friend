using Avalonia.Media.Imaging;
using ReactiveUI;

namespace Tama.ViewModels
{
    public class ThingViewModel : ViewModelBase
    {
        private int _food = 100;
        public int Food {
            get => _food;
            set => this.RaiseAndSetIfChanged(ref _food, value);
        }
        
    }
}