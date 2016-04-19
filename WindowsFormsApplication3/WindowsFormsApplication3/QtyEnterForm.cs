using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class QtyEnterForm : Form
    {
        public Boolean clicked = false;
        private int amount = 0;
        public QtyEnterForm()
        {
            InitializeComponent();
        }
        public QtyEnterForm(string catename, string quant)
        {
            InitializeComponent();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("DINPro-Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 20);
            label1.Text = "Quantity of " + catename;
            amount = Convert.ToInt32(quant);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value == 0)
                MessageBox.Show("Amount can't be 0!");
            else if (amount >= (int)numericUpDown1.Value)
            {
                clicked = true;
                this.Close();
            }
            else
            { MessageBox.Show("There aren't enough tools，please input again!"); }

        }
        public int getValue() { return (int)numericUpDown1.Value; }

        private void QtyEnterForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
