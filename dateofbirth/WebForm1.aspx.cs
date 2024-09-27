using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dateofbirth
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int cyear = DateTime.Now.Year;
                for (int i = cyear; i >= 1980; i--)
                {
                    DropDownList1.Items.Add(i.ToString());
                }
                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                DropDownList2.DataSource = months;
                DropDownList2.DataBind();
                for (int i = 1; i <= 31; i++)
                {
                    DropDownList3.Items.Add(i.ToString());
                }
            }
            
        }
 

        protected void Button1_Click(object sender, EventArgs e)
        {
            string d = DropDownList3.SelectedItem.ToString();
            int m = DropDownList2.SelectedIndex + 1;
            string y = DropDownList1.SelectedItem.ToString();
            string dob = d + "/" + m + "/" + y;
            Label3.Text = dob;
            Label4.Visible = true;
            Label3.Visible = true;
        }
    }
}