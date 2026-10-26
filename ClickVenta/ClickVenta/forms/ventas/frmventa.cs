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
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmventa_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
            this.GetCabecera();
        }

        private async void GetCabecera()
        {
            try
            {
                var cabecera = await Program.ServiceProvider.GetRequiredService<ICabeceraVentaService>().GetCabecera();
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
    }
}
