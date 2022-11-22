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
    public partial class choose2 : Form
    {
        conclude co = new conclude();
        Class1 sendscore = new Class1();
        int score1, score2, score3, score4, score5, score6, score7, score8, score9, score10;
        Double all, sum;
        Double p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
        public string OK { get; private set; }

        private void choose2_Load(object sender, EventArgs e)
        {

        }

        public choose2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score1 = sendscore.GetScorel(score1);
            co.label12.Text = score1.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score2 = sendscore.GetScorel(score2);
            co.label13.Text = score2.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            score3 = sendscore.GetScorel(score3);
            co.label14.Text = score3.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            score4 = sendscore.GetScorel(score4);
            co.label15.Text = score4.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            score5 = sendscore.GetScorel(score5);
            co.label16.Text = score5.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            score6 = sendscore.GetScorel(score6);
            co.label17.Text = score6.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            score7 = sendscore.GetScorel(score7);
            co.label18.Text = score7.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            score8 = sendscore.GetScorel(score8);
            co.label19.Text = score8.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            score9 = sendscore.GetScorel(score9);
            co.label20.Text = score9.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            score10 = sendscore.GetScorel(score10);
            co.label21.Text = score10.ToString();
            MessageBox.Show("คุณได้เลือกพรรคเรียบร้อยแล้ว", "");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            all = score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8 + score9 + score10;
            co.all.Text = all.ToString();
            sum = all / 5;
            co.sum.Text = sum.ToString();
            p1 = score1 / sum;
            co.label24.Text = p1.ToString();
            p2 = score2 / sum;
            co.label25.Text = p2.ToString();
            p3 = score3 / sum;
            co.label26.Text = p3.ToString();
            p4 = score4 / sum;
            co.label27.Text = p4.ToString();
            p5 = score5 / sum;
            co.label28.Text = p5.ToString();
            p6 = score6 / sum;
            co.label29.Text = p6.ToString();
            p7 = score7 / sum;
            co.label30.Text = p7.ToString();
            p8 = score8 / sum;
            co.label31.Text = p8.ToString();
            p9 = score9 / sum;
            co.label32.Text = p9.ToString();
            p10 = score10 / sum;
            co.label33.Text = p10.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.button12.Hide();
            co.Show();
        }
    }
}
