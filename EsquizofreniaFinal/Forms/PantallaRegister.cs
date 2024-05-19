using EsquizofreniaFinal.DAO;
using EsquizofreniaFinal.Models;
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
    public partial class PantallaRegister : Form
    {
        Form Login;
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public PantallaRegister()
        {
            InitializeComponent();
            txtpwd.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string dni = txtDni.Text;
            string pwd = txtpwd.Text;
            Cliente nuevoCliente = new Cliente(user, dni, pwd);
            ClienteDAO cDAO = new ClienteDAO();
            cDAO.registrarCliente(nuevoCliente);
            MessageBox.Show("Cliente registrado");
            Login = new Form1();
            Login.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login = new Form1();
            Login.Show();
            this.Hide();
        }

        private void linkLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;

            }
        }

        private void linkLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));

            }
        }

        private void linkLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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
