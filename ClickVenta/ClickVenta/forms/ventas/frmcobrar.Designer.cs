namespace ClickVenta.forms.ventas
{
    partial class frmcobrar
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            lbltotal = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblpago2 = new Label();
            lblpago1 = new Label();
            chbformacobro = new CheckBox();
            lblformapago1 = new Label();
            cvcpago1 = new ClickVenta.CustomStyle.ClickVentaComboBox();
            lblformapago2 = new Label();
            cvcpago2 = new ClickVenta.CustomStyle.ClickVentaComboBox();
            txtpago1 = new CustomControls.RJControls.ClickVentaTextBox();
            txtpago2 = new CustomControls.RJControls.ClickVentaTextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            clickVentaButton2 = new ClickVenta.CustomStyle.ClickVentaButton();
            clickVentaButton1 = new ClickVenta.CustomStyle.ClickVentaButton();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            panel1.Size = new Size(652, 51);
            panel1.TabIndex = 22;
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
            btnclose.Location = new Point(612, 0);
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
            label3.Size = new Size(260, 39);
            label3.TabIndex = 9;
            label3.Text = "Forma de pago";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.3496933F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.6503067F));
            tableLayoutPanel2.Controls.Add(label9, 0, 1);
            tableLayoutPanel2.Controls.Add(lbltotal, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 51);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.Size = new Size(652, 81);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(3, 9);
            label9.Name = "label9";
            label9.Size = new Size(231, 72);
            label9.TabIndex = 9;
            label9.Text = "Total a cobrar";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = SystemColors.ActiveCaptionText;
            lbltotal.Dock = DockStyle.Fill;
            lbltotal.FlatStyle = FlatStyle.Popup;
            lbltotal.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.ForeColor = SystemColors.ControlLightLight;
            lbltotal.Location = new Point(240, 9);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(409, 72);
            lbltotal.TabIndex = 10;
            lbltotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.56442F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.43558F));
            tableLayoutPanel1.Controls.Add(lblpago2, 0, 4);
            tableLayoutPanel1.Controls.Add(lblpago1, 0, 2);
            tableLayoutPanel1.Controls.Add(chbformacobro, 0, 0);
            tableLayoutPanel1.Controls.Add(lblformapago1, 0, 1);
            tableLayoutPanel1.Controls.Add(cvcpago1, 1, 1);
            tableLayoutPanel1.Controls.Add(lblformapago2, 0, 3);
            tableLayoutPanel1.Controls.Add(cvcpago2, 1, 3);
            tableLayoutPanel1.Controls.Add(txtpago1, 1, 2);
            tableLayoutPanel1.Controls.Add(txtpago2, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 132);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(652, 218);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // lblpago2
            // 
            lblpago2.AutoSize = true;
            lblpago2.Dock = DockStyle.Fill;
            lblpago2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblpago2.Location = new Point(3, 173);
            lblpago2.Name = "lblpago2";
            lblpago2.Size = new Size(265, 45);
            lblpago2.TabIndex = 19;
            lblpago2.Text = "Ingresa el faltante";
            lblpago2.TextAlign = ContentAlignment.MiddleCenter;
            lblpago2.Visible = false;
            // 
            // lblpago1
            // 
            lblpago1.AutoSize = true;
            lblpago1.Dock = DockStyle.Fill;
            lblpago1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblpago1.Location = new Point(3, 76);
            lblpago1.Name = "lblpago1";
            lblpago1.Size = new Size(265, 52);
            lblpago1.TabIndex = 16;
            lblpago1.Text = "Ingresa la cantidad";
            lblpago1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chbformacobro
            // 
            chbformacobro.AutoSize = true;
            chbformacobro.Dock = DockStyle.Left;
            chbformacobro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbformacobro.Location = new Point(3, 3);
            chbformacobro.Name = "chbformacobro";
            chbformacobro.RightToLeft = RightToLeft.Yes;
            chbformacobro.Size = new Size(235, 30);
            chbformacobro.TabIndex = 11;
            chbformacobro.Text = "Multiple forma de pago";
            chbformacobro.TextAlign = ContentAlignment.MiddleCenter;
            chbformacobro.UseVisualStyleBackColor = true;
            chbformacobro.CheckedChanged += chbformacobro_CheckedChanged;
            // 
            // lblformapago1
            // 
            lblformapago1.AutoSize = true;
            lblformapago1.Dock = DockStyle.Fill;
            lblformapago1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblformapago1.Location = new Point(3, 36);
            lblformapago1.Name = "lblformapago1";
            lblformapago1.Size = new Size(265, 40);
            lblformapago1.TabIndex = 9;
            lblformapago1.Text = "Seleccionar forma pago";
            lblformapago1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cvcpago1
            // 
            cvcpago1.BackColor = Color.WhiteSmoke;
            cvcpago1.BorderColor = Color.MediumSlateBlue;
            cvcpago1.BorderSize = 1;
            cvcpago1.Dock = DockStyle.Fill;
            cvcpago1.DropDownStyle = ComboBoxStyle.DropDown;
            cvcpago1.Font = new Font("Segoe UI", 10F);
            cvcpago1.ForeColor = Color.DimGray;
            cvcpago1.IconColor = Color.MediumSlateBlue;
            cvcpago1.ListBackColor = Color.FromArgb(230, 228, 245);
            cvcpago1.ListTextColor = Color.DimGray;
            cvcpago1.Location = new Point(274, 39);
            cvcpago1.MinimumSize = new Size(200, 30);
            cvcpago1.Name = "cvcpago1";
            cvcpago1.Padding = new Padding(1);
            cvcpago1.Size = new Size(375, 34);
            cvcpago1.TabIndex = 12;
            cvcpago1.Texts = "";
            // 
            // lblformapago2
            // 
            lblformapago2.AutoSize = true;
            lblformapago2.Dock = DockStyle.Fill;
            lblformapago2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblformapago2.Location = new Point(3, 128);
            lblformapago2.Name = "lblformapago2";
            lblformapago2.Size = new Size(265, 45);
            lblformapago2.TabIndex = 14;
            lblformapago2.Text = "Seleccionar forma pago";
            lblformapago2.TextAlign = ContentAlignment.MiddleCenter;
            lblformapago2.Visible = false;
            // 
            // cvcpago2
            // 
            cvcpago2.BackColor = Color.WhiteSmoke;
            cvcpago2.BorderColor = Color.MediumSlateBlue;
            cvcpago2.BorderSize = 1;
            cvcpago2.Dock = DockStyle.Fill;
            cvcpago2.DropDownStyle = ComboBoxStyle.DropDown;
            cvcpago2.Font = new Font("Segoe UI", 10F);
            cvcpago2.ForeColor = Color.DimGray;
            cvcpago2.IconColor = Color.MediumSlateBlue;
            cvcpago2.ListBackColor = Color.FromArgb(230, 228, 245);
            cvcpago2.ListTextColor = Color.DimGray;
            cvcpago2.Location = new Point(274, 131);
            cvcpago2.MinimumSize = new Size(200, 30);
            cvcpago2.Name = "cvcpago2";
            cvcpago2.Padding = new Padding(1);
            cvcpago2.Size = new Size(375, 39);
            cvcpago2.TabIndex = 13;
            cvcpago2.Texts = "";
            cvcpago2.Visible = false;
            // 
            // txtpago1
            // 
            txtpago1.BackColor = SystemColors.Window;
            txtpago1.BorderColor = Color.MediumSlateBlue;
            txtpago1.BorderFocusColor = Color.HotPink;
            txtpago1.BorderRadius = 0;
            txtpago1.BorderSize = 2;
            txtpago1.Dock = DockStyle.Fill;
            txtpago1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpago1.ForeColor = Color.FromArgb(64, 64, 64);
            txtpago1.Location = new Point(275, 80);
            txtpago1.Margin = new Padding(4);
            txtpago1.Multiline = false;
            txtpago1.Name = "txtpago1";
            txtpago1.Padding = new Padding(10, 7, 10, 7);
            txtpago1.PasswordChar = false;
            txtpago1.PlaceholderColor = Color.DarkGray;
            txtpago1.PlaceholderText = "";
            txtpago1.Size = new Size(373, 35);
            txtpago1.TabIndex = 20;
            txtpago1.Texts = "";
            txtpago1.UnderlinedStyle = false;
            // 
            // txtpago2
            // 
            txtpago2.BackColor = SystemColors.Window;
            txtpago2.BorderColor = Color.MediumSlateBlue;
            txtpago2.BorderFocusColor = Color.HotPink;
            txtpago2.BorderRadius = 0;
            txtpago2.BorderSize = 2;
            txtpago2.Dock = DockStyle.Fill;
            txtpago2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpago2.ForeColor = Color.FromArgb(64, 64, 64);
            txtpago2.Location = new Point(275, 177);
            txtpago2.Margin = new Padding(4);
            txtpago2.Multiline = false;
            txtpago2.Name = "txtpago2";
            txtpago2.Padding = new Padding(10, 7, 10, 7);
            txtpago2.PasswordChar = false;
            txtpago2.PlaceholderColor = Color.DarkGray;
            txtpago2.PlaceholderText = "";
            txtpago2.Size = new Size(373, 35);
            txtpago2.TabIndex = 21;
            txtpago2.Texts = "";
            txtpago2.UnderlinedStyle = false;
            txtpago2.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.1611366F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.8388634F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 219F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Controls.Add(clickVentaButton2, 2, 0);
            tableLayoutPanel3.Controls.Add(clickVentaButton1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 375);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel3.Size = new Size(652, 68);
            tableLayoutPanel3.TabIndex = 26;
            // 
            // clickVentaButton2
            // 
            clickVentaButton2.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton2.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton2.BorderRadius = 0;
            clickVentaButton2.BorderSize = 0;
            clickVentaButton2.Dock = DockStyle.Fill;
            clickVentaButton2.FlatAppearance.BorderSize = 0;
            clickVentaButton2.FlatStyle = FlatStyle.Flat;
            clickVentaButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickVentaButton2.ForeColor = Color.White;
            clickVentaButton2.Location = new Point(425, 5);
            clickVentaButton2.Margin = new Padding(3, 5, 3, 5);
            clickVentaButton2.Name = "clickVentaButton2";
            clickVentaButton2.Size = new Size(213, 49);
            clickVentaButton2.TabIndex = 14;
            clickVentaButton2.Text = "Cobrar";
            clickVentaButton2.TextColor = Color.White;
            clickVentaButton2.UseVisualStyleBackColor = false;
            clickVentaButton2.Click += clickVentaButton2_Click;
            // 
            // clickVentaButton1
            // 
            clickVentaButton1.BackColor = Color.Silver;
            clickVentaButton1.BorderColor = Color.Silver;
            clickVentaButton1.BorderRadius = 0;
            clickVentaButton1.BorderSize = 0;
            clickVentaButton1.Dock = DockStyle.Fill;
            clickVentaButton1.FlatAppearance.BorderSize = 0;
            clickVentaButton1.FlatStyle = FlatStyle.Flat;
            clickVentaButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickVentaButton1.ForeColor = Color.White;
            clickVentaButton1.Location = new Point(240, 5);
            clickVentaButton1.Margin = new Padding(3, 5, 3, 5);
            clickVentaButton1.Name = "clickVentaButton1";
            clickVentaButton1.Size = new Size(179, 49);
            clickVentaButton1.TabIndex = 13;
            clickVentaButton1.Text = "Cancelar";
            clickVentaButton1.TextColor = Color.White;
            clickVentaButton1.UseVisualStyleBackColor = false;
            clickVentaButton1.Click += clickVentaButton1_Click;
            // 
            // frmcobrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 443);
            ControlBox = false;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmcobrar";
            Load += frmcobrar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private Label lbltotal;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblformapago1;
        private CheckBox chbformacobro;
        private CustomStyle.ClickVentaComboBox cvcpago1;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomStyle.ClickVentaButton clickVentaButton2;
        private CustomStyle.ClickVentaButton clickVentaButton1;
        private CustomStyle.ClickVentaComboBox cvcpago2;
        private Label lblformapago2;
        private Label lblpago2;
        private Label lblpago1;
        private CustomControls.RJControls.ClickVentaTextBox txtpago1;
        private CustomControls.RJControls.ClickVentaTextBox txtpago2;
    }
}