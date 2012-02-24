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
    public partial class frmInclusaoRapida : Caixa.frmBase
    {
        public frmInclusaoRapida()
        {
            InitializeComponent();
            message.Hide();
            txtValor.Focus();
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
                    novo.Data = DateTime.Today;
                    novo.Descricao = "Venda - " + DateTime.Now.ToShortTimeString(); ;
                    novo.Valor = Convert.ToDouble(txtValor.Value);                    
                    novo.TipoMovimento = DBInstance.DB.TipoMovimento.FirstOrDefault(i => i.Descricao == "Entrada").Id;
                    novo.Observacao = txtObservacao.Text;

                    CaixaDBEntities db = new CaixaDBEntities();
                    db.Movimentos.AddObject(novo);
                    db.SaveChanges();

                    if (MessageBox.Show("Atenção", "Deseja incluir outro movimento?", MessageBox.MessageBoxButtons.YesNo,
                            MessageBox.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                    }
                    else
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
            if (txtValor.Value == 0)
            {
                err.SetError(txtValor, "O campo Valor precisa ser maior que 0 (zero)."); skip = false;
            }
            
            if (!skip)
                this.message.Show("Atenção", "Alguns campos são obrigatórios. Veja as sinalizações à frente dos campos detectados com problemas.", ctlBannerMessage.TipoMensagem.Alerta);

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
