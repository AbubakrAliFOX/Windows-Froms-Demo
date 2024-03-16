using My_First_Windows_Froms_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Windows_Froms_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void _CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;


            if (rb.Checked && rb.Text == "Boy")
            {
                pbDisplay.Image = Resources.Boy;
            } else if (rb.Checked && rb.Text == "Girl")
            {
                pbDisplay.Image = Resources.Girl;
            } else if (rb.Checked && rb.Text == "Books")
            {
                pbDisplay.Image = Resources.Book;
            } else if (rb.Checked && rb.Text == "Pen")
            {
                pbDisplay.Image = Resources.Pen;
            }

            label1.Text = rb.Text;
        }
    }
}
