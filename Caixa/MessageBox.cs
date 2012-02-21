using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caixa
{
    public partial class MessageBox : Form
    {        

        public MessageBox(string title, string message, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();

            this.lbTitle.Text = title;
            this.lbContent.Text = message;
            switch (icon)
            {
                case MessageBoxIcon.Warning:
                    lnIcon.BorderColor = Color.Yellow;
                    break;
                case MessageBoxIcon.Information:
                    lnIcon.BorderColor = Color.DodgerBlue;
                    break;
                case MessageBoxIcon.Error:
                    lnIcon.BorderColor = Color.DarkRed;
                    break;
                case MessageBoxIcon.Confirmation:
                    lnIcon.BorderColor = Color.Green;
                    break;
                default:
                    break;
            }
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                    
                    btOk.Visible = true;
                    btCancelar.Visible = false;
                    btNao.Visible = false;
                    btSim.Visible = false;

                    btOk.Location = new Point((((this.Width / 2) - btOk.Width / 2) + 10), btOk.Location.Y);

                    break;
                case MessageBoxButtons.OkCancel:
                    btOk.Visible = true;
                    btCancelar.Visible = true;
                    btNao.Visible = false;
                    btSim.Visible = false;

                    btOk.Location = new Point((((this.Width / 2) - btOk.Width / 2) - 10) - (btOk.Width / 2 - 10), btOk.Location.Y);
                    btCancelar.Location = new Point((((this.Width / 2) - btOk.Width / 2) + 10) + btOk.Width / 2 + 10, btOk.Location.Y);
                                        
                    break;
                case MessageBoxButtons.YesNo:
                    btOk.Visible = false;
                    btCancelar.Visible = false;
                    btNao.Visible = true;
                    btSim.Visible = true;

                    btSim.Location = new Point((((this.Width / 2) - btOk.Width / 2) - 10) - (btOk.Width / 2 - 10), btOk.Location.Y);
                    btNao.Location = new Point((((this.Width / 2) - btOk.Width / 2) + 10) + btOk.Width / 2 + 10, btOk.Location.Y);
                                        
                    break;
                case MessageBoxButtons.YesNoCancel:
                    btOk.Visible = false;
                    btCancelar.Visible = true;
                    btNao.Visible = true;
                    btSim.Visible = true;

                    btSim.Location = new Point((((this.Width / 2) - (btOk.Width) / 2) - 10) - (btOk.Width - 10), btOk.Location.Y);
                    btNao.Location = new Point((((this.Width / 2) - btOk.Width / 2) + 10), btOk.Location.Y);
                    btCancelar.Location = new Point((((this.Width / 2) - btOk.Width / 2) + 10) + btOk.Width + 10, btOk.Location.Y);
                    
                    break;
                default:
                    break;
            }

            
        }
        
        public static DialogResult Show(string title, string message, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox mbox = new MessageBox(title, message, buttons, icon);
            return mbox.ShowDialog();
        }

        public static DialogResult Show(string title, string message, MessageBoxButtons buttons)
        {
            MessageBox mbox = new MessageBox(title, message, buttons, MessageBoxIcon.Information);
            return mbox.ShowDialog();
        }

        public static DialogResult Show(string title, string message)
        {
            MessageBox mbox = new MessageBox(title, message, MessageBoxButtons.Ok, MessageBoxIcon.Information);
            return mbox.ShowDialog();
        }

        public static DialogResult Show(string message)
        {
            MessageBox mbox = new MessageBox("Atenção", message, MessageBoxButtons.Ok, MessageBoxIcon.Information);
            return mbox.ShowDialog();
        }

        public enum MessageBoxButtons
        { 
            Ok = 1,
            OkCancel = 2,
            YesNo = 3,
            YesNoCancel = 4
        }

        public enum MessageBoxIcon
        {
            Warning = 1,
            Information = 2,
            Error = 3,
            Confirmation = 4
        }

        private void btSim_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void btNao_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
