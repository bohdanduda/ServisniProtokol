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
            this.lbl_protocolNumber = new System.Windows.Forms.Label();
            this.lbl_dateOfMeasurement = new System.Windows.Forms.Label();
            this.txtBox_protocolNumber = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtBox_dateOfMeasurement = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_protocolNumber
            // 
            this.lbl_protocolNumber.AutoSize = true;
            this.lbl_protocolNumber.Location = new System.Drawing.Point(12, 9);
            this.lbl_protocolNumber.Name = "lbl_protocolNumber";
            this.lbl_protocolNumber.Size = new System.Drawing.Size(91, 15);
            this.lbl_protocolNumber.TabIndex = 0;
            this.lbl_protocolNumber.Text = "Číslo Protokolu:";
            // 
            // lbl_dateOfMeasurement
            // 
            this.lbl_dateOfMeasurement.AutoSize = true;
            this.lbl_dateOfMeasurement.Location = new System.Drawing.Point(12, 40);
            this.lbl_dateOfMeasurement.Name = "lbl_dateOfMeasurement";
            this.lbl_dateOfMeasurement.Size = new System.Drawing.Size(86, 15);
            this.lbl_dateOfMeasurement.TabIndex = 1;
            this.lbl_dateOfMeasurement.Text = "Datum Měření:";
            // 
            // txtBox_protocolNumber
            // 
            this.txtBox_protocolNumber.Location = new System.Drawing.Point(109, 6);
            this.txtBox_protocolNumber.Name = "txtBox_protocolNumber";
            this.txtBox_protocolNumber.Size = new System.Drawing.Size(226, 23);
            this.txtBox_protocolNumber.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(202, 73);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "OK";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(283, 73);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "ZRUŠIT";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txtBox_dateOfMeasurement
            // 
            this.txtBox_dateOfMeasurement.Location = new System.Drawing.Point(109, 35);
            this.txtBox_dateOfMeasurement.Mask = "00/00/0000";
            this.txtBox_dateOfMeasurement.Name = "txtBox_dateOfMeasurement";
            this.txtBox_dateOfMeasurement.Size = new System.Drawing.Size(226, 23);
            this.txtBox_dateOfMeasurement.TabIndex = 6;
            this.txtBox_dateOfMeasurement.ValidatingType = typeof(System.DateTime);
            // 
            // BasicInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 108);
            this.Controls.Add(this.txtBox_dateOfMeasurement);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_protocolNumber);
            this.Controls.Add(this.lbl_dateOfMeasurement);
            this.Controls.Add(this.lbl_protocolNumber);
            this.Name = "BasicInfoForm";
            this.Text = "Základní Informace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_protocolNumber;
        private Label lbl_dateOfMeasurement;
        private TextBox txtBox_protocolNumber;
        private Button btn_save;
        private Button btn_cancel;
        private MaskedTextBox txtBox_dateOfMeasurement;
    }
}