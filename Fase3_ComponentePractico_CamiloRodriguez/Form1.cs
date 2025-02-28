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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegi_Click(object sender, EventArgs e)
        {
            if (textBoxContra.Text != "")
            {

                if (textBoxContra.Text == "123")
                {
                    this.Hide();
                    menu men = new menu();
                    men.ShowDialog();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                    textBoxContra.Text = "";
                    textBoxContra.Focus();
                }

            }
            else
            {
                MessageBox.Show("Por favor digite la contraseña");
                textBoxContra.Focus();
            }
        }
    }
}
