using LeitorFiscal.Model.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorFiscal.AFD;

public class IdentificacaoEmpresaAFD671
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 2*/

    [MaxLength(24, ErrorMessage = "O campo DataHoraGravacao deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraGravacao deve ter um comprimento minimo de '24'")]
    public string? DataHoraGravacao { get; set; } /*Tamanho: 24, Posição: 11 a 34, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(14, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento minimo de '14'")]
    public string? CpfResponsavel { get; set; } /*Tamanho: 14, Posição: 35 a 48, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento minimo de '1'")]
    public string? TpIdentEmpregador { get; set; } /*Tamanho: 1, Posição: 49 a 49, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/

    [MaxLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento minimo de '14'")]
    public string? CnpjCpf { get; set; } /*Tamanho: 14, Posição: 50 a 63, Tipo: numérico*/

    [MaxLength(14, ErrorMessage = "O campo Cei deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo Cei deve ter um comprimento minimo de '14'")]
    public string? Cno { get; set; } /*Tamanho: 14, Posição: 64 a 77, Tipo: numérico, Não Obrigatório*/

    [MaxLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento máximo de '150'")]
    [MinLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento minimo de '150'")]
    public string? RazaoSocial { get; set; } /*Tamanho: 150, Posição: 78 a 227, Tipo: alfanumérico*/

    [MaxLength(100, ErrorMessage = "O campo LocalPrestServico deve ter um comprimento máximo de '100'")]
    [MinLength(100, ErrorMessage = "O campo LocalPrestServico deve ter um comprimento minimo de '100'")]
    public string? LocalPrestServico { get; set; } /*Tamanho: 100, Posição: 228 a 327, Tipo: alfanumérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; set; } /*Tamanho: 4, Posição: 328 a 331, Tipo: alfanumérico*/

    public static List<IdentificacaoEmpresaAFD671> IdentificacaoEmpresaRepAfdList { get; set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetIdentificadorEmpresa(string linhaArquivo)
    {
        IdentificacaoEmpresaAFD671 identificacaoEmpresa;
        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 331)
        {
            ErrosValidacao.Add($"O registro '2 - Identificação da Empresa' possui o tamanho de caracteres diferentes que o definido pela a Portaria Nº 671, de 8 de novembro de 2021. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria Nº 671, de 8 de novembro de 2021\n";

            identificacaoEmpresa = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataHoraGravacao = linhaArquivo.Substring(10, 24),
                CpfResponsavel = linhaArquivo.Substring(34, 14),
                TpIdentEmpregador = linhaArquivo.Substring(48, 1),
                CnpjCpf = linhaArquivo.Substring(49, 14),
                Cno = linhaArquivo.Substring(63, 14),
                RazaoSocial = linhaArquivo.Substring(77, 150),
                LocalPrestServico = linhaArquivo.Substring(227, 100),
                Crc16 = linhaArquivo.Substring(327, 4)
            };
        }
        if (ValidacaoTamanhoDado.ValidarTamanho(identificacaoEmpresa) && ValidarTipoDados(identificacaoEmpresa))
        {
            if (identificacaoEmpresa.TpRegistro != "2")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({identificacaoEmpresa.TpRegistro}) inválido, deve ter o valor '2'.\n");
                return;
            }

            if (identificacaoEmpresa.TpIdentEmpregador != "2" && identificacaoEmpresa.TpIdentEmpregador != "1")
            {
                ErrosValidacao.Add($"O campo 'TpIdentEmpregador' esta com o valor ({identificacaoEmpresa.TpIdentEmpregador}) inválido, deve ter o valor '1' ou '2'.\n");
                return;
            }

            IdentificacaoEmpresaRepAfdList.Add(identificacaoEmpresa);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }

    }
    private static bool ValidarTipoDados(IdentificacaoEmpresaAFD671 identificacaoEmpresa)
    {
        var camposComErro = new List<string>();

        if (!int.TryParse(identificacaoEmpresa.Nsr, out _))
        {
            camposComErro.Add("Nsr");
        }

        if (!int.TryParse(identificacaoEmpresa.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!DateTime.TryParse(identificacaoEmpresa.DataHoraGravacao, out _))
        {
            camposComErro.Add("DataHoraGravacao");
        }
      
        if (!string.IsNullOrWhiteSpace(identificacaoEmpresa.CpfResponsavel))
        {
            if (!double.TryParse(identificacaoEmpresa.CpfResponsavel, out _))
            {
                camposComErro.Add("CpfResponsavel");
            }
        }

        if (!double.TryParse(identificacaoEmpresa.TpIdentEmpregador, out _))
        {
            camposComErro.Add("TpIdentEmpregador");
        }
        if (!double.TryParse(identificacaoEmpresa.CnpjCpf, out _))
        {
            camposComErro.Add("CnpjCpf");
        }

        if (!string.IsNullOrWhiteSpace(identificacaoEmpresa.Cno))
        {
            if (!double.TryParse(identificacaoEmpresa.Cno, out _))
            {
                camposComErro.Add("Cno");
            }
        }

        if (!string.IsNullOrWhiteSpace(identificacaoEmpresa.Crc16))
        {
            if (!double.TryParse(identificacaoEmpresa.Crc16, out _))
            {
                camposComErro.Add("Crc16");
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
    #endregion
}
