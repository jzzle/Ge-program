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
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu form1 = new mainMenu();
            form1.Show();
            this.Hide();
        }

        private void myForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void myForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Sure to exit?", "Please confirm", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            { e.Cancel = false; }
            else if (dr == DialogResult.No)
                e.Cancel = true;
        }
    }
}
