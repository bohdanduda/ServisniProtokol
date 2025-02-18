namespace ServisniProtokol
{
    partial class DeviceInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_cancel = new Button();
            btn_save = new Button();
            txtBox_producer = new TextBox();
            lbl_model = new Label();
            lbl_maker = new Label();
            txtBox_modelName = new TextBox();
            txtBox_serialNum = new TextBox();
            lbl_serialNumber = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox_deviceInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox_deviceInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 9F);
            btn_cancel.Location = new Point(188, 147);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Zrušit";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 9F);
            btn_save.Location = new Point(107, 147);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "Uložit";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txtBox_producer
            // 
            txtBox_producer.Font = new Font("Segoe UI", 9F);
            txtBox_producer.Location = new Point(109, 40);
            txtBox_producer.Name = "txtBox_producer";
            txtBox_producer.Size = new Size(226, 23);
            txtBox_producer.TabIndex = 1;
            // 
            // lbl_model
            // 
            lbl_model.AutoSize = true;
            lbl_model.Font = new Font("Segoe UI", 9F);
            lbl_model.Location = new Point(59, 72);
            lbl_model.Name = "lbl_model";
            lbl_model.Size = new Size(44, 15);
            lbl_model.TabIndex = 8;
            lbl_model.Text = "Model:";
            // 
            // lbl_maker
            // 
            lbl_maker.AutoSize = true;
            lbl_maker.Font = new Font("Segoe UI", 9F);
            lbl_maker.Location = new Point(50, 43);
            lbl_maker.Name = "lbl_maker";
            lbl_maker.Size = new Size(53, 15);
            lbl_maker.TabIndex = 7;
            lbl_maker.Text = "Výrobce:";
            // 
            // txtBox_modelName
            // 
            txtBox_modelName.Font = new Font("Segoe UI", 9F);
            txtBox_modelName.Location = new Point(109, 69);
            txtBox_modelName.Name = "txtBox_modelName";
            txtBox_modelName.Size = new Size(226, 23);
            txtBox_modelName.TabIndex = 2;
            // 
            // txtBox_serialNum
            // 
            txtBox_serialNum.Font = new Font("Segoe UI", 9F);
            txtBox_serialNum.Location = new Point(109, 98);
            txtBox_serialNum.Name = "txtBox_serialNum";
            txtBox_serialNum.Size = new Size(226, 23);
            txtBox_serialNum.TabIndex = 3;
            // 
            // lbl_serialNumber
            // 
            lbl_serialNumber.AutoSize = true;
            lbl_serialNumber.Font = new Font("Segoe UI", 9F);
            lbl_serialNumber.Location = new Point(26, 101);
            lbl_serialNumber.Name = "lbl_serialNumber";
            lbl_serialNumber.Size = new Size(77, 15);
            lbl_serialNumber.TabIndex = 13;
            lbl_serialNumber.Text = "Seriové Číslo:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox_deviceInfo
            // 
            groupBox_deviceInfo.Controls.Add(txtBox_serialNum);
            groupBox_deviceInfo.Controls.Add(lbl_serialNumber);
            groupBox_deviceInfo.Controls.Add(txtBox_modelName);
            groupBox_deviceInfo.Controls.Add(btn_cancel);
            groupBox_deviceInfo.Controls.Add(btn_save);
            groupBox_deviceInfo.Controls.Add(txtBox_producer);
            groupBox_deviceInfo.Controls.Add(lbl_model);
            groupBox_deviceInfo.Controls.Add(lbl_maker);
            groupBox_deviceInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox_deviceInfo.Location = new Point(13, 21);
            groupBox_deviceInfo.Name = "groupBox_deviceInfo";
            groupBox_deviceInfo.Size = new Size(370, 176);
            groupBox_deviceInfo.TabIndex = 15;
            groupBox_deviceInfo.TabStop = false;
            groupBox_deviceInfo.Text = "Přidání informací o zařízení";
            // 
            // DeviceInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 218);
            Controls.Add(groupBox_deviceInfo);
            Name = "DeviceInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informace o zařízení";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox_deviceInfo.ResumeLayout(false);
            groupBox_deviceInfo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Button btn_cancel;
        private Button btn_save;
        private TextBox txtBox_producer;
        private Label lbl_model;
        private Label lbl_maker;
        private TextBox txtBox_modelName;
        private TextBox txtBox_serialNum;
        private Label lbl_serialNumber;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox_deviceInfo;
    }
}