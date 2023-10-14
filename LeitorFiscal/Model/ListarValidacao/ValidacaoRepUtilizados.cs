using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarValidacao;

public class ValidacaoRepUtilizados
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in REPsUtilizadosAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 02 - REPs utilizados:\n{validacao}\n";
    }
}
