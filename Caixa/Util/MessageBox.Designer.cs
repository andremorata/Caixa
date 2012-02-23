namespace Caixa
{
    partial class MessageBox
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnIcon = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.btSim = new Caixa.Controls.CaixaButton(this.components);
            this.btNao = new Caixa.Controls.CaixaButton(this.components);
            this.btCancelar = new Caixa.Controls.CaixaButton(this.components);
            this.btOk = new Caixa.Controls.CaixaButton(this.components);
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lnIcon});
            this.shapeContainer1.Size = new System.Drawing.Size(760, 300);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.White;
            this.lineShape4.BorderWidth = 10;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -1;
            this.lineShape4.X2 = 762;
            this.lineShape4.Y1 = -4;
            this.lineShape4.Y2 = -4;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.BorderWidth = 10;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 762;
            this.lineShape3.X2 = 762;
            this.lineShape3.Y1 = -2;
            this.lineShape3.Y2 = 302;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.BorderWidth = 10;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -3;
            this.lineShape2.X2 = 759;
            this.lineShape2.Y1 = 303;
            this.lineShape2.Y2 = 303;
            // 
            // lnIcon
            // 
            this.lnIcon.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lnIcon.BorderWidth = 10;
            this.lnIcon.Name = "lnIcon";
            this.lnIcon.X1 = 4;
            this.lnIcon.X2 = 4;
            this.lnIcon.Y1 = -1;
            this.lnIcon.Y2 = 302;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(14, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(485, 65);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Movimentos do Caixa";
            // 
            // lbContent
            // 
            this.lbContent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.White;
            this.lbContent.Location = new System.Drawing.Point(14, 75);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(734, 150);
            this.lbContent.TabIndex = 8;
            this.lbContent.Text = "Content";
            this.lbContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSim
            // 
            this.btSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSim.Location = new System.Drawing.Point(112, 245);
            this.btSim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSim.Name = "btSim";
            this.btSim.Size = new System.Drawing.Size(130, 42);
            this.btSim.TabIndex = 24;
            this.btSim.Text = "Sim";
            this.btSim.UseVisualStyleBackColor = false;
            this.btSim.Visible = false;
            this.btSim.Click += new System.EventHandler(this.btSim_Click);
            // 
            // btNao
            // 
            this.btNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNao.Location = new System.Drawing.Point(248, 245);
            this.btNao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNao.Name = "btNao";
            this.btNao.Size = new System.Drawing.Size(130, 42);
            this.btNao.TabIndex = 25;
            this.btNao.Text = "Não";
            this.btNao.UseVisualStyleBackColor = false;
            this.btNao.Visible = false;
            this.btNao.Click += new System.EventHandler(this.btNao_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(520, 245);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Location = new System.Drawing.Point(384, 245);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(130, 42);
            this.btOk.TabIndex = 26;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Visible = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(760, 300);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btNao);
            this.Controls.Add(this.btSim);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnIcon;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbContent;
        private Caixa.Controls.CaixaButton btSim;
        private Caixa.Controls.CaixaButton btNao;
        private Caixa.Controls.CaixaButton btCancelar;
        private Caixa.Controls.CaixaButton btOk;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}