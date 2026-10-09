using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Roles;
using ClickVenta.Config;
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
        public frmcrearsingleempleado()
        {
            InitializeComponent();
            this.UpdateRoleAutocomplete();
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
                if (string.IsNullOrEmpty(this.txtnombreusuario.Texts))
                {
                    MessageBox.Show("El nombre de usuario es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(this.txtcontrasenia.Texts))
                {
                    MessageBox.Show("La contraseña es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.cvcbrol.SelectedIndex < 0 ||  string.IsNullOrEmpty(this.cvcbrol.Texts))
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
                    RolId = ((RolDto)(this.cvcbrol.SelectedItem)).Id
                };
                var result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IEmpleadoService>().CreateEmpleado(empleado)?.Result;
                if (result != null)
                {
                    MessageBox.Show("Empleado creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //private void btnsave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(this.txtnombre.Text))
        //        {
        //            MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        if (string.IsNullOrEmpty(this.txtapellido.Text))
        //        {
        //            MessageBox.Show("El apellido es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        if (string.IsNullOrEmpty(this.txtdni.Text))
        //        {
        //            MessageBox.Show("El DNI es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        if (string.IsNullOrEmpty(this.txttelefono.Text))
        //        {
        //            MessageBox.Show("El telefono es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        if (string.IsNullOrEmpty(this.txtdireccion.Text))
        //        {
        //            MessageBox.Show("La direccion es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        var empleado = new BusinessEntities.Entities.Empleado
        //        {
        //            Nombre = this.txtnombre.Text,
        //            Apellido = this.txtapellido.Text,
        //            DNI = this.txtdni.Text,
        //            Telefono = this.txttelefono.Text,
        //            Direccion = this.txtdireccion.Text
        //        };
        //        var result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IEmpleadoService>().CreateEmpleado(empleado)?.Result;
        //        if (result != null)
        //        {
        //            MessageBox.Show("Empleado creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Resolver.HelperError.Exceptions.ExceptionHandler.HandleException(ex);
        //    }
        //}
    }
}
