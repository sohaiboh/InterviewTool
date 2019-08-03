using InterviewTool.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool
{
    public partial class _Default : Page 
    {
        private InterviewToolContext db = new InterviewToolContext();
        private ApplicationUserManager userManager;
        private RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

        private void LoadRecords()
        {
           
            var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InterviewToolContext"].ConnectionString);
            cn.Open();
            var cm = new SqlCommand("Select * from Fachgebiet", cn);

            ListBox1.DataSource = cm.ExecuteReader();
            ListBox1.DataTextField = "Name";
            ListBox1.DataValueField = "Id";
            ListBox1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var myuser = new ApplicationDbContext().Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            if (!IsPostBack)
            {
                userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                LoadRecords();
                if (User.Identity.IsAuthenticated)
                {
                    GridView1.DataSource = userManager.GetRoles(myuser.Id);//user.Roles.ToList();
                    GridView1.DataBind();
                    Panel2.Visible = true;
                }
            }
           
            

            if (User.Identity.IsAuthenticated)
            {
                userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var kompetenzs = db.Kompetenzs.Where(k => k.UserId == myuser.Id).ToList();

                // hide panel if there is no Kompetenz for the current user.
                if (kompetenzs.Count == 0)
                {
                    Panel1.Visible = true;
                }
                else
                {
                    Panel1.Visible = false;
                }
         





            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Kompetenz komp = new Kompetenz();
            if(ListBox1.SelectedItem !=null )
            {
                var item = ListBox1.SelectedItem;
                komp.FachgebietId = Convert.ToInt32(item.Value);
                if(TextBox1.Text!=null)
                {
                    komp.LevelValue = TextBox1.Text;
                }
                var myuser = new ApplicationDbContext().Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
                komp.UserId = myuser.Id;
                db.Kompetenzs.Add(komp);
                db.SaveChanges();

            }
        }

     
    }
}