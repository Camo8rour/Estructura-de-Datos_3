using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fase3_ComponentePractico_CamiloRodriguez
{
    public partial class bolos : Form
    {
        Stack<PilaBolos> pilaBolos = new Stack<PilaBolos>();
        CultureInfo cul = new CultureInfo("es-CO");

        public bolos()
        {
            InitializeComponent();
            double valor = 50000;
            textBox6.Text = valor.ToString("C", cul);
            label11.Hide();
            textBox5.Hide();
        }

        public void limpiarVentana()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.Text = string.Empty;
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ide = textBox1.Text;
            string nombre = textBox2.Text;
            string dicc = textBox3.Text;
            int juga = int.Parse(comboBox1.Text);
            int pist = int.Parse(comboBox2.Text);
            DateTime fechaRe = dateTimePicker1.Value;
            string Afi = comboBox3.SelectedItem.ToString();
            bool afil;

            if (Afi == "Si")
            {
                afil = true;
            }
            else
            {
                afil = false;
            }

            PilaBolos BOLOS = new PilaBolos(ide, nombre, dicc, juga, pist, fechaRe, afil);

            pilaBolos.Push(BOLOS);

            textBox5.Text = pilaBolos.Sum(b => b.getValor()).ToString("C", cul);
            textBox4.Text = BOLOS.getValor().ToString("C", cul);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pilaBolos.ToArray();

            limpiarVentana();
            textBox1.Focus();

            Thread thread = new Thread(() =>
            {
                Thread.Sleep(5000);
                this.Invoke(new Action(() =>
                {
                    textBox4.Text = string.Empty;
                }));
            });

            thread.Start();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pilaBolos.Count != 0)
            {
                DialogResult m = MessageBox.Show("Desea eliminar el regisro de la pila", "ALERTA",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                switch (m)
                {
                    case DialogResult.OK:

                        PilaBolos BOLOS = pilaBolos.Pop();

                        textBox1.Text = BOLOS.Identificacion;
                        textBox1.Text = BOLOS.Nombre;
                        textBox1.Text = BOLOS.Direccion;
                        comboBox1.Text = BOLOS.Jugador.ToString();
                        comboBox2.Text = BOLOS.Pista.ToString();
                        dateTimePicker1.Text = BOLOS.Fecha.ToString();

                        if (BOLOS.Afiliado) comboBox3.Text = "Si";
                        else comboBox3.Text = "No";

                        double totalRecaudado = pilaBolos.Sum(b => b.getValor());
                        textBox5.Text = totalRecaudado.ToString("C", cul);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = pilaBolos.ToArray();

                        MessageBox.Show("Se elimino correctamente el jugador de la pila", "IMPORTANTE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar", "IMPORTANTE",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limpiarVentana();

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            men.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostrarRecaudadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label11.Show();
            textBox5.Show();
        }
    }
}
