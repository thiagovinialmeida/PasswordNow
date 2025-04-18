namespace PasswordNow.Project.Services;

public class SenhaService
{
    private readonly Random _random = new();
    
    public string GerarSenha(int comprimento, bool maiusculas, bool minusculas, bool numero, bool simbulo)
    {
        string a = "abcdefghijklmnopqrstuvwxyz";
        string A = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string num = "0123456789";
        string simbulos = "!@#$%&";
            
        string caracteresPermitidos = "";
        string senha = "";

        if (maiusculas == false && minusculas == false && numero == false && simbulo == false)
        { return StatusCodes.Status400BadRequest.ToString(); }
        
        var opcoes = new List<(bool habilitados, string caracteres)>
        {
            (minusculas, a),
            (maiusculas, A),
            (numero, num),
            (simbulo, simbulos)
        };
        
        foreach(var opcao in opcoes)
        {
            if (opcao.habilitados) caracteresPermitidos += opcao.caracteres;
        }
        
        for (int i = 0; i <= comprimento; i++)
        {
            int indiceAleatorio = _random.Next(caracteresPermitidos.Length);
            senha += caracteresPermitidos[indiceAleatorio];
        }
        
        return senha;
    }
}