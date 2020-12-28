using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string color = textBox1.Text;
            try
            {
                string[] a;
                if (color.Contains(","))
                {
                    a = color.Split(',');
                }
                else
                {
                    a = color.Split('，');
                };
                int x = Convert.ToInt16(a[0]);
                int y = Convert.ToInt16(a[1]);
                int z = Convert.ToInt16(a[2]);
                string b;
                b = String.Format("#{0:X}{1:X}{2:X}", x, y, z);
                if (x <= 15 && y <= 15 && z <= 15)
                {
                    b = String.Format("#{0:X}{1:X}{2:X}{3:X}{4:X}{5:X}", x, x, y, y, z, z);
                }
                else if (x <= 15 && z <= 15)
                {
                    b = String.Format("#{0:X}{1:X}{2:X}{3:X}{4:X}", x, x, y, z, z);
                }
                else if (y <= 15 && z <= 15)
                {
                    b = String.Format("#{0:X}{1:X}{2:X}{3:X}{4:X}", x, y, y, z, z);
                }
                else if (x <= 15 && y <= 15)
                {
                    b = String.Format("#{0:X}{1:X}{2:X}{3:X}{4:X}", x, x, y, y, z);
                }
                else if (y <= 15)
                {
                    b = String.Format("#{0:X}{1:X}{2:X}{3:X}", x, y, y, z);
                }
                else if (z <= 15)
                {
                    b = String.Format("#{0:X}{1:X}{2:X}{3:X}", x, y, z, z);
                }
                else if (x <= 15)
                {
                    b = String.Format("#{0:X}{1:X}{2:X}{3:X}", x, x, y, z);
                }
                textBox2.Text = b;
            }
            catch (Exception)
            {
                textBox2.Text = "输入错误";
            }
        }
    }
}
