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
            btn_editCustomerInfo = new Button();
            lbl_id = new Label();
            lbl_postNumber = new Label();
            lbl_address = new Label();
            lbl_name = new Label();
            btn_editBasicInfo = new Button();
            lbl_dateOfMeasurement = new Label();
            lbl_protocolNumber = new Label();
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
            btn_addBasicInfo = new Button();
            groupBox_basicInfo = new GroupBox();
            btn_addCustomerInfo = new Button();
            groupBox1 = new GroupBox();
            button_addDeviceInfo = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btn_help = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_measurement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox_basicInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtBox_serialNumber
            // 
            txtBox_serialNumber.Font = new Font("Segoe UI", 9F);
            txtBox_serialNumber.Location = new Point(94, 105);
            txtBox_serialNumber.Name = "txtBox_serialNumber";
            txtBox_serialNumber.ReadOnly = true;
            txtBox_serialNumber.Size = new Size(173, 23);
            txtBox_serialNumber.TabIndex = 49;
            txtBox_serialNumber.Text = "?";
            txtBox_serialNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_modelName
            // 
            txtBox_modelName.Font = new Font("Segoe UI", 9F);
            txtBox_modelName.Location = new Point(94, 76);
            txtBox_modelName.Name = "txtBox_modelName";
            txtBox_modelName.ReadOnly = true;
            txtBox_modelName.Size = new Size(173, 23);
            txtBox_modelName.TabIndex = 48;
            txtBox_modelName.Text = "?";
            txtBox_modelName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_producerName
            // 
            txtBox_producerName.Font = new Font("Segoe UI", 9F);
            txtBox_producerName.Location = new Point(94, 47);
            txtBox_producerName.Name = "txtBox_producerName";
            txtBox_producerName.ReadOnly = true;
            txtBox_producerName.Size = new Size(173, 23);
            txtBox_producerName.TabIndex = 47;
            txtBox_producerName.Text = "?";
            txtBox_producerName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_id
            // 
            txtBox_id.Font = new Font("Segoe UI", 9F);
            txtBox_id.Location = new Point(83, 113);
            txtBox_id.Name = "txtBox_id";
            txtBox_id.ReadOnly = true;
            txtBox_id.Size = new Size(173, 23);
            txtBox_id.TabIndex = 46;
            txtBox_id.Text = "?";
            txtBox_id.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_postNumber
            // 
            txtBox_postNumber.Font = new Font("Segoe UI", 9F);
            txtBox_postNumber.Location = new Point(83, 84);
            txtBox_postNumber.Name = "txtBox_postNumber";
            txtBox_postNumber.ReadOnly = true;
            txtBox_postNumber.Size = new Size(173, 23);
            txtBox_postNumber.TabIndex = 45;
            txtBox_postNumber.Text = "?";
            txtBox_postNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_address
            // 
            txtBox_address.Font = new Font("Segoe UI", 9F);
            txtBox_address.Location = new Point(83, 55);
            txtBox_address.Name = "txtBox_address";
            txtBox_address.ReadOnly = true;
            txtBox_address.Size = new Size(173, 23);
            txtBox_address.TabIndex = 44;
            txtBox_address.Text = "?";
            txtBox_address.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_name
            // 
            txtBox_name.Font = new Font("Segoe UI", 9F);
            txtBox_name.Location = new Point(83, 26);
            txtBox_name.Name = "txtBox_name";
            txtBox_name.ReadOnly = true;
            txtBox_name.Size = new Size(173, 23);
            txtBox_name.TabIndex = 43;
            txtBox_name.Text = "?";
            txtBox_name.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_dateOfMeasurement
            // 
            txtBox_dateOfMeasurement.Font = new Font("Segoe UI", 9F);
            txtBox_dateOfMeasurement.Location = new Point(149, 64);
            txtBox_dateOfMeasurement.Name = "txtBox_dateOfMeasurement";
            txtBox_dateOfMeasurement.ReadOnly = true;
            txtBox_dateOfMeasurement.Size = new Size(172, 23);
            txtBox_dateOfMeasurement.TabIndex = 42;
            txtBox_dateOfMeasurement.Text = "?";
            txtBox_dateOfMeasurement.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBox_protocolNumber
            // 
            txtBox_protocolNumber.Font = new Font("Segoe UI", 9F);
            txtBox_protocolNumber.Location = new Point(149, 34);
            txtBox_protocolNumber.Name = "txtBox_protocolNumber";
            txtBox_protocolNumber.ReadOnly = true;
            txtBox_protocolNumber.Size = new Size(172, 23);
            txtBox_protocolNumber.TabIndex = 41;
            txtBox_protocolNumber.Text = "?";
            txtBox_protocolNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_editDeviceInfo
            // 
            btn_editDeviceInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_editDeviceInfo.Location = new Point(166, 157);
            btn_editDeviceInfo.Name = "btn_editDeviceInfo";
            btn_editDeviceInfo.Size = new Size(75, 23);
            btn_editDeviceInfo.TabIndex = 6;
            btn_editDeviceInfo.Text = "Upravit";
            btn_editDeviceInfo.UseVisualStyleBackColor = true;
            btn_editDeviceInfo.Click += btn_editDeviceInfo_Click;
            // 
            // lbl_serialNumber
            // 
            lbl_serialNumber.AutoSize = true;
            lbl_serialNumber.Font = new Font("Segoe UI", 9F);
            lbl_serialNumber.Location = new Point(13, 108);
            lbl_serialNumber.Name = "lbl_serialNumber";
            lbl_serialNumber.Size = new Size(75, 15);
            lbl_serialNumber.TabIndex = 39;
            lbl_serialNumber.Text = "Sériové číslo:";
            // 
            // lbl_modelName
            // 
            lbl_modelName.AutoSize = true;
            lbl_modelName.Font = new Font("Segoe UI", 9F);
            lbl_modelName.Location = new Point(44, 79);
            lbl_modelName.Name = "lbl_modelName";
            lbl_modelName.Size = new Size(44, 15);
            lbl_modelName.TabIndex = 38;
            lbl_modelName.Text = "Model:";
            // 
            // lbl_producerName
            // 
            lbl_producerName.AutoSize = true;
            lbl_producerName.Font = new Font("Segoe UI", 9F);
            lbl_producerName.Location = new Point(35, 50);
            lbl_producerName.Name = "lbl_producerName";
            lbl_producerName.Size = new Size(53, 15);
            lbl_producerName.TabIndex = 37;
            lbl_producerName.Text = "Výrobce:";
            // 
            // btn_editCustomerInfo
            // 
            btn_editCustomerInfo.Font = new Font("Segoe UI", 9F);
            btn_editCustomerInfo.Location = new Point(149, 157);
            btn_editCustomerInfo.Name = "btn_editCustomerInfo";
            btn_editCustomerInfo.Size = new Size(75, 23);
            btn_editCustomerInfo.TabIndex = 4;
            btn_editCustomerInfo.Text = "Upravit";
            btn_editCustomerInfo.UseVisualStyleBackColor = true;
            btn_editCustomerInfo.Click += btn_editCustomerInfo_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 9F);
            lbl_id.Location = new Point(56, 116);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(21, 15);
            lbl_id.TabIndex = 34;
            lbl_id.Text = "IČ:";
            // 
            // lbl_postNumber
            // 
            lbl_postNumber.AutoSize = true;
            lbl_postNumber.Font = new Font("Segoe UI", 9F);
            lbl_postNumber.Location = new Point(46, 87);
            lbl_postNumber.Name = "lbl_postNumber";
            lbl_postNumber.Size = new Size(31, 15);
            lbl_postNumber.TabIndex = 33;
            lbl_postNumber.Text = "PSČ:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 9F);
            lbl_address.Location = new Point(31, 56);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(46, 15);
            lbl_address.TabIndex = 32;
            lbl_address.Text = "Adresa:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 9F);
            lbl_name.Location = new Point(35, 29);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(42, 15);
            lbl_name.TabIndex = 31;
            lbl_name.Text = "Název:";
            // 
            // btn_editBasicInfo
            // 
            btn_editBasicInfo.Font = new Font("Segoe UI", 9F);
            btn_editBasicInfo.Location = new Point(353, 64);
            btn_editBasicInfo.Name = "btn_editBasicInfo";
            btn_editBasicInfo.Size = new Size(75, 23);
            btn_editBasicInfo.TabIndex = 2;
            btn_editBasicInfo.Text = "Upravit";
            btn_editBasicInfo.UseVisualStyleBackColor = true;
            btn_editBasicInfo.Click += btn_editBasicInfo_Click;
            // 
            // lbl_dateOfMeasurement
            // 
            lbl_dateOfMeasurement.AutoSize = true;
            lbl_dateOfMeasurement.Font = new Font("Segoe UI", 9F);
            lbl_dateOfMeasurement.Location = new Point(57, 68);
            lbl_dateOfMeasurement.Name = "lbl_dateOfMeasurement";
            lbl_dateOfMeasurement.Size = new Size(86, 15);
            lbl_dateOfMeasurement.TabIndex = 28;
            lbl_dateOfMeasurement.Text = "Datum Měření:";
            // 
            // lbl_protocolNumber
            // 
            lbl_protocolNumber.AutoSize = true;
            lbl_protocolNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_protocolNumber.Location = new Point(52, 38);
            lbl_protocolNumber.Name = "lbl_protocolNumber";
            lbl_protocolNumber.Size = new Size(91, 15);
            lbl_protocolNumber.TabIndex = 27;
            lbl_protocolNumber.Text = "Číslo Protokolu:";
            // 
            // dataGridView_measurement
            // 
            dataGridView_measurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_measurement.Columns.AddRange(new DataGridViewColumn[] { Paremeter, MeasuredValue, Value, IsValid });
            dataGridView_measurement.Location = new Point(27, 32);
            dataGridView_measurement.Name = "dataGridView_measurement";
            dataGridView_measurement.Size = new Size(444, 180);
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
            btn_add.Font = new Font("Segoe UI", 9F);
            btn_add.Location = new Point(135, 229);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 22);
            btn_add.TabIndex = 7;
            btn_add.Text = "Přidat";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 9F);
            btn_edit.Location = new Point(216, 228);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Upravit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 9F);
            btn_delete.Location = new Point(297, 229);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 22);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Smazat";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_preview
            // 
            btn_preview.Location = new Point(713, 663);
            btn_preview.Name = "btn_preview";
            btn_preview.Size = new Size(75, 23);
            btn_preview.TabIndex = 13;
            btn_preview.Text = "Náhled";
            btn_preview.UseVisualStyleBackColor = true;
            btn_preview.Click += btn_preview_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(10, 663);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 10;
            btn_save.Text = "Uložit";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(91, 663);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(75, 23);
            btn_load.TabIndex = 11;
            btn_load.Text = "Načíst";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_addBasicInfo
            // 
            btn_addBasicInfo.Font = new Font("Segoe UI", 9F);
            btn_addBasicInfo.Location = new Point(353, 34);
            btn_addBasicInfo.Name = "btn_addBasicInfo";
            btn_addBasicInfo.Size = new Size(75, 23);
            btn_addBasicInfo.TabIndex = 1;
            btn_addBasicInfo.Text = "Přidat";
            btn_addBasicInfo.UseVisualStyleBackColor = true;
            btn_addBasicInfo.Click += btn_addBasicInfo_Click;
            // 
            // groupBox_basicInfo
            // 
            groupBox_basicInfo.Controls.Add(btn_addBasicInfo);
            groupBox_basicInfo.Controls.Add(txtBox_dateOfMeasurement);
            groupBox_basicInfo.Controls.Add(txtBox_protocolNumber);
            groupBox_basicInfo.Controls.Add(btn_editBasicInfo);
            groupBox_basicInfo.Controls.Add(lbl_dateOfMeasurement);
            groupBox_basicInfo.Controls.Add(lbl_protocolNumber);
            groupBox_basicInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox_basicInfo.Location = new Point(170, 24);
            groupBox_basicInfo.Name = "groupBox_basicInfo";
            groupBox_basicInfo.Size = new Size(464, 121);
            groupBox_basicInfo.TabIndex = 59;
            groupBox_basicInfo.TabStop = false;
            groupBox_basicInfo.Text = "Základní informace";
            // 
            // btn_addCustomerInfo
            // 
            btn_addCustomerInfo.Font = new Font("Segoe UI", 9F);
            btn_addCustomerInfo.Location = new Point(68, 157);
            btn_addCustomerInfo.Name = "btn_addCustomerInfo";
            btn_addCustomerInfo.Size = new Size(75, 23);
            btn_addCustomerInfo.TabIndex = 3;
            btn_addCustomerInfo.Text = "Přidat";
            btn_addCustomerInfo.UseVisualStyleBackColor = true;
            btn_addCustomerInfo.Click += btn_addCustomerInfo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_addCustomerInfo);
            groupBox1.Controls.Add(txtBox_id);
            groupBox1.Controls.Add(txtBox_postNumber);
            groupBox1.Controls.Add(txtBox_address);
            groupBox1.Controls.Add(txtBox_name);
            groupBox1.Controls.Add(btn_editCustomerInfo);
            groupBox1.Controls.Add(lbl_id);
            groupBox1.Controls.Add(lbl_postNumber);
            groupBox1.Controls.Add(lbl_address);
            groupBox1.Controls.Add(lbl_name);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(60, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 186);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informace o zákazníkovi";
            // 
            // button_addDeviceInfo
            // 
            button_addDeviceInfo.Font = new Font("Segoe UI", 9F);
            button_addDeviceInfo.Location = new Point(85, 157);
            button_addDeviceInfo.Name = "button_addDeviceInfo";
            button_addDeviceInfo.Size = new Size(75, 23);
            button_addDeviceInfo.TabIndex = 5;
            button_addDeviceInfo.Text = "Přidat";
            button_addDeviceInfo.UseVisualStyleBackColor = true;
            button_addDeviceInfo.Click += button_addDeviceInfo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_addDeviceInfo);
            groupBox2.Controls.Add(txtBox_serialNumber);
            groupBox2.Controls.Add(txtBox_modelName);
            groupBox2.Controls.Add(txtBox_producerName);
            groupBox2.Controls.Add(btn_editDeviceInfo);
            groupBox2.Controls.Add(lbl_serialNumber);
            groupBox2.Controls.Add(lbl_modelName);
            groupBox2.Controls.Add(lbl_producerName);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox2.Location = new Point(447, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 186);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informace o zařízení";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_delete);
            groupBox3.Controls.Add(btn_edit);
            groupBox3.Controls.Add(btn_add);
            groupBox3.Controls.Add(dataGridView_measurement);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox3.Location = new Point(143, 391);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(499, 257);
            groupBox3.TabIndex = 64;
            groupBox3.TabStop = false;
            groupBox3.Text = "Měření";
            // 
            // btn_help
            // 
            btn_help.Location = new Point(632, 663);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(75, 23);
            btn_help.TabIndex = 12;
            btn_help.Text = "Nápověda";
            btn_help.UseVisualStyleBackColor = true;
            btn_help.Click += btn_help_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 698);
            Controls.Add(btn_help);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_basicInfo);
            Controls.Add(btn_load);
            Controls.Add(btn_save);
            Controls.Add(btn_preview);
            Name = "HomePageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servisní Protokol - Domovská stránka";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_measurement).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox_basicInfo.ResumeLayout(false);
            groupBox_basicInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
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
        private Button btn_editCustomerInfo;
        private Label lbl_id;
        private Label lbl_postNumber;
        private Label lbl_address;
        private Label lbl_name;
        private Label lbl_customer;
        private Button btn_editBasicInfo;
        private Label lbl_dateOfMeasurement;
        private Label lbl_protocolNumber;
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
        private Button btn_addBasicInfo;
        private GroupBox groupBox_basicInfo;
        private Button btn_addCustomerInfo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button_addDeviceInfo;
        private GroupBox groupBox3;
        private Button btn_help;
    }
}