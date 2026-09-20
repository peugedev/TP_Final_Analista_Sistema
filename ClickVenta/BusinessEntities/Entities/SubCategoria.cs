namespace BusinessEntities.Entities
{
    public class SubCategoria : BaseEntity
    {
        public string CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
    }
}