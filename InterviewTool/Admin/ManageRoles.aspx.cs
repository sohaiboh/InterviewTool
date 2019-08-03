using InterviewTool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Admin
{
    public partial class ManageRoles : System.Web.UI.Page
    {
        private RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridView1.DataSource = roleManager.Roles.ToList();
            GridView1.DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            if (roleManager.FindByName(txtRole.Text) == null)
            {
                roleManager.Create(new IdentityRole(txtRole.Text));
                lblStatus.Text = "Rolle (" + txtRole.Text + ") wurde erfolgreich erstellt!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = "Rolle (" + txtRole.Text + ") existiert schon!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }

            GridView1.DataSource = roleManager.Roles.ToList();
            GridView1.DataBind();


        }

       
    }
}