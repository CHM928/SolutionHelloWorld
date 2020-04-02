using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PrintNumberPyramid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            int lineMax = int.Parse(txtNumber.Text);
            if (lineMax >= 10 || lineMax < 0)
                return;
            else
            {
                for (int currentLine = 1; currentLine <= lineMax; currentLine++)
                {
                    for (int j = 1; j <= (lineMax - currentLine); j++)
                        result.Append("&nbsp;&nbsp;");
                    for (int star = 1; star <= currentLine; star++)
                        result.Append(star);
                    for (int next = currentLine - 1; next > 0; next = next - 1)
                        result.Append(next);
                    result.Append("<br>");

                }
                Response.Write(result);
            }


        }
    }
}