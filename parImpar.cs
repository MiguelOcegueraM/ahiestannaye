using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            /*Declaro una variable entera la cual le pedira al usuario
            un numero en el que se detendra el conteo*/
            int numeroUsuario = Convert.ToInt32(txtBox_numeroUno.Text);
            int numeroUsuarioDos = Convert.ToInt32(txtBox_numeroDos.Text);
            //Cada que de click en el boton y los listbox no acumulen
            //datos, aplicaremos un clear() para que los anteriores se elimininen
            listImpar.Items.Clear();
            listPares.Items.Clear();
            //generamos un ciclo que vaya de uno hasta el limite establecido por
            //el usuario
            for (int i = numeroUsuarioDos; i <= numeroUsuario; i++)
            {
                //Si el numero no tiene residuo es Par
                if(i % 2 == 0)
                {
                    //mostramos los datos en listbox con .add()
                    listPares.Items.Add(i);
                }
                //Pero si deja residuo es impar
                else
                {
                    listImpar.Items.Add(i);
                }
            
            }
        }

        private void btnGeneraMayorMenor_Click(object sender, EventArgs e)
        {
            int contador = Convert.ToInt32(txtBox_numeroUno.Text);
            int numeroUsuarioDos = Convert.ToInt32(txtBox_numeroDos.Text);
            listImpar.Items.Clear();
            listPares.Items.Clear();
            //un while que mientras el contador no sea igual a 0 se cumple
            while (contador != numeroUsuarioDos)
            {
                //el contador va disminuyendo este es igual al valor dado por el usuario
                contador--;
                if (contador % 2 == 0)
                {
                    //mostramos los datos en listbox con .add()
                    listPares.Items.Add(contador);
                }
                //Pero si deja residuo es impar
                else
                {
                    listImpar.Items.Add(contador);
                }
            }
        }
    }
}
