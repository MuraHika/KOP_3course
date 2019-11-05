using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

        public void SavePDF(string path, List<object> tests, List<string> fields, List<string> title, string head)
        {
            try
            {
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
                var phraseTitle = new Phrase(title[0],
                new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
                iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(phraseTitle)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 12
                };
                doc.Add(paragraph);
                var fontForCellBold = new iTextSharp.text.Font(baseFont, 10,
               iTextSharp.text.Font.BOLD);

                if (head.Contains("Строка"))
                {
                    //вставляем таблицу, задаем количество столбцов, и ширину колонок
                    PdfPTable table = new PdfPTable(fields.Count)
                    {
                        TotalWidth = 800F
                    };
                    table.SetTotalWidth(new float[] { 160, 140 });
                    //вставляем шапку
                    PdfPCell cell = new PdfPCell();

                    for (int i = 1; i < title.Count; i++)
                    {
                        table.AddCell(new PdfPCell(new Phrase(title[i], fontForCellBold))
                        {
                            HorizontalAlignment = Element.ALIGN_CENTER
                        });
                    }

                    //заполняем таблицу
                    var fontForCells = new iTextSharp.text.Font(baseFont, 10);
                    foreach (var item in tests)
                    {
                        Type t = item.GetType();
                        string[] field = new string[t.GetFields().Length];
                        foreach (var _field in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                        {
                            if (fields.Contains(new Regex(@"<(.*?)>").Match(_field.Name).Groups[1].Value))
                            {
                                var str = _field.GetValue(item);
                                cell = new PdfPCell(new Phrase(str.ToString(), fontForCells));
                                table.AddCell(cell);
                            }
                        }
                    }
                    cell = new PdfPCell(new Phrase("", fontForCellBold))
                    {
                        Border = 0
                    };
                    table.AddCell(cell);
                    //вставляем таблицу
                    doc.Add(table);
                }
                else if (head.Contains("Столбец"))
                {
                    //вставляем таблицу, задаем количество столбцов, и ширину колонок
                    PdfPTable table = new PdfPTable(tests.Count + 1)
                    {
                        TotalWidth = 800F
                    };
                    float[] width = new float[tests.Count + 1];
                    for (int s = 0; s < width.Length; s++)
                    {
                        width[s] = 50;
                    }
                    table.SetTotalWidth(width);
                    //вставляем шапку
                    PdfPCell cell = new PdfPCell();

                    int j = 0;
                    while (j < title.Count-1)
                    {
                        table.AddCell(new PdfPCell(new Phrase(title[j+1], fontForCellBold))
                        {
                            HorizontalAlignment = Element.ALIGN_CENTER
                        });
                        int i = 0;
                        while (i < tests.Count)
                        {
                            //заполняем таблицу
                            var fontForCells = new iTextSharp.text.Font(baseFont, 10);
                            Type t = tests[i].GetType();
                            string[] field = new string[t.GetFields().Length];
                            var _field = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[j];
                            if (fields.Contains(new Regex(@"<(.*?)>").Match(_field.Name).Groups[1].Value))
                            {
                                var str = _field.GetValue(tests[i]);
                                cell = new PdfPCell(new Phrase(str.ToString(), fontForCells));
                                table.AddCell(cell);
                            }
                            i++;
                        }

                        j++;
                    }
                    //вставляем таблицу
                    doc.Add(table);
                }
                doc.Close();
                MessageBox.Show("Сохранение PDF прошло успешно!", "Отлично", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}

