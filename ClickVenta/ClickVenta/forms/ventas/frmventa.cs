using BusinessEntities.Dtos.cobrar;
using BusinessEntities.Dtos.DetalleVenta;
using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Venta;
using ClickVenta.Config;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickVenta.forms.ventas
{
    public partial class frmventa : Form
    {
        public frmventa()
        {
            InitializeComponent();
            this.btncobrar.Enabled = false;
            this.datalist.AutoGenerateColumns = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmventa_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
            this.GetCabecera();
            this.CleanAnFocusTextBoxCodeBar();
        }

        private async void GetCabecera()
        {
            try
            {
                var cabecera = await Program.ServiceProvider.GetRequiredService<ICabeceraVentaProductoService>().GetCabecera();
                if (cabecera != null)
                {
                    this.lblticket.Text = cabecera.NroTicket;
                    this.lbltotalultimoventa.Text = cabecera.total.ToString();
                    this.lblformapago.Text = cabecera.FormaPago;
                }
                else
                {
                    this.lblticket.Text = GetFormato(1);
                    this.lbltotalultimoventa.Text = "0.00";
                    this.lblformapago.Text = "";

                }
                this.lblusername.Text = SystemConstant.UserName;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetFormato(int number)
        {
            long numeroPequeno = 1234567;
            var culturaPuntos = CultureInfo.CreateSpecificCulture("es-ES");

            // El formato "000,000,000" fuerza los ceros. 
            // Al pasarle la cultura es-ES, transformará las comas internamente en puntos.
            string resultadoConCeros = number.ToString("000,000,000", culturaPuntos);

            return resultadoConCeros;
        }
        List<DetalleVentaDto> VentaList = null;
        private async void clickVentaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(this.txtcodebar.Texts))
            {
                e.Handled = true; // Evita que se agregue un salto de línea
                // Aquí puedes agregar la lógica que deseas ejecutar cuando se presiona Enter
                var result = await Program.ServiceProvider.GetRequiredService<ICabeceraVentaProductoService>().ConsultaProductoCodigo(this.txtcodebar.Texts);

                if (result != null)
                {
                    if (this.datalist.DataSource is null || ((List<DetalleVentaDto>)this.datalist.DataSource).Count == 0)
                    {
                        CreateVentaDto venta = new CreateVentaDto
                        {
                            UsuarioId = SystemConstant.UsuarioId,
                            Precio = result.PrecioVenta,
                            Total = 0,
                            /* Detalle de venta*/
                            ProductoId = result.Id,
                            Subtotal = result.PrecioVenta,
                            Cantidad = 1
                        };
                        VentaList = new List<DetalleVentaDto>();
                        VentaList = await Program.ServiceProvider.GetRequiredService<IVentaService>().CreateVenta(venta);
                    }
                    else
                    {
                        if (VentaList is null)
                            VentaList = new List<DetalleVentaDto>();

                        //var selectedRow = this.datalist.SelectedRows[0];
                        //var dto = (VentaDto)selectedRow.DataBoundItem;
                        CreateDetalleVentaDto detalle = new CreateDetalleVentaDto
                        {
                            VentaId = VentaList.FirstOrDefault().Id,
                            Precio = result.PrecioVenta,
                            ProductoId = result.Id,
                            Subtotal = result.PrecioVenta,
                            Cantidad = 1
                        };
                        VentaList = await Program.ServiceProvider.GetRequiredService<IDetalleVentaService>().CreateDetalleVenta(detalle);
                    }

                    //this.datalist.Rows.Add(result.Id, result.Nombre, result.PrecioVenta, 1, result.PrecioVenta);
                    if (VentaList.Count > 0)
                    {
                        this.btncobrar.Enabled = true;
                    }
                    //this.HideColunm();
                    this.datalist.DataSource = VentaList;
                    this.UpdateHeade(VentaList);
                    this.CleanAnFocusTextBoxCodeBar();
                }
                else
                {
                    this.CleanAnFocusTextBoxCodeBar();
                    RJMessageBox.Show("No se encontró el producto con el código ingresado.", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CleanAnFocusTextBoxCodeBar()
        {
            this.txtcodebar.Texts = string.Empty;
            this.txtcodebar.Focus();
        }

        private void frmventa_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmventa_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.VentaList is not null || this.VentaList.Count > 0)
                {
                    // 1) Pedir confirmación al usuario
                    var resultado = MessageBox.Show(
                        "Hay una venta sin cobrar\n¿Está seguro que desea salir de la pantalla de venta?",
                        "Confirmar salida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                    if (resultado != DialogResult.Yes)
                    {
                        e.Cancel = true; // Cancela el cierre del formulario
                    }
                    else
                    {
                        DeleteVentaDto delete = new DeleteVentaDto
                        {
                            Id = this.VentaList.FirstOrDefault().Id
                        };
                        var result = Program.ServiceProvider.GetRequiredService<IVentaService>().DeleteVenta(delete);
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateHeade(List<DetalleVentaDto> Listdto)
        {
            this.lblcantidad.Text = Listdto.Sum(u => u.Cantidad).ToString();
            this.lblcobrar.Text = Listdto.Sum(u => u.Subtotal).ToString();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            frmcobrar form = new frmcobrar(new CobrarDTO
            {
                VentaId = this.VentaList.FirstOrDefault().Id,
                Total = this.VentaList.Sum(u => u.Subtotal).ToString()
            });
            form.ShowDialog();
        }
    }
}
