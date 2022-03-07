using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Countries
{
    /// <summary>
    /// Логика взаимодействия для Europe.xaml
    /// </summary>
    public partial class Europe : System.Windows.Window
    {
        List<Countries> countries = new List<Countries>();
        FileStream stream = new FileStream("EuropeanCountries.xlsx", FileMode.Open);
        static Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
        static Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open("EuropeanCountries.xlsx");
        static Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = (_Worksheet)excelWorkbook.Sheets[1];
        static Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;
        int rowCount = excelRange.Rows.Count;
        int colCount = excelRange.Columns.Count;
        

        public Europe()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++)
            {
                Countries country = new Countries((string)excelRange[rowCount, 0], (string)excelRange[rowCount, 1], (string)excelRange[rowCount, 2], (string)excelRange[rowCount, 3], (string)excelRange[rowCount, 4], (int)excelRange[rowCount, 5], (int)excelRange[rowCount, 6]);
                countries.Add(country);//excelRange[rowCount, 0],
            }
        }
    }
}
