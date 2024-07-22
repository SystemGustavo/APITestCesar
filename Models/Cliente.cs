namespace APITestCesar.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string? Email { get; set; }
        public int DistritoId { get; set; }
        public Distrito? Distrito { get; set; }
        public List<DetalleProyecto>? DetalleProyecto { get; set; }

    }
}
