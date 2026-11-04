using BusinessEntities.Dtos.cobrar;
using BusinessEntities.Dtos.FormaPago;
using BusinessEntities.Dtos.Venta;
using ClickVenta.Config;
using ClickVenta.forndesign;
using Microsoft.Extensions.DependencyInjection;

namespace ClickVenta.forms.ventas
{
    public partial class frmcobrar : Form
    {
        public bool iscompletar = false;
        private CobrarDTO _dto;
        public frmcobrar(CobrarDTO dto)
        {
            InitializeComponent();
            this.lbltotal.Text = dto.Total;
            _dto = dto;
        }

        private void frmcobrar_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
            this.LlenarComboFormaPago();
            this.LlenarComboFormaPago1();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbformacobro_CheckedChanged(object sender, EventArgs e)
        {
            if (chbformacobro.Checked)
            {
                //this.lblformapago1.Visible = false;
                this.lblformapago2.Visible = true;
                this.cvcpago2.Visible = true;

                this.lblformapago1.Text = "Seleccionar forma pago 1";
                this.lblformapago2.Text = "Seleccionar forma pago 2";
                this.lblpago2.Visible = true;
                this.txtpago2.Visible = true;
            }
            else
            {
                this.lblformapago2.Visible = false;
                this.cvcpago2.Visible = false;
                this.lblpago2.Visible = false;
                this.txtpago2.Visible = false;

                this.lblformapago1.Text = "Seleccionar forma pago";
            }
        }

        private async void LlenarComboFormaPago()
        {
            var list = await Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IFormaPagoService>().GetAllFormasPago(1, 1, 1000);
            this.cvcpago1.DataSource = list;
            this.cvcpago1.DisplayMember = "Nombre";
            this.cvcpago1.ValueMember = "Id";

            this.cvcpago1.SelectedIndex = -1;
            this.cvcpago1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cvcpago1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.cvcpago1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async void LlenarComboFormaPago1()
        {
            var list = await Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IFormaPagoService>().GetAllFormasPago(1, 1, 1000);

            this.cvcpago2.DataSource = list;
            this.cvcpago2.DisplayMember = "Nombre";
            this.cvcpago2.ValueMember = "Id";

            this.cvcpago2.SelectedIndex = -1;
            this.cvcpago2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cvcpago2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.cvcpago2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void clickVentaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickVentaButton2_Click(object sender, EventArgs e)
        {
            if (this.cvcpago1.SelectedIndex == -1)
            {
                RJMessageBox.Show("Debe seleccionar una forma de pago", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.chbformacobro.Checked && this.cvcpago2.SelectedIndex == -1)
            {
                RJMessageBox.Show("Debe seleccionar una forma de pago 2", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.chbformacobro.Checked && this.cvcpago1.Texts.ToString() == this.cvcpago2.Texts.ToString())
            {
                RJMessageBox.Show("No puede seleccionar la misma forma de pago", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.chbformacobro.Checked)
            {
                var formaPago1 = this.cvcpago1.SelectedItem as FormaPagoDto;
                var formaPago2 = this.cvcpago2.SelectedItem as FormaPagoDto;
                if (formaPago1 != null && formaPago2 != null)
                {
                    UpdateVentaDto updateVentaDto = new UpdateVentaDto
                    {
                        FormaPagoId1 = formaPago1.Id,
                        FormaPagoId2 = formaPago2.Id,
                        Total = decimal.Parse(this.lbltotal.Text),
                        Id = _dto.VentaId,
                    };
                    Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IVentaService>().UpdateVenta(updateVentaDto);
                    this.iscompletar = true;
                    this.Close();
                    // Aquí puedes manejar la lógica para procesar el cobro con dos formas de pago
                    //RJMessageBox.Show($"Cobro realizado con éxito con las formas de pago: {formaPago1.Nombre} y {formaPago2.Nombre}", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RJMessageBox.Show("Debe seleccionar ambas formas de pago", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var formaPago = this.cvcpago1.SelectedItem as FormaPagoDto;
                if (formaPago != null)
                {
                    UpdateVentaDto updateVentaDto = new UpdateVentaDto
                    {
                        FormaPagoId1 = formaPago.Id,
                        FormaPagoId2 = null,
                        Total = decimal.Parse(this.lbltotal.Text),
                        Id = _dto.VentaId,
                    };

                    Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IVentaService>().UpdateVenta(updateVentaDto);
                    this.iscompletar = true;
                    this.Close();
                    // Aquí puedes manejar la lógica para procesar el cobro con una sola forma de pago
                    //RJMessageBox.Show($"Cobro realizado con éxito con la forma de pago: {formaPago.Nombre}", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RJMessageBox.Show("Debe seleccionar una forma de pago", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
