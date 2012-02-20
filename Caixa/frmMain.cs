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
    public partial class frmMain : frmBase
    {

        CaixaDBEntities entities = new CaixaDBEntities();

        public frmMain()
        {
            InitializeComponent();
            //need to force
            gdData.ColumnHeadersDefaultCellStyle.Font = btIncluir.Font;

            FillDatas();
            GetData();
        }

        private void FillDatas()
        {
            List<DateTime> datas = (from i in entities.Movimentos
                                    orderby i.Data descending                                    
                                    select  i.Data).Distinct().ToList<DateTime>();

            lstData.ValueMember = "Data";
            lstData.DisplayMember = "Data";
            lstData.DataSource = datas;

        }

        private void GetData(DateTime Inicio, DateTime Fim)
        {
            var movimentos = (from i in entities.Movimentos
                                where i.Data >= Inicio && i.Data <= Fim
                                select new
                                {
                                    ID = i.Id,
                                    Descricao = i.Descricao,
                                    Data = i.Data,
                                    Valor = i.Valor,
                                    Tipo = i.Tipo.Descricao
                                });
            gdData.DataSource = movimentos;
        }

        private void GetData(DateTime Data)
        {
            DateTime datafim = Data.AddDays(1);

            var movimentos = (from i in entities.Movimentos
                                where i.Data >= Data && i.Data <= datafim
                                select new
                                {
                                    ID = i.Id,
                                    Descricao = i.Descricao,
                                    Data = i.Data,
                                    Valor = i.Valor,
                                    Tipo = i.Tipo.Descricao
                                });

            gdData.DataSource = movimentos;            
        } 

        private void GetData()
        {
            DateTime datafim = DateTime.Today.AddDays(1);

            var movimentos = (from i in entities.Movimentos
                                where i.Data >= DateTime.Today && i.Data <= datafim
                                select new
                                {
                                    ID = i.Id,
                                    Descricao = i.Descricao,
                                    Data = i.Data,
                                    Valor = i.Valor,
                                    Tipo = i.Tipo.Descricao
                                });
            
            gdData.DataSource = movimentos;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FillDatas();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    e.SuppressKeyPress = true;
                    if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                        btFechar_Click(sender, e);
                    break;
                case Keys.F1:
                    btIncluir.PerformClick();
                    break;
                default:
                    break;
            }
        }

        
    }
}
