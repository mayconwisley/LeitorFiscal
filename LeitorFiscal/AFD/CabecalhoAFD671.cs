using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class CabecalhoAFD671
{
    [MaxLength(9, ErrorMessage = "O campo Zeros deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Zeros deve ter um comprimento minimo de '9'")]
    public string? Zeros { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; }/*Tamanho: 1, Posição: 10 a 10, Tipo: numérico, Dado: = 1*/

    [MaxLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento minimo de '1'")]
    public string? TpIdentEmpregador { get; private set; } /*Tamanho: 1, Posição: 11 a 11, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/

    [MaxLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento minimo de '14'")]
    public string? CnpjCpf { get; private set; } /*Tamanho: 14, Posição: 12 a 25, Tipo: numérico*/

    [MaxLength(14, ErrorMessage = "O campo Cno deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo Cno deve ter um comprimento minimo de '14'")]
    public string? Cno { get; private set; } /*Tamanho: 14, Posição: 26 a 39, Tipo: numérico, Não Obrigatório*/

    [MaxLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento máximo de '150'")]
    [MinLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento minimo de '150'")]
    public string? RazaoSocial { get; private set; } /*Tamanho: 150, Posição: 38 a 187, Tipo: alfanumérico*/

    [MaxLength(17, ErrorMessage = "O campo NumeroFabRep deve ter um comprimento máximo de '17'")]
    [MinLength(17, ErrorMessage = "O campo NumeroFabRep deve ter um comprimento minimo de '17'")]
    public string? NumeroFabRep { get; private set; } /*Tamanho: 17, Posição: 188 a 204, Tipo: numérico*/

    [MaxLength(10, ErrorMessage = "O campo DataInicialRegistro671 deve ter um comprimento máximo de '10'")]
    [MinLength(10, ErrorMessage = "O campo DataInicialRegistro671 deve ter um comprimento minimo de '10'")]
    public string? DataInicialRegistro { get; private set; } /*Tamanho: 10, Posição: 207 a 216, Tipo: data, Formato: AAAA-MM-dd*/

    [MaxLength(10, ErrorMessage = "O campo DataFinalRegistro671 deve ter um comprimento máximo de '10'")]
    [MinLength(10, ErrorMessage = "O campo DataFinalRegistro671 deve ter um comprimento minimo de '10'")]
    public string? DataFinalRegistro { get; private set; } /*Tamanho: 10, Posição: 217 a 226, Tipo: data, Formato: AAAA-MM-dd*/

    [MaxLength(24, ErrorMessage = "O campo DataGeracao671 deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataGeracao671 deve ter um comprimento minimo de '24'")]
    public string? DataHoraGeracao { get; private set; } /*Tamanho: 24, Posição: 227 a 250, Tipo: datatime, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(3, ErrorMessage = "O campo VersaoAfd deve ter um comprimento máximo de '3'")]
    [MinLength(3, ErrorMessage = "O campo VersaoAfd deve ter um comprimento minimo de '3'")]
    public string? VersaoAfd { get; private set; } /*Tamanho: 3, Posição: 251 a 253, Tipo: numérico, Dado: = 003*/

    [MaxLength(1, ErrorMessage = "O campo TpIdentFabricante deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpIdentFabricante deve ter um comprimento minimo de '1'")]
    public string? TpIdentFabricante { get; private set; } /*Tamanho: 1, Posição: 254 a 254, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/

    [MaxLength(14, ErrorMessage = "O campo CnpjCpfFabricante deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CnpjCpfFabricante deve ter um comprimento minimo de '14'")]
    public string? CnpjCpfFabricante { get; private set; } /*Tamanho: 14, Posição: 255 a 268, Tipo: numérico*/

    [MaxLength(30, ErrorMessage = "O campo ModeloRep deve ter um comprimento máximo de '30'")]
    [MinLength(30, ErrorMessage = "O campo ModeloRep deve ter um comprimento minimo de '30'")]
    public string? ModeloRep { get; private set; } /*Tamanho: 30, Posição: 269 a 298, Tipo: alfanumérico, Apenas para o REP-C*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; private set; } /*Tamanho: 4, Posição: 233 a 236, Tipo: alfanumérico*/

    public static List<CabecalhoAFD671> CabecalhoAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; }

    #region Funções
    public static void GetCabecalho(string linhaArquivo)
    {
        CabecalhoAFD671 cabecalho;

        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 302)
        {
            ErrosValidacao.Add($"O registro '1 - Cabeçalho' possui o tamanho de caracteres diferentes que o definido pela a Portaria Nº 671, de 8 de novembro de 2021. Tamanho encontrado: {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria Nº 671, de 8 de novembro de 2021\n";

            cabecalho = new()
            {
                Zeros = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                TpIdentEmpregador = linhaArquivo.Substring(10, 1),
                CnpjCpf = linhaArquivo.Substring(11, 14),
                Cno = linhaArquivo.Substring(25, 14),
                RazaoSocial = linhaArquivo.Substring(39, 150),
                NumeroFabRep = linhaArquivo.Substring(189, 17),
                DataInicialRegistro = linhaArquivo.Substring(206, 10),
                DataFinalRegistro = linhaArquivo.Substring(216, 10),
                DataHoraGeracao = linhaArquivo.Substring(226, 24),
                VersaoAfd = linhaArquivo.Substring(250, 3),
                TpIdentFabricante = linhaArquivo.Substring(253, 1),
                CnpjCpfFabricante = linhaArquivo.Substring(254, 14),
                ModeloRep = linhaArquivo.Substring(268, 30),
                Crc16 = linhaArquivo.Substring(298, 4)
            };
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(cabecalho) && ValidarTipoDados(cabecalho))
        {
            if (cabecalho.Zeros != "000000000")
            {
                ErrosValidacao.Add($"O campo 'Zeros' esta com o valor ({cabecalho.Zeros}) inválido, deve ter o valor '000000000'.\n");
                return;
            }

            if (cabecalho.TpRegistro != "1")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({cabecalho.TpRegistro}) inválido, deve ter o valor '1'.\n");
                return;
            }

            if (cabecalho.TpIdentEmpregador != "1" && cabecalho.TpIdentEmpregador != "2")
            {
                ErrosValidacao.Add($"O campo 'TpIdentEmpregador' esta com o valor ({cabecalho.TpRegistro}) inválido, deve ter o valor '1' ou '2'.\n");
                return;
            }
            if (cabecalho.TpIdentFabricante != "1" && cabecalho.TpIdentFabricante != "2")
            {
                ErrosValidacao.Add($"O campo 'TpIdentFabricante' esta com o valor ({cabecalho.TpRegistro}) inválido, deve ter o valor '1' ou '2'.\n");
                return;
            }

            if (cabecalho.VersaoAfd != "003")
            {
                ErrosValidacao.Add($"O campo 'VersaoAfd' esta com o valor ({cabecalho.TpRegistro}) inválido, deve ter o valor '003'.\n");
                return;
            }

            CabecalhoAfdList.Add(cabecalho);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    private static bool ValidarTipoDados(CabecalhoAFD671 cabecalhoAFD)
    {
        var camposComErro = new List<string>();

        if (!int.TryParse(cabecalhoAFD.Zeros, out _))
        {
            camposComErro.Add("Zeros");
        }

        if (!int.TryParse(cabecalhoAFD.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(cabecalhoAFD.TpIdentEmpregador, out _))
        {
            camposComErro.Add("TpIdentEmpregador");
        }

        if (!double.TryParse(cabecalhoAFD.CnpjCpf, out _))
        {
            camposComErro.Add("CnpjCpf");
        }

        if (!double.TryParse(cabecalhoAFD.TpIdentFabricante, out _))
        {
            camposComErro.Add("TpIdentFabricante");
        }

        if (!double.TryParse(cabecalhoAFD.CnpjCpfFabricante, out _))
        {
            camposComErro.Add("CnpjCpfFabricante");
        }

        if (!string.IsNullOrWhiteSpace(cabecalhoAFD.Cno))
        {
            if (!double.TryParse(cabecalhoAFD.Cno, out _))
            {
                camposComErro.Add("Cno");
            }
        }

        if (!double.TryParse(cabecalhoAFD.NumeroFabRep, out _))
        {
            camposComErro.Add("NumeroFabRep");
        }

        if (!DateTime.TryParse(cabecalhoAFD.DataInicialRegistro, out _))
        {
            camposComErro.Add("DataInicialRegistro");
        }

        if (!DateTime.TryParse(cabecalhoAFD.DataInicialRegistro, out _))
        {
            camposComErro.Add("DataInicialRegistro671");
        }

        if (!DateTime.TryParse(cabecalhoAFD.DataFinalRegistro, out _))
        {
            camposComErro.Add("DataFinalRegistro671");
        }

        if (!DateTime.TryParse(cabecalhoAFD.DataHoraGeracao, out _))
        {
            camposComErro.Add("DataHoraGeracao671");
        }

        if (!DateTime.TryParse(cabecalhoAFD.DataFinalRegistro, out _))
        {
            camposComErro.Add("DataFinalRegistro");
        }

        if (!double.TryParse(cabecalhoAFD.VersaoAfd, out _))
        {
            camposComErro.Add("VersaoAfd");
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

