using API.Models.Entidades;

namespace API.EndPoints
{
    public static class EstadoExtension
    {
        public static void AddEndpointEstado(this WebApplication app)
        {
            app.MapGet("/Estados", (IHttpContextAccessor httpContextAccessor) =>
            {

                return Results.Ok(new Estado().GetEstados().OrderBy( e => e.Nome));
            });
        }
    }
}
