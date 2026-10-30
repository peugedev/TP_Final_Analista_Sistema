namespace ClickVenta.forms.Proveedor
{
    partial class frmproveedor
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
            tableLayoutPanel2 = new TableLayoutPanel();
            txtfilter = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            label12 = new Label();
            lblStatus = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            datalist = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            cuit_cuil = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Web = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).BeginInit();
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
            panel1.Size = new Size(905, 38);
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
            btnclose.Location = new Point(870, 0);
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
            label3.Size = new Size(294, 31);
            label3.TabIndex = 9;
            label3.Text = "Gestion de proveedor";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6885262F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.3114738F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel1.Controls.Add(datalist, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8095245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.1904755F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(905, 441);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.7696724F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.2303276F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel2.Controls.Add(txtfilter, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(899, 65);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // txtfilter
            // 
            txtfilter.Dock = DockStyle.Fill;
            txtfilter.Location = new Point(274, 3);
            txtfilter.Multiline = true;
            txtfilter.Name = "txtfilter";
            txtfilter.Size = new Size(422, 26);
            txtfilter.TabIndex = 2;
            txtfilter.KeyDown += txtfilter_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 32);
            label1.TabIndex = 1;
            label1.Text = "Buscar por nombre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            groupBox1.Location = new Point(3, 381);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(899, 57);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(788, 21);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(105, 22);
            lblTotal.TabIndex = 10;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.Location = new Point(609, 23);
            label12.Name = "label12";
            label12.Size = new Size(183, 20);
            label12.TabIndex = 9;
            label12.Text = " Cantidad de registros";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.FlatStyle = FlatStyle.Flat;
            lblStatus.Location = new Point(386, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(131, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "0 / 0";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Top;
            btnLast.Location = new Point(571, 19);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(32, 26);
            btnLast.TabIndex = 3;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top;
            btnNext.Location = new Point(533, 22);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(32, 26);
            btnNext.TabIndex = 2;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top;
            btnPrevious.Location = new Point(348, 22);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(32, 26);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Top;
            btnFirst.Location = new Point(310, 22);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(32, 26);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "|<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // datalist
            // 
            datalist.AllowUserToAddRows = false;
            datalist.AllowUserToDeleteRows = false;
            datalist.AllowUserToResizeRows = false;
            datalist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datalist.BackgroundColor = Color.White;
            datalist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalist.Columns.AddRange(new DataGridViewColumn[] { Codigo, RazonSocial, cuit_cuil, Email, Direccion, Web });
            datalist.Cursor = Cursors.Hand;
            datalist.Dock = DockStyle.Fill;
            datalist.Location = new Point(3, 74);
            datalist.Name = "datalist";
            datalist.ReadOnly = true;
            datalist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalist.Size = new Size(899, 301);
            datalist.TabIndex = 23;
            datalist.CellDoubleClick += datalist_CellDoubleClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.DataPropertyName = "RazonSocial";
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // cuit_cuil
            // 
            cuit_cuil.DataPropertyName = "Cuit_Cuil";
            cuit_cuil.HeaderText = "Cuit_Cuil";
            cuit_cuil.Name = "cuit_cuil";
            cuit_cuil.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Web
            // 
            Web.DataPropertyName = "Web";
            Web.HeaderText = "Web";
            Web.Name = "Web";
            Web.ReadOnly = true;
            // 
            // frmproveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 479);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmproveedor";
            Text = "frmproveedor";
            Load += frmproveedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datalist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView datalist;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtfilter;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Label lblStatus;
        private Label label12;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn cuit_cuil;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Web;
    }
}