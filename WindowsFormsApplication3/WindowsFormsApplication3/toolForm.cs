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
    public partial class toolForm : Form
    {
        public toolForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            engineerForm form1 = new engineerForm();
            form1.Show();
            this.Close();
        }

        private void toolForm_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] id = new string[5];
            string[] category = new string[5];
            int[] qty = new int[5];
            int x = 0;
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Haven't selected any tool");
            }
            else
            {
                foreach (ListViewItem i in listView1.CheckedItems)
                {
                    QtyEnterForm qtyEnter = new QtyEnterForm(i.SubItems[0].Text, i.SubItems[2].Text);
                    qtyEnter.ShowDialog();
                    if (qtyEnter.clicked == true)
                    {
                        id[x] = i.SubItems[0].Text;
                        category[x] = i.SubItems[1].Text;
                        qty[x++] = qtyEnter.getValue();
                    }
                }
                ConfirmForm f1 = new ConfirmForm(id, category, qty, listView1.CheckedItems.Count);
                f1.ShowDialog();
                this.Hide();
                if (f1.b2_clicked == true)
                {
                    this.Show();
                }
                else if (f1.b1_clicked == true)
                {
                    MessageBox.Show("Request successfully!");
                    engineerForm form2 = new engineerForm();
                    form2.Show();
                    this.Close();
                }
            }
        }
    }
}
