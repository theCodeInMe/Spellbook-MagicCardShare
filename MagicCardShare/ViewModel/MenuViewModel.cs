using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MagicCardShare.ViewModel
{
    public partial class MenuViewModel : ObservableObject
    {
        [RelayCommand]
        public async void GotoCardeditor()
        {
        
         await Shell.Current.GoToAsync(nameof(CardEditor));
        }


    }
}
