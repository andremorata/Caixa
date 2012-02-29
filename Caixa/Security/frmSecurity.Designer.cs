namespace Caixa
{
    partial class frmSecurity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAdmLogin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btVerTodosUsuarios = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btTornarUsuarioInativo = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btNovoUsuario = new System.Windows.Forms.LinkLabel();
            this.btAlterarSenha = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gdUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdUserCol_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoveUser = new Caixa.Controls.CaixaButton(this.components);
            this.btAddUser = new Caixa.Controls.CaixaButton(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.gdGrupos = new System.Windows.Forms.DataGridView();
            this.groupCol_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCol_Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCol_Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupCol_Permissoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCol_Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoveGroup = new Caixa.Controls.CaixaButton(this.components);
            this.btAddGroup = new Caixa.Controls.CaixaButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btPermissoes = new Caixa.Controls.CaixaButton(this.components);
            this.btAdmLogin = new Caixa.Controls.CaixaButton(this.components);
            this.gbPermissoes = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gdGroupFeatures = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btRemoveFeature = new Caixa.Controls.CaixaButton(this.components);
            this.btSelectFeature = new Caixa.Controls.CaixaButton(this.components);
            this.gdGroupPermissoes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAdmLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdGrupos)).BeginInit();
            this.gbPermissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdGroupFeatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdGroupPermissoes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdmLogin
            // 
            this.gbAdmLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdmLogin.Controls.Add(this.groupBox1);
            this.gbAdmLogin.Controls.Add(this.label4);
            this.gbAdmLogin.Controls.Add(this.gdUsuarios);
            this.gbAdmLogin.Controls.Add(this.btRemoveUser);
            this.gbAdmLogin.Controls.Add(this.btAddUser);
            this.gbAdmLogin.Controls.Add(this.label3);
            this.gbAdmLogin.Controls.Add(this.gdGrupos);
            this.gbAdmLogin.Controls.Add(this.btRemoveGroup);
            this.gbAdmLogin.Controls.Add(this.btAddGroup);
            this.gbAdmLogin.Controls.Add(this.label1);
            this.gbAdmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAdmLogin.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmLogin.Location = new System.Drawing.Point(85, 208);
            this.gbAdmLogin.Name = "gbAdmLogin";
            this.gbAdmLogin.Size = new System.Drawing.Size(1112, 417);
            this.gbAdmLogin.TabIndex = 9;
            this.gbAdmLogin.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.btVerTodosUsuarios);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btTornarUsuarioInativo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btNovoUsuario);
            this.groupBox1.Controls.Add(this.btAlterarSenha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(856, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 361);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btVerTodosUsuarios
            // 
            this.btVerTodosUsuarios.AutoSize = true;
            this.btVerTodosUsuarios.LinkColor = System.Drawing.Color.DodgerBlue;
            this.btVerTodosUsuarios.Location = new System.Drawing.Point(27, 104);
            this.btVerTodosUsuarios.Name = "btVerTodosUsuarios";
            this.btVerTodosUsuarios.Size = new System.Drawing.Size(181, 36);
            this.btVerTodosUsuarios.TabIndex = 28;
            this.btVerTodosUsuarios.TabStop = true;
            this.btVerTodosUsuarios.Text = "Buscar usuário";
            this.btVerTodosUsuarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btVerTodosUsuarios_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "> do usuário";
            // 
            // btTornarUsuarioInativo
            // 
            this.btTornarUsuarioInativo.AutoSize = true;
            this.btTornarUsuarioInativo.LinkColor = System.Drawing.Color.DodgerBlue;
            this.btTornarUsuarioInativo.Location = new System.Drawing.Point(27, 261);
            this.btTornarUsuarioInativo.Name = "btTornarUsuarioInativo";
            this.btTornarUsuarioInativo.Size = new System.Drawing.Size(161, 36);
            this.btTornarUsuarioInativo.TabIndex = 26;
            this.btTornarUsuarioInativo.TabStop = true;
            this.btTornarUsuarioInativo.Text = "Ativo/Inativo";
            this.btTornarUsuarioInativo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btTornarUsuarioInativo_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "> do sistema";
            // 
            // btNovoUsuario
            // 
            this.btNovoUsuario.AutoSize = true;
            this.btNovoUsuario.LinkColor = System.Drawing.Color.DodgerBlue;
            this.btNovoUsuario.Location = new System.Drawing.Point(27, 68);
            this.btNovoUsuario.Name = "btNovoUsuario";
            this.btNovoUsuario.Size = new System.Drawing.Size(167, 36);
            this.btNovoUsuario.TabIndex = 3;
            this.btNovoUsuario.TabStop = true;
            this.btNovoUsuario.Text = "Novo usuário";
            this.btNovoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btNovoUsuario_LinkClicked);
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.AutoSize = true;
            this.btAlterarSenha.LinkColor = System.Drawing.Color.DodgerBlue;
            this.btAlterarSenha.Location = new System.Drawing.Point(27, 213);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(167, 36);
            this.btAlterarSenha.TabIndex = 2;
            this.btAlterarSenha.TabStop = true;
            this.btAlterarSenha.Text = "Alterar senha";
            this.btAlterarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btAlterarSenha_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(14, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ações";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Usuários Associados ao Grupo";
            // 
            // gdUsuarios
            // 
            this.gdUsuarios.AllowUserToAddRows = false;
            this.gdUsuarios.AllowUserToDeleteRows = false;
            this.gdUsuarios.AllowUserToResizeColumns = false;
            this.gdUsuarios.AllowUserToResizeRows = false;
            this.gdUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gdUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gdUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.gdUserCol_Usuario,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gdUsuarios.EnableHeadersVisualStyles = false;
            this.gdUsuarios.Location = new System.Drawing.Point(451, 83);
            this.gdUsuarios.MultiSelect = false;
            this.gdUsuarios.Name = "gdUsuarios";
            this.gdUsuarios.ReadOnly = true;
            this.gdUsuarios.RowHeadersVisible = false;
            this.gdUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gdUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gdUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.gdUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdUsuarios.Size = new System.Drawing.Size(380, 318);
            this.gdUsuarios.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // gdUserCol_Usuario
            // 
            this.gdUserCol_Usuario.DataPropertyName = "Username";
            this.gdUserCol_Usuario.HeaderText = "Usuário";
            this.gdUserCol_Usuario.Name = "gdUserCol_Usuario";
            this.gdUserCol_Usuario.ReadOnly = true;
            this.gdUserCol_Usuario.Width = 250;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.FalseValue = "";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GruposUsuarios";
            this.dataGridViewTextBoxColumn3.HeaderText = "GruposUsuarios";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // btRemoveUser
            // 
            this.btRemoveUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btRemoveUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btRemoveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btRemoveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveUser.Image = global::Caixa.Properties.Resources.Delete24;
            this.btRemoveUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRemoveUser.Location = new System.Drawing.Point(790, 41);
            this.btRemoveUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRemoveUser.Name = "btRemoveUser";
            this.btRemoveUser.Size = new System.Drawing.Size(40, 35);
            this.btRemoveUser.TabIndex = 22;
            this.btRemoveUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRemoveUser.UseVisualStyleBackColor = true;
            this.btRemoveUser.Click += new System.EventHandler(this.btRemoveUser_Click);
            // 
            // btAddUser
            // 
            this.btAddUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddUser.Image = global::Caixa.Properties.Resources.Add24;
            this.btAddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAddUser.Location = new System.Drawing.Point(743, 41);
            this.btAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(40, 35);
            this.btAddUser.TabIndex = 21;
            this.btAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Grupos";
            // 
            // gdGrupos
            // 
            this.gdGrupos.AllowUserToAddRows = false;
            this.gdGrupos.AllowUserToDeleteRows = false;
            this.gdGrupos.AllowUserToResizeColumns = false;
            this.gdGrupos.AllowUserToResizeRows = false;
            this.gdGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gdGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdGrupos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gdGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupCol_Id,
            this.groupCol_Grupo,
            this.groupCol_Ativo,
            this.groupCol_Permissoes,
            this.groupCol_Login});
            this.gdGrupos.EnableHeadersVisualStyles = false;
            this.gdGrupos.Location = new System.Drawing.Point(44, 83);
            this.gdGrupos.MultiSelect = false;
            this.gdGrupos.Name = "gdGrupos";
            this.gdGrupos.ReadOnly = true;
            this.gdGrupos.RowHeadersVisible = false;
            this.gdGrupos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gdGrupos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gdGrupos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.gdGrupos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdGrupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdGrupos.Size = new System.Drawing.Size(380, 318);
            this.gdGrupos.TabIndex = 19;
            this.gdGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdGrupos_CellDoubleClick);
            this.gdGrupos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdGrupos_RowEnter);
            // 
            // groupCol_Id
            // 
            this.groupCol_Id.DataPropertyName = "Id";
            this.groupCol_Id.HeaderText = "Id";
            this.groupCol_Id.Name = "groupCol_Id";
            this.groupCol_Id.ReadOnly = true;
            this.groupCol_Id.Visible = false;
            // 
            // groupCol_Grupo
            // 
            this.groupCol_Grupo.DataPropertyName = "Nome";
            this.groupCol_Grupo.HeaderText = "Grupo";
            this.groupCol_Grupo.Name = "groupCol_Grupo";
            this.groupCol_Grupo.ReadOnly = true;
            this.groupCol_Grupo.Width = 250;
            // 
            // groupCol_Ativo
            // 
            this.groupCol_Ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.groupCol_Ativo.DataPropertyName = "Ativo";
            this.groupCol_Ativo.FalseValue = "";
            this.groupCol_Ativo.HeaderText = "Ativo";
            this.groupCol_Ativo.Name = "groupCol_Ativo";
            this.groupCol_Ativo.ReadOnly = true;
            this.groupCol_Ativo.Width = 79;
            // 
            // groupCol_Permissoes
            // 
            this.groupCol_Permissoes.DataPropertyName = "Permissoes";
            this.groupCol_Permissoes.HeaderText = "Permissoes";
            this.groupCol_Permissoes.Name = "groupCol_Permissoes";
            this.groupCol_Permissoes.ReadOnly = true;
            this.groupCol_Permissoes.Visible = false;
            // 
            // groupCol_Login
            // 
            this.groupCol_Login.DataPropertyName = "Logins";
            this.groupCol_Login.HeaderText = "Logins";
            this.groupCol_Login.Name = "groupCol_Login";
            this.groupCol_Login.ReadOnly = true;
            this.groupCol_Login.Visible = false;
            // 
            // btRemoveGroup
            // 
            this.btRemoveGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRemoveGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btRemoveGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btRemoveGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btRemoveGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btRemoveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveGroup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveGroup.Image = global::Caixa.Properties.Resources.Delete24;
            this.btRemoveGroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRemoveGroup.Location = new System.Drawing.Point(383, 41);
            this.btRemoveGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRemoveGroup.Name = "btRemoveGroup";
            this.btRemoveGroup.Size = new System.Drawing.Size(40, 35);
            this.btRemoveGroup.TabIndex = 18;
            this.btRemoveGroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRemoveGroup.UseVisualStyleBackColor = true;
            this.btRemoveGroup.Click += new System.EventHandler(this.btRemoveGroup_Click);
            // 
            // btAddGroup
            // 
            this.btAddGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddGroup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddGroup.Image = global::Caixa.Properties.Resources.Add24;
            this.btAddGroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAddGroup.Location = new System.Drawing.Point(336, 41);
            this.btAddGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddGroup.Name = "btAddGroup";
            this.btAddGroup.Size = new System.Drawing.Size(40, 35);
            this.btAddGroup.TabIndex = 17;
            this.btAddGroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAddGroup.UseVisualStyleBackColor = true;
            this.btAddGroup.Click += new System.EventHandler(this.btAddGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(14, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Login";
            // 
            // btPermissoes
            // 
            this.btPermissoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btPermissoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btPermissoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btPermissoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btPermissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPermissoes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPermissoes.Image = global::Caixa.Properties.Resources.Key48;
            this.btPermissoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPermissoes.Location = new System.Drawing.Point(239, 96);
            this.btPermissoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPermissoes.Name = "btPermissoes";
            this.btPermissoes.Size = new System.Drawing.Size(187, 90);
            this.btPermissoes.TabIndex = 16;
            this.btPermissoes.Text = "Permissões";
            this.btPermissoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPermissoes.UseVisualStyleBackColor = true;
            this.btPermissoes.Click += new System.EventHandler(this.btPermissoes_Click);
            // 
            // btAdmLogin
            // 
            this.btAdmLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btAdmLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAdmLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAdmLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btAdmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmLogin.Image = global::Caixa.Properties.Resources.User48;
            this.btAdmLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdmLogin.Location = new System.Drawing.Point(26, 96);
            this.btAdmLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdmLogin.Name = "btAdmLogin";
            this.btAdmLogin.Size = new System.Drawing.Size(187, 90);
            this.btAdmLogin.TabIndex = 15;
            this.btAdmLogin.Text = "Adm. Login";
            this.btAdmLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdmLogin.UseVisualStyleBackColor = true;
            this.btAdmLogin.Click += new System.EventHandler(this.btAdmLogin_Click);
            // 
            // gbPermissoes
            // 
            this.gbPermissoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPermissoes.Controls.Add(this.label9);
            this.gbPermissoes.Controls.Add(this.gdGroupFeatures);
            this.gbPermissoes.Controls.Add(this.label8);
            this.gbPermissoes.Controls.Add(this.btRemoveFeature);
            this.gbPermissoes.Controls.Add(this.btSelectFeature);
            this.gbPermissoes.Controls.Add(this.gdGroupPermissoes);
            this.gbPermissoes.Controls.Add(this.label2);
            this.gbPermissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPermissoes.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissoes.Location = new System.Drawing.Point(53, 177);
            this.gbPermissoes.Name = "gbPermissoes";
            this.gbPermissoes.Size = new System.Drawing.Size(1112, 417);
            this.gbPermissoes.TabIndex = 10;
            this.gbPermissoes.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Permissões do grupo";
            // 
            // gdGroupFeatures
            // 
            this.gdGroupFeatures.AllowUserToAddRows = false;
            this.gdGroupFeatures.AllowUserToDeleteRows = false;
            this.gdGroupFeatures.AllowUserToResizeColumns = false;
            this.gdGroupFeatures.AllowUserToResizeRows = false;
            this.gdGroupFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gdGroupFeatures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdGroupFeatures.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gdGroupFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdGroupFeatures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdGroupFeatures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gdGroupFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdGroupFeatures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column1});
            this.gdGroupFeatures.EnableHeadersVisualStyles = false;
            this.gdGroupFeatures.Location = new System.Drawing.Point(570, 66);
            this.gdGroupFeatures.MultiSelect = false;
            this.gdGroupFeatures.Name = "gdGroupFeatures";
            this.gdGroupFeatures.ReadOnly = true;
            this.gdGroupFeatures.RowHeadersVisible = false;
            this.gdGroupFeatures.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gdGroupFeatures.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gdGroupFeatures.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.gdGroupFeatures.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdGroupFeatures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdGroupFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdGroupFeatures.Size = new System.Drawing.Size(380, 332);
            this.gdGroupFeatures.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Função";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 350;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Permissoes";
            this.Column1.HeaderText = "Permissoes";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Grupos";
            // 
            // btRemoveFeature
            // 
            this.btRemoveFeature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRemoveFeature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btRemoveFeature.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btRemoveFeature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btRemoveFeature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btRemoveFeature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveFeature.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveFeature.Image = global::Caixa.Properties.Resources.Delete24;
            this.btRemoveFeature.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRemoveFeature.Location = new System.Drawing.Point(910, 28);
            this.btRemoveFeature.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRemoveFeature.Name = "btRemoveFeature";
            this.btRemoveFeature.Size = new System.Drawing.Size(40, 35);
            this.btRemoveFeature.TabIndex = 22;
            this.btRemoveFeature.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRemoveFeature.UseVisualStyleBackColor = true;
            this.btRemoveFeature.Click += new System.EventHandler(this.btRemoveFeature_Click);
            // 
            // btSelectFeature
            // 
            this.btSelectFeature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSelectFeature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btSelectFeature.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btSelectFeature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btSelectFeature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btSelectFeature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelectFeature.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectFeature.Image = global::Caixa.Properties.Resources.Add24;
            this.btSelectFeature.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSelectFeature.Location = new System.Drawing.Point(863, 28);
            this.btSelectFeature.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSelectFeature.Name = "btSelectFeature";
            this.btSelectFeature.Size = new System.Drawing.Size(40, 35);
            this.btSelectFeature.TabIndex = 21;
            this.btSelectFeature.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSelectFeature.UseVisualStyleBackColor = true;
            this.btSelectFeature.Click += new System.EventHandler(this.btSelectFeature_Click);
            // 
            // gdGroupPermissoes
            // 
            this.gdGroupPermissoes.AllowUserToAddRows = false;
            this.gdGroupPermissoes.AllowUserToDeleteRows = false;
            this.gdGroupPermissoes.AllowUserToResizeColumns = false;
            this.gdGroupPermissoes.AllowUserToResizeRows = false;
            this.gdGroupPermissoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gdGroupPermissoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdGroupPermissoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.gdGroupPermissoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdGroupPermissoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdGroupPermissoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdGroupPermissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdGroupPermissoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gdGroupPermissoes.EnableHeadersVisualStyles = false;
            this.gdGroupPermissoes.Location = new System.Drawing.Point(162, 66);
            this.gdGroupPermissoes.MultiSelect = false;
            this.gdGroupPermissoes.Name = "gdGroupPermissoes";
            this.gdGroupPermissoes.ReadOnly = true;
            this.gdGroupPermissoes.RowHeadersVisible = false;
            this.gdGroupPermissoes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gdGroupPermissoes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gdGroupPermissoes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.gdGroupPermissoes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdGroupPermissoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdGroupPermissoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdGroupPermissoes.Size = new System.Drawing.Size(380, 332);
            this.gdGroupPermissoes.TabIndex = 20;
            this.gdGroupPermissoes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdGroupPermissoes_RowEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn2.FalseValue = "";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Permissoes";
            this.dataGridViewTextBoxColumn6.HeaderText = "Permissoes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Logins";
            this.dataGridViewTextBoxColumn7.HeaderText = "Logins";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(14, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Permissões";
            // 
            // frmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(1284, 662);
            this.Controls.Add(this.gbPermissoes);
            this.Controls.Add(this.gbAdmLogin);
            this.Controls.Add(this.btPermissoes);
            this.Controls.Add(this.btAdmLogin);
            this.Feature = "Caixa_Seguranca";
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSecurity";
            this.Text = "Segurança";
            this.Title = "Central de Segurança";
            this.Controls.SetChildIndex(this.btAdmLogin, 0);
            this.Controls.SetChildIndex(this.btPermissoes, 0);
            this.Controls.SetChildIndex(this.gbAdmLogin, 0);
            this.Controls.SetChildIndex(this.gbPermissoes, 0);
            this.gbAdmLogin.ResumeLayout(false);
            this.gbAdmLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdGrupos)).EndInit();
            this.gbPermissoes.ResumeLayout(false);
            this.gbPermissoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdGroupFeatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdGroupPermissoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdmLogin;
        private Controls.CaixaButton btPermissoes;
        private Controls.CaixaButton btAdmLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPermissoes;
        private System.Windows.Forms.Label label2;
        private Controls.CaixaButton btAddGroup;
        private Controls.CaixaButton btRemoveGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdGrupos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gdUsuarios;
        private Controls.CaixaButton btRemoveUser;
        private Controls.CaixaButton btAddUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel btTornarUsuarioInativo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel btNovoUsuario;
        private System.Windows.Forms.LinkLabel btAlterarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel btVerTodosUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdUserCol_Usuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Grupo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn groupCol_Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Permissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gdGroupFeatures;
        private System.Windows.Forms.Label label8;
        private Controls.CaixaButton btRemoveFeature;
        private Controls.CaixaButton btSelectFeature;
        private System.Windows.Forms.DataGridView gdGroupPermissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
