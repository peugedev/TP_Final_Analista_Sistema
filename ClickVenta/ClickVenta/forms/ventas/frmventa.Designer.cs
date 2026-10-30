namespace ClickVenta.forms.ventas
{
    partial class frmventa
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
            panel1 = new Panel();
            btnclose = new Button();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblcantidad = new Label();
            lblusername = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblticket = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblcobrar = new Label();
            label9 = new Label();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblformapago = new Label();
            label12 = new Label();
            lbltotalultimoventa = new Label();
            label6 = new Label();
            datalist = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label14 = new Label();
            btncobrar = new ClickVenta.CustomStyle.ClickVentaButton();
            txtcodebar = new CustomControls.RJControls.ClickVentaTextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1023, 38);
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
            btnclose.Location = new Point(988, 0);
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
            label3.Size = new Size(267, 31);
            label3.TabIndex = 9;
            label3.Text = "Venta de productos";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.9566078F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.0433922F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            tableLayoutPanel1.Controls.Add(lblcantidad, 2, 1);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(lblusername, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblticket, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1023, 73);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.BackColor = SystemColors.ActiveCaptionText;
            lblcantidad.Dock = DockStyle.Fill;
            lblcantidad.FlatStyle = FlatStyle.Popup;
            lblcantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcantidad.ForeColor = SystemColors.ControlLightLight;
            lblcantidad.Location = new Point(908, 48);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(258, 49);
            lblcantidad.TabIndex = 6;
            lblcantidad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = SystemColors.ActiveCaptionText;
            lblusername.Dock = DockStyle.Fill;
            lblusername.FlatStyle = FlatStyle.Popup;
            lblusername.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = SystemColors.ControlLightLight;
            lblusername.Location = new Point(366, 36);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(422, 37);
            lblusername.TabIndex = 5;
            lblusername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(794, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 36);
            label4.TabIndex = 2;
            label4.Text = "Cantidad de productos";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(357, 36);
            label2.TabIndex = 1;
            label2.Text = "Nro. Ticket";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(366, 0);
            label1.Name = "label1";
            label1.Size = new Size(422, 36);
            label1.TabIndex = 0;
            label1.Text = "Cajero(a)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblticket
            // 
            lblticket.AutoSize = true;
            lblticket.BackColor = SystemColors.ActiveCaptionText;
            lblticket.Dock = DockStyle.Fill;
            lblticket.FlatStyle = FlatStyle.Popup;
            lblticket.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblticket.ForeColor = SystemColors.ControlLightLight;
            lblticket.Location = new Point(3, 36);
            lblticket.Name = "lblticket";
            lblticket.Size = new Size(357, 37);
            lblticket.TabIndex = 3;
            lblticket.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6592064F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.3407936F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 443F));
            tableLayoutPanel2.Controls.Add(lblcobrar, 2, 1);
            tableLayoutPanel2.Controls.Add(label9, 1, 1);
            tableLayoutPanel2.Controls.Add(checkBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 111);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel2.Size = new Size(1023, 67);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // lblcobrar
            // 
            lblcobrar.AutoSize = true;
            lblcobrar.BackColor = SystemColors.ActiveCaptionText;
            lblcobrar.Dock = DockStyle.Fill;
            lblcobrar.FlatStyle = FlatStyle.Popup;
            lblcobrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcobrar.ForeColor = SystemColors.ControlLightLight;
            lblcobrar.Location = new Point(728, 12);
            lblcobrar.Name = "lblcobrar";
            lblcobrar.Size = new Size(438, 77);
            lblcobrar.TabIndex = 9;
            lblcobrar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(369, 9);
            label9.Name = "label9";
            label9.Size = new Size(262, 58);
            label9.TabIndex = 8;
            label9.Text = "Total a cobrar";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Dock = DockStyle.Fill;
            checkBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(3, 12);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(360, 52);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "¿Imprimir ticket?";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1023, 64);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ultima venta";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.3924465F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.60755F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 382F));
            tableLayoutPanel3.Controls.Add(lblformapago, 3, 0);
            tableLayoutPanel3.Controls.Add(label12, 2, 0);
            tableLayoutPanel3.Controls.Add(lbltotalultimoventa, 1, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1017, 51);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // lblformapago
            // 
            lblformapago.AutoSize = true;
            lblformapago.BackColor = SystemColors.ActiveCaptionText;
            lblformapago.Dock = DockStyle.Fill;
            lblformapago.FlatStyle = FlatStyle.Popup;
            lblformapago.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblformapago.ForeColor = SystemColors.ControlLightLight;
            lblformapago.Location = new Point(637, 0);
            lblformapago.Name = "lblformapago";
            lblformapago.Size = new Size(377, 51);
            lblformapago.TabIndex = 12;
            lblformapago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label12.Location = new Point(438, 0);
            label12.Name = "label12";
            label12.Size = new Size(193, 51);
            label12.TabIndex = 11;
            label12.Text = "Forma de pago";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltotalultimoventa
            // 
            lbltotalultimoventa.AutoSize = true;
            lbltotalultimoventa.BackColor = SystemColors.ActiveCaptionText;
            lbltotalultimoventa.Dock = DockStyle.Fill;
            lbltotalultimoventa.FlatStyle = FlatStyle.Popup;
            lbltotalultimoventa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalultimoventa.ForeColor = SystemColors.ControlLightLight;
            lbltotalultimoventa.Location = new Point(131, 0);
            lbltotalultimoventa.Name = "lbltotalultimoventa";
            lbltotalultimoventa.Size = new Size(301, 51);
            lbltotalultimoventa.TabIndex = 10;
            lbltotalultimoventa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 51);
            label6.TabIndex = 9;
            label6.Text = "Total ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datalist
            // 
            datalist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datalist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalist.Columns.AddRange(new DataGridViewColumn[] { nombre, Cantidad, Precio, subtotal });
            datalist.Dock = DockStyle.Fill;
            datalist.Location = new Point(3, 24);
            datalist.Margin = new Padding(3, 4, 3, 4);
            datalist.Name = "datalist";
            datalist.RowHeadersWidth = 51;
            datalist.Size = new Size(1163, 409);
            datalist.TabIndex = 25;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // subtotal
            // 
            subtotal.DataPropertyName = "Subtotal";
            subtotal.HeaderText = "Subtotal";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(datalist);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1023, 328);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel4);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 567);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1023, 58);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2154541F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.7845459F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185F));
            tableLayoutPanel4.Controls.Add(label14, 0, 0);
            tableLayoutPanel4.Controls.Add(btncobrar, 2, 0);
            tableLayoutPanel4.Controls.Add(txtcodebar, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(3, 9);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1017, 46);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(286, 46);
            label14.TabIndex = 10;
            label14.Text = "Codigo de barra";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btncobrar
            // 
            btncobrar.BackColor = Color.FromArgb(128, 128, 255);
            btncobrar.BorderColor = Color.FromArgb(128, 128, 255);
            btncobrar.BorderRadius = 0;
            btncobrar.BorderSize = 0;
            btncobrar.Dock = DockStyle.Fill;
            btncobrar.FlatAppearance.BorderSize = 0;
            btncobrar.FlatStyle = FlatStyle.Flat;
            btncobrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncobrar.ForeColor = Color.White;
            btncobrar.Location = new Point(955, 4);
            btncobrar.Margin = new Padding(3, 4, 3, 4);
            btncobrar.Name = "btncobrar";
            btncobrar.Size = new Size(205, 53);
            btncobrar.TabIndex = 11;
            btncobrar.Text = "Cobrar";
            btncobrar.TextColor = Color.White;
            btncobrar.UseVisualStyleBackColor = false;
            // 
            // txtcodebar
            // 
            txtcodebar.BackColor = SystemColors.Window;
            txtcodebar.BorderColor = Color.MediumSlateBlue;
            txtcodebar.BorderFocusColor = Color.HotPink;
            txtcodebar.BorderRadius = 0;
            txtcodebar.BorderSize = 2;
            txtcodebar.Dock = DockStyle.Fill;
            txtcodebar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcodebar.ForeColor = Color.FromArgb(64, 64, 64);
            txtcodebar.Location = new Point(340, 5);
            txtcodebar.Margin = new Padding(5);
            txtcodebar.Multiline = true;
            txtcodebar.Name = "txtcodebar";
            txtcodebar.Padding = new Padding(11, 9, 11, 9);
            txtcodebar.PasswordChar = false;
            txtcodebar.PlaceholderColor = Color.DarkGray;
            txtcodebar.PlaceholderText = "";
            txtcodebar.RightToLeft = RightToLeft.Yes;
            txtcodebar.Size = new Size(607, 51);
            txtcodebar.TabIndex = 12;
            txtcodebar.Texts = "";
            txtcodebar.UnderlinedStyle = false;
            txtcodebar.KeyPress += clickVentaTextBox1_KeyPress;
            // 
            // frmventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 625);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmventa";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmventa_FormClosing;
            FormClosed += frmventa_FormClosed;
            Load += frmventa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblcantidad;
        private Label lblusername;
        private Label lblticket;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblcobrar;
        private Label label9;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblformapago;
        private Label label12;
        private Label lbltotalultimoventa;
        private Label label6;
        private DataGridView datalist;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label14;
        private CustomStyle.ClickVentaButton btncobrar;
        private CustomControls.RJControls.ClickVentaTextBox txtcodebar;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn subtotal;
    }
}