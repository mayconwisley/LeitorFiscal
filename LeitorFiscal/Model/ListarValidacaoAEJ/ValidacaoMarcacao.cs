using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarValidacaoAEJ;

public class ValidacaoMarcacao
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in MarcacoesAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 05 - Marcações:\n{validacao}\n";
    }
}
