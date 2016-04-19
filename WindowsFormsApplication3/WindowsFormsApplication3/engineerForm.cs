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
    public partial class engineerForm : Form
    {
        public engineerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             mainMenu form1 = new mainMenu();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolForm form4 = new toolForm();
            form4.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnForm form5 = new ReturnForm();
            form5.Show();
            this.Close();
        }


    }
}
