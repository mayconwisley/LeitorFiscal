using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoMarcacaoPonto
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (MarcacaoPontoAFD1510.Portaria!.Contains("1510"))
        {
            MarcacaoPontoAFD1510.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = MarcacaoPontoAFD1510.Portaria;
        }

        if (MarcacaoPontoAFD595.Portaria!.Contains("595"))
        {
            MarcacaoPontoAFD595.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = MarcacaoPontoAFD595.Portaria;
        }

        if (MarcacaoPontoAFD671.Portaria!.Contains("671"))
        {
            MarcacaoPontoAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = MarcacaoPontoAFD671.Portaria;
        }

        return $"Registro: 3 - Marcação Ponto: {portaria}\n{validacao}\n";
    }
}
