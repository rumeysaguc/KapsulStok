using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokTakip
{
    public partial class home_page_form : Form
    {
        public home_page_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_team_form fr1 = new add_team_form();
            fr1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_product_form fr2 = new add_product_form();
            fr2.ShowDialog();
        }
    }
}
