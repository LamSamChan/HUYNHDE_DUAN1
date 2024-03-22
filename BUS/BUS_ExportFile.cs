using Aspose.Cells;
using GemBox.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ExportFile
    {
        private static BUS_ExportFile instance;

        public static BUS_ExportFile Instance
        {
            get { if (instance == null) instance = new BUS_ExportFile(); return BUS_ExportFile.instance; }

            private set { BUS_ExportFile.instance = value; }
        }

        public void ExportFileXLSX_GDTP(string filepath, DataTable dataGrid)
        {
            SaveDataGridViewToCSV(filepath, dataGrid);
            ConvertCSVtoXLSX_GDTP(filepath);
        }

        private void SaveDataGridViewToCSV(string filepath, DataTable dataGrid)
        {
            StreamWriter sw = new StreamWriter(filepath, false);
            for (int i = 0; i < 6; i++)
            {
                sw.Write(sw.NewLine);
            }
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                sw.Write(dataGrid.Columns[i]);
                if (i < dataGrid.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dataGrid.Rows)
            {
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dataGrid.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        private void ConvertCSVtoXLSX_GDTP(string xlsx)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            // Create LoadOptions for CSV file
            Aspose.Cells.LoadOptions loadOptions = new Aspose.Cells.LoadOptions(LoadFormat.CSV);

            // Create a Workbook object and initialize with CSV file's path and the LoadOptions object
            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook($"{xlsx}", loadOptions);

            // Save CSV file as XLSX
            workbook.Save($"{xlsx}", SaveFormat.Xlsx);

            // edit file
            Aspose.Cells.Workbook Edit = new Aspose.Cells.Workbook(xlsx);
            Worksheet editSheet = Edit.Worksheets[0];

            editSheet.Name = "Du Lieu Giao Dich Trai Phieu";
            byte[] imgBytes = File.ReadAllBytes("../../img/huynhde_small.png");
            MemoryStream ms = new MemoryStream();
            ms.Write(imgBytes, 0, imgBytes.Length);

            editSheet.Pictures.Add(0, 0, ms);

            editSheet.Cells.SetRowHeight(6, 50);
            for (int i = 2; i <= 4; i++)
            {
                editSheet.Cells.SetColumnWidth(i, 15);
            }
            for (int i = 5; i <= 12; i++)
            {
                editSheet.Cells.SetColumnWidth(i, 20);
            }

            Cell cellTitle = editSheet.Cells["F2"];
            cellTitle.PutValue("THÔNG TIN GIAO DỊCH CỦA CHỨNG KHOÁN CÁC CHỨNG KHOÁN");
            Aspose.Cells.Style styleTitle = cellTitle.GetStyle();
            styleTitle.HorizontalAlignment = TextAlignmentType.Left;
            styleTitle.VerticalAlignment = TextAlignmentType.Center;
            styleTitle.Font.IsBold = true;
            styleTitle.Font.Size = 14;
            cellTitle.SetStyle(styleTitle);

            DateTime today = DateTime.Today;
            Cell celldate = editSheet.Cells["G4"];
            celldate.PutValue($"Ngày xuất dữ liệu: {today.ToString("dd/MM/yyyy")}");
            Aspose.Cells.Style styleDate = celldate.GetStyle();
            styleDate.HorizontalAlignment = TextAlignmentType.Left;
            styleDate.VerticalAlignment = TextAlignmentType.Center;
            styleDate.Font.Size = 12;
            celldate.SetStyle(styleDate);

            List<char> c = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            for (int i = 0; i < c.Count; i++)
            {
                Cell cell = editSheet.Cells[$"{c[i].ToString()}7"];
                Aspose.Cells.Style style = cell.GetStyle(); 
                style.HorizontalAlignment = TextAlignmentType.Center;
                style.VerticalAlignment = TextAlignmentType.Center;
                style.Font.IsBold = true;
                style.IsTextWrapped = true;

                // Setting the color
                style.Borders[BorderType.TopBorder].Color = Color.Black;
                style.Borders[BorderType.BottomBorder].Color = Color.Black;
                style.Borders[BorderType.LeftBorder].Color = Color.Black;
                style.Borders[BorderType.RightBorder].Color = Color.Black;
                // Setting the line style
                style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thick;
                style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thick;
                style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thick;
                style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thick;

                cell.SetStyle(style);
            }

            int index = 8;
            bool checknull = false;
            while (true)
            {
                for (int i = 0; i < c.Count; i++)
                {
                    Cell celldata = editSheet.Cells[$"{c[i].ToString()}{index}"];
                    switch (celldata.Type)
                    {
                        case Aspose.Cells.CellValueType.IsNull:
                            checknull = true;
                            break;
                    }
                    if (!checknull)
                    {
                        Aspose.Cells.Style style = celldata.GetStyle();
                        // Setting the color
                        style.Borders[BorderType.TopBorder].Color = Color.Black;
                        style.Borders[BorderType.BottomBorder].Color = Color.Black;
                        style.Borders[BorderType.LeftBorder].Color = Color.Black;
                        style.Borders[BorderType.RightBorder].Color = Color.Black;
                        // Setting the line style
                        style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                        style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                        style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                        style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                        celldata.SetStyle(style);
                    }
                    else
                    {
                        break;
                    }
                }

                index++;
                if (checknull == true)
                {
                    break;
                }
            }
            Edit.Worksheets.RemoveAt(1);
            Edit.Save(xlsx);
            var wb = ExcelFile.Load(xlsx);
            wb.Worksheets.Remove(1);
            wb.Save(xlsx);
        }

        public void ExportFilePDF(string pdf, DataTable data, string title)
        {
            FileStream fs = new FileStream(pdf, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            var CurrentDirectory = Directory.GetCurrentDirectory();
            string TextFont = Path.Combine($"{CurrentDirectory}\\Font\\Times New Roman 400.ttf");
            //image
            string imageURL = @"..\..\img\huynhde_small.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageURL);
            img.ScaleToFit(90f, 70f);
            img.Alignment = Element.ALIGN_LEFT;

            //title
            BaseFont bFont = BaseFont.CreateFont(TextFont, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bFont, 16, 1, iTextSharp.text.BaseColor.DARK_GRAY);
            Paragraph paraHead = new Paragraph();
            paraHead.Alignment = Element.ALIGN_CENTER;
            paraHead.Add(new Paragraph("\n"));
            paraHead.Add(new Chunk(title.ToUpper(), font));
            paraHead.Add(new Paragraph("\n"));
            document.Add(img);
            document.Add(paraHead);

            //author
            Paragraph paraAu = new Paragraph();
            BaseFont bfAu = BaseFont.CreateFont(TextFont, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fAu = new iTextSharp.text.Font(bfAu, 8, 2, iTextSharp.text.BaseColor.GRAY);
            paraAu.Alignment = Element.ALIGN_RIGHT;
            paraAu.Add(new Chunk("Người xuất: [HuynhDe]\n", fAu));
            paraAu.Add(new Chunk("Ngày xuất: " + DateTime.Today.ToString("dd/MM/yyyy"), fAu));
            document.Add(paraAu);

            //line
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(line);
            //Add line
            document.Add(new Chunk("\n", font));

            //add datatable
            PdfPTable table = new PdfPTable(data.Columns.Count);
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.TotalWidth = 570f;
            table.LockedWidth = true;
            float[] widths = new float[] { 20f, 20f, 40f, 40f, 50f, 50f, 50f, 50f, 50f, 50f, 50f, 50f, 50f };
            table.SetWidths(widths);
            BaseFont bFontColumnsName = BaseFont.CreateFont(TextFont, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font FontColumnsName = new iTextSharp.text.Font(bFontColumnsName, 7, 1, iTextSharp.text.BaseColor.WHITE);
            iTextSharp.text.Font FontCell = new iTextSharp.text.Font(bFontColumnsName, 5, 1, iTextSharp.text.BaseColor.BLACK);

            //columns
            for (int i = 0; i < data.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(data.Columns[i].ColumnName, FontColumnsName));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            //cells
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.AddElement(new Chunk(data.Rows[i][j].ToString(), FontCell));
                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        public void ExportFileXLSX_GDTP2(string filepath, DataGridView dataGrid, string title, List<char> kytu)
        {
            SaveDataGridViewToCSV2(filepath, dataGrid);
            ConvertCSVtoXLSX_GDTP2(filepath, title, kytu);
        }

        private void SaveDataGridViewToCSV2(string filepath, DataGridView dataGrid)
        {
            StreamWriter sw = new StreamWriter(filepath, false);
            for (int i = 0; i < 6; i++)
            {
                sw.Write(sw.NewLine);
            }
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                sw.Write(dataGrid.Columns[i].HeaderText);
                if (i < dataGrid.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataGridViewRow dr in dataGrid.Rows)
            {
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr.Cells[i].Value.ToString()))
                    {
                        string value = dr.Cells[i].Value.ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr.Cells[i].Value.ToString());
                        }
                    }
                    if (i < dataGrid.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        private void ConvertCSVtoXLSX_GDTP2(string xlsx, string title, List<char> kytu)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            // Create LoadOptions for CSV file
            Aspose.Cells.LoadOptions loadOptions = new Aspose.Cells.LoadOptions(LoadFormat.CSV);

            // Create a Workbook object and initialize with CSV file's path and the LoadOptions object
            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook($"{xlsx}", loadOptions);

            // Save CSV file as XLSX
            workbook.Save($"{xlsx}", SaveFormat.Xlsx);

            // edit file
            Aspose.Cells.Workbook Edit = new Aspose.Cells.Workbook(xlsx);
            Worksheet editSheet = Edit.Worksheets[0];

            editSheet.Name = "Sheet1";
            byte[] imgBytes = File.ReadAllBytes("../../img/huynhde_small.png");
            MemoryStream ms = new MemoryStream();
            ms.Write(imgBytes, 0, imgBytes.Length);

            editSheet.Pictures.Add(0, 0, ms);

            editSheet.Cells.SetRowHeight(6, 50);
            for (int i = 2; i <= 4; i++)
            {
                editSheet.Cells.SetColumnWidth(i, 15);
            }
            for (int i = 5; i <= 12; i++)
            {
                editSheet.Cells.SetColumnWidth(i, 20);
            }

            Cell cellTitle = editSheet.Cells["F2"];
            cellTitle.PutValue(title);
            Aspose.Cells.Style styleTitle = cellTitle.GetStyle();
            styleTitle.HorizontalAlignment = TextAlignmentType.Left;
            styleTitle.VerticalAlignment = TextAlignmentType.Center;
            styleTitle.Font.IsBold = true;
            styleTitle.Font.Size = 14;
            cellTitle.SetStyle(styleTitle);

            DateTime today = DateTime.Today;
            Cell celldate = editSheet.Cells["G4"];
            celldate.PutValue($"Ngày xuất dữ liệu: {today.ToString("dd/MM/yyyy")}");
            Aspose.Cells.Style styleDate = celldate.GetStyle();
            styleDate.HorizontalAlignment = TextAlignmentType.Left;
            styleDate.VerticalAlignment = TextAlignmentType.Center;
            styleDate.Font.Size = 12;
            celldate.SetStyle(styleDate);

            List<char> c = kytu; //new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            for (int i = 0; i < c.Count; i++)
            {
                Cell cell = editSheet.Cells[$"{c[i].ToString()}7"];
                Aspose.Cells.Style style = cell.GetStyle();
                style.HorizontalAlignment = TextAlignmentType.Center;
                style.VerticalAlignment = TextAlignmentType.Center;
                style.Font.IsBold = true;
                style.IsTextWrapped = true;

                // Setting the color
                style.Borders[BorderType.TopBorder].Color = Color.Black;
                style.Borders[BorderType.BottomBorder].Color = Color.Black;
                style.Borders[BorderType.LeftBorder].Color = Color.Black;
                style.Borders[BorderType.RightBorder].Color = Color.Black;
                // Setting the line style
                style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thick;
                style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thick;
                style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thick;
                style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thick;

                cell.SetStyle(style);
            }

            int index = 8;
            bool checknull = false;
            while (true)
            {
                for (int i = 0; i < c.Count; i++)
                {
                    Cell celldata = editSheet.Cells[$"{c[i].ToString()}{index}"];
                    switch (celldata.Type)
                    {
                        case Aspose.Cells.CellValueType.IsNull:
                            checknull = true;
                            break;
                    }
                    if (!checknull)
                    {
                        Aspose.Cells.Style style = celldata.GetStyle();
                        // Setting the color
                        style.Borders[BorderType.TopBorder].Color = Color.Black;
                        style.Borders[BorderType.BottomBorder].Color = Color.Black;
                        style.Borders[BorderType.LeftBorder].Color = Color.Black;
                        style.Borders[BorderType.RightBorder].Color = Color.Black;
                        // Setting the line style
                        style.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
                        style.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                        style.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                        style.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                        celldata.SetStyle(style);
                    }
                    else
                    {
                        break;
                    }
                }

                index++;
                if (checknull == true)
                {
                    break;
                }
            }
            Edit.Worksheets.RemoveAt(1);
            Edit.Save(xlsx);
            var wb = ExcelFile.Load(xlsx);
            wb.Worksheets.Remove(1);
            wb.Save(xlsx);
        }

        public void ExportFilePDF2(string pdf, DataGridView data, string title, float[] Wight)
        {
            FileStream fs = new FileStream(pdf, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            var CurrentDirectory = Directory.GetCurrentDirectory();
            string TextFont = Path.Combine($"{CurrentDirectory}\\Font\\Times New Roman 400.ttf");
            //image
            string imageURL = @"..\..\img\huynhde_small.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageURL);
            img.ScaleToFit(90f, 70f);
            img.Alignment = Element.ALIGN_LEFT;

            //title
            BaseFont bFont = BaseFont.CreateFont(TextFont, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bFont, 16, 1, iTextSharp.text.BaseColor.DARK_GRAY);
            Paragraph paraHead = new Paragraph();
            paraHead.Alignment = Element.ALIGN_CENTER;
            paraHead.Add(new Paragraph("\n"));
            paraHead.Add(new Chunk(title.ToUpper(), font));
            paraHead.Add(new Paragraph("\n"));
            document.Add(img);
            document.Add(paraHead);

            //author
            Paragraph paraAu = new Paragraph();
            BaseFont bfAu = BaseFont.CreateFont(TextFont, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fAu = new iTextSharp.text.Font(bfAu, 8, 2, iTextSharp.text.BaseColor.GRAY);
            paraAu.Alignment = Element.ALIGN_RIGHT;
            paraAu.Add(new Chunk("Người xuất: [HuynhDe]\n", fAu));
            paraAu.Add(new Chunk("Ngày xuất: " + DateTime.Today.ToString("dd/MM/yyyy"), fAu));
            document.Add(paraAu);

            //line
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(line);
            //Add line
            document.Add(new Chunk("\n", font));

            //add datatable
            PdfPTable table = new PdfPTable(data.Columns.Count);
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.TotalWidth = 750f;
            table.LockedWidth = true;

            table.SetWidths(Wight);
            BaseFont bFontColumnsName = BaseFont.CreateFont(TextFont, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font FontColumnsName = new iTextSharp.text.Font(bFontColumnsName, 7, 1, iTextSharp.text.BaseColor.WHITE);
            iTextSharp.text.Font FontCell = new iTextSharp.text.Font(bFontColumnsName, 5, 1, iTextSharp.text.BaseColor.BLACK);

            //columns
            for (int i = 0; i < data.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(data.Columns[i].HeaderText, FontColumnsName));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            //cells
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.AddElement(new Chunk(data.Rows[i].Cells[j].Value.ToString(), FontCell));
                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}