
namespace MiPrimeraApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}

public class Product
{
    public int Id { get; set; }
    public string? Nombre { get; set; } // Hecho nullable
    public string? Descripcion { get; set; } // Hecho nullable
    public decimal Precio { get; set; }
}