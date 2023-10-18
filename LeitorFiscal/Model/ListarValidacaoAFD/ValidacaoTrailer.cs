using LeitorFiscal.AFD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorFiscal.Model.ListarValidacaoAFD;

public class ValidacaoTrailer
{
    public static string Listar()
    {
        string? validacao = string.Empty;
        string? portaria = string.Empty;

        if (TrailerAFD1510.Portaria!.Contains("1510"))
        {
            TrailerAFD1510.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = TrailerAFD1510.Portaria;
        }

        if (TrailerAFD595.Portaria!.Contains("595"))
        {
            TrailerAFD595.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = TrailerAFD595.Portaria;
        }

        if (TrailerAFD671.Portaria!.Contains("671"))
        {
            TrailerAFD671.ErrosValidacao.ForEach(ar => { validacao += $"{ar}\n"; });
            portaria = TrailerAFD671.Portaria;
        }

        return $"Registro: 9 - Trailer: {portaria}\n{validacao}\n";
    }
}
