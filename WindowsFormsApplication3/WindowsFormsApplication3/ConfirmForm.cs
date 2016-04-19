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
    public partial class ConfirmForm : Form
    {
        public Boolean b1_clicked;
        public Boolean b2_clicked;
        public ConfirmForm()
        {
            InitializeComponent();
            b1_clicked = false;
            b2_clicked = false;
        }
        public ConfirmForm(string[] _id, string[] _category,int[] _amount,int _count)
        {
            InitializeComponent();
            b1_clicked = false;
            b2_clicked = false;
            for (int i = 0; i < _count; i++)
            {
                ListViewItem tempitem = new ListViewItem(_id[i]);
                tempitem.SubItems.Add(_category[i]);
                tempitem.SubItems.Add(_amount[i].ToString());
                listView1.Items.Add(tempitem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b1_clicked = true;
            /*
             此处添加数据库代码，更改借工具记录
             
             */
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2_clicked = true;
            this.Close();
        }

    }
}
