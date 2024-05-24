using MagicCardShare.ViewModel;

namespace MagicCardShare
{

	public partial class MainMenu : ContentPage
	{
		public MainMenu(MenuViewModel VM)
		{
			InitializeComponent();
			BindingContext = VM;
		}
	}
}