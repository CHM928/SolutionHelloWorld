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
            int num1 = int.Parse(year.Text);
            int num2 = int.Parse(month.Text);
            int sum = int.Parse(date.Text);
            int[] yearnum = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ( num1 % 4 ==0 && num1 % 100 !=0 || num1 % 400 == 0)
            {
                yearnum[1] = 29;
            }            
            for (int i = 0; i < num2-1; i++)
            {
                sum += yearnum[i];
            }
            Response.Write("这个日期是该年的第" + sum + "天");

        }
    }
}