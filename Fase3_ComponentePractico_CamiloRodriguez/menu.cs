using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3_ComponentePractico_CamiloRodriguez
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Esta seguro que desea salir", "Salir De Aire Tour", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bolos pila = new bolos();
            pila.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eps cola = new eps();
            cola.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jardin lista = new jardin();
            lista.Show();
            this.Hide();
        }
    }
}
