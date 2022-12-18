using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Coursework_2kurs
{
    public partial class FormMainFunc : Form
    {
        public FormMainFunc()
        {
            InitializeComponent();
        }

        public int[] array;

        private void button_generate_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
            chart1.Series[0].Points.Clear();

            int array_size = Convert.ToInt32(numericUpDown.Value);
            Array.Resize(ref array, array_size);


            Random random = new Random();
            for (int i = 0; i < array_size; i++)
            {
                array[i] = random.Next(0, 100);
                chart.Series[0].Points.Add(array[i]);
            }
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
           new CombSort(array).Sort(chart1);
        }

        private class CombSort 
        {
            int[] array { get; }
            public CombSort(int[] array)
            {
                this.array = array;
            }
            public void Sort(Chart chart1)
            {
                // Сортировка расчёской
                int gap = array.Length;
                while (gap >= 1)
                {
                    gap = Convert.ToInt32(Math.Truncate(gap / 1.247));
                    for (int i = 0; i + gap < array.Length; i++)
                    {
                        int j = i + gap;
                        if (array[i] > array[j])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                        // Отслежка сортировки в прямом эфире.
                        chart1.Series[0].Points.Clear();
                        for (int x = 0; x < array.Length; x++)
                        {
                            chart1.Series[0].Points.Add(array[x]);
                        }
                    }
                }
            }
        }
    }
}
