namespace LeitorAEJ
{
    partial class FrmRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            CbxVinculos = new ComboBox();
            RTxtMarcacaoIndividual = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbxVinculos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vinculos";
            // 
            // CbxVinculos
            // 
            CbxVinculos.DisplayMember = "NomeEmp";
            CbxVinculos.FormattingEnabled = true;
            CbxVinculos.Location = new Point(6, 22);
            CbxVinculos.Name = "CbxVinculos";
            CbxVinculos.Size = new Size(422, 23);
            CbxVinculos.TabIndex = 0;
            CbxVinculos.ValueMember = "IdtVinculoAej";
            CbxVinculos.SelectedIndexChanged += CbxVinculos_SelectedIndexChanged;
            // 
            // RTxtMarcacaoIndividual
            // 
            RTxtMarcacaoIndividual.Location = new Point(12, 79);
            RTxtMarcacaoIndividual.Name = "RTxtMarcacaoIndividual";
            RTxtMarcacaoIndividual.Size = new Size(814, 436);
            RTxtMarcacaoIndividual.TabIndex = 1;
            RTxtMarcacaoIndividual.Text = "";
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 527);
            Controls.Add(RTxtMarcacaoIndividual);
            Controls.Add(groupBox1);
            Name = "FrmRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório";
            Load += FrmRelatorio_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CbxVinculos;
        private RichTextBox RTxtMarcacaoIndividual;
    }
}