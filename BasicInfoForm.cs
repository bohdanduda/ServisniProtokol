using System.Text.RegularExpressions;

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
            if (this.ValidateProtocolNum(this.txtBox_protocolNumber.Text))
            {
                HomePageForm.instance.protocolNum.Text = this.txtBox_protocolNumber.Text;
                HomePageForm.instance.date.Text = this.dateTimePicker.Value.Date.ToString("dd.MM.yyyy");
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateProtocolNum(string protocolNum)
        {
            bool isValid = false;
            Regex regex = new("^\\d+$");
            if (!regex.IsMatch(protocolNum))
            {
                this.errorProvider1.SetError(this.txtBox_protocolNumber, "Zadejte validní číslo protokolu!");
                return isValid;
            }

            return isValid = true;
        }
    }
}
