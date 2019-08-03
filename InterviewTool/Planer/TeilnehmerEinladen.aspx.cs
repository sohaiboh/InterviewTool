using InterviewTool.Code;
using InterviewTool.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Data;
//using iTextSharp.Text;


namespace InterviewTool.Planer
{
    public partial class TeilnehmerEinladen : System.Web.UI.Page
    {
        private ApplicationUserManager userManager;
        private InterviewToolContext db = new InterviewToolContext();

        public TeilnehmerEinladen()
        {
            userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                GridView1.DataSource = userManager.Users.ToList();
                GridView1.DataBind();

                var users = userManager.Users.ToList();
                var FachgebietID = Convert.ToInt32(Request.QueryString["FachgebietID"]);

                var db = new DB();
                var query = @"Select * from AspNetUsers
                            inner join Kompetenz on AspNetUsers.Id = Kompetenz.UserId
                            where Kompetenz.FachgebietId = " + FachgebietID;

                GridView2.DataSource = db.ExecuteReader(query);
                GridView2.DataBind();
                
            }
        }

        protected void btnSendInvitation_Click(object sender, EventArgs e)
        {


            var userlist = "";
            var url = "http://localhost:53061/Teilnehmer/Interview/?interviewid=";

            Literal1.Text = "<p class='success'>Email wurde erfolgreich gesendet!</p>";
            if (btnShowAllUsers.Text != "Alle Nutzer anzeigen")
            {
                // how to get checked items from gridview
                foreach (GridViewRow r in GridView1.Rows)
                {
                    if (r.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox check = r.Cells[0].FindControl("CheckBox1") as CheckBox;
                        if (check.Checked)
                        {
                            
                            Literal1.Text += $"<strong>{r.Cells[1].Text}</strong><br>";
                            userlist += r.Cells[1].Text + Environment.NewLine;
                            var emailMessage = "Hallo,<br><br>Sie haben den Interview Tool HTW ein Link bekommen.Klicken Sie dazu bitte einfach auf den entsprechenden Link in dieser E-Mail.<br><br>";

                            // Link for the interview
                            var InterviewId = Request.QueryString["InterviewId"];
                            emailMessage += "Link :  " + url + InterviewId + "<br>";

                            emailMessage += "Danke";

                            Email.SendEmail("Einladung zum Interview ", emailMessage, r.Cells[1].Text);
                        }
                    }
                }
            }
            else
            {
                foreach (GridViewRow r in GridView2.Rows)
                {
                    if (r.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox check = r.Cells[0].FindControl("CheckBox2") as CheckBox;
                        if (check.Checked)
                        {
                          
                            Literal1.Text += $"<strong>{r.Cells[1].Text}</strong><br>";
                            userlist += r.Cells[1].Text + Environment.NewLine;
                            var emailMessage = "Hallo,<br><br>Sie haben den Interview Tool HTW ein Link bekommen.Klicken Sie dazu bitte einfach auf den entsprechenden Link in dieser E-Mail.<br><br>";

                            // Link for the interview
                            var InterviewId = Request.QueryString["InterviewId"];
                            emailMessage += "Link :  " + url + InterviewId + "<br>";

                            emailMessage += "Danke";

                            Email.SendEmail("Einladung zum Interview ", emailMessage, r.Cells[1].Text);
                        }
                    }
                }
            }
            var interviewId = Request.QueryString["InterviewId"];
            userlist = "Nutzer Liste:\n\n" + userlist;
            PDF.SaveToPDF(Server.MapPath("~/Content/PDFs/") + $"Interview{interviewId}.pdf", userlist);
            


        }

        protected void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            if (btnShowAllUsers.Text == "Alle Nutzer anzeigen")
            {
                GridView2.Visible = false;
                Panel1.Visible = true;
                btnShowAllUsers.Text = "Interressierte Nutzer anzeigen";
            }
            else
            {
                GridView2.Visible = true;
                Panel1.Visible = false;
                btnShowAllUsers.Text = "Alle Nutzer anzeigen";
            }
            
        }
    }
}