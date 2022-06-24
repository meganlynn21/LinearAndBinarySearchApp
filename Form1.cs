using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Linear_and_Binary_Search_App
{
    public partial class Form1 : Form
    {

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
                int randNum = random.Next(0, 10 * n);
                arrayOfInts[i] = randNum;
            }

            lblArray.Text = String.Join(", ", arrayOfInts);

        }
        // Getting the return value of the label array textbox so i can use it in linear button click function
        public string getArray()
        {
            return lblArray.Text;
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
            int value2 = Convert.ToInt32(NumberTextBox.Text);
            int num;
            string arrayOfString = getArray();

            //string s1 = "1;2;3;4;5;6;7;8;9;10;11;12";
            int[] arrayOfInts = arrayOfString.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

            if (!Int32.TryParse(NumberTextBox.Text, out num))
            {
                MessageBox.Show("Please enter a valid integer");
                NumberTextBox.Text = "";
            }

            for (int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                if (arrayOfInts[i] == value2)
                {
                    num = i;

                    lblArray.Text = "";
                    lblArray.Text = String.Join(",", arrayOfInts[i]);
                    lblArray.Text = "You Found" + ' ' + lblArray.Text;
                }
                else
                    lblArray.Text = "Not Found";
            }


        }

        // Set up binary search next

        private void BinaryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}