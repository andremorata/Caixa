using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caixa.Controls
{
    public partial class CaixaButton : Button
    {
        public CaixaButton()
        {
            InitializeComponent();
        }

        public CaixaButton(IContainer container)
        {            
            InitializeComponent();
            
            container.Add(this);
            
            this.Enter += new EventHandler(CaixaButton_GotFocus);
            this.Leave += new EventHandler(CaixaButton_LostFocus);
        }

        private void CaixaButton_GotFocus(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(99, 99, 99);
        }
        private void CaixaButton_LostFocus(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(33,33,33);
        }
    }
}
