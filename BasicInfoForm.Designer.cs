namespace ServisniProtokol
{
    partial class BasicInfoForm
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
            lbl_protocolNumber = new Label();
            lbl_dateOfMeasurement = new Label();
            txtBox_protocolNumber = new TextBox();
            btn_save = new Button();
            btn_cancel = new Button();
            dateTimePicker = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            groupBox_basicInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox_basicInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_protocolNumber
            // 
            lbl_protocolNumber.AutoSize = true;
            lbl_protocolNumber.Font = new Font("Segoe UI", 9F);
            lbl_protocolNumber.Location = new Point(20, 37);
            lbl_protocolNumber.Name = "lbl_protocolNumber";
            lbl_protocolNumber.Size = new Size(91, 15);
            lbl_protocolNumber.TabIndex = 0;
            lbl_protocolNumber.Text = "Číslo Protokolu:";
            // 
            // lbl_dateOfMeasurement
            // 
            lbl_dateOfMeasurement.AutoSize = true;
            lbl_dateOfMeasurement.Font = new Font("Segoe UI", 9F);
            lbl_dateOfMeasurement.Location = new Point(25, 69);
            lbl_dateOfMeasurement.Name = "lbl_dateOfMeasurement";
            lbl_dateOfMeasurement.Size = new Size(86, 15);
            lbl_dateOfMeasurement.TabIndex = 1;
            lbl_dateOfMeasurement.Text = "Datum Měření:";
            // 
            // txtBox_protocolNumber
            // 
            txtBox_protocolNumber.Font = new Font("Segoe UI", 9F);
            txtBox_protocolNumber.Location = new Point(117, 34);
            txtBox_protocolNumber.Name = "txtBox_protocolNumber";
            txtBox_protocolNumber.Size = new Size(226, 23);
            txtBox_protocolNumber.TabIndex = 2;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 9F);
            btn_save.Location = new Point(109, 107);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "Uložit";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 9F);
            btn_cancel.Location = new Point(190, 107);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Storno";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 9F);
            dateTimePicker.Location = new Point(117, 63);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(226, 23);
            dateTimePicker.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox_basicInfo
            // 
            groupBox_basicInfo.Controls.Add(dateTimePicker);
            groupBox_basicInfo.Controls.Add(btn_cancel);
            groupBox_basicInfo.Controls.Add(btn_save);
            groupBox_basicInfo.Controls.Add(txtBox_protocolNumber);
            groupBox_basicInfo.Controls.Add(lbl_dateOfMeasurement);
            groupBox_basicInfo.Controls.Add(lbl_protocolNumber);
            groupBox_basicInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox_basicInfo.Location = new Point(16, 20);
            groupBox_basicInfo.Name = "groupBox_basicInfo";
            groupBox_basicInfo.Size = new Size(372, 136);
            groupBox_basicInfo.TabIndex = 7;
            groupBox_basicInfo.TabStop = false;
            groupBox_basicInfo.Text = "Přidání základních informací";
            // 
            // BasicInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 174);
            Controls.Add(groupBox_basicInfo);
            Name = "BasicInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Základní informace";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox_basicInfo.ResumeLayout(false);
            groupBox_basicInfo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Label lbl_protocolNumber;
        private Label lbl_dateOfMeasurement;
        private TextBox txtBox_protocolNumber;
        private Button btn_save;
        private Button btn_cancel;
        private DateTimePicker dateTimePicker;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox_basicInfo;
    }
}