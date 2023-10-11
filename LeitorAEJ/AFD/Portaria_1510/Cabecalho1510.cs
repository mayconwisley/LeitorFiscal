namespace LeitorAEJ.AFD.Portaria_1510;

public class Cabecalho1510
{
    /*Registro 1*/
    public string? Zeros { get; set; } = "000000000"; /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/
    public string? TpRegistro { get; set; }/*Tamanho: 1, Posição: 10 a 10, Tipo: numérico, Dado: = 1*/
    public string? TpIdentEmpregador { get; set; } /*Tamanho: 1, Posição: 11 a 11, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/
    public string? CnpjCpf { get; set; } /*Tamanho: 14, Posição: 12 a 25, Tipo: numérico*/
    public string? Cei { get; set; } /*Tamanho: 12, Posição: 26 a 37, Tipo: numérico*/
    public string? RazaoSocial { get; set; } /*Tamanho: 150, Posição: 38 a 187, Tipo: alfanumérico*/
    public string? NumeroFabRep { get; set; } /*Tamanho: 17, Posição: 188 a 204, Tipo: numérico*/
    public string? DataInicialRegistro { get; set; } /*Tamanho: 8, Posição: 205 a 212, Tipo: numérico, Formato: ddmmaaaa*/
    public string? DataFinalRegistro { get; set; } /*Tamanho: 8, Posição: 213 a 220, Tipo: numérico, Formato: ddmmaaaa*/
    public string? DataGeracao { get; set; } /*Tamanho: 8, Posição: 221 a 228, Tipo: numérico, Formato: ddmmaaaa*/
    public string? HoraGeracao { get; set; } /*Tamanho: 4, Posição: 229 a 232, Tipo: numérico, Formato: hhmm*/
    public string? Crc16 { get; set; } /*Tamanho: 4, Posição: 233 a 236, Tipo: alfanumérico*/

    public static void GetCabecalho(string linhaCabecalho)
    {
        
        Cabecalho1510 cabecalho = new()
        {
            Zeros = linhaCabecalho.Substring(0, 9),
            TpRegistro = linhaCabecalho.Substring(9, 1),
            TpIdentEmpregador = linhaCabecalho.Substring(10, 1),
            CnpjCpf = linhaCabecalho.Substring(11, 14),
            Cei = linhaCabecalho.Substring(25, 12),
            RazaoSocial = linhaCabecalho.Substring(37, 150),
            NumeroFabRep = linhaCabecalho.Substring(187, 17),
            DataInicialRegistro = linhaCabecalho.Substring(204, 8),
            DataFinalRegistro = linhaCabecalho.Substring(212, 8),
            DataGeracao = linhaCabecalho.Substring(220, 8),
            HoraGeracao = linhaCabecalho.Substring(228, 4),
           
        };
    }
}
