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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_isValid
            // 
            lbl_isValid.AutoSize = true;
            lbl_isValid.Location = new Point(58, 102);
            lbl_isValid.Name = "lbl_isValid";
            lbl_isValid.Size = new Size(59, 15);
            lbl_isValid.TabIndex = 33;
            lbl_isValid.Text = "Vyhovuje:";
            // 
            // txtBox_unit
            // 
            txtBox_unit.Location = new Point(121, 70);
            txtBox_unit.Name = "txtBox_unit";
            txtBox_unit.Size = new Size(226, 23);
            txtBox_unit.TabIndex = 32;
            // 
            // lbl_unit
            // 
            lbl_unit.AutoSize = true;
            lbl_unit.Location = new Point(58, 73);
            lbl_unit.Name = "lbl_unit";
            lbl_unit.Size = new Size(57, 15);
            lbl_unit.TabIndex = 31;
            lbl_unit.Text = "Jednotka:";
            // 
            // txtBox_measuredUnit
            // 
            txtBox_measuredUnit.Location = new Point(121, 41);
            txtBox_measuredUnit.Name = "txtBox_measuredUnit";
            txtBox_measuredUnit.Size = new Size(226, 23);
            txtBox_measuredUnit.TabIndex = 30;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(272, 146);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 29;
            btn_cancel.Text = "STORNO";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(191, 146);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 28;
            btn_save.Text = "OK";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txtBox_paramName
            // 
            txtBox_paramName.Location = new Point(121, 12);
            txtBox_paramName.Name = "txtBox_paramName";
            txtBox_paramName.Size = new Size(226, 23);
            txtBox_paramName.TabIndex = 27;
            // 
            // lbl_measuredUnit
            // 
            lbl_measuredUnit.AutoSize = true;
            lbl_measuredUnit.Location = new Point(0, 44);
            lbl_measuredUnit.Name = "lbl_measuredUnit";
            lbl_measuredUnit.Size = new Size(115, 15);
            lbl_measuredUnit.TabIndex = 26;
            lbl_measuredUnit.Text = "Naměřená Jednotka:";
            // 
            // lbl_paramName
            // 
            lbl_paramName.AutoSize = true;
            lbl_paramName.Location = new Point(15, 15);
            lbl_paramName.Name = "lbl_paramName";
            lbl_paramName.Size = new Size(100, 15);
            lbl_paramName.TabIndex = 25;
            lbl_paramName.Text = "Název Parametru:";
            // 
            // chckBox_isValid
            // 
            chckBox_isValid.AutoSize = true;
            chckBox_isValid.Location = new Point(123, 103);
            chckBox_isValid.Name = "chckBox_isValid";
            chckBox_isValid.Size = new Size(15, 14);
            chckBox_isValid.TabIndex = 34;
            chckBox_isValid.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MeasureInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 187);
            Controls.Add(chckBox_isValid);
            Controls.Add(lbl_isValid);
            Controls.Add(txtBox_unit);
            Controls.Add(lbl_unit);
            Controls.Add(txtBox_measuredUnit);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txtBox_paramName);
            Controls.Add(lbl_measuredUnit);
            Controls.Add(lbl_paramName);
            Name = "MeasureInfoForm";
            Text = "MeasureInfoForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
    }
}