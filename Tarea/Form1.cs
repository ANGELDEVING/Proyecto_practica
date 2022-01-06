using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Calcular Sueldo
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sueldos sueldo = new Sueldos();
            sueldo.MdiParent = this;
            sueldo.Show();
        }

        // Registro empleados 
        private void calcularSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados f = new Empleados();
            f.MdiParent = this;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        
    }
}