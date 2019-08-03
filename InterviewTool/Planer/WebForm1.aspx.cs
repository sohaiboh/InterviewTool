using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Planer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ApplicationUserManager userManager;
        public WebForm1()
        {
            userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}