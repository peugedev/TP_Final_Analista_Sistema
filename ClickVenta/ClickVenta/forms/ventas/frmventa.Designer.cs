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
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label10 = new Label();
            label9 = new Label();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label14 = new Label();
            clickVentaButton1 = new ClickVenta.CustomStyle.ClickVentaButton();
            clickVentaTextBox1 = new CustomControls.RJControls.ClickVentaTextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 51);
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
            btnclose.Location = new Point(1129, 0);
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
            label3.Size = new Size(329, 39);
            label3.TabIndex = 9;
            label3.Text = "Venta de productos";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.9566078F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.0433922F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label7, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 51);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1169, 97);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Dock = DockStyle.Fill;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(908, 48);
            label8.Name = "label8";
            label8.Size = new Size(258, 49);
            label8.TabIndex = 6;
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Dock = DockStyle.Fill;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(419, 48);
            label7.Name = "label7";
            label7.Size = new Size(483, 49);
            label7.TabIndex = 5;
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(908, 0);
            label4.Name = "label4";
            label4.Size = new Size(258, 48);
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
            label2.Size = new Size(410, 48);
            label2.TabIndex = 1;
            label2.Text = "Nro. Ticket";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(419, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 48);
            label1.TabIndex = 0;
            label1.Text = "Cajero(a)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Dock = DockStyle.Fill;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(3, 48);
            label5.Name = "label5";
            label5.Size = new Size(410, 49);
            label5.TabIndex = 3;
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6592064F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.3407936F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 443F));
            tableLayoutPanel2.Controls.Add(label10, 2, 1);
            tableLayoutPanel2.Controls.Add(label9, 1, 1);
            tableLayoutPanel2.Controls.Add(checkBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 148);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel2.Size = new Size(1169, 89);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.Dock = DockStyle.Fill;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(728, 12);
            label10.Name = "label10";
            label10.Size = new Size(438, 77);
            label10.TabIndex = 9;
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(421, 12);
            label9.Name = "label9";
            label9.Size = new Size(301, 77);
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
            checkBox2.Location = new Point(3, 16);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(412, 69);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "¿Imprimir ticket?";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 237);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1169, 85);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ultima venta";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.3924465F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.60755F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 227F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 435F));
            tableLayoutPanel3.Controls.Add(label13, 3, 0);
            tableLayoutPanel3.Controls.Add(label12, 2, 0);
            tableLayoutPanel3.Controls.Add(label11, 1, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1163, 68);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Dock = DockStyle.Fill;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(730, 0);
            label13.Name = "label13";
            label13.Size = new Size(430, 68);
            label13.TabIndex = 12;
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label12.Location = new Point(503, 0);
            label12.Name = "label12";
            label12.Size = new Size(221, 68);
            label12.TabIndex = 11;
            label12.Text = "Forma de pago";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.Dock = DockStyle.Fill;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(150, 0);
            label11.Name = "label11";
            label11.Size = new Size(347, 68);
            label11.TabIndex = 10;
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 68);
            label6.TabIndex = 9;
            label6.Text = "Total ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, Cantidad, precioVenta, subtotal });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1163, 409);
            dataGridView1.TabIndex = 25;
            // 
            // nombre
            // 
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
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 322);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1169, 437);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel4);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 756);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1169, 77);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2154541F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.7845459F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tableLayoutPanel4.Controls.Add(label14, 0, 0);
            tableLayoutPanel4.Controls.Add(clickVentaButton1, 2, 0);
            tableLayoutPanel4.Controls.Add(clickVentaTextBox1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(3, 12);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1163, 61);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(329, 61);
            label14.TabIndex = 10;
            label14.Text = "Codigo de barra";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clickVentaButton1
            // 
            clickVentaButton1.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton1.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton1.BorderRadius = 0;
            clickVentaButton1.BorderSize = 0;
            clickVentaButton1.Dock = DockStyle.Fill;
            clickVentaButton1.FlatAppearance.BorderSize = 0;
            clickVentaButton1.FlatStyle = FlatStyle.Flat;
            clickVentaButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickVentaButton1.ForeColor = Color.White;
            clickVentaButton1.Location = new Point(955, 4);
            clickVentaButton1.Margin = new Padding(3, 4, 3, 4);
            clickVentaButton1.Name = "clickVentaButton1";
            clickVentaButton1.Size = new Size(205, 53);
            clickVentaButton1.TabIndex = 11;
            clickVentaButton1.Text = "Cobrar";
            clickVentaButton1.TextColor = Color.White;
            clickVentaButton1.UseVisualStyleBackColor = false;
            // 
            // clickVentaTextBox1
            // 
            clickVentaTextBox1.BackColor = SystemColors.Window;
            clickVentaTextBox1.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox1.BorderFocusColor = Color.HotPink;
            clickVentaTextBox1.BorderRadius = 0;
            clickVentaTextBox1.BorderSize = 2;
            clickVentaTextBox1.Dock = DockStyle.Fill;
            clickVentaTextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickVentaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox1.Location = new Point(340, 5);
            clickVentaTextBox1.Margin = new Padding(5);
            clickVentaTextBox1.Multiline = true;
            clickVentaTextBox1.Name = "clickVentaTextBox1";
            clickVentaTextBox1.Padding = new Padding(11, 9, 11, 9);
            clickVentaTextBox1.PasswordChar = false;
            clickVentaTextBox1.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox1.PlaceholderText = "";
            clickVentaTextBox1.RightToLeft = RightToLeft.Yes;
            clickVentaTextBox1.Size = new Size(607, 51);
            clickVentaTextBox1.TabIndex = 12;
            clickVentaTextBox1.Texts = "";
            clickVentaTextBox1.UnderlinedStyle = false;
            // 
            // frmventa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 833);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmventa";
            StartPosition = FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label8;
        private Label label7;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private Label label9;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label6;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label14;
        private CustomStyle.ClickVentaButton clickVentaButton1;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn subtotal;
    }
}