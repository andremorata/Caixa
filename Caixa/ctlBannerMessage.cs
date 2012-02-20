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
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public new void Show()
        {
            this.Visible = true;
            this.err.SetIconAlignment(lbTitle, ErrorIconAlignment.MiddleRight);
            this.err.SetError(lbTitle, "ATENÇÃO");
        }

        public new void Show(string title, string message)
        {
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
