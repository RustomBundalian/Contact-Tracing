﻿using System;
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

        private void ResetForm()
        {
            name.Text = contact.Text = item.Text = place.Text = reward.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool result = new ItemProcess().SubmitItem(name.Text, contact.Text, item.Text, dpDateLost.Value, place.Text, reward.Text);
            if ((name.Text == contact.Text) && (contact.Text == item.Text) && (item.Text == place.Text) && (place.Text == reward.Text) && (reward.Text == ""))
            {
                MessageBox.Show("Fill up the blanks before submitting!");
                ResetForm();
            }
            else
            {
                if (result)
                {
                    MessageBox.Show("Your info has been submitted");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Something is wrong! Please try again later");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ItemLostNFound> lst = new ItemProcess().SearchItem(dpSearch.Value);
            if (lst != null)
            {
                gridSearch.DataSource = lst;
                gridSearch.Refresh();
            }
        }

        private void gridSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
