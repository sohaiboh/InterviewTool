using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace InterviewTool.Code
{
    public class PDF
    {

        public static void SaveToPDF(string fileName, string text)
        {
            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);

                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                document.Open();

                document.Add(new Paragraph(text));


                document.Close();
                writer.Close();
                fs.Close();
            }
        }
    }
}