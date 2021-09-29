using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            
            var text = textNumbers.Text;
            var numbersStr = text.Split(" ");
            int[] arr = numbersStr.Select(x => int.Parse(x)).ToArray();




            MessageBox.Show(Logic.Ascending(arr));
        }

        private void textNumbers_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Logic
    {
        public static string Ascending(int[] numbers)
        {
            string result = "По возрастанию";
            int a = 0;
            int lastelem = numbers[a];

            for (int i = 1; i < numbers.Length; i++)
            {
                bool b = (lastelem >= numbers[i]);
                if (b)
                {
                    result = "Не по возрастанию";
                    break;
                }
                lastelem = numbers[i];
            }

            return result;
        }
    }
}
