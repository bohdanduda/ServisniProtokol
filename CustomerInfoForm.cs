using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokol
{
    public partial class CustomerInfoForm : Form
    {
        public CustomerInfoForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HomePageForm.instance.name.Text = this.txtBox_name.Text;
            HomePageForm.instance.address.Text = this.txtBox_address.Text;
            HomePageForm.instance.postNum.Text = this.txtBox_postNum.Text;
            HomePageForm.instance.id.Text = this.txtBox_id.Text;

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
