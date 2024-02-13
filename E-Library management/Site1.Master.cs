using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true; //user login linkbutton
                    LinkButton2.Visible = true; //signup link button

                    LinkButton3.Visible = false; // logout link button
                    LinkButton7.Visible = false; // Hello userlink button

                    LinkButton6.Visible = true; // Admin login button
                    LinkButton11.Visible = false; // author management link button
                    LinkButton12.Visible = false; // publisher management link button
                    LinkButton8.Visible = false; // book inventory link button
                    LinkButton9.Visible = false; // book issuing link button
                    LinkButton10.Visible = false; // member management link button



                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //user login linkbutton
                    LinkButton2.Visible = false; //signup link button

                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; // Hello userlink button
                    LinkButton7.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = true; // Admin login button
                    LinkButton11.Visible = false; // author management link button
                    LinkButton12.Visible = false; // publisher management link button
                    LinkButton8.Visible = false; // book inventory link button
                    LinkButton9.Visible = false; // book issuing link button
                }

                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //user login linkbutton
                    LinkButton2.Visible = false; //signup link button

                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; // Hello userlink button
                    LinkButton7.Text = "Hello admin";

                    LinkButton6.Visible = false; // Admin login button
                    LinkButton11.Visible = true; // author management link button
                    LinkButton12.Visible = true; // publisher management link button
                    LinkButton8.Visible = true; // book inventory link button
                    LinkButton9.Visible = true; // book issuing link button
                }
            }
            catch (Exception ex)
            {

            }
        
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminloginpage.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuingpage.aspx");

        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userloginpage.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";

            LinkButton1.Visible = true; //user login linkbutton
            LinkButton2.Visible = true; //signup link button

            LinkButton3.Visible = false; // logout link button
            LinkButton7.Visible = false; // Hello userlink button

            LinkButton6.Visible = true; // Admin login button
            LinkButton11.Visible = false; // author management link button
            LinkButton12.Visible = false; // publisher management link button
            LinkButton8.Visible = false; // book inventory link button
            LinkButton9.Visible = false; // book issuing link button
            LinkButton10.Visible = false; // member management link button

        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {

        }
    }
}