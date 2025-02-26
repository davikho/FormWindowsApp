using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerform
{
    public partial class Persona1 : Form
    {
        private List<Informacion> listaInformacion = new List<Informacion>();
        public Persona1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaInformacion.Count == 0)
            {
                MessageBox.Show("No hay datos guardados");
                return;
            }

            string mensaje = "";
            foreach (var info in listaInformacion)
            {
                mensaje += $"Nombre: {info.nombre}\nEdad: {info.edad}\nCédula: {info.cedula}\nDirección: {info.direccion}\nComentario: {info.comentario}\n\n";
            }

            MessageBox.Show(mensaje, "Datos guardados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = nombre.Text;
            int edad1 = int.Parse(edad.Text);
            int cedula1 = int.Parse(cedula.Text);
            string direccion1 = direccion.Text;
            string comentario1 = comentario.Text;
            Informacion i = new Informacion(nombre1, edad1, cedula1, direccion1, comentario1);
            listaInformacion.Add(i);
            listBox1.Items.Add(i);
            Crud crud = new Crud();
            crud.agregarObjeto(i);
            MessageBox.Show("Registro creado");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0 && index < listaInformacion.Count)
            {
                Informacion info = listaInformacion[index];

                string mensaje = $"Nombre: {info.nombre}\nEdad: {info.edad}\nCédula: {info.cedula}\nDirección: {info.direccion}\nComentario: {info.comentario}";
                MessageBox.Show(mensaje, "Detalles del registro");
            }

        }
    }
}
