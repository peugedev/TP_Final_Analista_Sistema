namespace ClickVenta.forms.Producto
{
    partial class frmproducto
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
            tableLayoutPanel2 = new TableLayoutPanel();
            clickVentaButton3 = new ClickVenta.CustomStyle.ClickVentaButton();
            label1 = new Label();
            txtfilter = new TextBox();
            btnempleado = new ClickVenta.CustomStyle.ClickVentaButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).BeginInit();
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
            panel1.Size = new Size(1045, 51);
            panel1.TabIndex = 20;
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
            btnclose.Location = new Point(1005, 0);
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
            label3.Size = new Size(341, 39);
            label3.TabIndex = 9;
            label3.Text = "Gestion de producto";
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.88889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.1111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.Size = new Size(1045, 578);
            tableLayoutPanel1.TabIndex = 24;
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
            groupBox5.Location = new Point(3, 509);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1039, 66);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.Location = new Point(685, 28);
            label12.Name = "label12";
            label12.Size = new Size(209, 27);
            label12.TabIndex = 8;
            label12.Text = " Cantidad de registros";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(896, 25);
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
            lblStatus.Location = new Point(434, 21);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(150, 33);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "0 / 0";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top;
            btnNext.Location = new Point(593, 21);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(37, 35);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Top;
            btnLast.Location = new Point(632, 21);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(45, 35);
            btnLast.TabIndex = 2;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top;
            btnPrevious.Location = new Point(386, 21);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(37, 35);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Top;
            btnFirst.Location = new Point(341, 20);
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
            datalist.Location = new Point(3, 98);
            datalist.Name = "datalist";
            datalist.ReadOnly = true;
            datalist.RowHeadersWidth = 51;
            datalist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalist.Size = new Size(1039, 405);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.71233F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.28767F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutPanel2.Controls.Add(clickVentaButton3, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtfilter, 1, 0);
            tableLayoutPanel2.Controls.Add(btnempleado, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.Size = new Size(1039, 89);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // clickVentaButton3
            // 
            clickVentaButton3.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton3.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton3.BorderRadius = 1;
            clickVentaButton3.BorderSize = 0;
            clickVentaButton3.Dock = DockStyle.Fill;
            clickVentaButton3.FlatAppearance.BorderSize = 0;
            clickVentaButton3.FlatStyle = FlatStyle.Flat;
            clickVentaButton3.ForeColor = Color.White;
            clickVentaButton3.Location = new Point(851, 3);
            clickVentaButton3.Name = "clickVentaButton3";
            clickVentaButton3.Size = new Size(185, 40);
            clickVentaButton3.TabIndex = 4;
            clickVentaButton3.Text = "Filtrar";
            clickVentaButton3.TextColor = Color.White;
            clickVentaButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 46);
            label1.TabIndex = 1;
            label1.Text = "Buscar por nombre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtfilter
            // 
            txtfilter.Dock = DockStyle.Fill;
            txtfilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtfilter.Location = new Point(314, 3);
            txtfilter.Multiline = true;
            txtfilter.Name = "txtfilter";
            txtfilter.Size = new Size(531, 40);
            txtfilter.TabIndex = 2;
            txtfilter.TextAlign = HorizontalAlignment.Right;
            // 
            // btnempleado
            // 
            btnempleado.BackColor = Color.FromArgb(128, 128, 255);
            btnempleado.BorderColor = Color.FromArgb(128, 128, 255);
            btnempleado.BorderRadius = 5;
            btnempleado.BorderSize = 0;
            btnempleado.Dock = DockStyle.Fill;
            btnempleado.FlatAppearance.BorderSize = 0;
            btnempleado.FlatStyle = FlatStyle.Flat;
            btnempleado.ForeColor = Color.White;
            btnempleado.Location = new Point(851, 49);
            btnempleado.Name = "btnempleado";
            btnempleado.Size = new Size(185, 37);
            btnempleado.TabIndex = 3;
            btnempleado.Text = "Nuevo producto";
            btnempleado.TextColor = Color.White;
            btnempleado.UseVisualStyleBackColor = false;
            btnempleado.Click += btnempleado_Click;
            // 
            // frmproducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 629);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmproducto";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmproducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datalist).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox5;
        private Label label12;
        private Label lblTotal;
        private Label lblStatus;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrevious;
        private Button btnFirst;
        private DataGridView datalist;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomStyle.ClickVentaButton clickVentaButton3;
        private Label label1;
        private TextBox txtfilter;
        private CustomStyle.ClickVentaButton btnempleado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
    }
}