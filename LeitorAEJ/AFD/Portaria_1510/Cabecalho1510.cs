using LeitorAEJ.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.AFD.Portaria_1510;

public class Cabecalho1510
{
    [MaxLength(9, ErrorMessage = "O campo Zeros deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Zeros deve ter um comprimento minimo de '9'")]
    public string? Zeros { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; }/*Tamanho: 1, Posição: 10 a 10, Tipo: numérico, Dado: = 1*/

    [MaxLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento minimo de '1'")]
    public string? TpIdentEmpregador { get; set; } /*Tamanho: 1, Posição: 11 a 11, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/

    [MaxLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento minimo de '14'")]
    public string? CnpjCpf { get; set; } /*Tamanho: 14, Posição: 12 a 25, Tipo: numérico*/

    [MaxLength(12, ErrorMessage = "O campo Cei deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Cei deve ter um comprimento minimo de '12'")]
    public string? Cei { get; set; } /*Tamanho: 12, Posição: 26 a 37, Tipo: numérico, Não Obrigatório*/

    [MaxLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento máximo de '150'")]
    [MinLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento minimo de '150'")]
    public string? RazaoSocial { get; set; } /*Tamanho: 150, Posição: 38 a 187, Tipo: alfanumérico*/

    [MaxLength(17, ErrorMessage = "O campo NumeroFabRep deve ter um comprimento máximo de '17'")]
    [MinLength(17, ErrorMessage = "O campo NumeroFabRep deve ter um comprimento minimo de '17'")]
    public string? NumeroFabRep { get; set; } /*Tamanho: 17, Posição: 188 a 204, Tipo: numérico*/

    [MaxLength(8, ErrorMessage = "O campo DataInicialRegistro deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataInicialRegistro deve ter um comprimento minimo de '8'")]
    public string? DataInicialRegistro { get; set; } /*Tamanho: 8, Posição: 205 a 212, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(8, ErrorMessage = "O campo DataFinalRegistro deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataFinalRegistro deve ter um comprimento minimo de '8'")]
    public string? DataFinalRegistro { get; set; } /*Tamanho: 8, Posição: 213 a 220, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(8, ErrorMessage = "O campo DataGeracao deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataGeracao deve ter um comprimento minimo de '8'")]
    public string? DataGeracao { get; set; } /*Tamanho: 8, Posição: 221 a 228, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraGeracao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraGeracao deve ter um comprimento minimo de '4'")]
    public string? HoraGeracao { get; set; } /*Tamanho: 4, Posição: 229 a 232, Tipo: numérico, Formato: hhmm*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; set; } /*Tamanho: 4, Posição: 233 a 236, Tipo: alfanumérico*/

    public static List<Cabecalho1510> Cabecalho1510List { get; set; } = new();

    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetCabecalho(string linhaArquivo, bool portaria595)
    {
        Cabecalho1510 cabecalho;

        int tamanhoLinha = linhaArquivo.Length;
        
            if (portaria595)
            {
                if (tamanhoLinha != 236)
                {
                    ErrosValidacao.Add($"O registro de '1 - Cabeçalho' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 595, de 05 de dezembro de 2013: '236'. Tamanho encontrado: {tamanhoLinha}\n");
                    return;
                }

                cabecalho = new()
                {
                    Zeros = linhaArquivo[..9],
                    TpRegistro = linhaArquivo.Substring(9, 1),
                    TpIdentEmpregador = linhaArquivo.Substring(10, 1),
                    CnpjCpf = linhaArquivo.Substring(11, 14),
                    Cei = linhaArquivo.Substring(25, 12),
                    RazaoSocial = linhaArquivo.Substring(37, 150),
                    NumeroFabRep = linhaArquivo.Substring(187, 17),
                    DataInicialRegistro = linhaArquivo.Substring(204, 8),
                    DataFinalRegistro = linhaArquivo.Substring(212, 8),
                    DataGeracao = linhaArquivo.Substring(220, 8),
                    HoraGeracao = linhaArquivo.Substring(228, 4),
                    Crc16 = linhaArquivo.Substring(232, 4)
                };
            }
            else
            {
                if (tamanhoLinha != 232)
                {
                    ErrosValidacao.Add($"O registro de '1 - Cabeçalho' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 1510, de 21 de agosto de 2009: '232'. Tamanho encontrado: {tamanhoLinha}\n");
                    return;
                }

                cabecalho = new()
                {
                    Zeros = linhaArquivo[..9],
                    TpRegistro = linhaArquivo.Substring(9, 1),
                    TpIdentEmpregador = linhaArquivo.Substring(10, 1),
                    CnpjCpf = linhaArquivo.Substring(11, 14),
                    Cei = linhaArquivo.Substring(25, 12),
                    RazaoSocial = linhaArquivo.Substring(37, 150),
                    NumeroFabRep = linhaArquivo.Substring(187, 17),
                    DataInicialRegistro = linhaArquivo.Substring(204, 8),
                    DataFinalRegistro = linhaArquivo.Substring(212, 8),
                    DataGeracao = linhaArquivo.Substring(220, 8),
                    HoraGeracao = linhaArquivo.Substring(228, 4)

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

                Cabecalho1510List.Add(cabecalho);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item + "\n");
            }
       

    }
    private static bool ValidarTipoDados(Cabecalho1510 cabecalho1510)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(cabecalho1510.Zeros, out _))
        {
            camposComErro.Add("Zeros");
        }

        if (!int.TryParse(cabecalho1510.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(cabecalho1510.TpIdentEmpregador, out _))
        {
            camposComErro.Add("TpIdentEmpregador");
        }

        if (!double.TryParse(cabecalho1510.CnpjCpf, out _))
        {
            camposComErro.Add("CnpjCpf");
        }

        if (!string.IsNullOrWhiteSpace(cabecalho1510.Cei))
        {
            if (!double.TryParse(cabecalho1510.Cei, out _))
            {
                camposComErro.Add("Cei");
            }

        }

        if (!double.TryParse(cabecalho1510.NumeroFabRep, out _))
        {
            camposComErro.Add("NumeroFabRep");
        }

        if (!double.TryParse(cabecalho1510.DataInicialRegistro, out _))
        {
            camposComErro.Add("DataInicialRegistro");
        }

        if (!double.TryParse(cabecalho1510.DataGeracao, out _))
        {
            camposComErro.Add("DataGeracao");
        }

        if (!double.TryParse(cabecalho1510.HoraGeracao, out _))
        {
            camposComErro.Add("HoraGeracao");
        }

        if (!double.TryParse(cabecalho1510.DataFinalRegistro, out _))
        {
            camposComErro.Add("DataFinalRegistro");
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
