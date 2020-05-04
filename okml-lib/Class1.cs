using System;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace okml_lib
{
    public class Class1
    {
        /// <summary>
        /// https://qiita.com/naverut/items/74eb2476b825382a13c8
        /// </summary>
        public void CreateSamplePdf()
        {
            //Initialize PDF writer
            PdfWriter writer = new PdfWriter(new FileInfo("HelloWorldJp.pdf"));
            
            // 平成角ゴシック
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            //Initialize PDF document
            PdfDocument pdf = new PdfDocument(writer);

            // Initialize document
            using (Document document = new Document(pdf))
            {
                //Add paragraph to the document
                document.Add(new Paragraph("Hello, world!").SetFont(font));
            }
        }
    }
}
