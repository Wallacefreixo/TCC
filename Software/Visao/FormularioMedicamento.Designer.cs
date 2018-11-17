namespace Visao
{
    partial class FormularioMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMedicamento));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bmtduracao = new System.Windows.Forms.TextBox();
            this.labelduracao = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bmtdossagem = new System.Windows.Forms.TextBox();
            this.labelintervalo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bmtintervalo = new System.Windows.Forms.TextBox();
            this.labeldossagem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnAdicionarDadosMed = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bmtduracao
            // 
            this.bmtduracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bmtduracao.ForeColor = System.Drawing.Color.DimGray;
            this.bmtduracao.Location = new System.Drawing.Point(242, 64);
            this.bmtduracao.Name = "bmtduracao";
            this.bmtduracao.Size = new System.Drawing.Size(62, 20);
            this.bmtduracao.TabIndex = 148;
            // 
            // labelduracao
            // 
            this.labelduracao.AutoSize = true;
            this.labelduracao.ForeColor = System.Drawing.Color.DimGray;
            this.labelduracao.Location = new System.Drawing.Point(239, 37);
            this.labelduracao.Name = "labelduracao";
            this.labelduracao.Size = new System.Drawing.Size(48, 13);
            this.labelduracao.TabIndex = 147;
            this.labelduracao.Text = "Duração";
            // 
            // bmtdossagem
            // 
            this.bmtdossagem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bmtdossagem.ForeColor = System.Drawing.Color.DimGray;
            this.bmtdossagem.Location = new System.Drawing.Point(31, 64);
            this.bmtdossagem.Name = "bmtdossagem";
            this.bmtdossagem.Size = new System.Drawing.Size(67, 20);
            this.bmtdossagem.TabIndex = 149;
            // 
            // labelintervalo
            // 
            this.labelintervalo.AutoSize = true;
            this.labelintervalo.ForeColor = System.Drawing.Color.DimGray;
            this.labelintervalo.Location = new System.Drawing.Point(118, 37);
            this.labelintervalo.Name = "labelintervalo";
            this.labelintervalo.Size = new System.Drawing.Size(95, 13);
            this.labelintervalo.TabIndex = 145;
            this.labelintervalo.Text = "Intervalo de tempo";
            // 
            // bmtintervalo
            // 
            this.bmtintervalo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bmtintervalo.ForeColor = System.Drawing.Color.DimGray;
            this.bmtintervalo.Location = new System.Drawing.Point(121, 64);
            this.bmtintervalo.Name = "bmtintervalo";
            this.bmtintervalo.Size = new System.Drawing.Size(92, 20);
            this.bmtintervalo.TabIndex = 146;
            // 
            // labeldossagem
            // 
            this.labeldossagem.AutoSize = true;
            this.labeldossagem.ForeColor = System.Drawing.Color.DimGray;
            this.labeldossagem.Location = new System.Drawing.Point(28, 37);
            this.labeldossagem.Name = "labeldossagem";
            this.labeldossagem.Size = new System.Drawing.Size(57, 13);
            this.labeldossagem.TabIndex = 144;
            this.labeldossagem.Text = "Dossagem";
            // 
            // BtnAdicionarDadosMed
            // 
            this.BtnAdicionarDadosMed.ActiveBorderThickness = 1;
            this.BtnAdicionarDadosMed.ActiveCornerRadius = 20;
            this.BtnAdicionarDadosMed.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.BtnAdicionarDadosMed.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnAdicionarDadosMed.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.BtnAdicionarDadosMed.BackColor = System.Drawing.Color.OldLace;
            this.BtnAdicionarDadosMed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdicionarDadosMed.BackgroundImage")));
            this.BtnAdicionarDadosMed.ButtonText = "Adicionar";
            this.BtnAdicionarDadosMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionarDadosMed.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarDadosMed.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAdicionarDadosMed.IdleBorderThickness = 1;
            this.BtnAdicionarDadosMed.IdleCornerRadius = 20;
            this.BtnAdicionarDadosMed.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.BtnAdicionarDadosMed.IdleForecolor = System.Drawing.Color.Transparent;
            this.BtnAdicionarDadosMed.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.BtnAdicionarDadosMed.Location = new System.Drawing.Point(328, 52);
            this.BtnAdicionarDadosMed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAdicionarDadosMed.Name = "BtnAdicionarDadosMed";
            this.BtnAdicionarDadosMed.Size = new System.Drawing.Size(79, 35);
            this.BtnAdicionarDadosMed.TabIndex = 150;
            this.BtnAdicionarDadosMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAdicionarDadosMed.Click += new System.EventHandler(this.BtnAdicionarDadosMed_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.Transparent;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.ImageActive = null;
            this.BtnFechar.Location = new System.Drawing.Point(393, 6);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(17, 18);
            this.BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnFechar.TabIndex = 151;
            this.BtnFechar.TabStop = false;
            this.BtnFechar.Zoom = 10;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormularioMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(420, 115);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAdicionarDadosMed);
            this.Controls.Add(this.bmtduracao);
            this.Controls.Add(this.labelduracao);
            this.Controls.Add(this.bmtdossagem);
            this.Controls.Add(this.labelintervalo);
            this.Controls.Add(this.bmtintervalo);
            this.Controls.Add(this.labeldossagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioMedicamento";
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox bmtduracao;
        private Bunifu.Framework.UI.BunifuCustomLabel labelduracao;
        private System.Windows.Forms.TextBox bmtdossagem;
        private Bunifu.Framework.UI.BunifuCustomLabel labelintervalo;
        private System.Windows.Forms.TextBox bmtintervalo;
        private Bunifu.Framework.UI.BunifuCustomLabel labeldossagem;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAdicionarDadosMed;
        private Bunifu.Framework.UI.BunifuImageButton BtnFechar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

    }
}