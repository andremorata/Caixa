using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Caixa.Classes;

namespace Caixa
{
    public partial class frmMain : frmBase
    {

        CaixaDBEntities entities = Movimentos.DB;        

        public frmMain()
        {
            InitializeComponent();

            gdData.ColumnHeadersDefaultCellStyle.Font = btIncluir.Font;  //need to force
            FillDatas();

        }

        private void FillDatas()
        {
            List<DateTime> datas = (from i in entities.Movimentos
                                    orderby i.Data descending
                                    select i.Data).Distinct().ToList<DateTime>();

            lstData.ValueMember = "Data";
            lstData.DisplayMember = "Data";
            lstData.DataSource = datas;

            if (datas.Count > 0)
                lstData.SelectedIndex = 0;
            else
                GetData(DateTime.Today);
        }

        private void GetData(DateTime Data)
        {
            double sum = 0;
            IQueryable movs = Movimentos.GetData(Data, Data.AddDays(1).AddSeconds(-1), out sum);
            lbTotal.Text = sum.ToString("c", new CultureInfo("pt-BR"));
            gdData.DataSource = movs;

            if (gdData.Rows.Count == 0)
                pnNoData.Visible = true;
            else
                pnNoData.Visible = false;
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            frmIncluir incluir = new frmIncluir();
            if (incluir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillDatas(); lstData.SelectedIndex = 0;
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {   
            GetData((DateTime)lstData.SelectedValue);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btIncluir.PerformClick();
                    break;
                case Keys.F2:
                    btAlterar.PerformClick();
                    break;
                case Keys.F5:
                    btInclusaoRapida.PerformClick();
                    break;
                case Keys.Delete:
                    btExcluir.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Movimento mov = null;
            if (gdData.SelectedRows.Count > 0)
            {
                Guid id = (Guid)gdData.SelectedRows[0].Cells["Id"].Value;
                mov = (from i in entities.Movimentos
                       where i.Id == id
                       select i).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("Atenção", "Nenhum item selecionado.", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Warning);
                return;
            }
            frmAlterar frm = new frmAlterar(mov);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillDatas(); lstData.SelectedIndex = 0;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Movimento mov = null;
                if (gdData.SelectedRows.Count > 0)
                {
                    Guid id = (Guid)gdData.SelectedRows[0].Cells["Id"].Value;
                    mov = (from i in entities.Movimentos
                           where i.Id == id
                           select i).FirstOrDefault();
                }
                else
                {
                    MessageBox.Show("Atenção", "Nenhum item selecionado.", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Atenção", "Deseja remover o item selecionado? \r\n \r\n Esta ação não poderá ser desfeita!",
                    MessageBox.MessageBoxButtons.YesNo, MessageBox.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        entities.Movimentos.DeleteObject(mov);
                        entities.SaveChanges();
                        FillDatas();
                        MessageBox.Show("Sucesso!", "Entrada removida com sucesso!", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Confirmation);                        
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!", "Ocorreu um erro durante o processamento. \r\n Detalhes: \r\n     " + ex.Message, MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
            }
        }

        private void pnNoData_Click(object sender, EventArgs e)
        {
            btIncluir.PerformClick();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void gdData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in gdData.Rows)
            {
                if (item.Cells["Tipo"].Value.ToString() == "Entrada")
                {
                    item.Cells["Tipo"].Style.BackColor = Color.Green;
                    item.Cells["Tipo"].Style.SelectionBackColor = Color.Green;
                }
                else
                {
                    item.Cells["Tipo"].Style.BackColor = Color.DarkRed;
                    item.Cells["Tipo"].Style.SelectionBackColor = Color.DarkRed;
                }
            }
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade ainda em desenvolvimento.");
        }

        private void btInclusaoRapida_Click(object sender, EventArgs e)
        {
            frmIncluir incluir = new frmIncluir(true);
            if (incluir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillDatas(); lstData.SelectedIndex = 0;
            }
        }


    }
}
