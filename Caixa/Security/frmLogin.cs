using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Caixa.Classes;
using Caixa.DB;

namespace Caixa
{
    public partial class frmLogin : Caixa.frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
            tmrTips.Start();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            base.btFechar_Click(sender, e);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            tmrTips.Stop();
            if (this.txtUsername.Text.Trim().Equals(string.Empty) || this.txtPassword.Text.Trim().Equals(string.Empty))
                this.message.Show("Faltam informações!", "Os campos USUÁRIO e SENHA devem estar devidamente preenchidos.", ctlBannerMessage.TipoMensagem.Alerta);
            else
            {
                Login loggedUser;
                List<Features> permissoes;
                bool success = UserLogin.Authenticate(txtUsername.Text.Trim(), txtPassword.Text, out loggedUser, out permissoes);

                if (success)
                {
                    Sistema.LoggedUser = loggedUser; Sistema.Permissoes = permissoes;
                    MessageBox.Show("Sucesso!", "Bem-vindo, " + txtUsername.Text.Trim() + "! \r\n\r\nClique Ok para continuar.");
                    frmMenu main = new frmMenu();
                    this.Hide(); txtUsername.Text = ""; txtPassword.Text = ""; txtUsername.Focus();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Falhou!", "Sua tentativa de login não foi bem-sucedida. \r\n\r\nPor favor, verifique seu nome de usuário e senha e tente novamente.", 
                        MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
                }
            }

        }

        private void tmrTips_Tick(object sender, EventArgs e)
        {
            this.message.Show("Informação", "Preencha nos campos abaixo o seu nome de usuário e senha para ingressar no sistema.", ctlBannerMessage.TipoMensagem.Dica);
            tmrTips.Stop();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl((Control)sender, true, true, false, true);
        }
        
    }
}
