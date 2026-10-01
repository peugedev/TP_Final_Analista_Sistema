using ClickVenta.Config;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickVenta.forms.user
{
    public partial class frmselectuser : Form
    {
        private TextBox txtUsername;
        Int64 count = 0;
        public string UserId { get; set; }
        public bool IsSelected { get; set; }
        public frmselectuser()
        {
            InitializeComponent();
            this.datalist.AutoGenerateColumns = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadList()
        {
            try
            {
                string filter = null;
                if (!string.IsNullOrEmpty(this.txtfilter.Text))
                    filter = this.txtfilter.Text;
                var result = Program.ServiceProvider.GetRequiredService<IUsuarioService>().GetAll(1, SystemConstant.pageactual, SystemConstant.pagesize, filter)?.Result;
                if (result.Any())
                    this.count = result.FirstOrDefault().ListaUsuarios.Count;
                this.datalist.DataSource = result;
                this.txtfilter.Text = string.Empty;
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

        private void frmselectuser_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
            this.LoadList();
        }
    }
}
