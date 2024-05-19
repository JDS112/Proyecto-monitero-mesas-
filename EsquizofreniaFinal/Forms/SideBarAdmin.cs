using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsquizofreniaFinal.Forms
{
    public partial class SideBarAdmin : Form
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public SideBarAdmin(string user)
        {
            InitializeComponent();
            labelUser.Text = user;
        }
        private void AbrirPantalla(object formHija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form form = formHija as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(form);
            this.PanelContenedor.Tag = form;
            form.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            AbrirPantalla(new PantallaMesas());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            AbrirPantalla(new PantallaPlatos());
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;

            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));

            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
