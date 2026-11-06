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
            groupBox1 = new GroupBox();
            clickVentaComboBox3 = new ClickVenta.CustomStyle.ClickVentaComboBox();
            clickVentaComboBox2 = new ClickVenta.CustomStyle.ClickVentaComboBox();
            clickVentaComboBox1 = new ClickVenta.CustomStyle.ClickVentaComboBox();
            clickVentaTextBox6 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox5 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox4 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox3 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox2 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox1 = new CustomControls.RJControls.ClickVentaTextBox();
            dtfechavenc = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
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
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 561);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1065, 58);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Accion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clickVentaComboBox3);
            groupBox1.Controls.Add(clickVentaComboBox2);
            groupBox1.Controls.Add(clickVentaComboBox1);
            groupBox1.Controls.Add(clickVentaTextBox6);
            groupBox1.Controls.Add(clickVentaTextBox5);
            groupBox1.Controls.Add(clickVentaTextBox4);
            groupBox1.Controls.Add(clickVentaTextBox3);
            groupBox1.Controls.Add(clickVentaTextBox2);
            groupBox1.Controls.Add(clickVentaTextBox1);
            groupBox1.Controls.Add(dtfechavenc);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
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
            // clickVentaComboBox3
            // 
            clickVentaComboBox3.BackColor = Color.WhiteSmoke;
            clickVentaComboBox3.BorderColor = Color.MediumSlateBlue;
            clickVentaComboBox3.BorderSize = 1;
            clickVentaComboBox3.DropDownStyle = ComboBoxStyle.DropDown;
            clickVentaComboBox3.Font = new Font("Segoe UI", 10F);
            clickVentaComboBox3.ForeColor = Color.DimGray;
            clickVentaComboBox3.IconColor = Color.MediumSlateBlue;
            clickVentaComboBox3.ListBackColor = Color.FromArgb(230, 228, 245);
            clickVentaComboBox3.ListTextColor = Color.DimGray;
            clickVentaComboBox3.Location = new Point(191, 239);
            clickVentaComboBox3.MinimumSize = new Size(200, 30);
            clickVentaComboBox3.Name = "clickVentaComboBox3";
            clickVentaComboBox3.Padding = new Padding(1);
            clickVentaComboBox3.Size = new Size(312, 30);
            clickVentaComboBox3.TabIndex = 36;
            clickVentaComboBox3.Texts = "";
            // 
            // clickVentaComboBox2
            // 
            clickVentaComboBox2.BackColor = Color.WhiteSmoke;
            clickVentaComboBox2.BorderColor = Color.MediumSlateBlue;
            clickVentaComboBox2.BorderSize = 1;
            clickVentaComboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            clickVentaComboBox2.Font = new Font("Segoe UI", 10F);
            clickVentaComboBox2.ForeColor = Color.DimGray;
            clickVentaComboBox2.IconColor = Color.MediumSlateBlue;
            clickVentaComboBox2.ListBackColor = Color.FromArgb(230, 228, 245);
            clickVentaComboBox2.ListTextColor = Color.DimGray;
            clickVentaComboBox2.Location = new Point(191, 182);
            clickVentaComboBox2.MinimumSize = new Size(200, 30);
            clickVentaComboBox2.Name = "clickVentaComboBox2";
            clickVentaComboBox2.Padding = new Padding(1);
            clickVentaComboBox2.Size = new Size(312, 30);
            clickVentaComboBox2.TabIndex = 35;
            clickVentaComboBox2.Texts = "";
            // 
            // clickVentaComboBox1
            // 
            clickVentaComboBox1.BackColor = Color.WhiteSmoke;
            clickVentaComboBox1.BorderColor = Color.MediumSlateBlue;
            clickVentaComboBox1.BorderSize = 1;
            clickVentaComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            clickVentaComboBox1.Font = new Font("Segoe UI", 10F);
            clickVentaComboBox1.ForeColor = Color.DimGray;
            clickVentaComboBox1.IconColor = Color.MediumSlateBlue;
            clickVentaComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            clickVentaComboBox1.ListTextColor = Color.DimGray;
            clickVentaComboBox1.Location = new Point(702, 182);
            clickVentaComboBox1.MinimumSize = new Size(200, 30);
            clickVentaComboBox1.Name = "clickVentaComboBox1";
            clickVentaComboBox1.Padding = new Padding(1);
            clickVentaComboBox1.Size = new Size(312, 30);
            clickVentaComboBox1.TabIndex = 34;
            clickVentaComboBox1.Texts = "";
            // 
            // clickVentaTextBox6
            // 
            clickVentaTextBox6.BackColor = SystemColors.Window;
            clickVentaTextBox6.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox6.BorderFocusColor = Color.HotPink;
            clickVentaTextBox6.BorderRadius = 0;
            clickVentaTextBox6.BorderSize = 2;
            clickVentaTextBox6.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox6.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox6.Location = new Point(702, 80);
            clickVentaTextBox6.Margin = new Padding(4);
            clickVentaTextBox6.Multiline = false;
            clickVentaTextBox6.Name = "clickVentaTextBox6";
            clickVentaTextBox6.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox6.PasswordChar = false;
            clickVentaTextBox6.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox6.PlaceholderText = "";
            clickVentaTextBox6.Size = new Size(312, 35);
            clickVentaTextBox6.TabIndex = 33;
            clickVentaTextBox6.Texts = "";
            clickVentaTextBox6.UnderlinedStyle = false;
            // 
            // clickVentaTextBox5
            // 
            clickVentaTextBox5.BackColor = SystemColors.Window;
            clickVentaTextBox5.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox5.BorderFocusColor = Color.HotPink;
            clickVentaTextBox5.BorderRadius = 0;
            clickVentaTextBox5.BorderSize = 2;
            clickVentaTextBox5.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox5.Location = new Point(191, 326);
            clickVentaTextBox5.Margin = new Padding(4);
            clickVentaTextBox5.Multiline = true;
            clickVentaTextBox5.Name = "clickVentaTextBox5";
            clickVentaTextBox5.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox5.PasswordChar = false;
            clickVentaTextBox5.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox5.PlaceholderText = "";
            clickVentaTextBox5.Size = new Size(312, 114);
            clickVentaTextBox5.TabIndex = 32;
            clickVentaTextBox5.Texts = "";
            clickVentaTextBox5.UnderlinedStyle = false;
            // 
            // clickVentaTextBox4
            // 
            clickVentaTextBox4.BackColor = SystemColors.Window;
            clickVentaTextBox4.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox4.BorderFocusColor = Color.HotPink;
            clickVentaTextBox4.BorderRadius = 0;
            clickVentaTextBox4.BorderSize = 2;
            clickVentaTextBox4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox4.Location = new Point(191, 123);
            clickVentaTextBox4.Margin = new Padding(4);
            clickVentaTextBox4.Multiline = false;
            clickVentaTextBox4.Name = "clickVentaTextBox4";
            clickVentaTextBox4.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox4.PasswordChar = false;
            clickVentaTextBox4.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox4.PlaceholderText = "";
            clickVentaTextBox4.Size = new Size(312, 35);
            clickVentaTextBox4.TabIndex = 31;
            clickVentaTextBox4.Texts = "";
            clickVentaTextBox4.UnderlinedStyle = false;
            // 
            // clickVentaTextBox3
            // 
            clickVentaTextBox3.BackColor = SystemColors.Window;
            clickVentaTextBox3.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox3.BorderFocusColor = Color.HotPink;
            clickVentaTextBox3.BorderRadius = 0;
            clickVentaTextBox3.BorderSize = 2;
            clickVentaTextBox3.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox3.Location = new Point(191, 81);
            clickVentaTextBox3.Margin = new Padding(4);
            clickVentaTextBox3.Multiline = false;
            clickVentaTextBox3.Name = "clickVentaTextBox3";
            clickVentaTextBox3.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox3.PasswordChar = false;
            clickVentaTextBox3.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox3.PlaceholderText = "";
            clickVentaTextBox3.Size = new Size(312, 35);
            clickVentaTextBox3.TabIndex = 30;
            clickVentaTextBox3.Texts = "";
            clickVentaTextBox3.UnderlinedStyle = false;
            // 
            // clickVentaTextBox2
            // 
            clickVentaTextBox2.BackColor = SystemColors.Window;
            clickVentaTextBox2.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox2.BorderFocusColor = Color.HotPink;
            clickVentaTextBox2.BorderRadius = 0;
            clickVentaTextBox2.BorderSize = 2;
            clickVentaTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox2.Location = new Point(191, 38);
            clickVentaTextBox2.Margin = new Padding(4);
            clickVentaTextBox2.Multiline = false;
            clickVentaTextBox2.Name = "clickVentaTextBox2";
            clickVentaTextBox2.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox2.PasswordChar = false;
            clickVentaTextBox2.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox2.PlaceholderText = "";
            clickVentaTextBox2.Size = new Size(312, 35);
            clickVentaTextBox2.TabIndex = 29;
            clickVentaTextBox2.Texts = "";
            clickVentaTextBox2.UnderlinedStyle = false;
            // 
            // clickVentaTextBox1
            // 
            clickVentaTextBox1.BackColor = SystemColors.Window;
            clickVentaTextBox1.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox1.BorderFocusColor = Color.HotPink;
            clickVentaTextBox1.BorderRadius = 0;
            clickVentaTextBox1.BorderSize = 2;
            clickVentaTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox1.Location = new Point(702, 37);
            clickVentaTextBox1.Margin = new Padding(4);
            clickVentaTextBox1.Multiline = false;
            clickVentaTextBox1.Name = "clickVentaTextBox1";
            clickVentaTextBox1.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox1.PasswordChar = false;
            clickVentaTextBox1.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox1.PlaceholderText = "";
            clickVentaTextBox1.Size = new Size(312, 35);
            clickVentaTextBox1.TabIndex = 28;
            clickVentaTextBox1.Texts = "";
            clickVentaTextBox1.UnderlinedStyle = false;
            // 
            // dtfechavenc
            // 
            dtfechavenc.Format = DateTimePickerFormat.Short;
            dtfechavenc.Location = new Point(702, 131);
            dtfechavenc.Name = "dtfechavenc";
            dtfechavenc.Size = new Size(255, 27);
            dtfechavenc.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(565, 133);
            label11.Name = "label11";
            label11.Size = new Size(111, 25);
            label11.TabIndex = 26;
            label11.Text = "Fecha venc.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.Location = new Point(11, 136);
            label10.Name = "label10";
            label10.Size = new Size(59, 25);
            label10.TabIndex = 24;
            label10.Text = "Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(563, 187);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 22;
            label8.Text = "Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(11, 239);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 19;
            label7.Text = "Presentacion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(11, 187);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 17;
            label9.Text = "Categoria";
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
            label5.Location = new Point(11, 91);
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
            ClientSize = new Size(1065, 619);
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
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox6;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox5;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox4;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox3;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox2;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox1;
        private CustomStyle.ClickVentaComboBox clickVentaComboBox3;
        private CustomStyle.ClickVentaComboBox clickVentaComboBox2;
        private CustomStyle.ClickVentaComboBox clickVentaComboBox1;
    }
}