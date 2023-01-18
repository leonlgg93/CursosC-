using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControladoresYOperadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFecha.Value;
            string musica = ckbMusica.Checked == true ? "Le gusta la musica": "No le gusta la musica";
            string instrumento;
            if (rbBajo.Checked)
                instrumento = "bajo";
            else if (rbGuitarra.Checked)
                instrumento = "guitarra";
            else
                instrumento = "bateria";

            string generoFavorito = cbGenero.SelectedItem.ToString();

            string mensaje = "nombre:" + nombre + ", fecha:" + fecha + ", le gusta la musica: " + musica + ", su instrumento es: " + instrumento + ", su genero favorito es: " + generoFavorito;

            MessageBox.Show(mensaje);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGenero.Items.Add("Rock");
            cbGenero.Items.Add("Pop");
            cbGenero.Items.Add("Metal");
        }
    }
}
