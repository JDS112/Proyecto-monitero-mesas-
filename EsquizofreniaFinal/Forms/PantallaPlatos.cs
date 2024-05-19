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
    public partial class PantallaPlatos : Form
    {
        public PantallaPlatos()
        {
            InitializeComponent();
            PlatoDAO pDAO = new PlatoDAO();
            dataGridViewPlatos.DataSource = pDAO.getPlatos();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string tamaño = txtTamaño.Text;
            float precio = float.Parse(txtPrecio.Text);
            Plato p = new Plato(nombre, tamaño, precio);
            PlatoDAO platoDAO = new PlatoDAO();
            platoDAO.AñadirPlato(p);

            dataGridViewPlatos.DataSource = null;
            dataGridViewPlatos.DataSource = platoDAO.getPlatos();
        }
    }
}
