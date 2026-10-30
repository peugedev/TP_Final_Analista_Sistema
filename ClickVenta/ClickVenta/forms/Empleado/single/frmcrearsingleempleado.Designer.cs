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
            groupBox3 = new GroupBox();
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
            panel1.Size = new Size(824, 38);
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
            btnclose.Location = new Point(789, 0);
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
            label3.Size = new Size(221, 31);
            label3.TabIndex = 9;
            label3.Text = "Crear empleado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 42);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(814, 150);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(10, 107);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(402, 68);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 6;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(10, 68);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 4;
            label4.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(402, 28);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(10, 206);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(814, 139);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos usuarios";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(10, 110);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 4;
            label9.Text = "Permiso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.Location = new Point(10, 68);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 1;
            label10.Text = "Contraseña";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(10, 28);
            label11.Name = "label11";
            label11.Size = new Size(144, 20);
            label11.TabIndex = 0;
            label11.Text = "Nombre de usuario";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(1, 355);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(814, 64);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Accion";
            // 
            // frmcrearsingleempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 425);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmcrearsingleempleado";
            StartPosition = FormStartPosition.Manual;
            Load += frmcrearsingleempleado_Load;
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
        private CustomControls.RJControls.ClickVentaTextBox txtcontrasenia;
        private CustomControls.RJControls.ClickVentaTextBox txtnombreusuario;
        private GroupBox groupBox3;
        private CustomStyle.ClickVentaButton clickVentaButton1;
        private CustomStyle.ClickVentaButton btnempleado;
        private CustomControls.RJControls.ClickVentaTextBox txtid;
    }
}