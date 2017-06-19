using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _0618_homework
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] = TextBox1.Text;
            Session["Username"] = TextBox2.Text;
            Session["Pssword"] = TextBox3.Text;
            Session["Birthday"] = TextBox4.Text;
            Session["Email"] = TextBox5.Text;
            Session["sex"] = DropDownList1.SelectedValue;


            string sEmail = TextBox5.Text;
            Regex pattern = new Regex(@"^\w+([.-]\w+)*@\w+([.-]\w+)+$");


            Response.Redirect("Preview.aspx");

            //Response.Write("Name - " + TextBox1.Text);
            //Response.Write("<p>Username - " + TextBox2.Text);
            //Response.Write("<p>Pssword - " + TextBox3.Text);
            //Response.Write("<p>Birthday - " + DropDownList1);
            //Response.Write("<p>sex - " + DropDownList1.SelectedValue);
        }

   
    }
}