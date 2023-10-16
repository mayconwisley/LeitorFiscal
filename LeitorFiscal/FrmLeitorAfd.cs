using LeitorFiscal.AFD;
using LeitorFiscal.LeituraArquivo;

namespace LeitorFiscal;

public partial class FrmLeitorAfd : Form
{
    string caminhoArquivo = string.Empty;
    bool portaria595 = false;
    public FrmLeitorAfd()
    {
        InitializeComponent();
    }

    private void ListarCabecalho1510()
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
        }

        if (CabecalhoAFD595.Portaria!.Contains("595"))
        {
            DgvListCabecalho.DataSource = CabecalhoAFD595.CabecalhoAfdList;
            if (DgvListCabecalho.RowCount > 0)
            {
                RTxtLogCabecalho.AppendText($"Versão do Registro 1 - {CabecalhoAFD595.Portaria}");
            }
        }

        if (CabecalhoAFD671.Portaria!.Contains("671"))
        {
            DgvListCabecalho.DataSource = CabecalhoAFD671.CabecalhoAfdList;
            if (DgvListCabecalho.RowCount > 0)
            {
                RTxtLogCabecalho.AppendText($"Versão do Registro 1 - {CabecalhoAFD671.Portaria}");
            }
        }

        foreach (var item in CabecalhoAFD1510.ErrosValidacao)
        {
            RTxtLogCabecalho.AppendText(item);
        }
    }

    private void ListarIdentificacaoEmpresa1510()
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
        }

        if (IdentificacaoEmpresaAFD595.Portaria!.Contains("595"))
        {
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD595.IdentificacaoEmpresaRepAfdList;
            if (DgvListIdentificacaoEmpresa.RowCount > 0)
            {
                RTxtLogIdentificacaoEmpresa.AppendText($"Versão do Registro 2 - {IdentificacaoEmpresaAFD595.Portaria}");
            }
        }

        if (IdentificacaoEmpresaAFD671.Portaria!.Contains("671"))
        {
            DgvListIdentificacaoEmpresa.DataSource = IdentificacaoEmpresaAFD671.IdentificacaoEmpresaRepAfdList;
            if (DgvListIdentificacaoEmpresa.RowCount > 0)
            {
                RTxtLogIdentificacaoEmpresa.AppendText($"Versão do Registro 2 - {IdentificacaoEmpresaAFD671.Portaria}");
            }
        }

        foreach (var item in IdentificacaoEmpresaAFD1510.ErrosValidacao)
        {
            RTxtLogIdentificacaoEmpresa.AppendText(item);
        }
    }
    private void ListarMarcacaoPonto1510()
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
        }

        if (MarcacaoPontoAFD595.Portaria!.Contains("595"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD595.MarcacaoPontoAfdList;
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD1510.Portaria}");
            }
        }

        if (MarcacaoPontoAFD671.Portaria!.Contains("671"))
        {
            DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD671.MarcacaoPontoAfdList;
            if (DgvListMarcacaoPonto.RowCount > 0)
            {
                RTxtLogMarcacaoPonto.AppendText($"Versão do Registro 3 - {MarcacaoPontoAFD1510.Portaria}");
            }
        }


        DgvListMarcacaoPonto.DataSource = MarcacaoPontoAFD1510.MarcacaoPontoAfdList;

        foreach (var item in MarcacaoPontoAFD1510.ErrosValidacao)
        {
            RTxtLogMarcacaoPonto.AppendText(item);
        }
    }
    private void ListarRelogioTempoReal1510()
    {
        RTxtLogRelogioTempoReal1510.Clear();
        DgvListRelogioTempoReal1510.DataSource = null;
        DgvListRelogioTempoReal1510.DataSource = TempoRealRepAFD.TempoRealRepAfdList;
        foreach (var item in TempoRealRepAFD.ErrosValidacao)
        {
            RTxtLogRelogioTempoReal1510.AppendText(item);
        }
    }
    private void ListarEmpregadoMt1510()
    {
        RTxtLogEmpregadoMt1510.Clear();
        DgvListEmpregadoMt1510.DataSource = null;
        DgvListEmpregadoMt1510.DataSource = EmpregadoMtRepAFD.EmpregadoMtRepAfdList;
        foreach (var item in EmpregadoMtRepAFD.ErrosValidacao)
        {
            RTxtLogEmpregadoMt1510.AppendText(item);
        }
    }
    private void ListarEventoSensiveis1510()
    {
        RTxtLogEventoSensiveis1510.Clear();
        DgvListEventoSensiveis1510.DataSource = null;
        DgvListEventoSensiveis1510.DataSource = EventosSensiveisRepAFD.EventosSensiveisRepAfdList;
        foreach (var item in EventosSensiveisRepAFD.ErrosValidacao)
        {
            RTxtLogEventoSensiveis1510.AppendText(item);
        }
    }
    private void ListarTrailer1510()
    {
        RTxtLogTrailer1510.Clear();
        DgvListTrailer1510.DataSource = null;
        DgvListTrailer1510.DataSource = TrailerAFD.TrailerAfdList;
        foreach (var item in TrailerAFD.ErrosValidacao)
        {
            RTxtLogTrailer1510.AppendText(item);
        }
    }
    private void LocalizarArquivo()
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
        openFileDialog.Multiselect = false;
        openFileDialog.Title = "Localizar arquivo AFD";
        portaria595 = false;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            caminhoArquivo = openFileDialog.FileName;
            if (MessageBox.Show("Verificar arquivo AFD com base na\nPortaria n.º 595, de 05 de dezembro de 2013", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                portaria595 = true;
            }
        }
    }

    private void SubMenuArquivoLer_Click(object sender, EventArgs e)
    {
        LocalizarArquivo();

        try
        {
            LerArquivoAFD.Arquivo(caminhoArquivo, portaria595);
            ListarCabecalho1510();
            ListarIdentificacaoEmpresa1510();
            ListarMarcacaoPonto1510();
            ListarRelogioTempoReal1510();
            ListarEmpregadoMt1510();
            ListarEventoSensiveis1510();
            ListarTrailer1510();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
