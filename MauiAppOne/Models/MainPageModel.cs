using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppOne.Models;
using System.Collections.ObjectModel;

namespace MauiAppOne.Models
{
    public partial class MainPageModel : BasePageModel
    {
        public ObservableCollection<Monkey> Monkeys { get; } = new ObservableCollection<Monkey>();

        [ObservableProperty]
        public bool _rememberMe;

        [RelayCommand]
        private void RememberMeLabel(RadioButton sender)
        {
            RememberMe = !RememberMe;
            System.Diagnostics.Debug.WriteLine($"Rember Me {RememberMe}");
        }

        public MainPageModel() : base()
        {
            Monkeys.Add(new Monkey { Name = "Baboon" });
            Monkeys.Add(new Monkey { Name = "Capuchin Monkey" });
        }
    }
}