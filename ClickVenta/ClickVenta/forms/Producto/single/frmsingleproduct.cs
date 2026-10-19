using BusinessEntities.Dtos.Categoria;
using BusinessEntities.Dtos.Presentacion;
using BusinessEntities.Dtos.Producto;
using BusinessEntities.Dtos.Proveedor;
using ClickVenta.Config;
using ClickVenta.forndesign;
using Microsoft.Extensions.DependencyInjection;

namespace ClickVenta.Producto.single
{
    public partial class frmsingleproduct : Form
    {
        public frmsingleproduct(UpdateProductoDto dto = null)
        {
            InitializeComponent();
            this.UpdateCategoriaAutocomplete();
            this.UpdatePresentacionAutocomplete();
            this.UpdateProveedorAutocomplete();

            if (dto != null)
            {
                this.label3.Text = "Actualiza producto";

                this.txtnombre.Texts = dto.Nombre;
                this.txtcodigobarra.Texts = dto.CodigoBarra;
                this.txtdescripcion.Texts = dto.Descripcion;
                this.txtpreciocompra.Texts = dto.PrecioCompra.ToString();
                this.txtprecioventa.Texts = dto.PrecioVenta.ToString();
                this.txtid.Texts = dto.Id;

            }
        }
        private void UpdateCategoriaAutocomplete()
        {
            try
            {
                var result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.ICategoriaService>().GetAllCategorias(1, 1, 200)?.Result;
                if (result != null)
                {

                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                    this.cvcbcategoria.DataSource = result;
                    this.cvcbcategoria.DisplayMember = "Nombre";   // Lo que se ve
                    this.cvcbcategoria.ValueMember = "Id";

                    this.cvcbcategoria.SelectedIndex = -1;
                    this.cvcbcategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.cvcbcategoria.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    this.cvcbcategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdatePresentacionAutocomplete()
        {
            try
            {
                var result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IPresentacionService>().GetAllPresentaciones(1, 1, 200)?.Result;
                if (result != null)
                {

                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                    this.cvcbpresentacion.DataSource = result;
                    this.cvcbpresentacion.DisplayMember = "Nombre";   // Lo que se ve
                    this.cvcbpresentacion.ValueMember = "Id";

                    this.cvcbpresentacion.SelectedIndex = -1;
                    this.cvcbpresentacion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.cvcbpresentacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    this.cvcbpresentacion.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateProveedorAutocomplete()
        {
            try
            {
                var result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IProveedorService>().GetAllProveedores(1, 1, 200)?.Result;
                if (result != null)
                {
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    this.cvcbproveedor.DataSource = result;
                    this.cvcbproveedor.DisplayMember = "RazonSocial";   // Lo que se ve
                    this.cvcbproveedor.ValueMember = "Id";
                    this.cvcbproveedor.SelectedIndex = -1;
                    this.cvcbproveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    this.cvcbproveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    this.cvcbproveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmsingleproduct_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtnombre.Texts) || string.IsNullOrEmpty(this.txtcodigobarra.Texts) || string.IsNullOrEmpty(this.txtdescripcion.Texts) || string.IsNullOrEmpty(this.txtpreciocompra.Texts) || string.IsNullOrEmpty(this.txtprecioventa.Texts) || this.cvcbcategoria.SelectedIndex == -1 || this.cvcbpresentacion.SelectedIndex == -1)
                {
                    RJMessageBox.Show("Debe completar todos los campos", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(this.txtpreciocompra.Texts) || string.IsNullOrEmpty(this.txtprecioventa.Texts))
                {
                    RJMessageBox.Show("El precio de compra y venta no puede estar vacío", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (this.txtpreciocompra.Texts == "0" || this.txtprecioventa.Texts == "0")
                {
                    RJMessageBox.Show("El precio de compra y venta no puede ser 0", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (this.txtprecioventa.Texts == this.txtpreciocompra.Texts)
                {
                    RJMessageBox.Show("El precio de venta no puede ser igual al precio de compra", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(this.txtnombre.Texts))
                {
                    RJMessageBox.Show("El nombre no puede estar vacío", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if( string.IsNullOrEmpty( this.txtstock.Texts))
                {
                    RJMessageBox.Show("El stock no puede estar vacío", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (this.txtstock.Texts == "0")
                {
                    RJMessageBox.Show("El stock no puede ser 0", "Sistema click venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((this.cvcbcategoria.SelectedIndex < 0 || string.IsNullOrEmpty(this.cvcbcategoria.Texts)) && string.IsNullOrEmpty(this.txtid.Texts))
                {
                    MessageBox.Show(
                        "Debe seleccionar una categoría antes de guardar.",
                        "Campo requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    this.cvcbcategoria.Focus();
                    return; // 🚫 Cortamos el flujo, no se guarda
                }
                if ((this.cvcbpresentacion.SelectedIndex < 0 || string.IsNullOrEmpty(this.cvcbpresentacion.Texts)) && string.IsNullOrEmpty(this.txtid.Texts))
                {
                    MessageBox.Show(
                        "Debe seleccionar una presentación antes de guardar.",
                        "Campo requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    this.cvcbpresentacion.Focus();
                    return; // 🚫 Cortamos el flujo, no se guarda
                }

                var createdto = new CreateProductoDto
                {
                    Nombre = this.txtnombre.Texts,
                    Stock = int.Parse(this.txtstock.Texts),
                    CodigoBarra = this.txtcodigobarra.Texts,
                    Descripcion = this.txtdescripcion.Texts,
                    PrecioCompra = decimal.Parse(this.txtpreciocompra.Texts),   
                    PrecioVenta = decimal.Parse(this.txtprecioventa.Texts),
                    FechaVencimiento = this.dtfechavenc.Value.Date == DateTime.MinValue.Date ? (DateTime?)null: this.dtfechavenc.Value,
                    CategoriaId = ((CategoriaDto)(this.cvcbcategoria?.SelectedItem))?.Id,
                    PresentacionId = ((PresentacionDto)(this.cvcbpresentacion?.SelectedItem))?.Id,
                    ProveedorId = ((ProveedorDto)(this.cvcbproveedor?.SelectedItem))?.Id
                };

                string result;
                if (string.IsNullOrEmpty(this.txtid.Texts))
                    result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IProductoService>().CreateProducto(createdto)?.Result;
                else
                {
                    UpdateProductoDto dto = new UpdateProductoDto()
                    {
                        Id = this.txtid.Texts,
                        Nombre = this.txtnombre.Texts,
                        CodigoBarra = this.txtcodigobarra.Texts,
                        Stock = int.Parse(this.txtstock.Texts),
                        Descripcion = this.txtdescripcion.Texts,
                        PrecioCompra = decimal.Parse(this.txtpreciocompra.Texts),
                        PrecioVenta = decimal.Parse(this.txtprecioventa.Texts),
                        CategoriaId = ((CategoriaDto)(this.cvcbcategoria?.SelectedItem))?.Id,
                        PresentacionId = ((PresentacionDto)(this.cvcbpresentacion?.SelectedItem))?.Id,
                        ProveedorProductoId = ((ProveedorDto)(this.cvcbproveedor?.SelectedItem))?.Id
                    };
                    result = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IProductoService>().UpdateProducto(dto)?.Result;
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
    }
}
