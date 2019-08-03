using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool
{
    public partial class TestEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
             Email.SendEmail("Interview Tool", "GFIA GMBH", "arsl94@hotmail.com");
            Label1.Text = "Email sent";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToShortTimeString();
        }
    }
}