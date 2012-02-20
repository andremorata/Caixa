using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Caixa
{
    public partial class frmIncluir : Caixa.frmBase
    {
       
        CaixaDBEntities entities = new CaixaDBEntities();
        public frmIncluir()
        {
            InitializeComponent();
            message.Hide();
            BindTipos();
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
                
        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (ValidadeFields())
            {
                message.Hide();

                Movimentos novo = new Movimentos();
                novo.Id = Guid.NewGuid();
                novo.Data = txtData.Value.Date;
                novo.Descricao = txtDescricao.Text;
                novo.Valor = Convert.ToDouble(txtValor.Value);
                novo.TipoMovimento = ((Guid)cboTipo.SelectedValue);
                novo.Observacao = txtObservacao.Text;

                CaixaDBEntities db = new CaixaDBEntities();
                db.Movimentos.AddObject(novo);
                //db.AcceptAllChanges();
                db.SaveChanges();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
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
                this.message.Show("Atenção", "Alguns campos são obrigatórios. Veja as sinalizações abaixo.");            
            
            return skip;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {            
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        
    }
}
