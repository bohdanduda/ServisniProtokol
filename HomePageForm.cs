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
        //datagrid
        public DataGridView dataGrid;

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
            postNum = this.txtBox_postNumber;
            id = this.txtBox_id;
            dataGrid = this.dataGridView_measurement;
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

        private void btn_editCustomerInfo_Click(object sender, EventArgs e)
        {
            CustomerInfoForm customerInfoForm = new();
            customerInfoForm.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MeasureInfoForm measureInfoForm = new();
            measureInfoForm.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MeasureInfoForm measureInfoForm = new();
            measureInfoForm.LoadData(true);
            measureInfoForm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_measurement.SelectedRows)
            {
                dataGridView_measurement.Rows.RemoveAt(row.Index);
            }
        }
    }
}