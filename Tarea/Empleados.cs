using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Empleados : Form
    {
        //la empresa envios orientales cxa, Necesita determinar el sueldo Neto de todos sus empleados
        /*pero sin ningun descuento. La empresa le concedera a todos sus empleados un bono de 10.000.00 
        por concepto del aniversario de la organizacion Determinar cual sera el valor total que cobrara el empleado incluyendo su sueldo
        bruto, (Es decir, que se determine el sueldo neto a cobrar*/

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // >>>==> [ btn_Close Form ] <== <<<//

            this.Close();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            // === [ Add to dta_Datos ] === //

            dta_Datos.Rows.Add(txt_numero_empleados.Text, txt_sueldo.Text, txt_empleado.Text, txt_curp.Text, txt_rfc.Text);
            txt_sueldo.Text = " ";
            txt_numero_empleados.Text = " ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
