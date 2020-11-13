using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class Form1 : Form
    {
        string top = "";
        string bottom = "";
        string input = "";
        string newLine = Environment.NewLine;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = newLine + top + newLine + "-----------------------------------" + newLine + bottom;//sets up the line for the calculator
        }
        private void textbox1(object sender, EventArgs e)
        {
            textBox1.Text = newLine + top + newLine + "----------------------------------------" + newLine + bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            top += "1";//adds one to top string
            textBox1.Text += "1";//puts one on the screen
        }

        private void button2_Click(object sender, EventArgs e)
        {
            top += "2";//adds two to top string
            textBox1.Text += "2";//puts two on the screen
        }

        private void button3_Click(object sender, EventArgs e)
        {
            top += "3";//adds three to top string
            textBox1.Text += "3";//puts three on the screen
        }

        private void button4_Click(object sender, EventArgs e)
        {
            top += "4";//adds four to top string
            textBox1.Text += "4";//puts four on the screen
        }

        private void button5_Click(object sender, EventArgs e)
        {
            top += "5";//adds 5 to the top string
            textBox1.Text += "5";//puts five on the screen
        }

        private void button6_Click(object sender, EventArgs e)
        {
            top += "6";//adds six to the top string
            textBox1.Text += "6";//puts six on the screen
        }

        private void button7_Click(object sender, EventArgs e)
        {
            top += "7";//adds seven to the top string
            textBox1.Text += "7";//puts seven on the screen
        }

        private void button8_Click(object sender, EventArgs e)
        {
            top += "8";//adds eight to the top string
            textBox1.Text += "8";//puts eight on the screen
        }

        private void button9_Click(object sender, EventArgs e)
        {
            top += "9";//adds nine to the top string
            textBox1.Text += "9";//puts nine on the screen
        }

        private void button0_Click(object sender, EventArgs e)
        {
            top += "0";//adds zero to the top string
            textBox1.Text += "0";//puts zero on the screen
        }

        private void buttondecimal_Click(object sender, EventArgs e)
        {
            top += ".";//adds a decimal to the top string
            textBox1.Text += ".";//puts a decimal on the screen
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            top += "-";//adds a negative to the top string
            textBox1.Text += "-";//puts a negative on the screen
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            top += "+";//adds a plus to the top string
            textBox1.Text += "+";//puts a plus on the screen
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            top += "-";//adds a minus to the top string
            textBox1.Text += "-";//puts a minus on the screen
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            top += "*";//adds a multiplication to the top string
            textBox1.Text += "*";//puts a multiplication on the screen
        }

        private void buttonmodular_Click(object sender, EventArgs e)
        {
            top += "%";//adds a mod to the top string
            textBox1.Text += "%";//puts a mod on the screen
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            top += "/";//adds a division to the top string
            textBox1.Text += "/";//puts a division on the screen
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            double firstnum = 0, secondnum = 0;
            string operators = "*/%+-";
            int count = 0, m, n;
            input = top;//set input equal to top to keep what the user put in
            textBox1.Text = input;//set that as the text

            for(int i = 0; i < top.Length && count < 5; i++)//goes through what the user typed in
            {
                string check = "";//new string to check the numbers

                if(top[i] == operators[count] )//if the user input is an operator
                {
                    for(m = i - 1; m >= 0; m--)//go through the numbers backwards
                    {
                        bool isNegative = false;
                        if (top[m] == '-')//if the first thing entered is a negative then set isNegative to true
                            isNegative = true;
                        if (top[m] == '*' || top[m] == '/' || top[m] == '%' || top[m] == '+' || (top[m] == '-' && isNegative == false))//if what the user entered is an operator skip to the numbers
                            break;
                        check += top[m];//put all the numbers into the check string
                    }
                    char[] ReverseNums = check.ToCharArray();//an array that will hold the reverse list of numbers
                    Array.Reverse(ReverseNums);//reverse the numbers back to their usual form
                    check = new string(ReverseNums);//put the numbers back into the check string
                    firstnum = Convert.ToDouble(check);//set the first value to the double value of the string
                    check = "";//set the check string to empty
                    for(n = i + 1; n < top.Length; n++)//go through the rest of the numbers forwards
                    {
                        bool isNegative = false;
                        if (top[n] == '-' && n == i + 1)//if the first thing entered is negative, set isNegative to true
                            isNegative = true;
                        if (top[n] == '*' || top[n] == '/' || top[n] == '%' || top[n] == '+' || (top[n] == '-' && isNegative == false))//if what the user entered is an operator, skip to the numbers
                            break;
                        check += top[n];//add the numbers to the check string
                    }
                    secondnum = Convert.ToDouble(check);//set the second value to the double value of the check string
                    check = "";//set the check string to empty

                    //math calculations
                    if (operators[count] == '*')
                        firstnum *= secondnum;
                    else if (operators[count] == '/')
                        firstnum /= secondnum;
                    else if (operators[count] == '%')
                        firstnum %= secondnum;
                    else if (operators[count] == '+')
                        firstnum += secondnum;
                    else
                        firstnum -= secondnum;

                    for(int j = 0; j <= m; j++)//adding the values to the empty string
                    {
                        check += top[j];
                    }
                    check += firstnum.ToString();//adding the new values

                    for(int k = n; k < top.Length; k++)//adding the rest of the values
                    {
                        check += top[k];
                    }

                    top = check;//top is now check
                    i = 0;//set i to 0 to loop back again
                }
                if (i == top.Length -1)
                {
                    i = 0;//set i back to 0 to loop again
                    count++;//increment count for the next loop
                }
            }
            this.top = input;//this is the user input on the top
            this.bottom = Convert.ToString(firstnum);//the bottom now shows the answer
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";//set all the strings to empty
            this.top = "";
            this.bottom = "";
        }
    }
}
