using System;
using System.Globalization;

namespace Name
{
    class Funcionario
    {

        public string Nome;

        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double porcentagem) {
        SalarioBruto = SalarioBruto + (SalarioBruto *(porcentagem /100.0));
        }

        public double SalarioLiquido() {
        return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return Nome +", $ "+SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
