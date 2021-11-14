using System;
using System.Collections.Generic;
using System.Linq;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void exportExcel(string duongdan, string tentep, DataGridView dgv)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveAs(duongdan + tentep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DangNhap());
         
            Application.Run(new QuanLyTaiKhoan());
        }
    }
}
