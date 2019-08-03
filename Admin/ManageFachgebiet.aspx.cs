using InterviewTool.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Admin
{
    public partial class ManageFachgebiet : System.Web.UI.Page
    {

        private InterviewToolContext db = new InterviewToolContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecords();
            }
        }

        private void LoadRecords()
        {
            var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InterviewToolContext"].ConnectionString);
            cn.Open();

            var cm = new SqlCommand("Select * from Fachgebiet", cn);
            GridView1.DataSource = cm.ExecuteReader();
            GridView1.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var hello = Request.Form["txtfachgebiet"];
            // check existing records in table
            var txtfachgebiet = Request.Form["txtfachgebiet"];
            var count = db.Fachgebiets.Where((f) => f.Name == txtfachgebiet).ToList().Count;
            //var result2 = from f in db.Fachgebiet where f.Name == txtfachgebiet.Text select f;
      
            // add if it does not exist
            if (count == 0)
            {

                if (txtfachgebiet != "")
                {
                    db.Fachgebiets.Add(new Fachgebiet() { Name = txtfachgebiet });
                    db.SaveChanges();

                    LoadRecords();
                }
                else
                {
                    Label1.Text = "Leere Eingabe ist ungültig!";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                
                
            }
            else
            {
                Label1.Text = txtfachgebiet + " wurde schon erstellt!";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                var value = e.Values[0].ToString();

                var item = db.Fachgebiets.Where((f) => f.Name == value).FirstOrDefault();

                if (item != null)
                {

                    db.Fachgebiets.Remove(item);
                    db.SaveChanges();

                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Sie Dürfen diese Fachgebiet Nicht löschen!";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
       
    }
}