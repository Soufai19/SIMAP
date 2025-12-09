namespace SIMAP.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; } = "Papelería";
    }
}