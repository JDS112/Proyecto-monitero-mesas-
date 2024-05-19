namespace EsquizofreniaFinal.Forms
{
    partial class PantallaReservacion
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
            panel3 = new Panel();
            txtNroTelefono = new TextBox();
            panel1 = new Panel();
            txtCorreo = new TextBox();
            panel2 = new Panel();
            txtFecha = new TextBox();
            panel4 = new Panel();
            txtHora = new TextBox();
            panel5 = new Panel();
            txtMesa = new TextBox();
            btnReservar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridViewMesas = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 33, 38);
            panel3.Controls.Add(txtNroTelefono);
            panel3.Location = new Point(72, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 46);
            panel3.TabIndex = 2;
            // 
            // txtNroTelefono
            // 
            txtNroTelefono.BackColor = Color.FromArgb(30, 33, 38);
            txtNroTelefono.BorderStyle = BorderStyle.None;
            txtNroTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroTelefono.ForeColor = SystemColors.Info;
            txtNroTelefono.Location = new Point(16, 15);
            txtNroTelefono.Name = "txtNroTelefono";
            txtNroTelefono.Size = new Size(223, 18);
            txtNroTelefono.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 33, 38);
            panel1.Controls.Add(txtCorreo);
            panel1.Location = new Point(72, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 46);
            panel1.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(30, 33, 38);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = SystemColors.Info;
            txtCorreo.Location = new Point(16, 15);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(223, 18);
            txtCorreo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 33, 38);
            panel2.Controls.Add(txtFecha);
            panel2.Location = new Point(72, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(111, 46);
            panel2.TabIndex = 3;
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(30, 33, 38);
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.ForeColor = SystemColors.Info;
            txtFecha.Location = new Point(16, 15);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(79, 18);
            txtFecha.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 33, 38);
            panel4.Controls.Add(txtHora);
            panel4.Location = new Point(216, 259);
            panel4.Name = "panel4";
            panel4.Size = new Size(111, 46);
            panel4.TabIndex = 4;
            // 
            // txtHora
            // 
            txtHora.BackColor = Color.FromArgb(30, 33, 38);
            txtHora.BorderStyle = BorderStyle.None;
            txtHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHora.ForeColor = SystemColors.Info;
            txtHora.Location = new Point(16, 15);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(79, 18);
            txtHora.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 33, 38);
            panel5.Controls.Add(txtMesa);
            panel5.Location = new Point(72, 333);
            panel5.Name = "panel5";
            panel5.Size = new Size(111, 46);
            panel5.TabIndex = 5;
            // 
            // txtMesa
            // 
            txtMesa.BackColor = Color.FromArgb(30, 33, 38);
            txtMesa.BorderStyle = BorderStyle.None;
            txtMesa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMesa.ForeColor = SystemColors.Info;
            txtMesa.Location = new Point(16, 15);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(79, 18);
            txtMesa.TabIndex = 0;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.DodgerBlue;
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatStyle = FlatStyle.Popup;
            btnReservar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservar.ForeColor = Color.White;
            btnReservar.Location = new Point(72, 385);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(255, 41);
            btnReservar.TabIndex = 6;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 84);
            label3.Name = "label3";
            label3.Size = new Size(127, 17);
            label3.TabIndex = 10;
            label3.Text = "Número de telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 161);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 11;
            label4.Text = "Correo electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 239);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 12;
            label5.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(216, 239);
            label6.Name = "label6";
            label6.Size = new Size(37, 17);
            label6.TabIndex = 13;
            label6.Text = "Hora";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(72, 313);
            label7.Name = "label7";
            label7.Size = new Size(91, 17);
            label7.TabIndex = 14;
            label7.Text = "N° de la mesa";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridViewMesas
            // 
            dataGridViewMesas.AllowUserToAddRows = false;
            dataGridViewMesas.AllowUserToDeleteRows = false;
            dataGridViewMesas.BackgroundColor = Color.FromArgb(30, 33, 38);
            dataGridViewMesas.BorderStyle = BorderStyle.None;
            dataGridViewMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMesas.Location = new Point(437, 34);
            dataGridViewMesas.Name = "dataGridViewMesas";
            dataGridViewMesas.ReadOnly = true;
            dataGridViewMesas.RowTemplate.Height = 25;
            dataGridViewMesas.Size = new Size(389, 387);
            dataGridViewMesas.TabIndex = 15;
            dataGridViewMesas.CellClick += dataGridViewMesas_CellClick;
            // 
            // PantallaReservacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(884, 461);
            Controls.Add(dataGridViewMesas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnReservar);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaReservacion";
            Text = "PantallaReservacion";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox txtNroTelefono;
        private Panel panel1;
        private TextBox txtCorreo;
        private Panel panel2;
        private TextBox txtFecha;
        private Panel panel4;
        private TextBox txtHora;
        private Panel panel5;
        private TextBox txtMesa;
        private Button btnReservar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridViewMesas;
    }
}