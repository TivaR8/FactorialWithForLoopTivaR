using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 06-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Factorial with For Loop
 * This program calculates the factorial of the users number...
 * ... This program does it with a For Loop
*/

namespace FactorialWithForLoopTivaR
{
    public partial class frmFactorialWithForLoop : Form
    {
        public frmFactorialWithForLoop()
        {
            InitializeComponent();
            lblFinalAnswer.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            // Initialize the final answer to 1
            factorialAnswer = 1;

            // Get the number from user
            factorialNumber = Convert.ToDouble(this.txtFactorial.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                // list the counter number in the listbox for the user to see
                this.lstFactorialNumbers.Items.Add(factorialCounter);

                // Multiply the counter by the answer 
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            // Dispaly the answer
            lblFinalAnswer.Show();
            this.lblFinalAnswer.Text = this.txtFactorial.Text + "! = " + Convert.ToString(factorialAnswer);

        }
    }
}
