using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace CalculatorNew
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
        }
        #endregion
        #region Instance Variables
        bool label1Override = false;
        int MathKey = 0;
        double? N1 = null;
        double? N2 = null;
        double? Result = null;
        bool insertDecimal = false;
        double sqrtValue = 0;
        double reciprocal = 0;
        #endregion  
        #region Form_load
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        #endregion
        #region Buttons Pressed 0-9
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button1.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button1.Text;
                }
                else
                {
                    label1.Text += button1.Text;
                }
            }
        } // Button "1"
        private void button2_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button2.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button2.Text;
                }
                else
                {
                    label1.Text += button2.Text;
                }
            } 
        } // Button "2"
        private void button3_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button3.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button3.Text;
                }
                else
                {
                    label1.Text += button3.Text;
                }
            }   
        } // Button "3"
        private void button4_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button4.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button4.Text;
                }
                else
                {
                    label1.Text += button4.Text;
                }
            }

            
        } // Button "4"
        private void button5_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button5.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button5.Text;
                }
                else
                {
                    label1.Text += button5.Text;
                }
            }

        } // Button "5"
        private void button6_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button6.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button6.Text;
                }
                else
                {
                    label1.Text += button6.Text;
                }
            }

        } // Button "6"
        private void button7_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button7.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button7.Text;
                }
                else
                {
                    label1.Text += button7.Text;
                }
            }


        } // Button "7"
        private void button8_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button8.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button8.Text;
                }
                else
                {
                    label1.Text += button8.Text;
                }
            }

        } // Button "8"
        private void button9_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button9.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button9.Text;
                }
                else
                {
                    label1.Text += button9.Text;
                }
            }

        }// Button "9"
        private void button10_Click(object sender, EventArgs e)
        {
            if (label1Override)
            {
                label1.Text = button10.Text;
                label1Override = false;
            }
            else if (!label1Override)
            {
                if (label1.Text.Length == 1 & label1.Text == "0")
                {
                    label1.Text = button10.Text;
                }
                else
                {
                    label1.Text += button10.Text;
                }
            }

        } // Button "0"
        #endregion
        #region Clear Buttons: CE, Backspace, 
        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            insertDecimal = false;
        }  // CE Button - clears label1
        private void button23_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length <= 1)
            {
                label1.Text = "0";
            }
            else if (label1.Text.Length > 1)
            {
                label1.Text = label1.Text.Substring(0, (label1.Text.Length - 1));
                if (label1.Text.Contains("."))
                {
                    insertDecimal = true;
                }
                else
                {
                    insertDecimal = false;
                }
            }
        }  // backspace button <--
        private void button22_Click(object sender, EventArgs e)
        {
            label1Override = false;
            MathKey = 0;
            N1 = null;
            N2 = null;
            Result = null;
            insertDecimal = false;
            label2.Text = string.Empty;
            label1.Text = "0";
            sqrtValue = 0;
        }  // C button - clears everything! - resets instance variables
        #endregion
        #region Decimal Button // redo this to check if label1 has a decimal?
        private void button11_Click(object sender, EventArgs e)
        {
            if (!(insertDecimal))
            {
                label1.Text += button11.Text;
                insertDecimal = true;
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }
        #endregion
        #region Arithmetic Buttons Addition "+" function
        private void button15_Click(object sender, EventArgs e)
        {
            MathKey = 1;
            if (N1 == null && N2 == null && Result == null) // only ever used for first calculation
            {
                N1 = double.Parse(label1.Text);
                label2.Text = (label1.Text + button15.Text);
                label1Override = true;
                insertDecimal = false;
            }
            else if (N1 != null && N2 == null && Result == null)
            {
                if (label1Override) // without this, pressing "+" twice prints "result+result" on label1
                {

                }
                else if (!label1Override)
                {
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button15.Text);
                    Result = Math.Addition(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }
            }
            else if (N1 == null && N2 == null && Result != null)
            {
                if (label1Override)
                {

                }
                else if (!label1Override)
                {
                    N1 = Result;
                    Result = null;
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button15.Text);
                    Result = Math.Addition(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }
            }
        }
        #endregion
        #region Arithmetic Buttons Subtraction "-" function
        private void button14_Click(object sender, EventArgs e)
        {
            MathKey = 2;
            if (N1 == null && N2 == null && Result == null) // only ever used for first calculation
            {
                N1 = double.Parse(label1.Text);
                label2.Text = (label1.Text + button14.Text);
                label1Override = true;
                insertDecimal = false;
            }
            else if (N1 != null && N2 == null && Result == null)
            {
                if (label1Override) // without this, pressing "-" twice prints "result-result" on label1
                {

                }
                else if (!label1Override)
                {
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button14.Text);
                    Result = Math.Subtraction(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }
            }
            else if (N1 == null && N2 == null && Result != null)
            {
                if (label1Override)
                {

                }
                else if (!label1Override)
                {
                    N1 = Result;
                    Result = null;
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button14.Text);
                    Result = Math.Subtraction(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }
            }
        }
        #endregion
        #region Arithmetic Buttons Multiplication "*" function
        private void button13_Click(object sender, EventArgs e)
        {
            MathKey = 3;
            if (N1 == null && N2 == null && Result == null) // only ever used for first calculation or if user presses "C"
            {
                N1 = double.Parse(label1.Text);
                label2.Text = (label1.Text + button13.Text);
                label1Override = true;
                insertDecimal = false;
            }
            else if (N1 != null && N2 == null && Result == null)
            {
                if (label1Override) // without this, pressing "*" twice prints "result*result" on label1
                {
                    //label2.Text = label2.Text.Substring(0, (label2.Text.Length - 1));
                    //label2.Text = (label1.Text + button13.Text);
                }
                else if (!label1Override)
                {
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button13.Text);
                    Result = Math.Multiplication(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }
            }
            else if (N1 == null && N2 == null && Result != null)
            {
                if (label1Override)
                {
                    //label2.Text = label2.Text.Substring(0, (label2.Text.Length - 1));
                    //label2.Text = (label1.Text + button13.Text);
                }
                else if (!label1Override)
                {
                    N1 = Result;
                    Result = null;
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button13.Text);
                    Result = Math.Multiplication(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }
            }
        }
        #endregion
        #region Arithmetic Buttons Division "/" function
        private void button12_Click(object sender, EventArgs e)
        {
            MathKey = 4;
            if (N1 == null && N2 == null && Result == null) // only ever used for first calculation
            {
                N1 = double.Parse(label1.Text);
                label2.Text = (label1.Text + button12.Text);
                label1Override = true;
                insertDecimal = false;
            }
            else if (N1 != null && N2 == null && Result == null)
            {
                if (label1Override) // without this, pressing "/" twice prints "result/result" on label1
                {
                    //label2.Text = label2.Text.Substring(0, (label2.Text.Length - 1));
                    //label2.Text = (label1.Text + button12.Text);
                }
                else if (!label1Override)
                {
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button12.Text);
                    Result = Math.Division(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }
            }
            else if (N1 == null && N2 == null && Result != null)
            {
                if (label1Override)
                {
                    //label2.Text = label2.Text.Substring(0, (label2.Text.Length - 1));
                    //label2.Text = (label1.Text + button12.Text);
                }
                else if (!label1Override)
                {
                    N1 = Result;
                    Result = null;
                    N2 = double.Parse(label1.Text);
                    label2.Text = (label2.Text + label1.Text + button12.Text);
                    Result = Math.Division(N1, N2, Result);
                    label1.Text = Convert.ToString(Result);
                    N1 = null;
                    N2 = null;
                    label1Override = true;
                    insertDecimal = false;
                }

            }
        }
        #endregion
        #region Equals button
        private void button16_Click(object sender, EventArgs e)
        {
            if (MathKey == 1)
            {
                N2 = double.Parse(label1.Text);
                label2.Text = (label2.Text + label1.Text);
                Result = Math.Addition(N1, N2, Result);
                label2.Text = string.Empty;
                label1.Text = Convert.ToString(Result);
                N1 = null;
                N2 = null;
                Result = null;
                label1Override = true;
                insertDecimal = false;
            }
            else if (MathKey == 2)
            {
                N2 = double.Parse(label1.Text);
                label2.Text = (label2.Text + label1.Text);
                Result = Math.Subtraction(N1, N2, Result);
                label2.Text = string.Empty;
                label1.Text = Convert.ToString(Result);
                N1 = null;
                N2 = null;
                Result = null;
                label1Override = true;
                insertDecimal = false;
            }
            else if (MathKey == 3)
            {
                N2 = double.Parse(label1.Text);
                label2.Text = (label2.Text + label1.Text);
                Result = Math.Multiplication(N1, N2, Result);
                label2.Text = string.Empty;
                label1.Text = Convert.ToString(Result);
                N1 = null;
                N2 = null;
                Result = null;
                label1Override = true;
                insertDecimal = false;
            }
            else if (MathKey == 4)
            {
                N2 = double.Parse(label1.Text);
                label2.Text = (label2.Text + label1.Text);
                Result = Math.Division(N1, N2, Result);
                label2.Text = string.Empty;
                label1.Text = Convert.ToString(Result);
                N1 = null;
                N2 = null;
                Result = null;
                label1Override = true;
                insertDecimal = false;
            }
        }
        #endregion
        #region Square Root button
        private void button18_Click(object sender, EventArgs e)
        {
           sqrtValue = System.Math.Sqrt(double.Parse(label1.Text));
           label1.Text = Convert.ToString(sqrtValue);
           label1Override = true;
           insertDecimal = false;
        }
        #endregion 
        #region Reciprocal Button
        private void button17_Click(object sender, EventArgs e)
        {
            reciprocal = double.Parse(label1.Text);
            reciprocal = 1 / reciprocal;
            label1.Text = Convert.ToString(reciprocal);
            label1Override = true;
            insertDecimal = false;
        }
        #endregion
        #region Changing sign of a number
        private void button20_Click(object sender, EventArgs e)
        {
            int a = System.Math.Sign(double.Parse(label1.Text)); 
            /* Converts number in label1 into a double.
             * Uses System.Math.Sign to determine if number is signed
             * if number is positive, a == 1 (or a > 0)
             * if number is negative a == -1 (or a < 0)
             * if number is 0 a == 0 (which has no sign!)
             * */ 
            if (a == 0)
            {
            }
            else if (a < 0)
            {
             double negativeNumber = System.Math.Abs(double.Parse(label1.Text));
             label1.Text = Convert.ToString(negativeNumber);
            }
            else if (a > 0)
            {
                double positiveNumber = (double.Parse(label1.Text) * (-1));
                label1.Text = Convert.ToString(positiveNumber);
            }
        }
        #endregion
        //private double? Redirector()
        //{
        //    if (MathKey == 3)
            
        //    return Result;

        //}
    }
}
