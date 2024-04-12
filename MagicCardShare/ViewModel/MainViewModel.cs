
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;



namespace MagicCardShare.ViewModel
{
   public partial class MainViewModel: ObservableObject
    {
      
        [ObservableProperty]
        string? loginName;

        [ObservableProperty]
        string? password;

        

        [RelayCommand]
       private async void LoginTo()
        {
            string user = loginName;
            string Password = password;
            bool access;

            SQLConnector connector = new SQLConnector(user, Password);
            access = connector.LoginSQL(connector.connectionstring);


            if (access == true)
            {

                await Shell.Current.GoToAsync(nameof(MainMenu));

            }
            else
            {
                LoginName = "Benutzer oder Passwort falsch, versuchs nochmal";

               

            }



        }
    }

    
}
