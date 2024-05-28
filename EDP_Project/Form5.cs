using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class about_form : Form
    {
        public about_form()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new reg_form();
            this.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
