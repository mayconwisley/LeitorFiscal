using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.LeituraArquivo.Enum;

namespace LeitorFiscal.AFD;

public class ProcessarGets
{
    public static int CountIdentEmpresa { get; set; } = 0;
    public static int CountMarcacaoPonto { get; set; } = 0;
    public static int CountTempoReal { get; set; } = 0;
    public static int CountEmpregadoMt { get; set; } = 0;
    public static int CountEventoSensiveis { get; set; } = 0;
    public static int CountMarcacaoPontoRepP { get; set; } = 0;
    public static int Trailer { get; set; } = 0;

    public static bool ProcessarCabecalho(string linha)
    {
        return ProcessarRegistro(linha, CabecalhoAFD1510.GetCabecalho, CabecalhoAFD595.GetCabecalho, CabecalhoAFD671.GetCabecalho);
    }

    public static bool ProcessarIdentificacaoEmpresa(string linha)
    {
        CountIdentEmpresa++;
        return ProcessarRegistro(linha, IdentificacaoEmpresaAFD1510.GetIdentificadorEmpresa, IdentificacaoEmpresaAFD595.GetIdentificadorEmpresa, IdentificacaoEmpresaAFD671.GetIdentificadorEmpresa);
    }

    public static bool ProcessarMarcacaoPonto(string linha)
    {
        CountMarcacaoPonto++;
        return ProcessarRegistro(linha, MarcacaoPontoAFD1510.GetMarcacaoPonto, MarcacaoPontoAFD595.GetMarcacaoPonto, MarcacaoPontoAFD671.GetMarcacaoPonto);
    }

    public static bool ProcessarAjusteRelogio(string linha)
    {
        CountTempoReal++;
        return ProcessarRegistro(linha, TempoRealAFD1510.GetTempoReal, TempoRealAFD595.GetTempoReal, TempoRealAFD671.GetTempoReal);
    }

    public static bool ProcessarEmpregado(string linha)
    {
        CountEmpregadoMt++;
        return ProcessarRegistro(linha, EmpregadoMtAFD1510.GetEmpregadoMtRep, EmpregadoMtAFD595.GetEmpregadoMtRep, EmpregadoMtAFD671.GetEmpregadoMtRep);
    }

    public static bool ProcessarEventoSensivel(string linha)
    {
        CountEventoSensiveis++;
        return ProcessarRegistro(linha, EventosSensiveisAFD595.GetEventosSensiveis, EventosSensiveisAFD671.GetEventosSensiveis);
    }

    public static bool ProcessarMarcacaoPontoRepP(string linha)
    {
        CountMarcacaoPontoRepP++;
        return ProcessarRegistro(linha, MarcacaoPontoRepPAFD671.GetMarcacaoPonto);
    }

    public static bool ProcessarTrailer(string linha)
    {
        Trailer++;
        return ProcessarRegistro(linha, TrailerAFD1510.GetTrailer, TrailerAFD595.GetTrailer, TrailerAFD671.GetTrailer);
    }
    private static bool ProcessarRegistro(string linha, params Action<string>[] actions)
    {
        foreach (var action in actions)
        {
            var length = linha.Length;
            if ((length == 232 && action == CabecalhoAFD1510.GetCabecalho) ||
                (length == 236 && action == CabecalhoAFD595.GetCabecalho) ||
                (length == 298 || length == 302 && action == CabecalhoAFD671.GetCabecalho) ||
                (length == 299 && action == IdentificacaoEmpresaAFD1510.GetIdentificadorEmpresa) ||
                (length == 317 && action == IdentificacaoEmpresaAFD595.GetIdentificadorEmpresa) ||
                (length == 327 || length == 331 && action == IdentificacaoEmpresaAFD671.GetIdentificadorEmpresa) ||
                (length == 34 && action == MarcacaoPontoAFD1510.GetMarcacaoPonto) ||
                (length == 38 && action == MarcacaoPontoAFD595.GetMarcacaoPonto) ||
                (length == 46 || length == 50 && action == MarcacaoPontoAFD671.GetMarcacaoPonto) ||
                (length == 34 && action == TempoRealAFD1510.GetTempoReal) ||
                (length == 49 && action == TempoRealAFD595.GetTempoReal) ||
                (length == 69 || length == 73 && action == TempoRealAFD671.GetTempoReal) ||
                (length == 87 && action == EmpregadoMtAFD1510.GetEmpregadoMtRep) ||
                (length == 106 && action == EmpregadoMtAFD595.GetEmpregadoMtRep) ||
                (length == 114 || length == 118 && action == EmpregadoMtAFD671.GetEmpregadoMtRep) ||
                (length == 24 && action == EventosSensiveisAFD595.GetEventosSensiveis) ||
                (length == 36 && action == EventosSensiveisAFD671.GetEventosSensiveis) ||
                (length == 133 || length == 137 && action == MarcacaoPontoRepPAFD671.GetMarcacaoPonto) ||
                (length == 46 && action == TrailerAFD1510.GetTrailer) ||
                (length == 55 && action == TrailerAFD595.GetTrailer) ||
                (length == 60 || length == 64 && action == TrailerAFD671.GetTrailer))
            {
                action(linha);
                return true;
            }
        }
        return false;
    }

    public static void ProcessarDefault(string linha, TipoRegistro tipoRegistro)
    {
        if (linha.Length == 100)
        {
            AssinaturaDigitalAFD.GetAssinaturaDigital(linha);
        }
        else
        {
            ErrosDeLeitura.Erros.Add($"Linha: {linha} - {tipoRegistro}");
            // MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // sr.ReadToEnd();
        }
    }
}
