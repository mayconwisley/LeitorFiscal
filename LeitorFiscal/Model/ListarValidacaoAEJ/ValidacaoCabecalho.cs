using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarValidacaoAEJ;

public class ValidacaoCabecalho
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in CabecalhoAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 01 - Cabeçalho:\n{validacao}\n";
    }
}
