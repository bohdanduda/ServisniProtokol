namespace ServisniProtokol
{
    public partial class HomePageForm : Form
    {
        public static HomePageForm instance;

        //textboxs for basic info
        public TextBox protocolNum;
        public TextBox date;
        //textboxs for device info
        public TextBox producer;
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
            producer = this.txtBox_producerName;
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
        private void btn_addBasicInfo_Click(object sender, EventArgs e)
        {
            BasicInfoForm basicInfoForm = new();
            basicInfoForm.ShowDialog();
        }

        private void btn_editBasicInfo_Click(object sender, EventArgs e)
        {
            if (this.txtBox_protocolNumber.Text == "?")
            {
                MessageBox.Show("Nejprve vyplòte data, abyste je mohli upravovat.");
                return;
            }

            BasicInfoForm basicInfoForm = new();
            basicInfoForm.LoadData(true);
            basicInfoForm.ShowDialog();
        }

        private void button_addDeviceInfo_Click(object sender, EventArgs e)
        {
            DeviceInfoForm deviceInfoForm = new();
            deviceInfoForm.ShowDialog();
        }

        private void btn_editDeviceInfo_Click(object sender, EventArgs e)
        {
            if (this.txtBox_producerName.Text == "?")
            {
                MessageBox.Show("Nejprve vyplòte data, abyste je mohli upravovat.");
                return;
            }

            DeviceInfoForm deviceInfoForm = new();
            deviceInfoForm.LoadData(true);
            deviceInfoForm.ShowDialog();
        }

        private void btn_addCustomerInfo_Click(object sender, EventArgs e)
        {
            CustomerInfoForm customerInfoForm = new();
            customerInfoForm.ShowDialog();
        }

        private void btn_editCustomerInfo_Click(object sender, EventArgs e)
        {
            if (this.txtBox_name.Text == "?")
            {
                MessageBox.Show("Nejprve vyplòte data, abyste je mohli upravovat.");
                return;
            }

            CustomerInfoForm customerInfoForm = new();
            customerInfoForm.LoadData(true);
            customerInfoForm.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MeasureInfoForm measureInfoForm = new();
            measureInfoForm.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_measurement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nejprve vyberte øádek, který chcete upravit.");
                return;
            }

            if (this.dataGridView_measurement.SelectedRows.Count > 1)
            {
                MessageBox.Show("Mùžete upravit pouze jeden øádek najednou.");
                return;
            }

            DataGridViewRow selectedRow = this.dataGridView_measurement.SelectedRows[0];
            if (selectedRow.Cells.Cast<DataGridViewCell>().All(cell => cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())))
            {
                MessageBox.Show("Nemùžete upravit neexistující data.");
                return;
            }

            MeasureInfoForm measureInfoForm = new();
            measureInfoForm.LoadData(true);
            measureInfoForm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_measurement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nejprve vyberte øádek, který chcete odstranit.");
                return;
            }

            if (this.dataGridView_measurement.SelectedRows.Count > 1)
            {
                MessageBox.Show("Mùžete odstranit pouze jeden øádek najednou.");
                return;
            }

            DataGridViewRow selectedRow = this.dataGridView_measurement.SelectedRows[0];
            if (selectedRow.Cells.Cast<DataGridViewCell>().All(cell => cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())))
            {
                MessageBox.Show("Nemùžete odstranit prázdný øádek.");
                return;
            }

            foreach (DataGridViewRow row in dataGridView_measurement.SelectedRows)
            {
                dataGridView_measurement.Rows.RemoveAt(row.Index);
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            PreviewForm previewForm = new();
            previewForm.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new();
            folderBrowser.ShowDialog();
            StreamWriter streamWriter = new StreamWriter($"{folderBrowser.SelectedPath}\\protocol.txt");

            streamWriter.WriteLine(txtBox_protocolNumber.Text);
            streamWriter.WriteLine(txtBox_dateOfMeasurement.Text);
            streamWriter.WriteLine(txtBox_name.Text);
            streamWriter.WriteLine(txtBox_address.Text);
            streamWriter.WriteLine(txtBox_postNumber.Text);
            streamWriter.WriteLine(txtBox_id.Text);
            streamWriter.WriteLine(txtBox_producerName.Text);
            streamWriter.WriteLine(txtBox_modelName.Text);
            streamWriter.WriteLine(txtBox_serialNumber.Text);

            streamWriter.Close();
            MessageBox.Show("Protokol Uložen!");
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.ShowDialog();
            StreamReader streamReader = new(fileDialog.FileName);
            List<string> data = new();

            //for (int i = 0; i < 9; i++)
            //{
            //    data.Add(streamReader.ReadLine());
            //}

            while (!streamReader.EndOfStream)
            {
                data.Add(streamReader.ReadLine());
            }

            this.txtBox_protocolNumber.Text = data[0];
            this.txtBox_dateOfMeasurement.Text = data[1];
            this.txtBox_name.Text = data[2];
            this.txtBox_address.Text = data[3];
            this.txtBox_postNumber.Text = data[4];
            this.txtBox_id.Text = data[5];
            this.txtBox_producerName.Text = data[6];
            this.txtBox_modelName.Text = data[7];
            this.txtBox_serialNumber.Text = data[8];

            MessageBox.Show("Protokol Naèten!");
        }



        private void btn_help_Click(object sender, EventArgs e)
        {

        }
    }
}