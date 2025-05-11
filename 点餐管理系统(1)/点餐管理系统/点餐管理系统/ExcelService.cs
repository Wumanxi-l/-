using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data;


namespace 点餐管理系统
{
    internal class ExcelService
    {
        /// <summary>
        /// 方法1；DataSet数据集导出到Excel
        /// </summary>
        /// <param name="dgv">DataSet控件</param>
        /// <param name="strTitle">导出的Excel标题</param>
        public void DataGridViewExportToExcel(DataSet ds, string strTitle)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.FileName = strTitle + ".xls";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) //导出时，点击【取消】按钮
            {
                return;
            }
            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            string strHeaderText = "";
            try
            {
                //写标题
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    if (i > 0)
                    {
                        strHeaderText += "\t";
                    }
                    strHeaderText += ds.Tables[0].Columns[i].ToString();
                }
                sw.WriteLine(strHeaderText);
                //写内容
                string strItemValue = "";
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    strItemValue = "";
                    for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            strItemValue += "\t";
                        }
                        strItemValue += ds.Tables[0].Rows[j][k].ToString();
                    }
                    sw.WriteLine(strItemValue); //把dgv的每一行的信息写为sw的每一行
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
        public static void ExportExcel(string fileName, DataGridView myDGV)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp =
                new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook =
                workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet
                = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
            //写入标题
            for (int i = 0; i < myDGV.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < myDGV.Rows.Count; r++)
            {
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
            MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
