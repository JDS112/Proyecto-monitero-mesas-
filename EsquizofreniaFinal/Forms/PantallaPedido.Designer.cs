namespace EsquizofreniaFinal.Forms
{
    partial class PantallaPedido
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
            dataGridViewMesas = new DataGridView();
            label7 = new Label();
            panel5 = new Panel();
            txtMesa = new TextBox();
            btnPedir = new Button();
            label2 = new Label();
            label3 = new Label();
            labelPrecio = new Label();
            labelPrecioNum = new Label();
            dataGridViewPlatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMesas
            // 
            dataGridViewMesas.AllowUserToAddRows = false;
            dataGridViewMesas.AllowUserToDeleteRows = false;
            dataGridViewMesas.BackgroundColor = Color.FromArgb(30, 33, 38);
            dataGridViewMesas.BorderStyle = BorderStyle.None;
            dataGridViewMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMesas.Location = new Point(664, 74);
            dataGridViewMesas.Name = "dataGridViewMesas";
            dataGridViewMesas.ReadOnly = true;
            dataGridViewMesas.RowTemplate.Height = 25;
            dataGridViewMesas.Size = new Size(217, 347);
            dataGridViewMesas.TabIndex = 16;
            dataGridViewMesas.CellClick += dataGridViewMesas_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 102);
            label7.Name = "label7";
            label7.Size = new Size(91, 17);
            label7.TabIndex = 18;
            label7.Text = "N° de la mesa";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 33, 38);
            panel5.Controls.Add(txtMesa);
            panel5.Location = new Point(12, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(111, 46);
            panel5.TabIndex = 17;
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
            // btnPedir
            // 
            btnPedir.BackColor = Color.DodgerBlue;
            btnPedir.Cursor = Cursors.Hand;
            btnPedir.FlatStyle = FlatStyle.Popup;
            btnPedir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedir.ForeColor = Color.White;
            btnPedir.Location = new Point(12, 189);
            btnPedir.Name = "btnPedir";
            btnPedir.Size = new Size(255, 41);
            btnPedir.TabIndex = 22;
            btnPedir.Text = "Pedir";
            btnPedir.UseVisualStyleBackColor = false;
            btnPedir.Click += btnSiguiente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(674, 46);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 23;
            label2.Text = "Mesas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(433, 46);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 24;
            label3.Text = "Platos";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrecio.ForeColor = Color.White;
            labelPrecio.Location = new Point(12, 46);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(116, 25);
            labelPrecio.TabIndex = 25;
            labelPrecio.Text = "Precio final: ";
            // 
            // labelPrecioNum
            // 
            labelPrecioNum.AutoSize = true;
            labelPrecioNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrecioNum.ForeColor = Color.White;
            labelPrecioNum.Location = new Point(124, 46);
            labelPrecioNum.Name = "labelPrecioNum";
            labelPrecioNum.Size = new Size(27, 25);
            labelPrecioNum.TabIndex = 26;
            labelPrecioNum.Text = "0 ";
            // 
            // dataGridViewPlatos
            // 
            dataGridViewPlatos.AllowUserToAddRows = false;
            dataGridViewPlatos.AllowUserToDeleteRows = false;
            dataGridViewPlatos.BackgroundColor = Color.FromArgb(30, 33, 38);
            dataGridViewPlatos.BorderStyle = BorderStyle.None;
            dataGridViewPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatos.Location = new Point(300, 74);
            dataGridViewPlatos.Name = "dataGridViewPlatos";
            dataGridViewPlatos.ReadOnly = true;
            dataGridViewPlatos.RowTemplate.Height = 25;
            dataGridViewPlatos.Size = new Size(358, 347);
            dataGridViewPlatos.TabIndex = 27;
            dataGridViewPlatos.SelectionChanged += dataGridViewPlatos_SelectionChanged;
            // 
            // PantallaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(884, 465);
            Controls.Add(dataGridViewPlatos);
            Controls.Add(labelPrecioNum);
            Controls.Add(labelPrecio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPedir);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(dataGridViewMesas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPedido";
            Text = "PantallaPedido";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMesas;
        private Label label7;
        private Panel panel5;
        private TextBox txtMesa;
        private Button btnPedir;
        private Label label2;
        private Label label3;
        private Label labelPrecio;
        private Label labelPrecioNum;
        private DataGridView dataGridViewPlatos;
    }
}