using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class MarcacaoPontoAFD671
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 3*/

    [MaxLength(24, ErrorMessage = "O campo DataMarcacao deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataMarcacao deve ter um comprimento minimo de '24'")]
    public string? DataHoraMarcacao { get; private set; } /*Tamanho: 24, Posição: 11 a 34, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(12, ErrorMessage = "O campo Pis deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Pis deve ter um comprimento minimo de '12'")]
    public string? Cpf { get; private set; } /*Tamanho: 12, Posição: 35 a 46, Tipo: numérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; private set; } /*Tamanho: 4, Posição: 47 a 50, Tipo: alfanumérico*/

    public static List<MarcacaoPontoAFD671> MarcacaoPontoAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new() ;
    public static string? Portaria { get; set; } = string.Empty;
    #region Funções
    public static void GetMarcacaoPonto(string linhaArquivo)
    {
        MarcacaoPontoAFD671 marcacaoPonto;
        int tamanhoLinha = linhaArquivo.Length;
        if (tamanhoLinha != 50 && tamanhoLinha != 46)
        {
            ErrosValidacao.Add($"O registro '3 - Marcação do Ponto' possui o tamanho de caracteres diferentes que o definido pela a Portaria Nº 671, de 8 de novembro de 2021. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria Nº 671, de 8 de novembro de 2021\n";

            if (tamanhoLinha == 46)
            {
                marcacaoPonto = new()
                {
                    Nsr = linhaArquivo[..9],
                    TpRegistro = linhaArquivo.Substring(9, 1),
                    DataHoraMarcacao = linhaArquivo.Substring(10, 24),
                    Cpf = linhaArquivo.Substring(34, 12)                  
                };
            }
            else
            {
                marcacaoPonto = new()
                {
                    Nsr = linhaArquivo[..9],
                    TpRegistro = linhaArquivo.Substring(9, 1),
                    DataHoraMarcacao = linhaArquivo.Substring(10, 24),
                    Cpf = linhaArquivo.Substring(34, 12),
                    Crc16 = linhaArquivo.Substring(46, 4)
                };
            }
            
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(marcacaoPonto, linhaArquivo) && ValidarTipoDados(marcacaoPonto, linhaArquivo))
        {
            if (marcacaoPonto.TpRegistro != "3")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({marcacaoPonto.TpRegistro}) inválido, deve ter o valor '3'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            string cpf = marcacaoPonto.Cpf.Substring(1, 11);


            bool eCpf = ValidacaoCPF.Validar(cpf);

            if (!eCpf)
            {
                ErrosValidacao.Add($"O campo 'Cpf' esta com o cpf inválido\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
            }



            MarcacaoPontoAfdList.Add(marcacaoPonto);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }

    }
    private static bool ValidarTipoDados(MarcacaoPontoAFD671 marcacaoPonto1510, string linha)
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



        if (!double.TryParse(marcacaoPonto1510.Cpf, out _))
        {
            camposComErro.Add("Cpf");
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
