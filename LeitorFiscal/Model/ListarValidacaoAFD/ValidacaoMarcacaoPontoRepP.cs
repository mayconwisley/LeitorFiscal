using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoMarcacaoPontoRepP
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (MarcacaoPontoRepPAFD671.Portaria!.Contains("671"))
        {
            MarcacaoPontoRepPAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = MarcacaoPontoRepPAFD671.Portaria;
        }

        return $"Registro: 7 - Marcação Ponto Rep-P: {portaria}\n{validacao}\n";
    }
}
