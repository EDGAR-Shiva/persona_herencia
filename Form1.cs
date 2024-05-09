using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            //Este codigo permite borrar en contenido de los textBox y deja el codigo abierto
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Este codigo lo que permite es cerrar el programa  
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Guardados");
        }
    }
}
