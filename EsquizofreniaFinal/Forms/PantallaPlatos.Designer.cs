namespace EsquizofreniaFinal.Forms
{
    partial class PantallaPlatos
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
            label3 = new Label();
            panel3 = new Panel();
            txtNombre = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txtTamaño = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            txtPrecio = new TextBox();
            btnAñadir = new Button();
            dataGridViewPlatos = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 71);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 12;
            label3.Text = "Nombre del plato";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 33, 38);
            panel3.Controls.Add(txtNombre);
            panel3.Location = new Point(27, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 46);
            panel3.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(30, 33, 38);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = SystemColors.Info;
            txtNombre.Location = new Point(16, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 18);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 153);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 14;
            label1.Text = "Tamaño";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 33, 38);
            panel1.Controls.Add(txtTamaño);
            panel1.Location = new Point(27, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 46);
            panel1.TabIndex = 13;
            // 
            // txtTamaño
            // 
            txtTamaño.BackColor = Color.FromArgb(30, 33, 38);
            txtTamaño.BorderStyle = BorderStyle.None;
            txtTamaño.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTamaño.ForeColor = SystemColors.Info;
            txtTamaño.Location = new Point(16, 15);
            txtTamaño.Name = "txtTamaño";
            txtTamaño.Size = new Size(223, 18);
            txtTamaño.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 239);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 16;
            label2.Text = "Precio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 33, 38);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPrecio);
            panel2.Location = new Point(27, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 46);
            panel2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(224, 15);
            label4.Name = "label4";
            label4.Size = new Size(15, 17);
            label4.TabIndex = 17;
            label4.Text = "$";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(30, 33, 38);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = SystemColors.Info;
            txtPrecio.Location = new Point(16, 15);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(223, 18);
            txtPrecio.TabIndex = 0;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.DodgerBlue;
            btnAñadir.Cursor = Cursors.Hand;
            btnAñadir.FlatStyle = FlatStyle.Popup;
            btnAñadir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAñadir.ForeColor = Color.White;
            btnAñadir.Location = new Point(27, 334);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(255, 41);
            btnAñadir.TabIndex = 17;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // dataGridViewPlatos
            // 
            dataGridViewPlatos.AllowUserToAddRows = false;
            dataGridViewPlatos.AllowUserToDeleteRows = false;
            dataGridViewPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatos.Location = new Point(384, 91);
            dataGridViewPlatos.Name = "dataGridViewPlatos";
            dataGridViewPlatos.ReadOnly = true;
            dataGridViewPlatos.RowTemplate.Height = 25;
            dataGridViewPlatos.Size = new Size(452, 284);
            dataGridViewPlatos.TabIndex = 18;
            // 
            // PantallaPlatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(884, 461);
            Controls.Add(dataGridViewPlatos);
            Controls.Add(btnAñadir);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPlatos";
            Text = "PantallaPlatos";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel3;
        private TextBox txtNombre;
        private Label label1;
        private Panel panel1;
        private TextBox txtTamaño;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private TextBox txtPrecio;
        private Button btnAñadir;
        private DataGridView dataGridViewPlatos;
    }
}