using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        int Index = 0;
        int SumAll;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Add(lstMenu.Text);
          
            Index = lstMenu.SelectedIndex;
            SumAll += int.Parse(Convert.ToString(lstPrice.Items[Index]));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Remove(lstZakaz.SelectedItem);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Приятного аппетита! \n Сумма заказа {SumAll}", "Ресторан студент");
            this.Close();
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstMenu.Items.Add(txtRemake.Text);
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Clear();
        }

        private void lstPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
