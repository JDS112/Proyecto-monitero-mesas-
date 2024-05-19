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
    public partial class PantallaReservacion : Form
    {
        public PantallaReservacion()
        {
            InitializeComponent();
            MesaDAO mDAO = new MesaDAO();
            dataGridViewMesas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 25, 28);
            try
            {
                dataGridViewMesas.DataSource = mDAO.getMesas();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string nroTelefono = txtNroTelefono.Text;
            string correo = txtCorreo.Text;
            string fechaStr = txtFecha.Text;
            string horaStr = txtHora.Text;
            int idMesa = int.Parse(txtMesa.Text);

            ReservaDAO rDAO = new ReservaDAO();

            if (DateTime.TryParse(fechaStr, out DateTime fecha) && TimeSpan.TryParse(horaStr, out TimeSpan hora))
            {
                string estado = "Reservado";
                Mesa m = new Mesa(idMesa, estado);
                Reserva r = new Reserva(fecha, hora);
                rDAO.ReservarMesa(nroTelefono, correo, m, r);
                MesaDAO mDAO = new MesaDAO();
                dataGridViewMesas.DataSource = null;
                dataGridViewMesas.DataSource = mDAO.getMesas();
            }
            else
            {
                MessageBox.Show("La fecha o la hora ingresada no es válida. Por favor, verifica los datos.");
            }



        }

        private void dataGridViewMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMesa.Text = dataGridViewMesas.SelectedCells[0].Value.ToString();
        }
    }
}
