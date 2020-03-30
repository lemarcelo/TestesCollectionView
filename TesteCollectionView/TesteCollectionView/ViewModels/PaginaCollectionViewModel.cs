using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TesteCollectionView.ViewModels
{
    public class PaginaCollectionViewModel
    {
        public ObservableCollection<string> ListaString => new ObservableCollection<string>
        {
            "Primeira linha","Segunda linha","Terceira linha","Quarta linha","Quinta linha",
            "Sexta linha","Setima linha","Oitava linha","Nona linha","Decma linha"
        };

        public string PropTeste { get; set; }

        public ICommand ItemSelectedCommand => new Command(() => ExibeMensatemAsync());
        public ICommand SelectionChangedCommand => new Command(() => SelectionCommand());

        public PaginaCollectionViewModel()
        {
         
        }
        private async void ExibeMensatemAsync()
        {
            await App.Current.MainPage.DisplayAlert("Alerta!","Behavior","Ok");
        }
        public void SelectionCommand()
        {
            App.Current.MainPage.DisplayAlert("Titulo", "Command", "Ok");
        }
    }
}
