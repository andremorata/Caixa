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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label2 = new System.Windows.Forms.Label();
            this.gbAdmLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdGrupos)).BeginInit();
            this.gbPermissoes.SuspendLayout();
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
            this.btVerTodosUsuarios.Size = new System.Drawing.Size(126, 36);
            this.btVerTodosUsuarios.TabIndex = 28;
            this.btVerTodosUsuarios.TabStop = true;
            this.btVerTodosUsuarios.Text = "Ver todos";
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
            this.dataGridViewTextBoxColumn2,
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
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
            this.groupCol_Login.DataPropertyName = "Login";
            this.groupCol_Login.HeaderText = "Login";
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
            this.btPermissoes.Location = new System.Drawing.Point(239, 83);
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
            this.btAdmLogin.Location = new System.Drawing.Point(26, 83);
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
            this.gbPermissoes.Controls.Add(this.label2);
            this.gbPermissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPermissoes.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissoes.Location = new System.Drawing.Point(53, 177);
            this.gbPermissoes.Name = "gbPermissoes";
            this.gbPermissoes.Size = new System.Drawing.Size(1112, 417);
            this.gbPermissoes.TabIndex = 10;
            this.gbPermissoes.TabStop = false;
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
            this.Controls.Add(this.btPermissoes);
            this.Controls.Add(this.btAdmLogin);
            this.Controls.Add(this.gbAdmLogin);
            this.Controls.Add(this.gbPermissoes);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSecurity";
            this.Text = "Segurança";
            this.Title = "Central de Segurança";
            this.Controls.SetChildIndex(this.gbPermissoes, 0);
            this.Controls.SetChildIndex(this.gbAdmLogin, 0);
            this.Controls.SetChildIndex(this.btAdmLogin, 0);
            this.Controls.SetChildIndex(this.btPermissoes, 0);
            this.gbAdmLogin.ResumeLayout(false);
            this.gbAdmLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdGrupos)).EndInit();
            this.gbPermissoes.ResumeLayout(false);
            this.gbPermissoes.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Grupo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn groupCol_Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Permissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCol_Login;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.LinkLabel btVerTodosUsuarios;
    }
}
