using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUP___Lost_and_Found
{
    public partial class LF : Form
    {
        public LF()
        {
            InitializeComponent();
        }

        private void LF_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Tom\Downloads\LostnFound.txt");
            file.WriteLine("Full Name: " + name.Text);
            file.WriteLine("Contact No: " + contact.Text);
            file.WriteLine("Item Lost: " + item.Text);
            file.WriteLine("Time you've lose the item: " + time.Text);
            file.WriteLine("Places you've been: " + place.Text);
            file.WriteLine("Reward (Optional): " + reward.Text);
            file.Close();
        }
    }
}
