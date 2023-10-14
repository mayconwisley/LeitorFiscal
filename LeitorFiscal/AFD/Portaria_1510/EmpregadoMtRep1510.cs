using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD.Portaria_1510;

public class EmpregadoMtRep1510
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 5*/

    [MaxLength(8, ErrorMessage = "O campo DataGravacao deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataGravacao deve ter um comprimento minimo de '8'")]
    public string? DataGravacao { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraGravacao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraGravacao deve ter um comprimento minimo de '4'")]
    public string? HoraGravacao { get; set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/

    [MaxLength(1, ErrorMessage = "O campo TpOperacao deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpOperacao deve ter um comprimento minimo de '1'")]
    public string? TpOperacao { get; set; } /*Tamanho: 1, Posição? 23 a 23, Tipo: alfanumérico, Dado: = I - Inclusão ou A - Alteracao ou E - Exclusão*/

    [MaxLength(12, ErrorMessage = "O campo Pis deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Pis deve ter um comprimento minimo de '12'")]
    public string? Pis { get; set; } /*Tamanho: 12, Posição: 24 a 35, Tipo: numérico*/

    [MaxLength(52, ErrorMessage = "O campo Nome deve ter um comprimento máximo de '52'")]
    [MinLength(52, ErrorMessage = "O campo Nome deve ter um comprimento minimo de '52'")]
    public string? Nome { get; set; } /*Tamanho: 52, Posição: 36 a 87, Tipo: alfanumérico*/

    [MaxLength(4, ErrorMessage = "O campo DadosIdentificacao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo DadosIdentificacao deve ter um comprimento minimo de '4'")]
    public string? DadosIdentificacao { get; set; }/*Tamanho: 4, Posição: 88 a 91, Tipo: alfanumérico*/

    [MaxLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento máximo de '11'")]
    [MinLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento minimo de '11'")]
    public string? CpfResponsavel { get; set; } /*Tamanho: 14, Posição: 92 a 102, Tipo: numérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; set; } /*Tamanho: 4, Posição: 103 a 106, Tipo: alfanumérico*/

    public static List<EmpregadoMtRep1510> EmpregadoMtRep1510List { get; set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetEmpregadoMtRep(string linhaArquivo, bool portaria595)
    {
        EmpregadoMtRep1510 empregadoMt;
        int tamanhoLinha = linhaArquivo.Length;


        if (portaria595)
        {
            if (tamanhoLinha != 106)
            {
                ErrosValidacao.Add($"O registro de '5 - Empregado MT' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 595, de 05 de dezembro de 2013: '106'. Tamanho encontrado: {tamanhoLinha}\n");
                return;
            }
            empregadoMt = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataGravacao = linhaArquivo.Substring(10, 8),
                HoraGravacao = linhaArquivo.Substring(18, 4),
                TpOperacao = linhaArquivo.Substring(22, 1),
                Pis = linhaArquivo.Substring(23, 12),
                Nome = linhaArquivo.Substring(35, 52),
                DadosIdentificacao = linhaArquivo.Substring(87, 4),
                CpfResponsavel = linhaArquivo.Substring(91, 11),
                Crc16 = linhaArquivo.Substring(102, 4)
            };
        }
        else
        {
            if (tamanhoLinha != 87)
            {
                ErrosValidacao.Add($"O registro de '5 - Empregado MT' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 1510, de 21 de agosto de 2009: '87'. Tamanho encontrado: {tamanhoLinha}\n");
                return;
            }
            empregadoMt = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataGravacao = linhaArquivo.Substring(10, 8),
                HoraGravacao = linhaArquivo.Substring(18, 4),
                TpOperacao = linhaArquivo.Substring(22, 1),
                Pis = linhaArquivo.Substring(23, 12),
                Nome = linhaArquivo.Substring(35, 52)
            };

        }




        if (ValidacaoTamanhoDado.ValidarTamanho(empregadoMt) && ValidarTipoDados(empregadoMt))
        {
            if (empregadoMt.TpRegistro != "5")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({empregadoMt.TpRegistro}) inválido, deve ter o valor '5'.\n");
                return;
            }

            EmpregadoMtRep1510List.Add(empregadoMt);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }

    }
    private static bool ValidarTipoDados(EmpregadoMtRep1510 empregadoMtRep)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(empregadoMtRep.Nsr, out _))
        {
            camposComErro.Add("Nsr");
        }

        if (!int.TryParse(empregadoMtRep.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(empregadoMtRep.DataGravacao, out _))
        {
            camposComErro.Add("DataGravacao");
        }

        if (!double.TryParse(empregadoMtRep.HoraGravacao, out _))
        {
            camposComErro.Add("HoraGravacao");
        }

        if (!double.TryParse(empregadoMtRep.Pis, out _))
        {
            camposComErro.Add("Pis");
        }
        if (!string.IsNullOrWhiteSpace(empregadoMtRep.CpfResponsavel))
        {
            if (!double.TryParse(empregadoMtRep.CpfResponsavel, out _))
            {
                camposComErro.Add("CpfResponsavel");
            }
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
