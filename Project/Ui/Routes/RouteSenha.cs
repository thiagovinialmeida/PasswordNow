using PasswordNow.Project.Services;
using PasswordNow.Project.Ui.Requests;

namespace PasswordNow.Project.Ui.Routes;

public static class PasswordNow
{
    public static void GerarSenha(this WebApplication app)
    {
        app.MapPost("", (SenhaRequest senhaRequest, SenhaService senhaService) =>
        {
            List<string> resp = senhaService.GerarSenha(senhaRequest.Quantidade , senhaRequest.Comprimento, senhaRequest.Maiuscula,
                senhaRequest.Minuscula, senhaRequest.Numero, senhaRequest.Simbulo);
            if (resp[0] == "400")
            { return Results.BadRequest("Todas as opções estão desabilitadas. Escolha ao menos uma!"); }
            
            return Results.Ok(resp);
        });
    }
}