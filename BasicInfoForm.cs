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
    public partial class BasicInfoForm : Form
    {
        public BasicInfoForm()
        {
            InitializeComponent();    
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HomePageForm.instance.protocolNum.Text = this.txtBox_protocolNumber.Text;
            HomePageForm.instance.date.Text = this.dateTimePicker.Value.ToString();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
