using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class EmpregadoMtAFD671
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 5*/

    [MaxLength(24, ErrorMessage = "O campo DataHoraGravacao deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraGravacao deve ter um comprimento minimo de '24'")]
    public string? DataHoraGravacao { get; private set; } /*Tamanho: 24, Posição: 11 a 34, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(1, ErrorMessage = "O campo TpOperacao deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpOperacao deve ter um comprimento minimo de '1'")]
    public string? TpOperacao { get; private set; } /*Tamanho: 1, Posição? 35 a 35, Tipo: alfanumérico, Dado: = I - Inclusão ou A - Alteracao ou E - Exclusão*/

    [MaxLength(12, ErrorMessage = "O campo Pis deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Pis deve ter um comprimento minimo de '12'")]
    public string? Cpf { get; private set; } /*Tamanho: 12, Posição: 36 a 47, Tipo: numérico*/

    [MaxLength(52, ErrorMessage = "O campo Nome deve ter um comprimento máximo de '52'")]
    [MinLength(52, ErrorMessage = "O campo Nome deve ter um comprimento minimo de '52'")]
    public string? Nome { get; private set; } /*Tamanho: 52, Posição: 48 a 99, Tipo: alfanumérico*/

    [MaxLength(4, ErrorMessage = "O campo DadosIdentificacao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo DadosIdentificacao deve ter um comprimento minimo de '4'")]
    public string? DadosIdentificacao { get; private set; }/*Tamanho: 4, Posição: 100 a 103, Tipo: alfanumérico*/

    [MaxLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento máximo de '11'")]
    [MinLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento minimo de '11'")]
    public string? CpfResponsavel { get; private set; } /*Tamanho: 14, Posição: 104 a 114, Tipo: numérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; private set; } /*Tamanho: 4, Posição: 115 a 118, Tipo: alfanumérico*/

    public static List<EmpregadoMtAFD671> EmpregadoMtRepAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; } = string.Empty;

    #region Funções
    public static void GetEmpregadoMtRep(string linhaArquivo)
    {
        EmpregadoMtAFD671 empregadoMt;
        int tamanhoLinha = linhaArquivo.Length;
        
        if (tamanhoLinha != 118 && tamanhoLinha != 114)
        {
            ErrosValidacao.Add($"O registro '5 - Empregado MT' possui o tamanho de caracteres diferentes que o definido pela a Portaria Nº 671, de 8 de novembro de 2021. Tamanho encontrado: {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria Nº 671, de 8 de novembro de 2021\n";

            if (tamanhoLinha == 114)
            {
                empregadoMt = new()
                {
                    Nsr = linhaArquivo[..9],
                    TpRegistro = linhaArquivo.Substring(9, 1),
                    DataHoraGravacao = linhaArquivo.Substring(10, 24),
                    TpOperacao = linhaArquivo.Substring(34, 1),
                    Cpf = linhaArquivo.Substring(35, 12),
                    Nome = linhaArquivo.Substring(47, 52),
                    DadosIdentificacao = linhaArquivo.Substring(99, 4),
                    CpfResponsavel = linhaArquivo.Substring(103, 11)                  
                };
            }
            else
            {
                empregadoMt = new()
                {
                    Nsr = linhaArquivo[..9],
                    TpRegistro = linhaArquivo.Substring(9, 1),
                    DataHoraGravacao = linhaArquivo.Substring(10, 24),
                    TpOperacao = linhaArquivo.Substring(34, 1),
                    Cpf = linhaArquivo.Substring(35, 12),
                    Nome = linhaArquivo.Substring(47, 52),
                    DadosIdentificacao = linhaArquivo.Substring(99, 4),
                    CpfResponsavel = linhaArquivo.Substring(103, 11),
                    Crc16 = linhaArquivo.Substring(114, 4)
                };
            }
            
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(empregadoMt, linhaArquivo) && ValidarTipoDados(empregadoMt, linhaArquivo))
        {
            if (empregadoMt.TpRegistro != "5")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({empregadoMt.TpRegistro}) inválido, deve ter o valor '5'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            if (empregadoMt.TpOperacao != "I" && empregadoMt.TpOperacao != "A" && empregadoMt.TpOperacao != "E")
            {
                ErrosValidacao.Add($"O campo 'TpOperacao' esta com o valor ({empregadoMt.TpOperacao}) inválido, deve ter o valor 'I' ou 'A' ou 'E'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            string cpf = empregadoMt.Cpf.Substring(1, 11);

            bool eCpf = ValidacaoCPF.Validar(cpf);
            if (!eCpf)
            {
                ErrosValidacao.Add($"O campo 'Cpf' esta com o cpf inválido\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
            }


            EmpregadoMtRepAfdList.Add(empregadoMt);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }

    }
    private static bool ValidarTipoDados(EmpregadoMtAFD671 empregadoMtRep, string linha)
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

        if (!DateTime.TryParse(empregadoMtRep.DataHoraGravacao, out _))
        {
            camposComErro.Add("DataHoraGravacao");
        }

        if (!double.TryParse(empregadoMtRep.Cpf, out _))
        {
            camposComErro.Add("Cpf");
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
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linha}\n");
            return false;
        }
    }
    #endregion
}
