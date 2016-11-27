using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // for dll import

namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        bool isOperation; // after using operation clear output
        string tempSign;  // save sign

        public Form1()
        {
            Text = "Calculator 1.0"; // title of the frame
            MaximizeBox = false;     // disable maximizing frame
            InitializeComponent();
        }

        // using button number 1
        private void button1_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
            
            if (isOperation == true)                    // if we used an operation clear output
                {textBox_output.Text = "";}                 // empty output
           
            if (tempSign == "Sminus")
            { textBox_output.Text += "-1"; }
            
            else
            textBox_output.Text += "1";                 // add 1 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 2
        private void button2_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
            
            if (isOperation == true)                    // if we used an operation clear output
            {textBox_output.Text = "";}                 // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-2"; }

            else
            textBox_output.Text += "2";                 // add 2 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 3
        private void button3_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
            
            if (isOperation == true)                    // if we used an operation clear output
            {textBox_output.Text = "";}                 // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-3"; }
           
            else
            textBox_output.Text += "3";                 // add 3 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 4
        private void button4_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
          
            if (isOperation == true)                    // if we used an operation clear output
            { textBox_output.Text = ""; }               // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-4"; }

            else
            textBox_output.Text += "4";                 // add 4 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 5
        private void button5_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
           
            if (isOperation == true)                    // if we used an operation clear output
            { textBox_output.Text = ""; }               // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-5"; }

            else
            textBox_output.Text += "5";                 // add 5 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 6
        private void button6_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
            
            if (isOperation == true)                    // if we used an operation clear output
            {textBox_output.Text = "";}                 // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-6"; }

            else
            textBox_output.Text += "6";                 // add 6 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 7
        private void button7_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
            
            if (isOperation == true)                    // if we used an operation clear output
            {textBox_output.Text = "";}                 // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-7"; }

            else
            textBox_output.Text += "7";                 // add 7 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 8
        private void button8_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
            if (isOperation == true)                    // if we used an operation clear output
            {textBox_output.Text = "";}                 // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-8"; }

            else

            textBox_output.Text += "8";                 // add 8 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number 9
        private void button9_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
           
            if (isOperation == true)                    // if we used an operation clear output
            {textBox_output.Text = "";}                 // empty output

            if (tempSign == "Sminus")
            { textBox_output.Text += "-9"; }

            else
            textBox_output.Text += "9";                 // add 9 to output
            isOperation = false;                        // no operation pressed yet
        }

        // using button number '0'
        private void button10_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;               // number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral; // color button when it enable
            if (isOperation == true)                    // if we used an operation clear output
            {
                textBox_output.Text = ""; // empty output
            }

            if(textBox_output.Text.StartsWith("0"))
            {        
                if (textBox_output.Text.Contains("."))
                    textBox_output.Text += "0"; // allow adding zero after point
                else { }// if we entered more then 1 zero at the begining
            }

            else 
                 textBox_output.Text += "0"; // adding zero after any number
                 isOperation = false; // no operation pressed yet
        }

        // using button point
        private void button11_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;// number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral;// color button when it enable
            
            if (textBox_output.Text.StartsWith(".")) // if user entered directly .
                textBox_output.Text = ("0.");        // display 0.

            if (textBox_output.Text.Contains("."))
            {
                // disable user pressing . more then 1 time
            }

            else if(textBox_output.Text.StartsWith(""))
            {
                textBox_output.Text += ".";
            }

            else 
                textBox_output.Text += ".";
        }

        // using 'C' button to clear
        private void button17_Click(object sender, EventArgs e)
        {
            textBox_output.Text = "";                   // empty output
            Operations.clear();                         // reset result
            tempSign = "";                              // reset tempsign
            but_backspace.Enabled = false;              // disable backspace
            but_backspace.BackColor = Color.GhostWhite; // color backspace
        }

        // using equal button
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            {
                // to prevent exception appearing
            }
            else
            {
                switch (tempSign)
                {
                    case "plus":
                        Operations.add(double.Parse(textBox_output.Text));
                        tempSign = "";
                        break;

                    case "minus":
                        Operations.sub(double.Parse(textBox_output.Text));
                        tempSign = "";
                        break;

                    case "Sminus":  // ex: '-3 ='
                        Operations.Ssub(Double.Parse(textBox_output.Text));
                        tempSign = "";
                        break;

                    case "mult":
                        Operations.mult(double.Parse(textBox_output.Text));
                        tempSign = "";
                        break;

                    case "div":
                        Operations.div(double.Parse(textBox_output.Text));
                        tempSign = "";
                        break;

                    case "modulo":
                        Operations.modulo(double.Parse(textBox_output.Text));
                        tempSign = "";
                        break;
                }

                textBox_output.Text = Convert.ToString(Operations.getResult());
            }
            but_backspace.Enabled = false;              // displaying result disable backspace
            but_backspace.BackColor = Color.GhostWhite; // color button when it disable
        }

        // using addition button
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            { // to prevent exception appearing
            }
            else
            {
                Operations.add(double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
                isOperation = true; // user pressed an operation
                tempSign = "plus";
            }
        }

        // using substraction button
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text.Length == 0)
            {
                tempSign = "Sminus";
            }
            else
            {
                Operations.sub(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
                isOperation = true; // user pressed an operation
                tempSign = "minus";
            }
        }

        // using multiplication button
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            {// to prevent exception appearing
            }
            else
            {
                Operations.mult(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
                isOperation = true; // user pressed an operation
                tempSign = "mult";
            }
        }

        // using division button
        private void button15_Click(object sender, EventArgs e)
        {
            tempSign = "div";
            if (textBox_output.Text == "")
            {// to prevent exception appearing
            }
            else
            {
                try
                {
                    Operations.div(Double.Parse(textBox_output.Text));
                    textBox_output.Text = Convert.ToString(Operations.getResult());
                    isOperation = true; // user pressed an operation
                }

                catch (DivideByZeroException ee)
                {
                    Console.WriteLine(ee.Message); // print error message
                }
            }
        }

        // using exit from file menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit application
        }

        // using about from help menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator 1.0\n\n\t\tDevelopped on Microsoft Visual C#\n\t\tAuthor: Ramzi Abou Rahal\n");
        }

        // using backspace button
        private void button18_Click(object sender, EventArgs e)
        {
            textBox_output.Text = textBox_output.Text.Remove(textBox_output.Text.Length - 1);
       
            if (textBox_output.Text == "")
            {
                 but_backspace.Enabled = false;  // output is empty disable backspace
                 but_backspace.BackColor = Color.GhostWhite;// color button when it enable
            }
         }

        // using Sin buttuon
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "") 
            { // to prevent exception appearing
            }
            else
            {
                Operations.sin(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
            }
        }

        // using Cos button
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            {// to prevent exception appearing
            }
            else
            {
                Operations.cos(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
            }
        }

        // using Tan button
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            { // to prevent exception appearing
            }
            else
            {
                Operations.cos(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
            }
        }

        // using square root button
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            { // to prevent exception appearing
            }
            else
            {
                Operations.sqrt(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
            }
        }

        // using modulo button
        private void button1_Click_1(object sender, EventArgs e)
        {
            tempSign = "modulo";
            if (textBox_output.Text == "")
            { // to prevent exception appearing
            }
            else
            {
                Operations.modulo(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
                isOperation = true;
            }
        }

        // using standard radio button 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {   // disabling all scientific button, enabling image instead
            but_sin.Visible =       false;
            but_cos.Visible =       false;
            but_tan.Visible =       false;
            but_sqrt.Visible =      false;
            but_modulo.Visible =    false;
            but_pi.Visible =        false;
            but_square.Visible =    false;
            but_cube.Visible =      false;
            but_factorial.Visible = false;
            but_fibonacci.Visible = false;
            label_image.Visible =   true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {   // enabling all scientific button, disabling image
            but_sin.Visible =       true;
            but_cos.Visible =       true;
            but_tan.Visible =       true;
            but_sqrt.Visible =      true;
            but_modulo.Visible =    true;
            but_pi.Visible =        true;
            but_square.Visible =    true;
            but_cube.Visible =      true;
            but_factorial.Visible = true;
            but_fibonacci.Visible = true;
            label_image.Visible =   false;
        }

        // using Pi button
        private void but_pi_Click(object sender, EventArgs e)
        {
            but_backspace.Enabled = true;// number button is clicked, enable backspace
            but_backspace.BackColor = Color.LightCoral;// color button when it enable

            if (isOperation == true || textBox_output.Text != "") // if we used an operation clear output
            {
                textBox_output.Text = ""; // empty output
            }
                textBox_output.Text += Math.PI;
                isOperation = false; // no operation pressed yet
        }


      // winmm.dll is located in the System32 directory of Windows. The mciSendString function is used to send a command string to an MCI device, 
      // in this case the CD / DVD drive.
                                                                                                                                     
      private void openToolStripMenuItem_Click(object sender, EventArgs e)                                                                    
      {     // call it to open the CD drive.. sending the set CDAudio door open command to the MCI device (the CD / DVD drive).               
          int sesame = ppp("set cdaudio door open", null, 0, IntPtr.Zero);                                                           
      }                                                                                                                                       
                                                                                                                                            
      private void closeToolStripMenuItem_Click(object sender, EventArgs e)                                                                   
      {     // call it to close the CD drive.. set CDAudio door closed command                                                                
          int sesame = ppp("set cdaudio door closed", null, 0, IntPtr.Zero);                                                         
      }                                                                                                                                       
                                                                                                                                                                                                                                                                                       
      [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]                                                         
      protected static extern int ppp(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);


        // using clock from menu to get current date & time
        private void clockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n" + DateTime.Now.ToLocalTime(), "Day / Time");
        }
                                                                                      

        // using square button
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            {// to prevent exception appearing
            }
            else
            {
                Operations.square(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
            }
        }

        // using cube button
        private void button1_Click_3(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            { // to prevent exception appearing
            }
            else
            {
                Operations.cube(Double.Parse(textBox_output.Text));
                textBox_output.Text = Convert.ToString(Operations.getResult());
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            { // to prevent exception appearing
            }
            else
            {
                try
                {
                    textBox_output.Text = Convert.ToString(Operations.factorial(long.Parse(textBox_output.Text)));
                }
                catch (Exception) 
                { 
                    MessageBox.Show("Factorial are only for integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    textBox_output.Text = ""; 
                    but_backspace.Enabled = false; 
                    but_backspace.BackColor = Color.GhostWhite; 
                }
            }
        }

        private void menu_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorChooser = new ColorDialog();
            DialogResult result;

            result = colorChooser.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            textBox_output.ForeColor = colorChooser.Color;
        }

        private void changeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorChooser = new ColorDialog();
            DialogResult result;

            result = colorChooser.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            BackColor = colorChooser.Color;
        }

        private void but_fibonacci_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text == "")
            { // to prevent exception appearing
            }
            else
            {
                try
                {
                    Operations.fibonacci(long.Parse(textBox_output.Text));
                    textBox_output.Text = Convert.ToString(Operations.fibonacci(long.Parse(textBox_output.Text)));
                }
                catch (Exception) 
                { 
                    MessageBox.Show("Fibonnaci are for integers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    textBox_output.Text = ""; 
                    but_backspace.Enabled = false; 
                    but_backspace.BackColor = Color.GhostWhite;
                }
            }
        }

        // white background color button
        private void blackToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            but_0.BackColor = Color.White;
            but_1.BackColor = Color.White;
            but_2.BackColor = Color.White;
            but_3.BackColor = Color.White;
            but_4.BackColor = Color.White;
            but_5.BackColor = Color.White;
            but_6.BackColor = Color.White;
            but_7.BackColor = Color.White;
            but_8.BackColor = Color.White;
            but_9.BackColor = Color.White;
            but_point.BackColor = Color.White;
            menu_white.Checked = true;
            menu_red.Checked = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            but_0.BackColor = Color.Red;
            but_1.BackColor = Color.Red;
            but_2.BackColor = Color.Red;
            but_3.BackColor = Color.Red;
            but_4.BackColor = Color.Red;
            but_5.BackColor = Color.Red;
            but_6.BackColor = Color.Red;
            but_7.BackColor = Color.Red;
            but_8.BackColor = Color.Red;
            but_9.BackColor = Color.Red;
            but_point.BackColor = Color.Red;
            menu_white.Checked = false;
            menu_red.Checked = true;
        }

        private void menu_black_Click(object sender, EventArgs e)
        {
            but_0.ForeColor = Color.Black;
            but_1.ForeColor = Color.Black;
            but_2.ForeColor = Color.Black;
            but_3.ForeColor = Color.Black;
            but_4.ForeColor = Color.Black;
            but_5.ForeColor = Color.Black;
            but_6.ForeColor = Color.Black;
            but_7.ForeColor = Color.Black;
            but_8.ForeColor = Color.Black;
            but_9.ForeColor = Color.Black;
            but_point.ForeColor = Color.Black;
            menu_black.Checked = true;
            menu_cyan.Checked = false;

        }

        private void menu_cyan_Click(object sender, EventArgs e)
        {
            but_0.ForeColor = Color.Cyan;
            but_1.ForeColor = Color.Cyan;
            but_2.ForeColor = Color.Cyan;
            but_3.ForeColor = Color.Cyan;
            but_4.ForeColor = Color.Cyan;
            but_5.ForeColor = Color.Cyan;
            but_6.ForeColor = Color.Cyan;
            but_7.ForeColor = Color.Cyan;
            but_8.ForeColor = Color.Cyan;
            but_9.ForeColor = Color.Cyan;
            but_point.ForeColor = Color.Cyan;
            menu_black.Checked = false;
            menu_cyan.Checked = true;
        }
  
    } // end class Form1
} // end namespace Calculator_GUI0