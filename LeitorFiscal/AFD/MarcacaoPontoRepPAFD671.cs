using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class MarcacaoPontoRepPAFD671
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 7*/

    [MaxLength(24, ErrorMessage = "O campo DataHoraMarcacao deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraMarcacao deve ter um comprimento minimo de '24'")]
    public string? DataHoraMarcacao { get; private set; } /*Tamanho: 24, Posição: 11 a 34, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(12, ErrorMessage = "O campo Cpf deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Cpf deve ter um comprimento minimo de '12'")]
    public string? Cpf { get; private set; } /*Tamanho: 12, Posição: 35 a 46, Tipo: numérico*/

    [MaxLength(24, ErrorMessage = "O campo DataHoraGravacao deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraGravacao deve ter um comprimento minimo de '24'")]
    public string? DataHoraGravacao { get; private set; } /*Tamanho: 24, Posição: 47 a 70, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(2, ErrorMessage = "O campo IdentificadorColetor deve ter um comprimento máximo de '2'")]
    [MinLength(2, ErrorMessage = "O campo IdentificadorColetor deve ter um comprimento minimo de '2'")]
    public string? IdentificadorColetor { get; private set; } /*Tamanho: 2, Posição: 71 a 72, Tipo: numérico*/
    /*
      "01": aplicativomobile;
      "02": browser(navegador internet); 
      "03": aplicativodesktop; 
      "04": dispositivo eletrônico; 
      "05": outro dispositivo eletrônico não especificado acima.
     */

    [MaxLength(1, ErrorMessage = "O campo MarcacaoOnOff deve ter um comprimento máximo de '4'")]
    [MinLength(1, ErrorMessage = "O campo MarcacaoOnOff deve ter um comprimento minimo de '4'")]
    public string? MarcacaoOnOff { get; private set; } /*Tamanho: 1, Posição: 73 a 73, Tipo: numérico, Dado: Informar "0" para marcaçãoon-lineou "1" para marcaçãooff-line.*/

    [MaxLength(64, ErrorMessage = "O campo CódigoHash deve ter um comprimento máximo de '64'")]
    [MinLength(64, ErrorMessage = "O campo CódigoHash deve ter um comprimento minimo de '64'")]
    public string? CódigoHash { get; private set; } /*Tamanho: 64, Posição: 74 a 137, Tipo: alfanumérico*/

    public static List<MarcacaoPontoRepPAFD671> MarcacaoPontoRepPAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetMarcacaoPonto(string linhaArquivo)
    {
        MarcacaoPontoRepPAFD671 marcacaoPonto;
        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 137)
        {
            ErrosValidacao.Add($"O registro '7 - Marcação do Ponto' possui o tamanho de caracteres diferentes que o definido pela a Portaria Nº 671, de 8 de novembro de 2021. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria Nº 671, de 8 de novembro de 2021\n";
            marcacaoPonto = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataHoraMarcacao = linhaArquivo.Substring(10, 24),
                Cpf = linhaArquivo.Substring(34, 12),
                DataHoraGravacao = linhaArquivo.Substring(46, 24),
                IdentificadorColetor = linhaArquivo.Substring(70, 2),
                MarcacaoOnOff = linhaArquivo.Substring(72, 1),
                CódigoHash = linhaArquivo.Substring(73, 64)
            };
        }
        if (ValidacaoTamanhoDado.ValidarTamanho(marcacaoPonto, linhaArquivo) && ValidarTipoDados(marcacaoPonto, linhaArquivo))
        {
            if (marcacaoPonto.TpRegistro != "7")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({marcacaoPonto.TpRegistro}) inválido, deve ter o valor '7'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            if (marcacaoPonto.IdentificadorColetor != "01" && marcacaoPonto.IdentificadorColetor != "02" && marcacaoPonto.IdentificadorColetor != "03" &&
                marcacaoPonto.IdentificadorColetor != "04" && marcacaoPonto.IdentificadorColetor != "05")
            {
                ErrosValidacao.Add($"O campo 'IdentificadorColetor' esta com o valor ({marcacaoPonto.IdentificadorColetor}) inválido, deve ter o valor '01', '02', '03', '04' ou '05'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            if (marcacaoPonto.MarcacaoOnOff != "0" && marcacaoPonto.MarcacaoOnOff != "1")
            {
                ErrosValidacao.Add($"O campo 'MarcacaoOnOff' esta com o valor ({marcacaoPonto.MarcacaoOnOff}) inválido, deve ter o valor '1' ou '2'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            MarcacaoPontoRepPAfdList.Add(marcacaoPonto);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    private static bool ValidarTipoDados(MarcacaoPontoRepPAFD671 marcacaoPonto1510, string linha)
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

        if (!DateTime.TryParse(marcacaoPonto1510.DataHoraMarcacao, out _))
        {
            camposComErro.Add("DataHoraMarcacao");
        }

        if (!DateTime.TryParse(marcacaoPonto1510.DataHoraGravacao, out _))
        {
            camposComErro.Add("DataHoraGravacao");
        }

        if (!double.TryParse(marcacaoPonto1510.Cpf, out _))
        {
            camposComErro.Add("Cpf");
        }
        if (!double.TryParse(marcacaoPonto1510.IdentificadorColetor, out _))
        {
            camposComErro.Add("IdentificadorColetor");
        }

        if (!double.TryParse(marcacaoPonto1510.MarcacaoOnOff, out _))
        {
            camposComErro.Add("MarcacaoOnOff");
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
