using InterviewTool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace InterviewTool.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TextBox1.Text = ConfigurationManager.AppSettings["EmailFrom"];
            TextBox2.Text = ConfigurationManager.AppSettings["EmailName"];
            TextBox3.Text = ConfigurationManager.AppSettings["EmailPassword"];
            TextBox4.Text = ConfigurationManager.AppSettings["EmailSMTP"];
            TextBox5.Text = ConfigurationManager.AppSettings["EmailSMTPPort"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Panel1.Visible = !Panel1.Visible;
        }

        
    }
}