namespace LeitorFiscal
{
    partial class FrmLeitorFgtsDigital
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
            menuStrip1 = new MenuStrip();
            MenuFgtsDigital = new ToolStripMenuItem();
            SubMenuLerArquivo = new ToolStripMenuItem();
            tabFgtsDigital = new TabControl();
            TabIdentificacao = new TabPage();
            GbValidacaoIdentificacao = new GroupBox();
            RtxValidacaoIdentificacao = new RichTextBox();
            DgvIdentificacao = new DataGridView();
            Identifcacao = new DataGridViewTextBoxColumn();
            CnpjCpf = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            DataAdmissao = new DataGridViewTextBoxColumn();
            Matricula = new DataGridViewTextBoxColumn();
            Categoria_Tsve = new DataGridViewTextBoxColumn();
            TabRemuneracao = new TabPage();
            groupBox1 = new GroupBox();
            RtxValidacaoRemuneracao = new RichTextBox();
            DgvRemuneracao = new DataGridView();
            IdentificaoRemuneracao = new DataGridViewTextBoxColumn();
            Competencia = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Valor_principal = new DataGridViewTextBoxColumn();
            valor_13_salario = new DataGridViewTextBoxColumn();
            Ind_ausencia_FGTS = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            tabFgtsDigital.SuspendLayout();
            TabIdentificacao.SuspendLayout();
            GbValidacaoIdentificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvIdentificacao).BeginInit();
            TabRemuneracao.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRemuneracao).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFgtsDigital });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuFgtsDigital
            // 
            MenuFgtsDigital.DropDownItems.AddRange(new ToolStripItem[] { SubMenuLerArquivo });
            MenuFgtsDigital.Name = "MenuFgtsDigital";
            MenuFgtsDigital.Size = new Size(78, 20);
            MenuFgtsDigital.Text = "Fgts Digital";
            // 
            // SubMenuLerArquivo
            // 
            SubMenuLerArquivo.Name = "SubMenuLerArquivo";
            SubMenuLerArquivo.Size = new Size(180, 22);
            SubMenuLerArquivo.Text = "Ler Arquivo";
            SubMenuLerArquivo.Click += SubMenuLerArquivo_Click;
            // 
            // tabFgtsDigital
            // 
            tabFgtsDigital.Controls.Add(TabIdentificacao);
            tabFgtsDigital.Controls.Add(TabRemuneracao);
            tabFgtsDigital.Location = new Point(12, 27);
            tabFgtsDigital.Name = "tabFgtsDigital";
            tabFgtsDigital.SelectedIndex = 0;
            tabFgtsDigital.Size = new Size(776, 411);
            tabFgtsDigital.TabIndex = 2;
            // 
            // TabIdentificacao
            // 
            TabIdentificacao.Controls.Add(GbValidacaoIdentificacao);
            TabIdentificacao.Controls.Add(DgvIdentificacao);
            TabIdentificacao.Location = new Point(4, 24);
            TabIdentificacao.Name = "TabIdentificacao";
            TabIdentificacao.Padding = new Padding(3);
            TabIdentificacao.Size = new Size(768, 383);
            TabIdentificacao.TabIndex = 0;
            TabIdentificacao.Text = "Identificação";
            TabIdentificacao.UseVisualStyleBackColor = true;
            // 
            // GbValidacaoIdentificacao
            // 
            GbValidacaoIdentificacao.Controls.Add(RtxValidacaoIdentificacao);
            GbValidacaoIdentificacao.Location = new Point(3, 275);
            GbValidacaoIdentificacao.Name = "GbValidacaoIdentificacao";
            GbValidacaoIdentificacao.Size = new Size(759, 100);
            GbValidacaoIdentificacao.TabIndex = 1;
            GbValidacaoIdentificacao.TabStop = false;
            GbValidacaoIdentificacao.Text = "Validação";
            // 
            // RtxValidacaoIdentificacao
            // 
            RtxValidacaoIdentificacao.Dock = DockStyle.Fill;
            RtxValidacaoIdentificacao.Location = new Point(3, 19);
            RtxValidacaoIdentificacao.Name = "RtxValidacaoIdentificacao";
            RtxValidacaoIdentificacao.Size = new Size(753, 78);
            RtxValidacaoIdentificacao.TabIndex = 0;
            RtxValidacaoIdentificacao.Text = "";
            // 
            // DgvIdentificacao
            // 
            DgvIdentificacao.AllowUserToAddRows = false;
            DgvIdentificacao.AllowUserToDeleteRows = false;
            DgvIdentificacao.BackgroundColor = SystemColors.Control;
            DgvIdentificacao.BorderStyle = BorderStyle.Fixed3D;
            DgvIdentificacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvIdentificacao.Columns.AddRange(new DataGridViewColumn[] { Identifcacao, CnpjCpf, Cpf, DataAdmissao, Matricula, Categoria_Tsve });
            DgvIdentificacao.Location = new Point(6, 6);
            DgvIdentificacao.MultiSelect = false;
            DgvIdentificacao.Name = "DgvIdentificacao";
            DgvIdentificacao.ReadOnly = true;
            DgvIdentificacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvIdentificacao.Size = new Size(756, 263);
            DgvIdentificacao.TabIndex = 0;
            // 
            // Identifcacao
            // 
            Identifcacao.DataPropertyName = "Identificador";
            Identifcacao.HeaderText = "Identificação";
            Identifcacao.Name = "Identifcacao";
            Identifcacao.ReadOnly = true;
            // 
            // CnpjCpf
            // 
            CnpjCpf.DataPropertyName = "CNPJ_CPF";
            CnpjCpf.HeaderText = "CNPJ/CPF";
            CnpjCpf.Name = "CnpjCpf";
            CnpjCpf.ReadOnly = true;
            // 
            // Cpf
            // 
            Cpf.DataPropertyName = "CPF";
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            // 
            // DataAdmissao
            // 
            DataAdmissao.DataPropertyName = "DataAdmissao";
            DataAdmissao.HeaderText = "Data Admissão";
            DataAdmissao.Name = "DataAdmissao";
            DataAdmissao.ReadOnly = true;
            // 
            // Matricula
            // 
            Matricula.DataPropertyName = "Matricula";
            Matricula.HeaderText = "Matricula";
            Matricula.Name = "Matricula";
            Matricula.ReadOnly = true;
            // 
            // Categoria_Tsve
            // 
            Categoria_Tsve.DataPropertyName = "CategoriaTSVE";
            Categoria_Tsve.HeaderText = "Categoria TSVE";
            Categoria_Tsve.Name = "Categoria_Tsve";
            Categoria_Tsve.ReadOnly = true;
            // 
            // TabRemuneracao
            // 
            TabRemuneracao.Controls.Add(groupBox1);
            TabRemuneracao.Controls.Add(DgvRemuneracao);
            TabRemuneracao.Location = new Point(4, 24);
            TabRemuneracao.Name = "TabRemuneracao";
            TabRemuneracao.Padding = new Padding(3);
            TabRemuneracao.Size = new Size(768, 383);
            TabRemuneracao.TabIndex = 1;
            TabRemuneracao.Text = "Remuneração";
            TabRemuneracao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RtxValidacaoRemuneracao);
            groupBox1.Location = new Point(5, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(759, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Validação";
            // 
            // RtxValidacaoRemuneracao
            // 
            RtxValidacaoRemuneracao.Dock = DockStyle.Fill;
            RtxValidacaoRemuneracao.Location = new Point(3, 19);
            RtxValidacaoRemuneracao.Name = "RtxValidacaoRemuneracao";
            RtxValidacaoRemuneracao.Size = new Size(753, 78);
            RtxValidacaoRemuneracao.TabIndex = 0;
            RtxValidacaoRemuneracao.Text = "";
            // 
            // DgvRemuneracao
            // 
            DgvRemuneracao.AllowUserToAddRows = false;
            DgvRemuneracao.AllowUserToDeleteRows = false;
            DgvRemuneracao.BackgroundColor = SystemColors.Control;
            DgvRemuneracao.BorderStyle = BorderStyle.Fixed3D;
            DgvRemuneracao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRemuneracao.Columns.AddRange(new DataGridViewColumn[] { IdentificaoRemuneracao, Competencia, Categoria, Valor_principal, valor_13_salario, Ind_ausencia_FGTS });
            DgvRemuneracao.Location = new Point(8, 7);
            DgvRemuneracao.MultiSelect = false;
            DgvRemuneracao.Name = "DgvRemuneracao";
            DgvRemuneracao.ReadOnly = true;
            DgvRemuneracao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvRemuneracao.Size = new Size(756, 263);
            DgvRemuneracao.TabIndex = 2;
            // 
            // IdentificaoRemuneracao
            // 
            IdentificaoRemuneracao.DataPropertyName = "Identificador";
            IdentificaoRemuneracao.HeaderText = "Identificação";
            IdentificaoRemuneracao.Name = "IdentificaoRemuneracao";
            IdentificaoRemuneracao.ReadOnly = true;
            // 
            // Competencia
            // 
            Competencia.DataPropertyName = "Competencia";
            Competencia.HeaderText = "Competência";
            Competencia.Name = "Competencia";
            Competencia.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Valor_principal
            // 
            Valor_principal.DataPropertyName = "ValorPrincipal";
            Valor_principal.HeaderText = "Valor Principal";
            Valor_principal.Name = "Valor_principal";
            Valor_principal.ReadOnly = true;
            // 
            // valor_13_salario
            // 
            valor_13_salario.DataPropertyName = "Valor13Salario";
            valor_13_salario.HeaderText = "Valor 13º Salário";
            valor_13_salario.Name = "valor_13_salario";
            valor_13_salario.ReadOnly = true;
            // 
            // Ind_ausencia_FGTS
            // 
            Ind_ausencia_FGTS.DataPropertyName = "IndAusenciaFGTS";
            Ind_ausencia_FGTS.HeaderText = "Ind. Ausencia FGTS";
            Ind_ausencia_FGTS.Name = "Ind_ausencia_FGTS";
            Ind_ausencia_FGTS.ReadOnly = true;
            // 
            // FrmLeitorFgtsDigital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabFgtsDigital);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmLeitorFgtsDigital";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fgts Digital";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabFgtsDigital.ResumeLayout(false);
            TabIdentificacao.ResumeLayout(false);
            GbValidacaoIdentificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvIdentificacao).EndInit();
            TabRemuneracao.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvRemuneracao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuFgtsDigital;
        private ToolStripMenuItem SubMenuLerArquivo;
        private TabControl tabFgtsDigital;
        private TabPage TabIdentificacao;
        private TabPage TabRemuneracao;
        private DataGridView DgvIdentificacao;
        private GroupBox GbValidacaoIdentificacao;
        private RichTextBox RtxValidacaoIdentificacao;
        private GroupBox groupBox1;
        private RichTextBox RtxValidacaoRemuneracao;
        private DataGridView DgvRemuneracao;
        private DataGridViewTextBoxColumn Identifcacao;
        private DataGridViewTextBoxColumn CnpjCpf;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn DataAdmissao;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Categoria_Tsve;
        private DataGridViewTextBoxColumn IdentificaoRemuneracao;
        private DataGridViewTextBoxColumn Competencia;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Valor_principal;
        private DataGridViewTextBoxColumn valor_13_salario;
        private DataGridViewTextBoxColumn Ind_ausencia_FGTS;
    }
}