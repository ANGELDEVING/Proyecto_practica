using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Sueldos : Form
    {
        public Sueldos()
        {
            InitializeComponent();
        }


        // ==> Calcular <==//
        private void btn_calcular_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                double n1, resultado = 0, tExtra = 0, dias, horas;
                String nombre;

                nombre = Convert.ToString(txt_nombre.Text);
                dias = Convert.ToDouble(txt_horas.Text);
                horas = Convert.ToDouble(txt_horas.Text);
                n1 = Convert.ToInt32(txt_sueldo.Text);

                resultado = (n1 * dias);
                //resultado2 = ((n1 * horas) + bono);


                //pendiente....

                if (horas < 48)
                {
                    resultado = (n1 * horas);
                    lst_resultado.Items.Add("El pago de " + nombre + " es " + resultado + " ");
                }
                else if (horas > 48)
                {
                    tExtra = horas * 33 + resultado;
                    lst_resultado.Items.Add("El pago con tiempo extra de  " + nombre + " es " + tExtra + " ");
                }

                {

                }

                //lst_resultado.Items.Add("El pago de neto es " +resultado2+ " ");
                txt_horas.Text = " ";
                txt_nombre.Text = " ";
                txt_horasExtra.Text = " ";
                txt_sueldo.Text = " ";


            }
            catch (Exception fail)
            {
                MessageBox.Show("Lo sentimos ingrese parametros correctos:" + fail);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_salir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sueldos_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular_sueldo f = new calcular_sueldo();
            f.Show();
        }
    }
}
