using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr = new int[5];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i<arr.Length)
            {
                arr[i] = Convert.ToInt32(textBox1.Text);
                i++;
            }
            else
            {
                MessageBox.Show("Array doldu");
            }
            textBox1.Clear();
            textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            string res = "";
            int say = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (n==arr[i])
                {
                    res = "eded var";
                    say++;
                }
            }
            if (res=="eded var")
            {
                MessageBox.Show(say.ToString());
            }
            else
            {
                MessageBox.Show("Eded yoxdur");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (int item in arr)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
