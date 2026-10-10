using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Rol;
using ClickVenta.Config;
using ClickVenta.forndesign;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickVenta.forms.Empleado.single
{
    public partial class frmcrearsingleempleado : Form
    {
        public frmcrearsingleempleado(UpdateEmpleadoDto dto = null)
        {
            InitializeComponent();
            this.UpdateRoleAutocomplete();

            if (dto != null)
            {
                this.groupBox2.Visible = false;
                this.label3.Text = "Actualiza empleado";
                this.Height = this.Height - (this.groupBox2.Height + this.groupBox3.Height);
                this.groupBox3.Location = new System.Drawing.Point(1, this.groupBox2.Height);

                this.txtnombre.Texts = dto.Nombre;
                this.txtdireccion.Texts = dto.Direccion;
                this.txtapellido.Texts = dto.Apellido;
                this.txttelefono.Texts = dto.Telefono;
                this.txtdni.Texts = dto.DNI;
                this.txtid.Texts = dto.Id;

            }
            else
            {
                this.groupBox2.Visible = true;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateRoleAutocomplete()
        {
            try
            {
                var result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IRolService>().GetAllRoles(1, 1, 20)?.Result;
                if (result != null)
                {

                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    //foreach (var item in result)
                    //{
                    //    collection.Add(item.Nombre);
                    //}
                    this.cvcbrol.DataSource = result;
                    this.cvcbrol.DisplayMember = "Nombre";   // Lo que se ve
                    this.cvcbrol.ValueMember = "Id";

                    this.cvcbrol.SelectedIndex = -1;
                    this.cvcbrol.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.cvcbrol.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    this.cvcbrol.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtnombre.Texts))
                {
                    MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(this.txtapellido.Texts))
                {
                    MessageBox.Show("El apellido es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(this.txtnombreusuario.Texts) && string.IsNullOrEmpty(this.txtid.Texts))
                {
                    MessageBox.Show("El nombre de usuario es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(this.txtcontrasenia.Texts) && string.IsNullOrEmpty(this.txtid.Texts))
                {
                    MessageBox.Show("La contraseña es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((this.cvcbrol.SelectedIndex < 0 || string.IsNullOrEmpty(this.cvcbrol.Texts)) && string.IsNullOrEmpty(this.txtid.Texts))
                {
                    MessageBox.Show(
                        "Debe seleccionar un rol antes de guardar.",
                        "Campo requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    this.cvcbrol.Focus();
                    return; // 🚫 Cortamos el flujo, no se guarda
                }
                var empleado = new CreateEmpleadoDto
                {
                    Nombre = this.txtnombre.Texts,
                    Apellido = this.txtapellido.Texts,
                    DNI = this.txtdni.Texts,
                    Telefono = this.txttelefono.Texts,
                    Direccion = this.txtdireccion.Texts,
                    NombreUsuario = this.txtnombreusuario.Texts,
                    Contrasena = this.txtcontrasenia.Texts,
                    RolId = ((RolDto)(this.cvcbrol?.SelectedItem))?.Id
                };
                string result;
                if (string.IsNullOrEmpty(this.txtid.Texts))
                    result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IEmpleadoService>().CreateEmpleado(empleado)?.Result;
                else
                {
                    UpdateEmpleadoDto dto = new UpdateEmpleadoDto()
                    {
                        Apellido = empleado.Apellido,
                        Direccion = empleado.Direccion,
                        DNI = empleado.DNI,
                        Id = this.txtid.Texts,
                        Nombre = empleado.Nombre,
                        Telefono = empleado.Telefono
                    };
                    result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IEmpleadoService>().UpdateEmpleado(dto)?.Result;
                }
                if (result != null)
                {
                    MessageBox.Show(result, "Click venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void clickVentaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcrearsingleempleado_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }
    }
}
