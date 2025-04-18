namespace PasswordNow.Project.Services;

public class SenhaService
{
    private readonly Random _random = new();
    
    public List<string> GerarSenha(int quantidade, int comprimento, bool maiusculas, bool minusculas, bool numero, bool simbulo)
    {
        List<string> listaSenhas = new List<string>();
        
        string a = "abcdefghijklmnopqrstuvwxyz";
        string A = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string num = "0123456789";
        string simbulos = "!@#$%&";
            
        string caracteresPermitidos = "";

        if (maiusculas == false && minusculas == false && numero == false && simbulo == false)
        { listaSenhas.Add(StatusCodes.Status400BadRequest.ToString()) ; return listaSenhas; }
        if (quantidade == 1) { quantidade -= 1; }
        if (comprimento == 1) { comprimento -= 1; }
        
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

        for (int i = 0; i <= quantidade; i++)
        {
            string senha = "";
            for (int x = 0; x <= comprimento; x++)
            {
                int indiceAleatorio = _random.Next(caracteresPermitidos.Length);
                senha += caracteresPermitidos[indiceAleatorio];
            }
            listaSenhas.Add(senha);
        }
        
        return listaSenhas;
    }
}