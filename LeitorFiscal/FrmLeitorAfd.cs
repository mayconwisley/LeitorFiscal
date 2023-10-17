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

    private void ListarCabecalho()
    {
        RTxtLogCabecalho.Clear();
        DgvListCabecalho.DataSource = null;

        if (CabecalhoAFD1510.Portaria!.Contains("1510"))
        {
            DgvListCabecalho.DataSource = CabecalhoAFD1510.CabecalhoAfdList;
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
            DgvListCabecalho.DataSource = CabecalhoAFD595.CabecalhoAfdList;
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
            DgvListCabecalho.DataSource = CabecalhoAFD671.CabecalhoAfdList;
            if (DgvListCabecalho.RowCount > 0)
            {
                RTxtLogCabecalho.AppendText($"Versão do Registro 1 - {CabecalhoAFD671.Portaria}");
            }
            foreach (var item in CabecalhoAFD671.ErrosValidacao)
            {
                RTxtLogCabecalho.AppendText(item);
            }
        }
    }
    private void ListarIdentificacaoEmpresa()
    {
        RTxtLogIdentificacaoEmpresa.Clear();
        DgvListIdentificacaoEmpresa.DataSource = null;

        if (IdentificacaoEmpresaAFD1510.Portaria!.Contains("1510"))
        {
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD1510.IdentificacaoEmpresaRepAfdList;
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
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD595.IdentificacaoEmpresaRepAfdList;
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
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD671.IdentificacaoEmpresaRepAfdList;
            if (DgvListIdentificacaoEmpresa.RowCount > 0)
            {
                RTxtLogIdentificacaoEmpresa.AppendText($"Versão do Registro 2 - {IdentificacaoEmpresaAFD671.Portaria}");
            }
            foreach (var item in IdentificacaoEmpresaAFD671.ErrosValidacao)
            {
                RTxtLogIdentificacaoEmpresa.AppendText(item);
            }
        }
    }
    private void ListarMarcacaoPonto()
    {
        RTxtLogMarcacaoPonto.Clear();
        DgvListMarcacaoPonto.DataSource = null;

        if (MarcacaoPontoAFD1510.Portaria!.Contains("1510"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD1510.MarcacaoPontoAfdList;
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD1510.Portaria}");
            }
            foreach (var item in MarcacaoPontoAFD1510.ErrosValidacao)
            {
                RTxtLogMarcacaoPonto.AppendText(item);
            }
        }

        if (MarcacaoPontoAFD595.Portaria!.Contains("595"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD595.MarcacaoPontoAfdList;
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD595.Portaria}");
            }
            foreach (var item in MarcacaoPontoAFD595.ErrosValidacao)
            {
                RTxtLogMarcacaoPonto.AppendText(item);
            }
        }

        if (MarcacaoPontoAFD671.Portaria!.Contains("671"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD671.MarcacaoPontoAfdList;
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD671.Portaria}");
            }
            foreach (var item in MarcacaoPontoAFD671.ErrosValidacao)
            {
                RTxtLogMarcacaoPonto.AppendText(item);
            }
        }
    }
    private void ListarRelogioTempoReal()
    {
        RTxtLogRelogioTempoReal.Clear();
        DgvListRelogioTempoReal.DataSource = null;

        if (TempoRealAFD1510.Portaria!.Contains("1510"))
        {
            DgvListRelogioTempoReal.DataSource = TempoRealAFD1510.TempoRealRepAfdList;
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
            DgvListRelogioTempoReal.DataSource = TempoRealAFD1510.TempoRealRepAfdList;
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
            DgvListRelogioTempoReal.DataSource = TempoRealAFD1510.TempoRealRepAfdList;
            if (DgvListRelogioTempoReal.RowCount > 0)
            {
                RTxtLogRelogioTempoReal.AppendText($"Versão do Registro 3 - {TempoRealAFD1510.Portaria}");
            }
            foreach (var item in TempoRealAFD671.ErrosValidacao)
            {
                RTxtLogRelogioTempoReal.AppendText(item);
            }
        }
    }
    private void ListarEmpregadoMt()
    {
        RTxtLogEmpregadoMt.Clear();
        DgvListEmpregadoMt.DataSource = null;
        if (EmpregadoMtAFD1510.Portaria!.Contains("1510"))
        {
            DgvListEmpregadoMt.DataSource = EmpregadoMtAFD1510.EmpregadoMtRepAfdList;
            if (DgvListEmpregadoMt.RowCount > 0)
            {
                RTxtLogEmpregadoMt.AppendText($"Versão do Registro 5 - {EmpregadoMtAFD1510.Portaria}");
            }
            foreach (var item in EmpregadoMtAFD1510.ErrosValidacao)
            {
                RTxtLogEmpregadoMt.AppendText(item);
            }
        }

        if (EmpregadoMtAFD595.Portaria!.Contains("595"))
        {
            DgvListEmpregadoMt.DataSource = EmpregadoMtAFD595.EmpregadoMtRepAfdList;
            if (DgvListEmpregadoMt.RowCount > 0)
            {
                RTxtLogEmpregadoMt.AppendText($"Versão do Registro 5 - {EmpregadoMtAFD595.Portaria}");
            }
            foreach (var item in EmpregadoMtAFD595.ErrosValidacao)
            {
                RTxtLogEmpregadoMt.AppendText(item);
            }
        }

        if (EmpregadoMtAFD671.Portaria!.Contains("671"))
        {
            DgvListEmpregadoMt.DataSource = EmpregadoMtAFD671.EmpregadoMtRepAfdList;
            if (DgvListEmpregadoMt.RowCount > 0)
            {
                RTxtLogEmpregadoMt.AppendText($"Versão do Registro 5 - {EmpregadoMtAFD671.Portaria}");
            }
            foreach (var item in EmpregadoMtAFD671.ErrosValidacao)
            {
                RTxtLogEmpregadoMt.AppendText(item);
            }
        }
    }
    private void ListarEventoSensiveis()
    {
        RTxtLogEventoSensiveis.Clear();
        DgvListEventoSensiveis.DataSource = null;

        if (EventosSensiveisAFD595.Portaria!.Contains("595"))
        {
            DgvListEventoSensiveis.DataSource = EventosSensiveisAFD595.EventosSensiveisRepAfdList;
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
            DgvListEventoSensiveis.DataSource = EventosSensiveisAFD671.EventosSensiveisRepAfdList;
            if (DgvListEventoSensiveis.RowCount > 0)
            {
                RTxtLogEventoSensiveis.AppendText($"Versão do Registro 6 - {EventosSensiveisAFD671.Portaria}");
            }
            foreach (var item in EventosSensiveisAFD671.ErrosValidacao)
            {
                RTxtLogEventoSensiveis.AppendText(item);
            }
        }
    }
    private void ListarMarcacaoPontoRepP()
    {
        RTxtLogMarcacaoPontoRepP.Clear();
        DgvListMarcacaoPontoRepP.DataSource = null;

        if (MarcacaoPontoRepPAFD671.Portaria!.Contains("671"))
        {
            DgvListMarcacaoPontoRepP.DataSource = MarcacaoPontoRepPAFD671.MarcacaoPontoRepPAfdList;
            if (DgvListMarcacaoPontoRepP.RowCount > 0)
            {
                RTxtLogMarcacaoPontoRepP.AppendText($"Versão do Registro 7 - {MarcacaoPontoRepPAFD671.Portaria}");
            }
            foreach (var item in MarcacaoPontoRepPAFD671.ErrosValidacao)
            {
                RTxtLogMarcacaoPontoRepP.AppendText(item);
            }
        }
    }
    private void ListarTrailer()
    {
        RTxtLogTrailer.Clear();
        DgvListTrailer.DataSource = null;

        if (TrailerAFD1510.Portaria!.Contains("1510"))
        {
            DgvListTrailer.DataSource = TrailerAFD1510.TrailerAfdList;
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
            DgvListTrailer.DataSource = TrailerAFD595.TrailerAfdList;
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
            DgvListTrailer.DataSource = TrailerAFD671.TrailerAfdList;
            if (DgvListTrailer.RowCount > 0)
            {
                RTxtLogTrailer.AppendText($"Versão do Registro 9 - {TrailerAFD671.Portaria}");
            }
            foreach (var item in TrailerAFD671.ErrosValidacao)
            {
                RTxtLogTrailer.AppendText(item);
            }
        }
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

    private void SubMenuArquivoLer_Click(object sender, EventArgs e)
    {
        LocalizarArquivo();

        try
        {
            LerArquivoAFD.Arquivo(caminhoArquivo);
            ListarCabecalho();
            ListarIdentificacaoEmpresa();
            ListarMarcacaoPonto();
            ListarRelogioTempoReal();
            ListarEmpregadoMt();
            ListarEventoSensiveis();
            ListarMarcacaoPontoRepP();
            ListarTrailer();

            MenuConverter.Enabled = true;
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
}
