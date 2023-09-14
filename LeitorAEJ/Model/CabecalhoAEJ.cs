using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class CabecalhoAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TpIdtEmpregador deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TpIdtEmpregador { get; private set; }
    [MaxLength(14, ErrorMessage = "O campo IdtEmpregador deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '14'")]
    public string? IdtEmpregador { get; private set; }
    [MaxLength(14, ErrorMessage = "O campo Caepf deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '14'")]
    public string? Caepf { get; private set; }
    [MaxLength(12, ErrorMessage = "O campo Cno deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '12'")]
    public string? Cno { get; private set; }
    [MaxLength(150, ErrorMessage = "O campo RazaoOuNome deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '150'")]
    public string? RazaoOuNome { get; private set; }
    [MaxLength(10, ErrorMessage = "O campo DataInicialAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '10'")]
    public string? DataInicialAej { get; private set; }
    [MaxLength(10, ErrorMessage = "O campo DataFinalAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '10'")]
    public string? DataFinalAej { get; private set; }
    [MaxLength(24, ErrorMessage = "O campo DataHoraGerAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '24'")]
    public string? DataHoraGerAej { get; private set; }
    [MaxLength(3, ErrorMessage = "O campo VersaoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '3'")]
    public string? VersaoAej { get; private set; } = "001";

    public static List<CabecalhoAEJ> CabecalhoAEJList { get; private set; } = new();

    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetCabecalhos(string linhaCabecalho, bool validarPortaria)
    {
        string[] itemLinha = linhaCabecalho.Split("|");
        ErrosValidacao.Clear();

        var cabecalho = new CabecalhoAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            TpIdtEmpregador = itemLinha[1].Trim(),
            IdtEmpregador = itemLinha[2].Trim(),
            Caepf = itemLinha[3].Trim(),
            Cno = itemLinha[4].Trim(),
            RazaoOuNome = itemLinha[5].Trim(),
            DataInicialAej = itemLinha[6].Trim(),
            DataFinalAej = itemLinha[7].Trim(),
            DataHoraGerAej = itemLinha[8].Trim(),
            VersaoAej = itemLinha[9].Trim()
        };

        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(cabecalho) && ValidarTipoDados(cabecalho))
            {
                CabecalhoAEJList.Add(cabecalho);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item);
            }

        }
        else
        {
            CabecalhoAEJList.Add(cabecalho);
        }
    }

    private static bool ValidarTipoDados(CabecalhoAEJ cabecalhoAEJ)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(cabecalhoAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!int.TryParse(cabecalhoAEJ.TpIdtEmpregador, out _))
        {
            camposComErro.Add("TpIdtEmpregador");
        }

        if (!double.TryParse(cabecalhoAEJ.IdtEmpregador, out _))
        {
            camposComErro.Add("IdtEmpregador");
        }

        if (!double.TryParse(cabecalhoAEJ.Caepf, out _))
        {
            camposComErro.Add("Caepf");
        }

        if (!double.TryParse(cabecalhoAEJ.Cno, out _))
        {
            camposComErro.Add("Cno");
        }

        if (!DateTime.TryParse(cabecalhoAEJ.DataInicialAej, out _))
        {
            camposComErro.Add("DataInicialAej");
        }

        if (!DateTime.TryParse(cabecalhoAEJ.DataFinalAej, out _))
        {
            camposComErro.Add("DataFinalAej");
        }

        if (!DateTime.TryParse(cabecalhoAEJ.DataHoraGerAej, out _))
        {
            camposComErro.Add("DataHoraGerAej");
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
