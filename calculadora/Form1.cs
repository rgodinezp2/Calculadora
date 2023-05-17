using System;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {

        string operador;
        double primero;
        double segundo;


        Clases.ClassSuma obj1 = new Clases.ClassSuma();
        Clases.ClassResta obj2 = new Clases.ClassResta();
        Clases.ClassMultiplica obj3 = new Clases.ClassMultiplica();
        Clases.ClassDivide obj4 = new Clases.ClassDivide();


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //  pantalla.Text = pantalla.Text + "=";
            segundo = double.Parse(pantalla.Text);

            double sum;
            double rest;
            double mult;
            double div;

            switch (operador)
            {
                case "+":
                    sum = obj1.suma((primero), (segundo));
                    pantalla.Text = sum.ToString();
                    primero = sum;
                    break;

                case "-":
                    rest = obj2.resta((primero), (segundo));
                    pantalla.Text = rest.ToString();
                    primero = rest;
                    break;

                case "*":
                    mult = obj3.multiplica((primero), (segundo));
                    pantalla.Text = mult.ToString();
                    primero = mult;
                    break;

                case "/":
                    div = obj4.divide((primero), (segundo));
                    pantalla.Text = div.ToString();
                    primero = div;
                    break;

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ",";

        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonMultiplica_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonDivide_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonBorraTodo_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void botonBorra_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
                pantalla.Text = "";
            else
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
        }

        private void botonApaga_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
