using InterviewTool.Code;
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
    public partial class Ergebnisse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            var query = @"select  Teilnehmer.InterviewID, Ergebnis.* from Teilnehmer
                        inner join Ergebnis on Teilnehmer.ErgebnisID = Ergebnis.ErgebnisId
                        where Teilnehmer.InterviewID =" + Request.QueryString["InterviewId"];


            var db = new DB();
            GridView1.DataSource = db.ExecuteReader(query);
            GridView1.DataBind();

        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}