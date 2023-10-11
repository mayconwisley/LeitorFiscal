using LeitorAEJ.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.AEJ;

public class MarcacoesAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; private set; }
    [MaxLength(9, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? IdtVinculoAej { get; private set; }
    [MaxLength(24, ErrorMessage = "O campo DataHoraMarc deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraMarc deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '24'")]
    public string? DataHoraMarc { get; private set; }
    [MaxLength(9, ErrorMessage = "O campo IdRepAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '9'")]
    public string? IdRepAej { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TpMarc deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpMarc deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? TpMarc { get; private set; }
    [MaxLength(3, ErrorMessage = "O campo SeqEntSaida deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '3'")]
    [MinLength(3, ErrorMessage = "O campo SeqEntSaida deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '3'")]
    public string? SeqEntSaida { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo FonteMarc deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo FonteMarc deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? FonteMarc { get; private set; }
    [MaxLength(30, ErrorMessage = "O campo CodHorContratual deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '30'")]
    public string? CodHorContratual { get; private set; }
    [MaxLength(150, ErrorMessage = "O campo Motivo deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '150'")]
    public string? Motivo { get; private set; }

    public static List<MarcacoesAEJ> MarcacoesAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetMarcacoes(string linhaMarcacoes)
    {
        string[] itemLinha = linhaMarcacoes.Split("|");

        var marcacoes = new MarcacoesAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            IdtVinculoAej = itemLinha[1].Trim(),
            DataHoraMarc = itemLinha[2].Trim(),
            IdRepAej = itemLinha[3].Trim(),
            TpMarc = itemLinha[4].Trim(),
            SeqEntSaida = itemLinha[5].Trim(),
            FonteMarc = itemLinha[6].Trim(),
            CodHorContratual = itemLinha[7].Trim(),
            Motivo = itemLinha[8].Trim()
        };
        if (ValidacaoTamanhoDado.ValidarTamanho(marcacoes) && ValidarTipoDados(marcacoes))
        {
            if (marcacoes.TpMarc != "E" && marcacoes.TpMarc != "S" && marcacoes.TpMarc != "D")
            {
                ErrosValidacao.Add($"Marcação {marcacoes.DataHoraMarc} esta com o campo 'TpMarc' com o valor ({marcacoes.TpMarc}) inválido, deve ter os valores 'E' ou 'S' ou 'D'.\n");
                return;

            }

            if (marcacoes.FonteMarc != "O" && marcacoes.FonteMarc != "I" && marcacoes.FonteMarc != "P" && marcacoes.FonteMarc != "X" && marcacoes.FonteMarc != "T")
            {
                ErrosValidacao.Add($"Marcação {marcacoes.DataHoraMarc} esta com o campo 'FonteMarc' com o valor ({marcacoes.FonteMarc}) inválido, deve ter os valores 'O' ou 'I' ou 'P' ou 'X' ou 'T'.\n");
                return;

            }

            if (marcacoes.TpMarc == "E" && marcacoes.SeqEntSaida == "1" && marcacoes.CodHorContratual == "")
            {
                ErrosValidacao.Add($"Marcação {marcacoes.DataHoraMarc} esta com o campo 'CodHorContratual' com o valor ({marcacoes.CodHorContratual}) inválido, deve ser informado quando o TpMarc = 'E' e SeqEntSaida = '1'.\n");
                return;
            }

            if (marcacoes.TpMarc == "D" && marcacoes.FonteMarc == "I")
            {
                ErrosValidacao.Add($"Marcação {marcacoes.DataHoraMarc} esta com o campo 'Motivo' inválido, campo OBRIGATÓRIO quando o TpMarc = 'D' e FonteMarc = 'I'.\n");
                return;
            }
            MarcacoesAEJList.Add(marcacoes);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
        }
    }

    private static bool ValidarTipoDados(MarcacoesAEJ marcacoesAEJ)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(marcacoesAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!double.TryParse(marcacoesAEJ.IdtVinculoAej, out _))
        {
            camposComErro.Add("IdtVinculoAej");
        }

        if (!DateTime.TryParse(marcacoesAEJ.DataHoraMarc, out _))
        {
            camposComErro.Add("DataHoraMarc");
        }

        if (!double.TryParse(marcacoesAEJ.IdRepAej, out _))
        {
            camposComErro.Add("IdRepAej");
        }

        if (!int.TryParse(marcacoesAEJ.SeqEntSaida, out _))
        {
            camposComErro.Add("SeqEntSaida");
        }

        if (camposComErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n");
            return false;
        }
    }
}
