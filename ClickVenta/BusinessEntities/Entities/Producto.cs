namespace BusinessEntities.Entities
{
    public class Producto : BaseEntity
    {
        public string Descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCompra { get; set; }
        public string IdCategoria { get; set; }
        //public string IdPresentacion { get; set; }
    }
}