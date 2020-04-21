using System.ComponentModel;

namespace PhotoUploader.UserInterface
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.Button btn_Check;
            this.rtb_photo_path = new System.Windows.Forms.RichTextBox();
            this.rtb_service_id = new System.Windows.Forms.RichTextBox();
            this.lbl_service = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            btn_Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            btn_Check.DialogResult = System.Windows.Forms.DialogResult.No;
            btn_Check.Location = new System.Drawing.Point(99, 164);
            btn_Check.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new System.Drawing.Size(400, 44);
            btn_Check.TabIndex = 0;
            btn_Check.Text = "Upload";
            btn_Check.UseVisualStyleBackColor = true;
            btn_Check.Click += new System.EventHandler(this.btn_upload_Click);
            this.rtb_photo_path.Location = new System.Drawing.Point(99, 98);
            this.rtb_photo_path.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rtb_photo_path.Name = "rtb_photo_path";
            this.rtb_photo_path.Size = new System.Drawing.Size(400, 44);
            this.rtb_photo_path.TabIndex = 2;
            this.rtb_photo_path.Text = "";
            this.rtb_service_id.Location = new System.Drawing.Point(99, 36);
            this.rtb_service_id.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rtb_service_id.Name = "rtb_service_id";
            this.rtb_service_id.Size = new System.Drawing.Size(400, 44);
            this.rtb_service_id.TabIndex = 2;
            this.rtb_service_id.Text = "";
            this.lbl_service.Location = new System.Drawing.Point(0, 39);
            this.lbl_service.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(134, 61);
            this.lbl_service.TabIndex = 10;
            this.lbl_service.Text = "ServiceId";
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "PhotoPath";
            this.lbl_result.Location = new System.Drawing.Point(99, 229);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(400, 61);
            this.lbl_result.TabIndex = 12;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_photo_path);
            this.Controls.Add(this.rtb_service_id);
            this.Controls.Add(this.lbl_service);
            this.Controls.Add(btn_Check);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_service;
        private System.Windows.Forms.RichTextBox rtb_photo_path;
        private System.Windows.Forms.RichTextBox rtb_service_id;

        #endregion
    }
}
