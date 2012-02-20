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
    public partial class frmBase : Form
    {   

        public frmBase()
        {
            InitializeComponent();
            
        }

        public string Title
        {
            get {
                return this.lbTitle.Text;
            }
            set {
                this.lbTitle.Text = value;
            }
        }

        internal void btFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {            
            btMinimizar.Visible = false;
            btRestaurar.Visible = false;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;            
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:                    
                    btFechar_Click(sender, e);
                    break;
            }
        }

        private void frmBase_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btMinimizar.Visible = true;
                btRestaurar.Visible = true;                
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;                
                Application.DoEvents();
                this.WindowState = FormWindowState.Maximized;
            }
        }
        
    }
}
