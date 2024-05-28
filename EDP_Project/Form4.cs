using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace EDP_Project
{
    public partial class reports_form : Form
    {
        private static string connectionString = "server=localhost;database=database_edp;uid=root;pwd=1052";
        MySqlConnection conn = new MySqlConnection(connectionString);
        public reports_form()
        {
            InitializeComponent();
        }

        public bool Connect_DB()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool Close_DB()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private DataTable GetDataFromDatabase(string selectedTable)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {selectedTable};";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from the database: " + ex.Message);
            }

            return dataTable;
        }

        private void UpdateReportListView(DataTable data)
        {
            report_list_view.Rows.Clear();
            report_list_view.Columns.Clear();

            foreach (DataColumn column in data.Columns)
            {
                report_list_view.Columns.Add(column.ColumnName, column.ColumnName);
            }

            foreach (DataRow row in data.Rows)
            {
                List<string> cellValues = new List<string>();
                foreach (object item in row.ItemArray)
                {
                    cellValues.Add(item.ToString());
                }
                report_list_view.Rows.Add(cellValues.ToArray());
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new reg_form();
            this.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void item_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = item_combo_box.SelectedItem.ToString();

            DataTable tableData = GetDataFromDatabase(selectedTable);

            UpdateReportListView(tableData);
        }
        private void ExportToExcel(DataGridView dataGridView, string templatePath, string exportPath)
        {
            File.Copy(templatePath, exportPath, true);

            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!");
                return;
            }

            excelApp.Visible = false;

            Excel.Workbook workbook = excelApp.Workbooks.Open(exportPath);
            Excel.Worksheet worksheet = workbook.Worksheets[1];

            int startRow = 13;
            int startColumn = 2;
            for (int col = 0; col < dataGridView.Columns.Count; col++)
            {
                worksheet.Cells[startRow - 1, startColumn + col] = dataGridView.Columns[col].HeaderText;
            }

            startRow = 13;
            for (int row = 0; row < dataGridView.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cells[startRow + row, startColumn + col] = dataGridView.Rows[row].Cells[col].Value?.ToString();
                }
            }

            workbook.Save();
            workbook.Close();
            excelApp.Quit();

            MessageBox.Show($"Data exported to {exportPath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string templatePath = Application.StartupPath + @"\reportTemplate\report.xlsx";
                ExportToExcel(report_list_view, templatePath, saveFileDialog.FileName);
            }
        }
    }
}
