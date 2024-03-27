using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrnMensalista frnMensalista = new FrnMensalista();
            frnMensalista.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrnHorista frnHorista = new FrnHorista();
            frnHorista.Show();
        }
    }
}
