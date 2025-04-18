namespace PasswordNow.Project.Services;

public class SenhaService
{
    private readonly Random _random = new();
    
    public string GerarSenha(int comprimento)
    {
        string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&";
        string senha = "";
        
        for (int i = 0; i <= comprimento; i++)
        {
            int indiceAleatorio = _random.Next(caracteresPermitidos.Length);
            senha += caracteresPermitidos[indiceAleatorio];
        }
        
        return senha;
    }
}