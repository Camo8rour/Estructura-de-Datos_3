using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fase3_ComponentePractico_CamiloRodriguez
{
    public partial class jardin : Form
    {
        List<ListaJardin> din;
        public jardin()
        {
            InitializeComponent();
            din = new List<ListaJardin> { };
            limpiarVentana();
        }

        private void limpiarVentana()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void MostrarDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = din.ToArray();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string civi = textBox1.Text;
            string nam = textBox2.Text;
            string con = comboBox1.Text;
            string estr = comboBox2.Text;
            DateTime nac = dateTimePicker1.Value;
            bool Ter = radioButton1.Checked;

            ListaJardin nuEs = new ListaJardin(civi, nam, con, estr, nac, Ter);
            din.Add(nuEs);

            MostrarDGV();
            limpiarVentana();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ciCon = textBox1.Text;
            foreach (var estu in din)
            {
                if (estu.RegistroCivil == ciCon)
                {
                    textBox1.Text = estu.RegistroCivil;
                    textBox2.Text = estu.Nombre;
                    comboBox1.SelectedItem = estu.Condicion;
                    comboBox2.SelectedItem = estu.Estrato;
                    dateTimePicker1.Value = estu.Nacimiento;
                    radioButton1.Checked = estu.Terapia;
                    radioButton2.Checked = !estu.Terapia;
                    eliminarToolStripMenuItem.Enabled = true;
                    break;
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clEli = textBox1.Text;

            foreach (var estu in din)
            {
                if (estu.RegistroCivil == clEli)
                {
                    din.Remove(estu);
                    break;
                }
            }
            eliminarToolStripMenuItem.Enabled = false;
            limpiarVentana();
            MostrarDGV();
        }

        private bool ExisiteCl(string cl)
        {
            return din.Exists(estu => estu.RegistroCivil.Equals(cl));
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            men.Show();
            this.Hide();
        }
    }
}
