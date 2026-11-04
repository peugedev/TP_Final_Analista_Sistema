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
            txtid = new CustomControls.RJControls.ClickVentaTextBox();
            txtdireccion = new CustomControls.RJControls.ClickVentaTextBox();
            txtapellido = new CustomControls.RJControls.ClickVentaTextBox();
            txtdni = new CustomControls.RJControls.ClickVentaTextBox();
            txttelefono = new CustomControls.RJControls.ClickVentaTextBox();
            txtnombre = new CustomControls.RJControls.ClickVentaTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cvcbrol = new ClickVenta.CustomStyle.ClickVentaComboBox();
            txtcontrasenia = new CustomControls.RJControls.ClickVentaTextBox();
            txtnombreusuario = new CustomControls.RJControls.ClickVentaTextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            clickVentaButton3 = new ClickVenta.CustomStyle.ClickVentaButton();
            clickVentaButton2 = new ClickVenta.CustomStyle.ClickVentaButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            label3.Size = new Size(275, 39);
            label3.TabIndex = 9;
            label3.Text = "Crear empleado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txtapellido);
            groupBox1.Controls.Add(txtdni);
            groupBox1.Controls.Add(txttelefono);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 200);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos empleados";
            // 
            // txtid
            // 
            txtid.BackColor = SystemColors.Window;
            txtid.BorderColor = Color.MediumSlateBlue;
            txtid.BorderFocusColor = Color.HotPink;
            txtid.BorderRadius = 0;
            txtid.BorderSize = 2;
            txtid.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.ForeColor = Color.FromArgb(64, 64, 64);
            txtid.Location = new Point(525, 133);
            txtid.Margin = new Padding(4);
            txtid.Multiline = false;
            txtid.Name = "txtid";
            txtid.Padding = new Padding(10, 7, 10, 7);
            txtid.PasswordChar = false;
            txtid.PlaceholderColor = Color.DarkGray;
            txtid.PlaceholderText = "";
            txtid.Size = new Size(312, 35);
            txtid.TabIndex = 14;
            txtid.Texts = "";
            txtid.UnderlinedStyle = false;
            txtid.Visible = false;
            // 
            // txtdireccion
            // 
            txtdireccion.BackColor = SystemColors.Window;
            txtdireccion.BorderColor = Color.MediumSlateBlue;
            txtdireccion.BorderFocusColor = Color.HotPink;
            txtdireccion.BorderRadius = 0;
            txtdireccion.BorderSize = 2;
            txtdireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtdireccion.Location = new Point(558, 81);
            txtdireccion.Margin = new Padding(4);
            txtdireccion.Multiline = false;
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Padding = new Padding(10, 7, 10, 7);
            txtdireccion.PasswordChar = false;
            txtdireccion.PlaceholderColor = Color.DarkGray;
            txtdireccion.PlaceholderText = "";
            txtdireccion.Size = new Size(312, 35);
            txtdireccion.TabIndex = 13;
            txtdireccion.Texts = "";
            txtdireccion.UnderlinedStyle = false;
            // 
            // txtapellido
            // 
            txtapellido.BackColor = SystemColors.Window;
            txtapellido.BorderColor = Color.MediumSlateBlue;
            txtapellido.BorderFocusColor = Color.HotPink;
            txtapellido.BorderRadius = 0;
            txtapellido.BorderSize = 2;
            txtapellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtapellido.ForeColor = Color.FromArgb(64, 64, 64);
            txtapellido.Location = new Point(558, 27);
            txtapellido.Margin = new Padding(4);
            txtapellido.Multiline = false;
            txtapellido.Name = "txtapellido";
            txtapellido.Padding = new Padding(10, 7, 10, 7);
            txtapellido.PasswordChar = false;
            txtapellido.PlaceholderColor = Color.DarkGray;
            txtapellido.PlaceholderText = "";
            txtapellido.Size = new Size(312, 35);
            txtapellido.TabIndex = 12;
            txtapellido.Texts = "";
            txtapellido.UnderlinedStyle = false;
            // 
            // txtdni
            // 
            txtdni.BackColor = SystemColors.Window;
            txtdni.BorderColor = Color.MediumSlateBlue;
            txtdni.BorderFocusColor = Color.HotPink;
            txtdni.BorderRadius = 0;
            txtdni.BorderSize = 2;
            txtdni.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdni.ForeColor = Color.FromArgb(64, 64, 64);
            txtdni.Location = new Point(99, 81);
            txtdni.Margin = new Padding(4);
            txtdni.Multiline = false;
            txtdni.Name = "txtdni";
            txtdni.Padding = new Padding(10, 7, 10, 7);
            txtdni.PasswordChar = false;
            txtdni.PlaceholderColor = Color.DarkGray;
            txtdni.PlaceholderText = "";
            txtdni.Size = new Size(312, 35);
            txtdni.TabIndex = 11;
            txtdni.Texts = "";
            txtdni.UnderlinedStyle = false;
            // 
            // txttelefono
            // 
            txttelefono.BackColor = SystemColors.Window;
            txttelefono.BorderColor = Color.MediumSlateBlue;
            txttelefono.BorderFocusColor = Color.HotPink;
            txttelefono.BorderRadius = 0;
            txttelefono.BorderSize = 2;
            txttelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txttelefono.Location = new Point(99, 133);
            txttelefono.Margin = new Padding(4);
            txttelefono.Multiline = false;
            txttelefono.Name = "txttelefono";
            txttelefono.Padding = new Padding(10, 7, 10, 7);
            txttelefono.PasswordChar = false;
            txttelefono.PlaceholderColor = Color.DarkGray;
            txttelefono.PlaceholderText = "";
            txttelefono.Size = new Size(312, 35);
            txttelefono.TabIndex = 10;
            txttelefono.Texts = "";
            txttelefono.UnderlinedStyle = false;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = SystemColors.Window;
            txtnombre.BorderColor = Color.MediumSlateBlue;
            txtnombre.BorderFocusColor = Color.HotPink;
            txtnombre.BorderRadius = 0;
            txtnombre.BorderSize = 2;
            txtnombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtnombre.Location = new Point(99, 27);
            txtnombre.Margin = new Padding(4);
            txtnombre.Multiline = false;
            txtnombre.Name = "txtnombre";
            txtnombre.Padding = new Padding(10, 7, 10, 7);
            txtnombre.PasswordChar = false;
            txtnombre.PlaceholderColor = Color.DarkGray;
            txtnombre.PlaceholderText = "";
            txtnombre.Size = new Size(312, 35);
            txtnombre.TabIndex = 9;
            txtnombre.Texts = "";
            txtnombre.UnderlinedStyle = false;
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
            label5.Location = new Point(459, 91);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 6;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(11, 91);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 4;
            label4.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(459, 37);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(11, 37);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cvcbrol);
            groupBox2.Controls.Add(txtcontrasenia);
            groupBox2.Controls.Add(txtnombreusuario);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(11, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(930, 185);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos usuarios";
            // 
            // cvcbrol
            // 
            cvcbrol.BackColor = Color.WhiteSmoke;
            cvcbrol.BorderColor = Color.MediumSlateBlue;
            cvcbrol.BorderSize = 1;
            cvcbrol.DropDownStyle = ComboBoxStyle.DropDown;
            cvcbrol.Font = new Font("Segoe UI", 10F);
            cvcbrol.ForeColor = Color.DimGray;
            cvcbrol.IconColor = Color.MediumSlateBlue;
            cvcbrol.ListBackColor = Color.FromArgb(230, 228, 245);
            cvcbrol.ListTextColor = Color.DimGray;
            cvcbrol.Location = new Point(260, 133);
            cvcbrol.MinimumSize = new Size(200, 30);
            cvcbrol.Name = "cvcbrol";
            cvcbrol.Padding = new Padding(1);
            cvcbrol.Size = new Size(410, 38);
            cvcbrol.TabIndex = 12;
            cvcbrol.Texts = "";
            // 
            // txtcontrasenia
            // 
            txtcontrasenia.BackColor = SystemColors.Window;
            txtcontrasenia.BorderColor = Color.MediumSlateBlue;
            txtcontrasenia.BorderFocusColor = Color.HotPink;
            txtcontrasenia.BorderRadius = 0;
            txtcontrasenia.BorderSize = 2;
            txtcontrasenia.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontrasenia.ForeColor = Color.FromArgb(64, 64, 64);
            txtcontrasenia.Location = new Point(260, 81);
            txtcontrasenia.Margin = new Padding(4);
            txtcontrasenia.Multiline = false;
            txtcontrasenia.Name = "txtcontrasenia";
            txtcontrasenia.Padding = new Padding(10, 7, 10, 7);
            txtcontrasenia.PasswordChar = false;
            txtcontrasenia.PlaceholderColor = Color.DarkGray;
            txtcontrasenia.PlaceholderText = "";
            txtcontrasenia.Size = new Size(312, 35);
            txtcontrasenia.TabIndex = 11;
            txtcontrasenia.Texts = "";
            txtcontrasenia.UnderlinedStyle = false;
            // 
            // txtnombreusuario
            // 
            txtnombreusuario.BackColor = SystemColors.Window;
            txtnombreusuario.BorderColor = Color.MediumSlateBlue;
            txtnombreusuario.BorderFocusColor = Color.HotPink;
            txtnombreusuario.BorderRadius = 0;
            txtnombreusuario.BorderSize = 2;
            txtnombreusuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombreusuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtnombreusuario.Location = new Point(260, 37);
            txtnombreusuario.Margin = new Padding(4);
            txtnombreusuario.Multiline = false;
            txtnombreusuario.Name = "txtnombreusuario";
            txtnombreusuario.Padding = new Padding(10, 7, 10, 7);
            txtnombreusuario.PasswordChar = false;
            txtnombreusuario.PlaceholderColor = Color.DarkGray;
            txtnombreusuario.PlaceholderText = "";
            txtnombreusuario.Size = new Size(459, 35);
            txtnombreusuario.TabIndex = 10;
            txtnombreusuario.Texts = "";
            txtnombreusuario.UnderlinedStyle = false;
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
            label11.Location = new Point(11, 37);
            label11.Name = "label11";
            label11.Size = new Size(175, 25);
            label11.TabIndex = 0;
            label11.Text = "Nombre de usuario";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(clickVentaButton3);
            groupBox3.Controls.Add(clickVentaButton2);
            groupBox3.Location = new Point(1, 497);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(930, 61);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Accion";
            // 
            // clickVentaButton3
            // 
            clickVentaButton3.BackColor = Color.Silver;
            clickVentaButton3.BorderColor = Color.Silver;
            clickVentaButton3.BorderRadius = 5;
            clickVentaButton3.BorderSize = 0;
            clickVentaButton3.FlatAppearance.BorderSize = 0;
            clickVentaButton3.FlatStyle = FlatStyle.Flat;
            clickVentaButton3.ForeColor = Color.White;
            clickVentaButton3.Location = new Point(608, 17);
            clickVentaButton3.Name = "clickVentaButton3";
            clickVentaButton3.Size = new Size(152, 37);
            clickVentaButton3.TabIndex = 1;
            clickVentaButton3.Text = "Cancelar";
            clickVentaButton3.TextColor = Color.White;
            clickVentaButton3.UseVisualStyleBackColor = false;
            clickVentaButton3.Click += btnclose_Click;
            // 
            // clickVentaButton2
            // 
            clickVentaButton2.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton2.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton2.BorderRadius = 5;
            clickVentaButton2.BorderSize = 0;
            clickVentaButton2.FlatAppearance.BorderSize = 0;
            clickVentaButton2.FlatStyle = FlatStyle.Flat;
            clickVentaButton2.ForeColor = Color.White;
            clickVentaButton2.Location = new Point(767, 17);
            clickVentaButton2.Name = "clickVentaButton2";
            clickVentaButton2.Size = new Size(152, 37);
            clickVentaButton2.TabIndex = 0;
            clickVentaButton2.Text = "Aceptar";
            clickVentaButton2.TextColor = Color.White;
            clickVentaButton2.UseVisualStyleBackColor = false;
            clickVentaButton2.Click += btnempleado_Click;
            // 
            // frmcrearsingleempleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 567);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcrearsingleempleado";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmcrearsingleempleado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private CustomControls.RJControls.ClickVentaTextBox txtdni;
        private Label label4;
        private CustomControls.RJControls.ClickVentaTextBox txtapellido;
        private CustomControls.RJControls.ClickVentaTextBox txtnombre;
        private Label label2;
        private CustomControls.RJControls.ClickVentaTextBox txttelefono;
        private Label label6;
        private CustomControls.RJControls.ClickVentaTextBox txtdireccion;
        private GroupBox groupBox2;
        private Label label9;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox10;
        private Label label10;
        private Label label11;
        private CustomStyle.ClickVentaComboBox cvcbrol;
        private CustomControls.RJControls.ClickVentaTextBox txtid;
        private CustomControls.RJControls.ClickVentaTextBox txtcontrasenia;
        private CustomControls.RJControls.ClickVentaTextBox txtnombreusuario;
        private GroupBox groupBox3;
        private CustomStyle.ClickVentaButton clickVentaButton1;
        private CustomStyle.ClickVentaButton btnempleado;
        private CustomStyle.ClickVentaButton clickVentaButton3;
        private CustomStyle.ClickVentaButton clickVentaButton2;
        //private CustomControls.RJControls.ClickVentaTextBox txtid;
        //private CustomControls.RJControls.ClickVentaTextBox txtdireccion;
        //private CustomControls.RJControls.ClickVentaTextBox txtapellido;
        //private CustomControls.RJControls.ClickVentaTextBox txtdni;
        //private CustomControls.RJControls.ClickVentaTextBox txttelefono;
        //private CustomControls.RJControls.ClickVentaTextBox txtnombre;
        //private CustomControls.RJControls.ClickVentaTextBox txtcontrasenia;
        //private CustomControls.RJControls.ClickVentaTextBox txtnombreusuario;
        //private CustomStyle.ClickVentaComboBox cvcbrol;
    }
}