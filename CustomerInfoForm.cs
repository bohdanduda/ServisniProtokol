﻿
using System.Text.RegularExpressions;

namespace ServisniProtokol
{
    public partial class CustomerInfoForm : Form
    {
        private bool isValid = false;
        public CustomerInfoForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ValidateData(this.txtBox_name.Text, this.txtBox_address.Text, this.txtBox_postNum.Text, this.txtBox_id.Text);
            if (isValid)
            {
                HomePageForm.instance.name.Text = this.txtBox_name.Text;
                HomePageForm.instance.address.Text = this.txtBox_address.Text;
                HomePageForm.instance.postNum.Text = this.txtBox_postNum.Text;
                HomePageForm.instance.id.Text = this.txtBox_id.Text;

                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateData(string name, string address, string postNum, string pin)
        {
            this.errorProvider1.Clear();

            Regex regex = new("^\\p{Lu}\\p{Ll}+( \\p{Lu}\\p{Ll}+)*$");
            if (!regex.IsMatch(name))
            {
                this.errorProvider1.SetError(this.txtBox_name, "Zadejte validní jméno!");
                return;
            }

            regex = new("^[\\p{L}\\p{N}\\p{Zs}]+$");
            if (!regex.IsMatch(address))
            {
                this.errorProvider1.SetError(this.txtBox_address, "Zadejte validní adresu!");
                return;
            }

            regex = new("\\d{3}[ ]?\\d{2}");
            if (!regex.IsMatch(postNum))
            {
                this.errorProvider1.SetError(this.txtBox_postNum, "Zadejte validní PSČ!");
                return;
            }
            
            regex = new("^[0-9]{8}$");
            if (!regex.IsMatch(pin))
            {
                this.errorProvider1.SetError(this.txtBox_id, "Zadejte validní IČ!");
                return;
            }

            this.isValid = true;
        }
    }
}
