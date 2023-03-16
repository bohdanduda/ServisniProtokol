namespace ServisniProtokol
{
    public partial class HomePageForm : Form
    {
        public static HomePageForm instance;
        
        //textboxs for basic info
        public TextBox protocolNum;
        public TextBox date;
        //textboxs for device info
        public TextBox maker;
        public TextBox modelName;
        public TextBox serialNum;
        //textboxs for customer info
        public TextBox name;
        public TextBox address;
        public TextBox postNum;
        public TextBox id;

        public HomePageForm()
        {
            InitializeComponent();
            instance = this;
            protocolNum = this.txtBox_protocolNumber;
            date = this.txtBox_dateOfMeasurement;
            maker = this.txtBox_producerName;
            modelName = this.txtBox_modelName;
            serialNum = this.txtBox_serialNumber;
            name = this.txtBox_name;
            address = this.txtBox_address;
            id = this.txtBox_id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_editBasicInfo_Click(object sender, EventArgs e)
        {
            BasicInfoForm basicInfoForm = new();
            basicInfoForm.ShowDialog();
        }

        private void btn_editDeviceInfo_Click(object sender, EventArgs e)
        {
            DeviceInfoForm deviceInfoForm = new();
            deviceInfoForm.ShowDialog();
        }
    }
}