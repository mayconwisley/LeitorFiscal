using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoAssinaturaDigital
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        try
        {
            if (!string.IsNullOrEmpty(AssinaturaDigitalAFD.Portaria!.Contains("595").ToString()))
            {
                AssinaturaDigitalAFD.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
                portaria = AssinaturaDigitalAFD.Portaria;
            }

            if (!string.IsNullOrEmpty(AssinaturaDigitalAFD.Portaria!.Contains("671").ToString()))
            {
                AssinaturaDigitalAFD.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
                portaria = AssinaturaDigitalAFD.Portaria;
            }

            return $"Assinatura Digital: {portaria}\n{validacao}\n";
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }
}
