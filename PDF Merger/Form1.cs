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
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using Aspose.Imaging.Xmp;
using Aspose.Imaging.Xmp.Schemas.DublinCore;
using Aspose.Imaging.Xmp.Schemas.Photoshop;
using GroupDocs.Merger;
using IronPdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;

namespace PDF_Merger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // outStream = new FileOutputStream(fileOut);
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document,  File.Open(@"D:\ptk.pdf", FileMode.Open));
            writer.CloseStream = false;
            document.Open();
            int g = 0;
            foreach (string fileName in Directory.GetFiles(@"C:\AWS\AWS Associate Exam-20221111T045157Z-001\AWS Associate Exam\SAA-C02 SPOT AWS Exam  Solutions Architect - Associate-20220721T124642Z-001\SAA-C02 SPOT AWS Exam  Solutions Architect - Associate"))
            {
                g++;
                if (g == 10)
                    break;
                Image image1 = Image.GetInstance(fileName);
                image1.SetAbsolutePosition(10f, 10f);
                image1.ScaleAbsolute(1200, 800);
                document.Add(image1);
            }
           
            //document.Close();
            writer.CloseStream = true;
            //writer.Flush();
            writer.Close();
            this.Close();
            //string sourceDirectory = @"C:\AWS\AWS Associate Exam-20221111T045157Z-001\AWS Associate Exam\SAA-C02 SPOT AWS Exam  Solutions Architect - Associate-20220721T124642Z-001\SAA-C02 SPOT AWS Exam  Solutions Architect - Associate";
            //string destinationFile = "JpgToPDF.pdf";
            //var imageFiles = Directory.EnumerateFiles(sourceDirectory, "*.png");
            //ImageToPdfConverter.ImageToPdf(imageFiles).SaveAs(destinationFile);
            //int count = 0;
            //foreach (string fileName in Directory.GetFiles(@"C:\AWS\AWS Associate Exam-20221111T045157Z-001\AWS Associate Exam\SAA-C02 SPOT AWS Exam  Solutions Architect - Associate-20220721T124642Z-001\SAA-C02 SPOT AWS Exam  Solutions Architect - Associate"))
            //{
            //    //RasterImage 
            //    // Load JPG image
            //    var image = RasterImage.Load(fileName);

            //    if (count == 0)
            //    {
            //        // Save PDF file
            //        image.Save(@"C:\AWS\PDF\converted.pdf");
            //        count = 1;
            //    }
            //    else
            //    {
            //        // Convert to PDF and save in FileStream
            //        FileStream fs = new FileStream(fileName + ".pdf", FileMode.Create);
            //        image.Save(fs);

            //        // Merge
            //        using (Merger merger = new Merger(@"C:\AWS\PDF\converted.pdf"))
            //        {
            //            merger.Join(fs);
            //            merger.Save(@"C:\AWS\PDF\converted.pdf");
            //        }
            //    }
            //}

        }
    }
}
