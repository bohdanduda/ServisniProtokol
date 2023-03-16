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
        public static BasicInfoForm instance;
        public BasicInfoForm()
        {
            InitializeComponent();    
            instance = this;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HomePageForm.instance.txtBox_protocolNum.Text = this.txtBox_protocolNumber.Text;
            HomePageForm.instance.txtBox_date.Text = this.txtBox_dateOfMeasurement.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
