using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            textBox1.Text += (sender as Button).Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = (sender as Button).Text;
            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            SeparateSymbols(textBox1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void SeparateSymbols(TextBox textbox)
        {
            int i = 0;            

            Char[] delimiters = { 'x', '/', '+', '-', '=' };
            string[] numbersInString = textbox.Text.Split(delimiters);
            Char[] operators = new char[numbersInString.Length - 1];
            double[] numbers = new double[numbersInString.Length - 1];

            for (int index = 0; index < numbersInString.Length - 1; index++)
            {
                numbers[i] = Double.Parse(numbersInString[index]);
                i++;
            }

            i = 0;
            foreach (char c in textbox.Text.ToCharArray())
            {
                if (IsOperator(c))
                {
                    operators[i] = c;
                    i++;
                }
            }

            textbox.Text = Convert.ToString(GetResult(numbers, operators));
        }

        private double GetResult(Double [] numbers, char [] operators)
        {

            while (numbers.Length > 1)
            {
               for (int i = 0; i < operators.Length - 1; i++)
               {
                    if (operators[i] == 'x')
                    {
                        CalculateResult(ref operators, ref numbers, operators[i], i);
                    }
               }

               for (int i = 0; i < operators.Length - 1; i++)
               {
                    if (operators[i] == '/')
                    {
                            CalculateResult(ref operators, ref numbers, operators[i], i);
                    }
               }

               for (int i = 0; i < operators.Length - 1; i++)
               {
                    if (operators[i] == '+')
                    {
                            CalculateResult(ref operators, ref numbers, operators[i], i);
                    }
               }

               for (int i = 0; i < operators.Length - 1; i++)
               {
                    if (operators[i] == '-')
                    {
                            CalculateResult(ref operators, ref numbers, operators[i], i);
                    }
               }                            
            }
            return numbers[0];
        }
        private void CalculateResult(ref Char [] operators, ref Double [] numbers, char currentOperator, int i)
        {
            double firstNumber = numbers[i];
            double secondNumber = numbers[i + 1];
            double result = 0;
            

                if (currentOperator == 'x')
                {                    
                    result = firstNumber * secondNumber;
                    numbers[i] = result;
                    ArrayCorrector(i, ref numbers, ref operators);                       
                    

                    for (i=0; i < operators.Length - 1; i++)
                    {
                        if (operators[i] == 'x')
                        {
                            CalculateResult(ref operators, ref numbers, operators[i], i);
                        }   
                    }                    
                }
                
                if (currentOperator == '/')
                { 
                    result = firstNumber / secondNumber;
                    numbers[i] = result;
                    ArrayCorrector(i, ref numbers, ref operators);

                    for (i = 0; i < operators.Length - 1; i++)
                    {
                        if (operators[i] == '/')
                        {
                            CalculateResult(ref operators, ref numbers, operators[i], i);
                        }
                    }
                }
                if (currentOperator == '+')
                {
                    result = firstNumber + secondNumber;
                    numbers[i] = result;
                    ArrayCorrector(i, ref numbers, ref operators);

                    for (i = 0; i < operators.Length - 1; i++)
                    {
                        if (operators[i] == '+')
                        {
                            CalculateResult(ref operators, ref numbers, operators[i], i);
                        }
                    }   
                }
                if (currentOperator == '-')
                {
                    result = firstNumber - secondNumber;
                    numbers[i] = result;
                    ArrayCorrector(i, ref numbers, ref operators);

                    for (i = 0; i < operators.Length - 1; i++)
                    {
                        if (operators[i] == '-')
                        {
                            CalculateResult(ref operators, ref numbers, operators[i], i);
                        }
                    }
                }
        }
        private void ArrayCorrector(int i, ref double [] numbers, ref char [] operators)
        {
            double [] newNumbers = new double [numbers.Length - 1];
            char [] newOperators = new char [numbers.Length - 1];

            for (int index = i + 1; index < numbers.Length -1; index++)
            {
                numbers[index] = numbers[index + 1];
                operators[index - 1] = operators[index];
            }

            operators[numbers.Length - 2] = operators [numbers.Length - 1];

            for (int index = 0; index < numbers.Length - 1; index++)
            {
                newNumbers[index] = numbers[index];
                newOperators[index] = operators[index];
            }

            numbers = newNumbers;
            operators = newOperators;
        
        }

        private bool IsOperator(char c)
        {
            return c == '-' || c == '+' || c == 'x' || c == '/' || c == '=';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "("; textBox1.Text += ")";
        }
    }
    
}
