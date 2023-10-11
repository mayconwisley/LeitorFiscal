namespace LeitorAEJ
{
    partial class FrmLeitorAfd
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
            MenuAfd = new MenuStrip();
            MenuArquivo = new ToolStripMenuItem();
            SubMenuArquivoLer = new ToolStripMenuItem();
            MenuAfd.SuspendLayout();
            SuspendLayout();
            // 
            // MenuAfd
            // 
            MenuAfd.BackColor = Color.Transparent;
            MenuAfd.Items.AddRange(new ToolStripItem[] { MenuArquivo });
            MenuAfd.Location = new Point(0, 0);
            MenuAfd.Name = "MenuAfd";
            MenuAfd.Size = new Size(800, 24);
            MenuAfd.TabIndex = 0;
            MenuAfd.Text = "menuStrip1";
            // 
            // MenuArquivo
            // 
            MenuArquivo.DropDownItems.AddRange(new ToolStripItem[] { SubMenuArquivoLer });
            MenuArquivo.Name = "MenuArquivo";
            MenuArquivo.Size = new Size(61, 20);
            MenuArquivo.Text = "Arquivo";
            // 
            // SubMenuArquivoLer
            // 
            SubMenuArquivoLer.Name = "SubMenuArquivoLer";
            SubMenuArquivoLer.Size = new Size(180, 22);
            SubMenuArquivoLer.Text = "Ler";
            SubMenuArquivoLer.Click += SubMenuArquivoLer_Click;
            // 
            // FrmLeitorAfd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuAfd);
            MainMenuStrip = MenuAfd;
            Name = "FrmLeitorAfd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leitor Afd";
            MenuAfd.ResumeLayout(false);
            MenuAfd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuAfd;
        private ToolStripMenuItem MenuArquivo;
        private ToolStripMenuItem SubMenuArquivoLer;
    }
}