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
    public partial class PantallaMesas : Form
    {
        DataTable mesasDataTable;
        public PantallaMesas()
        {
            InitializeComponent();
            MesaDAO m = new MesaDAO();
            dataGridViewMesas.AllowUserToAddRows = false;
            mesasDataTable = m.getMesas();
            dataGridViewMesas.DataSource = mesasDataTable;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string estado = "Disponible";
            Mesa m = new Mesa(estado);
            MesaDAO mDAO = new MesaDAO();
            mDAO.agregarMesa(m);
            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = mDAO.getMesas();


        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewMesas.SelectedCells[0].Value.ToString());
            MesaDAO m = new MesaDAO();
            m.eliminarMesa(id);

            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = m.getMesas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            labelID.Visible = true;
            labelEstado.Visible = true;
            txtID.Visible = true;
            txtEstado.Visible = true;
            panelEstado.Visible = true;
            panelID.Visible = true;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string estado = txtEstado.Text;
            Mesa m = new Mesa(id,estado);
            MesaDAO mDAO = new MesaDAO();
            mDAO.actualizarEstado(m);

            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = mDAO.getMesas();
        }
    }
}
