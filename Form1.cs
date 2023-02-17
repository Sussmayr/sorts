using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_Ordenamientos_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBurbuja1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Burbuja frm = new Burbuja();
            frm.Show();
        }

        private void btnBurbuja2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurbujaMejorada frm = new BurbujaMejorada();
            frm.Show();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seleccion frm = new Seleccion();
            frm.Show();
        }

        private void btnInsercion_Click(object sender, EventArgs e)
        {
            this.Hide();
            insercion frm = new insercion();
            frm.Show();
        }
    }
}
