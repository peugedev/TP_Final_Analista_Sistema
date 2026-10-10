namespace ClickVenta
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnminimizer = new ClickVenta.CustomStyle.ClickVentaButton();
            btnclose = new ClickVenta.CustomStyle.ClickVentaButton();
            label1 = new Label();
            label2 = new Label();
            txtusuario = new CustomControls.RJControls.ClickVentaTextBox();
            txtpassword = new CustomControls.RJControls.ClickVentaTextBox();
            btncancelar = new ClickVenta.CustomStyle.ClickVentaButton();
            btnentrar = new ClickVenta.CustomStyle.ClickVentaButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 100, 182);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 366);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnminimizer);
            panel1.Controls.Add(btnclose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(292, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 38);
            panel1.TabIndex = 1;
            // 
            // btnminimizer
            // 
            btnminimizer.BackColor = Color.FromArgb(30, 58, 107);
            btnminimizer.BorderColor = Color.FromArgb(30, 58, 107);
            btnminimizer.BorderRadius = 0;
            btnminimizer.BorderSize = 0;
            btnminimizer.Dock = DockStyle.Right;
            btnminimizer.FlatAppearance.BorderSize = 0;
            btnminimizer.FlatStyle = FlatStyle.Flat;
            btnminimizer.ForeColor = Color.White;
            btnminimizer.Location = new Point(554, 0);
            btnminimizer.Name = "btnminimizer";
            btnminimizer.Size = new Size(34, 38);
            btnminimizer.TabIndex = 2;
            btnminimizer.Text = "-";
            btnminimizer.TextColor = Color.White;
            btnminimizer.UseVisualStyleBackColor = false;
            btnminimizer.Click += btnminimizer_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.FromArgb(30, 58, 107);
            btnclose.BorderColor = Color.FromArgb(30, 79, 162);
            btnclose.BorderRadius = 0;
            btnclose.BorderSize = 0;
            btnclose.Dock = DockStyle.Right;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.ForeColor = Color.White;
            btnclose.Location = new Point(588, 0);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(34, 38);
            btnclose.TabIndex = 1;
            btnclose.Text = "x";
            btnclose.TextColor = Color.White;
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Black;
            label1.Location = new Point(292, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(622, 8);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Black;
            label2.Location = new Point(292, 265);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(622, 8);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // txtusuario
            // 
            txtusuario.BackColor = SystemColors.Window;
            txtusuario.BorderColor = Color.MediumSlateBlue;
            txtusuario.BorderFocusColor = Color.HotPink;
            txtusuario.BorderRadius = 5;
            txtusuario.BorderSize = 2;
            txtusuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtusuario.Location = new Point(341, 120);
            txtusuario.Margin = new Padding(4);
            txtusuario.Multiline = false;
            txtusuario.Name = "txtusuario";
            txtusuario.Padding = new Padding(10, 7, 10, 7);
            txtusuario.PasswordChar = false;
            txtusuario.PlaceholderColor = Color.DarkGray;
            txtusuario.PlaceholderText = "";
            txtusuario.Size = new Size(539, 35);
            txtusuario.TabIndex = 4;
            txtusuario.Texts = "";
            txtusuario.UnderlinedStyle = false;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Window;
            txtpassword.BorderColor = Color.MediumSlateBlue;
            txtpassword.BorderFocusColor = Color.HotPink;
            txtpassword.BorderRadius = 0;
            txtpassword.BorderSize = 2;
            txtpassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtpassword.Location = new Point(341, 173);
            txtpassword.Margin = new Padding(4);
            txtpassword.Multiline = false;
            txtpassword.Name = "txtpassword";
            txtpassword.Padding = new Padding(10, 7, 10, 7);
            txtpassword.PasswordChar = true;
            txtpassword.PlaceholderColor = Color.DarkGray;
            txtpassword.PlaceholderText = "*";
            txtpassword.Size = new Size(539, 35);
            txtpassword.TabIndex = 5;
            txtpassword.Texts = "";
            txtpassword.UnderlinedStyle = false;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Silver;
            btncancelar.BorderColor = Color.Silver;
            btncancelar.BorderRadius = 5;
            btncancelar.BorderSize = 0;
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(599, 313);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(144, 41);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "Cancelar";
            btncancelar.TextColor = Color.White;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.FromArgb(30, 79, 162);
            btnentrar.BorderColor = Color.FromArgb(30, 79, 162);
            btnentrar.BorderRadius = 5;
            btnentrar.BorderSize = 0;
            btnentrar.FlatAppearance.BorderSize = 0;
            btnentrar.FlatStyle = FlatStyle.Flat;
            btnentrar.ForeColor = Color.White;
            btnentrar.Location = new Point(758, 313);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(144, 41);
            btnentrar.TabIndex = 7;
            btnentrar.Text = "Aceptar";
            btnentrar.TextColor = Color.White;
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            btnentrar.Enter += btnentrar_Enter;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 58, 107);
            ClientSize = new Size(914, 366);
            ControlBox = false;
            Controls.Add(btnentrar);
            Controls.Add(btncancelar);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private CustomStyle.ClickVentaButton btnminimizer;
        private CustomStyle.ClickVentaButton btnclose;
        private Label label1;
        private Label label2;
        private CustomControls.RJControls.ClickVentaTextBox txtusuario;
        private CustomControls.RJControls.ClickVentaTextBox txtpassword;
        private CustomStyle.ClickVentaButton btncancelar;
        private CustomStyle.ClickVentaButton btnentrar;
    }
}
