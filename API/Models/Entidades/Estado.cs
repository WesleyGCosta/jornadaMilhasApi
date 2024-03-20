namespace API.Models.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public IEnumerable<Estado> GetEstados()
        {
            return [
                    new() { Id = 1, Nome = "Alagoas", Sigla = "AL" },
                    new() { Id = 2, Nome = "Amapá", Sigla = "AP" },
                    new() { Id = 3, Nome = "Distrito Federal", Sigla = "DF" },
                    new() { Id = 4, Nome = "Espírito Santo", Sigla = "ES" },
                    new() { Id = 5, Nome = "Goiás", Sigla = "GO" },
                    new() { Id = 6, Nome = "Maranhão", Sigla = "MA" },
                    new() { Id = 7, Nome = "Mato Grosso", Sigla = "MT" },
                    new() { Id = 8, Nome = "Mato Grosso do Sul", Sigla = "MS" },
                    new() { Id = 9, Nome = "Minas Gerais", Sigla = "MG" },
                    new() { Id = 10, Nome = "Pará", Sigla = "PA" },
                    new() { Id = 11, Nome = "Paraíba", Sigla = "PB" },
                    new() { Id = 12, Nome = "Paraná", Sigla = "PR" },
                    new() { Id = 13, Nome = "Pernambuco", Sigla = "PE" },
                    new() { Id = 14, Nome = "Piauí", Sigla = "PI" },
                    new() { Id = 15, Nome = "Rio de Janeiro", Sigla = "RJ" },
                    new() { Id = 16, Nome = "Rio Grande do Norte", Sigla = "RN" },
                    new() { Id = 17, Nome = "Rio Grande do Sul", Sigla = "RS" },
                    new() { Id = 18, Nome = "Rondônia", Sigla = "RO" },
                    new() { Id = 19, Nome = "Roraima", Sigla = "RR" },
                    new() { Id = 20, Nome = "Santa Catarina", Sigla = "SC" },
                    new() { Id = 21, Nome = "São Paulo", Sigla = "SP" },
                    new() { Id = 22, Nome = "Sergipe", Sigla = "SE" },
                    new() { Id = 23, Nome = "Tocantins", Sigla = "TO" },
                    new() { Id = 24, Nome = "Bahia", Sigla = "BA" },
                    new() { Id = 25, Nome = "Amazonas", Sigla = "AM" },
                    new() { Id = 26, Nome = "Ceará", Sigla = "CE" },
                    new() { Id = 27, Nome = "Acre", Sigla = "AC" }
                    ];
        }
    }
}
