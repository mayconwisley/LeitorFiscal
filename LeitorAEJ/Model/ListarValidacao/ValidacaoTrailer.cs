namespace LeitorAEJ.Model.ListarValidacao;

public class ValidacaoTrailer
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in TrailerAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 99 - Trailer:\n{validacao}\n";
    }
}
