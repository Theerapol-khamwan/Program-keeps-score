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
    public partial class county : Form
    {
        public county()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choose c1 = new choose();
            c1.Show();
            this.Hide();
            button1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choose2 c2 = new choose2();
            c2.Show();
            this.Hide();
            button1.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choose3 c3 = new choose3();
            c3.Show();
            this.Hide();
            button1.BackColor = Color.Green;
        }
    }
}
