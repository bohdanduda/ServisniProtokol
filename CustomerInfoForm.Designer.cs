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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtBox_postNum
            // 
            txtBox_postNum.Location = new Point(64, 67);
            txtBox_postNum.Name = "txtBox_postNum";
            txtBox_postNum.Size = new Size(226, 23);
            txtBox_postNum.TabIndex = 22;
            // 
            // lbl_postNumber
            // 
            lbl_postNumber.AutoSize = true;
            lbl_postNumber.Location = new Point(22, 70);
            lbl_postNumber.Name = "lbl_postNumber";
            lbl_postNumber.Size = new Size(31, 15);
            lbl_postNumber.TabIndex = 21;
            lbl_postNumber.Text = "PSČ:";
            // 
            // txtBox_address
            // 
            txtBox_address.Location = new Point(64, 38);
            txtBox_address.Name = "txtBox_address";
            txtBox_address.Size = new Size(226, 23);
            txtBox_address.TabIndex = 20;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(215, 147);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 19;
            btn_cancel.Text = "STORNO";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(134, 147);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 18;
            btn_save.Text = "OK";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txtBox_name
            // 
            txtBox_name.Location = new Point(64, 9);
            txtBox_name.Name = "txtBox_name";
            txtBox_name.Size = new Size(226, 23);
            txtBox_name.TabIndex = 17;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(9, 41);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(46, 15);
            lbl_address.TabIndex = 16;
            lbl_address.Text = "Adresa:";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(11, 12);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(42, 15);
            lbl_name.TabIndex = 15;
            lbl_name.Text = "Název:";
            // 
            // txtBox_id
            // 
            txtBox_id.Location = new Point(64, 96);
            txtBox_id.Name = "txtBox_id";
            txtBox_id.Size = new Size(226, 23);
            txtBox_id.TabIndex = 24;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(32, 99);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(21, 15);
            lbl_id.TabIndex = 23;
            lbl_id.Text = "IČ:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 181);
            Controls.Add(txtBox_id);
            Controls.Add(lbl_id);
            Controls.Add(txtBox_postNum);
            Controls.Add(lbl_postNumber);
            Controls.Add(txtBox_address);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txtBox_name);
            Controls.Add(lbl_address);
            Controls.Add(lbl_name);
            Name = "CustomerInfoForm";
            Text = "CustomerInfoForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
    }
}