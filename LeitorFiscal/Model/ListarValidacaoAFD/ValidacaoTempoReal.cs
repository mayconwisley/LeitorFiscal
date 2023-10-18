using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoTempoReal
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (TempoRealAFD1510.Portaria!.Contains("1510"))
        {
            TempoRealAFD1510.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = TempoRealAFD1510.Portaria;
        }

        if (TempoRealAFD595.Portaria!.Contains("595"))
        {
            TempoRealAFD595.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = TempoRealAFD595.Portaria;
        }

        if (TempoRealAFD671.Portaria!.Contains("671"))
        {
            TempoRealAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = TempoRealAFD671.Portaria;
        }

        return $"Registro: 4 - Relógio Tempo Real: {portaria}\n{validacao}\n";
    }
}
