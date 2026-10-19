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
        public frmlogin()
        {
            //this.Size = new Size(914, 366);
            InitializeComponent();
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
                if (string.IsNullOrEmpty(this.txtusuario.Texts))
                {
                    RJMessageBox.Show("El usuario es requerido", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(this.txtpassword.Texts))
                {
                    RJMessageBox.Show("La contraseña es requerida", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    RJMessageBox.Show("Usuario o contraseña incorrectos", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Aquí pones el código que quieres ejecutar o llamas al botón
                btnentrar_Click(sender, e);
            }
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evita el sonido de "beep" por defecto de Windows
                e.SuppressKeyPress = true;

                // Aquí pones el código que quieres ejecutar o llamas al botón
                btnentrar_Click(sender, e);
            }
        }
    }
}
