using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class getDay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void day_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(year.Text);
            double num2 = double.Parse(month.Text);
            double sum = double.Parse(date.Text);
            int[] yearnum = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (num1%4==0)
            {
                yearnum[1] = 29;
            }
            for (int i = 0; i < num2-1; i++)
            {
                sum = sum + yearnum[i];
            }
            Response.Write("这个日期是该年的第" + sum + "天");

        }
    }
}