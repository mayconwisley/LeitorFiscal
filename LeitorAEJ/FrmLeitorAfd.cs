using LeitorAEJ.LeituraArquivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorAEJ;

public partial class FrmLeitorAfd : Form
{
    string caminhoArquivo = string.Empty;
    public FrmLeitorAfd()
    {
        InitializeComponent();
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

    private void SubMenuArquivoLer_Click(object sender, EventArgs e)
    {
        LocalizarArquivo();

        try
        {
            LerArquivoAFD.Arquivo(caminhoArquivo);
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }
}
