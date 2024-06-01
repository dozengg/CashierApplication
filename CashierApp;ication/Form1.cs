using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CashierApp_ication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DiscountedItem comp;
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp = new DiscountedItem(item.Text, Convert.ToDouble(price.Text), Convert.ToInt16(quantity.Text), Convert.ToDouble(discount.Text));
           totalprice.Text = comp.getTotalPrice().ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comp.setPayment(Convert.ToDouble(textBox5.Text));
          changel.Text = comp.getChange().ToString();
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.ShowDialog();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }
    }
}
