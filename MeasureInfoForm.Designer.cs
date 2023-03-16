namespace ServisniProtokol
{
    partial class MeasureInfoForm
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
            this.lbl_isValid = new System.Windows.Forms.Label();
            this.txtBox_unit = new System.Windows.Forms.TextBox();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.txtBox_measuredUnit = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtBox_paramName = new System.Windows.Forms.TextBox();
            this.lbl_measuredUnit = new System.Windows.Forms.Label();
            this.lbl_paramName = new System.Windows.Forms.Label();
            this.chckBox_isValid = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_isValid
            // 
            this.lbl_isValid.AutoSize = true;
            this.lbl_isValid.Location = new System.Drawing.Point(58, 102);
            this.lbl_isValid.Name = "lbl_isValid";
            this.lbl_isValid.Size = new System.Drawing.Size(59, 15);
            this.lbl_isValid.TabIndex = 33;
            this.lbl_isValid.Text = "Vyhovuje:";
            // 
            // txtBox_unit
            // 
            this.txtBox_unit.Location = new System.Drawing.Point(121, 70);
            this.txtBox_unit.Name = "txtBox_unit";
            this.txtBox_unit.Size = new System.Drawing.Size(226, 23);
            this.txtBox_unit.TabIndex = 32;
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.Location = new System.Drawing.Point(58, 73);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(57, 15);
            this.lbl_unit.TabIndex = 31;
            this.lbl_unit.Text = "Jednotka:";
            // 
            // txtBox_measuredUnit
            // 
            this.txtBox_measuredUnit.Location = new System.Drawing.Point(121, 41);
            this.txtBox_measuredUnit.Name = "txtBox_measuredUnit";
            this.txtBox_measuredUnit.Size = new System.Drawing.Size(226, 23);
            this.txtBox_measuredUnit.TabIndex = 30;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(272, 146);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(191, 146);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "OK";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtBox_paramName
            // 
            this.txtBox_paramName.Location = new System.Drawing.Point(121, 12);
            this.txtBox_paramName.Name = "txtBox_paramName";
            this.txtBox_paramName.Size = new System.Drawing.Size(226, 23);
            this.txtBox_paramName.TabIndex = 27;
            // 
            // lbl_measuredUnit
            // 
            this.lbl_measuredUnit.AutoSize = true;
            this.lbl_measuredUnit.Location = new System.Drawing.Point(0, 44);
            this.lbl_measuredUnit.Name = "lbl_measuredUnit";
            this.lbl_measuredUnit.Size = new System.Drawing.Size(115, 15);
            this.lbl_measuredUnit.TabIndex = 26;
            this.lbl_measuredUnit.Text = "Naměřená Jednotka:";
            // 
            // lbl_paramName
            // 
            this.lbl_paramName.AutoSize = true;
            this.lbl_paramName.Location = new System.Drawing.Point(15, 15);
            this.lbl_paramName.Name = "lbl_paramName";
            this.lbl_paramName.Size = new System.Drawing.Size(100, 15);
            this.lbl_paramName.TabIndex = 25;
            this.lbl_paramName.Text = "Název Parametru:";
            // 
            // chckBox_isValid
            // 
            this.chckBox_isValid.AutoSize = true;
            this.chckBox_isValid.Location = new System.Drawing.Point(123, 103);
            this.chckBox_isValid.Name = "chckBox_isValid";
            this.chckBox_isValid.Size = new System.Drawing.Size(15, 14);
            this.chckBox_isValid.TabIndex = 34;
            this.chckBox_isValid.UseVisualStyleBackColor = true;
            // 
            // MeasureInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 187);
            this.Controls.Add(this.chckBox_isValid);
            this.Controls.Add(this.lbl_isValid);
            this.Controls.Add(this.txtBox_unit);
            this.Controls.Add(this.lbl_unit);
            this.Controls.Add(this.txtBox_measuredUnit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_paramName);
            this.Controls.Add(this.lbl_measuredUnit);
            this.Controls.Add(this.lbl_paramName);
            this.Name = "MeasureInfoForm";
            this.Text = "MeasureInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_isValid;
        private TextBox txtBox_unit;
        private Label lbl_unit;
        private TextBox txtBox_measuredUnit;
        private Button btn_cancel;
        private Button btn_save;
        private TextBox txtBox_paramName;
        private Label lbl_measuredUnit;
        private Label lbl_paramName;
        private CheckBox chckBox_isValid;
    }
}