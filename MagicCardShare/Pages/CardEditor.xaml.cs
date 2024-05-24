using MagicCardShare.ViewModel;

namespace MagicCardShare {
	public partial class CardEditor : ContentPage
	{
		public CardEditor(CardEditorViewModel VM)
		{
			InitializeComponent();
			BindingContext = VM;
			
		}
	}
}