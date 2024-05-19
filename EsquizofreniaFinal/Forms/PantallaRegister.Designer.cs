namespace EsquizofreniaFinal.Forms
{
    partial class PantallaRegister
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
            label4 = new Label();
            panel5 = new Panel();
            txtpwd = new TextBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            txtDni = new TextBox();
            panel3 = new Panel();
            txtUser = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            btnClose = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 25, 28);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(163, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 461);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(147, 271);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 10;
            label4.Text = "Contraseña";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 33, 38);
            panel5.Controls.Add(txtpwd);
            panel5.Location = new Point(147, 291);
            panel5.Name = "panel5";
            panel5.Size = new Size(255, 46);
            panel5.TabIndex = 9;
            // 
            // txtpwd
            // 
            txtpwd.BackColor = Color.FromArgb(30, 33, 38);
            txtpwd.BorderStyle = BorderStyle.None;
            txtpwd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtpwd.ForeColor = SystemColors.Info;
            txtpwd.Location = new Point(16, 15);
            txtpwd.Name = "txtpwd";
            txtpwd.PasswordChar = '*';
            txtpwd.Size = new Size(223, 18);
            txtpwd.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(299, 411);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Haz click aqui";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.MouseDown += linkLabel1_MouseDown;
            linkLabel1.MouseMove += linkLabel1_MouseMove;
            linkLabel1.MouseUp += linkLabel1_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.esquizofrenia;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(243, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 69);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(147, 356);
            button1.Name = "button1";
            button1.Size = new Size(255, 41);
            button1.TabIndex = 5;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(163, 409);
            label3.Name = "label3";
            label3.Size = new Size(135, 17);
            label3.TabIndex = 7;
            label3.Text = "¿Ya tenes una cuenta?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(147, 188);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 4;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 103);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 3;
            label1.Text = "Nombre de usuario";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 33, 38);
            panel4.Controls.Add(txtDni);
            panel4.Location = new Point(147, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 46);
            panel4.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(30, 33, 38);
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = SystemColors.Info;
            txtDni.Location = new Point(16, 15);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(223, 18);
            txtDni.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 33, 38);
            panel3.Controls.Add(txtUser);
            panel3.Location = new Point(147, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 46);
            panel3.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(30, 33, 38);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = SystemColors.Info;
            txtUser.Location = new Point(16, 15);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(223, 18);
            txtUser.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 33, 38);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 31);
            panel2.TabIndex = 2;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.minize;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(819, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 25);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(853, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 25);
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // PantallaRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(884, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegister";
            Text = "PantallaRegister";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private TextBox txtDni;
        private Panel panel3;
        private TextBox txtUser;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox btnClose;
        private Label label4;
        private Panel panel5;
        private TextBox txtpwd;
    }
}