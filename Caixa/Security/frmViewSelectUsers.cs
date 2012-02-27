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
    public partial class frmViewSelectUsers : Form
    {

        public Login SelectedUser { get; set; }

        public frmViewSelectUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {               
            gdUsuarios.DataSource = DBInstance.DB.Login.OrderBy(i => i.Username).ToList<Login>();            
        }
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.SelectedUser = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void frmAddEditGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btCancelar.PerformClick();            
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (gdUsuarios.SelectedRows.Count > 0)
            {
                SelectedUser = (Login)gdUsuarios.SelectedRows[0].DataBoundItem;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro!", "Nenhum usuário selecionado!", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
            }
        }

        
    }
}
