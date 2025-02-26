using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerForm;

namespace primerform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos están vacíos
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Por favor, ingrese ambos números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si no hay números
                }

                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                Operaciones op = new Operaciones();
                string mensaje = ""; // Variable para almacenar los resultados

                // Verificar si al menos un CheckBox está seleccionado
                if (chsuma.Checked || chresta.Checked || chmultiplicar.Checked || chdiv.Checked || chmodu.Checked)
                {
                    if (chsuma.Checked)
                    {
                        mensaje += "Suma: " + op.Sumar(num1, num2) + "\n";
                    }
                    if (chresta.Checked)
                    {
                        mensaje += "Resta: " + op.Restar(num1, num2) + "\n";
                    }
                    if (chmultiplicar.Checked)
                    {
                        mensaje += "Multiplicación: " + op.Multiplicar(num1, num2) + "\n";
                    }
                    if (chdiv.Checked)
                    {
                        try
                        {
                            mensaje += "División: " + op.Dividir(num1, num2) + "\n";
                        }
                        catch (DivideByZeroException)
                        {
                            mensaje += "División: Error (No se puede dividir por cero)\n";
                        }
                    }
                    if (chmodu.Checked)
                    {
                        try
                        {
                            mensaje += "Módulo: " + op.Modulo(num1, num2) + "\n";
                        }
                        catch (DivideByZeroException)
                        {
                            mensaje += "Módulo: Error (No se puede calcular con divisor cero)\n";
                        }
                    }

                    // Mostrar resultados en MessageBox y Label
                    MessageBox.Show(mensaje, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result.Text = mensaje; // Mostrar en un Label o TextBox
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione al menos una operación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona1 p = new Persona1();
            p.Show();

        }
    }
}
