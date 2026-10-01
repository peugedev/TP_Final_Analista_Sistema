namespace ClickVenta.forms.Empleado.single
{
    partial class frmcrearsingleempleado
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            clickVentaComboBox1 = new ClickVenta.CustomStyle.ClickVentaComboBox();
            clickVentaTextBox1 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox2 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox3 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox4 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox5 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox6 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox7 = new CustomControls.RJControls.ClickVentaTextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Size = new Size(942, 51);
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
            btnclose.Location = new Point(902, 0);
            btnclose.Margin = new Padding(2);
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
            label3.Size = new Size(275, 39);
            label3.TabIndex = 9;
            label3.Text = "Crear empleado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clickVentaTextBox5);
            groupBox1.Controls.Add(clickVentaTextBox4);
            groupBox1.Controls.Add(clickVentaTextBox3);
            groupBox1.Controls.Add(clickVentaTextBox2);
            groupBox1.Controls.Add(clickVentaTextBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 200);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(11, 143);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 8;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(459, 90);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 6;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(11, 90);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 4;
            label4.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(459, 38);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(clickVentaTextBox7);
            groupBox2.Controls.Add(clickVentaTextBox6);
            groupBox2.Controls.Add(clickVentaComboBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(12, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(930, 202);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos usuarios";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(11, 147);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 4;
            label9.Text = "Permiso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.Location = new Point(11, 91);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 1;
            label10.Text = "Contraseña";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(11, 38);
            label11.Name = "label11";
            label11.Size = new Size(175, 25);
            label11.TabIndex = 0;
            label11.Text = "Nombre de usuario";
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
            clickVentaComboBox1.Location = new Point(243, 134);
            clickVentaComboBox1.MinimumSize = new Size(200, 30);
            clickVentaComboBox1.Name = "clickVentaComboBox1";
            clickVentaComboBox1.Padding = new Padding(1);
            clickVentaComboBox1.Size = new Size(523, 38);
            clickVentaComboBox1.TabIndex = 5;
            clickVentaComboBox1.Texts = "";
            // 
            // clickVentaTextBox1
            // 
            clickVentaTextBox1.BackColor = SystemColors.Window;
            clickVentaTextBox1.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox1.BorderFocusColor = Color.HotPink;
            clickVentaTextBox1.BorderRadius = 5;
            clickVentaTextBox1.BorderSize = 2;
            clickVentaTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox1.Location = new Point(112, 38);
            clickVentaTextBox1.Margin = new Padding(4);
            clickVentaTextBox1.Multiline = false;
            clickVentaTextBox1.Name = "clickVentaTextBox1";
            clickVentaTextBox1.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox1.PasswordChar = false;
            clickVentaTextBox1.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox1.PlaceholderText = "";
            clickVentaTextBox1.Size = new Size(312, 35);
            clickVentaTextBox1.TabIndex = 9;
            clickVentaTextBox1.Texts = "";
            clickVentaTextBox1.UnderlinedStyle = false;
            // 
            // clickVentaTextBox2
            // 
            clickVentaTextBox2.BackColor = SystemColors.Window;
            clickVentaTextBox2.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox2.BorderFocusColor = Color.HotPink;
            clickVentaTextBox2.BorderRadius = 5;
            clickVentaTextBox2.BorderSize = 2;
            clickVentaTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox2.Location = new Point(112, 90);
            clickVentaTextBox2.Margin = new Padding(4);
            clickVentaTextBox2.Multiline = false;
            clickVentaTextBox2.Name = "clickVentaTextBox2";
            clickVentaTextBox2.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox2.PasswordChar = false;
            clickVentaTextBox2.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox2.PlaceholderText = "";
            clickVentaTextBox2.Size = new Size(312, 35);
            clickVentaTextBox2.TabIndex = 10;
            clickVentaTextBox2.Texts = "";
            clickVentaTextBox2.UnderlinedStyle = false;
            // 
            // clickVentaTextBox3
            // 
            clickVentaTextBox3.BackColor = SystemColors.Window;
            clickVentaTextBox3.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox3.BorderFocusColor = Color.HotPink;
            clickVentaTextBox3.BorderRadius = 5;
            clickVentaTextBox3.BorderSize = 2;
            clickVentaTextBox3.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox3.Location = new Point(112, 143);
            clickVentaTextBox3.Margin = new Padding(4);
            clickVentaTextBox3.Multiline = false;
            clickVentaTextBox3.Name = "clickVentaTextBox3";
            clickVentaTextBox3.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox3.PasswordChar = false;
            clickVentaTextBox3.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox3.PlaceholderText = "";
            clickVentaTextBox3.Size = new Size(312, 35);
            clickVentaTextBox3.TabIndex = 11;
            clickVentaTextBox3.Texts = "";
            clickVentaTextBox3.UnderlinedStyle = false;
            // 
            // clickVentaTextBox4
            // 
            clickVentaTextBox4.BackColor = SystemColors.Window;
            clickVentaTextBox4.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox4.BorderFocusColor = Color.HotPink;
            clickVentaTextBox4.BorderRadius = 5;
            clickVentaTextBox4.BorderSize = 2;
            clickVentaTextBox4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox4.Location = new Point(589, 38);
            clickVentaTextBox4.Margin = new Padding(4);
            clickVentaTextBox4.Multiline = false;
            clickVentaTextBox4.Name = "clickVentaTextBox4";
            clickVentaTextBox4.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox4.PasswordChar = false;
            clickVentaTextBox4.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox4.PlaceholderText = "";
            clickVentaTextBox4.Size = new Size(312, 35);
            clickVentaTextBox4.TabIndex = 12;
            clickVentaTextBox4.Texts = "";
            clickVentaTextBox4.UnderlinedStyle = false;
            // 
            // clickVentaTextBox5
            // 
            clickVentaTextBox5.BackColor = SystemColors.Window;
            clickVentaTextBox5.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox5.BorderFocusColor = Color.HotPink;
            clickVentaTextBox5.BorderRadius = 5;
            clickVentaTextBox5.BorderSize = 2;
            clickVentaTextBox5.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox5.Location = new Point(589, 90);
            clickVentaTextBox5.Margin = new Padding(4);
            clickVentaTextBox5.Multiline = false;
            clickVentaTextBox5.Name = "clickVentaTextBox5";
            clickVentaTextBox5.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox5.PasswordChar = false;
            clickVentaTextBox5.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox5.PlaceholderText = "";
            clickVentaTextBox5.Size = new Size(312, 35);
            clickVentaTextBox5.TabIndex = 13;
            clickVentaTextBox5.Texts = "";
            clickVentaTextBox5.UnderlinedStyle = false;
            // 
            // clickVentaTextBox6
            // 
            clickVentaTextBox6.BackColor = SystemColors.Window;
            clickVentaTextBox6.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox6.BorderFocusColor = Color.HotPink;
            clickVentaTextBox6.BorderRadius = 5;
            clickVentaTextBox6.BorderSize = 2;
            clickVentaTextBox6.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox6.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox6.Location = new Point(243, 81);
            clickVentaTextBox6.Margin = new Padding(4);
            clickVentaTextBox6.Multiline = false;
            clickVentaTextBox6.Name = "clickVentaTextBox6";
            clickVentaTextBox6.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox6.PasswordChar = false;
            clickVentaTextBox6.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox6.PlaceholderText = "";
            clickVentaTextBox6.Size = new Size(523, 35);
            clickVentaTextBox6.TabIndex = 14;
            clickVentaTextBox6.Texts = "";
            clickVentaTextBox6.UnderlinedStyle = false;
            // 
            // clickVentaTextBox7
            // 
            clickVentaTextBox7.BackColor = SystemColors.Window;
            clickVentaTextBox7.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox7.BorderFocusColor = Color.HotPink;
            clickVentaTextBox7.BorderRadius = 5;
            clickVentaTextBox7.BorderSize = 2;
            clickVentaTextBox7.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox7.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox7.Location = new Point(243, 38);
            clickVentaTextBox7.Margin = new Padding(4);
            clickVentaTextBox7.Multiline = false;
            clickVentaTextBox7.Name = "clickVentaTextBox7";
            clickVentaTextBox7.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox7.PasswordChar = false;
            clickVentaTextBox7.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox7.PlaceholderText = "";
            clickVentaTextBox7.Size = new Size(549, 35);
            clickVentaTextBox7.TabIndex = 15;
            clickVentaTextBox7.Texts = "";
            clickVentaTextBox7.UnderlinedStyle = false;
            // 
            // frmcrearsingleempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 647);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcrearsingleempleado";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox3;
        private Label label4;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox2;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox1;
        private Label label2;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox5;
        private Label label6;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox4;
        private GroupBox groupBox2;
        private Label label9;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox9;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox10;
        private Label label10;
        private Label label11;
        private CustomStyle.ClickVentaComboBox clickVentaComboBox1;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox7;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox6;
    }
}