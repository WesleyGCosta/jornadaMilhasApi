using API.Models.Entidades;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System;

namespace API.Extensions
{
    public static class PromocaoExtension
    {
        public static void AddEndpointPromocao(this WebApplication app)
        {
            app.MapGet("/Promocoes", (IHttpContextAccessor httpContextAccessor) =>
            {
                var request = httpContextAccessor?.HttpContext?.Request;
                var baseUri = $"{request?.Scheme}://{request?.Host}";
                var urlImagens = $"{baseUri}/Imagens";

                var listaPromocoes = new List<Promocao>
                {
                    new() { Id = 1, Destino = "Atacama", Imagem = $"{urlImagens}/atacama.png", Preco = 2500},
                    new() { Id = 2, Destino = "Veneza", Imagem = $"{urlImagens}/veneza.png", Preco = 1500},
                    new() { Id = 3, Destino = "Patagônia", Imagem = $"{urlImagens}/patagonia.png", Preco = 750},
                    new() { Id = 4, Destino = "Grand Canyon", Imagem = $"{urlImagens}/grand-canyon.png", Preco = 2500},
                    new() { Id = 5, Destino = "Turquia", Imagem = $"{urlImagens}/turquia.png", Preco = 1900},
                    new() { Id = 6, Destino = "Cordilheira dos Andes", Imagem = $"{urlImagens}/cordilheira-dos-andes.png", Preco = 800}
                };
                return Results.Ok(listaPromocoes);
            });
        }
    }
}
