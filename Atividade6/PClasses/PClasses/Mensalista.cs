using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    internal class Mensalista : Empregado
    {
        public double SalarioMensal {  get; set; }

        public static String Empresa = "Tesla";
        public const String Filial = "Filial Brasil";

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
        public Mensalista(int matx, string nomex, DateTime datax, double salx)
        {
            this.NomeEmpregado = nomex;
            this.DataEntradaEmpresa = datax;
            this.Matricula= matx;
            this.SalarioMensal = salx;
        }

        public Mensalista()
        {
            System.Windows.Forms.MessageBox.Show("Aqui é mensalista");
        }
    }
}
