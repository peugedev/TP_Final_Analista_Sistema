using BusinessEntities.Dtos.Proveedor;
using ClickVenta.Config;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace ClickVenta.forms.Proveedor.single
{
    public partial class frmsingleproveedor : Form
    {
        private UpdateProveedorDto _proveedorDto;

        public frmsingleproveedor(UpdateProveedorDto dto = null)
        {
            InitializeComponent();

            _proveedorDto = dto;

            if (dto != null)
            {
                label3.Text = "Actualizar proveedor";
                Text = "Actualizar Proveedor";

                txtRazonSocial.Text = dto.RazonSocial;
                txtCuitCuil.Text = dto.Cuit_Cuil;
                txtCodigo.Text = dto.Codigo;
                txtTelefono.Text = dto.Telefono;
                txtDireccion.Text = dto.Direccion;
                txtEmail.Text = dto.Email;
                txtWeb.Text = dto.Web;
                txtId.Text = dto.Id;
            }
        }

        private void frmsingleproveedor_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                var service = Program.ServiceProvider
                    .GetRequiredService<IProveedorService>();

                if (_proveedorDto == null)
                {
                    var createDto = new CreateProveedorDto
                    {
                        Codigo = txtCodigo.Text.Trim(),
                        Cuit_Cuil = txtCuitCuil.Text.Trim(),
                        RazonSocial = txtRazonSocial.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Web = txtWeb.Text.Trim()
                    };

                    var message = await service.CreateProveedor(createDto);

                    RJMessageBox.Show(
                        message,
                        "Sistema de ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    var updateDto = new UpdateProveedorDto
                    {
                        Id = txtId.Text,
                        Codigo = txtCodigo.Text.Trim(),
                        Cuit_Cuil = txtCuitCuil.Text.Trim(),
                        RazonSocial = txtRazonSocial.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Web = txtWeb.Text.Trim()
                    };

                    var message = await service.UpdateProveedor(updateDto);

                    RJMessageBox.Show(
                        message,
                        "Sistema de ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                Close();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(
                    ex.Message,
                    "Sistema de ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show(
                    "La razón social es requerida.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtRazonSocial.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show(
                    "El código es requerido.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            return true;
        }
    }
}
