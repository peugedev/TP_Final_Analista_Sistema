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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 38);
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
            btnclose.Location = new Point(897, 0);
            btnclose.Margin = new Padding(2);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(35, 38);
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
            label3.Size = new Size(209, 31);
            label3.TabIndex = 9;
            label3.Text = "Crear producto";
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 400);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(932, 64);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Accion";
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(0, 38);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(932, 335);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos empleados";
            // 
            // dtfechavenc
            // 
            dtfechavenc.Format = DateTimePickerFormat.Short;
            dtfechavenc.Location = new Point(600, 100);
            dtfechavenc.Margin = new Padding(3, 2, 3, 2);
            dtfechavenc.Name = "dtfechavenc";
            dtfechavenc.Size = new Size(224, 23);
            dtfechavenc.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(494, 100);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 26;
            label11.Text = "Stock";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.Location = new Point(10, 102);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 24;
            label10.Text = "Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(493, 140);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 22;
            label8.Text = "Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(10, 179);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 19;
            label7.Text = "Presentacion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(10, 140);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 17;
            label9.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(491, 68);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 8;
            label6.Text = "Precio venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(10, 68);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 6;
            label5.Text = "Precio compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(10, 252);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(494, 36);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo barra";
            // 
            // frmsingleproduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 464);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}