using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class MarcacaoPontoAFD1510
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 3*/

    [MaxLength(8, ErrorMessage = "O campo DataMarcacao deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataMarcacao deve ter um comprimento minimo de '8'")]
    public string? DataMarcacao { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraMarcacao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraMarcacao deve ter um comprimento minimo de '4'")]
    public string? HoraMarcacao { get; set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/

    [MaxLength(12, ErrorMessage = "O campo Pis deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Pis deve ter um comprimento minimo de '12'")]
    public string? Pis { get; set; } /*Tamanho: 12, Posição: 23 a 34, Tipo: numérico*/

    public static List<MarcacaoPontoAFD1510> MarcacaoPontoAfdList { get; set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();
    public static string? Portaria { get; set; }

    public static void GetMarcacaoPonto(string linhaArquivo)
    {
        MarcacaoPontoAFD1510 marcacaoPonto;
        int tamanhoLinha = linhaArquivo.Length;
        if (tamanhoLinha != 34)
        {
            ErrosValidacao.Add($"O registro '3 - Marcação do Ponto' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 1510, de 21 de agosto de 2009. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria n.º 1510, de 21 de agosto de 2009\n";
            marcacaoPonto = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataMarcacao = linhaArquivo.Substring(10, 8),
                HoraMarcacao = linhaArquivo.Substring(18, 4),
                Pis = linhaArquivo.Substring(22, 12)
            };
        }
        if (ValidacaoTamanhoDado.ValidarTamanho(marcacaoPonto) && ValidarTipoDados(marcacaoPonto))
        {
            if (marcacaoPonto.TpRegistro != "3")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({marcacaoPonto.TpRegistro}) inválido, deve ter o valor '3'.\n");
                return;
            }

            MarcacaoPontoAfdList.Add(marcacaoPonto);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }

    }
    private static bool ValidarTipoDados(MarcacaoPontoAFD1510 marcacaoPonto1510)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(marcacaoPonto1510.Nsr, out _))
        {
            camposComErro.Add("Nsr");
        }

        if (!int.TryParse(marcacaoPonto1510.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(marcacaoPonto1510.DataMarcacao, out _))
        {
            camposComErro.Add("DataMarcacao");
        }

        if (!double.TryParse(marcacaoPonto1510.HoraMarcacao, out _))
        {
            camposComErro.Add("HoraMarcacao");
        }

        if (!double.TryParse(marcacaoPonto1510.Pis, out _))
        {
            camposComErro.Add("Pis");
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
