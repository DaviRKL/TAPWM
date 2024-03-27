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
    public partial class FrnMensalista : Form
    {
        public FrnMensalista()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.NomeEmpregado = txt_nome.Text;
            objMensalista.Matricula = Convert.ToInt32(txt_matricula.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txt_data_entrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txt_salario_mensal.Text);

            MessageBox.Show("Nome:" + objMensalista.NomeEmpregado + "\n" +
                       "Matricula=" + objMensalista.Matricula + "\n" +
                       "Tempo Trabalho:" + objMensalista.TempoTrabalho()+
                       "\n"+ "Salário Final=" +
                       objMensalista.SalarioBruto().ToString("N2"));
            MessageBox.Show(Mensalista.Empresa);
            MessageBox.Show(Mensalista.Filial);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                Convert.ToInt32(txt_matricula.Text),
                txt_nome.Text,
                Convert.ToDateTime(txt_data_entrada.Text),
                Convert.ToDouble(txt_salario_mensal.Text)
                );
            
            MessageBox.Show("Nome:" + objMensalista.NomeEmpregado + "\n" +
                      "Matricula=" + objMensalista.Matricula + "\n" +
                      "Tempo Trabalho:" + objMensalista.TempoTrabalho() +
                      "\n" + "Salário Final=" +
                      objMensalista.SalarioBruto().ToString("N2"));

        }
    }
}
