using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDoce_factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            //Creamos una variable, la cual fungira como limite del for
            double limite = Convert.ToInt64(txtBox_numero.Text);
            //una variable factorial esta se multiplicara pos si misma
            double factorial = 1;
            //Desde 1 hasta el limite 
            for(int i = 1; i <= limite; i++)
            {
                //factorial seria igual a factorial * 1
                 factorial = factorial * i;
            }
            txtBox_resultado.Text = (factorial).ToString();
        }
    }
}
