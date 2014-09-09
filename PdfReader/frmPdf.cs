using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;


namespace PdfReader1
{
    public partial class frmPdf : Form
    {
        public frmPdf()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtMain.Text = ExtractTextFromPdf("joshua.pdf");

        }

        private static string parseUsingPDFBox(string input)
        {
            PDDocument doc = PDDocument.load(input);
            //PDFTextStripper stripper = new PDFTextStripper();

            //return stripper.getText(doc);


            PDFTextStripper stripper = new PDFTextStripper();
            stripper.setStartPage(1);
            stripper.setEndPage(1);
            return stripper.getText(doc);



        }

        public static string ExtractTextFromPdf(string path)
        {

            using (var reader = new PdfReader(path))
            {
                var text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.AppendLine();
                    text.AppendLine();
                    text.AppendLine();
                    text.Append("PAGE " + i);
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    if (i == 1)
                        break;
                }

                return text.ToString();
            }
        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            rtxtMain.Text = parseUsingPDFBox("joshua.pdf");
        }


    }
}
