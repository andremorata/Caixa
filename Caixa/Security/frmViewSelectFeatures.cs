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
    public partial class frmViewSelectFeatures : Form
    {

        public Features SelectedFeature { get; set; }

        public frmViewSelectFeatures()
        {
            InitializeComponent();
            LoadFeatures();
        }

        private void LoadFeatures()
        {
            gdFeatures.DataSource = DBInstance.DB.Features.OrderBy(i => i.Descricao).ToList<Features>();
        }
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.SelectedFeature = null;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btCancelar.PerformClick();            
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (gdFeatures.SelectedRows.Count > 0)
            {
                SelectedFeature = (Features)gdFeatures.SelectedRows[0].DataBoundItem;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro!", "Nenhuma Funcionalidade selecionada!", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
            }
        }

        
    }
}
