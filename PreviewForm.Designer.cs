namespace ServisniProtokol
{
    partial class PreviewForm
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
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(776, 407);
            this.pictureBox_preview.TabIndex = 0;
            this.pictureBox_preview.TabStop = false;
            this.pictureBox_preview.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_preview_Paint);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(713, 425);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Zavřít";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pictureBox_preview);
            this.Name = "PreviewForm";
            this.Text = "Náhled Tisku";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_preview;
        private Button btn_close;
    }
}