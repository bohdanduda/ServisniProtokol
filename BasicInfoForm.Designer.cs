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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_protocolNumber
            // 
            lbl_protocolNumber.AutoSize = true;
            lbl_protocolNumber.Location = new Point(12, 9);
            lbl_protocolNumber.Name = "lbl_protocolNumber";
            lbl_protocolNumber.Size = new Size(91, 15);
            lbl_protocolNumber.TabIndex = 0;
            lbl_protocolNumber.Text = "Číslo Protokolu:";
            // 
            // lbl_dateOfMeasurement
            // 
            lbl_dateOfMeasurement.AutoSize = true;
            lbl_dateOfMeasurement.Location = new Point(12, 40);
            lbl_dateOfMeasurement.Name = "lbl_dateOfMeasurement";
            lbl_dateOfMeasurement.Size = new Size(86, 15);
            lbl_dateOfMeasurement.TabIndex = 1;
            lbl_dateOfMeasurement.Text = "Datum Měření:";
            // 
            // txtBox_protocolNumber
            // 
            txtBox_protocolNumber.Location = new Point(109, 6);
            txtBox_protocolNumber.Name = "txtBox_protocolNumber";
            txtBox_protocolNumber.Size = new Size(226, 23);
            txtBox_protocolNumber.TabIndex = 2;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(202, 73);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "OK";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(283, 73);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "ZRUŠIT";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(109, 35);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(226, 23);
            dateTimePicker.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BasicInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 108);
            Controls.Add(dateTimePicker);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txtBox_protocolNumber);
            Controls.Add(lbl_dateOfMeasurement);
            Controls.Add(lbl_protocolNumber);
            Name = "BasicInfoForm";
            Text = "Základní Informace";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lbl_protocolNumber;
        private Label lbl_dateOfMeasurement;
        private TextBox txtBox_protocolNumber;
        private Button btn_save;
        private Button btn_cancel;
        private DateTimePicker dateTimePicker;
        private ErrorProvider errorProvider1;
    }
}