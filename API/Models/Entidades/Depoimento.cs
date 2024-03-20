namespace API.Models.Entidades
{
    public class Depoimento
    {
        public int Id { get; set; }
        public string Texto { get; set;} = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Avatar { get; set;} = string.Empty;
    }
}
