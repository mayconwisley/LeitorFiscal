using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


}
