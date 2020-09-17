using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // subscribir los eventos click de los 2 botones
            btnCerrar.Click += botonesDeOpcion;
            btnConfirmar.Click += botonesDeOpcion;
            
        }

        private void botonesDeOpcion(object sender, EventArgs e)
        {
            // codigo a ejecutarse cuando el usuario
            // haga click en alguno de los 2 botones
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnCerrar":
                    Close();
                    break;
                case "btnConfirmar":
                    // comunicarnos con capa de logica
                    Logica.Autor objLogica = new Logica.Autor();
                    Entidades.Autor objEntidad = new Entidades.Autor();
                    objEntidad.Apellido = txtApellido.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.FechaNacimiento = dtpFechaNacimiento.Value;
                    objEntidad.Nacionalidad = cboPaises.SelectedItem.ToString();
                    objLogica.Agregar(Program.ListaAutores, objEntidad);
                    MessageBox.Show("Autor agregado a la coleccion!!!");
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                    dtpFechaNacimiento.Value = DateTime.Today;
                    cboPaises.SelectedValue = "";
                    txtApellido.Focus();

                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
