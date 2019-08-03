using InterviewTool.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterviewTool.Planer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private InterviewToolContext db = new InterviewToolContext();
        private ApplicationUserManager userManager;
        public WebForm1()
        {
            userManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //questions/answers 
            


        }

        protected void ddlFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFileType.Text == "Audio")
            {
                audioRow.Visible = true;
                pictureRow.Visible = false;
            }
            else if (ddlFileType.Text == "Picture")
            {
                audioRow.Visible = false;
                pictureRow.Visible = true;
            }
            else
            {
                audioRow.Visible = false;
                pictureRow.Visible = false;
            }
        }
        protected void ddlAnswerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAnswerType.Text == "Text")
            {

                antwort1.Visible = true;
                antwort2.Visible = true;
                antwort3.Visible = true;
                antwort4.Visible = true;
                antskalaranfang.Visible = false;
                antskalarend.Visible = false;
                antskalarschritt.Visible = false;
            }
            else if (ddlAnswerType.Text == "Skalar")
            {
                antskalarschritt.Visible = true;
                antskalarend.Visible = true;
                antskalaranfang.Visible = true;
                antwort1.Visible = false;
                antwort2.Visible = false;
                antwort3.Visible = false;
                antwort4.Visible = false;
            }
            else
            {

                antwort1.Visible = false;
                antwort2.Visible = false;
                antwort3.Visible = false;
                antwort4.Visible = false;
                antskalarschritt.Visible = false;
                antskalarend.Visible = false;
                antskalaranfang.Visible = false;

            }

        }
        public void gettingreadytocheck()
        {

            lblAnfang.Visible = false;
            lblAnswertype.Visible = false;
            lblAudio.Visible = false;
            lblEnd.Visible = false;
            lblFiletype.Visible = false;
            lblfrage.Visible = false;
            lblMögliche1.Visible = false;
            lblMögliche2.Visible = false;
            lblpicture.Visible = false;
            lblSchritt.Visible = false;
        }

        public void speichern()
        {


            gettingreadytocheck();
            var countMissing = 0;
            var frage = new Frage();
            frage.InterviewId = Convert.ToInt32(Request.QueryString["InterviewId"]);


            if (ddlFileType.Text == "Audio")
            {

                if (FileUploadAudio.HasFile)
                {
                    if (Path.GetExtension(FileUploadAudio.FileName) == ".mp3" || Path.GetExtension(FileUploadAudio.FileName) == ".wav")
                    {

                        FileUploadAudio.PostedFile.SaveAs(Server.MapPath("~/Content/Uploads/") + FileUploadAudio.FileName);
                        frage.Audiodatei = FileUploadAudio.FileName;


                    }
                    else
                    {
                        lblAudio.Visible = true;
                        lblAudio.Text = "Bitte wählen Sie ein gültige Audio datei(.mp3 oder .wav)";
                        lblAudio.ForeColor = Color.Red;
                        countMissing++;
                    }

                }

                else
                {
                    lblAudio.Visible = true;
                    lblAudio.Text = "Bitte wählen Sie ein Audio datei";
                    lblAudio.ForeColor = Color.Red;
                    countMissing++;
                }

            }
            else if (ddlFileType.Text == "Picture")
            {
                if (FileUploadPicture.HasFile)
                {
                    if (Path.GetExtension(FileUploadPicture.FileName) == ".PNG"
                        || Path.GetExtension(FileUploadPicture.FileName) == ".JPG"
                        || Path.GetExtension(FileUploadPicture.FileName) == ".GIF"
                         || Path.GetExtension(FileUploadPicture.FileName) == ".png"
                        || Path.GetExtension(FileUploadPicture.FileName) == ".jpg"
                        || Path.GetExtension(FileUploadPicture.FileName) == ".gif")
                    {
                        FileUploadPicture.PostedFile.SaveAs(Server.MapPath("~/Content/Uploads/") + FileUploadPicture.FileName);

                        frage.Bilddatei1 = FileUploadPicture.FileName;
                    }
                    else

                    {
                        lblpicture.Visible = true;
                        lblpicture.Text = "Bitte wählen Sie ein gültige Bild datei (.png / .jpg oder .gif )";
                        lblpicture.ForeColor = Color.Red; countMissing++;
                    }

                }
                else
                {
                    lblpicture.Visible = true;
                    lblpicture.Text = "Bitte wählen Sie ein Bild";
                    lblpicture.ForeColor = Color.Red;
                    countMissing++;
                }
            }
            else
            {
                lblFiletype.Visible = true;
                lblFiletype.Text = "Bitte wählen Sie ein Dateityp!";
                lblFiletype.ForeColor = Color.Red;
                countMissing++;

            }

            if (txtfrage.Text == "")
            {
                lblfrage.Text = "Biite geben Sie eine Frage ein!";
                lblfrage.ForeColor = Color.Red;
                lblfrage.Visible = true;
                countMissing++;
            }
            else
            {
                frage.Bezeichnung = txtfrage.Text;
            }
            int n;
            if (ddlAnswerType.Text == "Skalar")
            {
                frage.Anwortformat = "Skalar";
                //first value
                if (txtAnfangwert.Text == "")
                {
                    lblAnfang.Visible = true; countMissing++;
                    lblAnfang.Text = "Bitte geben Sie ein anfangsWert ein!";
                    lblAnfang.ForeColor = Color.Red;
                }
                else
                {
                    if (!int.TryParse(txtAnfangwert.Text, out n))
                    {
                        lblAnfang.Visible = true;
                        lblAnfang.ForeColor = Color.Red;
                        lblAnfang.Text = "Bitte geben sie ein positiv ganze Zahl ein!";
                        countMissing++;
                    }



                }


                //second value

                if (txtEndwert.Text == "")
                {
                    lblEnd.Visible = true;
                    lblEnd.Text = "Bitte geben Sie ein endeWert ein!";
                    lblEnd.ForeColor = Color.Red;
                    countMissing++;
                }


                else
                {
                    if (!int.TryParse(txtEndwert.Text, out n))
                    {
                        lblEnd.Visible = true;
                        lblEnd.Text = "Bitte geben Sie ein positiv ganze Zahl ein!";
                        lblEnd.ForeColor = Color.Red;
                        countMissing++;
                    }
                    else
                    {
                        if (int.TryParse(txtEndwert.Text, out n) || int.TryParse(txtAnfangwert.Text, out n))
                        {
                            int x = Convert.ToInt32(txtAnfangwert.Text);
                            int y = Convert.ToInt32(txtEndwert.Text);
                            if (x > y || x == y)
                            {
                                lblEnd.Visible = true;
                                lblEnd.Text = "Bitte prüfen Sie ihre Angabe (Endewert muss große sein als Anfangswert!.)";
                                countMissing++;
                                lblEnd.ForeColor = Color.Red;
                            }
                        }
                    }







                    //third value
                    if (txtSchrittweite.Text == "")
                    {
                        lblSchritt.Text = "Bitte geben Sie ein SchrittWeite ein!.(z.B wenn Anfangswert ist 0 und Endewert ist 100 , schritteweite könnte 10/25/100 sein)";
                        lblSchritt.ForeColor = Color.Red;
                        countMissing++;
                        lblSchritt.Visible = true;

                    }
                    else
                    {
                        if (!int.TryParse(txtSchrittweite.Text, out n))
                        {
                            lblSchritt.ForeColor = Color.Red;
                            lblSchritt.Text = "Bitte geben sie ein positiv ganze Zahl ein!";
                            lblSchritt.Visible = true;
                            countMissing++;
                        }
                        else if (int.TryParse(txtEndwert.Text, out n) || int.TryParse(txtAnfangwert.Text, out n) || int.TryParse(txtSchrittweite.Text, out n))
                        {
                            int x = Convert.ToInt32(txtAnfangwert.Text);
                            int y = Convert.ToInt32(txtEndwert.Text);
                            int z = Convert.ToInt32(txtSchrittweite.Text);
                            var summe = (x + y) % z;

                            if (summe != 0)

                            {
                                lblSchritt.Visible = true;
                                lblSchritt.Text = "Bitte geben Sie ein gültige schrittweite ein!.(z.B wenn Anfangswert ist 0 und Endewert ist 100 , schrittweite könnte 10/25/100 sein ";
                                lblSchritt.ForeColor = Color.Red; countMissing++;


                            }



                        }


                    }



                }

            }

            else if (ddlAnswerType.Text == "Text")


            {
                frage.Anwortformat = "Text";
                if (MöglicheAntwort1.Text == "")
                {
                    countMissing++;
                    lblMögliche1.Visible = true;
                    lblMögliche1.ForeColor = Color.Red;
                    lblMögliche1.Text = "Bitte geben Sie ein mögliche Antwort ein";
                }
                else
                {

                }
                if (MöglicheAntwort2.Text == "")
                {
                    countMissing++;
                    lblMögliche2.Visible = true;
                    lblMögliche2.ForeColor = Color.Red;
                    lblMögliche2.Text = "Bitte geben Sie ein mögliche Antwort ein"
;
                }


            }
            else
            {
                lblAnswertype.Visible = true;
                lblAnswertype.ForeColor = Color.Red;
                countMissing++;
                lblAnswertype.Text = "Bitte wählen Sie Welche answertyp hat die Frage!";
            }


            if (countMissing == 0)
            {

                db.Frages.Add(frage);
                db.SaveChanges();
                if (frage.Anwortformat == "Skalar")
                {
                    Skalar skalar = new Skalar();
                    skalar.Idfrage = frage.Frageid;
                    skalar.Anfangswert = Convert.ToInt32(txtAnfangwert.Text);
                    skalar.Endwert = Convert.ToInt32(txtEndwert.Text);
                    skalar.Schrittweite = Convert.ToInt32(txtSchrittweite.Text);
                    db.Skalars.Add(skalar);
                    db.SaveChanges();

                }
                if (frage.Anwortformat == "Text")
                {
                    Antwort_Text text = new Antwort_Text();
                    text.Frageid = frage.Frageid;
                    text.möglich_text_antwort1 = MöglicheAntwort1.Text;
                    text.möglich_text_antwort2 = MöglicheAntwort2.Text;
                    text.möglich_text_antwort3 = MöglicheAntwort3.Text;
                    text.möglich_text_antwort4 = MöglicheAntwort4.Text;
                    db.Antwort_Text.Add(text);
                    db.SaveChanges();

                }

            }

        }


        protected void btnNext_Click(object sender, EventArgs e)
        {

            speichern();
            Response.Redirect("NeuInterview2.aspx?interviewid=" + Request.QueryString["InterviewId"]);




        }

        protected void btnDone_Click(object sender, EventArgs e)
        {
            speichern();
            Response.Redirect("Default.aspx");
        }
    }
}
