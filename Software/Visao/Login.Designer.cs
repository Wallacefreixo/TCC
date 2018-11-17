namespace Visao
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BmtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonCloseLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BmtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BmtUsuario
            // 
            this.BmtUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BmtUsuario.BorderColorFocused = System.Drawing.Color.Silver;
            this.BmtUsuario.BorderColorIdle = System.Drawing.Color.Transparent;
            this.BmtUsuario.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.BmtUsuario.BorderThickness = 3;
            this.BmtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BmtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BmtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.BmtUsuario.isPassword = false;
            this.BmtUsuario.Location = new System.Drawing.Point(115, 175);
            this.BmtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.BmtUsuario.Name = "BmtUsuario";
            this.BmtUsuario.Size = new System.Drawing.Size(297, 44);
            this.BmtUsuario.TabIndex = 3;
            this.BmtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BmtUsuario.OnValueChanged += new System.EventHandler(this.apagaMensagem);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(112, 153);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 16);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Usuário";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(112, 238);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(47, 16);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Senha";
            // 
            // ButtonCloseLogin
            // 
            this.ButtonCloseLogin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCloseLogin.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCloseLogin.Image")));
            this.ButtonCloseLogin.ImageActive = null;
            this.ButtonCloseLogin.Location = new System.Drawing.Point(478, 12);
            this.ButtonCloseLogin.Name = "ButtonCloseLogin";
            this.ButtonCloseLogin.Size = new System.Drawing.Size(18, 22);
            this.ButtonCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCloseLogin.TabIndex = 8;
            this.ButtonCloseLogin.TabStop = false;
            this.ButtonCloseLogin.Zoom = 10;
            this.ButtonCloseLogin.Click += new System.EventHandler(this.ButtonCloseLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonLogin.BorderRadius = 0;
            this.ButtonLogin.ButtonText = "                  Entrar no sistema";
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.Iconimage")));
            this.ButtonLogin.Iconimage_right = null;
            this.ButtonLogin.Iconimage_right_Selected = null;
            this.ButtonLogin.Iconimage_Selected = null;
            this.ButtonLogin.IconMarginLeft = 0;
            this.ButtonLogin.IconMarginRight = 0;
            this.ButtonLogin.IconRightVisible = true;
            this.ButtonLogin.IconRightZoom = 0D;
            this.ButtonLogin.IconVisible = true;
            this.ButtonLogin.IconZoom = 50D;
            this.ButtonLogin.IsTab = false;
            this.ButtonLogin.Location = new System.Drawing.Point(115, 369);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ButtonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.ButtonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonLogin.selected = false;
            this.ButtonLogin.Size = new System.Drawing.Size(297, 48);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "                  Entrar no sistema";
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogin.Textcolor = System.Drawing.Color.White;
            this.ButtonLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // BmtSenha
            // 
            this.BmtSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BmtSenha.BorderColorFocused = System.Drawing.Color.Silver;
            this.BmtSenha.BorderColorIdle = System.Drawing.Color.Transparent;
            this.BmtSenha.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.BmtSenha.BorderThickness = 3;
            this.BmtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BmtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BmtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.BmtSenha.isPassword = true;
            this.BmtSenha.Location = new System.Drawing.Point(115, 272);
            this.BmtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.BmtSenha.Name = "BmtSenha";
            this.BmtSenha.Size = new System.Drawing.Size(297, 44);
            this.BmtSenha.TabIndex = 9;
            this.BmtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BmtSenha.OnValueChanged += new System.EventHandler(this.apagaMensagem);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.ForeColor = System.Drawing.Color.DimGray;
            this.lblMsg.Location = new System.Drawing.Point(112, 346);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(508, 470);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.BmtSenha);
            this.Controls.Add(this.ButtonCloseLogin);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BmtUsuario);
            this.Controls.Add(this.ButtonLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCloseLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonLogin;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMetroTextbox BmtUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton ButtonCloseLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox BmtSenha;
        private System.Windows.Forms.Label lblMsg;
    }
}