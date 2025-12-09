namespace SIMAP
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar rutas de navegación
            Routing.RegisterRoute("ListaProductosPage", typeof(SIMAP.Views.ListaProductosPage));
            Routing.RegisterRoute("AgregarProductoPage", typeof(SIMAP.Views.AgregarProductoPage));
        }
    }
}
