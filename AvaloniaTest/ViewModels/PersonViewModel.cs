using System.Threading.Tasks;
using AvaloniaTest.Views;
using ReactiveUI;

namespace AvaloniaTest.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        private string? _surname;

        public string? Surname {
            get => _surname;
            set => this.RaiseAndSetIfChanged(ref _surname, value);
        }

        private string? _name;

        public string? Name {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        private string? _second_name;

        public string? SecondName {
            get => _second_name;
            set => this.RaiseAndSetIfChanged(ref _second_name, value);
        }

        private string? _ged;

        public string? Ged {
            get => _ged;
            set => this.RaiseAndSetIfChanged(ref _ged, value);
        }

        public void Save() {
            
        }

        public void Discard() {
            
        }
    }
}