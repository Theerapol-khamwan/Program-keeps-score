using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vote
{
    public partial class conclude : Form
    {
        

        public conclude()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10,n11, max;
            n1 = int.Parse(label12.Text);
            n2 = int.Parse(label13.Text);
            n3 = int.Parse(label14.Text);
            n4 = int.Parse(label15.Text);
            n5 = int.Parse(label16.Text);
            n6 = int.Parse(label17.Text);
            n7 = int.Parse(label18.Text);
            n8 = int.Parse(label19.Text);
            n9 = int.Parse(label20.Text);
            n10 = int.Parse(label21.Text);
            n11 = int.Parse(label39.Text);
            max = n11;
            
            if (n2 > max)
            {
                max = n2;
                label40.Text = n2.ToString("พรรคชาติพัฒนา");
                //MessageBox.Show("พรรคชาติพัฒนา");
            }
            if (n3 > max)
            {
                max = n3;
                label40.Text = n3.ToString("พรรคเพื่อไทย");
                //MessageBox.Show("พรรคเพื่อไทย");
            }
            if (n4 > max)
            {
                max = n4;
                label40.Text = n4.ToString("พรรคพรรคประชาธิปัตย์");
                //MessageBox.Show("พรรคพรรคประชาธิปัตย์");
            }
            if (n5 > max)
            {
                max = n5;
                label40.Text = n5.ToString("พรรคอนาคตใหม่");
                //MessageBox.Show("พรรคอนาคตใหม่");
            }
            if (n6 > max)
            {
                max = n6;
                label40.Text = n5.ToString("พรรครวมพลังประชาชาติไทย");
                //MessageBox.Show("พรรครวมพลังประชาชาติไทย");
            }
            if (n7 > max)
            {
                max = n7;
                label40.Text = n6.ToString("พรรครวมพลังสร้างชาติ");
                //MessageBox.Show("พรรครวมพลังสร้างชาติ");
            }

            if (n8 > max)
            {
                max = n8;
                label40.Text = n8.ToString("พรรคเศรษฐกิจใหม่");
                //MessageBox.Show("พรรคเศรษฐกิจใหม่");
            }
            if (n9 > max)
            {
                max = n9;
                label40.Text = n9.ToString("พรรครักษ์สันติ");
                //MessageBox.Show("พรรครักษ์สันติ");
            }
            if (n10 > max)
            {
                max = n10;
                label40.Text = n10.ToString("พรรคพลังธรรมใหม่");
                //MessageBox.Show("พรรคพลังธรรมใหม่");
            }
            if (n1 > max)
            {
                max = n1;
                label40.Text = n1.ToString("พรรคประชารัฐ");
                //MessageBox.Show("พรรคประชารัฐ");
            }
            label36.Text = max.ToString();
            label36.Visible = true;
            
            






        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
