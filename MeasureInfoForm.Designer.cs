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
            components = new System.ComponentModel.Container();
            lbl_isValid = new Label();
            txtBox_unit = new TextBox();
            lbl_unit = new Label();
            txtBox_measuredUnit = new TextBox();
            btn_cancel = new Button();
            btn_save = new Button();
            txtBox_paramName = new TextBox();
            lbl_measuredUnit = new Label();
            lbl_paramName = new Label();
            chckBox_isValid = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox_measureInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox_measureInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_isValid
            // 
            lbl_isValid.AutoSize = true;
            lbl_isValid.Font = new Font("Segoe UI", 9F);
            lbl_isValid.Location = new Point(66, 134);
            lbl_isValid.Name = "lbl_isValid";
            lbl_isValid.Size = new Size(59, 15);
            lbl_isValid.TabIndex = 33;
            lbl_isValid.Text = "Vyhovuje:";
            // 
            // txtBox_unit
            // 
            txtBox_unit.Font = new Font("Segoe UI", 9F);
            txtBox_unit.Location = new Point(131, 95);
            txtBox_unit.Name = "txtBox_unit";
            txtBox_unit.Size = new Size(226, 23);
            txtBox_unit.TabIndex = 3;
            // 
            // lbl_unit
            // 
            lbl_unit.AutoSize = true;
            lbl_unit.Font = new Font("Segoe UI", 9F);
            lbl_unit.Location = new Point(68, 98);
            lbl_unit.Name = "lbl_unit";
            lbl_unit.Size = new Size(57, 15);
            lbl_unit.TabIndex = 31;
            lbl_unit.Text = "Jednotka:";
            // 
            // txtBox_measuredUnit
            // 
            txtBox_measuredUnit.Font = new Font("Segoe UI", 9F);
            txtBox_measuredUnit.Location = new Point(131, 66);
            txtBox_measuredUnit.Name = "txtBox_measuredUnit";
            txtBox_measuredUnit.Size = new Size(226, 23);
            txtBox_measuredUnit.TabIndex = 2;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 9F);
            btn_cancel.Location = new Point(191, 170);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Zrušit";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 9F);
            btn_save.Location = new Point(110, 170);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 5;
            btn_save.Text = "Uložit";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txtBox_paramName
            // 
            txtBox_paramName.Font = new Font("Segoe UI", 9F);
            txtBox_paramName.Location = new Point(131, 37);
            txtBox_paramName.Name = "txtBox_paramName";
            txtBox_paramName.Size = new Size(226, 23);
            txtBox_paramName.TabIndex = 1;
            // 
            // lbl_measuredUnit
            // 
            lbl_measuredUnit.AutoSize = true;
            lbl_measuredUnit.Font = new Font("Segoe UI", 9F);
            lbl_measuredUnit.Location = new Point(10, 69);
            lbl_measuredUnit.Name = "lbl_measuredUnit";
            lbl_measuredUnit.Size = new Size(115, 15);
            lbl_measuredUnit.TabIndex = 26;
            lbl_measuredUnit.Text = "Naměřená Jednotka:";
            // 
            // lbl_paramName
            // 
            lbl_paramName.AutoSize = true;
            lbl_paramName.Font = new Font("Segoe UI", 9F);
            lbl_paramName.Location = new Point(25, 40);
            lbl_paramName.Name = "lbl_paramName";
            lbl_paramName.Size = new Size(100, 15);
            lbl_paramName.TabIndex = 25;
            lbl_paramName.Text = "Název Parametru:";
            // 
            // chckBox_isValid
            // 
            chckBox_isValid.AutoSize = true;
            chckBox_isValid.Font = new Font("Segoe UI", 9F);
            chckBox_isValid.Location = new Point(131, 135);
            chckBox_isValid.Name = "chckBox_isValid";
            chckBox_isValid.Size = new Size(15, 14);
            chckBox_isValid.TabIndex = 4;
            chckBox_isValid.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox_measureInfo
            // 
            groupBox_measureInfo.Controls.Add(chckBox_isValid);
            groupBox_measureInfo.Controls.Add(lbl_isValid);
            groupBox_measureInfo.Controls.Add(txtBox_unit);
            groupBox_measureInfo.Controls.Add(lbl_unit);
            groupBox_measureInfo.Controls.Add(txtBox_measuredUnit);
            groupBox_measureInfo.Controls.Add(btn_cancel);
            groupBox_measureInfo.Controls.Add(btn_save);
            groupBox_measureInfo.Controls.Add(txtBox_paramName);
            groupBox_measureInfo.Controls.Add(lbl_measuredUnit);
            groupBox_measureInfo.Controls.Add(lbl_paramName);
            groupBox_measureInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox_measureInfo.Location = new Point(12, 12);
            groupBox_measureInfo.Name = "groupBox_measureInfo";
            groupBox_measureInfo.Size = new Size(375, 199);
            groupBox_measureInfo.TabIndex = 35;
            groupBox_measureInfo.TabStop = false;
            groupBox_measureInfo.Text = "Přidání záznamu měření";
            // 
            // MeasureInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 230);
            Controls.Add(groupBox_measureInfo);
            Name = "MeasureInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Měření";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox_measureInfo.ResumeLayout(false);
            groupBox_measureInfo.PerformLayout();
            ResumeLayout(false);

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
        private ErrorProvider errorProvider1;
        private GroupBox groupBox_measureInfo;
    }
}