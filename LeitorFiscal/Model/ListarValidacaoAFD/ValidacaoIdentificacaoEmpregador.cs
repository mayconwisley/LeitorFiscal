using LeitorFiscal.AFD;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoIdentificacaoEmpregador
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (IdentificacaoEmpresaAFD1510.Portaria!.Contains("1510"))
        {
            IdentificacaoEmpresaAFD1510.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = IdentificacaoEmpresaAFD1510.Portaria;
        }

        if (IdentificacaoEmpresaAFD595.Portaria!.Contains("595"))
        {
            IdentificacaoEmpresaAFD595.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = IdentificacaoEmpresaAFD595.Portaria;
        }

        if (IdentificacaoEmpresaAFD671.Portaria!.Contains("671"))
        {
            IdentificacaoEmpresaAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = IdentificacaoEmpresaAFD671.Portaria;
        }

        return $"Registro: 2 - Identificaçao Empresa: {portaria}\n{validacao}\n";
    }
}
