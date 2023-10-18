namespace LeitorFiscal
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            BtnValidadeAej = new Button();
            BtnValidarAej = new Button();
            label1 = new Label();
            LkPortarias = new LinkLabel();
            LkProjetoGithub = new LinkLabel();
            SuspendLayout();
            // 
            // BtnValidadeAej
            // 
            BtnValidadeAej.Location = new Point(65, 38);
            BtnValidadeAej.Name = "BtnValidadeAej";
            BtnValidadeAej.Size = new Size(167, 75);
            BtnValidadeAej.TabIndex = 0;
            BtnValidadeAej.Text = "Validar AEJ";
            BtnValidadeAej.UseVisualStyleBackColor = true;
            BtnValidadeAej.Click += BtnValidadeAej_Click;
            // 
            // BtnValidarAej
            // 
            BtnValidarAej.Location = new Point(238, 38);
            BtnValidarAej.Name = "BtnValidarAej";
            BtnValidarAej.Size = new Size(167, 75);
            BtnValidarAej.TabIndex = 1;
            BtnValidarAej.Text = "Validar AFD";
            BtnValidarAej.UseVisualStyleBackColor = true;
            BtnValidarAej.Click += BtnValidarAej_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 2;
            label1.Text = "Desenvolvido por: Maycon Wisley";
            // 
            // LkPortarias
            // 
            LkPortarias.AutoSize = true;
            LkPortarias.Location = new Point(405, 126);
            LkPortarias.Name = "LkPortarias";
            LkPortarias.Size = new Size(53, 15);
            LkPortarias.TabIndex = 3;
            LkPortarias.TabStop = true;
            LkPortarias.Text = "Portarias";
            LkPortarias.LinkClicked += LkPortarias_LinkClicked;
            // 
            // LkProjetoGithub
            // 
            LkProjetoGithub.AutoSize = true;
            LkProjetoGithub.Location = new Point(203, 126);
            LkProjetoGithub.Name = "LkProjetoGithub";
            LkProjetoGithub.Size = new Size(84, 15);
            LkProjetoGithub.TabIndex = 4;
            LkProjetoGithub.TabStop = true;
            LkProjetoGithub.Text = "Projeto Github";
            LkProjetoGithub.LinkClicked += LkProjetoGithub_LinkClicked;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 150);
            Controls.Add(LkProjetoGithub);
            Controls.Add(LkPortarias);
            Controls.Add(label1);
            Controls.Add(BtnValidarAej);
            Controls.Add(BtnValidadeAej);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validador de Arquivos Fiscais AEJ e AFD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnValidadeAej;
        private Button BtnValidarAej;
        private Label label1;
        private LinkLabel LkPortarias;
        private LinkLabel LkProjetoGithub;
    }
}