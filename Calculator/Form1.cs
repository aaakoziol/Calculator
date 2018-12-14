using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double currentValue = 0;   //Pierwsza liczba      
        double numSum = 0;  //Druga liczba
        private EnumOperator currentOperator;
        private string tempData = string.Empty;


        private void NumberClick(string strNumber) // Wyświetlanie liczby z przycisku
        {
            tbResult.Text += strNumber;
            currentValue = Convert.ToDouble(tbResult.Text);

            tbOperat.Text += strNumber;
        }
        private void OperatorClick(EnumOperator op) // Wybieranie operatora działania
        {
            if (currentOperator != EnumOperator.None)
            {
                //Obliczanie
                Calculate();
            }
            else
            {
                
                double.TryParse(tbResult.Text, out numSum);
            }

            DisplayOperator(op);

            tbResult.Text = "";
            currentOperator = op;


        }
       

        private void DisplayOperator(EnumOperator op) // Wyświetlanie działania w oknie
        {
            switch (op)
            {
                case EnumOperator.None:
                    tbOperat.Text = tbResult.Text;
                    tbOperat.Text += "";
                    break;
                case EnumOperator.Add:
                   tbOperat.Text = tbResult.Text;
                   tbOperat.Text += "+";
                    break;
                case EnumOperator.Minus:
                    tbOperat.Text = tbResult.Text;
                    tbOperat.Text += "-";
                    break;
                case EnumOperator.Multiply:
                    tbOperat.Text = tbResult.Text;
                    tbOperat.Text += "x";
                    break;
                case EnumOperator.Divide:
                    tbOperat.Text = tbResult.Text;
                    tbOperat.Text += "/";
                    break;
                default:
                    break;
            }
        }

        private void Calculate()
        {
            Operation oper;

            
            switch (currentOperator)
            {
                case EnumOperator.None:
                    break;
                case EnumOperator.Add:
                    oper = OperationFactory.CreateOperate(EnumOperator.Add);
                    oper.NumberA = numSum;
                    oper.NumberB = currentValue;
                    numSum = oper.GetResult();
                    break;
                case EnumOperator.Minus:
                    oper = OperationFactory.CreateOperate(EnumOperator.Minus);
                    oper.NumberA = numSum;
                    oper.NumberB = currentValue;
                    numSum = oper.GetResult();
                    break;
                case EnumOperator.Multiply:
                    oper = OperationFactory.CreateOperate(EnumOperator.Multiply);
                    oper.NumberA = numSum;
                    oper.NumberB = currentValue;
                    numSum = oper.GetResult();
                    break;
                case EnumOperator.Divide:
                    if (currentValue != 0)
                    {
                        oper = OperationFactory.CreateOperate(EnumOperator.Divide);
                        oper.NumberA = numSum;
                        oper.NumberB = currentValue;
                        numSum = oper.GetResult();
                    }
                    else
                    {
                        MessageBox.Show("Błąd. Podaj liczbę inną niż 0.");
                        
                    }
                    break;
               
            }
            currentValue = 0;
            currentOperator = EnumOperator.None;
           
        }

        private void b7_Click(object sender, EventArgs e)
        {
            NumberClick(b7.Text);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            NumberClick(b8.Text);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            NumberClick(b9.Text);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            NumberClick(b6.Text);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            NumberClick(b5.Text);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            NumberClick(b4.Text);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            NumberClick(b0.Text);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            NumberClick(b1.Text);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            NumberClick(b2.Text);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            NumberClick(b3.Text);
        }

        private void bPlusMinus_Click(object sender, EventArgs e)
        {
            if (!tbResult.Text.Contains("-"))
            {
                tbOperat.Text = "-" + tbOperat.Text;
                tbResult.Text = "-" + tbResult.Text;
            }
            else
            {
                tbOperat.Text = tbOperat.Text.Trim('-');
                tbResult.Text = tbResult.Text.Trim('-');
            }
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            OperatorClick(EnumOperator.Minus);
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            OperatorClick(EnumOperator.Add);
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            Calculate();
            tbResult.Text = numSum.ToString();

            //Zapobieganie dublowaniu znaku równości
            if (tbOperat.Text.Length > 1 && tbOperat.Text.Substring(tbOperat.Text.Length - 1) != "=")
            {
                tbOperat.Text += "=";
            }

        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            OperatorClick(EnumOperator.Divide);
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            OperatorClick(EnumOperator.Multiply);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            currentOperator = EnumOperator.None;
            tbResult.Text = "";
            tbOperat.Text = "";
            numSum = 0;
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            if (!tbResult.Text.Contains(","))
            {
                tbResult.Text = tbResult.Text + ",";
                tbOperat.Text = tbOperat.Text + ",";
            }
        }
        
    }

}
