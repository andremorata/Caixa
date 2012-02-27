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
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();      
        }
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                Login novo = new Login();
                novo.Id = Guid.NewGuid();
                novo.Username = txtUsuario.Text.Trim();
                novo.Password = txtSenha.Text.Trim();
                novo.Ativo = ckGrupo.Checked;
                DBInstance.DB.Login.AddObject(novo);             
                DBInstance.DB.SaveChanges();
                MessageBox.Show("Sucesso!", "Novo usuário adicionado com sucesso!", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Confirmation);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Atenção!", "O campo Nome precisa ser preenchido.", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btCancelar.PerformClick();            
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, false, true);
            }
        }
    }
}
