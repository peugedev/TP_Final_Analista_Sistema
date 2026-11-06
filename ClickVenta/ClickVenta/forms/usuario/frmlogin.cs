using BusinessEntities.Dtos.Login;
using ClickVenta.Config;
using ClickVenta.forms.basehelper;
using ClickVenta.forms.Principal;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;

namespace ClickVenta
{
    public partial class frmlogin : Form
    {
        private const string PlaceholderUsuario = "Ingresar usuario";
        private const string PlaceholderContrasena = "Ingresar la contrase\u00F1a";

        public frmlogin()
        {
            //this.Size = new Size(914, 366);
            InitializeComponent();

            this.txtusuario.Enter += txtusuario_Enter;
            this.txtusuario.Leave += txtusuario_Leave;
            this.txtpassword.Enter += txtpassword_Enter;
            this.txtpassword.Leave += txtpassword_Leave;
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
            //this.KeyPreview = true;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnentrar_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private async void login()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtusuario.Texts) || this.txtusuario.Texts == PlaceholderUsuario)
                {
                    RJMessageBox.Show("El usuario es requerido", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.txtpassword.Texts) || this.txtpassword.Texts == PlaceholderContrasena)
                {
                    RJMessageBox.Show("La contrase\u00F1a es requerida", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoginDto loginDto = new LoginDto
                {
                    UsuarioLogin = this.txtusuario.Texts,
                    Password = this.txtpassword.Texts
                };

                var result = await Program.ServiceProvider.GetRequiredService<ILoginService>().Login(loginDto);
                if (result is not null)
                {
                    SystemConstant.UsuarioId = result.Id;
                    SystemConstant.EmpleadoId = result.EmpleadoId;
                    SystemConstant.UserName = result.NombreUsuario;
                    SystemConstant.RoleId = result.RolId;
                    this.Hide();
                    frmprincipal menu = new frmprincipal(result.Id);
                    menu.ShowDialog();
                }
                else
                {
                    RJMessageBox.Show("Usuario o contrase�a incorrectos", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnentrar_Enter(object sender, EventArgs e)
        {
            //this.login();
        }

        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido de "beep" por defecto de Windows
                e.SuppressKeyPress = true;

                // Aqu� pones el c�digo que quieres ejecutar o llamas al bot�n
                btnentrar_Click(sender, e);
            }
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido de "beep" por defecto de Windows
                e.SuppressKeyPress = true;

                // Aqu� pones el c�digo que quieres ejecutar o llamas al bot�n
                btnentrar_Click(sender, e);
            }
        }
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (this.txtusuario.Texts == PlaceholderUsuario)
            {
                this.txtusuario.Texts = string.Empty;
                this.txtusuario.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtusuario.Texts))
            {
                this.txtusuario.Texts = PlaceholderUsuario;
                this.txtusuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (this.txtpassword.Texts == PlaceholderContrasena)
            {
                this.txtpassword.Texts = string.Empty;
                this.txtpassword.ForeColor = Color.FromArgb(64, 64, 64);
                this.txtpassword.PasswordChar = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtpassword.Texts))
            {
                this.txtpassword.Texts = PlaceholderContrasena;
                this.txtpassword.ForeColor = Color.DarkGray;
                this.txtpassword.PasswordChar = false;
            }
        }

    }
}
