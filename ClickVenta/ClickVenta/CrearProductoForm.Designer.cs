namespace ClickVenta
{
    partial class CrearProductoForm
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
            clickVentaTextBox1 = new CustomControls.RJControls.ClickVentaTextBox();
            clickVentaTextBox2 = new CustomControls.RJControls.ClickVentaTextBox();
            nombreProductoLabel = new Label();
            codigoProductoLabel = new Label();
            activoRadioButton = new RadioButton();
            inactivoRadioButton = new RadioButton();
            guardarButton = new ClickVenta.CustomStyle.ClickVentaButton();
            cancelarButton = new ClickVenta.CustomStyle.ClickVentaButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            numericUpDown1 = new NumericUpDown();
            precioLabel = new Label();
            descripcionTextBox = new TextBox();
            categoriaDropDownBox = new ComboBox();
            categoriaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // clickVentaTextBox1
            // 
            clickVentaTextBox1.BackColor = SystemColors.Window;
            clickVentaTextBox1.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox1.BorderFocusColor = Color.HotPink;
            clickVentaTextBox1.BorderRadius = 0;
            clickVentaTextBox1.BorderSize = 2;
            clickVentaTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox1.Location = new Point(12, 62);
            clickVentaTextBox1.Margin = new Padding(4);
            clickVentaTextBox1.Multiline = false;
            clickVentaTextBox1.Name = "clickVentaTextBox1";
            clickVentaTextBox1.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox1.PasswordChar = false;
            clickVentaTextBox1.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox1.PlaceholderText = "";
            clickVentaTextBox1.Size = new Size(250, 31);
            clickVentaTextBox1.TabIndex = 0;
            clickVentaTextBox1.Texts = "";
            clickVentaTextBox1.UnderlinedStyle = false;
            // 
            // clickVentaTextBox2
            // 
            clickVentaTextBox2.BackColor = SystemColors.Window;
            clickVentaTextBox2.BorderColor = Color.MediumSlateBlue;
            clickVentaTextBox2.BorderFocusColor = Color.HotPink;
            clickVentaTextBox2.BorderRadius = 0;
            clickVentaTextBox2.BorderSize = 2;
            clickVentaTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickVentaTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            clickVentaTextBox2.Location = new Point(306, 62);
            clickVentaTextBox2.Margin = new Padding(4);
            clickVentaTextBox2.Multiline = false;
            clickVentaTextBox2.Name = "clickVentaTextBox2";
            clickVentaTextBox2.Padding = new Padding(10, 7, 10, 7);
            clickVentaTextBox2.PasswordChar = false;
            clickVentaTextBox2.PlaceholderColor = Color.DarkGray;
            clickVentaTextBox2.PlaceholderText = "";
            clickVentaTextBox2.Size = new Size(250, 31);
            clickVentaTextBox2.TabIndex = 1;
            clickVentaTextBox2.Texts = "";
            clickVentaTextBox2.UnderlinedStyle = false;
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new Point(12, 43);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new Size(130, 15);
            nombreProductoLabel.TabIndex = 2;
            nombreProductoLabel.Text = "Nombre del producto *";
            // 
            // codigoProductoLabel
            // 
            codigoProductoLabel.AutoSize = true;
            codigoProductoLabel.Location = new Point(306, 43);
            codigoProductoLabel.Name = "codigoProductoLabel";
            codigoProductoLabel.Size = new Size(106, 15);
            codigoProductoLabel.TabIndex = 3;
            codigoProductoLabel.Text = "Codigo Producto *";
            // 
            // activoRadioButton
            // 
            activoRadioButton.AutoSize = true;
            activoRadioButton.Checked = true;
            activoRadioButton.Location = new Point(625, 65);
            activoRadioButton.Name = "activoRadioButton";
            activoRadioButton.Size = new Size(59, 19);
            activoRadioButton.TabIndex = 2;
            activoRadioButton.TabStop = true;
            activoRadioButton.Text = "Activo";
            activoRadioButton.UseVisualStyleBackColor = true;
            activoRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // inactivoRadioButton
            // 
            inactivoRadioButton.AutoSize = true;
            inactivoRadioButton.Location = new Point(708, 65);
            inactivoRadioButton.Name = "inactivoRadioButton";
            inactivoRadioButton.Size = new Size(67, 19);
            inactivoRadioButton.TabIndex = 3;
            inactivoRadioButton.Text = "Inactivo";
            inactivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // guardarButton
            // 
            guardarButton.BackColor = Color.FromArgb(30, 79, 162);
            guardarButton.BorderColor = Color.FromArgb(30, 79, 162);
            guardarButton.BorderRadius = 5;
            guardarButton.BorderSize = 2;
            guardarButton.FlatAppearance.BorderSize = 0;
            guardarButton.FlatStyle = FlatStyle.Flat;
            guardarButton.ForeColor = Color.White;
            guardarButton.Location = new Point(532, 383);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(109, 31);
            guardarButton.TabIndex = 6;
            guardarButton.Text = "Guardar";
            guardarButton.TextColor = Color.White;
            guardarButton.UseVisualStyleBackColor = false;
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = Color.WhiteSmoke;
            cancelarButton.BorderColor = Color.Gainsboro;
            cancelarButton.BorderRadius = 5;
            cancelarButton.BorderSize = 2;
            cancelarButton.FlatAppearance.BorderSize = 0;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.ForeColor = Color.Black;
            cancelarButton.Location = new Point(657, 383);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(118, 31);
            cancelarButton.TabIndex = 7;
            cancelarButton.Text = "Cancelar";
            cancelarButton.TextColor = Color.Black;
            cancelarButton.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 138);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new Point(12, 120);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new Size(146, 15);
            precioLabel.TabIndex = 8;
            precioLabel.Text = "Precio Compra Producto *";
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(12, 204);
            descripcionTextBox.Multiline = true;
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.PlaceholderText = "Descripcion opcional del Producto";
            descripcionTextBox.Size = new Size(544, 144);
            descripcionTextBox.TabIndex = 9;
            // 
            // categoriaDropDownBox
            // 
            categoriaDropDownBox.FormattingEnabled = true;
            categoriaDropDownBox.Location = new Point(306, 133);
            categoriaDropDownBox.Name = "categoriaDropDownBox";
            categoriaDropDownBox.Size = new Size(250, 23);
            categoriaDropDownBox.TabIndex = 10;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new Point(306, 115);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(134, 15);
            categoriaLabel.TabIndex = 11;
            categoriaLabel.Text = "Categoria de producto *";
            // 
            // CrearProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(categoriaLabel);
            Controls.Add(categoriaDropDownBox);
            Controls.Add(descripcionTextBox);
            Controls.Add(precioLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(cancelarButton);
            Controls.Add(guardarButton);
            Controls.Add(inactivoRadioButton);
            Controls.Add(activoRadioButton);
            Controls.Add(codigoProductoLabel);
            Controls.Add(nombreProductoLabel);
            Controls.Add(clickVentaTextBox2);
            Controls.Add(clickVentaTextBox1);
            Name = "CrearProductoForm";
            Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox1;
        private CustomControls.RJControls.ClickVentaTextBox clickVentaTextBox2;
        private Label nombreProductoLabel;
        private Label codigoProductoLabel;
        private RadioButton activoRadioButton;
        private RadioButton inactivoRadioButton;
        private CustomStyle.ClickVentaButton guardarButton;
        private CustomStyle.ClickVentaButton cancelarButton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private NumericUpDown numericUpDown1;
        private Label precioLabel;
        private TextBox descripcionTextBox;
        private ComboBox categoriaDropDownBox;
        private Label categoriaLabel;
    }
}