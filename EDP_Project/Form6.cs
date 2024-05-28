using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EDP_Project
{
    public partial class Form6 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form6()
        {
            InitializeComponent();
        }

        private async void get_btn_Click(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void post_btn_Click(object sender, EventArgs e)
        {
            await PostData();
        }

        private async Task GetData()
        {
            try
            {
                var response = await client.GetStringAsync("http://localhost/api/index.php");
                var formattedJson = FormatJson(response);
                richTextBox1.Text = formattedJson;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private async Task PostData()
        {
            try
            {
                // Gather data from text fields
                var newEmployee = new
                {
                    emp_name = name_txt.Text,
                    emp_pos = pos_txt.Text,
                    emp_pay = sal_txt.Text,
                    from_branch = branch_txt.Text,
                    emp_key = key_txt.Text
                };

                var json = JsonConvert.SerializeObject(newEmployee);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost/api/index.php", data);
                var result = await response.Content.ReadAsStringAsync();
                var formattedJson = FormatJson(result);
                richTextBox1.Text = "POST response: " + formattedJson;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private string FormatJson(string json)
        {
            try
            {
                var parsedJson = JToken.Parse(json);
                return parsedJson.ToString(Formatting.Indented);
            }
            catch (JsonReaderException)
            {
                return json; // If response is not a valid JSON, return the original string
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new reg_form();
            this.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
