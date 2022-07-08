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

            // Error handling
            if (!Int32.TryParse(ArrayTextBox.Text, out n))
            {
                MessageBox.Show("Please enter a valid integer");
                ArrayTextBox.Text = "";
            }
            //Creating an array using the number the user types in as the size of the array.
            int[] arrayOfInts = new int[n];
            Random random = new Random();

            // Using a for loop to go through the array and put in random numbers between 0 and 10 * n.
            for (int i = 0; i < n; i++)
            {
                int randNum = random.Next(0, 10 * n);
                arrayOfInts[i] = randNum;
            }

            lblArray.Text = String.Join(", ", arrayOfInts);
        }

        // Getting the return value of the label ArrayTextbox so we can use it in linear button click function
        public string getArray()
        {
            return lblArray.Text;
        }

        // Linear Search Button
        //The Big O notation for Linear Search is O(N)
        public void LinearBtn_Click(object sender, EventArgs e)
        {
            string value = NumberTextBox.Text;
            int num;
            int count = 0;

            if (!Int32.TryParse(value, out num))
            {
                MessageBox.Show("Please enter a valid integer");
                NumberTextBox.Text = "";
            }

            bool success = Int32.TryParse(NumberTextBox.Text, out num);
            string arrayOfString = getArray();
            try
            {
                int[] arrayOfInts = arrayOfString.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

                if (success == true)
                {

                    int numTextBoxInt = Convert.ToInt32(NumberTextBox.Text);

                    for (int i = 0; i < arrayOfInts.Length; i++)
                    {
                        count++;

                        if (arrayOfInts[i] == numTextBoxInt)
                        {
                            Foundlbl.Text = $"You Found {numTextBoxInt}{'!'}";
                            lblResult.Text = $"Linear Results: Linear search for {arrayOfInts[i]} took {count} steps";
                            return;
                        }
                    }

                }
                lblArray.Text = "Not Found";
            }
            catch (FormatException)
            {

            }

        }

        // Binary Search Button
        // The Big O notation for Binary Search is O(log N).
        private void BinaryBtn_Click(object sender, EventArgs e)
        {
            string value = NumberTextBox.Text;
            int num;
            int count = 0;


            if (!Int32.TryParse(value, out num))
            {
                MessageBox.Show("Please enter a valid integer");
                NumberTextBox.Text = "";
            }

            bool success = Int32.TryParse(NumberTextBox.Text, out num);
            string arrayOfString = getArray();
            try
            {
                int[] arrayOfInts = arrayOfString.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

                if (success == true)
                {
                    int numTextBoxInt = Convert.ToInt32(NumberTextBox.Text);
                    int low = 0;
                    int high = arrayOfInts.Length;

                    Array.Sort(arrayOfInts);

                    while (low < high)
                    {
                        count++;
                        int mid = low + ((high - low) / 2);
                        if (numTextBoxInt == arrayOfInts[mid])
                        {
                            Foundlbl.Text = $"You Found {numTextBoxInt}{'!'}";
                            Binarylbl.Text = $"Binary Results: Binary search for {numTextBoxInt} took {count} steps";
                            return;
                        }
                        if (numTextBoxInt < arrayOfInts[mid])
                            high = mid - 1;
                        else
                            low = mid + 1;
                    }
                }


                lblArray.Text = "Not Found";
            }
            catch (FormatException)
            {

            }
        }
    }
}