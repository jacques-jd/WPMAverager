using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPMAverager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput.Text, out int output))
            {
                //error
                return;
            }

            lstResults.Items.Add(output);

            int total = 0;
            foreach(int result in lstResults.Items)
            {
                total += result;
            }
            lblAverage.Text = $"Average: {total/lstResults.Items.Count}";
            txtInput.Focus();
        }
    }
}
