using Microsoft.Maui.Controls;

namespace SIMAP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnListaProductosClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ListaProductosPage");
        }

        private async void OnAgregarProductoClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("AgregarProductoPage");
        }
    }
}
