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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 38);
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
            btnclose.Location = new Point(765, 0);
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
            label3.Size = new Size(226, 31);
            label3.TabIndex = 9;
            label3.Text = "Crear proveedor";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Controls.Add(btnCerrar);
            groupBox3.Location = new Point(12, 351);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(774, 64);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(15, 25);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(125, 25);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
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
            groupBox1.Location = new Point(12, 38);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(774, 308);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos proveedor";
            // 
            // txtWeb
            // 
            txtWeb.Location = new Point(100, 177);
            txtWeb.Margin = new Padding(3, 2, 3, 2);
            txtWeb.Name = "txtWeb";
            txtWeb.Size = new Size(275, 23);
            txtWeb.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 142);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 207);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(275, 23);
            txtId.TabIndex = 16;
            txtId.Visible = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(100, 103);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(275, 23);
            txtTelefono.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(492, 64);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(275, 23);
            txtDireccion.TabIndex = 14;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(100, 64);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(275, 23);
            txtCodigo.TabIndex = 13;
            // 
            // txtCuitCuil
            // 
            txtCuitCuil.Location = new Point(492, 24);
            txtCuitCuil.Margin = new Padding(3, 2, 3, 2);
            txtCuitCuil.Name = "txtCuitCuil";
            txtCuitCuil.Size = new Size(275, 23);
            txtCuitCuil.TabIndex = 12;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(100, 24);
            txtRazonSocial.Margin = new Padding(3, 2, 3, 2);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(275, 23);
            txtRazonSocial.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(14, 145);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 10;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(14, 180);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 9;
            label7.Text = "Web";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(10, 106);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(402, 67);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 6;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(10, 67);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 4;
            label4.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(402, 27);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Cuit Cuil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Razon social";
            // 
            // frmsingleproveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
