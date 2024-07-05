using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MagicCardShare.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? loginName;

        [ObservableProperty]
        private string? password;

        [ObservableProperty]
        private string? errorLabel;

        [RelayCommand]
        private async void LoginTo()
        {
            string user = loginName;
            string Password = password;
            bool access;

            if (user != null && password != null)
            {
                DataBaseInterface.SetConnectionstring(user, Password);

                access = DataBaseInterface.LoginDatabase();

                if (access == true)
                {
                    await Shell.Current.GoToAsync(nameof(MainMenu));
                }
                else
                {
                    ErrorLabel = "Passwort oder Benutzername falsch";
                    password = null;
                    LoginName = null;
                }
            }
            else
            {
                ErrorLabel = "Passwort und Benutzername müssen gegeben werden";
            }
        }
    }
}