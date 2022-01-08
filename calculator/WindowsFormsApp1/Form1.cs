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
        List<string> num = new List<string>();
        List<char> symbol = new List<char>();
        List<int> parenthesis_index = new List<int>();
        int index = 0;
        bool operation_symbol_possible = false;
        public Form1()
        {
            InitializeComponent();
            num.Add("");
            symbol.Add(' ');
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "9";
            num[index] += "9";
            operation_symbol_possible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            num[index] += "8";
            textBox1.Text += "8";
            operation_symbol_possible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "7";
            num[index] += "7";
            operation_symbol_possible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "6";
            num[index] += "6";
            operation_symbol_possible = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "5";
            num[index] += "5";
            operation_symbol_possible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "4";
            num[index] += "4";
            operation_symbol_possible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "3";
            num[index] += "3";
            operation_symbol_possible = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "2";
            num[index] += "2";
            operation_symbol_possible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "1";
            num[index] += "1";
            operation_symbol_possible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            textBox1.Text += "0";
            num[index] += "0";
            operation_symbol_possible = true;
        }

        private void button12_Click(object sender, EventArgs e) // Point
        {
            if (opening_parenthesis == true && operation_symbol_possible == true)
                return;

            if (operation_symbol_possible)
            {
                textBox1.Text += ".";
                num[index] += ".";
                operation_symbol_possible = false;
            }
        }
        private void button11_Click(object sender, EventArgs e) // Clear
        {
            textBox1.Text = "";
            textBox2.Text = "";
            index = 0;
            num.Clear();
            symbol.Clear();
            parenthesis_index.Clear();
            num.Add("");
            symbol.Add(' ');
            operation_symbol_possible = false;
            opening_parenthesis = true;
        }
        private void button13_Click(object sender, EventArgs e) // Deletion
        {
            if (textBox1.Text == "") // When there's nothing to delete
                return;

            char end_of_textbox = textBox1.Text.ElementAt(textBox1.Text.Length - 1);
            if (end_of_textbox == '(' || end_of_textbox == ')') // When deleting a parenthesis
            {
                if (end_of_textbox == '(') // When deleting a closing parenthesis
                {
                    opening_parenthesis = true;
                    operation_symbol_possible = false;
                }
                if (end_of_textbox == ')') // When deleting a closing parenthesis
                {
                    opening_parenthesis = false;
                    operation_symbol_possible = true;
                }

                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                parenthesis_index.RemoveAt(index);
                return;
            }

            if (num[index] == "") // When deleting an operation symbol
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                num.RemoveAt(index);
                symbol.RemoveAt(--index);
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                num[index] = num[index].Substring(0, num[index].Length - 1);
            }

        }
        private void button18_Click(object sender, EventArgs e) // Addition
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "+";
                symbol[index] = '+';
                // For the next node
                index++;
                num.Add("");
                symbol.Add(' ');
                //-----
                operation_symbol_possible = false;
            }
        }
        private void button17_Click(object sender, EventArgs e) // Subtraction
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "-";
                symbol[index] = '-';
                index++;
                num.Add("");
                symbol.Add(' ');
                operation_symbol_possible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e) // Multiplication
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "*";
                symbol[index] = '*';
                index++;
                num.Add("");
                symbol.Add(' ');
                operation_symbol_possible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e) // Division
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "/";
                symbol[index] = '/';
                index++;
                num.Add("");
                symbol.Add(' ');
                operation_symbol_possible = false;
            }
        }
        private void button14_Click(object sender, EventArgs e) // Mod
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "%";
                symbol[index] = '%';
                index++;
                num.Add("");
                symbol.Add(' ');
                operation_symbol_possible = false;
            }
        }

        bool opening_parenthesis = true;
        private void button20_Click(object sender, EventArgs e) // Parenthesis
        {
            if (textBox1.Text != "")
            {
                char end_of_textbox = textBox1.Text.ElementAt(textBox1.Text.Length - 1);
                if (end_of_textbox == '(' || end_of_textbox == ')') // If the opening parenthesis hasn't been closed
                    return;
            }

            if (opening_parenthesis == true && operation_symbol_possible == false)
            {
                textBox1.Text += "(";
                symbol[index] = '(';
                opening_parenthesis = false;
                parenthesis_index.Add(index);
            }
            else if (opening_parenthesis == false && operation_symbol_possible == true)
            {
                textBox1.Text += ")";
                symbol[index] = ')';
                opening_parenthesis = true;
                parenthesis_index.Add(index);
            }
        }

        void remove(int i, ref int end) // To delete a node after doing a calculation
        {
            num.RemoveAt(i + 1);
            symbol.RemoveAt(i);
            end--;
            index--;
            for (int j = 0; j < parenthesis_index.Count; j++)
                parenthesis_index[j]--;
        }

        void calculate(int start, int end)
        {
            double temp = 0;
            for (int i = start; i < end; i++) // First find and do calculations of * and / which have higher priority
            {
                switch (symbol[i])
                {
                    case '*':
                        temp = Convert.ToDouble(num[i]) * Convert.ToDouble(num[i + 1]);
                        num[i] = Convert.ToString(temp);
                        remove(i, ref end);
                        i--;
                        break;
                    case '/':
                        temp = Convert.ToDouble(num[i]) / Convert.ToDouble(num[i + 1]);
                        num[i] = Convert.ToString(temp);
                        remove(i, ref end);
                        i--;
                        break;
                    case '%':
                        temp = Convert.ToDouble(num[i]) % Convert.ToDouble(num[i + 1]);
                        num[i] = Convert.ToString(temp);
                        remove(i, ref end);
                        i--;
                        break;
                }
            }

            while (start < end)
            {
                switch (symbol[start])
                {
                    case '+':
                        temp = Convert.ToDouble(num[start]) + Convert.ToDouble(num[start + 1]);
                        num[start] = Convert.ToString(temp);
                        remove(start, ref end);
                        break;
                    case '-':
                        temp = Convert.ToDouble(num[start]) - Convert.ToDouble(num[start + 1]);
                        num[start] = Convert.ToString(temp);
                        remove(start, ref end);
                        break;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e) // =
        {
            try
            {
                for (int i = 0; i < parenthesis_index.Count - 1; i += 2) // Calculate the inside of parentheses first
                    calculate(parenthesis_index[i], parenthesis_index[i + 1]);

                calculate(0, index); //Final calculation after the calculations of higher priority
                textBox2.Text = Convert.ToString(num[0]); // Print result

                textBox1.Text = "";
                index = 0;
                num.Clear();
                symbol.Clear();
                parenthesis_index.Clear();
                num.Add("");
                symbol.Add(' ');
                operation_symbol_possible = false;
                opening_parenthesis = true;
            }
            catch
            {
                MessageBox.Show("Unable to calculate", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}