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
        Karte card;
      
        [ObservableProperty]
        List<Faehigkeit> faehigkeiten;

        [ObservableProperty]
        ObservableCollection<Faehigkeit> selectedFaehigkeit;

        
        public CardEditorViewModel()
        {
            card = new Karte();
            Faehigkeiten = new List<Faehigkeit>(Faehigkeit.ShowAllFaehigkeiten());
            SelectedFaehigkeit = new ObservableCollection<Faehigkeit>();
        }

        [RelayCommand]
        public void AddPickToSelection(Faehigkeit Pick)
        {
            if(Pick != null)
            {                
               Card.Faehigkeit.Add(Pick);
               SelectedFaehigkeit.Add(Pick);
            }
        }

        [RelayCommand]
        public void deletePickSelection(Faehigkeit Pick)
        {
            if(SelectedFaehigkeit.Contains(Pick))
            {
            Card.Faehigkeit.Remove(Pick);
            SelectedFaehigkeit.Remove(Pick);

            }
            
        }
    }
}