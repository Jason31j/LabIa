using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_IA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //para actualizar etiqueta que muestra la cantidad de movimentos
            InitializeComponent();
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString(); 
        }

        //BLOQUE DE VARIABLES
        // Varible que indican que botón ha sido presionado
        private bool boton1 = false;
        private bool boton2 = false;
        private bool boton3 = false;
        private bool boton4 = false;
        private bool boton5 = false;
        private bool boton6 = false;
        private bool boton7 = false;
        private bool boton8 = false;
        private bool boton9 = false;

        int cont = 0;
        int cont2 = 0;

        //llevará un conteo de la cantidad de movimientos realizados en el juego
        int movimientos = 0; 
                             //INSTRUCCIONES DE FUNCIONAMIENTO

        //FUNCIÓN DE INTERCAMBIOS
        
        //Método para realizar intercambio del botón presionado con el blanco
        public void Intercambio(Button origen, Button destino)
        {
            String aux; //Variable auxiliar para realizar el intercambio

            if (origen.Text != "") // verifica si el botón de origen no está en blanco 
            {
                if (destino.Text == "") // si el botón destino es el blanco,  se realiza el cambio de botones
                {
                    //intercambia los textos del boton origen con el de destino
                    aux = origen.Text;
                    origen.Text = "";
                    destino.Text = aux;
                    ganar();

                }
            }
        }

        //FUNCION DE COMPROBACION DE VICTORIA
        //METODO PARA COMPROBAR SI EL ESTADO ACTUAL ES IGUAL AL ESTADO OBJETIVO
        public void ganar()
        {
            //si todos los botones estan en la posicion preestablecida
            if (btn1.Text == btn1_2.Text && btn2.Text == btn2_2.Text && btn3.Text == btn3_2.Text && btn4.Text == btn4_2.Text && btn5.Text == btn5_2.Text && btn6.Text == btn6_2.Text && btn7.Text == btn7_2.Text && btn8.Text == btn8_2.Text && btn9.Text == btn9_2.Text)
                MessageBox.Show("Haz ganado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //BOTONES

        //BOTON #1
        // Método para el evento  click del botón 1, esquina superior izquierda
        private void btn1_Click(object sender, EventArgs e)
        {
            boton1 = true; // se ha presionado el botón 1
            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn1, btn2);
            Intercambio(btn1, btn4);
        }

        //BOTON #2
        // Método para el evento click del botón 2, posición (1,2)
        private void btn2_Click(object sender, EventArgs e)
        {
            boton2 = true; // se ha presionado el botón 2

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn2, btn1);
            Intercambio(btn2, btn3);
            Intercambio(btn2, btn5);
        }

        //BOTON #3
        // Método para el evento click del botón 3, posición (1,3)
        private void btn3_Click(object sender, EventArgs e)
        {
            boton3 = true; // se ha presionado el botón 3
            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn3, btn6);
            Intercambio(btn3, btn2);
        }

        //BOTON #4
        // Método para el evento click del botón 4, posición (2,1)
        private void btn4_Click(object sender, EventArgs e)
        {
            boton4 = true; // se ha presionado el botón 4

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn4, btn1);
            Intercambio(btn4, btn5);
            Intercambio(btn4, btn7);
        }

        //BOTON #5
        // Método para el evento click del botón 5, posición (2,2)
        private void btn5_Click(object sender, EventArgs e)
        {
            boton5 = true; // se ha presionado el botón 5

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn5, btn2);
            Intercambio(btn5, btn4);
            Intercambio(btn5, btn6);
            Intercambio(btn5, btn8);
        }

        //BOTON #6
        // Método para el evento click del botón 6, posición (2,3)
        private void btn6_Click(object sender, EventArgs e)
        {
            boton6 = true; // se ha presionado el botón 6

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            Intercambio(btn6, btn3);
            Intercambio(btn6, btn5);
            Intercambio(btn6, btn9);
        }

        //BOTON #7
        // Método para el evento click del botón 7, posición (3,1)
        private void btn7_Click(object sender, EventArgs e)
        {
            boton7 = true; // se ha presionado el botón 7

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn7, btn4);
            Intercambio(btn7, btn8);

        }

        //BOTON #8
        // Método para el evento click del botón 8, posición (3,2)
        private void btn8_Click(object sender, EventArgs e)
        {
            boton8 = true; // se ha presionado el botón 8

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn8, btn5);
            Intercambio(btn8, btn7);
            Intercambio(btn8, btn9);

        }

        //BOTON #9
        // Método para el evento click del botón del 9, esquina inferior derecho
        private void btn9_Click(object sender, EventArgs e)
        {
            boton9 = true; // se ha presionado el botón 9

            movimientos++; //actualizamos la cantidad de movimiento realizados
            lblMov.Text = "Cantidad de movimientos: " + movimientos.ToString();

            //intentamos hacer el intercambio entre los botones circundantes
            Intercambio(btn9, btn6);
            Intercambio(btn9, btn8);

        }

        //boton encargado de ingresar los datos al estado inicial
        private void button1_Click(object sender, EventArgs e)
        {
            //contador aux para controlar la entrada de datos
            cont++;

            if (btn1.Text == "" && cont == 1)
                btn1.Text = comboBox.Text;

            if (btn2.Text == "" && cont == 2)
                btn2.Text = comboBox.Text;

            if (btn3.Text == "" && cont == 3)
                btn3.Text = comboBox.Text;

            if (btn4.Text == "" && cont == 4)
                btn4.Text = comboBox.Text;

            if (btn5.Text == "" && cont == 5)
                btn5.Text = comboBox.Text;

            if (btn6.Text == "" && cont == 6)
                btn6.Text = comboBox.Text;

            if (btn7.Text == "" && cont == 7)
                btn7.Text = comboBox.Text;

            if (btn8.Text == "" && cont == 8)
                btn8.Text = comboBox.Text;

            if (btn9.Text == "" && cont == 9)
                btn9.Text = comboBox.Text;
        }

        //boton encargado de ingresar los datos al estado final
        private void button2_Click(object sender, EventArgs e)
        {
            //contador aux para controlar la entrada de datos
            cont2++;
            if (btn1_2.Text == "" && cont2 == 1)
                btn1_2.Text = comboBox1.Text;

            if (btn2_2.Text == "" && cont2 == 2)
                btn2_2.Text = comboBox1.Text;

            if (btn3_2.Text == "" && cont2 == 3)
                btn3_2.Text = comboBox1.Text;

            if (btn4_2.Text == "" && cont2 == 4)
                btn4_2.Text = comboBox1.Text;

            if (btn5_2.Text == "" && cont2 == 5)
                btn5_2.Text = comboBox1.Text;

            if (btn6_2.Text == "" && cont2 == 6)
                btn6_2.Text = comboBox1.Text;

            if (btn7_2.Text == "" && cont2 == 7)
                btn7_2.Text = comboBox1.Text;

            if (btn8_2.Text == "" && cont2 == 8)
                btn8_2.Text = comboBox1.Text;

            if (btn9_2.Text == "" && cont2 == 9)
                btn9_2.Text = comboBox1.Text;
        }

        //boton para iniciar el juego y ocultar los combobox encargados de la entrada de datos
        private void button3_Click(object sender, EventArgs e)
        {
            if (cont == 9 && cont2 == 9)
            {
                comboBox.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
                MessageBox.Show("Por favor llene el estado incial y el final del puzzle.");

        }
    }
}
