using Microsoft.Maui.Controls;
using SIMAP.Models;
using SIMAP.Services;

namespace SIMAP.Views
{
    public partial class AgregarProductoPage : ContentPage
    {
        public AgregarProductoPage()
        {
            InitializeComponent();
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreEntry.Text))
            {
                await DisplayAlert("Error", "Ingrese un nombre", "OK");
                return;
            }

            if (!int.TryParse(CantidadEntry.Text, out int cantidad) || cantidad < 0)
            {
                await DisplayAlert("Error", "Cantidad inválida", "OK");
                return;
            }

            var product = new Product
            {
                Name = NombreEntry.Text,
                Quantity = cantidad
            };

            MauiProgram.InventoryService.AddProduct(product);

            await DisplayAlert("Éxito", "Producto agregado", "OK");

            NombreEntry.Text = "";
            CantidadEntry.Text = "";
        }
    }
}
