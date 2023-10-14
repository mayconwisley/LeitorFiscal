using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class EventosSensiveisRepAFD
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição: 10 a 10, Tipo: numérico, Dado: = 6*/

    [MaxLength(8, ErrorMessage = "O campo DataRegistro deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataRegistro deve ter um comprimento minimo de '8'")]
    public string? DataRegistro { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numerico*/

    [MaxLength(4, ErrorMessage = "O campo HoraRegistro deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraRegistro deve ter um comprimento minimo de '4'")]
    public string? HoraRegistro { get; set; } /*Tamanho: 4, POsição: 19 a 22, Tipo: numérico*/

    [MaxLength(2, ErrorMessage = "O campo TpEvento deve ter um comprimento máximo de '2'")]
    [MinLength(2, ErrorMessage = "O campo TpEvento deve ter um comprimento minimo de '2'")]
    public string? TpEvento { get; set; } /*Tamanho: 2, Posição: 23 a 24, Tipo: numérico*/
    /*  Tipo de evento, “01” para abertura do REP por 
        manutenção ou violação, “02” para retorno de energia, 
        “03” para introdução de dispositivo externo de 
        memória na Porta Fiscal, “04” para retirada de 
        dispositivo externo de memória na Porta Fiscal, “05” 
        para emissão da Relação Instantânea de Marcações e 
        “06” para erro de impressão.
     */


    public static List<EventosSensiveisRepAFD> EventosSensiveisRepAfdList { get; set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetEventosSensiveis(string linhaArquivo, bool portaria595)
    {
        EventosSensiveisRepAFD eventosSensiveis;
        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 24)
        {
            ErrosValidacao.Add($"O registro de '6 - Eventos Sensíveis' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 595, de 05 de dezembro de 2013: '24'. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }

        if (portaria595 == false)
        {
            ErrosValidacao.Add("Registro 6 - Eventos Sensíveis não faz parte da portaria 1510 de 21 de agosto de 2009\n");
        }
        eventosSensiveis = new()
        {
            Nsr = linhaArquivo[..9],
            TpRegistro = linhaArquivo.Substring(9, 1),
            DataRegistro = linhaArquivo.Substring(10, 8),
            HoraRegistro = linhaArquivo.Substring(18, 4),
            TpEvento = linhaArquivo.Substring(22, 2)
        };

        if (ValidacaoTamanhoDado.ValidarTamanho(eventosSensiveis) && ValidarTipoDados(eventosSensiveis))
        {
            if (eventosSensiveis.TpRegistro != "6")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({eventosSensiveis.TpRegistro}) inválido, deve ter o valor '6'.\n");
                return;
            }

            EventosSensiveisRepAfdList.Add(eventosSensiveis);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    private static bool ValidarTipoDados(EventosSensiveisRepAFD eventosSensiveis)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(eventosSensiveis.Nsr, out _))
        {
            camposComErro.Add("Nsr");
        }

        if (!int.TryParse(eventosSensiveis.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(eventosSensiveis.DataRegistro, out _))
        {
            camposComErro.Add("DataRegistro");
        }

        if (!double.TryParse(eventosSensiveis.HoraRegistro, out _))
        {
            camposComErro.Add("HoraRegistro");
        }

        if (!double.TryParse(eventosSensiveis.TpEvento, out _))
        {
            camposComErro.Add("TpEvento");
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
