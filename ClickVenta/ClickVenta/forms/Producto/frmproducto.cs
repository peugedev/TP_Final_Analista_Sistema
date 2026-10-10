using ClickVenta.Config;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using Resolver.HelperError.IExceptions;

namespace ClickVenta.forms.Producto
{
    public partial class frmproducto : Form
    {
        Int64 count = 0;
        string filter = null;
        public frmproducto()
        {
            InitializeComponent();
        }

        private void frmproducto_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
            this.LoadList();
        }
        private void LoadList()
        {
            try
            {
                string filter = null;
                if (!string.IsNullOrEmpty(this.txtfilter.Text))
                    filter = this.txtfilter.Text;
                var result = Program.ServiceProvider.GetRequiredService<IProductoService>().GetAllProductos(1, SystemConstant.pageactual, SystemConstant.pagesize, filter)?.Result;
                if (result.Any())
                    this.count = result.FirstOrDefault().Count;
                this.datalist.DataSource = result;

                if (string.IsNullOrEmpty(filter))
                    this.filter = this.txtfilter.Text;

                this.txtfilter.Text = string.Empty;
                this.HideColumn();
                this.GetPagination();
            }
            catch (ApiBusinessException ex)
            {
                RJMessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //RJMessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Object reference not set to an instance of an object."))
                    RJMessageBox.Show("No se encontró el servidor. Compruebe que el nombre de la instancia es correcto.", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    RJMessageBox.Show("No se pudo conectar! Contacte al administrador.", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void HideColumn()
        {
            this.datalist.Columns["Id"].Visible = false;
            this.datalist.Columns["Descripcion"].Visible = false;
            this.datalist.Columns["CodigoBarra"].Visible = false;
            this.datalist.Columns["IdCategoria"].Visible = false;
            this.datalist.Columns["Count"].Visible = false;
            this.datalist.Columns["FechaCreacion"].Visible = false;
            this.datalist.Columns["FechaBaja"].Visible = false;
            this.datalist.Columns["Estado"].Visible = false;
            //this.datalist.Columns["ModifiedDate"].Visible = false;
            //this.datalist.Columns["IsContainExpiredDate"].Visible = false;
            //this.datalist.Columns["MinimumStock"].Visible = false;
            //this.datalist.Columns["Product"].Visible = false;
            //this.datalist.Columns["LotProductCode"].Visible = false;
            //this.datalist.Columns["SalePriceSpecial"].Visible = false;
            ////this.datalot.Columns["LotCode"].Visible = false;
        }
        private void GetPagination()
        {
            if (count > 0)
            {
                SystemConstant.pageamount = count;
                SystemConstant.page = Math.Ceiling(SystemConstant.pageamount / SystemConstant.pagesize);

                this.lblStatus.Text = (SystemConstant.skipamount).ToString() + " / " + SystemConstant.page.ToString();
                this.lblTotal.Text = SystemConstant.pageamount.ToString();

                if (Convert.ToInt32(SystemConstant.skipamount) < Convert.ToInt32(SystemConstant.page))
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnNext, btnLast }, true);
                }
                else
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnNext, btnLast }, false);
                }

                if (SystemConstant.skipamount > 1)
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnPrevious, btnFirst }, true);
                }
                else
                {
                    ShareMethod.GetInstance().HabilitarBtnPagination(new List<Button> { btnPrevious, btnFirst }, false);
                }
            }
            else
            {
                this.lblStatus.Text = (0 + " / " + 0);
                this.lblTotal.Text = (0).ToString();
            }
        }
    }
}
