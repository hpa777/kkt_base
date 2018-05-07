using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2
{
    class ExcelHelper: IDisposable
    {
        private Excel.Application excelapp;

        private Excel.Workbook excelappworkbook;

        private Excel.Sheets excelsheets;
        

        public ExcelHelper(string fileName)
        {
            fileName = Path.Combine(System.Windows.Forms.Application.StartupPath, fileName);
            excelapp = new Excel.Application();
            excelapp.Visible = false;            
            excelappworkbook = excelapp.Workbooks.Open(fileName
                , Type.Missing, Type.Missing, Type.Missing, Type.Missing
                , Type.Missing, Type.Missing, Type.Missing, Type.Missing
                , Type.Missing, Type.Missing, Type.Missing, Type.Missing
                , Type.Missing, Type.Missing);
            excelsheets = excelappworkbook.Worksheets;        
        }

        public void Dispose()
        {
            excelapp.Quit();
            Marshal.ReleaseComObject(excelsheets);
            Marshal.ReleaseComObject(excelappworkbook);
            Marshal.ReleaseComObject(excelapp);
        }

        private Excel.Worksheet excelworksheet;

        public void saveDoc(string fileName)
        {
            excelapp.DisplayAlerts = false;
          //  excelappworkbook.Saved = true;
          //  excelappworkbook.Activate();
            excelappworkbook.SaveAs(fileName, Excel.XlFileFormat.xlOpenXMLWorkbook,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        public void setActiveSheet(int idx) {
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(idx);
        }

        public void writeString(String[] rows, String value, bool lineBreak = false) {
            if (String.IsNullOrEmpty(value))
            {
                return;
            }
            int rowLength = writeRow(rows[0]);

            int startRow = 0, endRow = rowLength;
            foreach (string row in rows)
            {
                if (endRow >= value.Length)
                {
                    writeRow(row, value.Substring(startRow));
                    break;
                }
                else
                {
                    if (lineBreak)
                    {
                        while (!Char.IsWhiteSpace(value, endRow) && endRow != 1)
                        {
                            endRow--;
                        }
                    }
                    writeRow(row, value.Substring(startRow, endRow - startRow));
                    startRow = lineBreak ? endRow + 1 : endRow;
                    endRow += rowLength;
                }
            }
            
        }        

        private int writeRow(String row, String value = null)
        {
            Excel.Range excelcells = excelworksheet.get_Range(row);
            int count = 0, prev_row = 0, prev_col = 0;            
            foreach (Excel.Range cell in excelcells.Cells)
            {
                if ((Boolean)cell.MergeCells == true)
                {
                    if (prev_row == 0 || prev_col == 0 || prev_row != (int)cell.MergeArea.Row || prev_col != (int)cell.MergeArea.Column)
                    {
                        prev_row = (int)cell.MergeArea.Row;
                        prev_col = (int)cell.MergeArea.Column;
                        if (value != null)
                        {
                            cell.Value2 = value[count].ToString();
                            if (value.Length == count + 1)
                            {
                                count++;
                                break;
                            }
                        }
                        count++;
                    }
                }
            }
            return count;
        }

        
    }
}
