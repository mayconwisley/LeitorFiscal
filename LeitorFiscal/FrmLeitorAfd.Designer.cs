namespace LeitorFiscal
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
            MenuConverter = new ToolStripMenuItem();
            SubMenuConverterArt96 = new ToolStripMenuItem();
            TabControlAfd = new TabControl();
            Cabecalho = new TabPage();
            GbValidacao = new GroupBox();
            RTxtLogCabecalho = new RichTextBox();
            DgvListCabecalho = new DataGridView();
            IdentifcacaoEmpresa = new TabPage();
            groupBox1 = new GroupBox();
            RTxtLogIdentificacaoEmpresa = new RichTextBox();
            DgvListIdentificacaoEmpresa = new DataGridView();
            MarcacaoPonto = new TabPage();
            groupBox2 = new GroupBox();
            RTxtLogMarcacaoPonto = new RichTextBox();
            DgvListMarcacaoPonto = new DataGridView();
            RelogioTempoReal = new TabPage();
            groupBox3 = new GroupBox();
            RTxtLogRelogioTempoReal1510 = new RichTextBox();
            DgvListRelogioTempoReal1510 = new DataGridView();
            EmpregadoMt = new TabPage();
            groupBox4 = new GroupBox();
            RTxtLogEmpregadoMt1510 = new RichTextBox();
            DgvListEmpregadoMt1510 = new DataGridView();
            EventosSensiveis = new TabPage();
            groupBox5 = new GroupBox();
            RTxtLogEventoSensiveis1510 = new RichTextBox();
            DgvListEventoSensiveis1510 = new DataGridView();
            Trailer = new TabPage();
            groupBox8 = new GroupBox();
            RTxtLogTrailer1510 = new RichTextBox();
            DgvListTrailer1510 = new DataGridView();
            MenuAfd.SuspendLayout();
            TabControlAfd.SuspendLayout();
            Cabecalho.SuspendLayout();
            GbValidacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListCabecalho).BeginInit();
            IdentifcacaoEmpresa.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListIdentificacaoEmpresa).BeginInit();
            MarcacaoPonto.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListMarcacaoPonto).BeginInit();
            RelogioTempoReal.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListRelogioTempoReal1510).BeginInit();
            EmpregadoMt.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListEmpregadoMt1510).BeginInit();
            EventosSensiveis.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListEventoSensiveis1510).BeginInit();
            Trailer.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListTrailer1510).BeginInit();
            SuspendLayout();
            // 
            // MenuAfd
            // 
            MenuAfd.BackColor = Color.Transparent;
            MenuAfd.Items.AddRange(new ToolStripItem[] { MenuArquivo, MenuConverter });
            MenuAfd.Location = new Point(0, 0);
            MenuAfd.Name = "MenuAfd";
            MenuAfd.Size = new Size(823, 24);
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
            SubMenuArquivoLer.Size = new Size(90, 22);
            SubMenuArquivoLer.Text = "Ler";
            SubMenuArquivoLer.Click += SubMenuArquivoLer_Click;
            // 
            // MenuConverter
            // 
            MenuConverter.DropDownItems.AddRange(new ToolStripItem[] { SubMenuConverterArt96 });
            MenuConverter.Name = "MenuConverter";
            MenuConverter.Size = new Size(71, 20);
            MenuConverter.Text = "Converter";
            // 
            // SubMenuConverterArt96
            // 
            SubMenuConverterArt96.Name = "SubMenuConverterArt96";
            SubMenuConverterArt96.Size = new Size(173, 22);
            SubMenuConverterArt96.Text = "Art. 96 Portaria 671";
            // 
            // TabControlAfd
            // 
            TabControlAfd.Controls.Add(Cabecalho);
            TabControlAfd.Controls.Add(IdentifcacaoEmpresa);
            TabControlAfd.Controls.Add(MarcacaoPonto);
            TabControlAfd.Controls.Add(RelogioTempoReal);
            TabControlAfd.Controls.Add(EmpregadoMt);
            TabControlAfd.Controls.Add(EventosSensiveis);
            TabControlAfd.Controls.Add(Trailer);
            TabControlAfd.Location = new Point(5, 27);
            TabControlAfd.Name = "TabControlAfd";
            TabControlAfd.SelectedIndex = 0;
            TabControlAfd.Size = new Size(812, 548);
            TabControlAfd.TabIndex = 3;
            // 
            // Cabecalho
            // 
            Cabecalho.Controls.Add(GbValidacao);
            Cabecalho.Controls.Add(DgvListCabecalho);
            Cabecalho.Location = new Point(4, 24);
            Cabecalho.Name = "Cabecalho";
            Cabecalho.Padding = new Padding(3);
            Cabecalho.Size = new Size(804, 520);
            Cabecalho.TabIndex = 0;
            Cabecalho.Text = "1 - Cabeçalho";
            Cabecalho.UseVisualStyleBackColor = true;
            // 
            // GbValidacao
            // 
            GbValidacao.Controls.Add(RTxtLogCabecalho);
            GbValidacao.Location = new Point(3, 375);
            GbValidacao.Name = "GbValidacao";
            GbValidacao.Size = new Size(794, 136);
            GbValidacao.TabIndex = 1;
            GbValidacao.TabStop = false;
            GbValidacao.Text = "Validações Cabeçalho";
            // 
            // RTxtLogCabecalho
            // 
            RTxtLogCabecalho.Dock = DockStyle.Fill;
            RTxtLogCabecalho.Location = new Point(3, 19);
            RTxtLogCabecalho.Name = "RTxtLogCabecalho";
            RTxtLogCabecalho.ReadOnly = true;
            RTxtLogCabecalho.Size = new Size(788, 114);
            RTxtLogCabecalho.TabIndex = 0;
            RTxtLogCabecalho.Text = "";
            // 
            // DgvListCabecalho
            // 
            DgvListCabecalho.AllowUserToAddRows = false;
            DgvListCabecalho.AllowUserToDeleteRows = false;
            DgvListCabecalho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListCabecalho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListCabecalho.BackgroundColor = SystemColors.Control;
            DgvListCabecalho.BorderStyle = BorderStyle.Fixed3D;
            DgvListCabecalho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListCabecalho.Location = new Point(3, 3);
            DgvListCabecalho.MultiSelect = false;
            DgvListCabecalho.Name = "DgvListCabecalho";
            DgvListCabecalho.ReadOnly = true;
            DgvListCabecalho.RowTemplate.Height = 25;
            DgvListCabecalho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListCabecalho.Size = new Size(794, 366);
            DgvListCabecalho.TabIndex = 0;
            // 
            // IdentifcacaoEmpresa
            // 
            IdentifcacaoEmpresa.Controls.Add(groupBox1);
            IdentifcacaoEmpresa.Controls.Add(DgvListIdentificacaoEmpresa);
            IdentifcacaoEmpresa.Location = new Point(4, 24);
            IdentifcacaoEmpresa.Name = "IdentifcacaoEmpresa";
            IdentifcacaoEmpresa.Padding = new Padding(3);
            IdentifcacaoEmpresa.Size = new Size(804, 520);
            IdentifcacaoEmpresa.TabIndex = 1;
            IdentifcacaoEmpresa.Text = "2 - Identificação Empresa";
            IdentifcacaoEmpresa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RTxtLogIdentificacaoEmpresa);
            groupBox1.Location = new Point(3, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Validações Identificação Empresa";
            // 
            // RTxtLogIdentificacaoEmpresa
            // 
            RTxtLogIdentificacaoEmpresa.Dock = DockStyle.Fill;
            RTxtLogIdentificacaoEmpresa.Location = new Point(3, 19);
            RTxtLogIdentificacaoEmpresa.Name = "RTxtLogIdentificacaoEmpresa";
            RTxtLogIdentificacaoEmpresa.ReadOnly = true;
            RTxtLogIdentificacaoEmpresa.Size = new Size(791, 114);
            RTxtLogIdentificacaoEmpresa.TabIndex = 0;
            RTxtLogIdentificacaoEmpresa.Text = "";
            // 
            // DgvListIdentificacaoEmpresa
            // 
            DgvListIdentificacaoEmpresa.AllowUserToAddRows = false;
            DgvListIdentificacaoEmpresa.AllowUserToDeleteRows = false;
            DgvListIdentificacaoEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListIdentificacaoEmpresa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListIdentificacaoEmpresa.BackgroundColor = SystemColors.Control;
            DgvListIdentificacaoEmpresa.BorderStyle = BorderStyle.Fixed3D;
            DgvListIdentificacaoEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListIdentificacaoEmpresa.Location = new Point(3, 3);
            DgvListIdentificacaoEmpresa.MultiSelect = false;
            DgvListIdentificacaoEmpresa.Name = "DgvListIdentificacaoEmpresa";
            DgvListIdentificacaoEmpresa.ReadOnly = true;
            DgvListIdentificacaoEmpresa.RowTemplate.Height = 25;
            DgvListIdentificacaoEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListIdentificacaoEmpresa.Size = new Size(797, 366);
            DgvListIdentificacaoEmpresa.TabIndex = 0;
            // 
            // MarcacaoPonto
            // 
            MarcacaoPonto.Controls.Add(groupBox2);
            MarcacaoPonto.Controls.Add(DgvListMarcacaoPonto);
            MarcacaoPonto.Location = new Point(4, 24);
            MarcacaoPonto.Name = "MarcacaoPonto";
            MarcacaoPonto.Padding = new Padding(3);
            MarcacaoPonto.Size = new Size(804, 520);
            MarcacaoPonto.TabIndex = 2;
            MarcacaoPonto.Text = "3 - Marcação Ponto";
            MarcacaoPonto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RTxtLogMarcacaoPonto);
            groupBox2.Location = new Point(3, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(797, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Validações Marcao Ponto";
            // 
            // RTxtLogMarcacaoPonto
            // 
            RTxtLogMarcacaoPonto.Dock = DockStyle.Fill;
            RTxtLogMarcacaoPonto.Location = new Point(3, 19);
            RTxtLogMarcacaoPonto.Name = "RTxtLogMarcacaoPonto";
            RTxtLogMarcacaoPonto.ReadOnly = true;
            RTxtLogMarcacaoPonto.Size = new Size(791, 114);
            RTxtLogMarcacaoPonto.TabIndex = 0;
            RTxtLogMarcacaoPonto.Text = "";
            // 
            // DgvListMarcacaoPonto
            // 
            DgvListMarcacaoPonto.AllowUserToAddRows = false;
            DgvListMarcacaoPonto.AllowUserToDeleteRows = false;
            DgvListMarcacaoPonto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListMarcacaoPonto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListMarcacaoPonto.BackgroundColor = SystemColors.Control;
            DgvListMarcacaoPonto.BorderStyle = BorderStyle.Fixed3D;
            DgvListMarcacaoPonto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListMarcacaoPonto.Location = new Point(3, 3);
            DgvListMarcacaoPonto.MultiSelect = false;
            DgvListMarcacaoPonto.Name = "DgvListMarcacaoPonto";
            DgvListMarcacaoPonto.ReadOnly = true;
            DgvListMarcacaoPonto.RowTemplate.Height = 25;
            DgvListMarcacaoPonto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListMarcacaoPonto.Size = new Size(797, 366);
            DgvListMarcacaoPonto.TabIndex = 0;
            // 
            // RelogioTempoReal
            // 
            RelogioTempoReal.Controls.Add(groupBox3);
            RelogioTempoReal.Controls.Add(DgvListRelogioTempoReal1510);
            RelogioTempoReal.Location = new Point(4, 24);
            RelogioTempoReal.Name = "RelogioTempoReal";
            RelogioTempoReal.Size = new Size(804, 520);
            RelogioTempoReal.TabIndex = 3;
            RelogioTempoReal.Text = "4 - Relogio Tempo Real";
            RelogioTempoReal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RTxtLogRelogioTempoReal1510);
            groupBox3.Location = new Point(3, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 136);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Validações Relógio Tempo Real";
            // 
            // RTxtLogRelogioTempoReal1510
            // 
            RTxtLogRelogioTempoReal1510.Dock = DockStyle.Fill;
            RTxtLogRelogioTempoReal1510.Location = new Point(3, 19);
            RTxtLogRelogioTempoReal1510.Name = "RTxtLogRelogioTempoReal1510";
            RTxtLogRelogioTempoReal1510.ReadOnly = true;
            RTxtLogRelogioTempoReal1510.Size = new Size(794, 114);
            RTxtLogRelogioTempoReal1510.TabIndex = 0;
            RTxtLogRelogioTempoReal1510.Text = "";
            // 
            // DgvListRelogioTempoReal1510
            // 
            DgvListRelogioTempoReal1510.AllowUserToAddRows = false;
            DgvListRelogioTempoReal1510.AllowUserToDeleteRows = false;
            DgvListRelogioTempoReal1510.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListRelogioTempoReal1510.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListRelogioTempoReal1510.BackgroundColor = SystemColors.Control;
            DgvListRelogioTempoReal1510.BorderStyle = BorderStyle.Fixed3D;
            DgvListRelogioTempoReal1510.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListRelogioTempoReal1510.Location = new Point(3, 3);
            DgvListRelogioTempoReal1510.MultiSelect = false;
            DgvListRelogioTempoReal1510.Name = "DgvListRelogioTempoReal1510";
            DgvListRelogioTempoReal1510.ReadOnly = true;
            DgvListRelogioTempoReal1510.RowTemplate.Height = 25;
            DgvListRelogioTempoReal1510.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListRelogioTempoReal1510.Size = new Size(800, 366);
            DgvListRelogioTempoReal1510.TabIndex = 0;
            // 
            // EmpregadoMt
            // 
            EmpregadoMt.Controls.Add(groupBox4);
            EmpregadoMt.Controls.Add(DgvListEmpregadoMt1510);
            EmpregadoMt.Location = new Point(4, 24);
            EmpregadoMt.Name = "EmpregadoMt";
            EmpregadoMt.Size = new Size(804, 520);
            EmpregadoMt.TabIndex = 4;
            EmpregadoMt.Text = "5 - Empregado do MT";
            EmpregadoMt.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RTxtLogEmpregadoMt1510);
            groupBox4.Location = new Point(3, 375);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(800, 136);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Validações Empregado MT";
            // 
            // RTxtLogEmpregadoMt1510
            // 
            RTxtLogEmpregadoMt1510.Dock = DockStyle.Fill;
            RTxtLogEmpregadoMt1510.Location = new Point(3, 19);
            RTxtLogEmpregadoMt1510.Name = "RTxtLogEmpregadoMt1510";
            RTxtLogEmpregadoMt1510.ReadOnly = true;
            RTxtLogEmpregadoMt1510.Size = new Size(794, 114);
            RTxtLogEmpregadoMt1510.TabIndex = 0;
            RTxtLogEmpregadoMt1510.Text = "";
            // 
            // DgvListEmpregadoMt1510
            // 
            DgvListEmpregadoMt1510.AllowUserToAddRows = false;
            DgvListEmpregadoMt1510.AllowUserToDeleteRows = false;
            DgvListEmpregadoMt1510.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListEmpregadoMt1510.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListEmpregadoMt1510.BackgroundColor = SystemColors.Control;
            DgvListEmpregadoMt1510.BorderStyle = BorderStyle.Fixed3D;
            DgvListEmpregadoMt1510.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListEmpregadoMt1510.Location = new Point(3, 3);
            DgvListEmpregadoMt1510.MultiSelect = false;
            DgvListEmpregadoMt1510.Name = "DgvListEmpregadoMt1510";
            DgvListEmpregadoMt1510.ReadOnly = true;
            DgvListEmpregadoMt1510.RowTemplate.Height = 25;
            DgvListEmpregadoMt1510.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListEmpregadoMt1510.Size = new Size(800, 366);
            DgvListEmpregadoMt1510.TabIndex = 0;
            // 
            // EventosSensiveis
            // 
            EventosSensiveis.Controls.Add(groupBox5);
            EventosSensiveis.Controls.Add(DgvListEventoSensiveis1510);
            EventosSensiveis.Location = new Point(4, 24);
            EventosSensiveis.Name = "EventosSensiveis";
            EventosSensiveis.Size = new Size(804, 520);
            EventosSensiveis.TabIndex = 5;
            EventosSensiveis.Text = "6 - Eventos Sensíveis";
            EventosSensiveis.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(RTxtLogEventoSensiveis1510);
            groupBox5.Location = new Point(3, 375);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(800, 136);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Validações Evento Sensíveis";
            // 
            // RTxtLogEventoSensiveis1510
            // 
            RTxtLogEventoSensiveis1510.Dock = DockStyle.Fill;
            RTxtLogEventoSensiveis1510.Location = new Point(3, 19);
            RTxtLogEventoSensiveis1510.Name = "RTxtLogEventoSensiveis1510";
            RTxtLogEventoSensiveis1510.ReadOnly = true;
            RTxtLogEventoSensiveis1510.Size = new Size(794, 114);
            RTxtLogEventoSensiveis1510.TabIndex = 0;
            RTxtLogEventoSensiveis1510.Text = "";
            // 
            // DgvListEventoSensiveis1510
            // 
            DgvListEventoSensiveis1510.AllowUserToAddRows = false;
            DgvListEventoSensiveis1510.AllowUserToDeleteRows = false;
            DgvListEventoSensiveis1510.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListEventoSensiveis1510.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListEventoSensiveis1510.BackgroundColor = SystemColors.Control;
            DgvListEventoSensiveis1510.BorderStyle = BorderStyle.Fixed3D;
            DgvListEventoSensiveis1510.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListEventoSensiveis1510.Location = new Point(3, 3);
            DgvListEventoSensiveis1510.MultiSelect = false;
            DgvListEventoSensiveis1510.Name = "DgvListEventoSensiveis1510";
            DgvListEventoSensiveis1510.ReadOnly = true;
            DgvListEventoSensiveis1510.RowTemplate.Height = 25;
            DgvListEventoSensiveis1510.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListEventoSensiveis1510.Size = new Size(800, 366);
            DgvListEventoSensiveis1510.TabIndex = 0;
            // 
            // Trailer
            // 
            Trailer.Controls.Add(groupBox8);
            Trailer.Controls.Add(DgvListTrailer1510);
            Trailer.Location = new Point(4, 24);
            Trailer.Name = "Trailer";
            Trailer.Size = new Size(804, 520);
            Trailer.TabIndex = 8;
            Trailer.Text = "9 - Trailer";
            Trailer.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox8.Controls.Add(RTxtLogTrailer1510);
            groupBox8.Location = new Point(3, 375);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(800, 136);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Validações Trailer";
            // 
            // RTxtLogTrailer1510
            // 
            RTxtLogTrailer1510.Dock = DockStyle.Fill;
            RTxtLogTrailer1510.Location = new Point(3, 19);
            RTxtLogTrailer1510.Name = "RTxtLogTrailer1510";
            RTxtLogTrailer1510.ReadOnly = true;
            RTxtLogTrailer1510.Size = new Size(794, 114);
            RTxtLogTrailer1510.TabIndex = 0;
            RTxtLogTrailer1510.Text = "";
            // 
            // DgvListTrailer1510
            // 
            DgvListTrailer1510.AllowUserToAddRows = false;
            DgvListTrailer1510.AllowUserToDeleteRows = false;
            DgvListTrailer1510.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListTrailer1510.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListTrailer1510.BackgroundColor = SystemColors.Control;
            DgvListTrailer1510.BorderStyle = BorderStyle.Fixed3D;
            DgvListTrailer1510.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListTrailer1510.Dock = DockStyle.Fill;
            DgvListTrailer1510.Location = new Point(0, 0);
            DgvListTrailer1510.MultiSelect = false;
            DgvListTrailer1510.Name = "DgvListTrailer1510";
            DgvListTrailer1510.ReadOnly = true;
            DgvListTrailer1510.RowTemplate.Height = 25;
            DgvListTrailer1510.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListTrailer1510.Size = new Size(804, 520);
            DgvListTrailer1510.TabIndex = 0;
            // 
            // FrmLeitorAfd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 586);
            Controls.Add(TabControlAfd);
            Controls.Add(MenuAfd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = MenuAfd;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLeitorAfd";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arquivo-Fonte de Dados – AFD";
            MenuAfd.ResumeLayout(false);
            MenuAfd.PerformLayout();
            TabControlAfd.ResumeLayout(false);
            Cabecalho.ResumeLayout(false);
            GbValidacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListCabecalho).EndInit();
            IdentifcacaoEmpresa.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListIdentificacaoEmpresa).EndInit();
            MarcacaoPonto.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListMarcacaoPonto).EndInit();
            RelogioTempoReal.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListRelogioTempoReal1510).EndInit();
            EmpregadoMt.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListEmpregadoMt1510).EndInit();
            EventosSensiveis.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListEventoSensiveis1510).EndInit();
            Trailer.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListTrailer1510).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuAfd;
        private ToolStripMenuItem MenuArquivo;
        private ToolStripMenuItem SubMenuArquivoLer;
        private TabControl TabControlAfd;
        private TabPage Cabecalho;
        private GroupBox GbValidacao;
        private RichTextBox RTxtLogCabecalho;
        private DataGridView DgvListCabecalho;
        private TabPage IdentifcacaoEmpresa;
        private GroupBox groupBox1;
        private RichTextBox RTxtLogIdentificacaoEmpresa;
        private DataGridView DgvListIdentificacaoEmpresa;
        private TabPage MarcacaoPonto;
        private GroupBox groupBox2;
        private RichTextBox RTxtLogMarcacaoPonto;
        private DataGridView DgvListMarcacaoPonto;
        private TabPage RelogioTempoReal;
        private GroupBox groupBox3;
        private RichTextBox RTxtLogRelogioTempoReal1510;
        private DataGridView DgvListRelogioTempoReal1510;
        private TabPage EmpregadoMt;
        private GroupBox groupBox4;
        private RichTextBox RTxtLogEmpregadoMt1510;
        private DataGridView DgvListEmpregadoMt1510;
        private TabPage EventosSensiveis;
        private GroupBox groupBox5;
        private RichTextBox RTxtLogEventoSensiveis1510;
        private DataGridView DgvListEventoSensiveis1510;
        private TabPage Trailer;
        private GroupBox groupBox8;
        private RichTextBox RTxtLogTrailer1510;
        private DataGridView DgvListTrailer1510;
        private ToolStripMenuItem MenuConverter;
        private ToolStripMenuItem SubMenuConverterArt96;
    }
}