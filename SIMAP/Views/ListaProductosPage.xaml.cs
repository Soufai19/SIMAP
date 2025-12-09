using Microsoft.Maui.Controls;
using SIMAP.Services;

namespace SIMAP.Views
{
    public partial class ListaProductosPage : ContentPage
    {
        public ListaProductosPage()
        {
            InitializeComponent();
            BindingContext = MauiProgram.InventoryService;
        }
    }
}
