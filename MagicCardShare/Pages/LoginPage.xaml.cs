using MagicCardShare.ViewModel;

    
namespace MagicCardShare
{
    public partial class MainPage : ContentPage 
    {
        

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            
            
        }
         

       
        
        
    }

}
