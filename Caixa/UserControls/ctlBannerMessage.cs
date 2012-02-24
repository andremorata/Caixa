using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caixa
{
    public partial class ctlBannerMessage : UserControl
    {
        public ctlBannerMessage()
        {
            InitializeComponent();
            this.tipoDaMensagem = TipoMensagem.Alerta;
        }

        public enum TipoMensagem
        {
            Alerta = 1,
            Dica
        }

        TipoMensagem tipoDaMensagem;
        [DefaultValue(typeof(TipoMensagem), "Alerta")]
        public TipoMensagem TipoDaMensagem 
        {
            get
            {
                return this.tipoDaMensagem;
            }
            set
            {
                this.tipoDaMensagem = value;
                if (value == TipoMensagem.Alerta)
                {
                    lbTitle.ForeColor = Color.DarkRed;
                    lbMessage.ForeColor = Color.DarkRed;
                    this.BackColor = Color.FromArgb(249, 253, 198);
                    lbTitle.Location = new Point(-1, -2);
                    lbMessage.Location = new Point(13, 28);                    
                }
                else
                {
                    lbTitle.ForeColor = Color.DodgerBlue;
                    lbMessage.ForeColor = Color.DodgerBlue;
                    this.BackColor = Color.White;
                    lbTitle.Location = new Point(-1, -2);
                    lbMessage.Location = new Point(13, 22);                    
                }
            } 
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public new void Show()
        {
            this.Visible = true;
            if (TipoDaMensagem == TipoMensagem.Alerta)
            {
                this.err.SetIconAlignment(lbTitle, ErrorIconAlignment.MiddleRight);
                this.err.SetError(lbTitle, "ATENÇÃO");
            }
        }

        public void Show(string title, string message, TipoMensagem tipo)
        {
            this.TipoDaMensagem = tipo;
            this.lbTitle.Text = title;
            this.lbMessage.Text = message;
            this.Show();            
        }

        public new void Hide()
        {
            this.Visible = false;
            this.err.Clear();
        }

        public string Title 
        {
            get
            { return this.lbTitle.Text; }
            set
            { this.lbTitle.Text = value; }
        }

        public string Message
        {
            get
            { return this.lbMessage.Text; }
            set
            { this.lbMessage.Text = value; }
        }
    }
}
