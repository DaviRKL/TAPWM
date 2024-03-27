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
    public partial class FrnHorista : Form
    {
        public FrnHorista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrnHorista frnHorista = new FrnHorista();
            frnHorista.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrnHorista_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);

            MessageBox.Show("Nome:" + objHorista.NomeEmpregado + "\n" +
                      "Matricula=" + objHorista.Matricula + "\n" +
                      "Tempo Trabalho:" + objHorista.TempoTrabalho() +
                      "\n" + "Salário=" +
                      objHorista.SalarioBruto().ToString("N2"));
            MessageBox.Show($"Salário com aumento: {objHorista.SalarioBruto(50).ToString("N2")}");
        }
    }
}
