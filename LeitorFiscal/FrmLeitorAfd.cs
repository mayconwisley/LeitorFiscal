using LeitorFiscal.AFD.Portaria_1510;
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
        DgvListCabecalho1510.DataSource = Cabecalho1510.Cabecalho1510List;

        foreach (var item in Cabecalho1510.ErrosValidacao)
        {
            RTxtLogCabecalho1510.AppendText(item);
        }
    }

    private void ListarIdentificacaoEmpresa1510()
    {
        RTxtLogIdentificacaoEmpresa1510.Clear();
        DgvListIdentificacaoEmpresa1510.DataSource = null;
        DgvListIdentificacaoEmpresa1510.DataSource = IdentificacaoEmpresaRep1510.IdentificacaoEmpresaRep1510List;
        foreach (var item in IdentificacaoEmpresaRep1510.ErrosValidacao)
        {
            RTxtLogIdentificacaoEmpresa1510.AppendText(item);
        }
    }
    private void ListarMarcacaoPonto1510()
    {
        RTxtLogMarcacaoPonto1510.Clear();
        DgvListMarcacaoPonto1510.DataSource = null;
        DgvListMarcacaoPonto1510.DataSource = MarcacaoPonto1510.MarcacaoPonto1510List;
        foreach (var item in MarcacaoPonto1510.ErrosValidacao)
        {
            RTxtLogMarcacaoPonto1510.AppendText(item);
        }
    }
    private void ListarRelogioTempoReal1510()
    {
        RTxtLogRelogioTempoReal1510.Clear();
        DgvListRelogioTempoReal1510.DataSource = null;
        DgvListRelogioTempoReal1510.DataSource = TempoRealRep1510.TempoRealRep1510List;
        foreach (var item in TempoRealRep1510.ErrosValidacao)
        {
            RTxtLogRelogioTempoReal1510.AppendText(item);
        }
    }
    private void ListarEmpregadoMt1510()
    {
        RTxtLogEmpregadoMt1510.Clear();
        DgvListEmpregadoMt1510.DataSource = null;
        DgvListEmpregadoMt1510.DataSource = EmpregadoMtRep1510.EmpregadoMtRep1510List;
        foreach (var item in EmpregadoMtRep1510.ErrosValidacao)
        {
            RTxtLogEmpregadoMt1510.AppendText(item);
        }
    }
    private void ListarEventoSensiveis1510()
    {
        RTxtLogEventoSensiveis1510.Clear();
        DgvListEventoSensiveis1510.DataSource = null;
        DgvListEventoSensiveis1510.DataSource = EventosSensiveisRep1510.EventosSensiveisRep1510List;
        foreach (var item in EventosSensiveisRep1510.ErrosValidacao)
        {
            RTxtLogEventoSensiveis1510.AppendText(item);
        }
    }
    private void ListarTrailer1510()
    {
        RTxtLogTrailer1510.Clear();
        DgvListTrailer1510.DataSource = null;
        DgvListTrailer1510.DataSource = Trailer1510.Trailer1510List;
        foreach (var item in Trailer1510.ErrosValidacao)
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
