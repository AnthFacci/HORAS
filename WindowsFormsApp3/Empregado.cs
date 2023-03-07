using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Empregado
    {
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;  
        public int Vh { get; set; } 

        public int Hora { get; set; }

        public double Salario { get; private set; }

        public void CalcularSalario()
        {
            Salario = (Vh * Hora);
        }
    }
}
