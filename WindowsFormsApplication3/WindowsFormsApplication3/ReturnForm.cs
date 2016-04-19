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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            engineerForm form1 = new engineerForm();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Haven't chosen any tools!");
            }
            foreach (ListViewItem i in listView1.CheckedItems)
            {
                /*
                 此处调用数据库代码，完成归还信息记录
                 使用SQL语言
                 */
            }
            MessageBox.Show("Return successfully");
            engineerForm form2 = new engineerForm();
            form2.Show();
            this.Close();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            string toolid;
            string category;
            int quantity;
            vitual_database vdb = new vitual_database();
            for (int i = 0; i < vdb.CategoryAmount; i++)
            {
                toolid = vdb.Toolinf[i].Tool_id;
                category = vdb.Toolinf[i].Category;
                quantity = vdb.Toolinf[i].Quantity;
                ListViewItem tempitem = new ListViewItem(toolid);
                tempitem.SubItems.Add(category);
                tempitem.SubItems.Add(quantity.ToString());
                listView1.Items.Add(tempitem);
            }
        }
    }
}
