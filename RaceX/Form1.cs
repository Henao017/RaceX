using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceX
{
    public partial class Form1 : Form
    {
        private Carrera carrera = new Carrera();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string tipo = cmbTipo.SelectedItem.ToString();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Debe ingresar un nombre y seleccionar un tipo de auto.");
                    return;
                }

                Auto nuevoAuto = AutoFactory.CrearAuto(tipo, nombre);
                carrera.AgregarAuto(nuevoAuto);
                txtNombre.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClima.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un clima.");
                    return;
                }

                carrera.Clima = cmbClima.SelectedItem.ToString();
                carrera.IniciarCarrera();

                MessageBox.Show("¡Carrera iniciada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            string log = carrera.Turno();

            dataGridResultados.Rows.Clear();
            foreach (var auto in carrera.Participantes)
            {
                dataGridResultados.Rows.Add(auto.Nombre, auto.Tipo, auto.DistanciaRecorrida);
            }

            txtLog.Text += log + Environment.NewLine;

            if (carrera.CarreraFinalizada)
            {
                MessageBox.Show($"¡{carrera.Ganador.Nombre} ha ganado la carrera!");
                btnTurno.Enabled = false;
            }
        }

        private void dataGridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            carrera.Reiniciar();
            dataGridResultados.Rows.Clear();
            txtLog.Clear();
            btnTurno.Enabled = true;
            MessageBox.Show("Carrera reiniciada.");
        }
    }
}
