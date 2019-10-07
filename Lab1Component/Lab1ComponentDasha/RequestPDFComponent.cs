using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace Lab1ComponentDasha
{
    public partial class RequestPDFComponent : Component
    {
        public RequestPDFComponent()
        {
            InitializeComponent();
        }

        public RequestPDFComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SavePDF()
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "pdf|*.pdf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Test test = new Test("Поставщики и типы их поставляемых изделий", "ФИО поставщиков", "Типы изделий");
                    //из ресрусов получаем шрифт для кирилицы
                    if (!File.Exists("TIMCYR.TTF"))
                    {
                        File.WriteAllBytes("TIMCYR.TTF", Properties.Resources.TIMCYR);
                    }
                    //открываем файл для работы
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate,
                   FileAccess.Write);
                    //создаем документ, задаем границы, связываем документ и поток
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    doc.SetMargins(0.5f, 0.5f, 0.5f, 0.5f);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    BaseFont baseFont = BaseFont.CreateFont("TIMCYR.TTF", BaseFont.IDENTITY_H,
                   BaseFont.NOT_EMBEDDED);
                    //вставляем заголовок
                    var phraseTitle = new Phrase(test.Title,
                    new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
                    iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(phraseTitle)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };
                    doc.Add(paragraph);

                    /*var phrasePeriod = new Phrase("c " + model.DateFrom.Value.ToShortDateString() + " по " + model.DateTo.Value.ToShortDateString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD));
                    paragraph = new iTextSharp.text.Paragraph(phrasePeriod)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };
                    doc.Add(paragraph);
                    */

                    //вставляем таблицу, задаем количество столбцов, и ширину колонок
                    PdfPTable table = new PdfPTable(2)
                    {
                        TotalWidth = 800F
                    };
                    table.SetTotalWidth(new float[] { 160, 140});
                    //вставляем шапку
                    PdfPCell cell = new PdfPCell();
                    var fontForCellBold = new iTextSharp.text.Font(baseFont, 10,
                   iTextSharp.text.Font.BOLD);
                    table.AddCell(new PdfPCell(new Phrase(test.NamePost, fontForCellBold))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });
                    table.AddCell(new PdfPCell(new Phrase(test.NameType, fontForCellBold))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });

                    //заполняем таблицу
                    var listPost = test.GetPost();
                    var listType = test.GetType();
                    Random rnd = new Random();
                    var fontForCells = new iTextSharp.text.Font(baseFont, 10);
                    for (int i = 0; i < listPost.Count; i++)
                    {
                        cell = new PdfPCell(new Phrase(listPost[i], fontForCells));
                        table.AddCell(cell);
                        cell = new PdfPCell(new Phrase(listType[rnd.Next(3)], fontForCells));
                        table.AddCell(cell);
                    }
                    cell = new PdfPCell(new Phrase("", fontForCellBold))
                    {
                        Border = 0
                    };
                    table.AddCell(cell);
                    //вставляем таблицу
                    doc.Add(table);
                    doc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}

