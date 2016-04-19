using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class tool
    {
        private string tool_id;

        public string Tool_id
        {
            get { return tool_id; }
            set { tool_id = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public tool(string id,string cate,int qty){
            category = cate;
            quantity = qty;
            tool_id = id;
    }

    }
}
