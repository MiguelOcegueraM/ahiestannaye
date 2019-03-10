using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoQuince_tablero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            /*Declaro dos variables las cuales leeran las variables que el usuario ingrese
             * estas deben ser enteras postivas*/
            int filaTextBox = Convert.ToInt32(txtBox_fila.Text);
            int columnaTextBox = Convert.ToInt32(txtBox_columna.Text);
            //Un clear para que limpie el tablero cada que este se le ingresen nuevos valores
            txtBox_tablero.Clear();
            /*La condicional nos dice que si el usuario ingres un numero menor a 1
             * o mayor a 8 este enviara un alerta de que el usuario me debe de dar 
             * un numero entre 1 y 8*/
            if((filaTextBox < 1 && columnaTextBox > 8) || (filaTextBox > 8 && columnaTextBox < 1))
            {
                //Si el usuario ingresa un valor de 0 y 0 tampoco mostrara nada
                txtBox_tablero.Text = "Por favor ingrese valor entre 1 y 8";
            }
            else if (filaTextBox == 0 && columnaTextBox == 0)
            {
                //Si ambos valores son mayores a 8, tampoco mostrara nada
                txtBox_tablero.Text = "Por favor ingrese valor entre 1 y 8";
            }
            else if(filaTextBox > 8 && columnaTextBox > 8)
            {
                txtBox_tablero.Text = "Por favor ingrese valor entre 1 y 8";
            }
            else
            {
                /*el primer ciclo for llenara las filas esto es igual a un arreglo de dos
            * dimensiones que con ayuda de dos ciclos for se llena de forma simetrica*/
                for (int fila = 1; fila <= 8; fila++)
                {
                    //El segundo ciclo for nos ayudara a llenar las comlumnas
                    for (int columna = 1; columna <= 8; columna++)
                    {
                        /*Con ayuda de una condicional sobre los valores que nos de el usuario si este son iguales a la suma de las
                         * filas y columnas hara una x simulando el movimientod de un alfil*/
                        if (((filaTextBox + columnaTextBox) == (fila + columna)) || ((fila - columna) == (filaTextBox - columnaTextBox)))
                        {
                            txtBox_tablero.Text += "* ";
                        }
                        //Si este if no se cumple entonces se dividiras la posicion si esta es par se pondra una B
                        else if ((fila + columna) % 2 == 0)
                        {
                            txtBox_tablero.Text += "B ";
                        }
                        //Si tampoco se cumple entonces se pondra un N
                        else
                        {
                            txtBox_tablero.Text += "N ";
                        }

                    }
                    //El Environment.NewLine nos ayuda a llenar un textbox multilinea
                    txtBox_tablero.Text += Environment.NewLine;
                }
            }
            
        }
    }
}
