namespace LeitorAEJ.AFD.Portaria_1510;

public class IdentificacaoEmpresaRep1510
{
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 2*/
    public string? DataGravacao { get; set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/
    public string? HoraGravacao { get; set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/
    public string? TpIdentEmpregador { get; set; } /*Tamanho: 1, Posição: 23 a 23, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/
    public string? CnpjCpf { get; set; } /*Tamanho: 14, Posição: 24 a 37, Tipo: numérico*/
    public string? Cei { get; set; } /*Tamanho: 12, Posição: 38 a 49, Tipo: numérico*/
    public string? RazaoSocial { get; set; } /*Tamanho: 150, Posição: 50 a 199, Tipo: alfanumérico*/
    public string? LocalPrestServico { get; set; } /*Tamanho: 100, Posição: 200 a 299, Tipo: alfanumérico*/
}
