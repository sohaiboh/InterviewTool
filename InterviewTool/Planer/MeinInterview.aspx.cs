using InterviewTool.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Planer
{
    public partial class MeinInterview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InterviewToolContext"].ConnectionString);
            cn.Open();
            var myuser = new ApplicationDbContext().Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();

            var cm = new SqlCommand(@"Select Interview.InterviewID, Interview.FachgebietID, Interview.Titel, Interview.Termin_Beginn, Interview.Termin_Ende, 

count(Teilnehmer.UserID) as InterviewsCount, Status = case 
														when  getDate() >= Interview.Termin_Beginn and getDate() <= Interview.Termin_Ende then 1
														else 0
														end
 from Interview left outer join Teilnehmer on Interview.InterviewID = Teilnehmer.InterviewID
Where Interview.PlanerId='" + myuser.Id + "' " +
 "group by Interview.InterviewID, Interview.FachgebietID, Interview.Titel, Interview.Termin_Beginn, Interview.Termin_Ende", cn);
            // count how many people did one interview
          // var cm2 = new SqlCommand("", cn);
            //check if the interview still on/off( datum ) 
          //  var cm3 = new SqlCommand("", cn);
            // should we invite people to interview from here?

            GridView1.DataSource = cm.ExecuteReader();
            GridView1.DataBind();

        }
    }
}