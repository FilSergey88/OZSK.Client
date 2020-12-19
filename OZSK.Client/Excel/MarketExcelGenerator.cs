using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using OZSK.Client.Model;

namespace OZSK.Client.Excel
{
    public class MarketExcelGenerator
    {
        public byte[] Generate(DTOTN report)
        {
            var package = new ExcelPackage();

            var sheet = package.Workbook.Worksheets
                .Add("Market Report");

            sheet.Cells["B2"].Value = "Company:";
            sheet.Cells["B3"].Value = "Location:";
            

            var capitalizationChart = sheet.Drawings.AddChart("FindingsChart", OfficeOpenXml.Drawing.Chart.eChartType.Line);
            capitalizationChart.Title.Text = "Capitalization";
            capitalizationChart.SetPosition(7, 0, 5, 0);
            capitalizationChart.SetSize(800, 400);
            

            sheet.Protection.IsProtected = true;
            return package.GetAsByteArray();
        }
    }
}
