using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CountDown1.ForeColor = Color.White;
            Refresh(); Thread.Sleep(1000);
            CountDown1.ForeColor = Color.Black;
            CountDown2.ForeColor = Color.White;
            Refresh();Thread.Sleep(1000);
            CountDown2.ForeColor = Color.Black;
            CountDown3.ForeColor = Color.White;
            Refresh();Thread.Sleep(1000);
            CountDown3.ForeColor = Color.Black;
           this.BackColor = Color.Green;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
