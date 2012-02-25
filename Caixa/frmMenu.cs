using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Caixa.DB;
using Caixa.Classes;
using System.Linq;

namespace Caixa
{
    public partial class frmMenu : Caixa.frmBase
    {
        public frmMenu()
        {
            InitializeComponent();

            Caixa.DB.Features feat = Sistema.Permissoes.Find(i => i.Descricao == "Caixa_Admin");
            if (feat == null)
                btAdminCaixa.Enabled = false;

            lbWelcome.Text = string.Format(lbWelcome.Text, Sistema.LoggedUser.Username);

            BindLembretes();
        }

        private void BindLembretes()
        {
            var lembretes = DBInstance.DB.Lembretes.ToArray();
            lstLembretes.DataSource = lembretes;
            lstLembretes.DisplayMember = "Texto";
            lstLembretes.ValueMember = "Id";
            btLembretes.Text = "Lembretes (" + lstLembretes.Items.Count + ")";
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

        private void txtAddLembrete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAddLembrete.Text.Trim() != "")
                {
                    Lembretes novo = new Lembretes();
                    novo.Id = Guid.NewGuid();
                    novo.Texto = txtAddLembrete.Text.Trim();
                    DBInstance.DB.Lembretes.AddObject(novo);
                    DBInstance.DB.SaveChanges();
                    BindLembretes();

                    txtAddLembrete.Text = "";
                }
                else
                {
                    MessageBox.Show("Atenção!", "Você não pode inserir um lembrete sem antes informar um texto.", 
                        MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
                    txtAddLembrete.Focus();
                }
            }
        }

        private void lstLembretes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Lembretes item = DBInstance.DB.Lembretes.FirstOrDefault(i => i.Id == (Guid)lstLembretes.SelectedValue);
            DBInstance.DB.Lembretes.DeleteObject(item);
            DBInstance.DB.SaveChanges();
            BindLembretes();            
        }

        private void btLembretes_Click(object sender, EventArgs e)
        {
            pnLembretes.Visible = !pnLembretes.Visible;
        }
    }
}
