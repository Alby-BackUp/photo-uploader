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
            this.lbl_service_id = new System.Windows.Forms.Label();
            this.rtb_errors = new System.Windows.Forms.RichTextBox();
            this.cmb_services = new System.Windows.Forms.ComboBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.lbl_photo_path = new System.Windows.Forms.Label();
            this.cmb_image_id = new System.Windows.Forms.ComboBox();
            this.lbl_images = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lbl_service_id
            //
            this.lbl_service_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_service_id.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_service_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_service_id.Location = new System.Drawing.Point(11, 56);
            this.lbl_service_id.Name = "lbl_service_id";
            this.lbl_service_id.Size = new System.Drawing.Size(200, 38);
            this.lbl_service_id.TabIndex = 46;
            this.lbl_service_id.Text = "Service Id:";
            //
            // rtb_errors
            //
            this.rtb_errors.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtb_errors.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rtb_errors.ForeColor = System.Drawing.Color.Blue;
            this.rtb_errors.Location = new System.Drawing.Point(216, 291);
            this.rtb_errors.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rtb_errors.Name = "rtb_errors";
            this.rtb_errors.Size = new System.Drawing.Size(617, 221);
            this.rtb_errors.TabIndex = 45;
            this.rtb_errors.Text = "";
            //
            // cmb_services
            //
            this.cmb_services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_services.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_services.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmb_services.FormattingEnabled = true;
            this.cmb_services.Location = new System.Drawing.Point(216, 53);
            this.cmb_services.Margin = new System.Windows.Forms.Padding(1);
            this.cmb_services.Name = "cmb_services";
            this.cmb_services.Size = new System.Drawing.Size(300, 31);
            this.cmb_services.TabIndex = 44;
            //
            // btn_create
            //
            this.btn_create.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_create.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_create.Enabled = false;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_create.ForeColor = System.Drawing.Color.Black;
            this.btn_create.Location = new System.Drawing.Point(533, 177);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(300, 38);
            this.btn_create.TabIndex = 43;
            this.btn_create.Text = "New";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            //
            // btn_open
            //
            this.btn_open.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_open.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_open.Enabled = false;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_open.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(216, 113);
            this.btn_open.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(300, 38);
            this.btn_open.TabIndex = 42;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            //
            // btn_delete
            //
            this.btn_delete.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(533, 235);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(300, 38);
            this.btn_delete.TabIndex = 43;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            //
            // btn_upload
            //
            this.btn_upload.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_upload.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_upload.Enabled = false;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_upload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_upload.ForeColor = System.Drawing.Color.Black;
            this.btn_upload.Location = new System.Drawing.Point(216, 235);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(300, 38);
            this.btn_upload.TabIndex = 43;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            //
            // lbl_photo_path
            //
            this.lbl_photo_path.BackColor = System.Drawing.Color.Transparent;
            this.lbl_photo_path.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_photo_path.ForeColor = System.Drawing.Color.Black;
            this.lbl_photo_path.Location = new System.Drawing.Point(11, 113);
            this.lbl_photo_path.Name = "lbl_photo_path";
            this.lbl_photo_path.Size = new System.Drawing.Size(200, 38);
            this.lbl_photo_path.TabIndex = 46;
            this.lbl_photo_path.Text = "Photo Path:";
            //
            // cmb_image_id
            //
            this.cmb_image_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_image_id.Enabled = false;
            this.cmb_image_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_image_id.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmb_image_id.FormattingEnabled = true;
            this.cmb_image_id.Location = new System.Drawing.Point(216, 180);
            this.cmb_image_id.Margin = new System.Windows.Forms.Padding(1);
            this.cmb_image_id.Name = "cmb_image_id";
            this.cmb_image_id.Size = new System.Drawing.Size(300, 31);
            this.cmb_image_id.TabIndex = 44;
            //
            // lbl_images
            //
            this.lbl_images.BackColor = System.Drawing.Color.Transparent;
            this.lbl_images.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_images.ForeColor = System.Drawing.Color.Black;
            this.lbl_images.Location = new System.Drawing.Point(11, 183);
            this.lbl_images.Name = "lbl_images";
            this.lbl_images.Size = new System.Drawing.Size(200, 38);
            this.lbl_images.TabIndex = 46;
            this.lbl_images.Text = "Image Id:";
            //
            // btn_reset
            //
            this.btn_reset.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(533, 531);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(300, 38);
            this.btn_reset.TabIndex = 47;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            //
            // Main
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(987, 631);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_images);
            this.Controls.Add(this.lbl_photo_path);
            this.Controls.Add(this.lbl_service_id);
            this.Controls.Add(this.rtb_errors);
            this.Controls.Add(this.cmb_image_id);
            this.Controls.Add(this.cmb_services);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_open);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Main";
            this.Text = "Zunet Photo Uploader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.ComboBox cmb_image_id;
        private System.Windows.Forms.ComboBox cmb_services;
        private System.Windows.Forms.Label lbl_images;
        private System.Windows.Forms.Label lbl_photo_path;
        private System.Windows.Forms.Label lbl_service_id;
        private System.Windows.Forms.RichTextBox rtb_errors;

        #endregion
    }
}
