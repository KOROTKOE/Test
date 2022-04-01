using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR10
{
    public partial class Form1 : Form
    {
        private double[,] sourceArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private double[,] receiveRandomSquareArray(int length,TextBox textBox)
        {
            double[,] resultArray = new double[length, length];
            textBox.Text = "";
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i != 0 || j != 0)
                        resultArray[i, j] = i/(i+j);
                    else
                        resultArray[i, j] = 0;
                    textBox.Text += resultArray[i, j] + "\t";
                }
                textBox.Text += "\n";
            }
            return resultArray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sourceArray = receiveRandomSquareArray(int.Parse(textBox1.Text),textBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] result = getSumAndCountElement(0.2,0.3);
            double countValue = result[0];
            double sumValue = result[1];
        }

        private double[] getSumAndCountElement(double minValue,double maxValue)
        {
            int arrayLength = (int)Math.Sqrt(sourceArray.Length);
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {

                }
            }
        }
    }
}
