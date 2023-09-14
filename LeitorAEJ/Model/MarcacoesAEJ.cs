using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class MarcacoesAEJ
{
    [MaxLength(2)]
    public string? TipoReg { get; private set; }
    [MaxLength(9)]
    public string? IdtVinculoAej { get; private set; }
    [MaxLength(24)]
    public string? DataHoraMarc { get; private set; }
    [MaxLength(9)]
    public string? IdRepAej { get; private set; }
    [MaxLength(1)]
    public string? TpMarc { get; private set; }
    [MaxLength(3)]
    public string? SeqEntSaida { get; private set; }
    [MaxLength(1)]
    public string? FonteMarc { get; private set; }
    [MaxLength(30)]
    public string? CodHorContratual { get; private set; }
    [MaxLength(150)]
    public string? Motivo { get; private set; }

    public static List<MarcacoesAEJ> MarcacoesAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetMarcacoes(string linhaMarcacoes, bool validarPortaria)
    {
        string[] itemLinha = linhaMarcacoes.Split("|");
        ErrosValidacao.Clear();

        var marcacoes = new MarcacoesAEJ
        {
            TipoReg = itemLinha[0],
            IdtVinculoAej = itemLinha[1],
            DataHoraMarc = itemLinha[2],
            IdRepAej = itemLinha[3],
            TpMarc = itemLinha[4],
            SeqEntSaida = itemLinha[5],
            FonteMarc = itemLinha[6],
            CodHorContratual = itemLinha[7],
            Motivo = itemLinha[8]
        };
        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(marcacoes) && ValidarTipoDados(marcacoes))
            {
                MarcacoesAEJList.Add(marcacoes);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item);
            }
        }
        else
        {
            MarcacoesAEJList.Add(marcacoes);
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
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}");
            return false;
        }
    }
}
