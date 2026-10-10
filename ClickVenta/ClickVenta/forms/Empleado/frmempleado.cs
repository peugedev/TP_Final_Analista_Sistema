using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Entities;
using ClickVenta.Config;
using ClickVenta.forms.Empleado.single;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using Resolver.HelperError.IExceptions;

namespace ClickVenta.forms.Empleado
{
    public partial class frmempleado : Form
    {
        Int64 count = 0;
        string filter = null;
        public frmempleado()
        {
            InitializeComponent();
            this.datalist.AutoGenerateColumns = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            frmcrearsingleempleado frm = new frmcrearsingleempleado();
            frm.ShowDialog();
            this.LoadList();
        }

        private void frmempleado_Load(object sender, EventArgs e)
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
                var result = Program.ServiceProvider.GetRequiredService<IEmpleadoService>().GetAllEmpleados(1, SystemConstant.pageactual, SystemConstant.pagesize, filter)?.Result;
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
            this.datalist.Columns["ckdelete"].Visible = false;
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

        private void datalist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = this.datalist.SelectedRows[0];
            var emp = (EmpleadoDto)selectedRow.DataBoundItem;
            UpdateEmpleadoDto dto = new UpdateEmpleadoDto()
            {
                Apellido = emp.Apellido,
                Direccion = emp.Direccion,
                DNI = emp.DNI,
                Id = emp.Id,
                Nombre = emp.Nombre,
                Telefono = emp.Telefono
            };

            frmcrearsingleempleado frmcrearsingleempleado = new frmcrearsingleempleado(dto);
            frmcrearsingleempleado.ShowDialog();
            this.LoadList();
        }

        private void DeseabledComponent(bool val)
        {
            this.txtfilter.Enabled = val;
            this.btnfilter.Enabled = val;
            this.btnempleado.Enabled = val;
        }
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.datalist.Columns[0].Visible = true;
                this.DeseabledComponent(false);
            }
            else
            {
                foreach (DataGridViewRow row in datalist.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        row.Cells[0].Value = false;
                    }
                }
                this.datalist.Columns[0].Visible = false;
                this.DeseabledComponent(true);
            }
        }

        private void datalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalist.Columns["ckdelete"].Index /*&& e.ColumnIndex != this.dataList.Columns["colExpandir"].Index*/)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)datalist.Rows[e.RowIndex].Cells["ckdelete"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void clickVentaButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean isdelate = false;
                Boolean ischeked = false;

                foreach (DataGridViewRow row in datalist.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        ischeked = true;
                    }
                }
                if (chkEliminar.Checked && ischeked)
                {
                    DialogResult Opcion;
                    Opcion = RJMessageBox.Show("Realmente Desea Eliminar los Registros", "Click venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Opcion == DialogResult.OK)
                    {
                        //String Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in datalist.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                DeleteEmpleadoDto dto = new DeleteEmpleadoDto()
                                {
                                    Id = ((EmpleadoDto)row.DataBoundItem).Id
                                };

                                resp = Program.ServiceProvider.GetRequiredService<DataService.Services.IService.IEmpleadoService>().DeleteEmpleado(dto)?.Result;


                                if (!string.IsNullOrEmpty(resp))
                                {
                                    isdelate = true;
                                }
                                else
                                {
                                    isdelate = false;
                                }
                            }
                        }
                        if (isdelate)
                        {
                            RJMessageBox.Show(resp, "Click venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chkEliminar.Checked = false;

                        }
                        else
                        {
                            RJMessageBox.Show("El archivo no fue eliminado", "Click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            chkEliminar.Checked = false;
                        }
                        this.LoadList();
                    }
                }
                else
                    RJMessageBox.Show("Debe chequear el checkbox eliminar, si deseas eliminar uno o mas registro", "Click venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApiBusinessException ex)
            {
                this.txtfilter.Text = string.Empty;
                RJMessageBox.Show(ex.MessageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                this.txtfilter.Text = string.Empty;
                RJMessageBox.Show(ex.Message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            this.LoadList();
        }
    }
}
