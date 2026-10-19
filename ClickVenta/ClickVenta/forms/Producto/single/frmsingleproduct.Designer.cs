namespace ClickVenta.Producto.single
{
    partial class frmsingleproduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            btnclose = new Button();
            label3 = new Label();
            groupBox3 = new GroupBox();
            clickVentaButton1 = new ClickVenta.CustomStyle.ClickVentaButton();
            btnempleado = new ClickVenta.CustomStyle.ClickVentaButton();
            groupBox1 = new GroupBox();
            dtfechavenc = new DateTimePicker();
            label11 = new Label();
            txtstock = new CustomControls.RJControls.ClickVentaTextBox();
            label10 = new Label();
            cvcbproveedor = new ClickVenta.CustomStyle.ClickVentaComboBox();
            label8 = new Label();
            cvcbcategoria = new ClickVenta.CustomStyle.ClickVentaComboBox();
            cvcbpresentacion = new ClickVenta.CustomStyle.ClickVentaComboBox();
            label7 = new Label();
            label9 = new Label();
            txtid = new CustomControls.RJControls.ClickVentaTextBox();
            txtprecioventa = new CustomControls.RJControls.ClickVentaTextBox();
            txtpreciocompra = new CustomControls.RJControls.ClickVentaTextBox();
            txtdescripcion = new CustomControls.RJControls.ClickVentaTextBox();
            txtnombre = new CustomControls.RJControls.ClickVentaTextBox();
            txtcodigobarra = new CustomControls.RJControls.ClickVentaTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnclose);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 51);
            panel1.TabIndex = 21;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.FromArgb(128, 128, 255);
            btnclose.Dock = DockStyle.Right;
            btnclose.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnclose.ForeColor = Color.White;
            btnclose.ImageAlign = ContentAlignment.MiddleLeft;
            btnclose.Location = new Point(1025, 0);
            btnclose.Margin = new Padding(2, 3, 2, 3);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(40, 51);
            btnclose.TabIndex = 24;
            btnclose.Text = "X";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(257, 39);
            label3.TabIndex = 9;
            label3.Text = "Crear producto";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(clickVentaButton1);
            groupBox3.Controls.Add(btnempleado);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 532);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1065, 86);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Accion";
            // 
            // clickVentaButton1
            // 
            clickVentaButton1.BackColor = Color.Silver;
            clickVentaButton1.BorderColor = Color.Silver;
            clickVentaButton1.BorderRadius = 5;
            clickVentaButton1.BorderSize = 0;
            clickVentaButton1.FlatAppearance.BorderSize = 0;
            clickVentaButton1.FlatStyle = FlatStyle.Flat;
            clickVentaButton1.ForeColor = Color.White;
            clickVentaButton1.Location = new Point(674, 26);
            clickVentaButton1.Name = "clickVentaButton1";
            clickVentaButton1.Size = new Size(183, 43);
            clickVentaButton1.TabIndex = 5;
            clickVentaButton1.Text = "Cancelar";
            clickVentaButton1.TextColor = Color.White;
            clickVentaButton1.UseVisualStyleBackColor = false;
            // 
            // btnempleado
            // 
            btnempleado.BackColor = Color.FromArgb(128, 128, 255);
            btnempleado.BorderColor = Color.FromArgb(128, 128, 255);
            btnempleado.BorderRadius = 5;
            btnempleado.BorderSize = 0;
            btnempleado.FlatAppearance.BorderSize = 0;
            btnempleado.FlatStyle = FlatStyle.Flat;
            btnempleado.ForeColor = Color.White;
            btnempleado.Location = new Point(863, 26);
            btnempleado.Name = "btnempleado";
            btnempleado.Size = new Size(183, 43);
            btnempleado.TabIndex = 4;
            btnempleado.Text = "Aceptar";
            btnempleado.TextColor = Color.White;
            btnempleado.UseVisualStyleBackColor = false;
            btnempleado.Click += btnempleado_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtfechavenc);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtstock);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cvcbproveedor);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cvcbcategoria);
            groupBox1.Controls.Add(cvcbpresentacion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(txtprecioventa);
            groupBox1.Controls.Add(txtpreciocompra);
            groupBox1.Controls.Add(txtdescripcion);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(txtcodigobarra);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1065, 447);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos empleados";
            // 
            // dtfechavenc
            // 
            dtfechavenc.Format = DateTimePickerFormat.Short;
            dtfechavenc.Location = new Point(686, 134);
            dtfechavenc.Name = "dtfechavenc";
            dtfechavenc.Size = new Size(256, 27);
            dtfechavenc.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(565, 134);
            label11.Name = "label11";
            label11.Size = new Size(59, 25);
            label11.TabIndex = 26;
            label11.Text = "Stock";
            // 
            // txtstock
            // 
            txtstock.BackColor = SystemColors.Window;
            txtstock.BorderColor = Color.MediumSlateBlue;
            txtstock.BorderFocusColor = Color.HotPink;
            txtstock.BorderRadius = 5;
            txtstock.BorderSize = 2;
            txtstock.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstock.ForeColor = Color.FromArgb(64, 64, 64);
            txtstock.Location = new Point(145, 126);
            txtstock.Margin = new Padding(4);
            txtstock.Multiline = false;
            txtstock.Name = "txtstock";
            txtstock.Padding = new Padding(10, 7, 10, 7);
            txtstock.PasswordChar = false;
            txtstock.PlaceholderColor = Color.DarkGray;
            txtstock.PlaceholderText = "";
            txtstock.Size = new Size(234, 35);
            txtstock.TabIndex = 25;
            txtstock.Texts = "";
            txtstock.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.Location = new Point(12, 136);
            label10.Name = "label10";
            label10.Size = new Size(59, 25);
            label10.TabIndex = 24;
            label10.Text = "Stock";
            // 
            // cvcbproveedor
            // 
            cvcbproveedor.AutoCompleteCustomSource.AddRange(new string[] { "Seleccionar un proveedor" });
            cvcbproveedor.BackColor = Color.WhiteSmoke;
            cvcbproveedor.BorderColor = Color.MediumSlateBlue;
            cvcbproveedor.BorderSize = 1;
            cvcbproveedor.DropDownStyle = ComboBoxStyle.DropDown;
            cvcbproveedor.Font = new Font("Segoe UI", 10F);
            cvcbproveedor.ForeColor = Color.DimGray;
            cvcbproveedor.IconColor = Color.MediumSlateBlue;
            cvcbproveedor.Items.AddRange(new object[] { "Seleccionar presentacion" });
            cvcbproveedor.ListBackColor = Color.FromArgb(230, 228, 245);
            cvcbproveedor.ListTextColor = Color.DimGray;
            cvcbproveedor.Location = new Point(686, 175);
            cvcbproveedor.MinimumSize = new Size(200, 30);
            cvcbproveedor.Name = "cvcbproveedor";
            cvcbproveedor.Padding = new Padding(1);
            cvcbproveedor.Size = new Size(360, 36);
            cvcbproveedor.TabIndex = 23;
            cvcbproveedor.Texts = "Seleccionar un proveedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(563, 186);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 22;
            label8.Text = "Proveedor";
            // 
            // cvcbcategoria
            // 
            cvcbcategoria.AutoCompleteCustomSource.AddRange(new string[] { "Seleccionar la categoria" });
            cvcbcategoria.BackColor = Color.WhiteSmoke;
            cvcbcategoria.BorderColor = Color.MediumSlateBlue;
            cvcbcategoria.BorderSize = 1;
            cvcbcategoria.DropDownStyle = ComboBoxStyle.DropDown;
            cvcbcategoria.Font = new Font("Segoe UI", 10F);
            cvcbcategoria.ForeColor = Color.DimGray;
            cvcbcategoria.IconColor = Color.MediumSlateBlue;
            cvcbcategoria.Items.AddRange(new object[] { "Seleccionar presentacion" });
            cvcbcategoria.ListBackColor = Color.FromArgb(230, 228, 245);
            cvcbcategoria.ListTextColor = Color.DimGray;
            cvcbcategoria.Location = new Point(145, 175);
            cvcbcategoria.MinimumSize = new Size(200, 30);
            cvcbcategoria.Name = "cvcbcategoria";
            cvcbcategoria.Padding = new Padding(1);
            cvcbcategoria.Size = new Size(388, 36);
            cvcbcategoria.TabIndex = 21;
            cvcbcategoria.Texts = "Seleccionar la categoria";
            // 
            // cvcbpresentacion
            // 
            cvcbpresentacion.AutoCompleteCustomSource.AddRange(new string[] { "Seleccionar el permiso que desee dar al usuario" });
            cvcbpresentacion.BackColor = Color.WhiteSmoke;
            cvcbpresentacion.BorderColor = Color.MediumSlateBlue;
            cvcbpresentacion.BorderSize = 1;
            cvcbpresentacion.DropDownStyle = ComboBoxStyle.DropDown;
            cvcbpresentacion.Font = new Font("Segoe UI", 10F);
            cvcbpresentacion.ForeColor = Color.DimGray;
            cvcbpresentacion.IconColor = Color.MediumSlateBlue;
            cvcbpresentacion.Items.AddRange(new object[] { "Seleccionar presentacion" });
            cvcbpresentacion.ListBackColor = Color.FromArgb(230, 228, 245);
            cvcbpresentacion.ListTextColor = Color.DimGray;
            cvcbpresentacion.Location = new Point(145, 228);
            cvcbpresentacion.MinimumSize = new Size(200, 30);
            cvcbpresentacion.Name = "cvcbpresentacion";
            cvcbpresentacion.Padding = new Padding(1);
            cvcbpresentacion.Size = new Size(388, 36);
            cvcbpresentacion.TabIndex = 20;
            cvcbpresentacion.Texts = "Seleccionar presentacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(12, 239);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 19;
            label7.Text = "Presentacion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(12, 186);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 17;
            label9.Text = "Categoria";
            // 
            // txtid
            // 
            txtid.BackColor = SystemColors.Window;
            txtid.BorderColor = Color.MediumSlateBlue;
            txtid.BorderFocusColor = Color.HotPink;
            txtid.BorderRadius = 5;
            txtid.BorderSize = 2;
            txtid.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.ForeColor = Color.FromArgb(64, 64, 64);
            txtid.Location = new Point(530, 311);
            txtid.Margin = new Padding(4);
            txtid.Multiline = false;
            txtid.Name = "txtid";
            txtid.Padding = new Padding(10, 7, 10, 7);
            txtid.PasswordChar = false;
            txtid.PlaceholderColor = Color.DarkGray;
            txtid.PlaceholderText = "";
            txtid.Size = new Size(312, 35);
            txtid.TabIndex = 14;
            txtid.Texts = "";
            txtid.UnderlinedStyle = false;
            txtid.Visible = false;
            // 
            // txtprecioventa
            // 
            txtprecioventa.BackColor = SystemColors.Window;
            txtprecioventa.BorderColor = Color.MediumSlateBlue;
            txtprecioventa.BorderFocusColor = Color.HotPink;
            txtprecioventa.BorderRadius = 5;
            txtprecioventa.BorderSize = 2;
            txtprecioventa.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprecioventa.ForeColor = Color.FromArgb(64, 64, 64);
            txtprecioventa.Location = new Point(686, 81);
            txtprecioventa.Margin = new Padding(4);
            txtprecioventa.Multiline = false;
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Padding = new Padding(10, 7, 10, 7);
            txtprecioventa.PasswordChar = false;
            txtprecioventa.PlaceholderColor = Color.DarkGray;
            txtprecioventa.PlaceholderText = "";
            txtprecioventa.Size = new Size(206, 35);
            txtprecioventa.TabIndex = 13;
            txtprecioventa.Texts = "";
            txtprecioventa.UnderlinedStyle = false;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.BackColor = SystemColors.Window;
            txtpreciocompra.BorderColor = Color.MediumSlateBlue;
            txtpreciocompra.BorderFocusColor = Color.HotPink;
            txtpreciocompra.BorderRadius = 5;
            txtpreciocompra.BorderSize = 2;
            txtpreciocompra.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpreciocompra.ForeColor = Color.FromArgb(64, 64, 64);
            txtpreciocompra.Location = new Point(145, 81);
            txtpreciocompra.Margin = new Padding(4);
            txtpreciocompra.Multiline = false;
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Padding = new Padding(10, 7, 10, 7);
            txtpreciocompra.PasswordChar = false;
            txtpreciocompra.PlaceholderColor = Color.DarkGray;
            txtpreciocompra.PlaceholderText = "";
            txtpreciocompra.Size = new Size(234, 35);
            txtpreciocompra.TabIndex = 12;
            txtpreciocompra.Texts = "";
            txtpreciocompra.UnderlinedStyle = false;
            // 
            // txtdescripcion
            // 
            txtdescripcion.BackColor = SystemColors.Window;
            txtdescripcion.BorderColor = Color.MediumSlateBlue;
            txtdescripcion.BorderFocusColor = Color.HotPink;
            txtdescripcion.BorderRadius = 5;
            txtdescripcion.BorderSize = 2;
            txtdescripcion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtdescripcion.Location = new Point(145, 285);
            txtdescripcion.Margin = new Padding(4);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Padding = new Padding(10, 7, 10, 7);
            txtdescripcion.PasswordChar = false;
            txtdescripcion.PlaceholderColor = Color.DarkGray;
            txtdescripcion.PlaceholderText = "";
            txtdescripcion.Size = new Size(312, 127);
            txtdescripcion.TabIndex = 11;
            txtdescripcion.Texts = "";
            txtdescripcion.UnderlinedStyle = false;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = SystemColors.Window;
            txtnombre.BorderColor = Color.MediumSlateBlue;
            txtnombre.BorderFocusColor = Color.HotPink;
            txtnombre.BorderRadius = 5;
            txtnombre.BorderSize = 2;
            txtnombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtnombre.Location = new Point(686, 38);
            txtnombre.Margin = new Padding(4);
            txtnombre.Multiline = false;
            txtnombre.Name = "txtnombre";
            txtnombre.Padding = new Padding(10, 7, 10, 7);
            txtnombre.PasswordChar = false;
            txtnombre.PlaceholderColor = Color.DarkGray;
            txtnombre.PlaceholderText = "";
            txtnombre.Size = new Size(366, 35);
            txtnombre.TabIndex = 10;
            txtnombre.Texts = "";
            txtnombre.UnderlinedStyle = false;
            // 
            // txtcodigobarra
            // 
            txtcodigobarra.BackColor = SystemColors.Window;
            txtcodigobarra.BorderColor = Color.MediumSlateBlue;
            txtcodigobarra.BorderFocusColor = Color.HotPink;
            txtcodigobarra.BorderRadius = 5;
            txtcodigobarra.BorderSize = 2;
            txtcodigobarra.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcodigobarra.ForeColor = Color.FromArgb(64, 64, 64);
            txtcodigobarra.Location = new Point(145, 38);
            txtcodigobarra.Margin = new Padding(4);
            txtcodigobarra.Multiline = false;
            txtcodigobarra.Name = "txtcodigobarra";
            txtcodigobarra.Padding = new Padding(10, 7, 10, 7);
            txtcodigobarra.PasswordChar = false;
            txtcodigobarra.PlaceholderColor = Color.DarkGray;
            txtcodigobarra.PlaceholderText = "";
            txtcodigobarra.Size = new Size(413, 35);
            txtcodigobarra.TabIndex = 9;
            txtcodigobarra.Texts = "";
            txtcodigobarra.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(561, 91);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 8;
            label6.Text = "Precio venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(12, 91);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 6;
            label5.Text = "Precio compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(11, 336);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 4;
            label4.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(565, 48);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(11, 48);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Codigo barra";
            // 
            // frmsingleproduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 618);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmsingleproduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Producto";
            Load += frmsingleproduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private GroupBox groupBox3;
        private CustomStyle.ClickVentaButton clickVentaButton1;
        private CustomStyle.ClickVentaButton btnempleado;
        private GroupBox groupBox1;
        private CustomControls.RJControls.ClickVentaTextBox txtid;
        private CustomControls.RJControls.ClickVentaTextBox txtprecioventa;
        private CustomControls.RJControls.ClickVentaTextBox txtpreciocompra;
        private CustomControls.RJControls.ClickVentaTextBox txtdescripcion;
        private CustomControls.RJControls.ClickVentaTextBox txtnombre;
        private CustomControls.RJControls.ClickVentaTextBox txtcodigobarra;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private CustomStyle.ClickVentaComboBox cvcbpresentacion;
        private Label label7;
        private Label label9;
        private CustomStyle.ClickVentaComboBox cvcbcategoria;
        private CustomStyle.ClickVentaComboBox cvcbproveedor;
        private Label label8;
        private CustomControls.RJControls.ClickVentaTextBox txtstock;
        private Label label10;
        private DateTimePicker dtfechavenc;
        private Label label11;
    }
}