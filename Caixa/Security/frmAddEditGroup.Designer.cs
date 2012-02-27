namespace Caixa.Security
{
    partial class frmAddEditGroup
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
            this.ckNovoGrupoAtivo = new System.Windows.Forms.CheckBox();
            this.txtNovoGrupoNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btCancelar = new Caixa.Controls.CaixaButton(this.components);
            this.btIncluir = new Caixa.Controls.CaixaButton(this.components);
            this.SuspendLayout();
            // 
            // ckNovoGrupoAtivo
            // 
            this.ckNovoGrupoAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckNovoGrupoAtivo.AutoSize = true;
            this.ckNovoGrupoAtivo.Location = new System.Drawing.Point(600, 132);
            this.ckNovoGrupoAtivo.Margin = new System.Windows.Forms.Padding(6);
            this.ckNovoGrupoAtivo.Name = "ckNovoGrupoAtivo";
            this.ckNovoGrupoAtivo.Size = new System.Drawing.Size(74, 29);
            this.ckNovoGrupoAtivo.TabIndex = 2;
            this.ckNovoGrupoAtivo.Text = "Ativo";
            this.ckNovoGrupoAtivo.UseVisualStyleBackColor = true;
            this.ckNovoGrupoAtivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoGrupoNome_KeyDown);
            // 
            // txtNovoGrupoNome
            // 
            this.txtNovoGrupoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovoGrupoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovoGrupoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNovoGrupoNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoGrupoNome.Location = new System.Drawing.Point(132, 129);
            this.txtNovoGrupoNome.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNovoGrupoNome.MaxLength = 20;
            this.txtNovoGrupoNome.Name = "txtNovoGrupoNome";
            this.txtNovoGrupoNome.Size = new System.Drawing.Size(429, 32);
            this.txtNovoGrupoNome.TabIndex = 1;
            this.txtNovoGrupoNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoGrupoNome_KeyDown);
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
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(15, -3);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(549, 65);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Novo Grupo de Usuários";
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
            this.btCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoGrupoNome_KeyDown);
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
            this.btIncluir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoGrupoNome_KeyDown);
            // 
            // frmAddEditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(713, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ckNovoGrupoAtivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNovoGrupoNome);
            this.Controls.Add(this.shapeContainer2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddEditGroup";
            this.Text = "Novo Grupo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddEditGroup_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CaixaButton btCancelar;
        private Controls.CaixaButton btIncluir;
        private System.Windows.Forms.CheckBox ckNovoGrupoAtivo;
        private System.Windows.Forms.TextBox txtNovoGrupoNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTitle;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}