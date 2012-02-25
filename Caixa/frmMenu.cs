using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Caixa.DB;
using Caixa.Classes;

namespace Caixa
{
    public partial class frmMenu : Caixa.frmBase
    {
        public frmMenu()
        {
            InitializeComponent();

            Caixa.DB.Features feat  = Sistema.Permissoes.Find(i => i.Descricao == "Caixa_Admin");
            if (feat == null)
                btAdminCaixa.Enabled = false;

            lbWelcome.Text = string.Format(lbWelcome.Text, Sistema.LoggedUser.Username);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = DateTime.Now.ToShortTimeString();
            lbSegundos.Text = DateTime.Now.Second.ToString().PadLeft(2, '0');
        }

        private void btAdminCaixa_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();            
            frm.ShowDialog();
        }

        private void btInclusaoRapida_Click(object sender, EventArgs e)
        {
            frmInclusaoRapida frm = new frmInclusaoRapida();
            frm.ShowDialog();
        }

        private void btSeguranca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade ainda não disponível.");
        }

        bool ConfirmaSair = false;
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmaSair)
            {
                if (MessageBox.Show("Atenção", "Deseja realmente sair? \r\n\r\n Você será levado à tela de Login.", MessageBox.MessageBoxButtons.YesNo,
                                MessageBox.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    ConfirmaSair = true;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
