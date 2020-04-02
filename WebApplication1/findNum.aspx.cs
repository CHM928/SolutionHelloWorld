using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class findNum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[30];
            for (int i = 0; i < 30; i++)
            {                
                byte[] buffer = Guid.NewGuid().ToByteArray();
                int iSeed = BitConverter.ToInt32(buffer, 0);
                Random random = new Random(iSeed);                
                num[i] = Convert.ToInt32(random.Next(1, 100));
                for (int j = 0;j < i;j++)
                {
                    if( num[i] == num[j])
                    {
                        i = i - 1;
                        continue;
                    }
                }
            }

            for (var i = 0; i < num.Length; i++)
            {
                for (var j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] <= num[j + 1])
                        continue;
                    var temp = num[j + 1];
                    num[j + 1] = num[j];
                    num[j] = temp;
                }
            }

            foreach (int i in num)
            {
                Response.Write(i);
                Response.Write("<br>");
            }


            int high = 29;
            int low = 0;
            int middle = 50;
            int target = int.Parse(txtNumber.Text);
            int count = 0;

            while (low <= high)
            {
                middle = (low + high) / 2;
                count++;
                if (target == num[middle])
                {
                    Response.Write(string.Format("{2}的位置在{0}，共找了{1}次", middle, count, target));
                    return;
                }
                else if (target > num[middle])
                {
                    low = middle + 1;
                }
                else if (target < num[middle])
                {
                    high = middle - 1;
                }
            }
            Response.Write("没找到");




        }
    }
}