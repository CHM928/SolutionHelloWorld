using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HomeworkchkEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string email = txtEmail1.Text;
            int atLocation = email.IndexOf("@");
            string result = "Email格式合法，顶级域名：";
            if (atLocation > 0)
            {
                string username = email.Substring(0, atLocation);
                string hostname = email.Substring(atLocation+1);//startindex的范围是从0到字符串的长度
                int pointLocation = hostname.IndexOf(".");
                if (pointLocation > 0)
                {
                    string TopDomain = hostname.Substring(pointLocation + 1);
                    if (!TopDomain.Contains(".") && TopDomain != "")
                    {
                        result = "Email格式合法，顶级域名：" + TopDomain;
                    }                   
                }
            }
            Response.Write(result);
        }
    }
}
