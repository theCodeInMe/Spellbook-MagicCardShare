using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MagicCardShare.Klassen;
using Microsoft.IdentityModel.Tokens;
using System.Collections.ObjectModel;

namespace MagicCardShare.ViewModel
{
    public partial class CardEditorViewModel : ObservableObject
    {
      
        [ObservableProperty]
        private string cardname;

        [ObservableProperty]
        private string description;

        [ObservableProperty]
        private int staerke;

        [ObservableProperty]
        private int widerstandskraft;

        [ObservableProperty]
        private bool legendaer;

        [ObservableProperty]
        List<Faehigkeit> faehigkeiten;


        [ObservableProperty]
        Image cardPicture;

        [ObservableProperty]
        ObservableCollection<Faehigkeit> selectedFaehigkeit;
        

        public CardEditorViewModel()
        {
            Karte Card = new Karte();
            Faehigkeiten = new List<Faehigkeit>(Faehigkeit.ShowAllFaehigkeiten());
            SelectedFaehigkeit = new ObservableCollection<Faehigkeit>();
        }

        [RelayCommand]
        public void AddPickToSelection(Faehigkeit Pick)
        {
            if(Pick != null)
            {
                SelectedFaehigkeit.Add(Pick);

            }
            

        }
    }
}