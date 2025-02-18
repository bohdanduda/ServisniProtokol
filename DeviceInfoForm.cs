

using System.Text.RegularExpressions;

namespace ServisniProtokol
{
    public partial class DeviceInfoForm : Form
    {
        private bool isValid = false;

        public DeviceInfoForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.ValidateData(this.txtBox_producer.Text, this.txtBox_modelName.Text, this.txtBox_serialNum.Text);

            if (this.isValid)
            {
                HomePageForm.instance.producer.Text = this.txtBox_producer.Text;
                HomePageForm.instance.modelName.Text = this.txtBox_modelName.Text;
                HomePageForm.instance.serialNum.Text = this.txtBox_serialNum.Text;

                this.Close();
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateData(string producer, string model, string serialNum)
        {
            this.errorProvider1.Clear();

            Regex regex = new("^[a-zA-Z-0-9(). -]+$");

            if (!regex.IsMatch(producer))
            {
                this.errorProvider1.SetError(this.txtBox_producer, "Zadejte validní název výrobce!");
                return;
            }

            regex = new("^[a-zA-Z0-9-]+$");
            if (!regex.IsMatch(model))
            {
                this.errorProvider1.SetError(this.txtBox_modelName, "Zadejte validní číslo modelu!");
                return;
            }
            
            if (!regex.IsMatch(serialNum))
            {
                this.errorProvider1.SetError(this.txtBox_serialNum, "Zadejte validní sériové číslo!");
                return;
            }

            this.isValid = true;
        }
    }
}
