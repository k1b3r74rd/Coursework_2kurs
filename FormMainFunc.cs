using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Сортировка расчёской
            int gap = array.Length - 1;
            while (gap >= 1)
            {
                gap = Convert.ToInt32(Math.Truncate(gap / 1.127));
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
            // Из-за особенности алгоритма, при 2 элементах сортировка не производится
            // Поэтому дополнительно отдельно выносим "добивочную" часть, сортировку пузырьком
            for (int i = 0; i + 1 < array.Length; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
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
