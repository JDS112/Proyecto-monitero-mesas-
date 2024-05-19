namespace EsquizofreniaFinal.Forms
{
    partial class SideBar
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
            labelUser = new Label();
            label2 = new Label();
            btnPedido = new Button();
            btnReserva = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnClose = new PictureBox();
            pictureBox2 = new PictureBox();
            PanelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 25, 28);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnPedido);
            panel1.Controls.Add(btnReserva);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 561);
            panel1.TabIndex = 0;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.White;
            labelUser.Location = new Point(118, 121);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(0, 17);
            labelUser.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 121);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 25;
            label2.Text = "Bienvenido ";
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(30, 33, 38);
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(0, 225);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(223, 38);
            btnPedido.TabIndex = 9;
            btnPedido.Text = "Realizar pedido";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.FromArgb(30, 33, 38);
            btnReserva.FlatStyle = FlatStyle.Popup;
            btnReserva.ForeColor = Color.White;
            btnReserva.Location = new Point(0, 191);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(223, 38);
            btnReserva.TabIndex = 8;
            btnReserva.Text = "Reservar";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.esquizofrenia;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(70, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 69);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 33, 38);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(223, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 30);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(930, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 25);
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.minize;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(902, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 25);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(64, 64, 64);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(223, 30);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(961, 531);
            PanelContenedor.TabIndex = 2;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1184, 561);
            Controls.Add(PanelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SideBar";
            Text = "SideBar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnReserva;
        private Button btnPedido;
        private PictureBox pictureBox2;
        private PictureBox btnClose;
        private Label labelUser;
        private Label label2;
        private Panel PanelContenedor;
    }
}