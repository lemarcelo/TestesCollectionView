using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteCollectionView.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TesteTemplate : ContentView
    {
        public TesteTemplate()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Titulo", "TapGestureFrame", "Ok");

        }
    }
}