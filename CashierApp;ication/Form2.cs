using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp_ication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static double price, discount, quantity;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if (Log.Text.Equals("Ashly") && Passw.Text.Equals("ashly12345"))
             {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            }
             else
             {
            MessageBox.Show("Invalid Inputs");
             }
        }
    }
}
