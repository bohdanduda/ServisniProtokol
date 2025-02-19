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
            components = new System.ComponentModel.Container();
            pictureBox_preview = new PictureBox();
            btn_close = new Button();
            errorProvider1 = new ErrorProvider(components);
            btn_savePreview = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_preview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_preview
            // 
            pictureBox_preview.Location = new Point(12, 12);
            pictureBox_preview.Name = "pictureBox_preview";
            pictureBox_preview.Size = new Size(776, 407);
            pictureBox_preview.TabIndex = 0;
            pictureBox_preview.TabStop = false;
            pictureBox_preview.Paint += pictureBox_preview_Paint;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(408, 425);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(75, 23);
            btn_close.TabIndex = 1;
            btn_close.Text = "Zavřít";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_savePreview
            // 
            btn_savePreview.Location = new Point(317, 425);
            btn_savePreview.Name = "btn_savePreview";
            btn_savePreview.Size = new Size(75, 23);
            btn_savePreview.TabIndex = 2;
            btn_savePreview.Text = "Uložit";
            btn_savePreview.UseVisualStyleBackColor = true;
            btn_savePreview.Click += btn_savePreview_Click;
            // 
            // PreviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_savePreview);
            Controls.Add(btn_close);
            Controls.Add(pictureBox_preview);
            Name = "PreviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Náhled Tisku";
            ((System.ComponentModel.ISupportInitialize)pictureBox_preview).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_preview;
        private Button btn_close;
        private ErrorProvider errorProvider1;
        private Button btn_savePreview;
    }
}