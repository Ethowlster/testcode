using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflex_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstCity.GetItemText(lstCity.SelectedItem);
            MessageBox.Show($"You live in {text}");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String address = txtAddress.Text;

            MessageBox.Show (name + address);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
