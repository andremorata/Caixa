namespace Caixa
{
    partial class frmMenu
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
            this.btAdminCaixa = new Caixa.Controls.CaixaButton(this.components);
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btInclusaoRapida = new Caixa.Controls.CaixaButton(this.components);
            this.btSeguranca = new Caixa.Controls.CaixaButton(this.components);
            this.btLembretes = new Caixa.Controls.CaixaButton(this.components);
            this.lbRelogio = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lbSegundos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAdminCaixa
            // 
            this.btAdminCaixa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdminCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAdminCaixa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAdminCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAdminCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAdminCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdminCaixa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdminCaixa.Image = global::Caixa.Properties.Resources.File_info48;
            this.btAdminCaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdminCaixa.Location = new System.Drawing.Point(337, 323);
            this.btAdminCaixa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdminCaixa.Name = "btAdminCaixa";
            this.btAdminCaixa.Size = new System.Drawing.Size(187, 90);
            this.btAdminCaixa.TabIndex = 12;
            this.btAdminCaixa.Text = "Admin. Caixa";
            this.btAdminCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdminCaixa.UseVisualStyleBackColor = true;
            this.btAdminCaixa.Click += new System.EventHandler(this.btAdminCaixa_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(28, 96);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(261, 50);
            this.lbWelcome.TabIndex = 11;
            this.lbWelcome.Text = "Bem-vindo, {0}";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Use os botões abaixo para iniciar as funções do sistema";
            // 
            // btInclusaoRapida
            // 
            this.btInclusaoRapida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInclusaoRapida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btInclusaoRapida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btInclusaoRapida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btInclusaoRapida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btInclusaoRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInclusaoRapida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInclusaoRapida.Image = global::Caixa.Properties.Resources.Add48;
            this.btInclusaoRapida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btInclusaoRapida.Location = new System.Drawing.Point(550, 323);
            this.btInclusaoRapida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInclusaoRapida.Name = "btInclusaoRapida";
            this.btInclusaoRapida.Size = new System.Drawing.Size(187, 90);
            this.btInclusaoRapida.TabIndex = 14;
            this.btInclusaoRapida.Text = "Inc. Rápida";
            this.btInclusaoRapida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInclusaoRapida.UseVisualStyleBackColor = true;
            this.btInclusaoRapida.Click += new System.EventHandler(this.btInclusaoRapida_Click);
            // 
            // btSeguranca
            // 
            this.btSeguranca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSeguranca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btSeguranca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btSeguranca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btSeguranca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btSeguranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeguranca.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeguranca.Image = global::Caixa.Properties.Resources.Lock48;
            this.btSeguranca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSeguranca.Location = new System.Drawing.Point(761, 323);
            this.btSeguranca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSeguranca.Name = "btSeguranca";
            this.btSeguranca.Size = new System.Drawing.Size(187, 90);
            this.btSeguranca.TabIndex = 15;
            this.btSeguranca.Text = "Segurança";
            this.btSeguranca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSeguranca.UseVisualStyleBackColor = true;
            this.btSeguranca.Click += new System.EventHandler(this.btSeguranca_Click);
            // 
            // btLembretes
            // 
            this.btLembretes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLembretes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btLembretes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btLembretes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btLembretes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btLembretes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLembretes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLembretes.Image = global::Caixa.Properties.Resources.Paperclip24;
            this.btLembretes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLembretes.Location = new System.Drawing.Point(1096, 627);
            this.btLembretes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLembretes.Name = "btLembretes";
            this.btLembretes.Size = new System.Drawing.Size(176, 42);
            this.btLembretes.TabIndex = 17;
            this.btLembretes.Text = "Lembretes";
            this.btLembretes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLembretes.UseVisualStyleBackColor = true;
            // 
            // lbRelogio
            // 
            this.lbRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRelogio.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelogio.Location = new System.Drawing.Point(12, 545);
            this.lbRelogio.Name = "lbRelogio";
            this.lbRelogio.Size = new System.Drawing.Size(284, 128);
            this.lbRelogio.TabIndex = 18;
            this.lbRelogio.Text = "22:55";
            this.lbRelogio.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 250;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // lbSegundos
            // 
            this.lbSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSegundos.AutoSize = true;
            this.lbSegundos.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundos.Location = new System.Drawing.Point(259, 595);
            this.lbSegundos.Name = "lbSegundos";
            this.lbSegundos.Size = new System.Drawing.Size(80, 65);
            this.lbSegundos.TabIndex = 19;
            this.lbSegundos.Text = "00";
            this.lbSegundos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(1284, 682);
            this.Controls.Add(this.lbSegundos);
            this.Controls.Add(this.lbRelogio);
            this.Controls.Add(this.btLembretes);
            this.Controls.Add(this.btSeguranca);
            this.Controls.Add(this.btInclusaoRapida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdminCaixa);
            this.Controls.Add(this.lbWelcome);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMenu";
            this.Title = "Caixa - Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Controls.SetChildIndex(this.lbWelcome, 0);
            this.Controls.SetChildIndex(this.btAdminCaixa, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btInclusaoRapida, 0);
            this.Controls.SetChildIndex(this.btSeguranca, 0);
            this.Controls.SetChildIndex(this.btLembretes, 0);
            this.Controls.SetChildIndex(this.lbRelogio, 0);
            this.Controls.SetChildIndex(this.lbSegundos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CaixaButton btAdminCaixa;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label1;
        private Controls.CaixaButton btInclusaoRapida;
        private Controls.CaixaButton btSeguranca;
        private Controls.CaixaButton btLembretes;
        private System.Windows.Forms.Label lbRelogio;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lbSegundos;
    }
}
