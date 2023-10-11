namespace LeitorAEJ.AFD.Portaria_1510;

public class TempoRealRep1510
{
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 4*/
    public string? DataAntesAjuste { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/
    public string? HoraAntesAjuste { get; set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/
    public string? DataAjustada { get; set; } /*Tamanho: 8, Posição: 23 a 30, Tipo: numérico, Formato: ddmmaaaa*/
    public string? HoraAjustada { get; set; } /*Tamanho: 4, Posição: 31 a 34, Tipo: numérico, Formato: hhmm*/
}
