namespace LeitorAEJ.AFD.Portaria_1510;

public class EventosSensiveisRep1510
{
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição: 10 a 10, Tipo: numérico, Dado: = 6*/
    public string? DataRegistro { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numerico*/
    public string? HoraRegistro { get; set; } /*Tamanho: 4, POsição: 19 a 22, Tipo: numérico*/
    public string? TpEvento { get; set; } /*Tamanho: 2, Posição: 23 a 24, Tipo: numérico*/
    /*  Tipo de evento, “01” para abertura do REP por 
        manutenção ou violação, “02” para retorno de energia, 
        “03” para introdução de dispositivo externo de 
        memória na Porta Fiscal, “04” para retirada de 
        dispositivo externo de memória na Porta Fiscal, “05” 
        para emissão da Relação Instantânea de Marcações e 
        “06” para erro de impressão.
     */

    public static List<EventosSensiveisRep1510> EventosSensiveisRep1510List { get; set; } = new();
    public static void GetEventosSensiveis(string linhaCabecalho)
    {
        EventosSensiveisRep1510 eventosSensiveis = new()
        {
            Nsr = linhaCabecalho.Substring(0, 9).Trim(),
            TpRegistro = linhaCabecalho.Substring(9, 1).Trim(),
            DataRegistro = linhaCabecalho.Substring(10, 8).Trim(),
            HoraRegistro = linhaCabecalho.Substring(18, 4).Trim(),
            TpEvento = linhaCabecalho.Substring(22, 2).Trim()
        };

        EventosSensiveisRep1510List.Add(eventosSensiveis);
    }
}
