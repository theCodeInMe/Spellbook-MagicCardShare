namespace MagicCardShare;

public partial class CardEditor : ContentPage
{
	public CardEditor(CardEditor VM)
	{
		InitializeComponent();
		BindingContext = VM;
	}
}