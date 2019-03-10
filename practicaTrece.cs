using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaTrece_mcdAndmcm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Declaro una variable lea los dos valores ingresados por el usuario
             * despues, un valor residuo ya que este leera el residuo si deja ser 1
             * se deja de cumplir el ciclo y la auxiliar variable la cual nos servira
             * para guardar un valor*/
            double numeroUno, numeroDos;
            double residuo, maximoComunDivisor, minimoComunMultiplo, auxiliar;


            numeroUno = Convert.ToInt64(txtBox_numeroUno.Text);
            numeroDos = Convert.ToInt64(txtBox_numeroDos.Text);

            /*Despues de que el usuario ingresa los datos, con ayuda de un if
             * se determina si los valores que ingreso son enteros positivos
             * si esto se cumple se realiza la operacion, si no se envia una
             * alerta*/
            if (numeroUno > 0 && numeroDos > 0)
            {

                lblWarning.Text = ("  ");
                maximoComunDivisor = numeroUno;
                auxiliar = numeroDos;
                //con ayuda de un ciclo do while que se cumpla solo cuando el residuo sea diferente a 0
                do
                {
                    /*Por ejemplo nuestros valores son 12 y 18, nuestro residuo es igual
                     * a lo que resulte de 12 % 18*/
                    residuo = maximoComunDivisor % auxiliar;
                    maximoComunDivisor = auxiliar;
                    auxiliar = residuo;
                } while (residuo != 0);

                minimoComunMultiplo = numeroUno * numeroDos / maximoComunDivisor;

                txtBoxMcd.Text = (maximoComunDivisor).ToString();
                txtBoxMcm.Text = (minimoComunMultiplo).ToString();

            }
            else
            {
                lblWarning.Text = ("Ingresa numeros enteros positivos");
            }

        }
    }
}
