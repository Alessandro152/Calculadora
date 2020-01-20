using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        private string operador;
        double num1, num2;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum1.Text;
            IncluirHistorico(btnNum1.Text);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum2.Text;
            IncluirHistorico(btnNum2.Text);
        }

        private void IncluirHistorico(string dados)
        {
            lblHistorico.Text += dados;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum3.Text;
            IncluirHistorico(btnNum3.Text);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum4.Text;
            IncluirHistorico(btnNum4.Text);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum5.Text;
            IncluirHistorico(btnNum5.Text);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum6.Text;
            IncluirHistorico(btnNum6.Text);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum7.Text;
            IncluirHistorico(btnNum7.Text);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum8.Text;
            IncluirHistorico(btnNum8.Text);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum9.Text;
            IncluirHistorico(btnNum9.Text);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnNum0.Text;
            IncluirHistorico(btnNum0.Text);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text += btnDecimal.Text;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(lblResultado.Text);
            lblResultado.Text = string.Empty;
            operador = btnSomar.Text;
            IncluirHistorico(btnSomar.Text);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(lblResultado.Text);
            lblResultado.Text = string.Empty;
            operador = btnSubtrair.Text;
            IncluirHistorico(btnSubtrair.Text);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(lblResultado.Text);
            lblResultado.Text = string.Empty;
            operador = btnMultiplicar.Text;
            IncluirHistorico(btnMultiplicar.Text);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(lblResultado.Text);
            lblResultado.Text = string.Empty;
            operador = btnDividir.Text;
            IncluirHistorico(btnDividir.Text);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(lblResultado.Text);
            double resultado = CalcularValores(num1, num2, operador);

            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
            lblHistorico.Text = string.Empty;
        }

        private double CalcularValores(double num1, double num2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "x":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}
