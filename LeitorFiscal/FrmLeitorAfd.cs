using LeitorFiscal.AFD;
using LeitorFiscal.GravarArquivo;
using LeitorFiscal.LeituraArquivo;

namespace LeitorFiscal;

public partial class FrmLeitorAfd : Form
{
    string caminhoArquivo = string.Empty;
    string caminhoSalvar = string.Empty;

    public FrmLeitorAfd()
    {
        InitializeComponent();
    }

    private int paginaAtual = 1;
    decimal totalPagina = 1;
    int totalItens = 0;
    const int tamanhoPg = 250;
    
    private void ListarCabecalho(int pgAtual = 1)
    {
        RTxtLogCabecalho.Clear();
        DgvListCabecalho.DataSource = null;

        if (CabecalhoAFD1510.Portaria!.Contains("1510"))
        {
            DgvListCabecalho.DataSource = CabecalhoAFD1510.CabecalhoAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListCabecalho.RowCount > 0)
            {
                RTxtLogCabecalho.AppendText($"Versão do Registro 1 - {CabecalhoAFD1510.Portaria}");
            }
            foreach (var item in CabecalhoAFD1510.ErrosValidacao)
            {
                RTxtLogCabecalho.AppendText(item);
            }
        }

        if (CabecalhoAFD595.Portaria!.Contains("595"))
        {
            DgvListCabecalho.DataSource = CabecalhoAFD595.CabecalhoAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListCabecalho.RowCount > 0)
            {
                RTxtLogCabecalho.AppendText($"Versão do Registro 1 - {CabecalhoAFD595.Portaria}");
            }
            foreach (var item in CabecalhoAFD595.ErrosValidacao)
            {
                RTxtLogCabecalho.AppendText(item);
            }
        }

        if (CabecalhoAFD671.Portaria!.Contains("671"))
        {
            DgvListCabecalho.DataSource = CabecalhoAFD671.CabecalhoAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListCabecalho.RowCount > 0)
            {
                RTxtLogCabecalho.AppendText($"Versão do Registro 1 - {CabecalhoAFD671.Portaria}");
            }
            foreach (var item in CabecalhoAFD671.ErrosValidacao)
            {
                RTxtLogCabecalho.AppendText(item);
            }
        }

        totalItens = DgvListCabecalho.RowCount;
    }
    private void ListarIdentificacaoEmpresa(int pgAtual = 1)
    {
        RTxtLogIdentificacaoEmpresa.Clear();
        DgvListIdentificacaoEmpresa.DataSource = null;

        if (IdentificacaoEmpresaAFD1510.Portaria!.Contains("1510"))
        {
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD1510.IdentificacaoEmpresaRepAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListIdentificacaoEmpresa.RowCount > 0)
            {
                RTxtLogIdentificacaoEmpresa.AppendText($"Versão do Registro 2 - {IdentificacaoEmpresaAFD1510.Portaria}");
            }
            foreach (var item in IdentificacaoEmpresaAFD1510.ErrosValidacao)
            {
                RTxtLogIdentificacaoEmpresa.AppendText(item);
            }
        }

        if (IdentificacaoEmpresaAFD595.Portaria!.Contains("595"))
        {
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD595.IdentificacaoEmpresaRepAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListIdentificacaoEmpresa.RowCount > 0)
            {
                RTxtLogIdentificacaoEmpresa.AppendText($"Versão do Registro 2 - {IdentificacaoEmpresaAFD595.Portaria}");
            }
            foreach (var item in IdentificacaoEmpresaAFD595.ErrosValidacao)
            {
                RTxtLogIdentificacaoEmpresa.AppendText(item);
            }
        }

        if (IdentificacaoEmpresaAFD671.Portaria!.Contains("671"))
        {
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD671.IdentificacaoEmpresaRepAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListIdentificacaoEmpresa.RowCount > 0)
            {
                RTxtLogIdentificacaoEmpresa.AppendText($"Versão do Registro 2 - {IdentificacaoEmpresaAFD671.Portaria}");
            }
            foreach (var item in IdentificacaoEmpresaAFD671.ErrosValidacao)
            {
                RTxtLogIdentificacaoEmpresa.AppendText(item);
            }
        }
        totalItens = DgvListIdentificacaoEmpresa.RowCount;
    }
    private void ListarMarcacaoPonto(int pgAtual = 1)
    {
        RTxtLogMarcacaoPonto.Clear();
        DgvListMarcacaoPonto.DataSource = null;

        if (MarcacaoPontoAFD1510.Portaria!.Contains("1510"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD1510
                                              .MarcacaoPontoAfdList
                                              .Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD1510.Portaria}");
            }
            foreach (var item in MarcacaoPontoAFD1510.ErrosValidacao)
            {
                RTxtLogMarcacaoPonto.AppendText(item);
            }
            MenuConverter.Enabled = true;
        }

        if (MarcacaoPontoAFD595.Portaria!.Contains("595"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD595
                                              .MarcacaoPontoAfdList
                                              .Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD595.Portaria}");
            }
            foreach (var item in MarcacaoPontoAFD595.ErrosValidacao)
            {
                RTxtLogMarcacaoPonto.AppendText(item);
            }
            MenuConverter.Enabled = true;
        }

        if (MarcacaoPontoAFD671.Portaria!.Contains("671"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD671
                                             .MarcacaoPontoAfdList
                                             .Skip((pgAtual - 1) * tamanhoPg)
                                             .Take(tamanhoPg)
                                             .ToList();
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD671.Portaria}");
            }
            foreach (var item in MarcacaoPontoAFD671.ErrosValidacao)
            {
                RTxtLogMarcacaoPonto.AppendText(item);
            }
            MenuConverter.Enabled = false;
        }

        totalItens = DgvListMarcacaoPonto.RowCount;
    }
    private void ListarRelogioTempoReal(int pgAtual = 1)
    {
        RTxtLogRelogioTempoReal.Clear();
        DgvListRelogioTempoReal.DataSource = null;

        if (TempoRealAFD1510.Portaria!.Contains("1510"))
        {
            DgvListRelogioTempoReal.DataSource = TempoRealAFD1510.TempoRealRepAfdList.Skip((pgAtual - 1) * tamanhoPg).Take(tamanhoPg).ToList();
            if (DgvListRelogioTempoReal.RowCount > 0)
            {
                RTxtLogRelogioTempoReal.AppendText($"Versão do Registro 3 - {TempoRealAFD1510.Portaria}");
            }
            foreach (var item in TempoRealAFD1510.ErrosValidacao)
            {
                RTxtLogRelogioTempoReal.AppendText(item);
            }
        }

        if (TempoRealAFD1510.Portaria!.Contains("595"))
        {
            DgvListRelogioTempoReal.DataSource = TempoRealAFD1510.TempoRealRepAfdList.Skip((pgAtual - 1) * tamanhoPg).Take(tamanhoPg).ToList();
            if (DgvListRelogioTempoReal.RowCount > 0)
            {
                RTxtLogRelogioTempoReal.AppendText($"Versão do Registro 3 - {TempoRealAFD1510.Portaria}");
            }
            foreach (var item in TempoRealAFD595.ErrosValidacao)
            {
                RTxtLogRelogioTempoReal.AppendText(item);
            }
        }

        if (TempoRealAFD1510.Portaria!.Contains("671"))
        {
            DgvListRelogioTempoReal.DataSource = TempoRealAFD1510.TempoRealRepAfdList.Skip((pgAtual - 1) * tamanhoPg).Take(tamanhoPg).ToList();
            if (DgvListRelogioTempoReal.RowCount > 0)
            {
                RTxtLogRelogioTempoReal.AppendText($"Versão do Registro 3 - {TempoRealAFD1510.Portaria}");
            }
            foreach (var item in TempoRealAFD671.ErrosValidacao)
            {
                RTxtLogRelogioTempoReal.AppendText(item);
            }
        }

        totalItens = DgvListRelogioTempoReal.RowCount;
    }
    private void ListarEmpregadoMt(int pgAtual = 1)
    {
        RTxtLogEmpregadoMt.Clear();
        DgvListEmpregadoMt.DataSource = null;
        if (EmpregadoMtAFD1510.Portaria!.Contains("1510"))
        {
            DgvListEmpregadoMt.DataSource = EmpregadoMtAFD1510
                                             .EmpregadoMtRepAfdList
                                             .Skip((pgAtual - 1) * tamanhoPg)
                                             .Take(tamanhoPg)
                                             .ToList();

            if (DgvListEmpregadoMt.RowCount > 0)
            {
                RTxtLogEmpregadoMt.AppendText($"Versão do Registro 5 - {EmpregadoMtAFD1510.Portaria}");
            }
            foreach (var item in EmpregadoMtAFD1510.ErrosValidacao)
            {
                RTxtLogEmpregadoMt.AppendText(item);
            }
            MenuConverter.Enabled = true;
        }

        if (EmpregadoMtAFD595.Portaria!.Contains("595"))
        {
            DgvListEmpregadoMt.DataSource = EmpregadoMtAFD595
                                              .EmpregadoMtRepAfdList
                                              .Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListEmpregadoMt.RowCount > 0)
            {
                RTxtLogEmpregadoMt.AppendText($"Versão do Registro 5 - {EmpregadoMtAFD595.Portaria}");
            }
            foreach (var item in EmpregadoMtAFD595.ErrosValidacao)
            {
                RTxtLogEmpregadoMt.AppendText(item);
            }
            MenuConverter.Enabled = true;
        }

        if (EmpregadoMtAFD671.Portaria!.Contains("671"))
        {
            DgvListEmpregadoMt.DataSource = EmpregadoMtAFD671
                                            .EmpregadoMtRepAfdList
                                            .Skip((pgAtual - 1) * tamanhoPg)
                                            .Take(tamanhoPg)
                                            .ToList();
            if (DgvListEmpregadoMt.RowCount > 0)
            {
                RTxtLogEmpregadoMt.AppendText($"Versão do Registro 5 - {EmpregadoMtAFD671.Portaria}");
            }
            foreach (var item in EmpregadoMtAFD671.ErrosValidacao)
            {
                RTxtLogEmpregadoMt.AppendText(item);
            }
            MenuConverter.Enabled = false;
        }

        totalItens = DgvListEmpregadoMt.RowCount;

    }
    private void ListarEventoSensiveis(int pgAtual = 1)
    {
        RTxtLogEventoSensiveis.Clear();
        DgvListEventoSensiveis.DataSource = null;

        if (EventosSensiveisAFD595.Portaria!.Contains("595"))
        {
            DgvListEventoSensiveis.DataSource = EventosSensiveisAFD595.EventosSensiveisRepAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListEventoSensiveis.RowCount > 0)
            {
                RTxtLogEventoSensiveis.AppendText($"Versão do Registro 6 - {EventosSensiveisAFD595.Portaria}");
            }
            foreach (var item in EventosSensiveisAFD595.ErrosValidacao)
            {
                RTxtLogEventoSensiveis.AppendText(item);
            }
        }

        if (EventosSensiveisAFD671.Portaria!.Contains("671"))
        {
            DgvListEventoSensiveis.DataSource = EventosSensiveisAFD671.EventosSensiveisRepAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListEventoSensiveis.RowCount > 0)
            {
                RTxtLogEventoSensiveis.AppendText($"Versão do Registro 6 - {EventosSensiveisAFD671.Portaria}");
            }
            foreach (var item in EventosSensiveisAFD671.ErrosValidacao)
            {
                RTxtLogEventoSensiveis.AppendText(item);
            }
        }

        totalItens = DgvListEventoSensiveis.RowCount;
    }
    private void ListarMarcacaoPontoRepP(int pgAtual = 1)
    {
        RTxtLogMarcacaoPontoRepP.Clear();
        DgvListMarcacaoPontoRepP.DataSource = null;

        if (MarcacaoPontoRepPAFD671.Portaria!.Contains("671"))
        {
            DgvListMarcacaoPontoRepP.DataSource = MarcacaoPontoRepPAFD671.MarcacaoPontoRepPAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListMarcacaoPontoRepP.RowCount > 0)
            {
                RTxtLogMarcacaoPontoRepP.AppendText($"Versão do Registro 7 - {MarcacaoPontoRepPAFD671.Portaria}");
            }
            foreach (var item in MarcacaoPontoRepPAFD671.ErrosValidacao)
            {
                RTxtLogMarcacaoPontoRepP.AppendText(item);
            }
        }

        totalItens = DgvListMarcacaoPontoRepP.RowCount;
    }
    private void ListarTrailer(int pgAtual = 1)
    {
        RTxtLogTrailer.Clear();
        DgvListTrailer.DataSource = null;

        if (TrailerAFD1510.Portaria!.Contains("1510"))
        {
            DgvListTrailer.DataSource = TrailerAFD1510.TrailerAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListTrailer.RowCount > 0)
            {
                RTxtLogTrailer.AppendText($"Versão do Registro 9 - {TrailerAFD1510.Portaria}");
            }
            foreach (var item in TrailerAFD1510.ErrosValidacao)
            {
                RTxtLogTrailer.AppendText(item);
            }

        }

        if (TrailerAFD595.Portaria!.Contains("595"))
        {
            DgvListTrailer.DataSource = TrailerAFD595.TrailerAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListTrailer.RowCount > 0)
            {
                RTxtLogTrailer.AppendText($"Versão do Registro 9 - {TrailerAFD595.Portaria}");
            }
            foreach (var item in TrailerAFD595.ErrosValidacao)
            {
                RTxtLogTrailer.AppendText(item);
            }

        }

        if (TrailerAFD671.Portaria!.Contains("671"))
        {
            DgvListTrailer.DataSource = TrailerAFD671.TrailerAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
            if (DgvListTrailer.RowCount > 0)
            {
                RTxtLogTrailer.AppendText($"Versão do Registro 9 - {TrailerAFD671.Portaria}");
            }
            foreach (var item in TrailerAFD671.ErrosValidacao)
            {
                RTxtLogTrailer.AppendText(item);
            }
        }

        totalItens = DgvListTrailer.RowCount;
    }
    private void ListarAssinaturaDigiral(int pgAtual = 1)
    {
        RTxtLogAssinaturaDigital.Clear();
        DgvListAssinaturaDigital.DataSource = null;
        DgvListAssinaturaDigital.DataSource = AssinaturaDigitalAFD.AssinaturaDigitalAfdList.Skip((pgAtual - 1) * tamanhoPg)
                                              .Take(tamanhoPg)
                                              .ToList();
        if (DgvListAssinaturaDigital.RowCount > 0)
        {
            RTxtLogAssinaturaDigital.AppendText($"Assinatura Digital - {AssinaturaDigitalAFD.Portaria}");
        }
        foreach (var item in AssinaturaDigitalAFD.ErrosValidacao)
        {
            RTxtLogAssinaturaDigital.AppendText(item);
        }

        totalItens = DgvListAssinaturaDigital.RowCount;
    }
    private void LocalizarArquivo()
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
        openFileDialog.Multiselect = false;
        openFileDialog.Title = "Localizar arquivo AFD";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            caminhoArquivo = openFileDialog.FileName;
        }
    }
    private void SalvarArquivo()
    {
        using SaveFileDialog saveFileDialog = new();
        saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
        saveFileDialog.Title = "Salvar Conversão Art. 96 Portaria 6710";
        saveFileDialog.FileName = "AFDConvertido.txt";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            caminhoSalvar = saveFileDialog.FileName;
        }

    }
    private void ValidacaoDePagina(decimal totalPagina)
    {
        if (totalPagina == 1)
        {
            BtnAnterior.Enabled = false;
            BtnProximo.Enabled = false;
        }
        else
        {
            BtnProximo.Enabled = true;
            BtnAnterior.Enabled = true;
        }

        if (paginaAtual == 1)
        {
            BtnAnterior.Enabled = false;
        }

        if (paginaAtual == totalPagina)
        {
            BtnProximo.Enabled = false;
        }

    }
    private void InformacaoPaginaTab(int pgAtual, decimal pgTotal, int totalItens = 0)
    {
        if (totalItens > 1)
        {
            LblInfoPaginas.Text = $"Página {pgAtual} de {pgTotal}";
        }
        else
        {
            LblInfoPaginas.Text = $"Página {pgAtual} de {pgTotal}";
        }
    }
    private void AtualizarDados(int pgAtual)
    {
        ListarCabecalho(pgAtual);
        ListarIdentificacaoEmpresa(pgAtual);
        ListarMarcacaoPonto(pgAtual);
        ListarRelogioTempoReal(pgAtual);
        ListarEmpregadoMt(pgAtual);
        ListarEventoSensiveis(pgAtual);
        ListarMarcacaoPontoRepP(pgAtual);
        ListarTrailer(pgAtual);
        ListarAssinaturaDigiral(pgAtual);
    }
    private void LimparCampos()
    {
        ProcessarGets.CountIdentEmpresa = 0;
        ProcessarGets.CountMarcacaoPonto = 0;
        ProcessarGets.CountTempoReal = 0;
        ProcessarGets.CountEmpregadoMt = 0;
        ProcessarGets.CountEventoSensiveis = 0;
        ProcessarGets.CountMarcacaoPontoRepP = 0;
        ProcessarGets.Trailer = 0;
    }
    private async void SubMenuArquivoLer_Click(object sender, EventArgs e)
    {
        LocalizarArquivo();
        LimparCampos();
        try
        {
            decimal totalLinha = await LerArquivoAFD.TotalLinhaArquivo(caminhoArquivo);
            LerArquivoAFD.Arquivo(caminhoArquivo);
            ListarCabecalho();
            ListarIdentificacaoEmpresa();
            ListarMarcacaoPonto();
            ListarRelogioTempoReal();
            ListarEmpregadoMt();

            ListarEventoSensiveis();
            ListarMarcacaoPontoRepP();
            ListarTrailer();
            ListarAssinaturaDigiral();

            InformacaoPaginaTab(paginaAtual, totalPagina);

            MenuValidacao.Enabled = true;
            if (ErrosDeLeitura.Erros.Count > 0)
            {
                MessageBox.Show($"Tipo de registro inválido: \n{ErrosDeLeitura.ListaDeErro()}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void SubMenuValidacaoListar_Click(object sender, EventArgs e)
    {
        try
        {
            FrmListarValidacao frmListarValidacao = new("AFD");
            frmListarValidacao.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void SubMenuConverterArt96_Click(object sender, EventArgs e)
    {
        SalvarArquivo();
        ConverterArt96Por671.Converter(caminhoArquivo, caminhoSalvar);
        MessageBox.Show("Arquivo convertido!", "Aviso");
    }
    private void BtnProximo_Click(object sender, EventArgs e)
    {
        paginaAtual++;

        if (paginaAtual > 1)
        {
            BtnAnterior.Enabled = true;
        }
        AtualizarDados(paginaAtual);

        InformacaoPaginaTab(paginaAtual, totalPagina);
        ValidacaoDePagina(totalPagina);

    }
    private void BtnAnterior_Click(object sender, EventArgs e)
    {
        paginaAtual--;

        if (paginaAtual <= 1)
        {
            BtnAnterior.Enabled = false;
        }
        AtualizarDados(paginaAtual);
        InformacaoPaginaTab(paginaAtual, totalPagina);
        ValidacaoDePagina(totalPagina);
    }
    private void TabControlAfd_SelectedIndexChanged(object sender, EventArgs e)
    {
        int tabIndex = TabControlAfd.SelectedIndex;
        decimal totalDados = 0;
        paginaAtual = 1;
        switch (tabIndex)
        {
            case 0:
                totalDados = CabecalhoAFD1510.CabecalhoAfdList.Count;

                break;
            case 1:
                totalDados = IdentificacaoEmpresaAFD1510.IdentificacaoEmpresaRepAfdList.Count;

                break;
            case 2:
                totalDados = MarcacaoPontoAFD1510.MarcacaoPontoAfdList.Count;
                break;
            case 3:
                totalDados = TempoRealAFD1510.TempoRealRepAfdList.Count;

                break;
            case 4:
                totalDados = EmpregadoMtAFD1510.EmpregadoMtRepAfdList.Count;

                break;
            case 5:
                totalDados = EventosSensiveisAFD595.EventosSensiveisRepAfdList.Count;

                break;
            case 6:
                totalDados = MarcacaoPontoRepPAFD671.MarcacaoPontoRepPAfdList.Count;

                break;
            case 7:
                totalDados = TrailerAFD1510.TrailerAfdList.Count;

                break;
            case 8:
                totalDados = AssinaturaDigitalAFD.AssinaturaDigitalAfdList.Count;

                break;
            default:
                break;

        }

        totalPagina = (totalDados / tamanhoPg) <= 0 ? 1 : Math.Ceiling(totalDados / tamanhoPg);
        InformacaoPaginaTab(paginaAtual, totalPagina);
        AtualizarDados(paginaAtual);
        ValidacaoDePagina(totalPagina);
    }
}
