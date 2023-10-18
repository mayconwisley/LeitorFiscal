using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarValidacaoAEJ;

public class ValidacaoAssinaturaDigital
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in AssinaturaDigitalAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Assinatura Digital:\n{validacao}\n";
    }
}
