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
        List<string> numbers = new List<string>();
        List<char> symbols = new List<char>();
        List<int> parenthesis_indexes = new List<int>();
        int index = 0;
        bool operation_symbol_possible = false;
        public Form1()
        {
            InitializeComponent();
            numbers.Add("");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "9";
            numbers[index] += "9";
            operation_symbol_possible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "8";
            numbers[index] += "8";
            operation_symbol_possible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "7";
            numbers[index] += "7";
            operation_symbol_possible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "6";
            numbers[index] += "6";
            operation_symbol_possible = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "5";
            numbers[index] += "5";
            operation_symbol_possible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "4";
            numbers[index] += "4";
            operation_symbol_possible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "3";
            numbers[index] += "3";
            operation_symbol_possible = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "2";
            numbers[index] += "2";
            operation_symbol_possible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "1";
            numbers[index] += "1";
            operation_symbol_possible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            textBox1.Text += "0";
            numbers[index] += "0";
            operation_symbol_possible = true;
        }

        private void button12_Click(object sender, EventArgs e) // Point
        {
            if (textBox1.Text != "" && textBox1.Text.ElementAt(textBox1.Text.Count() - 1) == ')')
                return;

            if (operation_symbol_possible)
            {
                textBox1.Text += ".";
                numbers[index] += ".";
                operation_symbol_possible = false;
            }
        }

        void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            index = 0;
            numbers.Clear();
            symbols.Clear();
            parenthesis_indexes.Clear();
            numbers.Add("");
            operation_symbol_possible = false;
            opening_parenthesis = true;
        }
        private void button11_Click(object sender, EventArgs e) // Clear
        {
            clear();
        }
        private void button13_Click(object sender, EventArgs e) // Deletion
        {
            if (textBox1.Text == "") // When there's nothing to delete
                return;

            char end_of_textbox = textBox1.Text.ElementAt(textBox1.Text.Count() - 1);
            if (end_of_textbox == '(' || end_of_textbox == ')') // When deleting a parenthesis
            {
                if (end_of_textbox == '(') // When deleting a opening parenthesis
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
                parenthesis_indexes.RemoveAt(index);
                return;
            }
            else if (numbers[index] == "") // When deleting an operation symbol
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                numbers.RemoveAt(index);
                symbols.RemoveAt(--index);
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                numbers[index] = numbers[index].Substring(0, numbers[index].Length - 1);
            }

        }
        private void button18_Click(object sender, EventArgs e) // Addition
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "+";
                symbols.Add('+');
                numbers.Add("");
                index++;
                operation_symbol_possible = false;
            }
        }
        private void button17_Click(object sender, EventArgs e) // Subtraction
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "-";
                symbols.Add('-');
                numbers.Add("");
                index++;
                operation_symbol_possible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e) // Multiplication
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "*";
                symbols.Add('*');
                numbers.Add("");
                index++;
                operation_symbol_possible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e) // Division
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "/";
                symbols.Add('/');
                numbers.Add("");
                index++;
                operation_symbol_possible = false;
            }
        }
        private void button14_Click(object sender, EventArgs e) // Mod
        {
            if (operation_symbol_possible)
            {
                textBox1.Text += "%";
                symbols.Add('%');
                numbers.Add("");
                index++;
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
                opening_parenthesis = false;
                parenthesis_indexes.Add(index);
            }
            else if (opening_parenthesis == false && operation_symbol_possible == true)
            {
                textBox1.Text += ")";
                opening_parenthesis = true;
                parenthesis_indexes.Add(index);
            }
        }

        int recovering_previous_parenthesis_indexes = 0;
        void remove(int i, ref int end) // To delete a node after doing a calculation
        {
            numbers.RemoveAt(i + 1);
            symbols.RemoveAt(i);
            end--;
            for (int j = 0; j < parenthesis_indexes.Count; j++)
                parenthesis_indexes[j]--;
            recovering_previous_parenthesis_indexes++;
        }

        void calculate(int start, int end)
        {
            double temp = 0;
            for (int i = start; i < end; i++) // First find and do calculations of * and / which have higher priority
            {
                switch (symbols[i])
                {
                    case '*':
                        temp = Convert.ToDouble(numbers[i]) * Convert.ToDouble(numbers[i + 1]);
                        numbers[i] = Convert.ToString(temp);
                        remove(i, ref end);
                        i--;
                        break;
                    case '/':
                        temp = Convert.ToDouble(numbers[i]) / Convert.ToDouble(numbers[i + 1]);
                        numbers[i] = Convert.ToString(temp);
                        remove(i, ref end);
                        i--;
                        break;
                    case '%':
                        temp = Convert.ToDouble(numbers[i]) % Convert.ToDouble(numbers[i + 1]);
                        numbers[i] = Convert.ToString(temp);
                        remove(i, ref end);
                        i--;
                        break;
                }
            }

            while (start < end)
            {
                switch (symbols[start])
                {
                    case '+':
                        temp = Convert.ToDouble(numbers[start]) + Convert.ToDouble(numbers[start + 1]);
                        numbers[start] = Convert.ToString(temp);
                        remove(start, ref end);
                        break;
                    case '-':
                        temp = Convert.ToDouble(numbers[start]) - Convert.ToDouble(numbers[start + 1]);
                        numbers[start] = Convert.ToString(temp);
                        remove(start, ref end);
                        break;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e) // =
        {
            List<string> temp_numbers = new List<string>();
            List<char> temp_symbols = new List<char>();
            for (int i = 0; i < numbers.Count(); i++)
                temp_numbers.Add(numbers[i]);
            for (int i = 0; i < symbols.Count(); i++)
                temp_symbols.Add(symbols[i]);

            if (parenthesis_indexes.Count() % 2 != 0)
            {
                MessageBox.Show("Unable to calculate", "Error");
                return;
            }

            try
            {
                for (int i = 0; i < parenthesis_indexes.Count - 1; i += 2) // Calculate the inside of parentheses first
                    calculate(parenthesis_indexes[i], parenthesis_indexes[i + 1]);

                calculate(0, numbers.Count - 1); // Final calculation after the calculations of higher priority
                textBox2.Text = Convert.ToString(numbers[0]); // Print result

                // Clear
                textBox1.Text = "";
                index = 0;
                numbers.Clear();
                symbols.Clear();
                parenthesis_indexes.Clear();
                numbers.Add("");
                operation_symbol_possible = false;
                opening_parenthesis = true;
                //-----
            }
            catch
            {
                MessageBox.Show("Unable to calculate", "Error");
                clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}