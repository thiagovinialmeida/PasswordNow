namespace PasswordNow.Project.Ui.Requests;

public record SenhaRequest(int Quantidade, int Comprimento, bool Maiuscula, bool Minuscula, bool Numero, bool Simbulo);