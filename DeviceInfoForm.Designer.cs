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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(258, 115);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "STORNO";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(177, 115);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 10;
            btn_save.Text = "OK";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txtBox_producer
            // 
            txtBox_producer.Location = new Point(107, 12);
            txtBox_producer.Name = "txtBox_producer";
            txtBox_producer.Size = new Size(226, 23);
            txtBox_producer.TabIndex = 9;
            // 
            // lbl_model
            // 
            lbl_model.AutoSize = true;
            lbl_model.Location = new Point(52, 44);
            lbl_model.Name = "lbl_model";
            lbl_model.Size = new Size(44, 15);
            lbl_model.TabIndex = 8;
            lbl_model.Text = "Model:";
            // 
            // lbl_maker
            // 
            lbl_maker.AutoSize = true;
            lbl_maker.Location = new Point(43, 15);
            lbl_maker.Name = "lbl_maker";
            lbl_maker.Size = new Size(53, 15);
            lbl_maker.TabIndex = 7;
            lbl_maker.Text = "Výrobce:";
            // 
            // txtBox_modelName
            // 
            txtBox_modelName.Location = new Point(107, 41);
            txtBox_modelName.Name = "txtBox_modelName";
            txtBox_modelName.Size = new Size(226, 23);
            txtBox_modelName.TabIndex = 12;
            // 
            // txtBox_serialNum
            // 
            txtBox_serialNum.Location = new Point(107, 70);
            txtBox_serialNum.Name = "txtBox_serialNum";
            txtBox_serialNum.Size = new Size(226, 23);
            txtBox_serialNum.TabIndex = 14;
            // 
            // lbl_serialNumber
            // 
            lbl_serialNumber.AutoSize = true;
            lbl_serialNumber.Location = new Point(19, 73);
            lbl_serialNumber.Name = "lbl_serialNumber";
            lbl_serialNumber.Size = new Size(77, 15);
            lbl_serialNumber.TabIndex = 13;
            lbl_serialNumber.Text = "Seriové Číslo:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DeviceInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 149);
            Controls.Add(txtBox_serialNum);
            Controls.Add(lbl_serialNumber);
            Controls.Add(txtBox_modelName);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txtBox_producer);
            Controls.Add(lbl_model);
            Controls.Add(lbl_maker);
            Name = "DeviceInfoForm";
            Text = "Zařízení";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
    }
}