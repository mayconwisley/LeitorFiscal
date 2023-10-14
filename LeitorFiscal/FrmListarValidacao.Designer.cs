namespace LeitorFiscal
{
    partial class FrmListarValidacao
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
            RTxtListaValidacao = new RichTextBox();
            SuspendLayout();
            // 
            // RTxtListaValidacao
            // 
            RTxtListaValidacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RTxtListaValidacao.Location = new Point(12, 12);
            RTxtListaValidacao.Name = "RTxtListaValidacao";
            RTxtListaValidacao.ReadOnly = true;
            RTxtListaValidacao.Size = new Size(937, 452);
            RTxtListaValidacao.TabIndex = 0;
            RTxtListaValidacao.Text = "";
            // 
            // FrmListarValidacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 476);
            Controls.Add(RTxtListaValidacao);
            MinimizeBox = false;
            Name = "FrmListarValidacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Validação";
            Load += FrmListarValidacao_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RTxtListaValidacao;
    }
}