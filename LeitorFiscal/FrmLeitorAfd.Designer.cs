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
            MenuValidacao = new ToolStripMenuItem();
            SubMenuValidacaoListar = new ToolStripMenuItem();
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
            RTxtLogRelogioTempoReal = new RichTextBox();
            DgvListRelogioTempoReal = new DataGridView();
            EmpregadoMt = new TabPage();
            groupBox4 = new GroupBox();
            RTxtLogEmpregadoMt = new RichTextBox();
            DgvListEmpregadoMt = new DataGridView();
            EventosSensiveis = new TabPage();
            groupBox5 = new GroupBox();
            RTxtLogEventoSensiveis = new RichTextBox();
            DgvListEventoSensiveis = new DataGridView();
            MarcacaoPontoRepP = new TabPage();
            groupBox6 = new GroupBox();
            RTxtLogMarcacaoPontoRepP = new RichTextBox();
            DgvListMarcacaoPontoRepP = new DataGridView();
            Trailer = new TabPage();
            groupBox8 = new GroupBox();
            RTxtLogTrailer = new RichTextBox();
            DgvListTrailer = new DataGridView();
            AssinaturaDigital = new TabPage();
            groupBox7 = new GroupBox();
            RTxtLogAssinaturaDigital = new RichTextBox();
            DgvListAssinaturaDigital = new DataGridView();
            LblInfoPaginas = new Label();
            BtnProximo = new Button();
            BtnAnterior = new Button();
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
            ((System.ComponentModel.ISupportInitialize)DgvListRelogioTempoReal).BeginInit();
            EmpregadoMt.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListEmpregadoMt).BeginInit();
            EventosSensiveis.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListEventoSensiveis).BeginInit();
            MarcacaoPontoRepP.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListMarcacaoPontoRepP).BeginInit();
            Trailer.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListTrailer).BeginInit();
            AssinaturaDigital.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListAssinaturaDigital).BeginInit();
            SuspendLayout();
            // 
            // MenuAfd
            // 
            MenuAfd.BackColor = Color.Transparent;
            MenuAfd.Items.AddRange(new ToolStripItem[] { MenuArquivo, MenuConverter, MenuValidacao });
            MenuAfd.Location = new Point(0, 0);
            MenuAfd.Name = "MenuAfd";
            MenuAfd.Size = new Size(1067, 24);
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
            MenuConverter.Enabled = false;
            MenuConverter.Name = "MenuConverter";
            MenuConverter.Size = new Size(71, 20);
            MenuConverter.Text = "Converter";
            // 
            // SubMenuConverterArt96
            // 
            SubMenuConverterArt96.Name = "SubMenuConverterArt96";
            SubMenuConverterArt96.Size = new Size(173, 22);
            SubMenuConverterArt96.Text = "Art. 96 Portaria 671";
            SubMenuConverterArt96.Click += SubMenuConverterArt96_Click;
            // 
            // MenuValidacao
            // 
            MenuValidacao.DropDownItems.AddRange(new ToolStripItem[] { SubMenuValidacaoListar });
            MenuValidacao.Enabled = false;
            MenuValidacao.Name = "MenuValidacao";
            MenuValidacao.Size = new Size(74, 20);
            MenuValidacao.Text = "Validações";
            // 
            // SubMenuValidacaoListar
            // 
            SubMenuValidacaoListar.Name = "SubMenuValidacaoListar";
            SubMenuValidacaoListar.Size = new Size(102, 22);
            SubMenuValidacaoListar.Text = "Listar";
            SubMenuValidacaoListar.Click += SubMenuValidacaoListar_Click;
            // 
            // TabControlAfd
            // 
            TabControlAfd.Controls.Add(Cabecalho);
            TabControlAfd.Controls.Add(IdentifcacaoEmpresa);
            TabControlAfd.Controls.Add(MarcacaoPonto);
            TabControlAfd.Controls.Add(RelogioTempoReal);
            TabControlAfd.Controls.Add(EmpregadoMt);
            TabControlAfd.Controls.Add(EventosSensiveis);
            TabControlAfd.Controls.Add(MarcacaoPontoRepP);
            TabControlAfd.Controls.Add(Trailer);
            TabControlAfd.Controls.Add(AssinaturaDigital);
            TabControlAfd.Location = new Point(5, 27);
            TabControlAfd.Name = "TabControlAfd";
            TabControlAfd.SelectedIndex = 0;
            TabControlAfd.Size = new Size(1056, 548);
            TabControlAfd.TabIndex = 3;
            // 
            // Cabecalho
            // 
            Cabecalho.Controls.Add(GbValidacao);
            Cabecalho.Controls.Add(DgvListCabecalho);
            Cabecalho.Location = new Point(4, 24);
            Cabecalho.Name = "Cabecalho";
            Cabecalho.Padding = new Padding(3);
            Cabecalho.Size = new Size(1048, 520);
            Cabecalho.TabIndex = 0;
            Cabecalho.Text = "1 - Cabeçalho";
            Cabecalho.UseVisualStyleBackColor = true;
            // 
            // GbValidacao
            // 
            GbValidacao.Controls.Add(RTxtLogCabecalho);
            GbValidacao.Location = new Point(6, 375);
            GbValidacao.Name = "GbValidacao";
            GbValidacao.Size = new Size(1036, 139);
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
            RTxtLogCabecalho.Size = new Size(1030, 117);
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
            DgvListCabecalho.Location = new Point(6, 6);
            DgvListCabecalho.MultiSelect = false;
            DgvListCabecalho.Name = "DgvListCabecalho";
            DgvListCabecalho.ReadOnly = true;
            DgvListCabecalho.RowTemplate.Height = 25;
            DgvListCabecalho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListCabecalho.Size = new Size(1036, 363);
            DgvListCabecalho.TabIndex = 0;
            // 
            // IdentifcacaoEmpresa
            // 
            IdentifcacaoEmpresa.Controls.Add(groupBox1);
            IdentifcacaoEmpresa.Controls.Add(DgvListIdentificacaoEmpresa);
            IdentifcacaoEmpresa.Location = new Point(4, 24);
            IdentifcacaoEmpresa.Name = "IdentifcacaoEmpresa";
            IdentifcacaoEmpresa.Padding = new Padding(3);
            IdentifcacaoEmpresa.Size = new Size(1048, 520);
            IdentifcacaoEmpresa.TabIndex = 1;
            IdentifcacaoEmpresa.Text = "2 - Identificação Empresa";
            IdentifcacaoEmpresa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RTxtLogIdentificacaoEmpresa);
            groupBox1.Location = new Point(6, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1036, 139);
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
            RTxtLogIdentificacaoEmpresa.Size = new Size(1030, 117);
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
            DgvListIdentificacaoEmpresa.Location = new Point(6, 6);
            DgvListIdentificacaoEmpresa.MultiSelect = false;
            DgvListIdentificacaoEmpresa.Name = "DgvListIdentificacaoEmpresa";
            DgvListIdentificacaoEmpresa.ReadOnly = true;
            DgvListIdentificacaoEmpresa.RowTemplate.Height = 25;
            DgvListIdentificacaoEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListIdentificacaoEmpresa.Size = new Size(1036, 363);
            DgvListIdentificacaoEmpresa.TabIndex = 0;
            // 
            // MarcacaoPonto
            // 
            MarcacaoPonto.Controls.Add(groupBox2);
            MarcacaoPonto.Controls.Add(DgvListMarcacaoPonto);
            MarcacaoPonto.Location = new Point(4, 24);
            MarcacaoPonto.Name = "MarcacaoPonto";
            MarcacaoPonto.Padding = new Padding(3);
            MarcacaoPonto.Size = new Size(1048, 520);
            MarcacaoPonto.TabIndex = 2;
            MarcacaoPonto.Text = "3 - Marcação Ponto";
            MarcacaoPonto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RTxtLogMarcacaoPonto);
            groupBox2.Location = new Point(6, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1036, 139);
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
            RTxtLogMarcacaoPonto.Size = new Size(1030, 117);
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
            DgvListMarcacaoPonto.Location = new Point(6, 6);
            DgvListMarcacaoPonto.MultiSelect = false;
            DgvListMarcacaoPonto.Name = "DgvListMarcacaoPonto";
            DgvListMarcacaoPonto.ReadOnly = true;
            DgvListMarcacaoPonto.RowTemplate.Height = 25;
            DgvListMarcacaoPonto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListMarcacaoPonto.Size = new Size(1036, 363);
            DgvListMarcacaoPonto.TabIndex = 0;
            // 
            // RelogioTempoReal
            // 
            RelogioTempoReal.Controls.Add(groupBox3);
            RelogioTempoReal.Controls.Add(DgvListRelogioTempoReal);
            RelogioTempoReal.Location = new Point(4, 24);
            RelogioTempoReal.Name = "RelogioTempoReal";
            RelogioTempoReal.Size = new Size(1048, 520);
            RelogioTempoReal.TabIndex = 3;
            RelogioTempoReal.Text = "4 - Relogio Tempo Real";
            RelogioTempoReal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RTxtLogRelogioTempoReal);
            groupBox3.Location = new Point(6, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1036, 139);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Validações Relógio Tempo Real";
            // 
            // RTxtLogRelogioTempoReal
            // 
            RTxtLogRelogioTempoReal.Dock = DockStyle.Fill;
            RTxtLogRelogioTempoReal.Location = new Point(3, 19);
            RTxtLogRelogioTempoReal.Name = "RTxtLogRelogioTempoReal";
            RTxtLogRelogioTempoReal.ReadOnly = true;
            RTxtLogRelogioTempoReal.Size = new Size(1030, 117);
            RTxtLogRelogioTempoReal.TabIndex = 0;
            RTxtLogRelogioTempoReal.Text = "";
            // 
            // DgvListRelogioTempoReal
            // 
            DgvListRelogioTempoReal.AllowUserToAddRows = false;
            DgvListRelogioTempoReal.AllowUserToDeleteRows = false;
            DgvListRelogioTempoReal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListRelogioTempoReal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListRelogioTempoReal.BackgroundColor = SystemColors.Control;
            DgvListRelogioTempoReal.BorderStyle = BorderStyle.Fixed3D;
            DgvListRelogioTempoReal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListRelogioTempoReal.Location = new Point(6, 6);
            DgvListRelogioTempoReal.MultiSelect = false;
            DgvListRelogioTempoReal.Name = "DgvListRelogioTempoReal";
            DgvListRelogioTempoReal.ReadOnly = true;
            DgvListRelogioTempoReal.RowTemplate.Height = 25;
            DgvListRelogioTempoReal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListRelogioTempoReal.Size = new Size(1036, 363);
            DgvListRelogioTempoReal.TabIndex = 0;
            // 
            // EmpregadoMt
            // 
            EmpregadoMt.Controls.Add(groupBox4);
            EmpregadoMt.Controls.Add(DgvListEmpregadoMt);
            EmpregadoMt.Location = new Point(4, 24);
            EmpregadoMt.Name = "EmpregadoMt";
            EmpregadoMt.Size = new Size(1048, 520);
            EmpregadoMt.TabIndex = 4;
            EmpregadoMt.Text = "5 - Empregado do MT";
            EmpregadoMt.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RTxtLogEmpregadoMt);
            groupBox4.Location = new Point(6, 375);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1036, 139);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Validações Empregado MT";
            // 
            // RTxtLogEmpregadoMt
            // 
            RTxtLogEmpregadoMt.Dock = DockStyle.Fill;
            RTxtLogEmpregadoMt.Location = new Point(3, 19);
            RTxtLogEmpregadoMt.Name = "RTxtLogEmpregadoMt";
            RTxtLogEmpregadoMt.ReadOnly = true;
            RTxtLogEmpregadoMt.Size = new Size(1030, 117);
            RTxtLogEmpregadoMt.TabIndex = 0;
            RTxtLogEmpregadoMt.Text = "";
            // 
            // DgvListEmpregadoMt
            // 
            DgvListEmpregadoMt.AllowUserToAddRows = false;
            DgvListEmpregadoMt.AllowUserToDeleteRows = false;
            DgvListEmpregadoMt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListEmpregadoMt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListEmpregadoMt.BackgroundColor = SystemColors.Control;
            DgvListEmpregadoMt.BorderStyle = BorderStyle.Fixed3D;
            DgvListEmpregadoMt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListEmpregadoMt.Location = new Point(6, 6);
            DgvListEmpregadoMt.MultiSelect = false;
            DgvListEmpregadoMt.Name = "DgvListEmpregadoMt";
            DgvListEmpregadoMt.ReadOnly = true;
            DgvListEmpregadoMt.RowTemplate.Height = 25;
            DgvListEmpregadoMt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListEmpregadoMt.Size = new Size(1036, 363);
            DgvListEmpregadoMt.TabIndex = 0;
            // 
            // EventosSensiveis
            // 
            EventosSensiveis.Controls.Add(groupBox5);
            EventosSensiveis.Controls.Add(DgvListEventoSensiveis);
            EventosSensiveis.Location = new Point(4, 24);
            EventosSensiveis.Name = "EventosSensiveis";
            EventosSensiveis.Size = new Size(1048, 520);
            EventosSensiveis.TabIndex = 5;
            EventosSensiveis.Text = "6 - Eventos Sensíveis";
            EventosSensiveis.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(RTxtLogEventoSensiveis);
            groupBox5.Location = new Point(6, 375);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1036, 139);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Validações Evento Sensíveis";
            // 
            // RTxtLogEventoSensiveis
            // 
            RTxtLogEventoSensiveis.Dock = DockStyle.Fill;
            RTxtLogEventoSensiveis.Location = new Point(3, 19);
            RTxtLogEventoSensiveis.Name = "RTxtLogEventoSensiveis";
            RTxtLogEventoSensiveis.ReadOnly = true;
            RTxtLogEventoSensiveis.Size = new Size(1030, 117);
            RTxtLogEventoSensiveis.TabIndex = 0;
            RTxtLogEventoSensiveis.Text = "";
            // 
            // DgvListEventoSensiveis
            // 
            DgvListEventoSensiveis.AllowUserToAddRows = false;
            DgvListEventoSensiveis.AllowUserToDeleteRows = false;
            DgvListEventoSensiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListEventoSensiveis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListEventoSensiveis.BackgroundColor = SystemColors.Control;
            DgvListEventoSensiveis.BorderStyle = BorderStyle.Fixed3D;
            DgvListEventoSensiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListEventoSensiveis.Location = new Point(6, 6);
            DgvListEventoSensiveis.MultiSelect = false;
            DgvListEventoSensiveis.Name = "DgvListEventoSensiveis";
            DgvListEventoSensiveis.ReadOnly = true;
            DgvListEventoSensiveis.RowTemplate.Height = 25;
            DgvListEventoSensiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListEventoSensiveis.Size = new Size(1036, 363);
            DgvListEventoSensiveis.TabIndex = 0;
            // 
            // MarcacaoPontoRepP
            // 
            MarcacaoPontoRepP.Controls.Add(groupBox6);
            MarcacaoPontoRepP.Controls.Add(DgvListMarcacaoPontoRepP);
            MarcacaoPontoRepP.Location = new Point(4, 24);
            MarcacaoPontoRepP.Name = "MarcacaoPontoRepP";
            MarcacaoPontoRepP.Padding = new Padding(3);
            MarcacaoPontoRepP.Size = new Size(1048, 520);
            MarcacaoPontoRepP.TabIndex = 9;
            MarcacaoPontoRepP.Text = "7 - Marcação Ponto Rep-P";
            MarcacaoPontoRepP.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(RTxtLogMarcacaoPontoRepP);
            groupBox6.Location = new Point(6, 375);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1036, 139);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Validações Marcação Ponto Rep-P";
            // 
            // RTxtLogMarcacaoPontoRepP
            // 
            RTxtLogMarcacaoPontoRepP.Dock = DockStyle.Fill;
            RTxtLogMarcacaoPontoRepP.Location = new Point(3, 19);
            RTxtLogMarcacaoPontoRepP.Name = "RTxtLogMarcacaoPontoRepP";
            RTxtLogMarcacaoPontoRepP.ReadOnly = true;
            RTxtLogMarcacaoPontoRepP.Size = new Size(1030, 117);
            RTxtLogMarcacaoPontoRepP.TabIndex = 0;
            RTxtLogMarcacaoPontoRepP.Text = "";
            // 
            // DgvListMarcacaoPontoRepP
            // 
            DgvListMarcacaoPontoRepP.AllowUserToAddRows = false;
            DgvListMarcacaoPontoRepP.AllowUserToDeleteRows = false;
            DgvListMarcacaoPontoRepP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListMarcacaoPontoRepP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListMarcacaoPontoRepP.BackgroundColor = SystemColors.Control;
            DgvListMarcacaoPontoRepP.BorderStyle = BorderStyle.Fixed3D;
            DgvListMarcacaoPontoRepP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListMarcacaoPontoRepP.Location = new Point(6, 6);
            DgvListMarcacaoPontoRepP.MultiSelect = false;
            DgvListMarcacaoPontoRepP.Name = "DgvListMarcacaoPontoRepP";
            DgvListMarcacaoPontoRepP.ReadOnly = true;
            DgvListMarcacaoPontoRepP.RowTemplate.Height = 25;
            DgvListMarcacaoPontoRepP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListMarcacaoPontoRepP.Size = new Size(1036, 363);
            DgvListMarcacaoPontoRepP.TabIndex = 2;
            // 
            // Trailer
            // 
            Trailer.Controls.Add(groupBox8);
            Trailer.Controls.Add(DgvListTrailer);
            Trailer.Location = new Point(4, 24);
            Trailer.Name = "Trailer";
            Trailer.Size = new Size(1048, 520);
            Trailer.TabIndex = 8;
            Trailer.Text = "9 - Trailer";
            Trailer.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox8.Controls.Add(RTxtLogTrailer);
            groupBox8.Location = new Point(6, 375);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1036, 139);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Validações Trailer";
            // 
            // RTxtLogTrailer
            // 
            RTxtLogTrailer.Dock = DockStyle.Fill;
            RTxtLogTrailer.Location = new Point(3, 19);
            RTxtLogTrailer.Name = "RTxtLogTrailer";
            RTxtLogTrailer.ReadOnly = true;
            RTxtLogTrailer.Size = new Size(1030, 117);
            RTxtLogTrailer.TabIndex = 0;
            RTxtLogTrailer.Text = "";
            // 
            // DgvListTrailer
            // 
            DgvListTrailer.AllowUserToAddRows = false;
            DgvListTrailer.AllowUserToDeleteRows = false;
            DgvListTrailer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListTrailer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListTrailer.BackgroundColor = SystemColors.Control;
            DgvListTrailer.BorderStyle = BorderStyle.Fixed3D;
            DgvListTrailer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListTrailer.Location = new Point(6, 6);
            DgvListTrailer.MultiSelect = false;
            DgvListTrailer.Name = "DgvListTrailer";
            DgvListTrailer.ReadOnly = true;
            DgvListTrailer.RowTemplate.Height = 25;
            DgvListTrailer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListTrailer.Size = new Size(1036, 363);
            DgvListTrailer.TabIndex = 0;
            // 
            // AssinaturaDigital
            // 
            AssinaturaDigital.Controls.Add(groupBox7);
            AssinaturaDigital.Controls.Add(DgvListAssinaturaDigital);
            AssinaturaDigital.Location = new Point(4, 24);
            AssinaturaDigital.Name = "AssinaturaDigital";
            AssinaturaDigital.Size = new Size(1048, 520);
            AssinaturaDigital.TabIndex = 10;
            AssinaturaDigital.Text = "Assinatura Digital";
            AssinaturaDigital.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(RTxtLogAssinaturaDigital);
            groupBox7.Location = new Point(6, 375);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1036, 139);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Validações Assinatura Digital";
            // 
            // RTxtLogAssinaturaDigital
            // 
            RTxtLogAssinaturaDigital.Dock = DockStyle.Fill;
            RTxtLogAssinaturaDigital.Location = new Point(3, 19);
            RTxtLogAssinaturaDigital.Name = "RTxtLogAssinaturaDigital";
            RTxtLogAssinaturaDigital.ReadOnly = true;
            RTxtLogAssinaturaDigital.Size = new Size(1030, 117);
            RTxtLogAssinaturaDigital.TabIndex = 0;
            RTxtLogAssinaturaDigital.Text = "";
            // 
            // DgvListAssinaturaDigital
            // 
            DgvListAssinaturaDigital.AllowUserToAddRows = false;
            DgvListAssinaturaDigital.AllowUserToDeleteRows = false;
            DgvListAssinaturaDigital.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListAssinaturaDigital.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListAssinaturaDigital.BackgroundColor = SystemColors.Control;
            DgvListAssinaturaDigital.BorderStyle = BorderStyle.Fixed3D;
            DgvListAssinaturaDigital.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListAssinaturaDigital.Location = new Point(6, 6);
            DgvListAssinaturaDigital.MultiSelect = false;
            DgvListAssinaturaDigital.Name = "DgvListAssinaturaDigital";
            DgvListAssinaturaDigital.ReadOnly = true;
            DgvListAssinaturaDigital.RowTemplate.Height = 25;
            DgvListAssinaturaDigital.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListAssinaturaDigital.Size = new Size(1036, 363);
            DgvListAssinaturaDigital.TabIndex = 2;
            // 
            // LblInfoPaginas
            // 
            LblInfoPaginas.AutoSize = true;
            LblInfoPaginas.Location = new Point(198, 585);
            LblInfoPaginas.Name = "LblInfoPaginas";
            LblInfoPaginas.Size = new Size(92, 15);
            LblInfoPaginas.TabIndex = 4;
            LblInfoPaginas.Text = "Página 0 de 000.";
            // 
            // BtnProximo
            // 
            BtnProximo.Location = new Point(93, 581);
            BtnProximo.Name = "BtnProximo";
            BtnProximo.Size = new Size(75, 23);
            BtnProximo.TabIndex = 3;
            BtnProximo.Text = ">>";
            BtnProximo.UseVisualStyleBackColor = true;
            BtnProximo.Click += BtnProximo_Click;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Location = new Point(12, 581);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(75, 23);
            BtnAnterior.TabIndex = 3;
            BtnAnterior.Text = "<<";
            BtnAnterior.UseVisualStyleBackColor = true;
            BtnAnterior.Click += BtnAnterior_Click;
            // 
            // FrmLeitorAfd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 616);
            Controls.Add(LblInfoPaginas);
            Controls.Add(TabControlAfd);
            Controls.Add(BtnProximo);
            Controls.Add(MenuAfd);
            Controls.Add(BtnAnterior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = MenuAfd;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLeitorAfd";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arquivo Fonte de Dados – AFD";
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
            ((System.ComponentModel.ISupportInitialize)DgvListRelogioTempoReal).EndInit();
            EmpregadoMt.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListEmpregadoMt).EndInit();
            EventosSensiveis.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListEventoSensiveis).EndInit();
            MarcacaoPontoRepP.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListMarcacaoPontoRepP).EndInit();
            Trailer.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListTrailer).EndInit();
            AssinaturaDigital.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListAssinaturaDigital).EndInit();
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
        private RichTextBox RTxtLogRelogioTempoReal;
        private DataGridView DgvListRelogioTempoReal;
        private TabPage EmpregadoMt;
        private GroupBox groupBox4;
        private RichTextBox RTxtLogEmpregadoMt;
        private DataGridView DgvListEmpregadoMt;
        private TabPage EventosSensiveis;
        private GroupBox groupBox5;
        private RichTextBox RTxtLogEventoSensiveis;
        private DataGridView DgvListEventoSensiveis;
        private TabPage Trailer;
        private GroupBox groupBox8;
        private RichTextBox RTxtLogTrailer;
        private DataGridView DgvListTrailer;
        private ToolStripMenuItem MenuConverter;
        private ToolStripMenuItem SubMenuConverterArt96;
        private TabPage MarcacaoPontoRepP;
        private GroupBox groupBox6;
        private RichTextBox RTxtLogMarcacaoPontoRepP;
        private DataGridView DgvListMarcacaoPontoRepP;
        private ToolStripMenuItem MenuValidacao;
        private ToolStripMenuItem SubMenuValidacaoListar;
        private TabPage AssinaturaDigital;
        private GroupBox groupBox7;
        private RichTextBox RTxtLogAssinaturaDigital;
        private DataGridView DgvListAssinaturaDigital;
        private Button BtnProximo;
        private Button BtnAnterior;
        private Label LblInfoPaginas;
    }
}