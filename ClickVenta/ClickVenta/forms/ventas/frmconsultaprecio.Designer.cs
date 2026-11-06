namespace ClickVenta.forms.ventas
{
    partial class frmconsultaprecio
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
            txtnombreusuario = new CustomControls.RJControls.ClickVentaTextBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(737, 51);
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
            btnclose.Location = new Point(697, 0);
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
            label3.Size = new Size(281, 39);
            label3.TabIndex = 9;
            label3.Text = "Consultar precio";
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
            txtnombreusuario.Location = new Point(13, 19);
            txtnombreusuario.Margin = new Padding(4);
            txtnombreusuario.Multiline = false;
            txtnombreusuario.Name = "txtnombreusuario";
            txtnombreusuario.Padding = new Padding(10, 7, 10, 7);
            txtnombreusuario.PasswordChar = false;
            txtnombreusuario.PlaceholderColor = Color.DarkGray;
            txtnombreusuario.PlaceholderText = "";
            txtnombreusuario.Size = new Size(711, 35);
            txtnombreusuario.TabIndex = 22;
            txtnombreusuario.Texts = "";
            txtnombreusuario.UnderlinedStyle = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtnombreusuario);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 51);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(737, 61);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Codigo de barra o nombre del producto";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 273);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado";
            // 
            // frmconsultaprecio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 414);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmconsultaprecio";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmconsultaprecio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        private Label label3;
        private CustomControls.RJControls.ClickVentaTextBox txtnombreusuario;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
    }
}