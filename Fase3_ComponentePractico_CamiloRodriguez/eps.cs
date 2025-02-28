using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3_ComponentePractico_CamiloRodriguez
{
    public partial class eps : Form
    {
        Queue<ColaEPS> pse;
        CultureInfo cul = new CultureInfo("es-CO");

        public eps()
        {
            InitializeComponent();
            pse = new Queue<ColaEPS>();
            label8.Hide();
            textBox5.Hide();
        }

        public void limpiarVentana()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox3.Focus();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Text = string.Empty;
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            men.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            string na = textBox2.Text;
            int ed = int.Parse(textBox3.Text);
            string tiCo = comboBox1.Text;
            DateTime time = dateTimePicker1.Value;

            ColaEPS ps = new ColaEPS(i, na, ed, tiCo, time);

            pse.Enqueue(ps);

            int currentCount;
            if (int.TryParse(textBox5.Text, out currentCount))
            {
                textBox5.Text = (currentCount + 1).ToString();
            }
            else
            {
                textBox5.Text = "1";
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pse.ToArray();
            limpiarVentana();
            textBox1.Focus();

            textBox4.Text = ps.tieEs().ToString();
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
            if (pse.Count != 0)
            {
                DialogResult m = MessageBox.Show("Desea eliminar el registro de la cola", "ALERTA",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                switch (m)
                {
                    case DialogResult.OK:
                        ColaEPS usuElim = pse.Dequeue();
                        textBox1.Text = usuElim.Id;
                        textBox2.Text = usuElim.Name;
                        textBox1.Text = usuElim.Edad.ToString();
                        comboBox1.Text = usuElim.TipCo;
                        dateTimePicker1.Text = usuElim.Fec.ToString();

                        textBox5.Text = (int.Parse(textBox5.Text) - 1).ToString();

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = pse.ToArray();
                        MessageBox.Show("Se elimino el registro de la cola", "IMPORTANTE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar en la cola", "IMPORTANTE",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limpiarVentana();
        }

        private void mostrarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label8.Show();
            textBox5.Show();
        }
    }
}
