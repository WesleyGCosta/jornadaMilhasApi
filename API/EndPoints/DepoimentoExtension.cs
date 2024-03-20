using API.Extensions;
using API.Models.Entidades;
using Microsoft.AspNetCore.Http;

namespace API.EndPoints
{
    public static class DepoimentoExtension
    {
        public static void AddEndpointDepoimento(this WebApplication app)
        {
            app.MapGet("/Depoimentos", (IHttpContextAccessor httpContextAccessor) =>
            {
                var baseUri = httpContextAccessor?.HttpContext?.Request.GetBaseUrl();
                var urlImagens = $"{baseUri}/Imagens";


                var depoimentos = new List<Depoimento>
                {
                    new(){Id = 1,
                        Texto="A Jornada foi uma das melhores agências de viagens que eu já experimentei. O serviço ao cliente foi excepcional, e toda a equipe foi muito atenciosa e prestativa.",
                        Autor="Lauro Matos",
                        Avatar=$"{urlImagens}/avatar-1.png" },
                    new(){Id = 2,
                        Texto="Recomendo fortemente a agência de viagens Jornada. Eles oferecem um serviço personalizado e de alta qualidade que excedeu minhas expectativas em minha última viagem.", 
                        Autor="Talita Magalhães", 
                        Avatar=$"{urlImagens}/avatar-2.png"  },
                    new(){Id = 3,
                        Texto="Minha viagem com a Jornada foi incrível! Recomendo muito a agência para quem busca uma experiência emocionante e personalizada a partir das nossas necessidades.", 
                        Autor="Mariana Faustino", 
                        Avatar=$"{urlImagens}/avatar-3.png" }
                };

                return Results.Ok(depoimentos);
            });
        }
    }
}
