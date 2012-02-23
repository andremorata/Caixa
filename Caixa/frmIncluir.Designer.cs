namespace Caixa
{
    partial class frmIncluir
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
            this.btCancelar = new Caixa.Controls.CaixaButton(this.components);
            this.btIncluir = new Caixa.Controls.CaixaButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.NumericUpDown();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.message = new Caixa.ctlBannerMessage();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
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
            this.btCancelar.Location = new System.Drawing.Point(683, 512);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
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
            this.btIncluir.Location = new System.Drawing.Point(532, 512);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(130, 42);
            this.btIncluir.TabIndex = 10;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo";
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipo.BackColor = System.Drawing.Color.White;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.err.SetIconPadding(this.cboTipo, 5);
            this.cboTipo.Items.AddRange(new object[] {
            "Selecione",
            "Entrada",
            "Saída"});
            this.cboTipo.Location = new System.Drawing.Point(296, 395);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(166, 40);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.CalendarForeColor = System.Drawing.Color.Black;
            this.txtData.CalendarMonthBackground = System.Drawing.Color.White;
            this.txtData.CalendarTitleBackColor = System.Drawing.Color.DodgerBlue;
            this.txtData.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.txtData.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.txtData.CustomFormat = "dd/MM/yyyy";
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.err.SetIconPadding(this.txtData, 5);
            this.txtData.Location = new System.Drawing.Point(296, 332);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(166, 39);
            this.txtData.TabIndex = 5;
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.DecimalPlaces = 2;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err.SetIconPadding(this.txtValor, 5);
            this.txtValor.Location = new System.Drawing.Point(296, 267);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(166, 39);
            this.txtValor.TabIndex = 3;
            this.txtValor.ThousandsSeparator = true;
            this.txtValor.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err.SetIconPadding(this.txtDescricao, 5);
            this.txtDescricao.Location = new System.Drawing.Point(296, 210);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(875, 32);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err.SetIconPadding(this.txtObservacao, 5);
            this.txtObservacao.Location = new System.Drawing.Point(644, 267);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacao.Size = new System.Drawing.Size(527, 168);
            this.txtObservacao.TabIndex = 9;
            this.txtObservacao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtObservacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Observações";
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(253)))), ((int)(((byte)(198)))));
            this.message.Location = new System.Drawing.Point(22, 99);
            this.message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.message.Message = "ÇPpjq";
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(1295, 78);
            this.message.TabIndex = 12;
            this.message.Title = "Descrição";
            // 
            // err
            // 
            this.err.BlinkRate = 50;
            this.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err.ContainerControl = this;
            // 
            // frmIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(1344, 682);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmIncluir";
            this.Text = "Caixa - Playmore";
            this.Title = "Incluir novo movimento";
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtData, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btIncluir, 0);
            this.Controls.SetChildIndex(this.btCancelar, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.message, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Caixa.Controls.CaixaButton btCancelar;
        private Caixa.Controls.CaixaButton btIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label2;
        private ctlBannerMessage message;
        private System.Windows.Forms.ErrorProvider err;
    }
}
