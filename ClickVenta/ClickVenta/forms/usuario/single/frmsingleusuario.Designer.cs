namespace ClickVenta.forms.usuario.single
{
    partial class frmsingleusuario
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
            groupBox3 = new GroupBox();
            clickVentaButton3 = new ClickVenta.CustomStyle.ClickVentaButton();
            clickVentaButton2 = new ClickVenta.CustomStyle.ClickVentaButton();
            groupBox2 = new GroupBox();
            cvcbrol = new ClickVenta.CustomStyle.ClickVentaComboBox();
            txtcontrasenia = new CustomControls.RJControls.ClickVentaTextBox();
            txtnombreusuario = new CustomControls.RJControls.ClickVentaTextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
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
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 51);
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
            btnclose.Location = new Point(696, 0);
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
            label3.Size = new Size(236, 39);
            label3.TabIndex = 9;
            label3.Text = "Crear usuario";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(clickVentaButton3);
            groupBox3.Controls.Add(clickVentaButton2);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 255);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(736, 61);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Accion";
            // 
            // clickVentaButton3
            // 
            clickVentaButton3.BackColor = Color.Silver;
            clickVentaButton3.BorderColor = Color.Silver;
            clickVentaButton3.BorderRadius = 5;
            clickVentaButton3.BorderSize = 0;
            clickVentaButton3.Dock = DockStyle.Right;
            clickVentaButton3.FlatAppearance.BorderSize = 0;
            clickVentaButton3.FlatStyle = FlatStyle.Flat;
            clickVentaButton3.ForeColor = Color.White;
            clickVentaButton3.Location = new Point(429, 23);
            clickVentaButton3.Name = "clickVentaButton3";
            clickVentaButton3.Size = new Size(152, 35);
            clickVentaButton3.TabIndex = 1;
            clickVentaButton3.Text = "Cancelar";
            clickVentaButton3.TextColor = Color.White;
            clickVentaButton3.UseVisualStyleBackColor = false;
            // 
            // clickVentaButton2
            // 
            clickVentaButton2.BackColor = Color.FromArgb(128, 128, 255);
            clickVentaButton2.BorderColor = Color.FromArgb(128, 128, 255);
            clickVentaButton2.BorderRadius = 5;
            clickVentaButton2.BorderSize = 0;
            clickVentaButton2.Dock = DockStyle.Right;
            clickVentaButton2.FlatAppearance.BorderSize = 0;
            clickVentaButton2.FlatStyle = FlatStyle.Flat;
            clickVentaButton2.ForeColor = Color.White;
            clickVentaButton2.Location = new Point(581, 23);
            clickVentaButton2.Name = "clickVentaButton2";
            clickVentaButton2.Size = new Size(152, 35);
            clickVentaButton2.TabIndex = 0;
            clickVentaButton2.Text = "Aceptar";
            clickVentaButton2.TextColor = Color.White;
            clickVentaButton2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cvcbrol);
            groupBox2.Controls.Add(txtcontrasenia);
            groupBox2.Controls.Add(txtnombreusuario);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(736, 193);
            groupBox2.TabIndex = 25;
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
            // frmsingleusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 316);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmsingleusuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmsingleusuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private GroupBox groupBox3;
        private CustomStyle.ClickVentaButton clickVentaButton3;
        private CustomStyle.ClickVentaButton clickVentaButton2;
        private GroupBox groupBox2;
        private CustomStyle.ClickVentaComboBox cvcbrol;
        private CustomControls.RJControls.ClickVentaTextBox txtcontrasenia;
        private CustomControls.RJControls.ClickVentaTextBox txtnombreusuario;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}