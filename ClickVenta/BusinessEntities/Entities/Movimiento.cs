namespace BusinessEntities.Entities
{
    public class Movimiento: BaseEntity
    {
        public string TipoMovimientoId { get; set; }
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }
        public Usuario Usuario { get; set; }
    }
}