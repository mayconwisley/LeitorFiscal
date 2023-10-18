using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoEmpregadoMT
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (EmpregadoMtAFD1510.Portaria!.Contains("1510"))
        {
            EmpregadoMtAFD1510.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = EmpregadoMtAFD1510.Portaria;
        }

        if (EmpregadoMtAFD595.Portaria!.Contains("595"))
        {
            EmpregadoMtAFD595.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = EmpregadoMtAFD595.Portaria;
        }

        if (EmpregadoMtAFD671.Portaria!.Contains("671"))
        {
            EmpregadoMtAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = EmpregadoMtAFD671.Portaria;
        }

        return $"Registro: 5 - Empregado MT: {portaria}\n{validacao}\n";
    }
}
