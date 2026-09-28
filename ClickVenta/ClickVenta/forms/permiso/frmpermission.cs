using BusinessEntities.Dtos.permision;
using BusinessEntities.Entities;
using ClickVenta.forms.Menus;
using ClickVenta.forms.Menus.menu;
using ClickVenta.forms.user;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickVenta.forms
{
    public partial class frmpermission : Form
    {
        private IEnumerable<PermissionMenuDto> permissionsTable;
        private string currentUserId = "-1";
        private TreeView tvMenus;
        private ListBox lstUsers;
        private Button btnAddUser, btnAddMenu, btnAddSubmenu;
        private Label lblStatus;

        public frmpermission()
        {
            InitializeComponent();
            this.Initialize();
        }
        private void Initialize()
        {
            this.Text = "Gestor de Permisos";
            this.Size = new Size(600, 520);

            // ListBox de usuarios
            lstUsers = new ListBox { Location = new Point(12, 50), Size = new Size(200, 400), DisplayMember = "Username", ValueMember = "UserId" };
            lstUsers.SelectedValueChanged += LstUsers_SelectedValueChanged;

            // TreeView de menús/submenús
            tvMenus = new TreeView { Location = new Point(230, 50), Size = new Size(350, 400), CheckBoxes = true };
            tvMenus.AfterCheck += TvMenus_AfterCheck;

            // Botones
            btnAddUser = new Button { Text = "Seleccionar Usuario", Location = new Point(12, 450), Size = new Size(200, 30) };
            btnAddUser.Click += BtnAddUser_Click;

            btnAddMenu = new Button { Text = "Agregar Menú", Location = new Point(230, 450), Size = new Size(170, 30) };
            btnAddMenu.Click += BtnAddMenu_Click;

            btnAddSubmenu = new Button { Text = "Agregar Submenú", Location = new Point(410, 450), Size = new Size(170, 30) };
            btnAddSubmenu.Click += BtnAddSubmenu_Click;

            lblStatus = new Label { Location = new Point(12, 490), Size = new Size(760, 30), Text = "Seleccione un usuario para ver/editar permisos." };

            this.Controls.Add(lstUsers);
            this.Controls.Add(tvMenus);
            this.Controls.Add(btnAddUser);
            //this.Controls.Add(btnAddMenu);
            //this.Controls.Add(btnAddSubmenu);
            //this.Controls.Add(lblStatus);
        }
        private void LstUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedValue == null) return;

            UserBE selectedUser = lstUsers.SelectedItem as UserBE;
            currentUserId = selectedUser.Id;
            LoadPermissionsForUser(currentUserId);
        }

        private void LoadPermissionsForUser(string userId)
        {
            permissionsTable = Program.ServiceProvider.GetRequiredService<IPermissionService>().GetUserPermissions(userId)?.Result;
            BuildTreeWithPermissions();
        }

        private void BuildTreeWithPermissions()
        {
            tvMenus.Nodes.Clear();
            // Agrupar por menú
            var menuGroups = permissionsTable
                .GroupBy(row => new { MenuId = row.Id, MenuName = row.Name });

            foreach (var menuGroup in menuGroups)
            {
                TreeNode menuNode = new TreeNode(menuGroup.Key.MenuName) { Tag = menuGroup.Key.MenuId };
                foreach (var submenuRow in menuGroup)
                {
                    string subMenuId = submenuRow.SubMenuId;
                    string subMenuName = submenuRow.SubMenuName;
                    int isAssigned = submenuRow.IsAssigned;
                    TreeNode subNode = new TreeNode(subMenuName) { Tag = subMenuId };
                    subNode.Checked = isAssigned == 1;
                    menuNode.Nodes.Add(subNode);
                }
                tvMenus.Nodes.Add(menuNode);
            }
            tvMenus.ExpandAll();
        }

        private async void TvMenus_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Solo procesar nodos hoja (submenús)
            if (e.Node.Nodes.Count > 0) return;
            if (currentUserId == "-1")
            {
                MessageBox.Show("Seleccione un usuario primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Node.Checked = !e.Node.Checked; // revertir
                return;
            }

            string subMenuId = (string)e.Node.Tag;
            bool isChecked = e.Node.Checked;

            try
            {
                PermissionMenuCreateDto be = new PermissionMenuCreateDto
                {
                    UserId = currentUserId,
                    //MenuId = GetParentMenuId(e.Node),
                    SubMenuId = subMenuId
                };
                if (isChecked)
                    await Task.Run(() => Program.ServiceProvider.GetRequiredService<IPermissionService>().Add(be));
                else
                    await Task.Run(() => Program.ServiceProvider.GetRequiredService<IPermissionService>().Delete(currentUserId, subMenuId));

                lblStatus.Text = $"Permiso {(isChecked ? "asignado" : "desasignado")} correctamente.";
                // Recargar para mantener consistencia (por si hubiera otros cambios externos)
                //LoadPermissionsForUser(currentUserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Node.Checked = !isChecked; // revertir
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            using var dialog = new frmselectuser();
            dialog.ShowDialog();
            if (dialog.IsSelected)
            {
                LoadUsers(dialog.UserId);
                lblStatus.Text = "Usuario creado. Selecciónelo para asignar permisos.";
            }
        }

        private void BtnAddMenu_Click(object sender, EventArgs e)
        {
            using var dialog = new AddMenuForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Recargar estructura de permisos para el usuario actual (si hay uno seleccionado)
                if (currentUserId != "-1")
                    LoadPermissionsForUser(currentUserId);
                lblStatus.Text = "Menú creado. Los nuevos submenús aparecerán en el árbol.";
            }
        }

        private void BtnAddSubmenu_Click(object sender, EventArgs e)
        {
            using var dialog = new AddSubmenuForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (currentUserId != "-1")
                    LoadPermissionsForUser(currentUserId);
                lblStatus.Text = "Submenú creado. Ahora puede asignar permisos.";
            }
        }
        private void LoadUsers(string userId)
        {
            var result = Program.ServiceProvider.GetRequiredService<IUserService>().GetById(userId)?.Result;
            lstUsers.DataSource = new List<UserBE> { result };
        }
    }
}
