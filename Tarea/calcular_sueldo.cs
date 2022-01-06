using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class calcular_sueldo : Form
    {
        public calcular_sueldo()
        {
            InitializeComponent();
        }

        /* ==> calcular sueldo por hora <==*/
        private void btn_Calcular_Sueldo_Click(object sender, EventArgs e)
        {
            double sueldo, horas, resultado;

            sueldo = Convert.ToDouble(txt_Sueldo_Diaro.Text);
            horas = Convert.ToDouble(txt_horas_l.Text);

            resultado = sueldo / horas;

            lbl_r.Text = ("Sueldo por hora:  " + resultado + " ");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
