using InterviewTool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Admin
{
    public partial class EditUser : System.Web.UI.Page
    {
        private ApplicationUserManager userManager;
        private RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));


        public EditUser()
        {
            userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text= Request.QueryString["username"];
                
                var username = Request.QueryString["username"];
                Label1.ForeColor = System.Drawing.Color.Green;
                var user = userManager.FindByNameAsync(username).Result;
                GridView1.DataSource = userManager.GetRoles(user.Id);//user.Role.s.ToList();
                GridView1.DataBind();

                ddlRoles.DataSource = roleManager.Roles.ToList();   
                ddlRoles.DataValueField = "Id";
                ddlRoles.DataTextField = "Name";
                ddlRoles.DataBind();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var username = Request.QueryString["username"];
            var user = userManager.FindByNameAsync(username).Result;


            userManager.AddToRole(user.Id, ddlRoles.SelectedItem.Text);

            GridView1.DataSource = userManager.GetRoles(user.Id); //user.Roles.ToList();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var value = e.Values[0].ToString();
            var username = Request.QueryString["username"];
            var user = userManager.FindByNameAsync(username).Result;
            userManager.RemoveFromRole(user.Id, value);
            GridView1.DataSource = userManager.GetRoles(user.Id);//user.Roles.ToList();
            GridView1.DataBind();
        }
    }
}