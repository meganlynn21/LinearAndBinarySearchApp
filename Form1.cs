using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Linear_and_Binary_Search_App
{
    public partial class Form1 : Form
    {
        private object arrayOfInts;

        public Form1()
        {
            InitializeComponent();
        }

        // Array TextBox
        private void ArrayTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        // Set Up Button
        public void SetUpBtn_Click(object sender, EventArgs e)
        {
            string value = ArrayTextBox.Text;
            int n;
 
            if (!Int32.TryParse(ArrayTextBox.Text, out n))
            {
                MessageBox.Show("Please enter a valid integer");
                ArrayTextBox.Text = "";
            }
            //Create an array using the number the user types in as the size of the array. 

            int[] arrayOfInts = new int[n];
            /* Use a for loop to go through the array
              and put in random numbers between 0 and 10 * n.
            Print out the array with a loop to make sure it works. 
            */
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int randNum = random.Next(0, 10*n);
                arrayOfInts[i] = randNum;
            }
            
            lblArray.Text = String.Join(", ", arrayOfInts);
           
        }


        /*
         * Ask the user for a number to search for.
         * Write and call a linear search function that
        /searches for the number in the array
        /(going through the array with a loop)
        /and prints out if it is found or not.
        */
       
        public void LinearBtn_Click(object sender, EventArgs e)
        {
            string value = NumberTextBox.Text;
            int num;

            if (!Int32.TryParse(NumberTextBox.Text, out num))
            {
                MessageBox.Show("Please enter a valid integer");
                NumberTextBox.Text = "";
            }

            foreach (int element in arrayOfInts)
            {
                if (element = NumberTextBox.Text)
                {
                    num = element;
                }
            }
       
     
        }
    }
}