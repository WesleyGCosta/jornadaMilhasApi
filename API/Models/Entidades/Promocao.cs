namespace API.Models.Entidades
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Destino { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
        public decimal Preco { get; set; }
    }
}
