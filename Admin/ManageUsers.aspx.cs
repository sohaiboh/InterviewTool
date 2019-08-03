using InterviewTool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Admin
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        private InterviewToolContext db = new InterviewToolContext();
        private ApplicationUserManager userManager;
        public ManageUsers()
        {
            userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }


        protected void Page_Load(object sender, EventArgs e)
        { 
            GridView1.DataSource = userManager.Users.ToList();
            GridView1.DataBind();

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {

            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = new ApplicationUser() { UserName = txtEmail.Text, Email = txtEmail.Text };


            var pwd = System.Web.Security.Membership.GeneratePassword(8, 1);
            var r = new Random();

            pwd = pwd + r.Next(0, 10).ToString();

            user.ChangePassword = true;

            IdentityResult result = manager.Create(user, pwd);

            if (result.Succeeded)
            {
                var emailMessage = "Hallo,<br><br>Ihr Account wurde erfolgreich erstellt! Hier finden Sie Ihre Login Information. <br><br>";

                emailMessage += "Email: " + txtEmail.Text + "<br>";
                emailMessage += "Passwort: " + pwd + "<br><br>";
                emailMessage += "Danke";

                Email.SendEmail("Einladung für unsere Interview Tool", emailMessage, txtEmail.Text);
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Ihr Account wurde erfolgreich erstellt!";
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Nutzer kann nicht erstellt werden. Bitte überprüfen Sie Ihre Eingabe!";
            }

            
            //  db.Fachgebiet.Add(new Fachgebiet() { Name = .Text });
            //  db.SaveChanges();

            GridView1.DataSource = userManager.Users.ToList();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

                var value = e.Values[0].ToString();
                userManager.Delete(userManager.FindByName(value));

                GridView1.DataSource = userManager.Users.ToList();
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Label1.Text = "Sie Dürfen diese Nutzer Nicht löschen!";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}