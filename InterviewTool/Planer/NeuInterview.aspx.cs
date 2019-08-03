using InterviewTool.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Planer
{
    public partial class NeuInterview : System.Web.UI.Page
    {
        private InterviewToolContext db = new InterviewToolContext();
        private DateTime datebegindatum;

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
        public void RadiobuttonCheck()
        {
          
            if (RadioButtonList1.SelectedIndex != -1)
            {
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    Debug.WriteLine("First");

                }
                else if (RadioButtonList1.SelectedIndex == 1)
                {
                    ListBox2.Visible = true;
                    var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InterviewToolContext"].ConnectionString);
                    cn.Open();
                    var cm = new SqlCommand("Select * from Interview WHERE Gruppe IN ('0')", cn);
                    
                    ListBox2.DataSource = cm.ExecuteReader();
                    ListBox2.DataTextField = "Titel";
                    ListBox2.DataValueField = "InterviewID";
                    ListBox2.DataBind();
                    Debug.WriteLine("Second");
                    Label1.Visible = true;
                    triggerbutton.Visible = true;

                }
            }
   
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            RadiobuttonCheck();
           
        }
        public void gettingreadytocheck()
        {
            TitelMissing.Visible = false;
            GruppeMissing.Visible = false;
            fachgebieterror.Visible = false;
        }

        protected void btnWeiter_Click(object sender, EventArgs e)
        {
            gettingreadytocheck();
            var countMissing = 0;
            var interview = new Interview();
            interview.PlanerID= new ApplicationDbContext().Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id;
           
            // Titel check
            if (txt1.Text != "")
            {
                interview.Titel = txt1.Text;
            }
            else
            {
                TitelMissing.Visible = true;
                TitelMissing.Text = "Bitte geben Sie ein Titel für Ihr Interview ein!";
                TitelMissing.ForeColor = Color.Red;
                countMissing++;
            }
            //Gruppe check


            if (RadioButtonList1.SelectedIndex != -1)
            {

                if (RadioButtonList1.SelectedIndex == 0)
                {
                    interview.Gruppe = 0;

                }
                else if (RadioButtonList1.SelectedIndex == 1)
                {
                    if (ListBox2.SelectedItem != null)
                    {

                        var item = ListBox2.SelectedItem;
                        GruppeMissing.Visible = true;
                        GruppeMissing.Text = item.Value;
                        interview.Gruppe = Convert.ToInt32(item.Value);
                    }
                    else
                    {
                        GruppeMissing.Visible = true;
                        GruppeMissing.ForeColor = Color.Red;
                        GruppeMissing.Text = "Bitte wählen Sie zu welche Veranstaltung gehört dieses Interview";
                        countMissing++;
                    }
                }
            }
            else
            {
                GruppeMissing.Visible = true;
                GruppeMissing.ForeColor = Color.Red;
                countMissing++;
                GruppeMissing.Text = "Bitte wählen Sie ob dieses Interview eine Einzelverantstaltung ist oder zu einer anderen Verantstaltung gehört";
            }



            var idnummer = 0;
            //fachgebiet check
            int countfachgebiet = 0;
            foreach (GridViewRow r in GridView1.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    CheckBox check = r.Cells[0].FindControl("CheckBox1") as CheckBox;
                    if (check.Checked)
                    {
                        if (countfachgebiet < 1)
                        {
                           
                            countfachgebiet++;
                            var value = r.Cells[1].Text;
                            var item = db.Fachgebiets.Where((f) => f.Name == value).FirstOrDefault();
                            if (item != null)
                            {
                                 idnummer = item.Id;
                                interview.FachgebietID = idnummer;
                               // interview.Fachgebiet = item;   ????????????????????????
                            }
                        }
                        else
                        {
                            fachgebieterror.Visible = true;
                            fachgebieterror.Text = "Nur das erste gewählte Fachgebiet wird genommen";
                        }



                    }
                }
            }
            if (countfachgebiet == 0)
            {
                fachgebieterror.Visible = true;
                fachgebieterror.Text = "Bitte wählen Sie ein Fachgebiet ein!";
                fachgebieterror.ForeColor = Color.Red;

            }


            //timecheck
           var begindatum =  Request.Form["datepicker"];
           var enddatum = Request.Form["datepicker1"];
           var datebegindatum = DateTime.Parse(Request.Form["datepicker"], new CultureInfo("en-US", true));
           var dateenddatum = DateTime.Parse(Request.Form["datepicker1"], new CultureInfo("en-US", true));
            if (begindatum == "")
           {

                lblbegintermin.Text = "Bitte wählen Sie das Datum ein!";
                lblbegintermin.ForeColor = Color.Red;
                countMissing++;
            }
           else
            {
                if (datebegindatum < DateTime.Today)
                {
                    lblbegintermin.Text = "Bitte wälen Sie gültiges Datum ein! ";
                    lblbegintermin.ForeColor = Color.Red;
                    countMissing++;

                }
                else
                {
                    interview.Termin_Beginn = datebegindatum;
                }
            }
           if(enddatum == "")
            {

                lblendtermin.Text = "Bitte wählen Sie das Datum ein!";
                lblendtermin.ForeColor = Color.Red;
                countMissing++;
            }
           else
            {
                if (dateenddatum < DateTime.Today)
                {
                    lblendtermin.Text = "Bitte wälen Sie gültiges Datum ein! ";
                    lblendtermin.ForeColor = Color.Red;
                    countMissing++;
                }
                else
                {

                    if (dateenddatum > datebegindatum)
                    {

                        interview.Termin_Ende = dateenddatum;
                    }
                    else
                    {
                        lblendtermin.Text = "Bitte wälen Sie gültiges Datum ein! (Beginndatum muss vorm Enddatum sein)";
                        lblendtermin.ForeColor = Color.Red;
                        countMissing++;
                    }
                }
            }
       // mind.anzahl check


                int n;
            var isNumeric = int.TryParse(txtminanzahl.Text, out  n);
            if (txtminanzahl.Text != "")
            {
                if (isNumeric)
                {
                    interview.Min_Anzahl = Convert.ToInt32(txtminanzahl.Text);
                }
                else
                {
                    lblminanzahl.Text = "Bitte geben Sie ein nummer ein!";
                    lblminanzahl.ForeColor = Color.Red;
                    countMissing++;
                }
            }
            else
            {
                lblminanzahl.Text = "Bitte geben Sie mind. anzahl Teilnehmer ein!";
                lblminanzahl.ForeColor = Color.Red;
                countMissing++;
            }
            
       
          
      




            if (countMissing == 0)
            {
               // db.Interviews.Add(new Interview() { Titel = txt1.Text, FachgebietID =idnummer, Gruppe=0, Min_Anzahl=Convert.ToInt32(txtminanzahl.Text), Termin_Beginn=Convert.ToDateTime(txtTerminBeginn.Text) , Termin_Ende=Convert.ToDateTime(txtTerminEnd.Text)});
                db.Interviews.Add(interview);
                db.SaveChanges();
                Response.Redirect("NeuInterview2.aspx?interviewid=" + interview.InterviewID);
            }
        }

     

      
 
      
      
      

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           triggerbutton_Click(sender, new EventArgs());
            
        }

        protected void triggerbutton_Click(object sender, EventArgs e)
        {
            if (ListBox2.SelectedItem != null)
            {
                Label1.Text = ListBox2.SelectedItem.Value.ToString();
                Label1.ForeColor = Color.Green;
            }

            
            
        }

       
    }
}