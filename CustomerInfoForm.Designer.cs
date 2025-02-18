namespace ServisniProtokol
{
    partial class CustomerInfoForm
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
            txtBox_postNum = new TextBox();
            lbl_postNumber = new Label();
            txtBox_address = new TextBox();
            btn_cancel = new Button();
            btn_save = new Button();
            txtBox_name = new TextBox();
            lbl_address = new Label();
            lbl_name = new Label();
            txtBox_id = new TextBox();
            lbl_id = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox_customerInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox_customerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtBox_postNum
            // 
            txtBox_postNum.Font = new Font("Segoe UI", 9F);
            txtBox_postNum.Location = new Point(101, 102);
            txtBox_postNum.Name = "txtBox_postNum";
            txtBox_postNum.Size = new Size(226, 23);
            txtBox_postNum.TabIndex = 3;
            // 
            // lbl_postNumber
            // 
            lbl_postNumber.AutoSize = true;
            lbl_postNumber.Font = new Font("Segoe UI", 9F);
            lbl_postNumber.Location = new Point(59, 105);
            lbl_postNumber.Name = "lbl_postNumber";
            lbl_postNumber.Size = new Size(31, 15);
            lbl_postNumber.TabIndex = 21;
            lbl_postNumber.Text = "PSČ:";
            // 
            // txtBox_address
            // 
            txtBox_address.Font = new Font("Segoe UI", 9F);
            txtBox_address.Location = new Point(101, 73);
            txtBox_address.Name = "txtBox_address";
            txtBox_address.Size = new Size(226, 23);
            txtBox_address.TabIndex = 2;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 9F);
            btn_cancel.Location = new Point(190, 182);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Storno";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 9F);
            btn_save.Location = new Point(109, 182);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 5;
            btn_save.Text = "Uložit";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txtBox_name
            // 
            txtBox_name.Font = new Font("Segoe UI", 9F);
            txtBox_name.Location = new Point(101, 44);
            txtBox_name.Name = "txtBox_name";
            txtBox_name.Size = new Size(226, 23);
            txtBox_name.TabIndex = 1;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 9F);
            lbl_address.Location = new Point(46, 76);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(46, 15);
            lbl_address.TabIndex = 16;
            lbl_address.Text = "Adresa:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 9F);
            lbl_name.Location = new Point(48, 47);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(42, 15);
            lbl_name.TabIndex = 15;
            lbl_name.Text = "Název:";
            // 
            // txtBox_id
            // 
            txtBox_id.Font = new Font("Segoe UI", 9F);
            txtBox_id.Location = new Point(101, 131);
            txtBox_id.Name = "txtBox_id";
            txtBox_id.Size = new Size(226, 23);
            txtBox_id.TabIndex = 4;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 9F);
            lbl_id.Location = new Point(69, 134);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(21, 15);
            lbl_id.TabIndex = 23;
            lbl_id.Text = "IČ:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox_customerInfo
            // 
            groupBox_customerInfo.Controls.Add(txtBox_id);
            groupBox_customerInfo.Controls.Add(lbl_id);
            groupBox_customerInfo.Controls.Add(txtBox_postNum);
            groupBox_customerInfo.Controls.Add(lbl_postNumber);
            groupBox_customerInfo.Controls.Add(txtBox_address);
            groupBox_customerInfo.Controls.Add(btn_cancel);
            groupBox_customerInfo.Controls.Add(btn_save);
            groupBox_customerInfo.Controls.Add(txtBox_name);
            groupBox_customerInfo.Controls.Add(lbl_address);
            groupBox_customerInfo.Controls.Add(lbl_name);
            groupBox_customerInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox_customerInfo.Location = new Point(12, 21);
            groupBox_customerInfo.Name = "groupBox_customerInfo";
            groupBox_customerInfo.Size = new Size(383, 216);
            groupBox_customerInfo.TabIndex = 25;
            groupBox_customerInfo.TabStop = false;
            groupBox_customerInfo.Text = "Přidání zákaznických informací";
            // 
            // CustomerInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 256);
            Controls.Add(groupBox_customerInfo);
            Name = "CustomerInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zákaznické informace";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox_customerInfo.ResumeLayout(false);
            groupBox_customerInfo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TextBox txtBox_postNum;
        private Label lbl_postNumber;
        private TextBox txtBox_address;
        private Button btn_cancel;
        private Button btn_save;
        private TextBox txtBox_name;
        private Label lbl_address;
        private Label lbl_name;
        private TextBox txtBox_id;
        private Label lbl_id;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox_customerInfo;
    }
}