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
            this.txtBox_postNum = new System.Windows.Forms.TextBox();
            this.lbl_postNumber = new System.Windows.Forms.Label();
            this.txtBox_address = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_postNum
            // 
            this.txtBox_postNum.Location = new System.Drawing.Point(97, 70);
            this.txtBox_postNum.Name = "txtBox_postNum";
            this.txtBox_postNum.Size = new System.Drawing.Size(226, 23);
            this.txtBox_postNum.TabIndex = 22;
            // 
            // lbl_postNumber
            // 
            this.lbl_postNumber.AutoSize = true;
            this.lbl_postNumber.Location = new System.Drawing.Point(55, 73);
            this.lbl_postNumber.Name = "lbl_postNumber";
            this.lbl_postNumber.Size = new System.Drawing.Size(31, 15);
            this.lbl_postNumber.TabIndex = 21;
            this.lbl_postNumber.Text = "PSČ:";
            // 
            // txtBox_address
            // 
            this.txtBox_address.Location = new System.Drawing.Point(97, 41);
            this.txtBox_address.Name = "txtBox_address";
            this.txtBox_address.Size = new System.Drawing.Size(226, 23);
            this.txtBox_address.TabIndex = 20;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(248, 150);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(167, 150);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "OK";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(97, 12);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(226, 23);
            this.txtBox_name.TabIndex = 17;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(42, 44);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(46, 15);
            this.lbl_address.TabIndex = 16;
            this.lbl_address.Text = "Adresa:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(44, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 15);
            this.lbl_name.TabIndex = 15;
            this.lbl_name.Text = "Název:";
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(97, 99);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(226, 23);
            this.txtBox_id.TabIndex = 24;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(65, 102);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 15);
            this.lbl_id.TabIndex = 23;
            this.lbl_id.Text = "IČ:";
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtBox_postNum);
            this.Controls.Add(this.lbl_postNumber);
            this.Controls.Add(this.txtBox_address);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Name = "CustomerInfoForm";
            this.Text = "CustomerInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}