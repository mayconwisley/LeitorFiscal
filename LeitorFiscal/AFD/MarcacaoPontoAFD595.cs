using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class MarcacaoPontoAFD595
{

    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 3*/

    [MaxLength(8, ErrorMessage = "O campo DataMarcacao deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataMarcacao deve ter um comprimento minimo de '8'")]
    public string? DataMarcacao { get; private set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraMarcacao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraMarcacao deve ter um comprimento minimo de '4'")]
    public string? HoraMarcacao { get; private set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/

    [MaxLength(12, ErrorMessage = "O campo Pis deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Pis deve ter um comprimento minimo de '12'")]
    public string? Pis { get; private set; } /*Tamanho: 12, Posição: 23 a 34, Tipo: numérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; private set; } /*Tamanho: 4, Posição: 35 a 38, Tipo: alfanumérico*/

    public static List<MarcacaoPontoAFD595> MarcacaoPontoAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetMarcacaoPonto(string linhaArquivo)
    {
        MarcacaoPontoAFD595 marcacaoPonto;
        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 38)
        {
            ErrosValidacao.Add($"O registro '3 - Marcação do Ponto' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 595, de 05 de dezembro de 2013. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria n.º 595, de 05 de dezembro de 2013\n";
            marcacaoPonto = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataMarcacao = linhaArquivo.Substring(10, 8),
                HoraMarcacao = linhaArquivo.Substring(18, 4),
                Pis = linhaArquivo.Substring(22, 12),
                Crc16 = linhaArquivo.Substring(34, 4)
            };
        }
        if (ValidacaoTamanhoDado.ValidarTamanho(marcacaoPonto, linhaArquivo) && ValidarTipoDados(marcacaoPonto, linhaArquivo))
        {
            if (marcacaoPonto.TpRegistro != "3")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({marcacaoPonto.TpRegistro}) inválido, deve ter o valor '3'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }
            string validacaoPis = marcacaoPonto.Pis[..1];
            string pis = marcacaoPonto.Pis.Substring(1, 11);
            if (validacaoPis == "0")
            {
                bool ePis = ValidacaoPIS.Validar(pis);
                bool eCpf = ValidacaoCPF.Validar(pis);

                if (!ePis)
                {
                    if (eCpf)
                    {
                        ErrosValidacao.Add($"O campo 'Pis' esta indicado o valor 0(zero) no inicio, mas se trata de um Cpf\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                    }

                }
            }

            if (validacaoPis == "9")
            {
                bool ePis = ValidacaoPIS.Validar(pis);
                bool eCpf = ValidacaoCPF.Validar(pis);

                if (!eCpf)
                {
                    if (ePis)
                    {
                        ErrosValidacao.Add($"O campo 'Pis' esta indicado o valor 9(nove) no inicio, mas se trata de um Pis\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                    }

                }
            }
            MarcacaoPontoAfdList.Add(marcacaoPonto);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    private static bool ValidarTipoDados(MarcacaoPontoAFD595 marcacaoPonto1510, string linha)
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
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linha}\n");
            return false;
        }
    }
    #endregion
}
