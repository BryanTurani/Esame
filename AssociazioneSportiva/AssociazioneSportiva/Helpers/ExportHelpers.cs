using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Helpers
{
    public class ExportHelpers
    {
        public static string ExcelContentType
        {
            get
            {
                return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            }
        }

        public static ExcelPackage ToExcel<T>(IEnumerable<T> data, string filename)
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");
            workSheet.Cells[1, 1].LoadFromCollection(data, true);

            var columnCount = typeof(T).GetProperties().Length;

            using (ExcelRange r = workSheet.Cells[1, 1, 1, columnCount])
            {
                r.Style.Font.Color.SetColor(System.Drawing.Color.White);
                r.Style.Font.Bold = true;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#1fb5ad"));
            }

            for (int i = columnCount; i > 0; i--)
            {
                workSheet.Column(i).AutoFit();
            }
            return excel;
        }
    }
}
