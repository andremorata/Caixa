using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Caixa.DB;
using Caixa.Classes;

namespace Caixa
{
    public partial class frmAlterar : Caixa.frmBase
    {
       
        CaixaDBEntities entities = DBInstance.DB;
        
        public Movimento Movimento { get; set; }

        public frmAlterar(Movimento item)
        {
            InitializeComponent();
            message.Hide();
            BindTipos();
            this.Movimento = item;

            txtDescricao.Text = item.Descricao;
            txtData.Value = item.Data;
            txtValor.Value = Convert.ToDecimal(item.Valor);
            txtObservacao.Text = item.Observacao;
            cboTipo.SelectedValue = item.TipoMovimento;

        }

        private void BindTipos()
        {
            List<TipoMovimento> tipos = (from i in entities.TipoMovimento
                                         select i).ToList<TipoMovimento>();

            TipoMovimento selecione = new TipoMovimento();
            selecione.Descricao = "Selecione";
            selecione.Id = new Guid();
            tipos.Insert(0, selecione);

            cboTipo.DisplayMember = "Descricao";
            cboTipo.ValueMember = "Id";

            cboTipo.DataSource = tipos;

        }
                
        private bool ValidadeFields()
        {
            bool skip = true;
            if (string.IsNullOrEmpty(txtDescricao.Text.Trim())) {
                err.SetError(txtDescricao, "O campo Descrição precisa ser preenchido."); skip = false; }
            if (txtValor.Value == 0) {
                err.SetError(txtValor, "O campo Valor precisa ser maior que 0 (zero)."); skip = false; }            
            if (cboTipo.SelectedIndex <= 0) {
                err.SetError(cboTipo, "O campo Tipo precisa ser preenchido."); skip = false; }

            if (!skip)
                this.message.Show("Atenção", "Alguns campos são obrigatórios. Veja as sinalizações abaixo.", ctlBannerMessage.TipoMensagem.Alerta);            
            
            return skip;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {            
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (ValidadeFields())
            {
                message.Hide();
                Movimento mov = entities.Movimentos.FirstOrDefault(i => i.Id.Equals(Movimento.Id));
                mov.Data = txtData.Value.Date;
                mov.Descricao = txtDescricao.Text;
                mov.Valor = Convert.ToDouble(txtValor.Value);
                mov.TipoMovimento = ((Guid)cboTipo.SelectedValue);
                mov.Observacao = txtObservacao.Text;

                entities.SaveChanges();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
                ((TextBox)sender).SelectAll();

            if (sender is NumericUpDown)
                ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Value.ToString("f").Length);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl((Control)sender, true, true, false, true);
        }
        
    }
}
