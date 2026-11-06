﻿using BusinessEntities.Dtos.TiposMovimiento;
using ClickVenta.Config;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;

namespace ClickVenta.TipoMovimiento.single
{
    public partial class frsingletpmovimiento : Form
    {
        private UpdateTipoMovimientoDto _tipoMovimientoDto;

        public frsingletpmovimiento(UpdateTipoMovimientoDto dto = null)
        {
            InitializeComponent();
            _tipoMovimientoDto = dto;

            if (dto != null)
            {
                label3.Text = "Actualizar tipo de movimiento";
                Text = "Actualizar Tipo de Movimiento";
                txtId.Text = dto.Id;
                txtNombre.Text = dto.Nombre;
                txtDescripcion.Text = dto.Descripcion;
            }
        }

        private void frsingletpmovimiento_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                var service = Program.ServiceProvider.GetRequiredService<ITipoMovimientoService>();

                if (_tipoMovimientoDto == null)
                {
                    var createDto = new CreateTipoMovimientoDto
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim(),
                    };

                    var message = await service.CreateTipoMovimiento(createDto);
                    RJMessageBox.Show(message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var updateDto = new UpdateTipoMovimientoDto
                    {
                        Id = txtId.Text,
                        Nombre = txtNombre.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim(),
                    };

                    var message = await service.UpdateTipoMovimiento(updateDto);
                    RJMessageBox.Show(message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            return true;
        }
    }
}
