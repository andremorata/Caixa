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
    public partial class frmAddEditGroup : Form
    {
        public GruposUsuarios SelectedGroup { get; set; }
        public frmAddEditGroup(GruposUsuarios grupo)
        {
            InitializeComponent();
            if (grupo != null)
            {
                SelectedGroup = grupo;
                txtNovoGrupoNome.Text = grupo.Nome;
                ckNovoGrupoAtivo.Checked = grupo.Ativo;
                lbTitle.Text = "Alterar Grupo de Usuários";
            }
        }
        
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNovoGrupoNome.Text.Trim()))
            {
                if (SelectedGroup == null)
                {
                    GruposUsuarios novo = new GruposUsuarios();
                    novo.Id = Guid.NewGuid();
                    novo.Nome = txtNovoGrupoNome.Text.Trim();
                    novo.Ativo = ckNovoGrupoAtivo.Checked;
                    DBInstance.DB.AddToGruposUsuarios(novo);
                }
                else
                {
                    SelectedGroup.Nome = txtNovoGrupoNome.Text.Trim();
                    SelectedGroup.Ativo = ckNovoGrupoAtivo.Checked;
                    DBInstance.DB.GruposUsuarios.ApplyCurrentValues(SelectedGroup);
                }
                DBInstance.DB.SaveChanges();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Atenção!", "O campo Nome precisa ser preenchido.", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
        }

        private void frmAddEditGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btCancelar.PerformClick();            
        }

        private void txtNovoGrupoNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, false, true);
            }
        }
    }
}
