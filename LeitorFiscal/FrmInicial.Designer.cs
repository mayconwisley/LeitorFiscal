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
            SuspendLayout();
            // 
            // BtnValidadeAej
            // 
            BtnValidadeAej.Location = new Point(55, 14);
            BtnValidadeAej.Name = "BtnValidadeAej";
            BtnValidadeAej.Size = new Size(167, 75);
            BtnValidadeAej.TabIndex = 0;
            BtnValidadeAej.Text = "Validar AEJ";
            BtnValidadeAej.UseVisualStyleBackColor = true;
            BtnValidadeAej.Click += BtnValidadeAej_Click;
            // 
            // BtnValidarAej
            // 
            BtnValidarAej.Location = new Point(228, 14);
            BtnValidarAej.Name = "BtnValidarAej";
            BtnValidarAej.Size = new Size(167, 75);
            BtnValidarAej.TabIndex = 1;
            BtnValidarAej.Text = "Validar AFD";
            BtnValidarAej.UseVisualStyleBackColor = true;
            BtnValidarAej.Click += BtnValidarAej_Click;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 103);
            Controls.Add(BtnValidarAej);
            Controls.Add(BtnValidadeAej);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validador de Arquivos Fiscais AEJ e AFD";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnValidadeAej;
        private Button BtnValidarAej;
    }
}