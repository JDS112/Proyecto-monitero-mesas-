using EsquizofreniaFinal.DAO;
using EsquizofreniaFinal.Forms;
using EsquizofreniaFinal.Models;
using System.Collections;

namespace EsquizofreniaFinal
{
    public partial class Form1 : Form
    {
        Form pRegister;
        Form sideBar;
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public Form1()
        {
            InitializeComponent();
            txtPwd.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pRegister = new PantallaRegister();

            pRegister.Show();

            this.Hide();
        }
        public bool credencialesValidas()
        {
            if (txtUser.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("Ingrese un nombre de usuario válido.");
            }
            else if (txtPwd.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("Ingrese una contraseña válida.");
            }
            else
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pwd = txtPwd.Text;
            Cliente c = new Cliente(user, pwd);
            ClienteDAO cDAO = new ClienteDAO();
            if (txtUser.Text == "admin" && txtPwd.Text == "admin")
            {
                sideBar = new SideBarAdmin(txtUser.Text);
                MessageBox.Show("Bienvenido administrador");
                sideBar.Show();
                this.Hide();
            }
            else
            {
                if (credencialesValidas())
                {
                    bool estaRegistrado = cDAO.login(c);
                    if (estaRegistrado)
                    {
                        MessageBox.Show("Bienveni2");
                        sideBar = new SideBar(user);

                        sideBar.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usted no esta registrado");

                    }
                }
                else
                {
                    MessageBox.Show("Error: Ingrese usuario y contraseña válidos.");
                }
            }

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