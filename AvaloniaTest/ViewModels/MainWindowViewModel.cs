using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using AvaloniaTest.Views;
using ReactiveUI;

namespace AvaloniaTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Bitmap? _image_path;

        public Bitmap? ImagePath {
            get => _image_path;
            set => this.RaiseAndSetIfChanged(ref _image_path, value);
        }
        
        public async Task Open() {
            var dialog = new OpenFileDialog();
            string[]? result = null;
            dialog.Filters.Add(new FileDialogFilter() {Name = "Image", Extensions = {"png", "jpg", "jpeg"}});
            result = await dialog.ShowAsync(new Window());
            if (result != null) {
                ImagePath = new Bitmap(result.First());
            }
        }

        public async Task Save() {
            var dialog = new SaveFileDialog();
            dialog.Filters.Add(new FileDialogFilter()
                {Name = "Image", Extensions = {"png, jpg, jpeg"}});
            var result = await dialog.ShowAsync(new Window());
            if (result != null) {
                //File.WriteAllText(result, Data);
            }
        }

        public void OpenPersonWindow() => new Person().Show();
    }
}