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


            String text;
            String[] numbersStr;
            int[] arr;

            try
            {
                text = textNumbers.Text;
                numbersStr = text.Split(" ");
                arr = numbersStr.Select(x => int.Parse(x)).ToArray();
            }

            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


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
