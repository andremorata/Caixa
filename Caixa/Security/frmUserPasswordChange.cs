using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Caixa.DB;
using Caixa.Classes;

namespace Caixa.Security
{
    public partial class frmUserPasswordChange : Form
    {
        public Login SelectedUser { get; set; }
        public frmUserPasswordChange(Login user)
        {
            InitializeComponent();
            if (user != null)
            {
                SelectedUser = user;
                txtNovaSenha.Text = user.Password;
            }
            else
            {
                MessageBox.Show("Erro!", "O usuário selecionado é inválido.", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
                btCancelar.PerformClick();
            }
        }
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNovaSenha.Text.Trim()))
            {
                if (SelectedUser != null)
                {
                    SelectedUser.Password = txtNovaSenha.Text;                    
                    DBInstance.DB.Login.ApplyCurrentValues(SelectedUser);
                }
                DBInstance.DB.SaveChanges();
                MessageBox.Show("Sucesso!", "Senha alterada com sucesso!", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Confirmation);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Atenção!", "O campo Nome precisa ser preenchido.", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                txtNovaSenha.Text = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
                ckVerSenha.Checked = true;
            }
            if (e.KeyCode == Keys.Escape)
                btCancelar.PerformClick();            
        }

        private void txtNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, false, true);
            }
        }

        private void ckVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = !ckVerSenha.Checked;
        }

        private void txtNovoGrupoNome_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
