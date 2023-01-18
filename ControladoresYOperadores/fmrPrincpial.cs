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
    public partial class fmrPrincpial : Form
    {
        public fmrPrincpial()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1)) 
                {
                    MessageBox.Show("Ya esta en ejecucion esta ventana, porfavor termine de trabajar alli");
                    return;
                }
            }
            
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void fmrPrincpial_Load(object sender, EventArgs e)
        {

        }
    }
}
