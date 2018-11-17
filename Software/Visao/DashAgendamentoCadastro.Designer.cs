namespace Visao
{
    partial class DashAgendamentoCadastro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashAgendamentoCadastro));
            this.GpbDados = new System.Windows.Forms.GroupBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BmtIdMedico = new System.Windows.Forms.TextBox();
            this.BmtIdPaciente = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MtbHorario = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MtbData = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BmtMotivo = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelconsultacadastro2 = new System.Windows.Forms.Panel();
            this.ButtonSalvarConsulta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MtbHorafim = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LtbMedicResp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltrarCategoriaMedica = new System.Windows.Forms.ComboBox();
            this.mtbHoraInicial = new System.Windows.Forms.MaskedTextBox();
            this.CkbDomingo = new System.Windows.Forms.CheckBox();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DadosPaciente = new System.Windows.Forms.GroupBox();
            this.btnbuscarPaciente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.CkbSabado = new System.Windows.Forms.CheckBox();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuImageButton();
            this.CkbSexta = new System.Windows.Forms.CheckBox();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CkbQuinta = new System.Windows.Forms.CheckBox();
            this.CkbSegunda = new System.Windows.Forms.CheckBox();
            this.CkbTerca = new System.Windows.Forms.CheckBox();
            this.CkbQuarta = new System.Windows.Forms.CheckBox();
            this.GpbDados.SuspendLayout();
            this.panelconsultacadastro2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DadosPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // GpbDados
            // 
            this.GpbDados.Controls.Add(this.CmbStatus);
            this.GpbDados.Controls.Add(this.bunifuCustomLabel11);
            this.GpbDados.Controls.Add(this.bunifuCustomLabel16);
            this.GpbDados.Controls.Add(this.BmtIdMedico);
            this.GpbDados.Controls.Add(this.BmtIdPaciente);
            this.GpbDados.Controls.Add(this.bunifuCustomLabel1);
            this.GpbDados.Controls.Add(this.MtbHorario);
            this.GpbDados.Controls.Add(this.bunifuCustomLabel7);
            this.GpbDados.Controls.Add(this.MtbData);
            this.GpbDados.Controls.Add(this.bunifuCustomLabel9);
            this.GpbDados.Controls.Add(this.BmtMotivo);
            this.GpbDados.Controls.Add(this.bunifuCustomLabel4);
            this.GpbDados.ForeColor = System.Drawing.Color.DimGray;
            this.GpbDados.Location = new System.Drawing.Point(27, 226);
            this.GpbDados.Name = "GpbDados";
            this.GpbDados.Size = new System.Drawing.Size(982, 120);
            this.GpbDados.TabIndex = 58;
            this.GpbDados.TabStop = false;
            this.GpbDados.Text = "Informações da consulta";
            this.GpbDados.Enter += new System.EventHandler(this.GpbDados_Enter);
            // 
            // CmbStatus
            // 
            this.CmbStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CmbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Confirmada",
            "Cancelada",
            "Realizada"});
            this.CmbStatus.Location = new System.Drawing.Point(506, 71);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(129, 21);
            this.CmbStatus.TabIndex = 65;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(505, 44);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel11.TabIndex = 64;
            this.bunifuCustomLabel11.Text = "Status";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(168, 45);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(56, 13);
            this.bunifuCustomLabel16.TabIndex = 80;
            this.bunifuCustomLabel16.Text = "ID Médico";
            // 
            // BmtIdMedico
            // 
            this.BmtIdMedico.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BmtIdMedico.Enabled = false;
            this.BmtIdMedico.ForeColor = System.Drawing.Color.DimGray;
            this.BmtIdMedico.Location = new System.Drawing.Point(171, 72);
            this.BmtIdMedico.Name = "BmtIdMedico";
            this.BmtIdMedico.Size = new System.Drawing.Size(53, 20);
            this.BmtIdMedico.TabIndex = 79;
            // 
            // BmtIdPaciente
            // 
            this.BmtIdPaciente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BmtIdPaciente.Enabled = false;
            this.BmtIdPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.BmtIdPaciente.Location = new System.Drawing.Point(71, 73);
            this.BmtIdPaciente.Name = "BmtIdPaciente";
            this.BmtIdPaciente.Size = new System.Drawing.Size(55, 20);
            this.BmtIdPaciente.TabIndex = 82;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(68, 45);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 13);
            this.bunifuCustomLabel1.TabIndex = 81;
            this.bunifuCustomLabel1.Text = "ID Paciente";
            // 
            // MtbHorario
            // 
            this.MtbHorario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MtbHorario.ForeColor = System.Drawing.Color.DimGray;
            this.MtbHorario.Location = new System.Drawing.Point(408, 72);
            this.MtbHorario.Mask = "00:00";
            this.MtbHorario.Name = "MtbHorario";
            this.MtbHorario.Size = new System.Drawing.Size(52, 20);
            this.MtbHorario.TabIndex = 55;
            this.MtbHorario.ValidatingType = typeof(System.DateTime);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(405, 43);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(41, 13);
            this.bunifuCustomLabel7.TabIndex = 54;
            this.bunifuCustomLabel7.Text = "Horário";
            // 
            // MtbData
            // 
            this.MtbData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MtbData.ForeColor = System.Drawing.Color.DimGray;
            this.MtbData.Location = new System.Drawing.Point(287, 72);
            this.MtbData.Mask = "00/00/0000";
            this.MtbData.Name = "MtbData";
            this.MtbData.Size = new System.Drawing.Size(71, 20);
            this.MtbData.TabIndex = 50;
            this.MtbData.ValidatingType = typeof(System.DateTime);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(284, 46);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel9.TabIndex = 49;
            this.bunifuCustomLabel9.Text = "Data";
            // 
            // BmtMotivo
            // 
            this.BmtMotivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BmtMotivo.ForeColor = System.Drawing.Color.DimGray;
            this.BmtMotivo.Location = new System.Drawing.Point(681, 71);
            this.BmtMotivo.Name = "BmtMotivo";
            this.BmtMotivo.Size = new System.Drawing.Size(258, 20);
            this.BmtMotivo.TabIndex = 40;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(680, 41);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(39, 13);
            this.bunifuCustomLabel4.TabIndex = 39;
            this.bunifuCustomLabel4.Text = "Motivo";
            // 
            // panelconsultacadastro2
            // 
            this.panelconsultacadastro2.Controls.Add(this.ButtonSalvarConsulta);
            this.panelconsultacadastro2.Controls.Add(this.bunifuThinButton21);
            this.panelconsultacadastro2.Controls.Add(this.MtbHorafim);
            this.panelconsultacadastro2.Controls.Add(this.bunifuCustomLabel2);
            this.panelconsultacadastro2.Controls.Add(this.groupBox1);
            this.panelconsultacadastro2.Controls.Add(this.mtbHoraInicial);
            this.panelconsultacadastro2.Controls.Add(this.CkbDomingo);
            this.panelconsultacadastro2.Controls.Add(this.bunifuCustomLabel17);
            this.panelconsultacadastro2.Controls.Add(this.DadosPaciente);
            this.panelconsultacadastro2.Controls.Add(this.CkbSabado);
            this.panelconsultacadastro2.Controls.Add(this.btnVoltar);
            this.panelconsultacadastro2.Controls.Add(this.GpbDados);
            this.panelconsultacadastro2.Controls.Add(this.CkbSexta);
            this.panelconsultacadastro2.Controls.Add(this.bunifuCustomLabel22);
            this.panelconsultacadastro2.Controls.Add(this.CkbQuinta);
            this.panelconsultacadastro2.Controls.Add(this.CkbSegunda);
            this.panelconsultacadastro2.Controls.Add(this.CkbTerca);
            this.panelconsultacadastro2.Controls.Add(this.CkbQuarta);
            this.panelconsultacadastro2.Location = new System.Drawing.Point(0, 0);
            this.panelconsultacadastro2.Name = "panelconsultacadastro2";
            this.panelconsultacadastro2.Size = new System.Drawing.Size(1081, 753);
            this.panelconsultacadastro2.TabIndex = 60;
            this.panelconsultacadastro2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelconsultacadastro2_Paint);
            // 
            // ButtonSalvarConsulta
            // 
            this.ButtonSalvarConsulta.ActiveBorderThickness = 1;
            this.ButtonSalvarConsulta.ActiveCornerRadius = 20;
            this.ButtonSalvarConsulta.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.ButtonSalvarConsulta.ActiveForecolor = System.Drawing.Color.Transparent;
            this.ButtonSalvarConsulta.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.ButtonSalvarConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSalvarConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSalvarConsulta.BackgroundImage")));
            this.ButtonSalvarConsulta.ButtonText = "Salvar";
            this.ButtonSalvarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvarConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalvarConsulta.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonSalvarConsulta.IdleBorderThickness = 1;
            this.ButtonSalvarConsulta.IdleCornerRadius = 20;
            this.ButtonSalvarConsulta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.ButtonSalvarConsulta.IdleForecolor = System.Drawing.Color.Transparent;
            this.ButtonSalvarConsulta.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.ButtonSalvarConsulta.Location = new System.Drawing.Point(890, 356);
            this.ButtonSalvarConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSalvarConsulta.Name = "ButtonSalvarConsulta";
            this.ButtonSalvarConsulta.Size = new System.Drawing.Size(120, 41);
            this.ButtonSalvarConsulta.TabIndex = 122;
            this.ButtonSalvarConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSalvarConsulta.Click += new System.EventHandler(this.ButtonSalvarConsulta_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Verificar Horário";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.Location = new System.Drawing.Point(28, 353);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(130, 44);
            this.bunifuThinButton21.TabIndex = 121;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BtnVerificarHora_Click);
            // 
            // MtbHorafim
            // 
            this.MtbHorafim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MtbHorafim.Enabled = false;
            this.MtbHorafim.ForeColor = System.Drawing.Color.DimGray;
            this.MtbHorafim.Location = new System.Drawing.Point(968, 92);
            this.MtbHorafim.Mask = "00:00";
            this.MtbHorafim.Name = "MtbHorafim";
            this.MtbHorafim.Size = new System.Drawing.Size(41, 20);
            this.MtbHorafim.TabIndex = 77;
            this.MtbHorafim.ValidatingType = typeof(System.DateTime);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(966, 74);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(32, 13);
            this.bunifuCustomLabel2.TabIndex = 76;
            this.bunifuCustomLabel2.Text = "Final ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LtbMedicResp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbFiltrarCategoriaMedica);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(503, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 94);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Médico";
            // 
            // LtbMedicResp
            // 
            this.LtbMedicResp.FormattingEnabled = true;
            this.LtbMedicResp.Location = new System.Drawing.Point(349, 16);
            this.LtbMedicResp.Name = "LtbMedicResp";
            this.LtbMedicResp.Size = new System.Drawing.Size(146, 69);
            this.LtbMedicResp.TabIndex = 91;
            this.LtbMedicResp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LtbMedicResp_MouseClick);
            this.LtbMedicResp.SelectedIndexChanged += new System.EventHandler(this.LtbMedicResp_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Buscar por:";
            // 
            // cmbFiltrarCategoriaMedica
            // 
            this.cmbFiltrarCategoriaMedica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbFiltrarCategoriaMedica.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFiltrarCategoriaMedica.FormattingEnabled = true;
            this.cmbFiltrarCategoriaMedica.Items.AddRange(new object[] {
            "Acupunturista",
            "Cardiologista",
            "Cirurgião Geral",
            "Clínico Geral",
            "Dermatologista",
            "Infectologista",
            "Neurologista",
            "Nutrologista",
            "Pediatra",
            "Psiquiatra"});
            this.cmbFiltrarCategoriaMedica.Location = new System.Drawing.Point(83, 40);
            this.cmbFiltrarCategoriaMedica.Name = "cmbFiltrarCategoriaMedica";
            this.cmbFiltrarCategoriaMedica.Size = new System.Drawing.Size(172, 21);
            this.cmbFiltrarCategoriaMedica.TabIndex = 74;
            this.cmbFiltrarCategoriaMedica.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarCategoriaMedica_SelectedIndexChanged);
            // 
            // mtbHoraInicial
            // 
            this.mtbHoraInicial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtbHoraInicial.Enabled = false;
            this.mtbHoraInicial.ForeColor = System.Drawing.Color.DimGray;
            this.mtbHoraInicial.Location = new System.Drawing.Point(912, 93);
            this.mtbHoraInicial.Mask = "00:00";
            this.mtbHoraInicial.Name = "mtbHoraInicial";
            this.mtbHoraInicial.Size = new System.Drawing.Size(41, 20);
            this.mtbHoraInicial.TabIndex = 75;
            this.mtbHoraInicial.ValidatingType = typeof(System.DateTime);
            // 
            // CkbDomingo
            // 
            this.CkbDomingo.AutoSize = true;
            this.CkbDomingo.Enabled = false;
            this.CkbDomingo.ForeColor = System.Drawing.Color.DimGray;
            this.CkbDomingo.Location = new System.Drawing.Point(848, 95);
            this.CkbDomingo.Name = "CkbDomingo";
            this.CkbDomingo.Size = new System.Drawing.Size(48, 17);
            this.CkbDomingo.TabIndex = 89;
            this.CkbDomingo.Text = "Dom";
            this.CkbDomingo.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(912, 74);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(34, 13);
            this.bunifuCustomLabel17.TabIndex = 74;
            this.bunifuCustomLabel17.Text = "Inicial";
            // 
            // DadosPaciente
            // 
            this.DadosPaciente.Controls.Add(this.btnbuscarPaciente);
            this.DadosPaciente.Controls.Add(this.label);
            this.DadosPaciente.Controls.Add(this.cbmFiltrar);
            this.DadosPaciente.Controls.Add(this.txtPesquisar);
            this.DadosPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.DadosPaciente.Location = new System.Drawing.Point(27, 117);
            this.DadosPaciente.Name = "DadosPaciente";
            this.DadosPaciente.Size = new System.Drawing.Size(433, 94);
            this.DadosPaciente.TabIndex = 66;
            this.DadosPaciente.TabStop = false;
            this.DadosPaciente.Text = "Buscar Paciente";
            // 
            // btnbuscarPaciente
            // 
            this.btnbuscarPaciente.ActiveBorderThickness = 1;
            this.btnbuscarPaciente.ActiveCornerRadius = 20;
            this.btnbuscarPaciente.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnbuscarPaciente.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnbuscarPaciente.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnbuscarPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbuscarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarPaciente.BackgroundImage")));
            this.btnbuscarPaciente.ButtonText = "Buscar";
            this.btnbuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarPaciente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnbuscarPaciente.IdleBorderThickness = 1;
            this.btnbuscarPaciente.IdleCornerRadius = 20;
            this.btnbuscarPaciente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbuscarPaciente.IdleForecolor = System.Drawing.Color.White;
            this.btnbuscarPaciente.IdleLineColor = System.Drawing.Color.Silver;
            this.btnbuscarPaciente.Location = new System.Drawing.Point(354, 30);
            this.btnbuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbuscarPaciente.Name = "btnbuscarPaciente";
            this.btnbuscarPaciente.Size = new System.Drawing.Size(65, 37);
            this.btnbuscarPaciente.TabIndex = 87;
            this.btnbuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbuscarPaciente.Click += new System.EventHandler(this.btnbuscarPaciente_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Gray;
            this.label.Location = new System.Drawing.Point(13, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 13);
            this.label.TabIndex = 85;
            this.label.Text = "Buscar por:";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbmFiltrar.ForeColor = System.Drawing.Color.DimGray;
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "",
            "CPF",
            "RG",
            "Nome Completo"});
            this.cbmFiltrar.Location = new System.Drawing.Point(83, 40);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(103, 21);
            this.cbmFiltrar.TabIndex = 74;
            this.cbmFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbmFiltrar_SelectedIndexChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisar.Location = new System.Drawing.Point(196, 40);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(142, 20);
            this.txtPesquisar.TabIndex = 76;
            this.txtPesquisar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPesquisar_MaskInputRejected);
            // 
            // CkbSabado
            // 
            this.CkbSabado.AutoSize = true;
            this.CkbSabado.Enabled = false;
            this.CkbSabado.ForeColor = System.Drawing.Color.DimGray;
            this.CkbSabado.Location = new System.Drawing.Point(791, 95);
            this.CkbSabado.Name = "CkbSabado";
            this.CkbSabado.Size = new System.Drawing.Size(45, 17);
            this.CkbSabado.TabIndex = 88;
            this.CkbSabado.Text = "Sáb";
            this.CkbSabado.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.ErrorImage")));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageActive = null;
            this.btnVoltar.Location = new System.Drawing.Point(27, 40);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(22, 51);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 72;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Tag = "Atualizar Dado";
            this.btnVoltar.Zoom = 10;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CkbSexta
            // 
            this.CkbSexta.AutoSize = true;
            this.CkbSexta.Enabled = false;
            this.CkbSexta.ForeColor = System.Drawing.Color.DimGray;
            this.CkbSexta.Location = new System.Drawing.Point(736, 95);
            this.CkbSexta.Name = "CkbSexta";
            this.CkbSexta.Size = new System.Drawing.Size(44, 17);
            this.CkbSexta.TabIndex = 87;
            this.CkbSexta.Text = "Sex";
            this.CkbSexta.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel22.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(512, 68);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(147, 13);
            this.bunifuCustomLabel22.TabIndex = 83;
            this.bunifuCustomLabel22.Text = "Dias / horário de atendimento";
            // 
            // CkbQuinta
            // 
            this.CkbQuinta.AutoSize = true;
            this.CkbQuinta.Enabled = false;
            this.CkbQuinta.ForeColor = System.Drawing.Color.DimGray;
            this.CkbQuinta.Location = new System.Drawing.Point(682, 95);
            this.CkbQuinta.Name = "CkbQuinta";
            this.CkbQuinta.Size = new System.Drawing.Size(42, 17);
            this.CkbQuinta.TabIndex = 86;
            this.CkbQuinta.Text = "Qui";
            this.CkbQuinta.UseVisualStyleBackColor = true;
            // 
            // CkbSegunda
            // 
            this.CkbSegunda.AutoSize = true;
            this.CkbSegunda.Enabled = false;
            this.CkbSegunda.ForeColor = System.Drawing.Color.DimGray;
            this.CkbSegunda.Location = new System.Drawing.Point(513, 95);
            this.CkbSegunda.Name = "CkbSegunda";
            this.CkbSegunda.Size = new System.Drawing.Size(45, 17);
            this.CkbSegunda.TabIndex = 18;
            this.CkbSegunda.Text = "Seg";
            this.CkbSegunda.UseVisualStyleBackColor = true;
            // 
            // CkbTerca
            // 
            this.CkbTerca.AutoSize = true;
            this.CkbTerca.Enabled = false;
            this.CkbTerca.ForeColor = System.Drawing.Color.DimGray;
            this.CkbTerca.Location = new System.Drawing.Point(572, 95);
            this.CkbTerca.Name = "CkbTerca";
            this.CkbTerca.Size = new System.Drawing.Size(42, 17);
            this.CkbTerca.TabIndex = 84;
            this.CkbTerca.Text = "Ter";
            this.CkbTerca.UseVisualStyleBackColor = true;
            // 
            // CkbQuarta
            // 
            this.CkbQuarta.AutoSize = true;
            this.CkbQuarta.Enabled = false;
            this.CkbQuarta.ForeColor = System.Drawing.Color.DimGray;
            this.CkbQuarta.Location = new System.Drawing.Point(625, 95);
            this.CkbQuarta.Name = "CkbQuarta";
            this.CkbQuarta.Size = new System.Drawing.Size(46, 17);
            this.CkbQuarta.TabIndex = 85;
            this.CkbQuarta.Text = "Qua";
            this.CkbQuarta.UseVisualStyleBackColor = true;
            // 
            // DashAgendamentoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelconsultacadastro2);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "DashAgendamentoCadastro";
            this.Size = new System.Drawing.Size(1084, 753);
            this.GpbDados.ResumeLayout(false);
            this.GpbDados.PerformLayout();
            this.panelconsultacadastro2.ResumeLayout(false);
            this.panelconsultacadastro2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DadosPaciente.ResumeLayout(false);
            this.DadosPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbDados;
        private System.Windows.Forms.MaskedTextBox MtbData;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox BmtMotivo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.MaskedTextBox MtbHorario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox CmbStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.Panel panelconsultacadastro2;
        private Bunifu.Framework.UI.BunifuImageButton btnVoltar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.TextBox BmtIdPaciente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.TextBox BmtIdMedico;
        private System.Windows.Forms.MaskedTextBox txtPesquisar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltrarCategoriaMedica;
        private System.Windows.Forms.GroupBox DadosPaciente;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbuscarPaciente;
        private System.Windows.Forms.MaskedTextBox MtbHorafim;
        private System.Windows.Forms.CheckBox CkbDomingo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.CheckBox CkbSabado;
        private System.Windows.Forms.MaskedTextBox mtbHoraInicial;
        private System.Windows.Forms.CheckBox CkbSexta;
        private System.Windows.Forms.CheckBox CkbQuinta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private System.Windows.Forms.CheckBox CkbQuarta;
        private System.Windows.Forms.CheckBox CkbTerca;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private System.Windows.Forms.CheckBox CkbSegunda;
        private System.Windows.Forms.ListBox LtbMedicResp;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSalvarConsulta;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
