using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PersonalID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;
            if (a.Length != 18) 
            {
                Response.Write("身份证长度不对");
                Response.End();
             }
            else if (int.Parse(a.Substring(10, 2)) > 13 || int.Parse(a.Substring(10, 2)) < 1) 
            {
                Response.Write("出生日期月份不合法");
                Response.End();
            }
            else if (int.Parse(a.Substring(12, 2)) > 32 || int.Parse(a.Substring(12, 2)) < 1)
            {
                Response.Write("出生日期日期不合法");
                Response.End();
            }
            else if (int.Parse(a.Substring(7, 4)) > 1949 || int.Parse(a.Substring(7, 4)) < 2020)
            {
                Response.Write("出生日期年份不合法");
                Response.End();
            }
            
            for (int i = 0; i < (a.Length  - 1); i++)
            {
                if (!char.IsDigit(a,i))
                {
                    Response.Write("身份证前17位不合法");
                    Response.End();
                }
            }

            string LastNumber = a.Substring(17, 1);
            string X = "X";
            char a_char = Convert.ToChar(LastNumber);
            if (!LastNumber.Equals(X) && !char.IsDigit(a_char))
            {
                Response.Write("第17位不合法");
                Response.End();
            }

            string Birthday = a.Substring(7, 4) + "年" + a.Substring(10, 2) + "月" + a.Substring(12, 2) + "日";

            string a_17 = a.Substring(16, 1);
            int a_17_int = Convert.ToInt32(a_17);
            string Gender;
            if (a_17_int == 1 || a_17_int == 3 || a_17_int == 5 || a_17_int == 7 || a_17_int == 9)
                 Gender = "男性";
            else Gender = "女性";

            Label1.Text = Server.HtmlEncode( Birthday + "," + Gender);
        }


    }

       
    }