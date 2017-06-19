using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _0618_homework
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) {
                    TextBox1.Text = Session["Name"].ToString();
                    TextBox2.Text = Session["Username"].ToString();
                    TextBox3.Text = Session["Pssword"].ToString();
                    TextBox4.Text = Session["Birthday"].ToString();
                    TextBox5.Text = Session["Email"].ToString();
                    DropDownList1.SelectedValue = Session["sex"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}