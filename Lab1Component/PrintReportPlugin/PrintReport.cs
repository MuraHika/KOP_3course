using DataBaseImplementDataBase;
using DataBaseView;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XL = Microsoft.Office.Interop.Excel;
using System.util;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using IronXL;

namespace PrintReportPlugin
{

    [Export(typeof(IPlugin))]
    public class PrintReport : IPlugin
    {
        private DataBaseDbContext context;
        public PrintReport(DataBaseDbContext context)
        {
            this.context = context;
        }
        public string Operation => "Формирование накладной на поставку";

        public void RunPlugin(PluginsView pluginsView)
        {
            string path = "";
            var openFileDialog = new SaveFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName + ".pdf";
                //из ресрусов получаем шрифт для кирилицы
                if (!File.Exists("TIMCYR.TTF"))
                {
                    File.WriteAllBytes("TIMCYR.TTF", Properties.Resources.TIMCYR);
                }
                //открываем файл для работы
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate,
               FileAccess.Write);
                //создаем документ, задаем границы, связываем документ и поток
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                doc.SetMargins(0.5f, 0.5f, 0.5f, 0.5f);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                BaseFont baseFont = BaseFont.CreateFont("TIMCYR.TTF", BaseFont.IDENTITY_H,
               BaseFont.NOT_EMBEDDED);
                //вставляем заголовок
                var phraseTitle = new Phrase("Накладная по поставкам",
                new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
                iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(phraseTitle)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 12
                };
                doc.Add(paragraph);
                var fontForCellBold = new iTextSharp.text.Font(baseFont, 10,
               iTextSharp.text.Font.BOLD);
                //вставляем таблицу, задаем количество столбцов, и ширину колонок
                PdfPTable table = new PdfPTable(4)
                {
                    TotalWidth = 800F
                };
                table.SetTotalWidth(new float[] { 160, 140, 160, 160 });
                //вставляем шапку
                PdfPCell cell = new PdfPCell();
                List<string> title = new List<string> { "N", "Наименование поставщика", "Тип организации", "Дата последней поставки" };
                for (int i = 0; i < title.Count; i++)
                {
                    table.AddCell(new PdfPCell(new Phrase(title[i], fontForCellBold))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });
                }
                for (int i = 0; i < title.Count; i++)
                {
                    table.AddCell(new PdfPCell(new Phrase((i + 1).ToString(), fontForCellBold))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });
                }

                //заполняем таблицу
                var fontForCells = new iTextSharp.text.Font(baseFont, 10);
                foreach (var item in pluginsView.listB)
                {
                    Type t = item.GetType();
                    string[] field = new string[t.GetFields().Length];
                    foreach (var _field in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {

                        var str = _field.GetValue(item);
                        if (str == null)
                        {
                            str = "-";
                        }
                        cell = new PdfPCell(new Phrase(str.ToString(), fontForCells));
                        table.AddCell(cell);

                    }
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
        }

        public override string ToString()
        {
            return Operation;
        }
    }
}
