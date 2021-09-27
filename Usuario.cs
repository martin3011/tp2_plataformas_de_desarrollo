using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TP2_GRUPO5
{
    public partial class Usuario : Form

   

    {
        public Usuario()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj1 = new Form1();
            obj1.Show();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
    }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtNombre.Text == "")

            {
                MessageBox.Show("Por favor, ingresar nombre del Usuario.");
            }
            else if (txtApellido.Text == "")

            {
                MessageBox.Show("Por favor, ingresar Apellido del Usuario.");
            }
            else if (txtDNI.Text == "")

            {
                MessageBox.Show("Por favor, ingresar DNI del Usuario.");
            }
            else if (txtCUIT.Text == "")

            {
                MessageBox.Show("Por favor, ingresar CUIT del Usuario.");
            }
            else if (txtTipo.Text == "")

            {
                MessageBox.Show("Por favor, ingresar Tipo de Usuario.");
            }
            else
            {
                MessageBox.Show("usuario Generado Correctamente!");

            }


            ManejarUsuario();

        }

        private  bool ManejarUsuario()
        {
            string Path = @"D:\Users\mavila\source\repos\TP2-GRUPO5\TP2-GRUPO5\Data\logUsuarios.txt";
            //REVISAR

            System.IO.File.SetAttributes(Path, System.IO.FileAttributes.Normal);

            StreamWriter Escritor = new StreamWriter(Path, true);
            StringBuilder LaCadena = new StringBuilder();

            string NombreArchivo = Path;


            LaCadena.AppendLine("Fecha: " + DateTime.Now);
            LaCadena.AppendLine("Usuario: " + "GRUPO 2");
            
            
            LaCadena.AppendLine("Se ha generado un Nuevo Usuario");
            LaCadena.AppendLine("Nombre: " + txtNombre.Text);
            LaCadena.AppendLine("Apellido: " + txtApellido.Text);
            LaCadena.AppendLine("DNI: " + txtDNI.Text);
            LaCadena.AppendLine("CUIT: " + txtCUIT.Text);
            LaCadena.AppendLine("TIPO: " + txtTipo.Text);
            LaCadena.AppendLine(Constants.vbNewLine);
            LaCadena.AppendLine("******************************** Siguiente Registro ***************************");

            Escritor.WriteLine(LaCadena.ToString());

            Escritor.Close();
            Escritor.Dispose();
            if (File.Exists(Path) == true)
                System.IO.File.SetAttributes(Path, System.IO.FileAttributes.ReadOnly);
            else
            {
            }

            return true;
        }

    }
}
