namespace EsquizofreniaFinal.Forms
{
    partial class PantallaMesas
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
            btnAñadir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            labelID = new Label();
            panelID = new Panel();
            txtID = new TextBox();
            labelEstado = new Label();
            panelEstado = new Panel();
            txtEstado = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).BeginInit();
            panelID.SuspendLayout();
            panelEstado.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMesas
            // 
            dataGridViewMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMesas.Location = new Point(481, 41);
            dataGridViewMesas.Name = "dataGridViewMesas";
            dataGridViewMesas.RowTemplate.Height = 25;
            dataGridViewMesas.Size = new Size(289, 374);
            dataGridViewMesas.TabIndex = 0;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.DodgerBlue;
            btnAñadir.Cursor = Cursors.Hand;
            btnAñadir.FlatStyle = FlatStyle.Popup;
            btnAñadir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAñadir.ForeColor = Color.White;
            btnAñadir.Location = new Point(194, 41);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(255, 41);
            btnAñadir.TabIndex = 7;
            btnAñadir.Text = "Añadir nueva mesa";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DodgerBlue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(194, 121);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(255, 41);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar mesa";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DodgerBlue;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(194, 199);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(255, 41);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar mesa";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(194, 255);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 17);
            labelID.TabIndex = 12;
            labelID.Text = "ID";
            labelID.Visible = false;
            // 
            // panelID
            // 
            panelID.BackColor = Color.FromArgb(30, 33, 38);
            panelID.Controls.Add(txtID);
            panelID.Location = new Point(194, 275);
            panelID.Name = "panelID";
            panelID.Size = new Size(109, 46);
            panelID.TabIndex = 11;
            panelID.Visible = false;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(30, 33, 38);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.ForeColor = SystemColors.Info;
            txtID.Location = new Point(16, 15);
            txtID.Name = "txtID";
            txtID.Size = new Size(71, 18);
            txtID.TabIndex = 0;
            txtID.Visible = false;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEstado.ForeColor = Color.White;
            labelEstado.Location = new Point(322, 255);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(48, 17);
            labelEstado.TabIndex = 14;
            labelEstado.Text = "Estado";
            labelEstado.Visible = false;
            // 
            // panelEstado
            // 
            panelEstado.BackColor = Color.FromArgb(30, 33, 38);
            panelEstado.Controls.Add(txtEstado);
            panelEstado.Location = new Point(322, 275);
            panelEstado.Name = "panelEstado";
            panelEstado.Size = new Size(126, 46);
            panelEstado.TabIndex = 13;
            panelEstado.Visible = false;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = Color.FromArgb(30, 33, 38);
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.ForeColor = SystemColors.Info;
            txtEstado.Location = new Point(16, 15);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(95, 18);
            txtEstado.TabIndex = 0;
            txtEstado.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(194, 327);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(255, 41);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // PantallaMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(884, 461);
            Controls.Add(btnGuardar);
            Controls.Add(labelEstado);
            Controls.Add(panelEstado);
            Controls.Add(labelID);
            Controls.Add(panelID);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAñadir);
            Controls.Add(dataGridViewMesas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaMesas";
            Text = "PantallaMesas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).EndInit();
            panelID.ResumeLayout(false);
            panelID.PerformLayout();
            panelEstado.ResumeLayout(false);
            panelEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMesas;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnModificar;
        private Label labelID;
        private Panel panelID;
        private TextBox txtID;
        private Label labelEstado;
        private Panel panelEstado;
        private TextBox txtEstado;
        private Button btnGuardar;
    }
}