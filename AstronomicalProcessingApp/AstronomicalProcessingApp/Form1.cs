using System;
using System.Linq;
using System.Windows.Forms;

namespace AstronomicalProcessingApp
{
    public partial class MainForm : Form
    {
        private int[] dataArray = new int[24]; // Array to store hourly neutrino interaction values
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

        private void buttonSort_Click(object sender, EventArgs e)
        {
            BubbleSort(dataArray); // Sort the array using Bubble Sort
            UpdateListBox();
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
                    MessageBox.Show($"Value {searchValue} found at hour {index + 1}");
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
                dataArray[listBoxData.SelectedIndex] = newValue;
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please select an item in the list and enter a valid integer value to edit.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            GenerateRandomData(); // Generate new random data
            UpdateListBox(); // Update list box with new data
        }
        private void UpdateListBox()
        {
            listBoxData.Items.Clear();
            for (int i = 0; i < dataArray.Length; i++)
            {
                listBoxData.Items.Add($"Hour {i + 1}: {dataArray[i]} interactions");
            }
        }

        private void GenerateRandomData()
        {
            Random random = new Random();
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = random.Next(10, 91); // Random values between 10 and 90
            }
        }

        private void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap elements
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        private int BinarySearch(int[] array, int searchValue)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == searchValue)
                {
                    return mid; // Value found
                }

                if (array[mid] < searchValue)
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
    }
}


