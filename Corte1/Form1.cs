using Corte1.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        Operacion op = new Operacion();
        
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, ciudad;
            DateTime nacimiento;
         

            try
            {
               
                nombre = tbNombre.Text;
                apellido = tbApellido.Text;
                nacimiento = dtpNacimiento.Value;
                ciudad = cbCiudad.SelectedItem.ToString();
                Persona persona = new Persona(nombre, apellido, nacimiento, ciudad);
                Registro[] per = new Registro[30];
                per[index] = (Registro)persona;
                
                
                index++;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCiudad.Items.Clear();
            cbCiudad.Items.Add("Granada");
            cbCiudad.Items.Add("Masaya");
            cbCiudad.Items.Add("Managua");
            cbCiudad.Items.Add("Leon");
            cbCiudad.Items.Add("Rivas");
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpNacimiento.Value;
            int edad;
            edad = op.Calcular(nacimiento);
            MessageBox.Show(op.Medir(edad));
        }
    }
}
