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
    public partial class DeviceInfoForm : Form
    {
        public DeviceInfoForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            HomePageForm.instance.maker.Text = this.txtBox_maker.Text;
            HomePageForm.instance.modelName.Text = this.txtBox_modelName.Text;
            HomePageForm.instance.serialNum.Text = this.txtBox_serialNum.Text;

            this.Close();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
