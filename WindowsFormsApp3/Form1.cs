using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void txtcalcular_Click(object sender, EventArgs e)
        {
            Empregado emp = new Empregado();

            emp.Nome = txtname.Text;
            emp.Cpf = txtcpf.Text;
            emp.Vh = int.Parse(txtvh.Text);
            emp.Hora = int.Parse(txtht.Text);

            emp.CalcularSalario();


            txtsalario.Text = emp.Salario.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsalario.Visible = true;
        }

       
    }
}
