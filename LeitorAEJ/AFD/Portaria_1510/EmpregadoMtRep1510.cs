namespace LeitorAEJ.AFD.Portaria_1510;

public class EmpregadoMtRep1510
{
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 5*/
    public string? DataGravacao { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/
    public string? HoraGravacao { get; set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/
    public string? TpOperacao { get; set; } /*Tamanho: 1, Posição? 23 a 23, Tipo: alfanumérico, Dado: = I - Inclusão ou A - Alteracao ou E - Exclusão*/
    public string? Pis { get; set; } /*Tamanho: 12, Posição: 24 a 35, Tipo: numérico*/
    public string? Nome { get; set; } /*Tamanho: 52, Posição: 36 a 87, Tipo: alfanumérico*/
}
