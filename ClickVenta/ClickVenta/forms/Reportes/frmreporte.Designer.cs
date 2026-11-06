namespace ClickVenta.forms.Reportes
{
    partial class frmreporte
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
            groupBox5 = new GroupBox();
            label12 = new Label();
            lblTotal = new Label();
            lblStatus = new Label();
            btnNext = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            datalist = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            clickVentaButton1 = new ClickVenta.CustomStyle.ClickVentaButton();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            panel1.Size = new Size(1180, 51);
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
            btnclose.Location = new Point(1140, 0);
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
            label3.Size = new Size(315, 39);
            label3.TabIndex = 9;
            label3.Text = "Gestion de reporte";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(lblTotal);
            groupBox5.Controls.Add(lblStatus);
            groupBox5.Controls.Add(btnNext);
            groupBox5.Controls.Add(btnLast);
            groupBox5.Controls.Add(btnPrevious);
            groupBox5.Controls.Add(btnFirst);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 594);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1174, 66);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.Location = new Point(824, 28);
            label12.Name = "label12";
            label12.Size = new Size(209, 27);
            label12.TabIndex = 8;
            label12.Text = " Cantidad de registros";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(1035, 25);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(120, 29);
            lblTotal.TabIndex = 7;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.FlatStyle = FlatStyle.Flat;
            lblStatus.Location = new Point(573, 21);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(150, 33);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "0 / 0";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top;
            btnNext.Location = new Point(732, 21);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(37, 35);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Top;
            btnLast.Location = new Point(771, 21);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(45, 35);
            btnLast.TabIndex = 2;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top;
            btnPrevious.Location = new Point(525, 21);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(37, 35);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Top;
            btnFirst.Location = new Point(480, 20);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(43, 35);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "|<";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // datalist
            // 
            datalist.AllowUserToAddRows = false;
            datalist.AllowUserToDeleteRows = false;
            datalist.AllowUserToResizeRows = false;
            datalist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datalist.BackgroundColor = Color.White;
            datalist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalist.Columns.AddRange(new DataGridViewColumn[] { Nombre, PrecioCompra, PrecioVenta });
            datalist.Cursor = Cursors.Hand;
            datalist.Dock = DockStyle.Fill;
            datalist.Location = new Point(3, 54);
            datalist.Name = "datalist";
            datalist.ReadOnly = true;
            datalist.RowHeadersWidth = 51;
            datalist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalist.Size = new Size(1174, 534);
            datalist.TabIndex = 19;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.DataPropertyName = "PrecioCompra";
            PrecioCompra.HeaderText = "Precio compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "Precio venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox5, 0, 2);
            tableLayoutPanel1.Controls.Add(datalist, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.629441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.37056F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.Size = new Size(1180, 663);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8823528F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.1176453F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 349F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel2.Controls.Add(dateTimePicker2, 3, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(clickVentaButton1, 4, 0);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1174, 45);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Bottom;
            dateTimePicker2.Location = new Point(652, 15);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(343, 27);
            dateTimePicker2.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(479, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 45);
            label2.TabIndex = 24;
            label2.Text = "Fecha hasta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 45);
            label1.TabIndex = 1;
            label1.Text = "Fecha desde";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clickVentaButton1
            // 
            clickVentaButton1.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton1.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton1.BorderRadius = 1;
            clickVentaButton1.BorderSize = 0;
            clickVentaButton1.Dock = DockStyle.Fill;
            clickVentaButton1.FlatAppearance.BorderSize = 0;
            clickVentaButton1.FlatStyle = FlatStyle.Flat;
            clickVentaButton1.ForeColor = Color.White;
            clickVentaButton1.Location = new Point(1001, 3);
            clickVentaButton1.Name = "clickVentaButton1";
            clickVentaButton1.Size = new Size(170, 39);
            clickVentaButton1.TabIndex = 22;
            clickVentaButton1.Text = "Filtrar";
            clickVentaButton1.TextColor = Color.White;
            clickVentaButton1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Bottom;
            dateTimePicker1.Location = new Point(150, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // frmreporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 714);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmreporte";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmreporte_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datalist).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private GroupBox groupBox5;
        private Label label12;
        private Label lblTotal;
        private Label lblStatus;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnFirst;
        private DataGridView datalist;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label1;
        private CustomStyle.ClickVentaButton clickVentaButton1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}