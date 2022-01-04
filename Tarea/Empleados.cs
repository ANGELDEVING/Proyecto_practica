using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        // >>>==> [ btn_Close Form ] <== <<<//

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // === [ Add to dta_Datos ] === //

        private void button1_Click_1(object sender, EventArgs e)
        {
            // calculando 

            dta_Datos.Rows.Add(txt_numero_empleados.Text, txt_sueldo.Text);
            txt_sueldo.Text = " ";
            txt_numero_empleados.Text = " ";
        }

    }
}
