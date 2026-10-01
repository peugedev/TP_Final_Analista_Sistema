namespace ClickVenta.Message
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            panelTitleBar = new Panel();
            labelCaption = new Label();
            btnClose = new ClickVenta.CustomStyle.ClickVentaButton();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelButtons = new Panel();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            panelTitleBar.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.CornflowerBlue;
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(505, 41);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.ForeColor = SystemColors.Window;
            labelCaption.Location = new Point(22, 10);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(94, 20);
            labelCaption.TabIndex = 1;
            labelCaption.Text = "labelCaption";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.CornflowerBlue;
            btnClose.BorderColor = Color.FromArgb(30, 79, 162);
            btnClose.BorderRadius = 0;
            btnClose.BorderSize = 0;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(465, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 41);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 41);
            panelBody.Margin = new Padding(4, 3, 4, 3);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(505, 190);
            panelBody.TabIndex = 1;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Font = new Font("Microsoft Sans Serif", 10F);
            labelMessage.ForeColor = Color.FromArgb(85, 85, 85);
            labelMessage.Location = new Point(46, 0);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.MaximumSize = new Size(700, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(6, 4, 11, 14);
            labelMessage.Size = new Size(129, 38);
            labelMessage.TabIndex = 4;
            labelMessage.Text = "labelMessage";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Left;
            pictureBoxIcon.Image = (Image)resources.GetObject("pictureBoxIcon.Image");
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Margin = new Padding(4, 3, 4, 3);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(46, 190);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 3;
            pictureBoxIcon.TabStop = false;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button4);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 171);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(505, 60);
            panelButtons.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(379, 9);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(116, 41);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(255, 9);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(116, 41);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10F);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(131, 9);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(116, 41);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 231);
            ControlBox = false;
            Controls.Add(panelButtons);
            Controls.Add(panelBody);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormMessageBox_Load;
            Paint += FormMessageBox_Paint;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelBody;
        private Panel panelButtons;
        private CustomStyle.ClickVentaButton btnClose;
        private Label labelCaption;
        private Label labelMessage;
        private PictureBox pictureBoxIcon;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}