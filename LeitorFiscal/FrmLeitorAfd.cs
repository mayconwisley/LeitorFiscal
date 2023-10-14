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
        RTxtLogCabecalho1510.Clear();
        DgvListCabecalho1510.DataSource = null;
        DgvListCabecalho1510.DataSource = CabecalhoAFD.CabecalhoAfdList;

        foreach (var item in CabecalhoAFD.ErrosValidacao)
        {
            RTxtLogCabecalho1510.AppendText(item);
        }
    }

    private void ListarIdentificacaoEmpresa1510()
    {
        RTxtLogIdentificacaoEmpresa1510.Clear();
        DgvListIdentificacaoEmpresa1510.DataSource = null;
        DgvListIdentificacaoEmpresa1510.DataSource = IdentificacaoEmpresaRepAFD.IdentificacaoEmpresaRepAfdList;
        foreach (var item in IdentificacaoEmpresaRepAFD.ErrosValidacao)
        {
            RTxtLogIdentificacaoEmpresa1510.AppendText(item);
        }
    }
    private void ListarMarcacaoPonto1510()
    {
        RTxtLogMarcacaoPonto1510.Clear();
        DgvListMarcacaoPonto1510.DataSource = null;
        DgvListMarcacaoPonto1510.DataSource = MarcacaoPontoAFD.MarcacaoPontoAfdList;
        foreach (var item in MarcacaoPontoAFD.ErrosValidacao)
        {
            RTxtLogMarcacaoPonto1510.AppendText(item);
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
