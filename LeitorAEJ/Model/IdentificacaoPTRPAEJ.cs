using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class IdentificacaoPTRPAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; private set; }
    [MaxLength(150, ErrorMessage = "O campo NomeProg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '150'")]
    public string? NomeProg { get; private set; }
    [MaxLength(8, ErrorMessage = "O campo VersaoProg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '8'")]
    public string? VersaoProg { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TpIdtDesenv deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TpIdtDesenv { get; private set; }
    [MaxLength(14, ErrorMessage = "O campo IdtDesenv deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '14'")]
    public string? IdtDesenv { get; private set; }
    [MaxLength(150, ErrorMessage = "O campo RazaoNomeDesenv deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '150'")]
    public string? RazaoNomeDesenv { get; private set; }
    [MaxLength(50, ErrorMessage = "O campo EmailDesenv deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '50'")]
    public string? EmailDesenv { get; private set; }

    public static List<IdentificacaoPTRPAEJ> IdentificacaoPTRPAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetIdentificacaoPTRP(string linhaIdentificacaoPTRPAEJ, bool validarPortaria)
    {
        string[] itemLinha = linhaIdentificacaoPTRPAEJ.Split("|");
        ErrosValidacao.Clear();

        var identificacaoPTRP = new IdentificacaoPTRPAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            NomeProg = itemLinha[1].Trim(),
            VersaoProg = itemLinha[2].Trim(),
            TpIdtDesenv = itemLinha[3].Trim(),
            IdtDesenv = itemLinha[4].Trim(),
            RazaoNomeDesenv = itemLinha[5].Trim(),
            EmailDesenv = itemLinha[6].Trim()
        };

        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(identificacaoPTRP) && ValidarTipoDados(identificacaoPTRP))
            {
                IdentificacaoPTRPAEJList.Add(identificacaoPTRP);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item);
            }
        }
        else
        {
            IdentificacaoPTRPAEJList.Add(identificacaoPTRP);
        }
    }
    private static bool ValidarTipoDados(IdentificacaoPTRPAEJ identificacaoPTRP)
    {
        var camposComErro = new List<string>();

        if (!int.TryParse(identificacaoPTRP.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!int.TryParse(identificacaoPTRP.TpIdtDesenv, out _))
        {
            camposComErro.Add("TpIdtDesenv");
        }

        if (!double.TryParse(identificacaoPTRP.IdtDesenv, out _))
        {
            camposComErro.Add("IdtDesenv");
        }

        if (camposComErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}");
            return false;
        }
    }
}
