using EsquizofreniaFinal.DAO;
using EsquizofreniaFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsquizofreniaFinal.Forms
{
    public partial class PantallaPedido : Form
    {
        Form pSeleccionDePlatos;
        public PantallaPedido()
        {
            InitializeComponent();
            MesaDAO mDAO = new MesaDAO();
            PlatoDAO pDAO = new PlatoDAO();

            dataGridViewMesas.DataSource = mDAO.getMesas();
            dataGridViewPlatos.DataSource = pDAO.getPlatos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            float precioTotal = float.Parse(labelPrecioNum.Text);
            DateTime dateTime = DateTime.Now;
            int idmesa = int.Parse(txtMesa.Text);
            
            string estado = "Ocupado";
            Cuenta c = new Cuenta(idmesa, precioTotal, dateTime);
            CuentaDAO cDAO = new CuentaDAO();
            cDAO.agregarCuenta(c);
            MesaDAO mDAO = new MesaDAO();
            Mesa m = new Mesa(idmesa, estado);
            mDAO.actualizarEstado(m);
            MessageBox.Show("El se realizo con exito. En breve se te entregara el pedido");
            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = mDAO.getMesas();

        }

        private void dataGridViewMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMesa.Text = dataGridViewMesas.SelectedCells[0].Value.ToString();
        }
        private void CalcularTotalSeleccionado()
        {
            DataGridViewColumn columnaPrecio = dataGridViewPlatos.Columns["Precio"];

            if (columnaPrecio != null)
            {
                decimal total = 0;

                foreach (DataGridViewRow fila in dataGridViewPlatos.SelectedRows)
                {
                    if (fila.Cells[columnaPrecio.Index].Value != null)
                    {
                        decimal valor;
                        if (decimal.TryParse(fila.Cells[columnaPrecio.Index].Value.ToString(), out valor))
                        {
                            total += valor;
                        }
                    }
                }

                labelPrecioNum.Text = $"{total}";
            }
            else
            {
                MessageBox.Show("La columna 'Precio' no existe en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPlatos_SelectionChanged(object sender, EventArgs e)
        {
            CalcularTotalSeleccionado();
        }
    }
}
