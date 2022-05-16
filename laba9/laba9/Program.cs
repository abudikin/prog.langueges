using System;
using Microsoft.Office.Interop.Excel;
using Excel= Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace laba9
{
    class Program
    {

       

        static void Main(string[] args)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            Excel.Range formatRange;
            formatRange = xlWorkSheet.get_Range("c1");
            formatRange.EntireColumn.ColumnWidth = 25;
            formatRange.EntireRow.RowHeight = 55;
            formatRange.EntireRow.Font.Bold = true;
            formatRange.EntireRow.Font.Size = 32;
            formatRange = xlWorkSheet.get_Range("b3","d3");
            formatRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            formatRange.EntireRow.Font.Bold = true;

            formatRange = xlWorkSheet.get_Range("c4","c6");

            formatRange.Font.Italic = true;
            formatRange = xlWorkSheet.get_Range("b1");
            formatRange.EntireColumn.ColumnWidth = 20;
            formatRange = xlWorkSheet.get_Range("d1");
            formatRange.EntireColumn.ColumnWidth = 30;

            formatRange = xlWorkSheet.get_Range("d4", "d6");
            formatRange.HorizontalAlignment= Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;


            xlWorkSheet.Cells[1, 3] = "Почта";
            


            xlWorkSheet.Cells[3, 2] = "Номер";
            xlWorkSheet.Cells[3, 3] = "Наименование";
            xlWorkSheet.Cells[3, 4] = "Дата отправки";

            xlWorkSheet.Cells[4, 2] = "1290";
            xlWorkSheet.Cells[4, 3] = "посылка";
            xlWorkSheet.Cells[4, 4] = "12.10.2015";

            xlWorkSheet.Cells[5, 2] = "764";
            xlWorkSheet.Cells[5, 3] = "бандероль";
            xlWorkSheet.Cells[5, 4] = "04.11.2012";

            xlWorkSheet.Cells[6, 2] = "6526";
            xlWorkSheet.Cells[6, 3] = "письмо";
            xlWorkSheet.Cells[6, 4] = "05.10.2012";
            

            xlWorkBook.SaveAs("d:\\laba_9.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

        }
    }
}
