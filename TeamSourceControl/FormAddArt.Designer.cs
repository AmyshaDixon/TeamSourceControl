﻿namespace TeamSourceControl {
    partial class FormAddArt {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbRequired = new System.Windows.Forms.GroupBox();
            this.gbOptional = new System.Windows.Forms.GroupBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbArtURL = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateDisplayed = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblIsInteractive = new System.Windows.Forms.Label();
            this.lblTargetedAgeRange = new System.Windows.Forms.Label();
            this.lblArtURL = new System.Windows.Forms.Label();
            this.lblDateRemoved = new System.Windows.Forms.Label();
            this.lblDateAvailableForSale = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtpDisplayed = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.dtpCreated = new System.Windows.Forms.DateTimePicker();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.cbInteractive = new System.Windows.Forms.ComboBox();
            this.cbAgeRange = new System.Windows.Forms.ComboBox();
            this.dtpRemoved = new System.Windows.Forms.DateTimePicker();
            this.dtpSale = new System.Windows.Forms.DateTimePicker();
            this.gbRequired.SuspendLayout();
            this.gbOptional.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRequired
            // 
            this.gbRequired.Controls.Add(this.cbAgeRange);
            this.gbRequired.Controls.Add(this.cbInteractive);
            this.gbRequired.Controls.Add(this.cbStyle);
            this.gbRequired.Controls.Add(this.dtpCreated);
            this.gbRequired.Controls.Add(this.dtpArrival);
            this.gbRequired.Controls.Add(this.dtpDisplayed);
            this.gbRequired.Controls.Add(this.lblArtURL);
            this.gbRequired.Controls.Add(this.lblTargetedAgeRange);
            this.gbRequired.Controls.Add(this.lblIsInteractive);
            this.gbRequired.Controls.Add(this.lblStyle);
            this.gbRequired.Controls.Add(this.lblDateCreated);
            this.gbRequired.Controls.Add(this.lblArrivalDate);
            this.gbRequired.Controls.Add(this.lblDateDisplayed);
            this.gbRequired.Controls.Add(this.lblTitle);
            this.gbRequired.Controls.Add(this.tbArtURL);
            this.gbRequired.Controls.Add(this.tbTitle);
            this.gbRequired.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRequired.Location = new System.Drawing.Point(38, 56);
            this.gbRequired.Name = "gbRequired";
            this.gbRequired.Size = new System.Drawing.Size(517, 395);
            this.gbRequired.TabIndex = 0;
            this.gbRequired.TabStop = false;
            this.gbRequired.Text = "Required";
            // 
            // gbOptional
            // 
            this.gbOptional.Controls.Add(this.dtpSale);
            this.gbOptional.Controls.Add(this.dtpRemoved);
            this.gbOptional.Controls.Add(this.lblDescription);
            this.gbOptional.Controls.Add(this.lblPrice);
            this.gbOptional.Controls.Add(this.lblDateAvailableForSale);
            this.gbOptional.Controls.Add(this.lblDateRemoved);
            this.gbOptional.Controls.Add(this.tbDescription);
            this.gbOptional.Controls.Add(this.tbPrice);
            this.gbOptional.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptional.Location = new System.Drawing.Point(597, 56);
            this.gbOptional.Name = "gbOptional";
            this.gbOptional.Size = new System.Drawing.Size(517, 395);
            this.gbOptional.TabIndex = 1;
            this.gbOptional.TabStop = false;
            this.gbOptional.Text = "Optional";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(207, 33);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(200, 29);
            this.tbTitle.TabIndex = 0;
            // 
            // tbArtURL
            // 
            this.tbArtURL.Location = new System.Drawing.Point(207, 337);
            this.tbArtURL.Name = "tbArtURL";
            this.tbArtURL.Size = new System.Drawing.Size(200, 29);
            this.tbArtURL.TabIndex = 7;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(204, 209);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 29);
            this.tbPrice.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(204, 275);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(200, 29);
            this.tbDescription.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(142, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 22);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // lblDateDisplayed
            // 
            this.lblDateDisplayed.AutoSize = true;
            this.lblDateDisplayed.Location = new System.Drawing.Point(67, 80);
            this.lblDateDisplayed.Name = "lblDateDisplayed";
            this.lblDateDisplayed.Size = new System.Drawing.Size(114, 22);
            this.lblDateDisplayed.TabIndex = 9;
            this.lblDateDisplayed.Text = "Date Displayed";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Location = new System.Drawing.Point(88, 124);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(93, 22);
            this.lblArrivalDate.TabIndex = 10;
            this.lblArrivalDate.Text = "Arrival Date";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(10, 168);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(171, 22);
            this.lblDateCreated.TabIndex = 11;
            this.lblDateCreated.Text = "Date Created (by Artist)";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(137, 212);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(44, 22);
            this.lblStyle.TabIndex = 12;
            this.lblStyle.Text = "Style";
            // 
            // lblIsInteractive
            // 
            this.lblIsInteractive.AutoSize = true;
            this.lblIsInteractive.Location = new System.Drawing.Point(78, 256);
            this.lblIsInteractive.Name = "lblIsInteractive";
            this.lblIsInteractive.Size = new System.Drawing.Size(103, 22);
            this.lblIsInteractive.TabIndex = 13;
            this.lblIsInteractive.Text = "Is Interactive?";
            // 
            // lblTargetedAgeRange
            // 
            this.lblTargetedAgeRange.AutoSize = true;
            this.lblTargetedAgeRange.Location = new System.Drawing.Point(35, 300);
            this.lblTargetedAgeRange.Name = "lblTargetedAgeRange";
            this.lblTargetedAgeRange.Size = new System.Drawing.Size(146, 22);
            this.lblTargetedAgeRange.TabIndex = 14;
            this.lblTargetedAgeRange.Text = "Targeted Age Range";
            // 
            // lblArtURL
            // 
            this.lblArtURL.AutoSize = true;
            this.lblArtURL.Location = new System.Drawing.Point(65, 340);
            this.lblArtURL.Name = "lblArtURL";
            this.lblArtURL.Size = new System.Drawing.Size(116, 22);
            this.lblArtURL.TabIndex = 15;
            this.lblArtURL.Text = "Art Image URL";
            // 
            // lblDateRemoved
            // 
            this.lblDateRemoved.AutoSize = true;
            this.lblDateRemoved.Location = new System.Drawing.Point(78, 83);
            this.lblDateRemoved.Name = "lblDateRemoved";
            this.lblDateRemoved.Size = new System.Drawing.Size(109, 22);
            this.lblDateRemoved.TabIndex = 4;
            this.lblDateRemoved.Text = "Date Removed";
            // 
            // lblDateAvailableForSale
            // 
            this.lblDateAvailableForSale.AutoSize = true;
            this.lblDateAvailableForSale.Location = new System.Drawing.Point(17, 149);
            this.lblDateAvailableForSale.Name = "lblDateAvailableForSale";
            this.lblDateAvailableForSale.Size = new System.Drawing.Size(170, 22);
            this.lblDateAvailableForSale.TabIndex = 5;
            this.lblDateAvailableForSale.Text = "Date Avaialable for Sale";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(143, 212);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 22);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(100, 278);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 22);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(481, 467);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(193, 59);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // dtpDisplayed
            // 
            this.dtpDisplayed.Location = new System.Drawing.Point(207, 76);
            this.dtpDisplayed.MaxDate = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            this.dtpDisplayed.Name = "dtpDisplayed";
            this.dtpDisplayed.Size = new System.Drawing.Size(268, 29);
            this.dtpDisplayed.TabIndex = 16;
            this.dtpDisplayed.Value = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            // 
            // dtpArrival
            // 
            this.dtpArrival.Location = new System.Drawing.Point(207, 119);
            this.dtpArrival.MaxDate = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(268, 29);
            this.dtpArrival.TabIndex = 17;
            this.dtpArrival.Value = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            // 
            // dtpCreated
            // 
            this.dtpCreated.Location = new System.Drawing.Point(207, 162);
            this.dtpCreated.MaxDate = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(268, 29);
            this.dtpCreated.TabIndex = 18;
            this.dtpCreated.Value = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(207, 205);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(200, 30);
            this.cbStyle.TabIndex = 19;
            // 
            // cbInteractive
            // 
            this.cbInteractive.FormattingEnabled = true;
            this.cbInteractive.Location = new System.Drawing.Point(207, 249);
            this.cbInteractive.Name = "cbInteractive";
            this.cbInteractive.Size = new System.Drawing.Size(200, 30);
            this.cbInteractive.TabIndex = 20;
            // 
            // cbAgeRange
            // 
            this.cbAgeRange.FormattingEnabled = true;
            this.cbAgeRange.Location = new System.Drawing.Point(207, 293);
            this.cbAgeRange.Name = "cbAgeRange";
            this.cbAgeRange.Size = new System.Drawing.Size(200, 30);
            this.cbAgeRange.TabIndex = 21;
            // 
            // dtpRemoved
            // 
            this.dtpRemoved.Location = new System.Drawing.Point(204, 77);
            this.dtpRemoved.MaxDate = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            this.dtpRemoved.Name = "dtpRemoved";
            this.dtpRemoved.Size = new System.Drawing.Size(268, 29);
            this.dtpRemoved.TabIndex = 8;
            this.dtpRemoved.Value = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            // 
            // dtpSale
            // 
            this.dtpSale.Location = new System.Drawing.Point(204, 143);
            this.dtpSale.MaxDate = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            this.dtpSale.Name = "dtpSale";
            this.dtpSale.Size = new System.Drawing.Size(268, 29);
            this.dtpSale.TabIndex = 9;
            this.dtpSale.Value = new System.DateTime(2018, 8, 17, 0, 0, 0, 0);
            // 
            // FormAddArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 558);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbOptional);
            this.Controls.Add(this.gbRequired);
            this.Name = "FormAddArt";
            this.Text = "FormAddArt";
            this.gbRequired.ResumeLayout(false);
            this.gbRequired.PerformLayout();
            this.gbOptional.ResumeLayout(false);
            this.gbOptional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRequired;
        private System.Windows.Forms.GroupBox gbOptional;
        private System.Windows.Forms.TextBox tbArtURL;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblArtURL;
        private System.Windows.Forms.Label lblTargetedAgeRange;
        private System.Windows.Forms.Label lblIsInteractive;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDateDisplayed;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDateAvailableForSale;
        private System.Windows.Forms.Label lblDateRemoved;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.DateTimePicker dtpDisplayed;
        private System.Windows.Forms.DateTimePicker dtpCreated;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.ComboBox cbInteractive;
        private System.Windows.Forms.ComboBox cbAgeRange;
        private System.Windows.Forms.DateTimePicker dtpSale;
        private System.Windows.Forms.DateTimePicker dtpRemoved;
    }
}