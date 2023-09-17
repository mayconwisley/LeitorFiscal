namespace LeitorAEJ.Model.ListarValidacao;

public class ValidacaoIdentificacaoPTRP
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in IdentificacaoPTRPAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 08 - Identificação do PTRP:\n{validacao}\n";
    }
}
