namespace ServisniProtokol
{
    public partial class HomePageForm : Form
    {
        private string protocolNumber;
        public static HomePageForm instance;
        public TextBox txtBox_protocolNum;
        public TextBox txtBox_date;

        public HomePageForm()
        {
            InitializeComponent();
            instance = this;
            txtBox_protocolNum = this.txtBox_protocolNumber;
            txtBox_date = this.txtBox_dateOfMeasurement;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_editBasicInfo_Click(object sender, EventArgs e)
        {
            BasicInfoForm basicInfoForm = new();
            basicInfoForm.ShowDialog();
        }
    }
}