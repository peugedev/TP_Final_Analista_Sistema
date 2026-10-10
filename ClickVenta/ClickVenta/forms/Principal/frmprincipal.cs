using BusinessEntities.Dtos.permision;
using ClickVenta.Config;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Reflection;

namespace ClickVenta.forms.Principal
{
    public partial class frmprincipal : Form
    {
        private readonly string _usuarioId;

        #region Variable autorizacion
        private IEnumerable<PermissionMenuDto> permissionsTable;

        private MenuStrip menuStrip1;
        #endregion
        public frmprincipal(string usuarioId)
        {
            InitializeComponent();
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            //this.Text = "Sistema - Click venta";
            _usuarioId = usuarioId;


            WindowState = FormWindowState.Maximized;

            CrearEstructura();
            AgregarBotonesVentana();
            ConfigurarCabeceraPersonalizada();
        }

        #region MenuStrip   
        private void CrearEstructura()
        {
            // Panel superior que contiene CABECERA + MENÚ (en ese orden)
            var pnlTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60 + 24,   // cabecera + altura menú
                BackColor = Color.FromArgb(0, 58, 107)
            };

            // Cabecera (arriba del todo)
            pnlCabecera = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.FromArgb(30, 58, 107)
            };

            lblTitulo = new Label
            {
                Text = "Sistema - Click venta",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,   // 👈 CENTRADO
                Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point), // 👈 GRANDE + NEGRITA
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };

            pnlCabecera.Controls.Add(lblTitulo);
            // Menú (debajo de la cabecera)
            menuStrip1 = new MenuStrip { Dock = DockStyle.Top };

            // ⚠️ Dentro del panel pnlTop: agregar menú PRIMERO y cabecera DESPUÉS
            pnlTop.Controls.Add(menuStrip1);
            pnlTop.Controls.Add(pnlCabecera);

            Controls.Add(pnlTop);
        }
        #endregion

        #region Panel personalizado
        private Panel pnlCabecera;
        private Label lblTitulo;

        private void ConfigurarCabeceraPersonalizada()
        {
            // Ocultar la barra de título nativa y los bordes
            FormBorderStyle = FormBorderStyle.None;

            // Mantener el formulario maximizado pero con espacio para nuestra barra
            WindowState = FormWindowState.Maximized;

            // Opcional: si quieres permitir arrastrar y maximizar, ver punto 1.4
        }
        private void AgregarBotonesVentana()
        {
            var pnlBotones = new FlowLayoutPanel
            {
                Dock = DockStyle.Right,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false,
                Padding = new Padding(0, 10, 10, 0),
                BackColor = Color.Transparent
            };

            Button CrearBoton(string texto, EventHandler onClick)
            {
                var btn = new Button
                {
                    Text = texto,
                    Width = 45,
                    Height = 35,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(30, 58, 107),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    TabStop = false
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 74);
                btn.Click += onClick;
                return btn;
            }

            pnlBotones.Controls.Add(CrearBoton("—", (s, e) => WindowState = FormWindowState.Minimized));
            pnlBotones.Controls.Add(CrearBoton("☐", (s, e) =>
                WindowState = WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized));
            pnlBotones.Controls.Add(CrearBoton("✕", (s, e) => CerrarSistema()));

            pnlCabecera.Controls.Add(pnlBotones);
            pnlBotones.BringToFront();
        }

        private void CerrarSistema()
        {
            // 1) Pedir confirmación al usuario
            var resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resultado != DialogResult.Yes)
                return;

            // 2) Cerrar formularios MDI hijos que estén abiertos
            foreach (var frm in MdiChildren)
            {
                // Si algún form tiene lógica propia al cerrar (ej. guardar cambios), se respeta
                frm.Close();
            }

            // 3) Cerrar cualquier otro formulario abierto (no MDI)
            var otrosForms = Application.OpenForms.Cast<Form>()
                .Where(f => f != this)
                .ToList();

            foreach (var f in otrosForms)
                f.Close();

            // 4) Salir del bucle de mensajes
            Application.Exit();
        }
        // Habilita mover la ventana arrastrando desde el panel
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        private void LoadPermissionsForUser(string userId)
        {
            permissionsTable = Program.ServiceProvider.GetRequiredService<IPermissionService>().GetUserPermissions(userId)?.Result;
            BuildTreeWithPermissions();
        }

        private void BuildTreeWithPermissions()
        {
            menuStrip1.Items.Clear();

            var menuGroups = permissionsTable
                .GroupBy(row => new { MenuId = row.Id, MenuName = row.Name, IsAssigned = row.IsAssigned });

            foreach (var menuGroup in menuGroups)
            {
                // Fix: Use a local variable to allow modification
                var menuName = menuGroup.Key.MenuName;
                if (menuName.Equals("Productos con imagen"))
                    menuName = "Productos";

                var menuItem = new ToolStripMenuItem(menuName)
                {
                    Tag = menuGroup.Key.MenuId
                };

                foreach (var submenuRow in menuGroup)
                {
                    if (submenuRow.IsAssigned != 1)
                        break;
                    var subItem = new ToolStripMenuItem(submenuRow.SubMenuName)
                    {
                        Tag = submenuRow,                    // 👈 guardamos TODA la fila
                        Enabled = true
                    };

                    //subItem.CheckedChanged += SubItem_CheckedChanged;
                    subItem.Click += SubItem_Click;
                    menuItem.DropDownItems.Add(subItem);
                }
                var subMenuItems = menuGroup.Where(row => row.IsAssigned == 1 && row.Id == menuGroup.Key.MenuId).ToList();
                if (subMenuItems.Count > 0)
                    menuStrip1.Items.Add(menuItem);
            }
        }

        // ============================================================
        //  ABRIR FORMULARIO POR NOMBRE (reflexión)
        // ============================================================
        private void SubItem_Click(object? sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem item || item.Tag is not PermissionMenuDto row)
                return;

            // 🔐 Doble chequeo de permisos
            if (row.IsAssigned != 1)
            {
                MessageBox.Show("No tiene permisos para acceder a esta opción.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔎 Validar que tenga formulario asociado
            if (string.IsNullOrWhiteSpace(row.FormAssociation))
            {
                MessageBox.Show($"La opción '{row.SubMenuName}' no tiene formulario asociado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AbrirFormulario(row.FormAssociation!, row.SubMenuName);
        }

        // ============================================================
        //  ABRIR FORMULARIO POR NOMBRE (reflexión)
        // ============================================================
        private void AbrirFormulario(string nombreForm, string titulo)
        {
            // 1) Resolver el Type
            var tipo = FormResolver.ResolverFormType(nombreForm);

            if (tipo == null || !typeof(Form).IsAssignableFrom(tipo))
            {
                MessageBox.Show(
                    $"No se encontró el formulario '{nombreForm}'.\n" +
                    "Verifique el nombre en la tabla Submenu.formAssociation.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Reutilizar instancia abierta (no abre duplicados)
            foreach (var frmAbierto in MdiChildren)
            {
                if (frmAbierto.GetType() == tipo)
                {
                    if (frmAbierto.WindowState == FormWindowState.Minimized)
                        frmAbierto.WindowState = FormWindowState.Normal;
                    frmAbierto.Activate();
                    return;
                }
            }

            // 3) Crear instancia
            try
            {
                var form = (Form)Activator.CreateInstance(tipo)!;
                form.MdiParent = this;
                form.Text = titulo;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir '{titulo}':\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmprincipal_Load(object sender, EventArgs e)
        {
            this.LoadPermissionsForUser(_usuarioId);
        }
    }
}
