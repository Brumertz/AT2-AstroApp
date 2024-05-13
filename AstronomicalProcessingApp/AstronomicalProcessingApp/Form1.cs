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
                MessageBox.Show("Please select an item in the list an enter a valid integer value to edit.");
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
                string? interactions = listBoxData.SelectedItem?.ToString();
                string[]? words = interactions?.Split(' ');
                textBoxInput.Text = words?[2];

            }
        }
        // Math Methods
        private double CalculateMidExtreme(HourlyData[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("Data array cannot be empty.");
            }

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].Interactions < data[minIndex].Interactions)
                {
                    minIndex = i;
                }
                else if (data[i].Interactions > data[maxIndex].Interactions)
                {
                    maxIndex = i;
                }
            }

            return (data[minIndex].Interactions + data[maxIndex].Interactions) / 2.0;

        }
        private int FindMode(HourlyData[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("Data array cannot be empty.");
            }

            int maxCount = 0;
            int mode = data[0].Interactions;

            for (int i = 0; i < data.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < data.Length; j++)
                {
                    if (data[i].Interactions == data[j].Interactions)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mode = data[i].Interactions;
                }
            }

            return mode;
        }
        private double CalculateAverage(HourlyData[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("Data array cannot be empty.");
            }

            double total = 0.0;
            foreach (HourlyData hourlyData in data)
            {
                total += hourlyData.Interactions;
            }

            return total / data.Length;
        }
        private int CalculateRange(HourlyData[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("Data array cannot be empty.");
            }

            int min = data[0].Interactions;
            int max = data[0].Interactions;

            for (int i = 1; i < data.Length; i++)
            {
                min = Math.Min(min, data[i].Interactions);
                max = Math.Max(max, data[i].Interactions);
            }

            return max - min;
        }

        private int SequentialSearch(HourlyData[] data, int searchValue)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Interactions == searchValue)
                {
                    return i; // Found at index i
                }
            }

            return -1; // Not found
        }

        private void buttonSequentialsearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSequencialSearch.Text))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            if (int.TryParse(textBoxSequencialSearch.Text, out int searchValue))
            {
                int index = SequentialSearch(dataArray, searchValue);
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
        private void buttonMidExtreme_Click(object sender, EventArgs e)
        {
            try
            {
                double midExtreme = CalculateMidExtreme(dataArray);
                textBoxMidExtreme.Text = midExtreme.ToString("N2"); // Format with 2 decimal places
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            try
            {
                int mode = FindMode(dataArray);
                textBoxMode.Text = mode.ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            try
            {
                double average = CalculateAverage(dataArray);
                textBoxAverage.Text = average.ToString("N2"); // Format with 2 decimal places
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            try
            {
                int range = CalculateRange(dataArray);
                textBoxRange.Text = range.ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}


