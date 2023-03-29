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
            this.lbl_measurement = new System.Windows.Forms.Label();
            this.txtBox_serialNumber = new System.Windows.Forms.TextBox();
            this.txtBox_modelName = new System.Windows.Forms.TextBox();
            this.txtBox_producerName = new System.Windows.Forms.TextBox();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.txtBox_postNumber = new System.Windows.Forms.TextBox();
            this.txtBox_address = new System.Windows.Forms.TextBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.txtBox_dateOfMeasurement = new System.Windows.Forms.TextBox();
            this.txtBox_protocolNumber = new System.Windows.Forms.TextBox();
            this.btn_editDeviceInfo = new System.Windows.Forms.Button();
            this.lbl_serialNumber = new System.Windows.Forms.Label();
            this.lbl_modelName = new System.Windows.Forms.Label();
            this.lbl_producerName = new System.Windows.Forms.Label();
            this.lbl_device = new System.Windows.Forms.Label();
            this.btn_editCustomerInfo = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_postNumber = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.btn_editBasicInfo = new System.Windows.Forms.Button();
            this.lbl_dateOfMeasurement = new System.Windows.Forms.Label();
            this.lbl_protocolNumber = new System.Windows.Forms.Label();
            this.lbl_basicInfo = new System.Windows.Forms.Label();
            this.dataGridView_measurement = new System.Windows.Forms.DataGridView();
            this.Paremeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuredValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_measurement)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_measurement
            // 
            this.lbl_measurement.AutoSize = true;
            this.lbl_measurement.Location = new System.Drawing.Point(73, 399);
            this.lbl_measurement.Name = "lbl_measurement";
            this.lbl_measurement.Size = new System.Drawing.Size(44, 15);
            this.lbl_measurement.TabIndex = 50;
            this.lbl_measurement.Text = "Měření";
            // 
            // txtBox_serialNumber
            // 
            this.txtBox_serialNumber.Location = new System.Drawing.Point(627, 269);
            this.txtBox_serialNumber.Name = "txtBox_serialNumber";
            this.txtBox_serialNumber.ReadOnly = true;
            this.txtBox_serialNumber.Size = new System.Drawing.Size(100, 23);
            this.txtBox_serialNumber.TabIndex = 49;
            this.txtBox_serialNumber.Text = "?";
            // 
            // txtBox_modelName
            // 
            this.txtBox_modelName.Location = new System.Drawing.Point(627, 240);
            this.txtBox_modelName.Name = "txtBox_modelName";
            this.txtBox_modelName.ReadOnly = true;
            this.txtBox_modelName.Size = new System.Drawing.Size(100, 23);
            this.txtBox_modelName.TabIndex = 48;
            this.txtBox_modelName.Text = "?";
            // 
            // txtBox_producerName
            // 
            this.txtBox_producerName.Location = new System.Drawing.Point(627, 211);
            this.txtBox_producerName.Name = "txtBox_producerName";
            this.txtBox_producerName.ReadOnly = true;
            this.txtBox_producerName.Size = new System.Drawing.Size(100, 23);
            this.txtBox_producerName.TabIndex = 47;
            this.txtBox_producerName.Text = "?";
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(216, 295);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.ReadOnly = true;
            this.txtBox_id.Size = new System.Drawing.Size(100, 23);
            this.txtBox_id.TabIndex = 46;
            this.txtBox_id.Text = "?";
            // 
            // txtBox_postNumber
            // 
            this.txtBox_postNumber.Location = new System.Drawing.Point(216, 266);
            this.txtBox_postNumber.Name = "txtBox_postNumber";
            this.txtBox_postNumber.ReadOnly = true;
            this.txtBox_postNumber.Size = new System.Drawing.Size(100, 23);
            this.txtBox_postNumber.TabIndex = 45;
            this.txtBox_postNumber.Text = "?";
            // 
            // txtBox_address
            // 
            this.txtBox_address.Location = new System.Drawing.Point(216, 237);
            this.txtBox_address.Name = "txtBox_address";
            this.txtBox_address.ReadOnly = true;
            this.txtBox_address.Size = new System.Drawing.Size(100, 23);
            this.txtBox_address.TabIndex = 44;
            this.txtBox_address.Text = "?";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(216, 208);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.ReadOnly = true;
            this.txtBox_name.Size = new System.Drawing.Size(100, 23);
            this.txtBox_name.TabIndex = 43;
            this.txtBox_name.Text = "?";
            // 
            // txtBox_dateOfMeasurement
            // 
            this.txtBox_dateOfMeasurement.Location = new System.Drawing.Point(216, 100);
            this.txtBox_dateOfMeasurement.Name = "txtBox_dateOfMeasurement";
            this.txtBox_dateOfMeasurement.ReadOnly = true;
            this.txtBox_dateOfMeasurement.Size = new System.Drawing.Size(100, 23);
            this.txtBox_dateOfMeasurement.TabIndex = 42;
            this.txtBox_dateOfMeasurement.Text = "?";
            // 
            // txtBox_protocolNumber
            // 
            this.txtBox_protocolNumber.Location = new System.Drawing.Point(216, 71);
            this.txtBox_protocolNumber.Name = "txtBox_protocolNumber";
            this.txtBox_protocolNumber.ReadOnly = true;
            this.txtBox_protocolNumber.Size = new System.Drawing.Size(100, 23);
            this.txtBox_protocolNumber.TabIndex = 41;
            this.txtBox_protocolNumber.Text = "?";
            // 
            // btn_editDeviceInfo
            // 
            this.btn_editDeviceInfo.Location = new System.Drawing.Point(652, 315);
            this.btn_editDeviceInfo.Name = "btn_editDeviceInfo";
            this.btn_editDeviceInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_editDeviceInfo.TabIndex = 40;
            this.btn_editDeviceInfo.Text = "Upravit";
            this.btn_editDeviceInfo.UseVisualStyleBackColor = true;
            this.btn_editDeviceInfo.Click += new System.EventHandler(this.btn_editDeviceInfo_Click);
            // 
            // lbl_serialNumber
            // 
            this.lbl_serialNumber.AutoSize = true;
            this.lbl_serialNumber.Location = new System.Drawing.Point(533, 274);
            this.lbl_serialNumber.Name = "lbl_serialNumber";
            this.lbl_serialNumber.Size = new System.Drawing.Size(77, 15);
            this.lbl_serialNumber.TabIndex = 39;
            this.lbl_serialNumber.Text = "Sériové Číslo:";
            // 
            // lbl_modelName
            // 
            this.lbl_modelName.AutoSize = true;
            this.lbl_modelName.Location = new System.Drawing.Point(533, 245);
            this.lbl_modelName.Name = "lbl_modelName";
            this.lbl_modelName.Size = new System.Drawing.Size(44, 15);
            this.lbl_modelName.TabIndex = 38;
            this.lbl_modelName.Text = "Model:";
            // 
            // lbl_producerName
            // 
            this.lbl_producerName.AutoSize = true;
            this.lbl_producerName.Location = new System.Drawing.Point(533, 214);
            this.lbl_producerName.Name = "lbl_producerName";
            this.lbl_producerName.Size = new System.Drawing.Size(53, 15);
            this.lbl_producerName.TabIndex = 37;
            this.lbl_producerName.Text = "Výrobce:";
            // 
            // lbl_device
            // 
            this.lbl_device.AutoSize = true;
            this.lbl_device.Location = new System.Drawing.Point(515, 178);
            this.lbl_device.Name = "lbl_device";
            this.lbl_device.Size = new System.Drawing.Size(48, 15);
            this.lbl_device.TabIndex = 36;
            this.lbl_device.Text = "Zařízení";
            // 
            // btn_editCustomerInfo
            // 
            this.btn_editCustomerInfo.Location = new System.Drawing.Point(241, 324);
            this.btn_editCustomerInfo.Name = "btn_editCustomerInfo";
            this.btn_editCustomerInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_editCustomerInfo.TabIndex = 35;
            this.btn_editCustomerInfo.Text = "Upravit";
            this.btn_editCustomerInfo.UseVisualStyleBackColor = true;
            this.btn_editCustomerInfo.Click += new System.EventHandler(this.btn_editCustomerInfo_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(91, 297);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 15);
            this.lbl_id.TabIndex = 34;
            this.lbl_id.Text = "IČ:";
            // 
            // lbl_postNumber
            // 
            this.lbl_postNumber.AutoSize = true;
            this.lbl_postNumber.Location = new System.Drawing.Point(91, 268);
            this.lbl_postNumber.Name = "lbl_postNumber";
            this.lbl_postNumber.Size = new System.Drawing.Size(31, 15);
            this.lbl_postNumber.TabIndex = 33;
            this.lbl_postNumber.Text = "PSČ:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(91, 238);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(46, 15);
            this.lbl_address.TabIndex = 32;
            this.lbl_address.Text = "Adresa:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(91, 211);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 15);
            this.lbl_name.TabIndex = 31;
            this.lbl_name.Text = "Název:";
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Location = new System.Drawing.Point(73, 178);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(53, 15);
            this.lbl_customer.TabIndex = 30;
            this.lbl_customer.Text = "Zákazník";
            // 
            // btn_editBasicInfo
            // 
            this.btn_editBasicInfo.Location = new System.Drawing.Point(564, 74);
            this.btn_editBasicInfo.Name = "btn_editBasicInfo";
            this.btn_editBasicInfo.Size = new System.Drawing.Size(101, 46);
            this.btn_editBasicInfo.TabIndex = 29;
            this.btn_editBasicInfo.Text = "Upravit";
            this.btn_editBasicInfo.UseVisualStyleBackColor = true;
            this.btn_editBasicInfo.Click += new System.EventHandler(this.btn_editBasicInfo_Click);
            // 
            // lbl_dateOfMeasurement
            // 
            this.lbl_dateOfMeasurement.AutoSize = true;
            this.lbl_dateOfMeasurement.Location = new System.Drawing.Point(91, 105);
            this.lbl_dateOfMeasurement.Name = "lbl_dateOfMeasurement";
            this.lbl_dateOfMeasurement.Size = new System.Drawing.Size(86, 15);
            this.lbl_dateOfMeasurement.TabIndex = 28;
            this.lbl_dateOfMeasurement.Text = "Datum Měření:";
            // 
            // lbl_protocolNumber
            // 
            this.lbl_protocolNumber.AutoSize = true;
            this.lbl_protocolNumber.Location = new System.Drawing.Point(91, 74);
            this.lbl_protocolNumber.Name = "lbl_protocolNumber";
            this.lbl_protocolNumber.Size = new System.Drawing.Size(91, 15);
            this.lbl_protocolNumber.TabIndex = 27;
            this.lbl_protocolNumber.Text = "Číslo Protokolu:";
            // 
            // lbl_basicInfo
            // 
            this.lbl_basicInfo.AutoSize = true;
            this.lbl_basicInfo.Location = new System.Drawing.Point(73, 36);
            this.lbl_basicInfo.Name = "lbl_basicInfo";
            this.lbl_basicInfo.Size = new System.Drawing.Size(109, 15);
            this.lbl_basicInfo.TabIndex = 26;
            this.lbl_basicInfo.Text = "Základní Informace";
            // 
            // dataGridView_measurement
            // 
            this.dataGridView_measurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_measurement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paremeter,
            this.MeasuredValue,
            this.Value,
            this.IsValid});
            this.dataGridView_measurement.Location = new System.Drawing.Point(91, 429);
            this.dataGridView_measurement.Name = "dataGridView_measurement";
            this.dataGridView_measurement.RowTemplate.Height = 25;
            this.dataGridView_measurement.Size = new System.Drawing.Size(623, 180);
            this.dataGridView_measurement.TabIndex = 51;
            // 
            // Paremeter
            // 
            this.Paremeter.HeaderText = "Parametr";
            this.Paremeter.Name = "Paremeter";
            // 
            // MeasuredValue
            // 
            this.MeasuredValue.HeaderText = "Naměřená Jednotka";
            this.MeasuredValue.Name = "MeasuredValue";
            // 
            // Value
            // 
            this.Value.HeaderText = "Jednotka";
            this.Value.Name = "Value";
            // 
            // IsValid
            // 
            this.IsValid.HeaderText = "Vyhovuje";
            this.IsValid.Name = "IsValid";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(477, 615);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 52;
            this.btn_add.Text = "Přidat";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(558, 615);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 53;
            this.btn_edit.Text = "Upravit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(639, 615);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 54;
            this.btn_delete.Text = "Smazat";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(713, 663);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 55;
            this.btn_preview.Text = "Náhled";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 663);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Uložit";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(102, 663);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 57;
            this.btn_load.Text = "Načíst";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView_measurement);
            this.Controls.Add(this.lbl_measurement);
            this.Controls.Add(this.txtBox_serialNumber);
            this.Controls.Add(this.txtBox_modelName);
            this.Controls.Add(this.txtBox_producerName);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.txtBox_postNumber);
            this.Controls.Add(this.txtBox_address);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.txtBox_dateOfMeasurement);
            this.Controls.Add(this.txtBox_protocolNumber);
            this.Controls.Add(this.btn_editDeviceInfo);
            this.Controls.Add(this.lbl_serialNumber);
            this.Controls.Add(this.lbl_modelName);
            this.Controls.Add(this.lbl_producerName);
            this.Controls.Add(this.lbl_device);
            this.Controls.Add(this.btn_editCustomerInfo);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_postNumber);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.btn_editBasicInfo);
            this.Controls.Add(this.lbl_dateOfMeasurement);
            this.Controls.Add(this.lbl_protocolNumber);
            this.Controls.Add(this.lbl_basicInfo);
            this.Name = "HomePageForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_measurement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}