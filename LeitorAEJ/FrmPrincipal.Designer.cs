namespace LeitorAEJ
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            MenuPrincipal = new MenuStrip();
            MenuAej = new ToolStripMenuItem();
            SubMenuLerArquivo = new ToolStripMenuItem();
            MenuVisualizar = new ToolStripMenuItem();
            SubMenuVisualizarListar = new ToolStripMenuItem();
            MenuValidacao = new ToolStripMenuItem();
            SubMenuValidacaoListar = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            Cabecalho = new TabPage();
            GbValidacao = new GroupBox();
            RTxtLogCabecalho = new RichTextBox();
            DgvListCabecalho = new DataGridView();
            REPsUtilizados = new TabPage();
            groupBox1 = new GroupBox();
            RTxtLogRepUtilizado = new RichTextBox();
            DgvListRepsUtilizados = new DataGridView();
            Vinculos = new TabPage();
            groupBox2 = new GroupBox();
            RTxtLogVinculo = new RichTextBox();
            DgvListVinculo = new DataGridView();
            HorarioContratual = new TabPage();
            groupBox3 = new GroupBox();
            RTxtLogHorarioContratual = new RichTextBox();
            DgvListHorarioContratual = new DataGridView();
            Marcacoes = new TabPage();
            groupBox4 = new GroupBox();
            RTxtLogMarcacoes = new RichTextBox();
            DgvListMarcacao = new DataGridView();
            VinculoeSocial = new TabPage();
            groupBox5 = new GroupBox();
            RTxtLogVinculoeSocial = new RichTextBox();
            DgvListVinculoeSocial = new DataGridView();
            AusenciasBancoHoras = new TabPage();
            groupBox6 = new GroupBox();
            RTxtLogAusenciaBancoHoras = new RichTextBox();
            DgvListAusenciaBancoHoras = new DataGridView();
            IdentificacaoPTRP = new TabPage();
            groupBox7 = new GroupBox();
            RTxtLogIdentificaoPTRP = new RichTextBox();
            DgvListIdentificaoPTRP = new DataGridView();
            Trailer = new TabPage();
            groupBox8 = new GroupBox();
            RTxtLogTrailer = new RichTextBox();
            DgvListTrailer = new DataGridView();
            testeToolStripMenuItem = new ToolStripMenuItem();
            MenuPrincipal.SuspendLayout();
            tabControl1.SuspendLayout();
            Cabecalho.SuspendLayout();
            GbValidacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListCabecalho).BeginInit();
            REPsUtilizados.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListRepsUtilizados).BeginInit();
            Vinculos.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListVinculo).BeginInit();
            HorarioContratual.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListHorarioContratual).BeginInit();
            Marcacoes.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListMarcacao).BeginInit();
            VinculoeSocial.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListVinculoeSocial).BeginInit();
            AusenciasBancoHoras.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListAusenciaBancoHoras).BeginInit();
            IdentificacaoPTRP.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListIdentificaoPTRP).BeginInit();
            Trailer.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListTrailer).BeginInit();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.BackColor = Color.Transparent;
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { MenuAej, MenuVisualizar, MenuValidacao, testeToolStripMenuItem });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(1069, 24);
            MenuPrincipal.TabIndex = 1;
            MenuPrincipal.Text = "MenuPrincipal";
            // 
            // MenuAej
            // 
            MenuAej.DropDownItems.AddRange(new ToolStripItem[] { SubMenuLerArquivo });
            MenuAej.Name = "MenuAej";
            MenuAej.Size = new Size(37, 20);
            MenuAej.Text = "AEJ";
            // 
            // SubMenuLerArquivo
            // 
            SubMenuLerArquivo.Name = "SubMenuLerArquivo";
            SubMenuLerArquivo.Size = new Size(180, 22);
            SubMenuLerArquivo.Text = "&Ler Arquivo";
            SubMenuLerArquivo.Click += SubMenuLerArquivo_Click;
            // 
            // MenuVisualizar
            // 
            MenuVisualizar.DropDownItems.AddRange(new ToolStripItem[] { SubMenuVisualizarListar });
            MenuVisualizar.Name = "MenuVisualizar";
            MenuVisualizar.Size = new Size(123, 20);
            MenuVisualizar.Text = "Visualizar Individual";
            // 
            // SubMenuVisualizarListar
            // 
            SubMenuVisualizarListar.Name = "SubMenuVisualizarListar";
            SubMenuVisualizarListar.Size = new Size(102, 22);
            SubMenuVisualizarListar.Text = "Listar";
            SubMenuVisualizarListar.Click += SubMenuVisualizarListar_Click;
            // 
            // MenuValidacao
            // 
            MenuValidacao.DropDownItems.AddRange(new ToolStripItem[] { SubMenuValidacaoListar });
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
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Cabecalho);
            tabControl1.Controls.Add(REPsUtilizados);
            tabControl1.Controls.Add(Vinculos);
            tabControl1.Controls.Add(HorarioContratual);
            tabControl1.Controls.Add(Marcacoes);
            tabControl1.Controls.Add(VinculoeSocial);
            tabControl1.Controls.Add(AusenciasBancoHoras);
            tabControl1.Controls.Add(IdentificacaoPTRP);
            tabControl1.Controls.Add(Trailer);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1045, 545);
            tabControl1.TabIndex = 2;
            // 
            // Cabecalho
            // 
            Cabecalho.Controls.Add(GbValidacao);
            Cabecalho.Controls.Add(DgvListCabecalho);
            Cabecalho.Location = new Point(4, 24);
            Cabecalho.Name = "Cabecalho";
            Cabecalho.Padding = new Padding(3);
            Cabecalho.Size = new Size(1037, 517);
            Cabecalho.TabIndex = 0;
            Cabecalho.Text = "01 - Cabeçalho";
            Cabecalho.UseVisualStyleBackColor = true;
            // 
            // GbValidacao
            // 
            GbValidacao.Controls.Add(RTxtLogCabecalho);
            GbValidacao.Location = new Point(3, 375);
            GbValidacao.Name = "GbValidacao";
            GbValidacao.Size = new Size(1028, 136);
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
            RTxtLogCabecalho.Size = new Size(1022, 114);
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
            DgvListCabecalho.Size = new Size(1031, 366);
            DgvListCabecalho.TabIndex = 0;
            // 
            // REPsUtilizados
            // 
            REPsUtilizados.Controls.Add(groupBox1);
            REPsUtilizados.Controls.Add(DgvListRepsUtilizados);
            REPsUtilizados.Location = new Point(4, 24);
            REPsUtilizados.Name = "REPsUtilizados";
            REPsUtilizados.Padding = new Padding(3);
            REPsUtilizados.Size = new Size(1037, 517);
            REPsUtilizados.TabIndex = 1;
            REPsUtilizados.Text = "02 - REPs utilizados";
            REPsUtilizados.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RTxtLogRepUtilizado);
            groupBox1.Location = new Point(3, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1028, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Validações REP Utilizados";
            // 
            // RTxtLogRepUtilizado
            // 
            RTxtLogRepUtilizado.Dock = DockStyle.Fill;
            RTxtLogRepUtilizado.Location = new Point(3, 19);
            RTxtLogRepUtilizado.Name = "RTxtLogRepUtilizado";
            RTxtLogRepUtilizado.ReadOnly = true;
            RTxtLogRepUtilizado.Size = new Size(1022, 114);
            RTxtLogRepUtilizado.TabIndex = 0;
            RTxtLogRepUtilizado.Text = "";
            // 
            // DgvListRepsUtilizados
            // 
            DgvListRepsUtilizados.AllowUserToAddRows = false;
            DgvListRepsUtilizados.AllowUserToDeleteRows = false;
            DgvListRepsUtilizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListRepsUtilizados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListRepsUtilizados.BackgroundColor = SystemColors.Control;
            DgvListRepsUtilizados.BorderStyle = BorderStyle.Fixed3D;
            DgvListRepsUtilizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListRepsUtilizados.Location = new Point(3, 3);
            DgvListRepsUtilizados.MultiSelect = false;
            DgvListRepsUtilizados.Name = "DgvListRepsUtilizados";
            DgvListRepsUtilizados.ReadOnly = true;
            DgvListRepsUtilizados.RowTemplate.Height = 25;
            DgvListRepsUtilizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListRepsUtilizados.Size = new Size(1031, 366);
            DgvListRepsUtilizados.TabIndex = 0;
            // 
            // Vinculos
            // 
            Vinculos.Controls.Add(groupBox2);
            Vinculos.Controls.Add(DgvListVinculo);
            Vinculos.Location = new Point(4, 24);
            Vinculos.Name = "Vinculos";
            Vinculos.Padding = new Padding(3);
            Vinculos.Size = new Size(1037, 517);
            Vinculos.TabIndex = 2;
            Vinculos.Text = "03 - Vínculos";
            Vinculos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RTxtLogVinculo);
            groupBox2.Location = new Point(3, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1028, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Validações Vínculos";
            // 
            // RTxtLogVinculo
            // 
            RTxtLogVinculo.Dock = DockStyle.Fill;
            RTxtLogVinculo.Location = new Point(3, 19);
            RTxtLogVinculo.Name = "RTxtLogVinculo";
            RTxtLogVinculo.ReadOnly = true;
            RTxtLogVinculo.Size = new Size(1022, 114);
            RTxtLogVinculo.TabIndex = 0;
            RTxtLogVinculo.Text = "";
            // 
            // DgvListVinculo
            // 
            DgvListVinculo.AllowUserToAddRows = false;
            DgvListVinculo.AllowUserToDeleteRows = false;
            DgvListVinculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListVinculo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListVinculo.BackgroundColor = SystemColors.Control;
            DgvListVinculo.BorderStyle = BorderStyle.Fixed3D;
            DgvListVinculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListVinculo.Location = new Point(3, 3);
            DgvListVinculo.MultiSelect = false;
            DgvListVinculo.Name = "DgvListVinculo";
            DgvListVinculo.ReadOnly = true;
            DgvListVinculo.RowTemplate.Height = 25;
            DgvListVinculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListVinculo.Size = new Size(1031, 366);
            DgvListVinculo.TabIndex = 0;
            // 
            // HorarioContratual
            // 
            HorarioContratual.Controls.Add(groupBox3);
            HorarioContratual.Controls.Add(DgvListHorarioContratual);
            HorarioContratual.Location = new Point(4, 24);
            HorarioContratual.Name = "HorarioContratual";
            HorarioContratual.Size = new Size(1037, 517);
            HorarioContratual.TabIndex = 3;
            HorarioContratual.Text = "04 - Horário contratual";
            HorarioContratual.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RTxtLogHorarioContratual);
            groupBox3.Location = new Point(3, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1028, 136);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Validações Horario Contratual";
            // 
            // RTxtLogHorarioContratual
            // 
            RTxtLogHorarioContratual.Dock = DockStyle.Fill;
            RTxtLogHorarioContratual.Location = new Point(3, 19);
            RTxtLogHorarioContratual.Name = "RTxtLogHorarioContratual";
            RTxtLogHorarioContratual.ReadOnly = true;
            RTxtLogHorarioContratual.Size = new Size(1022, 114);
            RTxtLogHorarioContratual.TabIndex = 0;
            RTxtLogHorarioContratual.Text = "";
            // 
            // DgvListHorarioContratual
            // 
            DgvListHorarioContratual.AllowUserToAddRows = false;
            DgvListHorarioContratual.AllowUserToDeleteRows = false;
            DgvListHorarioContratual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListHorarioContratual.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListHorarioContratual.BackgroundColor = SystemColors.Control;
            DgvListHorarioContratual.BorderStyle = BorderStyle.Fixed3D;
            DgvListHorarioContratual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListHorarioContratual.Location = new Point(3, 3);
            DgvListHorarioContratual.MultiSelect = false;
            DgvListHorarioContratual.Name = "DgvListHorarioContratual";
            DgvListHorarioContratual.ReadOnly = true;
            DgvListHorarioContratual.RowTemplate.Height = 25;
            DgvListHorarioContratual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListHorarioContratual.Size = new Size(1031, 366);
            DgvListHorarioContratual.TabIndex = 0;
            // 
            // Marcacoes
            // 
            Marcacoes.Controls.Add(groupBox4);
            Marcacoes.Controls.Add(DgvListMarcacao);
            Marcacoes.Location = new Point(4, 24);
            Marcacoes.Name = "Marcacoes";
            Marcacoes.Size = new Size(1037, 517);
            Marcacoes.TabIndex = 4;
            Marcacoes.Text = "05 - Marcações";
            Marcacoes.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RTxtLogMarcacoes);
            groupBox4.Location = new Point(3, 375);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1028, 136);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Validações Marcações";
            // 
            // RTxtLogMarcacoes
            // 
            RTxtLogMarcacoes.Dock = DockStyle.Fill;
            RTxtLogMarcacoes.Location = new Point(3, 19);
            RTxtLogMarcacoes.Name = "RTxtLogMarcacoes";
            RTxtLogMarcacoes.ReadOnly = true;
            RTxtLogMarcacoes.Size = new Size(1022, 114);
            RTxtLogMarcacoes.TabIndex = 0;
            RTxtLogMarcacoes.Text = "";
            // 
            // DgvListMarcacao
            // 
            DgvListMarcacao.AllowUserToAddRows = false;
            DgvListMarcacao.AllowUserToDeleteRows = false;
            DgvListMarcacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListMarcacao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListMarcacao.BackgroundColor = SystemColors.Control;
            DgvListMarcacao.BorderStyle = BorderStyle.Fixed3D;
            DgvListMarcacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListMarcacao.Location = new Point(3, 3);
            DgvListMarcacao.MultiSelect = false;
            DgvListMarcacao.Name = "DgvListMarcacao";
            DgvListMarcacao.ReadOnly = true;
            DgvListMarcacao.RowTemplate.Height = 25;
            DgvListMarcacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListMarcacao.Size = new Size(1031, 366);
            DgvListMarcacao.TabIndex = 0;
            // 
            // VinculoeSocial
            // 
            VinculoeSocial.Controls.Add(groupBox5);
            VinculoeSocial.Controls.Add(DgvListVinculoeSocial);
            VinculoeSocial.Location = new Point(4, 24);
            VinculoeSocial.Name = "VinculoeSocial";
            VinculoeSocial.Size = new Size(1037, 517);
            VinculoeSocial.TabIndex = 5;
            VinculoeSocial.Text = "06 - Vínculo no eSocial";
            VinculoeSocial.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(RTxtLogVinculoeSocial);
            groupBox5.Location = new Point(3, 375);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1028, 136);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Validações Vinculo eSocial";
            // 
            // RTxtLogVinculoeSocial
            // 
            RTxtLogVinculoeSocial.Dock = DockStyle.Fill;
            RTxtLogVinculoeSocial.Location = new Point(3, 19);
            RTxtLogVinculoeSocial.Name = "RTxtLogVinculoeSocial";
            RTxtLogVinculoeSocial.ReadOnly = true;
            RTxtLogVinculoeSocial.Size = new Size(1022, 114);
            RTxtLogVinculoeSocial.TabIndex = 0;
            RTxtLogVinculoeSocial.Text = "";
            // 
            // DgvListVinculoeSocial
            // 
            DgvListVinculoeSocial.AllowUserToAddRows = false;
            DgvListVinculoeSocial.AllowUserToDeleteRows = false;
            DgvListVinculoeSocial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListVinculoeSocial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListVinculoeSocial.BackgroundColor = SystemColors.Control;
            DgvListVinculoeSocial.BorderStyle = BorderStyle.Fixed3D;
            DgvListVinculoeSocial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListVinculoeSocial.Location = new Point(3, 3);
            DgvListVinculoeSocial.MultiSelect = false;
            DgvListVinculoeSocial.Name = "DgvListVinculoeSocial";
            DgvListVinculoeSocial.ReadOnly = true;
            DgvListVinculoeSocial.RowTemplate.Height = 25;
            DgvListVinculoeSocial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListVinculoeSocial.Size = new Size(1031, 366);
            DgvListVinculoeSocial.TabIndex = 0;
            // 
            // AusenciasBancoHoras
            // 
            AusenciasBancoHoras.Controls.Add(groupBox6);
            AusenciasBancoHoras.Controls.Add(DgvListAusenciaBancoHoras);
            AusenciasBancoHoras.Location = new Point(4, 24);
            AusenciasBancoHoras.Name = "AusenciasBancoHoras";
            AusenciasBancoHoras.Size = new Size(1037, 517);
            AusenciasBancoHoras.TabIndex = 6;
            AusenciasBancoHoras.Text = "07  - Ausências e Banco de Horas";
            AusenciasBancoHoras.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(RTxtLogAusenciaBancoHoras);
            groupBox6.Location = new Point(3, 375);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1028, 136);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Validações Ausência e Banco de Horas";
            // 
            // RTxtLogAusenciaBancoHoras
            // 
            RTxtLogAusenciaBancoHoras.Dock = DockStyle.Fill;
            RTxtLogAusenciaBancoHoras.Location = new Point(3, 19);
            RTxtLogAusenciaBancoHoras.Name = "RTxtLogAusenciaBancoHoras";
            RTxtLogAusenciaBancoHoras.ReadOnly = true;
            RTxtLogAusenciaBancoHoras.Size = new Size(1022, 114);
            RTxtLogAusenciaBancoHoras.TabIndex = 0;
            RTxtLogAusenciaBancoHoras.Text = "";
            // 
            // DgvListAusenciaBancoHoras
            // 
            DgvListAusenciaBancoHoras.AllowUserToAddRows = false;
            DgvListAusenciaBancoHoras.AllowUserToDeleteRows = false;
            DgvListAusenciaBancoHoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListAusenciaBancoHoras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListAusenciaBancoHoras.BackgroundColor = SystemColors.Control;
            DgvListAusenciaBancoHoras.BorderStyle = BorderStyle.Fixed3D;
            DgvListAusenciaBancoHoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListAusenciaBancoHoras.Location = new Point(3, 3);
            DgvListAusenciaBancoHoras.MultiSelect = false;
            DgvListAusenciaBancoHoras.Name = "DgvListAusenciaBancoHoras";
            DgvListAusenciaBancoHoras.ReadOnly = true;
            DgvListAusenciaBancoHoras.RowTemplate.Height = 25;
            DgvListAusenciaBancoHoras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListAusenciaBancoHoras.Size = new Size(1031, 366);
            DgvListAusenciaBancoHoras.TabIndex = 0;
            // 
            // IdentificacaoPTRP
            // 
            IdentificacaoPTRP.Controls.Add(groupBox7);
            IdentificacaoPTRP.Controls.Add(DgvListIdentificaoPTRP);
            IdentificacaoPTRP.Location = new Point(4, 24);
            IdentificacaoPTRP.Name = "IdentificacaoPTRP";
            IdentificacaoPTRP.Size = new Size(1037, 517);
            IdentificacaoPTRP.TabIndex = 7;
            IdentificacaoPTRP.Text = "08 - Identificação do PTRP";
            IdentificacaoPTRP.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(RTxtLogIdentificaoPTRP);
            groupBox7.Location = new Point(3, 375);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1028, 136);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Validações Identificação PTRP";
            // 
            // RTxtLogIdentificaoPTRP
            // 
            RTxtLogIdentificaoPTRP.Dock = DockStyle.Fill;
            RTxtLogIdentificaoPTRP.Location = new Point(3, 19);
            RTxtLogIdentificaoPTRP.Name = "RTxtLogIdentificaoPTRP";
            RTxtLogIdentificaoPTRP.ReadOnly = true;
            RTxtLogIdentificaoPTRP.Size = new Size(1022, 114);
            RTxtLogIdentificaoPTRP.TabIndex = 0;
            RTxtLogIdentificaoPTRP.Text = "";
            // 
            // DgvListIdentificaoPTRP
            // 
            DgvListIdentificaoPTRP.AllowUserToAddRows = false;
            DgvListIdentificaoPTRP.AllowUserToDeleteRows = false;
            DgvListIdentificaoPTRP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListIdentificaoPTRP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListIdentificaoPTRP.BackgroundColor = SystemColors.Control;
            DgvListIdentificaoPTRP.BorderStyle = BorderStyle.Fixed3D;
            DgvListIdentificaoPTRP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListIdentificaoPTRP.Location = new Point(3, 3);
            DgvListIdentificaoPTRP.MultiSelect = false;
            DgvListIdentificaoPTRP.Name = "DgvListIdentificaoPTRP";
            DgvListIdentificaoPTRP.ReadOnly = true;
            DgvListIdentificaoPTRP.RowTemplate.Height = 25;
            DgvListIdentificaoPTRP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListIdentificaoPTRP.Size = new Size(1031, 366);
            DgvListIdentificaoPTRP.TabIndex = 0;
            // 
            // Trailer
            // 
            Trailer.Controls.Add(groupBox8);
            Trailer.Controls.Add(DgvListTrailer);
            Trailer.Location = new Point(4, 24);
            Trailer.Name = "Trailer";
            Trailer.Size = new Size(1037, 517);
            Trailer.TabIndex = 8;
            Trailer.Text = "99 - Trailer";
            Trailer.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(RTxtLogTrailer);
            groupBox8.Location = new Point(3, 375);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1028, 136);
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
            RTxtLogTrailer.Size = new Size(1022, 114);
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
            DgvListTrailer.Location = new Point(3, 3);
            DgvListTrailer.MultiSelect = false;
            DgvListTrailer.Name = "DgvListTrailer";
            DgvListTrailer.ReadOnly = true;
            DgvListTrailer.RowTemplate.Height = 25;
            DgvListTrailer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListTrailer.Size = new Size(1031, 366);
            DgvListTrailer.TabIndex = 0;
            // 
            // testeToolStripMenuItem
            // 
            testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            testeToolStripMenuItem.Size = new Size(45, 20);
            testeToolStripMenuItem.Text = "Teste";
            testeToolStripMenuItem.Click += testeToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 584);
            Controls.Add(tabControl1);
            Controls.Add(MenuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARQUIVO ELETRÔNICO DE JORNADA - AEJ - Portaria 671 - 08/11/2021";
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            tabControl1.ResumeLayout(false);
            Cabecalho.ResumeLayout(false);
            GbValidacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListCabecalho).EndInit();
            REPsUtilizados.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListRepsUtilizados).EndInit();
            Vinculos.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListVinculo).EndInit();
            HorarioContratual.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListHorarioContratual).EndInit();
            Marcacoes.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListMarcacao).EndInit();
            VinculoeSocial.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListVinculoeSocial).EndInit();
            AusenciasBancoHoras.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListAusenciaBancoHoras).EndInit();
            IdentificacaoPTRP.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListIdentificaoPTRP).EndInit();
            Trailer.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListTrailer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MenuPrincipal;
        private ToolStripMenuItem MenuAej;
        private TabControl tabControl1;
        private TabPage Cabecalho;
        private TabPage REPsUtilizados;
        private TabPage Vinculos;
        private TabPage HorarioContratual;
        private TabPage Marcacoes;
        private TabPage VinculoeSocial;
        private TabPage AusenciasBancoHoras;
        private TabPage IdentificacaoPTRP;
        private TabPage Trailer;
        private ToolStripMenuItem SubMenuLerArquivo;
        private DataGridView DgvListCabecalho;
        private DataGridView DgvListRepsUtilizados;
        private DataGridView DgvListVinculo;
        private DataGridView DgvListHorarioContratual;
        private DataGridView DgvListMarcacao;
        private DataGridView DgvListVinculoeSocial;
        private DataGridView DgvListAusenciaBancoHoras;
        private DataGridView DgvListIdentificaoPTRP;
        private DataGridView DgvListTrailer;
        private GroupBox GbValidacao;
        private RichTextBox RTxtLogCabecalho;
        private GroupBox groupBox1;
        private RichTextBox RTxtLogRepUtilizado;
        private GroupBox groupBox2;
        private RichTextBox RTxtLogVinculo;
        private GroupBox groupBox3;
        private RichTextBox RTxtLogHorarioContratual;
        private GroupBox groupBox4;
        private RichTextBox RTxtLogMarcacoes;
        private GroupBox groupBox5;
        private RichTextBox RTxtLogVinculoeSocial;
        private GroupBox groupBox6;
        private RichTextBox RTxtLogAusenciaBancoHoras;
        private GroupBox groupBox7;
        private RichTextBox RTxtLogIdentificaoPTRP;
        private GroupBox groupBox8;
        private RichTextBox RTxtLogTrailer;
        private ToolStripMenuItem MenuVisualizar;
        private ToolStripMenuItem SubMenuVisualizarListar;
        private ToolStripMenuItem MenuValidacao;
        private ToolStripMenuItem SubMenuValidacaoListar;
        private ToolStripMenuItem testeToolStripMenuItem;
    }
}