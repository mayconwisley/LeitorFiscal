namespace LeitorAEJ;

public partial class FrmInicial : Form
{
    public FrmInicial()
    {
        InitializeComponent();
    }

    private void BtnValidadeAej_Click(object sender, EventArgs e)
    {
        FrmLeitorAej frmLeitorAej = new();
        frmLeitorAej.ShowDialog();
    }

    private void BtnValidarAej_Click(object sender, EventArgs e)
    {
        FrmLeitorAfd frmLeitorAfd = new();
        frmLeitorAfd.ShowDialog();
    }
}
