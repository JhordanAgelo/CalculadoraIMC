using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double peso = Convert.ToDouble(txtPeso.Text);

            string textoAltura = txtAltura.Text; 
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura*altura);
            MessageBox.Show("Su IMC es de : " + imc);
            
        }
    }
}
