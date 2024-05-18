namespace SoftwareLocker
{
    partial class frmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialog));
            this.sebBaseString = new SerialBox.SerialBox();
            this.sebPassword = new SerialBox.SerialBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblComment = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnTrial = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sebBaseString
            // 
            this.sebBaseString.CaptleLettersOnly = true;
            this.sebBaseString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sebBaseString.Location = new System.Drawing.Point(9, 53);
            this.sebBaseString.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sebBaseString.Name = "sebBaseString";
            this.sebBaseString.ReadOnly = true;
            this.sebBaseString.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sebBaseString.Size = new System.Drawing.Size(397, 25);
            this.sebBaseString.TabIndex = 2;
            // 
            // sebPassword
            // 
            this.sebPassword.CaptleLettersOnly = true;
            this.sebPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sebPassword.Location = new System.Drawing.Point(9, 87);
            this.sebPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sebPassword.Name = "sebPassword";
            this.sebPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sebPassword.Size = new System.Drawing.Size(397, 32);
            this.sebPassword.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.lblComment);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(529, 440);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = " Ã—»… Ê ›⁄Ì· «·„‰ŸÊ„…";
            // 
            // lblComment
            // 
            this.lblComment.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.Red;
            this.lblComment.Location = new System.Drawing.Point(7, 49);
            this.lblComment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(516, 62);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Â–Â «·„‰ŸÊ„… €Ì— „Ã«‰Ì… ÊÌ„ﬂ‰  Ã—» Â« ·› —… „ÕœÊœ… . »⁄œÂ« ÌÃ» «·Õ’Ê· ⁄·Ï ﬂÊœ «· " +
    "›⁄Ì· · ‘€Ì· «·„‰ŸÊ„… ·› —… €Ì— „ÕœÊœ….";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnOK);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.sebPassword);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.sebBaseString);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(13, 114);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(505, 177);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = " ›⁄Ì· «·„‰ŸÊ„…";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "· ›⁄Ì· «·„‰ŸÊ„… ÌÃ» «—”«· „⁄—› ··ÃÂ«“ ··Õ’Ê· ⁄·Ï ﬂÊœ «· ›⁄Ì·";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(404, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "„⁄—› «·ÃÂ«“";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(404, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "ﬂÊœ «· ›⁄Ì·";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Appearance.Options.UseTextOptions = true;
            this.btnOK.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage1")));
            this.btnOK.Location = new System.Drawing.Point(182, 127);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 33);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = " ›‹‹‹⁄Ì·";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.lbldays);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.btnTrial);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(13, 297);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(503, 129);
            this.groupControl3.TabIndex = 10;
            this.groupControl3.Text = " Ã—»… «·„‰ŸÊ„…";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // btnTrial
            // 
            this.btnTrial.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrial.Appearance.Options.UseFont = true;
            this.btnTrial.Appearance.Options.UseTextOptions = true;
            this.btnTrial.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnTrial.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnTrial.Location = new System.Drawing.Point(182, 81);
            this.btnTrial.Name = "btnTrial";
            this.btnTrial.Size = new System.Drawing.Size(96, 33);
            this.btnTrial.TabIndex = 9;
            this.btnTrial.Text = " Ã—Ì‹‹‹»";
            this.btnTrial.Click += new System.EventHandler(this.btnTrial_Click_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(92, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "„·«ÕŸ… : Ì—ÃÏ ⁄œ„  €ÌÌ—  «—ÌŒ «·ÃÂ«“ ⁄‰œ  Ã—»… «·„‰ŸÊ„… ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(323, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "⁄œœ «·√Ì«„ «·„ »ﬁÌ… ·· Ã—Ì» :";
            // 
            // lbldays
            // 
            this.lbldays.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.ForeColor = System.Drawing.Color.Red;
            this.lbldays.Location = new System.Drawing.Point(286, 51);
            this.lbldays.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(37, 27);
            this.lbldays.TabIndex = 12;
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 448);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ›⁄Ì· «·„‰ŸÊ„…";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SerialBox.SerialBox sebBaseString;
        private SerialBox.SerialBox sebPassword;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblComment;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnTrial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label label4;
    }
}