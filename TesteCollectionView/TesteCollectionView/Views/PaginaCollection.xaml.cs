using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteCollectionView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCollection : ContentPage
    {
        public PaginaCollection()
        {
            InitializeComponent();
            BindingContext = new ViewModels.PaginaCollectionViewModel();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("","TapGesture", "Ok");
        }
    }
}