// Brandon Morales id 30085204 C., Sudaka Dev, Sprint Number
// Date:15/04/2024
// Version:1.01
// Astronimical Processing
// Brief explanation of the program : This program manages astronomical interaction data.
//Inputs are user-entered values.
//Processes involve random data generation, binary search, and bubble sort. Outputs include UI updates, search results, and sorted data display.
// It efficiently organizes and presents astronomical data for analysis and interaction.


using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AstronomicalProcessingApp
{
    public partial class MainForm : Form
    {
        private struct HourlyData
        {
            public int Hour;
            public int Interactions;

            public HourlyData(int hour, int interactions)
            {
                Hour = hour;
                Interactions = interactions;
            }
        }
        private HourlyData[] dataArray = new HourlyData[24]; // Array to store hourly data


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelAppName.Text = "Astronomical Processing";

            GenerateRandomData(); // Initial generation of random data
            UpdateListBox(); // Update list box with initial data

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInput.Text))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            if (int.TryParse(textBoxInput.Text, out int searchValue))
            {
                int index = BinarySearch(dataArray, searchValue);
                if (index != -1)
                {
                    listBoxData.SelectedIndex = index;
                    MessageBox.Show($"Value {searchValue} found at hour {dataArray[index].Hour}");
                }
                else
                {
                    MessageBox.Show($"Value {searchValue} not found in the data.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value to search.");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxData.SelectedIndex != -1 && int.TryParse(textBoxInput.Text, out int newValue))
            {
                dataArray[listBoxData.SelectedIndex].Interactions = newValue;
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please select an item in the list and enter a valid integer value to edit.");
            }
            textBoxInput.Text = "";
            MessageBox.Show("You have been changed the Interactions Number");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
             // Generate new random data
            UpdateListBox(); // Update list box with new data
            textBoxInput.Text = ""; // clear textBoxInput 

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            UpdateListBox();
            BubbleSort(dataArray); // Sort the array using Bubble Sort
            UpdateListBox(); // Update list box with sorted data
        }

        private int BinarySearch(HourlyData[] array, int searchValue)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid].Interactions == searchValue)
                {
                    return mid; // Value found
                }

                if (array[mid].Interactions < searchValue)
                {
                    left = mid + 1; // Search the right half
                }
                else
                {
                    right = mid - 1; // Search the left half
                }
            }


            return -1; // Value not found
        }


        private void GenerateRandomData()
        {
            Random random = new Random();
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = new HourlyData(i + 1, random.Next(10, 91)); // Random values between 10 and 90
            }

        }

        private void UpdateListBox()
        {
            listBoxData.Items.Clear();
            foreach (HourlyData data in dataArray)
            {
                listBoxData.Items.Add($"Hour {data.Hour}: {data.Interactions} interactions");
            }
        }




        private void BubbleSort(HourlyData[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].Interactions > array[j + 1].Interactions)
                    {
                        // Swap elements
                        HourlyData temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxData.SelectedIndex != -1)
            {
                string Interactions = listBoxData.SelectedItem.ToString();
                string[] words = Interactions.Split(' ');
                textBoxInput.Text = words[2];
                
            }
        }
    }

}


