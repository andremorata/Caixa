namespace Caixa
{
    partial class frmAlterar
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
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
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(694, 514);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(543, 514);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 23;
            this.btAlterar.Text = "Concluir";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 20;
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
            this.cboTipo.Items.AddRange(new object[] {
            "Selecione",
            "Entrada",
            "Saída"});
            this.cboTipo.Location = new System.Drawing.Point(307, 397);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(166, 40);
            this.cboTipo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 32);
            this.label6.TabIndex = 18;
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
            this.txtData.Location = new System.Drawing.Point(307, 334);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(166, 39);
            this.txtData.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.DecimalPlaces = 2;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(307, 269);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(166, 39);
            this.txtValor.TabIndex = 17;
            this.txtValor.ThousandsSeparator = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(307, 212);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(875, 32);
            this.txtDescricao.TabIndex = 15;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(655, 269);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacao.Size = new System.Drawing.Size(527, 168);
            this.txtObservacao.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Observações";
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Location = new System.Drawing.Point(22, 99);
            this.message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.message.Message = "Texto";
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(1317, 84);
            this.message.TabIndex = 27;
            this.message.Title = "Descrição";
            // 
            // err
            // 
            this.err.BlinkRate = 50;
            this.err.ContainerControl = this;
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAlterar";
            this.Text = "Caixa - Playmore";
            this.Title = "Alterar movimento cadastrado";
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtData, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
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

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
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
