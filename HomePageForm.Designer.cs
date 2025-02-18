namespace ServisniProtokol
{
    partial class HomePageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_measurement = new Label();
            txtBox_serialNumber = new TextBox();
            txtBox_modelName = new TextBox();
            txtBox_producerName = new TextBox();
            txtBox_id = new TextBox();
            txtBox_postNumber = new TextBox();
            txtBox_address = new TextBox();
            txtBox_name = new TextBox();
            txtBox_dateOfMeasurement = new TextBox();
            txtBox_protocolNumber = new TextBox();
            btn_editDeviceInfo = new Button();
            lbl_serialNumber = new Label();
            lbl_modelName = new Label();
            lbl_producerName = new Label();
            lbl_device = new Label();
            btn_editCustomerInfo = new Button();
            lbl_id = new Label();
            lbl_postNumber = new Label();
            lbl_address = new Label();
            lbl_name = new Label();
            lbl_customer = new Label();
            btn_editBasicInfo = new Button();
            lbl_dateOfMeasurement = new Label();
            lbl_protocolNumber = new Label();
            lbl_basicInfo = new Label();
            dataGridView_measurement = new DataGridView();
            Paremeter = new DataGridViewTextBoxColumn();
            MeasuredValue = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            IsValid = new DataGridViewTextBoxColumn();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_preview = new Button();
            btn_save = new Button();
            btn_load = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_measurement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_measurement
            // 
            lbl_measurement.AutoSize = true;
            lbl_measurement.Location = new Point(73, 399);
            lbl_measurement.Name = "lbl_measurement";
            lbl_measurement.Size = new Size(44, 15);
            lbl_measurement.TabIndex = 50;
            lbl_measurement.Text = "Měření";
            // 
            // txtBox_serialNumber
            // 
            txtBox_serialNumber.Location = new Point(627, 269);
            txtBox_serialNumber.Name = "txtBox_serialNumber";
            txtBox_serialNumber.ReadOnly = true;
            txtBox_serialNumber.Size = new Size(100, 23);
            txtBox_serialNumber.TabIndex = 49;
            txtBox_serialNumber.Text = "?";
            // 
            // txtBox_modelName
            // 
            txtBox_modelName.Location = new Point(627, 240);
            txtBox_modelName.Name = "txtBox_modelName";
            txtBox_modelName.ReadOnly = true;
            txtBox_modelName.Size = new Size(100, 23);
            txtBox_modelName.TabIndex = 48;
            txtBox_modelName.Text = "?";
            // 
            // txtBox_producerName
            // 
            txtBox_producerName.Location = new Point(627, 211);
            txtBox_producerName.Name = "txtBox_producerName";
            txtBox_producerName.ReadOnly = true;
            txtBox_producerName.Size = new Size(100, 23);
            txtBox_producerName.TabIndex = 47;
            txtBox_producerName.Text = "?";
            // 
            // txtBox_id
            // 
            txtBox_id.Location = new Point(216, 295);
            txtBox_id.Name = "txtBox_id";
            txtBox_id.ReadOnly = true;
            txtBox_id.Size = new Size(100, 23);
            txtBox_id.TabIndex = 46;
            txtBox_id.Text = "?";
            // 
            // txtBox_postNumber
            // 
            txtBox_postNumber.Location = new Point(216, 266);
            txtBox_postNumber.Name = "txtBox_postNumber";
            txtBox_postNumber.ReadOnly = true;
            txtBox_postNumber.Size = new Size(100, 23);
            txtBox_postNumber.TabIndex = 45;
            txtBox_postNumber.Text = "?";
            // 
            // txtBox_address
            // 
            txtBox_address.Location = new Point(216, 237);
            txtBox_address.Name = "txtBox_address";
            txtBox_address.ReadOnly = true;
            txtBox_address.Size = new Size(100, 23);
            txtBox_address.TabIndex = 44;
            txtBox_address.Text = "?";
            // 
            // txtBox_name
            // 
            txtBox_name.Location = new Point(216, 208);
            txtBox_name.Name = "txtBox_name";
            txtBox_name.ReadOnly = true;
            txtBox_name.Size = new Size(100, 23);
            txtBox_name.TabIndex = 43;
            txtBox_name.Text = "?";
            // 
            // txtBox_dateOfMeasurement
            // 
            txtBox_dateOfMeasurement.Location = new Point(216, 100);
            txtBox_dateOfMeasurement.Name = "txtBox_dateOfMeasurement";
            txtBox_dateOfMeasurement.ReadOnly = true;
            txtBox_dateOfMeasurement.Size = new Size(100, 23);
            txtBox_dateOfMeasurement.TabIndex = 42;
            txtBox_dateOfMeasurement.Text = "?";
            // 
            // txtBox_protocolNumber
            // 
            txtBox_protocolNumber.Location = new Point(216, 71);
            txtBox_protocolNumber.Name = "txtBox_protocolNumber";
            txtBox_protocolNumber.ReadOnly = true;
            txtBox_protocolNumber.Size = new Size(100, 23);
            txtBox_protocolNumber.TabIndex = 41;
            txtBox_protocolNumber.Text = "?";
            // 
            // btn_editDeviceInfo
            // 
            btn_editDeviceInfo.Location = new Point(652, 315);
            btn_editDeviceInfo.Name = "btn_editDeviceInfo";
            btn_editDeviceInfo.Size = new Size(75, 23);
            btn_editDeviceInfo.TabIndex = 40;
            btn_editDeviceInfo.Text = "Upravit";
            btn_editDeviceInfo.UseVisualStyleBackColor = true;
            btn_editDeviceInfo.Click += btn_editDeviceInfo_Click;
            // 
            // lbl_serialNumber
            // 
            lbl_serialNumber.AutoSize = true;
            lbl_serialNumber.Location = new Point(533, 274);
            lbl_serialNumber.Name = "lbl_serialNumber";
            lbl_serialNumber.Size = new Size(77, 15);
            lbl_serialNumber.TabIndex = 39;
            lbl_serialNumber.Text = "Sériové Číslo:";
            // 
            // lbl_modelName
            // 
            lbl_modelName.AutoSize = true;
            lbl_modelName.Location = new Point(533, 245);
            lbl_modelName.Name = "lbl_modelName";
            lbl_modelName.Size = new Size(44, 15);
            lbl_modelName.TabIndex = 38;
            lbl_modelName.Text = "Model:";
            // 
            // lbl_producerName
            // 
            lbl_producerName.AutoSize = true;
            lbl_producerName.Location = new Point(533, 214);
            lbl_producerName.Name = "lbl_producerName";
            lbl_producerName.Size = new Size(53, 15);
            lbl_producerName.TabIndex = 37;
            lbl_producerName.Text = "Výrobce:";
            // 
            // lbl_device
            // 
            lbl_device.AutoSize = true;
            lbl_device.Location = new Point(515, 178);
            lbl_device.Name = "lbl_device";
            lbl_device.Size = new Size(48, 15);
            lbl_device.TabIndex = 36;
            lbl_device.Text = "Zařízení";
            // 
            // btn_editCustomerInfo
            // 
            btn_editCustomerInfo.Location = new Point(241, 324);
            btn_editCustomerInfo.Name = "btn_editCustomerInfo";
            btn_editCustomerInfo.Size = new Size(75, 23);
            btn_editCustomerInfo.TabIndex = 35;
            btn_editCustomerInfo.Text = "Upravit";
            btn_editCustomerInfo.UseVisualStyleBackColor = true;
            btn_editCustomerInfo.Click += btn_editCustomerInfo_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(91, 297);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(21, 15);
            lbl_id.TabIndex = 34;
            lbl_id.Text = "IČ:";
            // 
            // lbl_postNumber
            // 
            lbl_postNumber.AutoSize = true;
            lbl_postNumber.Location = new Point(91, 268);
            lbl_postNumber.Name = "lbl_postNumber";
            lbl_postNumber.Size = new Size(31, 15);
            lbl_postNumber.TabIndex = 33;
            lbl_postNumber.Text = "PSČ:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(91, 238);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(46, 15);
            lbl_address.TabIndex = 32;
            lbl_address.Text = "Adresa:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(91, 211);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(42, 15);
            lbl_name.TabIndex = 31;
            lbl_name.Text = "Název:";
            // 
            // lbl_customer
            // 
            lbl_customer.AutoSize = true;
            lbl_customer.Location = new Point(73, 178);
            lbl_customer.Name = "lbl_customer";
            lbl_customer.Size = new Size(53, 15);
            lbl_customer.TabIndex = 30;
            lbl_customer.Text = "Zákazník";
            // 
            // btn_editBasicInfo
            // 
            btn_editBasicInfo.Location = new Point(564, 74);
            btn_editBasicInfo.Name = "btn_editBasicInfo";
            btn_editBasicInfo.Size = new Size(101, 46);
            btn_editBasicInfo.TabIndex = 29;
            btn_editBasicInfo.Text = "Upravit";
            btn_editBasicInfo.UseVisualStyleBackColor = true;
            btn_editBasicInfo.Click += btn_editBasicInfo_Click;
            // 
            // lbl_dateOfMeasurement
            // 
            lbl_dateOfMeasurement.AutoSize = true;
            lbl_dateOfMeasurement.Location = new Point(91, 105);
            lbl_dateOfMeasurement.Name = "lbl_dateOfMeasurement";
            lbl_dateOfMeasurement.Size = new Size(86, 15);
            lbl_dateOfMeasurement.TabIndex = 28;
            lbl_dateOfMeasurement.Text = "Datum Měření:";
            // 
            // lbl_protocolNumber
            // 
            lbl_protocolNumber.AutoSize = true;
            lbl_protocolNumber.Location = new Point(91, 74);
            lbl_protocolNumber.Name = "lbl_protocolNumber";
            lbl_protocolNumber.Size = new Size(91, 15);
            lbl_protocolNumber.TabIndex = 27;
            lbl_protocolNumber.Text = "Číslo Protokolu:";
            // 
            // lbl_basicInfo
            // 
            lbl_basicInfo.AutoSize = true;
            lbl_basicInfo.Location = new Point(73, 36);
            lbl_basicInfo.Name = "lbl_basicInfo";
            lbl_basicInfo.Size = new Size(109, 15);
            lbl_basicInfo.TabIndex = 26;
            lbl_basicInfo.Text = "Základní Informace";
            // 
            // dataGridView_measurement
            // 
            dataGridView_measurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_measurement.Columns.AddRange(new DataGridViewColumn[] { Paremeter, MeasuredValue, Value, IsValid });
            dataGridView_measurement.Location = new Point(91, 429);
            dataGridView_measurement.Name = "dataGridView_measurement";
            dataGridView_measurement.Size = new Size(623, 180);
            dataGridView_measurement.TabIndex = 51;
            // 
            // Paremeter
            // 
            Paremeter.HeaderText = "Parametr";
            Paremeter.Name = "Paremeter";
            // 
            // MeasuredValue
            // 
            MeasuredValue.HeaderText = "Naměřená Jednotka";
            MeasuredValue.Name = "MeasuredValue";
            // 
            // Value
            // 
            Value.HeaderText = "Jednotka";
            Value.Name = "Value";
            // 
            // IsValid
            // 
            IsValid.HeaderText = "Vyhovuje";
            IsValid.Name = "IsValid";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(477, 615);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 52;
            btn_add.Text = "Přidat";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(558, 615);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 53;
            btn_edit.Text = "Upravit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(639, 615);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 54;
            btn_delete.Text = "Smazat";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_preview
            // 
            btn_preview.Location = new Point(713, 663);
            btn_preview.Name = "btn_preview";
            btn_preview.Size = new Size(75, 23);
            btn_preview.TabIndex = 55;
            btn_preview.Text = "Náhled";
            btn_preview.UseVisualStyleBackColor = true;
            btn_preview.Click += btn_preview_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(12, 663);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 56;
            btn_save.Text = "Uložit";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(102, 663);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(75, 23);
            btn_load.TabIndex = 57;
            btn_load.Text = "Načíst";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 698);
            Controls.Add(btn_load);
            Controls.Add(btn_save);
            Controls.Add(btn_preview);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(dataGridView_measurement);
            Controls.Add(lbl_measurement);
            Controls.Add(txtBox_serialNumber);
            Controls.Add(txtBox_modelName);
            Controls.Add(txtBox_producerName);
            Controls.Add(txtBox_id);
            Controls.Add(txtBox_postNumber);
            Controls.Add(txtBox_address);
            Controls.Add(txtBox_name);
            Controls.Add(txtBox_dateOfMeasurement);
            Controls.Add(txtBox_protocolNumber);
            Controls.Add(btn_editDeviceInfo);
            Controls.Add(lbl_serialNumber);
            Controls.Add(lbl_modelName);
            Controls.Add(lbl_producerName);
            Controls.Add(lbl_device);
            Controls.Add(btn_editCustomerInfo);
            Controls.Add(lbl_id);
            Controls.Add(lbl_postNumber);
            Controls.Add(lbl_address);
            Controls.Add(lbl_name);
            Controls.Add(lbl_customer);
            Controls.Add(btn_editBasicInfo);
            Controls.Add(lbl_dateOfMeasurement);
            Controls.Add(lbl_protocolNumber);
            Controls.Add(lbl_basicInfo);
            Name = "HomePageForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_measurement).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lbl_measurement;
        private TextBox txtBox_serialNumber;
        private TextBox txtBox_modelName;
        private TextBox txtBox_producerName;
        private TextBox txtBox_id;
        private TextBox txtBox_postNumber;
        private TextBox txtBox_address;
        private TextBox txtBox_name;
        private TextBox txtBox_dateOfMeasurement;
        private TextBox txtBox_protocolNumber;
        private Button btn_editDeviceInfo;
        private Label lbl_serialNumber;
        private Label lbl_modelName;
        private Label lbl_producerName;
        private Label lbl_device;
        private Button btn_editCustomerInfo;
        private Label lbl_id;
        private Label lbl_postNumber;
        private Label lbl_address;
        private Label lbl_name;
        private Label lbl_customer;
        private Button btn_editBasicInfo;
        private Label lbl_dateOfMeasurement;
        private Label lbl_protocolNumber;
        private Label lbl_basicInfo;
        private DataGridView dataGridView_measurement;
        private DataGridViewTextBoxColumn Paremeter;
        private DataGridViewTextBoxColumn MeasuredValue;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn IsValid;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_preview;
        private Button btn_save;
        private Button btn_load;
        private ErrorProvider errorProvider1;
    }
}