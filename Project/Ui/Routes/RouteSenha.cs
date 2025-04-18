using PasswordNow.Project.Services;
using PasswordNow.Project.Ui.Requests;

namespace PasswordNow.Project.Ui.Routes;

public static class PasswordNow
{
    public static void GerarSenha(this WebApplication app)
    {
        app.MapPost("", (SenhaRequest senhaRequest, SenhaService _senhaService) =>
        {
            return Results.Ok(_senhaService.GerarSenha(senhaRequest.Comprimento));
        });
    }
}