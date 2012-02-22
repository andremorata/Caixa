namespace Caixa
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btIncluir = new Caixa.Controls.CaixaButton(this.components);
            this.gdData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAlterar = new Caixa.Controls.CaixaButton(this.components);
            this.btExcluir = new Caixa.Controls.CaixaButton(this.components);
            this.lstData = new System.Windows.Forms.ListBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnNoData = new Caixa.Controls.CaixaButton(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btBusca = new Caixa.Controls.CaixaButton(this.components);
            this.btInclusaoRapida = new Caixa.Controls.CaixaButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btIncluir
            // 
            this.btIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btIncluir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncluir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.Location = new System.Drawing.Point(339, 129);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(150, 42);
            this.btIncluir.TabIndex = 2;
            this.btIncluir.Text = "Incluir (F1)";
            this.btIncluir.UseVisualStyleBackColor = false;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // gdData
            // 
            this.gdData.AllowUserToAddRows = false;
            this.gdData.AllowUserToDeleteRows = false;
            this.gdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdData.BackgroundColor = System.Drawing.Color.Black;
            this.gdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdData.ColumnHeadersHeight = 50;
            this.gdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tipo,
            this.Descricao,
            this.Data,
            this.Valor});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdData.DefaultCellStyle = dataGridViewCellStyle4;
            this.gdData.EnableHeadersVisualStyles = false;
            this.gdData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gdData.Location = new System.Drawing.Point(337, 177);
            this.gdData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdData.MultiSelect = false;
            this.gdData.Name = "gdData";
            this.gdData.ReadOnly = true;
            this.gdData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdData.RowHeadersVisible = false;
            this.gdData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gdData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdData.Size = new System.Drawing.Size(1001, 410);
            this.gdData.StandardTab = true;
            this.gdData.TabIndex = 7;
            this.gdData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gdData_DataBindingComplete);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tipo.Width = 10;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 350;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 59;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 220;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(699, 129);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(150, 42);
            this.btAlterar.TabIndex = 4;
            this.btAlterar.Text = "Alterar (F2)";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(855, 129);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(160, 42);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir (DEL)";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lstData
            // 
            this.lstData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstData.BackColor = System.Drawing.Color.Black;
            this.lstData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstData.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstData.ForeColor = System.Drawing.Color.White;
            this.lstData.FormattingEnabled = true;
            this.lstData.IntegralHeight = false;
            this.lstData.ItemHeight = 50;
            this.lstData.Items.AddRange(new object[] {
            "01/01/2012",
            "02/01/2012",
            "03/01/2012"});
            this.lstData.Location = new System.Drawing.Point(12, 127);
            this.lstData.Name = "lstData";
            this.lstData.ScrollAlwaysVisible = true;
            this.lstData.Size = new System.Drawing.Size(319, 542);
            this.lstData.TabIndex = 1;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(900, 591);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(424, 82);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "R$ 0,00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnNoData
            // 
            this.pnNoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnNoData.BackColor = System.Drawing.Color.Black;
            this.pnNoData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pnNoData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.pnNoData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnNoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnNoData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnNoData.Location = new System.Drawing.Point(381, 276);
            this.pnNoData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnNoData.Name = "pnNoData";
            this.pnNoData.Size = new System.Drawing.Size(588, 130);
            this.pnNoData.TabIndex = 0;
            this.pnNoData.Text = "Sem dados para exibir. \r\nClique aqui para adicionar um movimento.";
            this.pnNoData.UseVisualStyleBackColor = false;
            this.pnNoData.Click += new System.EventHandler(this.pnNoData_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1350, 682);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape1.BorderWidth = 10;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1333;
            this.lineShape1.X2 = 1333;
            this.lineShape1.Y1 = 592;
            this.lineShape1.Y2 = 675;
            // 
            // btBusca
            // 
            this.btBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btBusca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btBusca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btBusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBusca.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.Location = new System.Drawing.Point(1021, 129);
            this.btBusca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(160, 42);
            this.btBusca.TabIndex = 6;
            this.btBusca.Text = "Busca (F3)";
            this.btBusca.UseVisualStyleBackColor = false;
            this.btBusca.Visible = false;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // btInclusaoRapida
            // 
            this.btInclusaoRapida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btInclusaoRapida.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btInclusaoRapida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btInclusaoRapida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btInclusaoRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInclusaoRapida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInclusaoRapida.Location = new System.Drawing.Point(495, 129);
            this.btInclusaoRapida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInclusaoRapida.Name = "btInclusaoRapida";
            this.btInclusaoRapida.Size = new System.Drawing.Size(198, 42);
            this.btInclusaoRapida.TabIndex = 3;
            this.btInclusaoRapida.Text = "Inc. Rápida (F5)";
            this.btInclusaoRapida.UseVisualStyleBackColor = false;
            this.btInclusaoRapida.Click += new System.EventHandler(this.btInclusaoRapida_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 682);
            this.Controls.Add(this.btInclusaoRapida);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.pnNoData);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.gdData);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.shapeContainer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.Controls.SetChildIndex(this.shapeContainer1, 0);
            this.Controls.SetChildIndex(this.lbTotal, 0);
            this.Controls.SetChildIndex(this.lstData, 0);
            this.Controls.SetChildIndex(this.gdData, 0);
            this.Controls.SetChildIndex(this.btIncluir, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btExcluir, 0);
            this.Controls.SetChildIndex(this.pnNoData, 0);
            this.Controls.SetChildIndex(this.btBusca, 0);
            this.Controls.SetChildIndex(this.btInclusaoRapida, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Caixa.Controls.CaixaButton btIncluir;
        private System.Windows.Forms.DataGridView gdData;
        private Caixa.Controls.CaixaButton btAlterar;
        private Caixa.Controls.CaixaButton btExcluir;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label lbTotal;
        private Caixa.Controls.CaixaButton pnNoData;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private Caixa.Controls.CaixaButton btBusca;
        private Caixa.Controls.CaixaButton btInclusaoRapida;
    }
}

