namespace Caixa.Security
{
    partial class frmUserPasswordChange
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
            this.ckVerSenha = new System.Windows.Forms.CheckBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btCancelar = new Caixa.Controls.CaixaButton(this.components);
            this.btIncluir = new Caixa.Controls.CaixaButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckVerSenha
            // 
            this.ckVerSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckVerSenha.AutoSize = true;
            this.ckVerSenha.Location = new System.Drawing.Point(573, 132);
            this.ckVerSenha.Margin = new System.Windows.Forms.Padding(6);
            this.ckVerSenha.Name = "ckVerSenha";
            this.ckVerSenha.Size = new System.Drawing.Size(112, 29);
            this.ckVerSenha.TabIndex = 2;
            this.ckVerSenha.Text = "ver senha";
            this.ckVerSenha.UseVisualStyleBackColor = true;
            this.ckVerSenha.CheckedChanged += new System.EventHandler(this.ckVerSenha_CheckedChanged);
            this.ckVerSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaSenha_KeyDown);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNovaSenha.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(195, 129);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNovaSenha.MaxLength = 30;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(366, 32);
            this.txtNovaSenha.TabIndex = 1;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            this.txtNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaSenha_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nova Senha";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(15, -3);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(555, 65);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Alterar Senha do Usuário";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Yellow;
            this.lineShape1.BorderWidth = 15;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 0;
            this.lineShape1.Y1 = -3;
            this.lineShape1.Y2 = 364;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(713, 317);
            this.shapeContainer2.TabIndex = 20;
            this.shapeContainer2.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(354, 205);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(173, 47);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            this.btCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaSenha_KeyDown);
            // 
            // btIncluir
            // 
            this.btIncluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btIncluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btIncluir.Location = new System.Drawing.Point(169, 205);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(173, 47);
            this.btIncluir.TabIndex = 3;
            this.btIncluir.Text = "Concluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            this.btIncluir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaSenha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "pressione F5 para gerar uma nova senha automaticamente ou digite uma no campo aba" +
    "ixo.";
            // 
            // frmUserPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(713, 317);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ckVerSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.shapeContainer2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserPasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Grupo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CaixaButton btCancelar;
        private Controls.CaixaButton btIncluir;
        private System.Windows.Forms.CheckBox ckVerSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTitle;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label label1;
    }
}