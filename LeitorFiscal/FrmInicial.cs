namespace LeitorFiscal;

public partial class FrmInicial : Form
{
    public FrmInicial()
    {
        InitializeComponent();
    }

    private void BtnValidadeAej_Click(object sender, EventArgs e)
    {
        try
        {
            FrmLeitorFiscal frmLeitorFiscal = new();
            frmLeitorFiscal.ShowDialog();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

    private void BtnValidarAej_Click(object sender, EventArgs e)
    {
        try
        {
            FrmLeitorAfd frmLeitorAfd = new();
            frmLeitorAfd.ShowDialog();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }
}
