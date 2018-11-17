namespace Visao
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenuRelatórios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEspecialista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonMenuConsulta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonMenuPacientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonMenuAgenda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMenuResponsivo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.LblRelogio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonTopoFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.PtbImageTopo = new System.Windows.Forms.PictureBox();
            this.bunifuLabelTopo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelMenuAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelMenuAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenuResponsivo)).BeginInit();
            this.panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTopoFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImageTopo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelMenu.Controls.Add(this.btnMenuRelatórios);
            this.panelMenu.Controls.Add(this.btnEspecialista);
            this.panelMenu.Controls.Add(this.ButtonMenuConsulta);
            this.panelMenu.Controls.Add(this.ButtonMenuPacientes);
            this.panelMenu.Controls.Add(this.ButtonMenuAgenda);
            this.panelMenu.Controls.Add(this.PtbLogo);
            this.panelMenu.Controls.Add(this.ButtonMenuResponsivo);
            this.LogoAnimator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnMenuRelatórios
            // 
            this.btnMenuRelatórios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnMenuRelatórios.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnMenuRelatórios, "btnMenuRelatórios");
            this.btnMenuRelatórios.BorderRadius = 0;
            this.btnMenuRelatórios.ButtonText = "              Relatórios";
            this.btnMenuRelatórios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelMenuAnimator2.SetDecoration(this.btnMenuRelatórios, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.btnMenuRelatórios, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnMenuRelatórios, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuRelatórios.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuRelatórios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuRelatórios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuRelatórios.Iconimage")));
            this.btnMenuRelatórios.Iconimage_right = null;
            this.btnMenuRelatórios.Iconimage_right_Selected = null;
            this.btnMenuRelatórios.Iconimage_Selected = null;
            this.btnMenuRelatórios.IconMarginLeft = 0;
            this.btnMenuRelatórios.IconMarginRight = 0;
            this.btnMenuRelatórios.IconRightVisible = true;
            this.btnMenuRelatórios.IconRightZoom = 0D;
            this.btnMenuRelatórios.IconVisible = true;
            this.btnMenuRelatórios.IconZoom = 40D;
            this.btnMenuRelatórios.IsTab = true;
            this.btnMenuRelatórios.Name = "btnMenuRelatórios";
            this.btnMenuRelatórios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuRelatórios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnMenuRelatórios.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.btnMenuRelatórios.selected = false;
            this.btnMenuRelatórios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRelatórios.Textcolor = System.Drawing.Color.White;
            this.btnMenuRelatórios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRelatórios.Click += new System.EventHandler(this.btnMenuRelatórios_Click);
            // 
            // btnEspecialista
            // 
            this.btnEspecialista.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnEspecialista.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnEspecialista, "btnEspecialista");
            this.btnEspecialista.BorderRadius = 0;
            this.btnEspecialista.ButtonText = "              Especialista";
            this.btnEspecialista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelMenuAnimator2.SetDecoration(this.btnEspecialista, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.btnEspecialista, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnEspecialista, BunifuAnimatorNS.DecorationType.None);
            this.btnEspecialista.DisabledColor = System.Drawing.Color.Gray;
            this.btnEspecialista.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEspecialista.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEspecialista.Iconimage")));
            this.btnEspecialista.Iconimage_right = null;
            this.btnEspecialista.Iconimage_right_Selected = null;
            this.btnEspecialista.Iconimage_Selected = null;
            this.btnEspecialista.IconMarginLeft = 0;
            this.btnEspecialista.IconMarginRight = 0;
            this.btnEspecialista.IconRightVisible = true;
            this.btnEspecialista.IconRightZoom = 0D;
            this.btnEspecialista.IconVisible = true;
            this.btnEspecialista.IconZoom = 40D;
            this.btnEspecialista.IsTab = true;
            this.btnEspecialista.Name = "btnEspecialista";
            this.btnEspecialista.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEspecialista.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnEspecialista.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.btnEspecialista.selected = false;
            this.btnEspecialista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialista.Textcolor = System.Drawing.Color.White;
            this.btnEspecialista.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialista.Click += new System.EventHandler(this.btnMédico_Click);
            // 
            // ButtonMenuConsulta
            // 
            this.ButtonMenuConsulta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.ButtonMenuConsulta.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ButtonMenuConsulta, "ButtonMenuConsulta");
            this.ButtonMenuConsulta.BorderRadius = 0;
            this.ButtonMenuConsulta.ButtonText = "              Consulta";
            this.ButtonMenuConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelMenuAnimator2.SetDecoration(this.ButtonMenuConsulta, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.ButtonMenuConsulta, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ButtonMenuConsulta, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMenuConsulta.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonMenuConsulta.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonMenuConsulta.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonMenuConsulta.Iconimage")));
            this.ButtonMenuConsulta.Iconimage_right = null;
            this.ButtonMenuConsulta.Iconimage_right_Selected = null;
            this.ButtonMenuConsulta.Iconimage_Selected = null;
            this.ButtonMenuConsulta.IconMarginLeft = 0;
            this.ButtonMenuConsulta.IconMarginRight = 0;
            this.ButtonMenuConsulta.IconRightVisible = true;
            this.ButtonMenuConsulta.IconRightZoom = 0D;
            this.ButtonMenuConsulta.IconVisible = true;
            this.ButtonMenuConsulta.IconZoom = 40D;
            this.ButtonMenuConsulta.IsTab = true;
            this.ButtonMenuConsulta.Name = "ButtonMenuConsulta";
            this.ButtonMenuConsulta.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonMenuConsulta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.ButtonMenuConsulta.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMenuConsulta.selected = false;
            this.ButtonMenuConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMenuConsulta.Textcolor = System.Drawing.Color.White;
            this.ButtonMenuConsulta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenuConsulta.Click += new System.EventHandler(this.ButtonMenuLaudos_Click);
            // 
            // ButtonMenuPacientes
            // 
            this.ButtonMenuPacientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.ButtonMenuPacientes.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ButtonMenuPacientes, "ButtonMenuPacientes");
            this.ButtonMenuPacientes.BorderRadius = 0;
            this.ButtonMenuPacientes.ButtonText = "              Paciente";
            this.ButtonMenuPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelMenuAnimator2.SetDecoration(this.ButtonMenuPacientes, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.ButtonMenuPacientes, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ButtonMenuPacientes, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMenuPacientes.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonMenuPacientes.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonMenuPacientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonMenuPacientes.Iconimage")));
            this.ButtonMenuPacientes.Iconimage_right = null;
            this.ButtonMenuPacientes.Iconimage_right_Selected = null;
            this.ButtonMenuPacientes.Iconimage_Selected = null;
            this.ButtonMenuPacientes.IconMarginLeft = 0;
            this.ButtonMenuPacientes.IconMarginRight = 0;
            this.ButtonMenuPacientes.IconRightVisible = true;
            this.ButtonMenuPacientes.IconRightZoom = 0D;
            this.ButtonMenuPacientes.IconVisible = true;
            this.ButtonMenuPacientes.IconZoom = 40D;
            this.ButtonMenuPacientes.IsTab = true;
            this.ButtonMenuPacientes.Name = "ButtonMenuPacientes";
            this.ButtonMenuPacientes.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonMenuPacientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.ButtonMenuPacientes.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMenuPacientes.selected = false;
            this.ButtonMenuPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMenuPacientes.Textcolor = System.Drawing.Color.White;
            this.ButtonMenuPacientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenuPacientes.Click += new System.EventHandler(this.ButtonMenuPacientes_Click);
            // 
            // ButtonMenuAgenda
            // 
            this.ButtonMenuAgenda.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.ButtonMenuAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.ButtonMenuAgenda, "ButtonMenuAgenda");
            this.ButtonMenuAgenda.BorderRadius = 0;
            this.ButtonMenuAgenda.ButtonText = "              Agenda";
            this.ButtonMenuAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelMenuAnimator2.SetDecoration(this.ButtonMenuAgenda, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.ButtonMenuAgenda, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ButtonMenuAgenda, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMenuAgenda.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonMenuAgenda.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonMenuAgenda.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonMenuAgenda.Iconimage")));
            this.ButtonMenuAgenda.Iconimage_right = null;
            this.ButtonMenuAgenda.Iconimage_right_Selected = null;
            this.ButtonMenuAgenda.Iconimage_Selected = null;
            this.ButtonMenuAgenda.IconMarginLeft = 0;
            this.ButtonMenuAgenda.IconMarginRight = 0;
            this.ButtonMenuAgenda.IconRightVisible = true;
            this.ButtonMenuAgenda.IconRightZoom = 0D;
            this.ButtonMenuAgenda.IconVisible = true;
            this.ButtonMenuAgenda.IconZoom = 40D;
            this.ButtonMenuAgenda.IsTab = true;
            this.ButtonMenuAgenda.Name = "ButtonMenuAgenda";
            this.ButtonMenuAgenda.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonMenuAgenda.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.ButtonMenuAgenda.OnHoverTextColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMenuAgenda.selected = true;
            this.ButtonMenuAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMenuAgenda.Textcolor = System.Drawing.Color.White;
            this.ButtonMenuAgenda.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenuAgenda.Click += new System.EventHandler(this.ButtonMenuConsultas_Click);
            // 
            // PtbLogo
            // 
            this.PanelMenuAnimator2.SetDecoration(this.PtbLogo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.PtbLogo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PtbLogo, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.PtbLogo, "PtbLogo");
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.TabStop = false;
            // 
            // ButtonMenuResponsivo
            // 
            resources.ApplyResources(this.ButtonMenuResponsivo, "ButtonMenuResponsivo");
            this.ButtonMenuResponsivo.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.ButtonMenuResponsivo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.ButtonMenuResponsivo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this.ButtonMenuResponsivo, BunifuAnimatorNS.DecorationType.None);
            this.ButtonMenuResponsivo.ImageActive = null;
            this.ButtonMenuResponsivo.Name = "ButtonMenuResponsivo";
            this.ButtonMenuResponsivo.TabStop = false;
            this.ButtonMenuResponsivo.Zoom = 10;
            this.ButtonMenuResponsivo.Click += new System.EventHandler(this.ButtonMenuResponsivo_Click);
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.IndianRed;
            this.panelTopo.Controls.Add(this.LblRelogio);
            this.panelTopo.Controls.Add(this.buttonTopoFechar);
            this.panelTopo.Controls.Add(this.PtbImageTopo);
            this.panelTopo.Controls.Add(this.bunifuLabelTopo);
            this.LogoAnimator.SetDecoration(this.panelTopo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.panelTopo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this.panelTopo, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelTopo, "panelTopo");
            this.panelTopo.Name = "panelTopo";
            // 
            // LblRelogio
            // 
            resources.ApplyResources(this.LblRelogio, "LblRelogio");
            this.PanelMenuAnimator2.SetDecoration(this.LblRelogio, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.LblRelogio, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.LblRelogio, BunifuAnimatorNS.DecorationType.None);
            this.LblRelogio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblRelogio.Name = "LblRelogio";
            // 
            // buttonTopoFechar
            // 
            this.buttonTopoFechar.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.buttonTopoFechar, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.buttonTopoFechar, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this.buttonTopoFechar, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.buttonTopoFechar, "buttonTopoFechar");
            this.buttonTopoFechar.ImageActive = null;
            this.buttonTopoFechar.Name = "buttonTopoFechar";
            this.buttonTopoFechar.TabStop = false;
            this.buttonTopoFechar.Zoom = 10;
            this.buttonTopoFechar.Click += new System.EventHandler(this.buttonTopoFechar_Click);
            // 
            // PtbImageTopo
            // 
            this.PanelMenuAnimator2.SetDecoration(this.PtbImageTopo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.PtbImageTopo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PtbImageTopo, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.PtbImageTopo, "PtbImageTopo");
            this.PtbImageTopo.Name = "PtbImageTopo";
            this.PtbImageTopo.TabStop = false;
            // 
            // bunifuLabelTopo
            // 
            resources.ApplyResources(this.bunifuLabelTopo, "bunifuLabelTopo");
            this.PanelMenuAnimator2.SetDecoration(this.bunifuLabelTopo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.bunifuLabelTopo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuLabelTopo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLabelTopo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuLabelTopo.Name = "bunifuLabelTopo";
            // 
            // doubleBitmapControl1
            // 
            this.PanelMenuAnimator.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.doubleBitmapControl1, "doubleBitmapControl1");
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogoAnimator.SetDecoration(this.panelConteudo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.panelConteudo, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this.panelConteudo, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelConteudo, "panelConteudo");
            this.panelConteudo.ForeColor = System.Drawing.Color.DimGray;
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConteudo_Paint);
            // 
            // contextMenuStrip1
            // 
            this.LogoAnimator.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // PanelMenuAnimator
            // 
            this.PanelMenuAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelMenuAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelMenuAnimator.DefaultAnimation = animation2;
            // 
            // PanelMenuAnimator2
            // 
            this.PanelMenuAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelMenuAnimator2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelMenuAnimator2.DefaultAnimation = animation3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTopo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTopo);
            this.PanelMenuAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenuAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenuResponsivo)).EndInit();
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTopoFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImageTopo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox PtbLogo;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonMenuAgenda;
        private System.Windows.Forms.PictureBox PtbImageTopo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuLabelTopo;
        private Bunifu.Framework.UI.BunifuImageButton buttonTopoFechar;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonMenuPacientes;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonMenuConsulta;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private Bunifu.Framework.UI.BunifuImageButton ButtonMenuResponsivo;
        private BunifuAnimatorNS.BunifuTransition PanelMenuAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelMenuAnimator2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel LblRelogio;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelConteudo;
        private Bunifu.Framework.UI.BunifuFlatButton btnEspecialista;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuRelatórios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

