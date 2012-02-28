using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Caixa.Classes;
using Caixa.DB;
using System.Linq;

namespace Caixa
{
    public partial class frmSecurity : Caixa.frmBase
    {
        public frmSecurity()
        {
            InitializeComponent();
            gbPermissoes.Location = gbAdmLogin.Location;

            ActivateTab(ActiveTab.AdmLogin);

            LoadGrupos();
        }

        private void LoadGrupos()
        {
            List<GruposUsuarios> grupos = DBInstance.DB.GruposUsuarios.OrderBy(i => i.Nome).ToList<GruposUsuarios>();
            gdGrupos.DataSource = grupos;
        }

        private enum ActiveTab { AdmLogin, Permissoes }

        private void ActivateTab(ActiveTab tab)
        {
            switch (tab)
            {
                case ActiveTab.AdmLogin:
                    btAdmLogin.BackColor = Color.FromArgb(99, 99, 99);
                    btPermissoes.BackColor = Color.FromArgb(44, 44, 44);
                    gbPermissoes.Visible = false;
                    gbAdmLogin.Visible = true;
                    break;
                case ActiveTab.Permissoes:
                    btPermissoes.BackColor = Color.FromArgb(99, 99, 99);
                    btAdmLogin.BackColor = Color.FromArgb(44, 44, 44);
                    gbPermissoes.Visible = true;
                    gbAdmLogin.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btAdmLogin_Click(object sender, EventArgs e)
        {
            ActivateTab(ActiveTab.AdmLogin);
        }

        private void btPermissoes_Click(object sender, EventArgs e)
        {
            ActivateTab(ActiveTab.Permissoes);
        }

        private void gdGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GruposUsuarios selected = (GruposUsuarios)gdGrupos.SelectedRows[0].DataBoundItem;
                Security.frmAddEditGroup frm = new Security.frmAddEditGroup(selected);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    LoadGrupos();
                frm.Dispose();
            }
        }

        private void btAddGroup_Click(object sender, EventArgs e)
        {
            Security.frmAddEditGroup frm = new Security.frmAddEditGroup(null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                LoadGrupos();
            frm.Dispose();
        }

        private void btRemoveGroup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Atenção!", "Você está prestes a remover um grupo de usuários e todas as permissões a ele atribuídas.\r\n\r\nDeseja realmente exluir este grupo?",
                                 MessageBox.MessageBoxButtons.OkCancel, MessageBox.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                GruposUsuarios selected = (GruposUsuarios)gdGrupos.SelectedRows[0].DataBoundItem;
                DBInstance.DB.GruposUsuarios.DeleteObject(selected);
                DBInstance.DB.SaveChanges();

                LoadGrupos();
            }
        }

        private void gdGrupos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gdGrupos.SelectedRows.Count > 0)
            {
                LoadUsers();
            }
        }

        private void LoadUsers()
        {
            if (gdGrupos.SelectedRows.Count > 0)
            {
                GruposUsuarios selected = (GruposUsuarios)gdGrupos.SelectedRows[0].DataBoundItem;
                gdUsuarios.DataSource = selected.Logins.OrderBy(i => i.Username).ToList<Login>();
            }
        }

        private void btAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (gdUsuarios.SelectedRows.Count > 0)
            {
                Login selected = (Login)gdUsuarios.SelectedRows[0].DataBoundItem;
                Security.frmUserPasswordChange frm = new Security.frmUserPasswordChange(selected);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    LoadUsers();
                frm.Dispose();
            }
        }

        private void btTornarUsuarioInativo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (gdUsuarios.SelectedRows.Count > 0)
            {
                Login selected = (Login)gdUsuarios.SelectedRows[0].DataBoundItem;
                selected.Ativo = !selected.Ativo;
                DBInstance.DB.Login.ApplyCurrentValues(selected);
                DBInstance.DB.SaveChanges();
                gdUsuarios.InvalidateRow(gdUsuarios.SelectedRows[0].Index);
            }
            else
                MessageBox.Show("Erro!", "Nenhum usuário selecionado!", MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
        }

        private void btNovoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Security.frmAddNewUser frm = new Security.frmAddNewUser();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btVerTodosUsuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Security.frmViewSelectUsers frm = new Security.frmViewSelectUsers();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GruposUsuarios gp = frm.SelectedUser.GruposUsuarios.FirstOrDefault();
                if (gp != null)
                    foreach (DataGridViewRow item in gdGrupos.Rows)
                    {
                        if (((GruposUsuarios)item.DataBoundItem).Id == gp.Id)
                        {
                            item.Selected = true; 
                            gdGrupos.CurrentCell = item.Cells["groupCol_Grupo"]; LoadUsers();
                            foreach (DataGridViewRow user in gdUsuarios.Rows)
                                if (((Login)user.DataBoundItem).Id == frm.SelectedUser.Id)
                                {
                                    user.Selected = true; 
                                    gdUsuarios.CurrentCell = user.Cells["gdUserCol_Usuario"];
                                }
                        }
                    }
                else
                {
                    MessageBox.Show("Erro!", "O usuário selecionado ainda não foi adicionado a nenhum grupo e por isso não pode ser exibido!", 
                        MessageBox.MessageBoxButtons.Ok, MessageBox.MessageBoxIcon.Error);
                }
            }
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            Security.frmViewSelectUsers frm = new Security.frmViewSelectUsers();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GruposUsuarios gp = ((GruposUsuarios)gdGrupos.SelectedRows[0].DataBoundItem);
                GruposUsuarios existGp = frm.SelectedUser.GruposUsuarios.FirstOrDefault(i => i.Id == gp.Id);
                Login user = frm.SelectedUser;
                if (existGp == null)
                {
                    gp.Logins.Add(user);
                    DBInstance.DB.GruposUsuarios.ApplyCurrentValues(gp);   
                    
                    //A linha abaixo precisa forçar a mudança de estado do objeto para que a estrutura seja salva.
                    //Caso o estado do objeto seja Unchanged, os dados não serão salvos.
                    DBInstance.DB.ObjectStateManager.ChangeObjectState(gp, EntityState.Modified);                                 
                    DBInstance.DB.SaveChanges();
                    LoadUsers();
                }
                else
                    MessageBox.Show("Este usuário já faz parte do grupo");

            }
        }

        private void btRemoveUser_Click(object sender, EventArgs e)
        {
            if (gdGrupos.SelectedRows.Count > 0 && gdUsuarios.Rows.Count > 0)
            {
                Login user = (Login)gdUsuarios.SelectedRows[0].DataBoundItem;
                GruposUsuarios grupo = (GruposUsuarios)gdGrupos.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show("Atenção!", "Você tem certeza que deseja remover o usuário selecionado do grupo? \r\n\r\n" +
                    "Esta ação fará com que este usuário perca todas as permissões associadas ao grupo.",
                     MessageBox.MessageBoxButtons.YesNo, MessageBox.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    grupo.Logins.Remove(user);
                    DBInstance.DB.GruposUsuarios.ApplyCurrentValues(grupo);
                    DBInstance.DB.ObjectStateManager.ChangeObjectState(grupo, EntityState.Modified);
                    DBInstance.DB.SaveChanges();
                    LoadUsers();
                }
            }
        }

    }
}
