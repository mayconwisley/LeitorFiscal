using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class IdentificacaoEmpresaAFD595
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 2*/

    [MaxLength(8, ErrorMessage = "O campo DataGravacao deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataGravacao deve ter um comprimento minimo de '8'")]
    public string? DataGravacao { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraGravacao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraGravacao deve ter um comprimento minimo de '4'")]
    public string? HoraGravacao { get; set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/

    [MaxLength(14, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento minimo de '14'")]
    public string? CpfResponsavel { get; set; } /*Tamanho: 14, Posição: 23 a 36, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento minimo de '1'")]
    public string? TpIdentEmpregador { get; set; } /*Tamanho: 1, Posição: 37 a 37, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/

    [MaxLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento minimo de '14'")]
    public string? CnpjCpf { get; set; } /*Tamanho: 14, Posição: 38 a 51, Tipo: numérico*/

    [MaxLength(12, ErrorMessage = "O campo Cei deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Cei deve ter um comprimento minimo de '12'")]
    public string? Cei { get; set; } /*Tamanho: 12, Posição: 52 a 63, Tipo: numérico, Não Obrigatório*/

    [MaxLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento máximo de '150'")]
    [MinLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento minimo de '150'")]
    public string? RazaoSocial { get; set; } /*Tamanho: 150, Posição: 64 a 213, Tipo: alfanumérico*/

    [MaxLength(100, ErrorMessage = "O campo LocalPrestServico deve ter um comprimento máximo de '100'")]
    [MinLength(100, ErrorMessage = "O campo LocalPrestServico deve ter um comprimento minimo de '100'")]
    public string? LocalPrestServico { get; set; } /*Tamanho: 100, Posição: 214 a 313, Tipo: alfanumérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; set; } /*Tamanho: 4, Posição: 314 a 317, Tipo: alfanumérico*/

    public static List<IdentificacaoEmpresaAFD595> IdentificacaoEmpresaRepAfdList { get; set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetIdentificadorEmpresa(string linhaArquivo)
    {
        IdentificacaoEmpresaAFD595 identificacaoEmpresa;
        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 317)
        {
            ErrosValidacao.Add($"O registro '2 - Identificação da Empresa' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 595, de 05 de dezembro de 2013. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria n.º 595, de 05 de dezembro de 2013\n";

            identificacaoEmpresa = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataGravacao = linhaArquivo.Substring(10, 8),
                HoraGravacao = linhaArquivo.Substring(18, 4),
                CpfResponsavel = linhaArquivo.Substring(22, 14),
                TpIdentEmpregador = linhaArquivo.Substring(36, 1),
                CnpjCpf = linhaArquivo.Substring(37, 14),
                Cei = linhaArquivo.Substring(51, 12),
                RazaoSocial = linhaArquivo.Substring(63, 150),
                LocalPrestServico = linhaArquivo.Substring(213, 100),
                Crc16 = linhaArquivo.Substring(313, 4)
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
    private static bool ValidarTipoDados(IdentificacaoEmpresaAFD595 identificacaoEmpresa)
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

        if (!double.TryParse(identificacaoEmpresa.DataGravacao, out _))
        {
            camposComErro.Add("DataGravacao");
        }

        if (!double.TryParse(identificacaoEmpresa.HoraGravacao, out _))
        {
            camposComErro.Add("HoraGravacao");
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

        if (!string.IsNullOrWhiteSpace(identificacaoEmpresa.Cei))
        {
            if (!double.TryParse(identificacaoEmpresa.Cei, out _))
            {
                camposComErro.Add("Cei");
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
