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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtBox_maker = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_maker = new System.Windows.Forms.Label();
            this.txtBox_modelName = new System.Windows.Forms.TextBox();
            this.txtBox_serialNum = new System.Windows.Forms.TextBox();
            this.lbl_serialNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(258, 115);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(177, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "OK";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtBox_maker
            // 
            this.txtBox_maker.Location = new System.Drawing.Point(107, 12);
            this.txtBox_maker.Name = "txtBox_maker";
            this.txtBox_maker.Size = new System.Drawing.Size(226, 23);
            this.txtBox_maker.TabIndex = 9;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(52, 44);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(44, 15);
            this.lbl_model.TabIndex = 8;
            this.lbl_model.Text = "Model:";
            // 
            // lbl_maker
            // 
            this.lbl_maker.AutoSize = true;
            this.lbl_maker.Location = new System.Drawing.Point(43, 15);
            this.lbl_maker.Name = "lbl_maker";
            this.lbl_maker.Size = new System.Drawing.Size(53, 15);
            this.lbl_maker.TabIndex = 7;
            this.lbl_maker.Text = "Výrobce:";
            // 
            // txtBox_modelName
            // 
            this.txtBox_modelName.Location = new System.Drawing.Point(107, 41);
            this.txtBox_modelName.Name = "txtBox_modelName";
            this.txtBox_modelName.Size = new System.Drawing.Size(226, 23);
            this.txtBox_modelName.TabIndex = 12;
            // 
            // txtBox_serialNum
            // 
            this.txtBox_serialNum.Location = new System.Drawing.Point(107, 70);
            this.txtBox_serialNum.Name = "txtBox_serialNum";
            this.txtBox_serialNum.Size = new System.Drawing.Size(226, 23);
            this.txtBox_serialNum.TabIndex = 14;
            // 
            // lbl_serialNumber
            // 
            this.lbl_serialNumber.AutoSize = true;
            this.lbl_serialNumber.Location = new System.Drawing.Point(19, 73);
            this.lbl_serialNumber.Name = "lbl_serialNumber";
            this.lbl_serialNumber.Size = new System.Drawing.Size(77, 15);
            this.lbl_serialNumber.TabIndex = 13;
            this.lbl_serialNumber.Text = "Seriové Číslo:";
            // 
            // DeviceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 149);
            this.Controls.Add(this.txtBox_serialNum);
            this.Controls.Add(this.lbl_serialNumber);
            this.Controls.Add(this.txtBox_modelName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_maker);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_maker);
            this.Name = "DeviceInfoForm";
            this.Text = "Zařízení";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_cancel;
        private Button btn_save;
        private TextBox txtBox_maker;
        private Label lbl_model;
        private Label lbl_maker;
        private TextBox txtBox_modelName;
        private TextBox txtBox_serialNum;
        private Label lbl_serialNumber;
    }
}