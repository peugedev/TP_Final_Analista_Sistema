namespace ClickVenta.forms.Proveedor.single
{
    partial class frmsingleproveedor
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
        /// the contents of this method or the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnclose = new Button();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnGuardar = new Button();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            txtWeb = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCodigo = new TextBox();
            txtCuitCuil = new TextBox();
            txtRazonSocial = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(914, 51);
            panel1.TabIndex = 26;
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
            btnclose.Location = new Point(874, 0);
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
            label3.Size = new Size(279, 39);
            label3.TabIndex = 9;
            label3.Text = "Crear proveedor";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(btnCerrar);
            groupBox3.Location = new Point(14, 468);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(885, 85);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(17, 33);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(143, 33);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(114, 40);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtWeb);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtCuitCuil);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 411);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos proveedor";
            // 
            // txtWeb
            // 
            txtWeb.Location = new Point(114, 236);
            txtWeb.Name = "txtWeb";
            txtWeb.Size = new Size(314, 27);
            txtWeb.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 276);
            txtId.Name = "txtId";
            txtId.Size = new Size(314, 27);
            txtId.TabIndex = 16;
            txtId.Visible = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(114, 137);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(314, 27);
            txtTelefono.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(562, 85);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(314, 27);
            txtDireccion.TabIndex = 14;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(114, 85);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(314, 27);
            txtCodigo.TabIndex = 13;
            // 
            // txtCuitCuil
            // 
            txtCuitCuil.Location = new Point(562, 32);
            txtCuitCuil.Name = "txtCuitCuil";
            txtCuitCuil.Size = new Size(314, 27);
            txtCuitCuil.TabIndex = 12;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(114, 32);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(314, 27);
            txtRazonSocial.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(16, 193);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 10;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(16, 240);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 9;
            label7.Text = "Web";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(11, 141);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 8;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(459, 89);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 6;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(11, 89);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 4;
            label4.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(459, 36);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Cuit Cuil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(11, 36);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "Razon social";
            // 
            // frmsingleproveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 567);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmsingleproveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Proveedor";
            Load += frmsingleproveedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Button btnGuardar;
        private Button btnCerrar;
        private TextBox txtWeb;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCodigo;
        private TextBox txtCuitCuil;
        private TextBox txtRazonSocial;
        private TextBox txtId;
    }
}
