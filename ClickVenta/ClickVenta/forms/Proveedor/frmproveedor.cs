using System;
using BusinessEntities.Dtos.Proveedor;
using ClickVenta.Config;
using ClickVenta.forms.Proveedor.single;
using ClickVenta.forndesign;
using DataService.Services.IService;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClickVenta.forms.Proveedor
{
    public partial class frmproveedor : Form
    {
        private long count;
        private string filter;

        public frmproveedor()
        {
            InitializeComponent();
            datalist.AutoGenerateColumns = false;
        }

        private async void frmproveedor_Load(object sender, EventArgs e)
        {
            radiusform.GetRadius(this);
            await LoadListAsync();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmsingleproveedor();
            frm.ShowDialog();
            _ = LoadListAsync();
        }

        private async Task LoadListAsync()
        {
            try
            {
                var currentFilter = string.IsNullOrWhiteSpace(txtfilter.Text)
                    ? filter
                    : txtfilter.Text.Trim();

                var service = Program.ServiceProvider
                    .GetRequiredService<IProveedorService>();

                var result = await service.GetAllProveedores(
                    1,
                    SystemConstant.pageactual,
                    SystemConstant.pagesize,
                    currentFilter);

                var proveedores = result?.ToList() ?? new List<ProveedorDto>();

                if (proveedores.Count > 0)
                    count = proveedores[0].Count;
                else if (string.IsNullOrWhiteSpace(currentFilter))
                    count = 0;

                datalist.DataSource = proveedores;
                filter = currentFilter;
                txtfilter.Clear();

                UpdatePagination();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(
                    ex.Message,
                    "Sistema de ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdatePagination()
        {
            if (count <= 0)
            {
                lblStatus.Text = "0 / 0";
                lblTotal.Text = "0";
                ShareMethod.GetInstance().HabilitarBtnPagination(
                    new List<Button> { btnFirst, btnPrevious, btnNext, btnLast },
                    false);
                return;
            }

            SystemConstant.pageamount = count;
            SystemConstant.page = Math.Ceiling(
                SystemConstant.pageamount / SystemConstant.pagesize);

            lblStatus.Text = $"{SystemConstant.skipamount} / {SystemConstant.page}";
            lblTotal.Text = SystemConstant.pageamount.ToString();

            ShareMethod.GetInstance().HabilitarBtnPagination(
                new List<Button> { btnFirst, btnPrevious },
                SystemConstant.pageactual > 1);

            ShareMethod.GetInstance().HabilitarBtnPagination(
                new List<Button> { btnNext, btnLast },
                SystemConstant.pageactual < SystemConstant.page);
        }

        private void txtfilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            SystemConstant.pageactual = 1;
            SystemConstant.skipamount = 1;
            _ = LoadListAsync();
        }

        private void datalist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var proveedor = datalist.Rows[e.RowIndex].DataBoundItem as ProveedorDto;

            if (proveedor == null)
                return;

            MessageBox.Show(
                $"Código: {proveedor.Codigo}\n" +
                $"Razón social: {proveedor.RazonSocial}\n" +
                $"CUIT/CUIL: {proveedor.Cuit_Cuil}\n" +
                $"Email: {proveedor.Email}\n" +
                $"Teléfono: {proveedor.Telefono}\n" +
                $"Dirección: {proveedor.Direccion}\n" +
                $"Web: {proveedor.Web}",
                "Proveedor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private async void btnFirst_Click(object sender, EventArgs e)
        {
            if (SystemConstant.pageactual <= 1)
                return;

            SystemConstant.pageactual = 1;
            SystemConstant.skipamount = 1;
            await LoadListAsync();
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (SystemConstant.pageactual <= 1)
                return;

            SystemConstant.pageactual--;
            SystemConstant.skipamount--;
            await LoadListAsync();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (SystemConstant.pageactual >= SystemConstant.page)
                return;

            SystemConstant.pageactual++;
            SystemConstant.skipamount++;
            await LoadListAsync();
        }

        private async void btnLast_Click(object sender, EventArgs e)
        {
            if (count <= 0)
                return;

            SystemConstant.page = Math.Ceiling(
                (decimal)count / SystemConstant.pagesize);
            SystemConstant.pageactual = Convert.ToInt32(SystemConstant.page);
            SystemConstant.skipamount = SystemConstant.pageactual;
            await LoadListAsync();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
