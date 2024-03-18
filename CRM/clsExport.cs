using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using CRM_BussinsLayer;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using IronPdf.Pages;

namespace CRM
{
    public class clsExport
    {

        public static void ExportTabelsAsPDF(DataGridView dataGridView1, string PDFName)
        {


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Pdf File";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = PDFName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // actual code that will create Pdf files


                Document doc = new Document(iTextSharp.text.PageSize.A2, 10, 10, 42, 35);
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                doc.Open();
                PdfContentByte pdfContent = pdfWriter.DirectContent;
                iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);
                //customized border sizes
                rectangle.Left += doc.LeftMargin - 5;
                rectangle.Right -= doc.RightMargin - 5;
                rectangle.Top -= doc.TopMargin - 5;
                rectangle.Bottom += doc.BottomMargin - 5;
                pdfContent.SetColorStroke(BaseColor.WHITE);//setting the color of the border to white
                pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
                pdfContent.Stroke();
                //setting font type, font size and font color
                iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 25, BaseColor.BLACK);
                Paragraph p = new Paragraph();
                p.Alignment = Element.ALIGN_CENTER;//adjust the alignment of the heading
                p.Add(new Chunk(PDFName+"\n\n", headerFont));//adding a heading to the PDF
                doc.Add(p);//adding component to the document
                iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.BLACK);
                //creating pdf table
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(); //create object from the pdfpcell
                    cell.BackgroundColor = BaseColor.WHITE;//set color of cells
                    cell.AddElement(new Chunk(dataGridView1.Columns[j].HeaderText.ToUpper(), font));
                    table.AddCell(cell);
                }
                //adding rows from gridview to table
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    table.WidthPercentage = 100;//set width of the table
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                            table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                    }
                }
                //adding table to document
                doc.Add(table);
                doc.Close();
                MessageBox.Show("You have successfully exported the file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }

        }

        public static void ExportTextAsTXT(string Text,string TextTitle)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Text";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = TextTitle;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                TextWriter txt = new StreamWriter(saveFileDialog1.FileName);
                txt.Write(Text);
                txt.Close();
                MessageBox.Show("Text Saved Successfully!");

            }
        }

        public static void ExportInvoicesAsPDF(string SubjectTitle, clsAdminInvoices Invoice, clsCustomersInvoices CustomerInvoice)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Pdf File";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = SubjectTitle;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                Document doc = new Document(iTextSharp.text.PageSize.A3, 10, 10, 42, 35);
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                doc.Open();
                PdfContentByte pdfContent = pdfWriter.DirectContent;
                iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);
                //customized border sizes
                rectangle.Left += doc.LeftMargin - 5;
                rectangle.Right -= doc.RightMargin - 5;
                rectangle.Top -= doc.TopMargin - 5;
                rectangle.Bottom += doc.BottomMargin - 5;
                pdfContent.SetColorStroke(BaseColor.WHITE);//setting the color of the border to white
                pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
                pdfContent.Stroke();                              
                Paragraph p2 = new Paragraph();
                p2.Alignment = Element.ALIGN_CENTER;
                p2.Add(AdminInvoice(Invoice, CustomerInvoice));
                doc.Add(p2);
                doc.Close();

                MessageBox.Show("You have successfully exported the Invoice.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }


        public static string AdminInvoice(clsAdminInvoices Invoice,clsCustomersInvoices CustomerInvoice)
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine();
            SB.AppendLine();

            SB.AppendLine("__________________________________________________");
            SB.AppendLine($"\t\t\t\tInvoice Total : $ {Invoice.Amount}");
            SB.AppendLine("INVOICE");
            SB.AppendLine($"# {Invoice.InvoiceID}");
            SB.AppendLine();
            SB.AppendLine("Make a Payment to Our Bank Account");
            SB.AppendLine($"Bank Name : {CustomerInvoice.BankAccount.BankName}");
            SB.AppendLine($"Account Name : {CustomerInvoice.BankAccount.Customer.Name}");
            SB.AppendLine($"Account Number : {CustomerInvoice.BankAccount.AccountNumber}");
            SB.AppendLine("__________________________________________________");
            return SB.ToString();
        }



    }
}
