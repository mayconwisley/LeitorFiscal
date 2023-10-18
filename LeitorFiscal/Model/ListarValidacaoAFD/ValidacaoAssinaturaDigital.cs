using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoAssinaturaDigital
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (AssinaturaDigitalAFD.Portaria!.Contains("595"))
        {
            AssinaturaDigitalAFD.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = AssinaturaDigitalAFD.Portaria;
        }

        if (AssinaturaDigitalAFD.Portaria!.Contains("671"))
        {
            AssinaturaDigitalAFD.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = AssinaturaDigitalAFD.Portaria;
        }

        return $"Assinatura Digital: {portaria}\n{validacao}\n";
    }
}
