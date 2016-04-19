using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class vitual_database
    {
        private tool[] toolinf;

        internal tool[] Toolinf
        {
            get { return toolinf; }
            set { toolinf = value; }
        }
        private int categoryAmount;

        public int CategoryAmount
        {
            get { return categoryAmount; }
            set { categoryAmount = value; }
        }
        public vitual_database()
        {
            toolinf = new tool[5];
            toolinf[0] = new tool("PAT1102","AIR PUMP", 2);
            toolinf[1] = new tool("HH001","HYDRAULIC HOSES", 1);
            toolinf[2] = new tool("RC102","HYDRAULIC CLYINDER", 2);
            toolinf[3] = new tool("RSM100","HYDRAULIC CLYINDER", 2);
            toolinf[4] = new tool("G2535L","Glycerim Gauge", 2);
            categoryAmount = 5;
        }
    }
}
