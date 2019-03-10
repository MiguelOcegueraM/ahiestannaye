using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaCatorce_numerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUno_generar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int limite;
            limite = Convert.ToInt32(txtBoxUno.Text);

            for(int i = 1; i <= limite; i++)
            {
                int contador = 0;
                for (int h = 1; h <= limite; h++)
                {
                    if (i % h == 0)
                        contador++;
                }
                if (contador == 2)
                {
                    textBox1.Text += i.ToString() + Environment.NewLine;
                }
            }

            

    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 
}
