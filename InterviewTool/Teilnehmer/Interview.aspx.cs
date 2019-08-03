using InterviewTool.Code;
using InterviewTool.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Teilnehmer
{
 
    public partial class Interview : System.Web.UI.Page
    {
        InterviewToolContext context = new InterviewToolContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                {

                if (Request.QueryString["InterviewID"] != null)
                {
                    GetInterview(Request.QueryString["InterviewID"].ToString());
                }

            }
        }

        private void  GetInterview(string id)
        {
            var db = new DB();
            var query = @"Select * from Interview where Interview.InterviewID = " + id;
            
            //var cm = new SqlCommand (@"Select * from Interview where Interview.InterviewID = " + id);
             var reader = db.ExecuteReader(query);
            if (reader.Read())
            {
                Label1.Text = Convert.ToString(reader["Titel"]);
            }
        }

 
        protected void ListView1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

            var db = new DB();
            var frageid = e.Item.FindControl("FrageidLabel1") as Label;
            var frageantwortformat = e.Item.FindControl("Anwortformat1") as Label;
            var Audio = e.Item.FindControl("AudiodateiLabel") as Label;
            if(Audio.Text!="")
            {
                e.Item.FindControl("AudiodateiLabel").Visible = false;
                e.Item.FindControl("Bilddatei1").Visible = false;
                e.Item.FindControl("audio1").Visible = true;
                
            }
            int number;
            if (frageantwortformat.Text=="Text")
            {
                if ((int.TryParse(frageid.Text, out number)))
                {
                    var query = @"Select * from [Antwort-Text] Where Frageid = " + number;
                    var reader = db.ExecuteReader(query);
                    if (reader.Read())
                    {
                        if (Convert.ToString(reader["möglich-text-antwort1"]) != "")
                        {
                            (e.Item.FindControl("RadioButton1") as CheckBox).Text = Convert.ToString(reader["möglich-text-antwort1"]);
                            (e.Item.FindControl("RadioButton2") as CheckBox).Text = Convert.ToString(reader["möglich-text-antwort2"]);
                            if (Convert.ToString(reader["möglich-text-antwort3"]) != "")
                            {
                                (e.Item.FindControl("RadioButton3") as CheckBox).Text = Convert.ToString(reader["möglich-text-antwort3"]);
                            }
                            else
                            {
                                e.Item.FindControl("RadioButton3").Visible = false;
                                e.Item.FindControl("RadioButton4").Visible = false;
                            }
                            if (Convert.ToString(reader["möglich-text-antwort4"]) != "")
                            {
                                (e.Item.FindControl("RadioButton4") as CheckBox).Text = Convert.ToString(reader["möglich-text-antwort4"]);
                            }
                            else
                            {
                                e.Item.FindControl("RadioButton4").Visible = false;
                            }
                            e.Item.FindControl("range1").Visible = false;
                        }
                       
                    }
                }
            }
            else
            {
                
                e.Item.FindControl("RadioButton1").Visible = false;
                e.Item.FindControl("RadioButton2").Visible = false;
                e.Item.FindControl("RadioButton3").Visible = false;
                e.Item.FindControl("RadioButton4").Visible = false;
                e.Item.FindControl("range1").Visible = true;

                var ct = e.Item.FindControl("range1") as TextBox;

                if (ct != null)
                {

                    var skalar = context.Skalars.Where(s => s.Idfrage.ToString() == frageid.Text).FirstOrDefault();
                    if (skalar != null)
                    {
                        ct.Attributes.Add("min", skalar.Anfangswert.ToString()); //0
                        ct.Attributes.Add("max", skalar.Endwert.ToString());
                        ct.Attributes.Add("step", skalar.Schrittweite.ToString());
                        ct.Text = "0";
                    }
                }

            }


            

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var counter = 0;
            var ergebni = new Ergebni();

            foreach (var item in ListView1.Items)
            {
                counter++;
                var frageid = item.FindControl("FrageidLabel1") as Label;
                var frageantwortformat = item.FindControl("Anwortformat1") as Label;
                var Audio = item.FindControl("AudiodateiLabel") as Label;

                var RadioButton1 = item.FindControl("RadioButton1") as RadioButton;
                var RadioButton2 = item.FindControl("RadioButton2") as RadioButton;
                var RadioButton3 = item.FindControl("RadioButton3") as RadioButton;
                var RadioButton4 = item.FindControl("RadioButton4") as RadioButton;
                var range1 = item.FindControl("range1") as TextBox;

                var answer = "";
                if (frageantwortformat.Text == "Text")
                {
                    if (RadioButton1.Checked)
                    {
                        answer = RadioButton1.Text;
                    }
                    if (RadioButton2.Checked)
                    {
                        answer = RadioButton2.Text;
                    }
                    if (RadioButton3.Checked)
                    {
                        answer = RadioButton3.Text;
                    }
                    if (RadioButton4.Checked)
                    {
                        answer = RadioButton4.Text;
                    }
                }
                else
                {
                    answer = range1.Text;
                }

                switch (counter)
                {
                    case 1:
                        ergebni.ErgFrage1 = answer;
                        break;
                    case 2:
                        ergebni.ErgFrage2 = answer;
                        break;
                    case 3:
                        ergebni.ErgFrage3 = answer;
                        break;
                    case 4:
                        ergebni.ErgFrage4 = answer;
                        break;
                    case 5:
                        ergebni.ErgFrage5 = answer;
                        break;
                    case 6:
                        ergebni.ErgFrage6 = answer;
                        break;
                    case 7:
                        ergebni.ErgFrage7 = answer;
                        break;
                    case 8:
                        ergebni.ErgFrage8 = answer;
                        break;
                    case 9:
                        ergebni.ErgFrage9 = answer;
                        break;
                    case 10:
                        ergebni.ErgFrage10 = answer;
                        break;
                    default:
                        break;
                } // end switch
            } // end foreach

            context.Ergebnis.Add(ergebni);
            context.SaveChanges();

            var teilnehmer = new Models.Teilnehmer();
            var myuser = new ApplicationDbContext().Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            teilnehmer.UserID = myuser.Id;
            teilnehmer.InterviewID = Convert.ToInt32(Request.QueryString["InterviewID"]);
            teilnehmer.ErgebnisID = ergebni.ErgebnisId;
            context.Teilnehmers.Add(teilnehmer);
            context.SaveChanges();
            Response.Redirect("/Default.aspx");
        }
    }
}