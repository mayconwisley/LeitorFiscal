namespace LeitorFiscal.AFD.LimparDados;

public class LimparAFD
{
    public static void Limpar()
    {
        CabecalhoAFD1510.CabecalhoAfdList.Clear();
        CabecalhoAFD1510.ErrosValidacao.Clear();
        CabecalhoAFD1510.Portaria = "";
        CabecalhoAFD595.CabecalhoAfdList.Clear();
        CabecalhoAFD595.ErrosValidacao.Clear();
        CabecalhoAFD595.Portaria = "";
        CabecalhoAFD671.CabecalhoAfdList.Clear();
        CabecalhoAFD671.ErrosValidacao.Clear();
        CabecalhoAFD671.Portaria = "";

        IdentificacaoEmpresaAFD1510.IdentificacaoEmpresaRepAfdList.Clear();
        IdentificacaoEmpresaAFD1510.ErrosValidacao.Clear();
        IdentificacaoEmpresaAFD1510.Portaria = "";
        IdentificacaoEmpresaAFD595.IdentificacaoEmpresaRepAfdList.Clear();
        IdentificacaoEmpresaAFD595.ErrosValidacao.Clear();
        IdentificacaoEmpresaAFD595.Portaria = "";
        IdentificacaoEmpresaAFD671.IdentificacaoEmpresaRepAfdList.Clear();
        IdentificacaoEmpresaAFD671.ErrosValidacao.Clear();
        IdentificacaoEmpresaAFD671.Portaria = "";

        MarcacaoPontoAFD1510.MarcacaoPontoAfdList.Clear();
        MarcacaoPontoAFD1510.ErrosValidacao.Clear();
        MarcacaoPontoAFD1510.Portaria = "";
        MarcacaoPontoAFD595.MarcacaoPontoAfdList.Clear();
        MarcacaoPontoAFD595.ErrosValidacao.Clear();
        MarcacaoPontoAFD595.Portaria = "";
        MarcacaoPontoAFD671.MarcacaoPontoAfdList.Clear();
        MarcacaoPontoAFD671.ErrosValidacao.Clear();
        MarcacaoPontoAFD671.Portaria = "";

        TempoRealAFD1510.TempoRealRepAfdList.Clear();
        TempoRealAFD1510.ErrosValidacao.Clear();
        TempoRealAFD1510.Portaria = "";
        TempoRealAFD595.TempoRealRepAfdList.Clear();
        TempoRealAFD595.ErrosValidacao.Clear();
        TempoRealAFD595.Portaria = "";
        TempoRealAFD671.TempoRealRepAfdList.Clear();
        TempoRealAFD671.ErrosValidacao.Clear();
        TempoRealAFD671.Portaria = "";

        EmpregadoMtAFD1510.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtAFD1510.ErrosValidacao.Clear();
        EmpregadoMtAFD1510.Portaria = "";
        EmpregadoMtAFD595.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtAFD595.ErrosValidacao.Clear();
        EmpregadoMtAFD595.Portaria = "";
        EmpregadoMtAFD671.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtAFD671.ErrosValidacao.Clear();
        EmpregadoMtAFD671.Portaria = "";

        EventosSensiveisAFD595.EventosSensiveisRepAfdList.Clear();
        EventosSensiveisAFD595.ErrosValidacao.Clear();
        EventosSensiveisAFD595.Portaria = "";
        EventosSensiveisAFD671.EventosSensiveisRepAfdList.Clear();
        EventosSensiveisAFD671.ErrosValidacao.Clear();
        EventosSensiveisAFD671.Portaria = "";

        MarcacaoPontoRepPAFD671.MarcacaoPontoRepPAfdList.Clear();
        MarcacaoPontoRepPAFD671.ErrosValidacao.Clear();
        MarcacaoPontoRepPAFD671.Portaria = "";

        TrailerAFD1510.TrailerAfdList.Clear();
        TrailerAFD1510.ErrosValidacao.Clear();
        TrailerAFD1510.Portaria = "";
        TrailerAFD595.TrailerAfdList.Clear();
        TrailerAFD595.ErrosValidacao.Clear();
        TrailerAFD595.Portaria = "";
        TrailerAFD671.TrailerAfdList.Clear();
        TrailerAFD671.ErrosValidacao.Clear();
        TrailerAFD671.Portaria = "";
    }
}
