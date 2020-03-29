using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ExampleGetMAx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double num3 = double.Parse(txtNum3.Text);
            double max ;
            max = num1 >= num2 ? num1 : num2;
            max = max >= num3 ? max : num3;
            Response.Write("三个数的最大值是：" + max);
        }
    }
}