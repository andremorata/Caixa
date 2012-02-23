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
    public partial class frmIncluir : Caixa.frmBase
    {

        CaixaDBEntities entities = new CaixaDBEntities();
        public frmIncluir()
        {
            InitializeComponent();
            message.Hide();
            BindTipos();
        }

        public frmIncluir(bool InclusaoRapida)
        {
            InitializeComponent();

            message.Hide();
            BindTipos();

            if (InclusaoRapida)
            {
                txtDescricao.Text = "Venda - " + DateTime.Now.ToShortTimeString();
                txtData.Value = DateTime.Today;
                txtObservacao.Text = "";
                foreach (TipoMovimento item in cboTipo.Items)
                    if (item.Descricao == "Entrada")
                        cboTipo.SelectedValue = item.Id;
                
                this.message.Show("DICA:", "Este modo de inclusão se aplica à vendas rápidas e por isso alguns campos foram desativados.", ctlBannerMessage.TipoMensagem.Dica);

                txtDescricao.Enabled = false;
                txtData.Enabled = false;
                txtObservacao.Enabled = false;
                cboTipo.Enabled = false;

                Application.DoEvents();
                txtValor.Focus();
            }
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
            try
            {
                if (ValidadeFields())
                {
                    message.Hide();

                    Movimento novo = new Movimento();
                    novo.Id = Guid.NewGuid();
                    novo.Data = txtData.Value.Date;
                    novo.Descricao = txtDescricao.Text;
                    novo.Valor = Convert.ToDouble(txtValor.Value);
                    novo.TipoMovimento = ((Guid)cboTipo.SelectedValue);
                    novo.Observacao = txtObservacao.Text;

                    CaixaDBEntities db = new CaixaDBEntities();
                    db.Movimentos.AddObject(novo);
                    db.SaveChanges();

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", "Ocorreu um erro durante o processamento. \r\nDetalhe: " + ex.Message, MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
            }
        }

        private bool ValidadeFields()
        {
            bool skip = true;
            if (string.IsNullOrEmpty(txtDescricao.Text.Trim()))
            {
                err.SetError(txtDescricao, "O campo Descrição precisa ser preenchido."); skip = false;
            }
            if (txtValor.Value == 0)
            {
                err.SetError(txtValor, "O campo Valor precisa ser maior que 0 (zero)."); skip = false;
            }
            if (cboTipo.SelectedIndex <= 0)
            {
                err.SetError(cboTipo, "O campo Tipo precisa ser preenchido."); skip = false;
            }

            if (!skip)
                this.message.Show("Atenção", "Alguns campos são obrigatórios. Veja as sinalizações abaixo.", ctlBannerMessage.TipoMensagem.Alerta);

            return skip;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
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
