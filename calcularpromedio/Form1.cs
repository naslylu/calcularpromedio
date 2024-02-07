using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularpromedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CalcularPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                double P1 = Convert.ToDouble(txt_P1.Text);
                double P2 = Convert.ToDouble(txt_P2.Text);
                double P3 = Convert.ToDouble(txt_P3.Text);
                double P4 = Convert.ToDouble(txt_P4.Text);

                double Promedio = (P1 + P2 + P3 + P4) / 4;

                MessageBox.Show($"El promedio del estudiantes es de: {Promedio}", "Promedio Calculado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BorrarTodo_Click(object sender, EventArgs e)
        {
            txt_P1.Clear();
            txt_P2.Clear();
            txt_P3.Clear();
            txt_P4.Clear();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
