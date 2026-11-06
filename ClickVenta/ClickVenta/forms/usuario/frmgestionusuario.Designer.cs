namespace ClickVenta.forms.usuario
{
    partial class frmgestionusuario
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
            tableLayoutPanel2 = new TableLayoutPanel();
            clickVentaButton4 = new ClickVenta.CustomStyle.ClickVentaButton();
            clickVentaButton1 = new ClickVenta.CustomStyle.ClickVentaButton();
            txtfilter = new TextBox();
            label1 = new Label();
            datalist = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            label12 = new Label();
            lblStatus = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            panel1 = new Panel();
            btnclose = new Button();
            label3 = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.7696724F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.2303276F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tableLayoutPanel2.Controls.Add(clickVentaButton4, 2, 1);
            tableLayoutPanel2.Controls.Add(clickVentaButton1, 2, 0);
            tableLayoutPanel2.Controls.Add(txtfilter, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1270, 111);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // clickVentaButton4
            // 
            clickVentaButton4.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton4.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton4.BorderRadius = 5;
            clickVentaButton4.BorderSize = 0;
            clickVentaButton4.Dock = DockStyle.Fill;
            clickVentaButton4.FlatAppearance.BorderSize = 0;
            clickVentaButton4.FlatStyle = FlatStyle.Flat;
            clickVentaButton4.ForeColor = Color.White;
            clickVentaButton4.Location = new Point(1043, 58);
            clickVentaButton4.Name = "clickVentaButton4";
            clickVentaButton4.Size = new Size(224, 50);
            clickVentaButton4.TabIndex = 26;
            clickVentaButton4.Text = "Nueva usuario";
            clickVentaButton4.TextColor = Color.White;
            clickVentaButton4.UseVisualStyleBackColor = false;
            clickVentaButton4.Click += clickVentaButton4_Click;
            // 
            // clickVentaButton1
            // 
            clickVentaButton1.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton1.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton1.BorderRadius = 5;
            clickVentaButton1.BorderSize = 0;
            clickVentaButton1.Dock = DockStyle.Fill;
            clickVentaButton1.FlatAppearance.BorderSize = 0;
            clickVentaButton1.FlatStyle = FlatStyle.Flat;
            clickVentaButton1.ForeColor = Color.White;
            clickVentaButton1.Location = new Point(1043, 3);
            clickVentaButton1.Name = "clickVentaButton1";
            clickVentaButton1.Size = new Size(224, 49);
            clickVentaButton1.TabIndex = 23;
            clickVentaButton1.Text = "Filtrar";
            clickVentaButton1.TextColor = Color.White;
            clickVentaButton1.UseVisualStyleBackColor = false;
            // 
            // txtfilter
            // 
            txtfilter.Dock = DockStyle.Fill;
            txtfilter.Location = new Point(406, 4);
            txtfilter.Margin = new Padding(3, 4, 3, 4);
            txtfilter.Multiline = true;
            txtfilter.Name = "txtfilter";
            txtfilter.Size = new Size(631, 47);
            txtfilter.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(397, 55);
            label1.TabIndex = 1;
            label1.Text = "Buscar por nombre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datalist
            // 
            datalist.AllowUserToAddRows = false;
            datalist.AllowUserToDeleteRows = false;
            datalist.AllowUserToResizeRows = false;
            datalist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datalist.BackgroundColor = Color.White;
            datalist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalist.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Apellido, Usuario });
            datalist.Cursor = Cursors.Hand;
            datalist.Dock = DockStyle.Fill;
            datalist.Location = new Point(3, 123);
            datalist.Margin = new Padding(3, 4, 3, 4);
            datalist.Name = "datalist";
            datalist.ReadOnly = true;
            datalist.RowHeadersWidth = 51;
            datalist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalist.Size = new Size(1270, 507);
            datalist.TabIndex = 23;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6885262F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3114738F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 216F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(datalist, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 51);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8095245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.1904755F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1276, 718);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 638);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1270, 76);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(1137, 29);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(120, 29);
            lblTotal.TabIndex = 10;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.Location = new Point(932, 32);
            label12.Name = "label12";
            label12.Size = new Size(209, 27);
            label12.TabIndex = 9;
            label12.Text = " Cantidad de registros";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.FlatStyle = FlatStyle.Flat;
            lblStatus.Location = new Point(677, 32);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(150, 33);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "0 / 0";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Top;
            btnLast.Location = new Point(889, 26);
            btnLast.Margin = new Padding(3, 4, 3, 4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(37, 35);
            btnLast.TabIndex = 3;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top;
            btnNext.Location = new Point(845, 30);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(37, 35);
            btnNext.TabIndex = 2;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top;
            btnPrevious.Location = new Point(634, 30);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(37, 35);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Top;
            btnFirst.Location = new Point(590, 30);
            btnFirst.Margin = new Padding(3, 4, 3, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(37, 35);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "|<";
            btnFirst.UseVisualStyleBackColor = true;
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
            panel1.Size = new Size(1276, 51);
            panel1.TabIndex = 23;
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
            btnclose.Location = new Point(1236, 0);
            btnclose.Margin = new Padding(2, 3, 2, 3);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(40, 51);
            btnclose.TabIndex = 24;
            btnclose.Text = "X";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(363, 39);
            label3.TabIndex = 9;
            label3.Text = "Gestion de proveedor";
            // 
            // frmgestionusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 769);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmgestionusuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmgestionusuario_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private CustomStyle.ClickVentaButton clickVentaButton4;
        private CustomStyle.ClickVentaButton clickVentaButton1;
        private TextBox txtfilter;
        private Label label1;
        private DataGridView datalist;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Usuario;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label lblTotal;
        private Label label12;
        private Label lblStatus;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Panel panel1;
        private Button btnclose;
        private Label label3;
    }
}