using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoEventosSensiveis
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (EventosSensiveisAFD595.Portaria!.Contains("595"))
        {
            EventosSensiveisAFD595.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = EventosSensiveisAFD595.Portaria;
        }

        if (EventosSensiveisAFD671.Portaria!.Contains("671"))
        {
            EventosSensiveisAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = EventosSensiveisAFD671.Portaria;
        }

        return $"Registro: 6 - Eventos Sensíveis: {portaria}\n{validacao}\n";
    }
}
