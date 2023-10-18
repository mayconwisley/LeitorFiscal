using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoCabecalho
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (CabecalhoAFD1510.Portaria!.Contains("1510"))
        {
            CabecalhoAFD1510.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = CabecalhoAFD1510.Portaria;
        }

        if (CabecalhoAFD595.Portaria!.Contains("595"))
        {
            CabecalhoAFD595.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = CabecalhoAFD595.Portaria;
        }

        if (CabecalhoAFD671.Portaria!.Contains("671"))
        {
            CabecalhoAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = CabecalhoAFD671.Portaria;
        }

        return $"Registro: 1 - Cabeçalho: {portaria}\n{validacao}\n";
    }

}
