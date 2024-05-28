using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace EDP_Project
{
    public partial class reg_form : Form
    {
        private static string connectionString = "server=localhost;database=database_edp;uid=root;pwd=1052";
        private string query = "SELECT prod_name, prod_price FROM products;";
        MySqlConnection conn = new MySqlConnection(connectionString);

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
        private void itemchoice_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row is selected
            {
                DataGridViewRow selectedRow = itemchoice_list.Rows[e.RowIndex];
                string selectedProductName = selectedRow.Cells["prod_name"].Value.ToString(); // Assuming prod_name is the column name in itemchoice_list

                // Query the database to get the details of the selected product
                string selectedProductQuery = "SELECT * FROM products WHERE prod_name = @prod_name;";
                MySqlCommand cmd = new MySqlCommand(selectedProductQuery, conn);
                cmd.Parameters.AddWithValue("@prod_name", selectedProductName);

                try
                {
                    if (Connect_DB())
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Create a new row for item_list_view and populate it with data from the database
                                DataGridViewRow newRow = (DataGridViewRow)item_list_view.Rows[0].Clone();
                                newRow.Cells[0].Value = reader["prod_id"].ToString(); // Assuming prod_name is the column name in the database
                                newRow.Cells[1].Value = reader["prod_name"].ToString(); // Assuming prod_price is the column name in the database
                                newRow.Cells[2].Value = reader["prod_price"].ToString(); // Assuming prod_description is the column name in the database

                                item_list_view.Rows.Add(newRow); // Add the new row to item_list_view
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error retrieving product details from the database.");
                }
                finally
                {
                    Close_DB();
                }
            }
        }

        private void ExportDataGridViewToExcelTemplate(DataGridView dgv, string templatePath, string newfilepath)
        {
            var excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!");
                return;
            }

            excelApp.Visible = false;
            Excel.Workbook workbook = excelApp.Workbooks.Open(templatePath);
            Excel.Worksheet worksheet = workbook.Worksheets[1] as Excel.Worksheet;
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                worksheet.Cells[3, col + 1] = dgv.Columns[col].HeaderText;
            }
            int rowIndex = 4;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        worksheet.Cells[rowIndex, col + 1] = row.Cells[col].Value.ToString();
                    }
                    rowIndex++;
                }
            }

            worksheet.Cells[rowIndex + 1, 1] = "Total:";
            worksheet.Cells[rowIndex + 1, 2] = total_text.Text;
            worksheet.Cells[rowIndex + 2, 1] = "Cash:";
            worksheet.Cells[rowIndex + 2, 2] = cash_text.Text;
            worksheet.Cells[rowIndex + 3, 1] = "Change:";
            worksheet.Cells[rowIndex + 3, 2] = change_text.Text;

            MessageBox.Show($"Data exported to {newfilepath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            excelApp.Visible = true;

            workbook.SaveAs(newfilepath);
            workbook.PrintPreview();
        }



        public reg_form()
        {
            InitializeComponent();
            itemchoice_list.CellDoubleClick += itemchoice_list_CellDoubleClick;
        }

        public double Cost_Of_Items()
        {
            Double sum = 0;
            int i = 0;
            for (i = 0; i < (item_list_view.Rows.Count); i++)
            {
                sum = sum + Convert.ToDouble(item_list_view.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private void AddCost()
        {
            Double tax, q;
            tax = 0.12;
            if ((item_list_view.Rows.Count) > 0)
            {
                tax_text.Text = String.Format("{0:c}", (((Cost_Of_Items() * tax) / 100)));
                subtotal_text.Text = String.Format("{0:c}", (Cost_Of_Items()));
                q = ((Cost_Of_Items() * tax) / 100);
                total_text.Text = String.Format("{0:c}", (Cost_Of_Items() + q));
            }
        }

        private void Change()
        {
            Double tax, q, c;
            tax = 0.12;
            if ((item_list_view.Rows.Count) > 0)
            {
                q = ((Cost_Of_Items() * tax) / 100) + Cost_Of_Items();
                c = Convert.ToDouble(cash_text.Text);
                change_text.Text = String.Format("{0:c}", c - q);
            }
        }


        private void reports_link_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new reports_form();
            this.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void about_link_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new about_form();
            this.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            try
            {
                cash_text.Text = "0";
                change_text.Text = "0";
                subtotal_text.Text = "0";
                total_text.Text = "0";
                tax_text.Text = "0";
                total_text.Text = "0";
                item_list_view.Rows.Clear();
                item_list_view.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (cash_text.Text == "0")
            {
                cash_text.Text = "";
                cash_text.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (!cash_text.Text.Contains("."))
                {
                    cash_text.Text += b.Text;
                }
            }
            else
                cash_text.Text += b.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            cash_text.Text = "0";
        }

        private void InsertTransactionData(DateTime transactionDateTime, string total, string cash, string change)
        {
            string insertQuery = "INSERT INTO transaction_table (transaction_datetime, total, cash, `change`) VALUES (@transactionDateTime, @total, @cash, @change);";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
            {
            cmd.Parameters.AddWithValue("@transactionDateTime", transactionDateTime);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@cash", cash);
            cmd.Parameters.AddWithValue("@change", change);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Transaction data inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to insert transaction data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting transaction data: " + ex.Message);
            }
        }
    }
}


        private void pay_btn_Click(object sender, EventArgs e)
        {
            AddCost();
            Change();
            DateTime transactionDateTime = DateTime.Now;

            string total = total_text.Text;
            string cash = cash_text.Text;
            string change = change_text.Text;
            InsertTransactionData(transactionDateTime, total, cash, change);
        }


        private void remove_btn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.item_list_view.SelectedRows)
            {
                item_list_view.Rows.Remove(row);
            }
            AddCost();
            Change();
        }

        private void reg_form_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            itemchoice_list.DataSource = GetItemsList();
        }
        private DataTable GetItemsList()
        {
            DataTable dt = new DataTable();
            if(Connect_DB())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            Close_DB();
            return dt;
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            string templatePath = Application.StartupPath + @"\reportTemplate\receipt.xlsx";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "receipt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newFilePath = saveFileDialog.FileName;

                ExportDataGridViewToExcelTemplate(item_list_view, templatePath, newFilePath);
            }
        }

        private void aPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form6();
            this.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
