namespace Matematikátor
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.AttendanceList = new System.Windows.Forms.CheckedListBox();
            this.AttendanceTitle = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AttendanceList
            // 
            this.AttendanceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttendanceList.FormattingEnabled = true;
            this.AttendanceList.Location = new System.Drawing.Point(13, 58);
            this.AttendanceList.Name = "AttendanceList";
            this.AttendanceList.Size = new System.Drawing.Size(388, 424);
            this.AttendanceList.TabIndex = 0;
            // 
            // AttendanceTitle
            // 
            this.AttendanceTitle.AutoSize = true;
            this.AttendanceTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttendanceTitle.Location = new System.Drawing.Point(12, 9);
            this.AttendanceTitle.Name = "AttendanceTitle";
            this.AttendanceTitle.Size = new System.Drawing.Size(107, 33);
            this.AttendanceTitle.TabIndex = 2;
            this.AttendanceTitle.Text = "Absence";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(294, 503);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 38);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Zrušit";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(181, 503);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 38);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Uložit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 547);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AttendanceTitle);
            this.Controls.Add(this.AttendanceList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Attendance";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox AttendanceList;
        private System.Windows.Forms.Label AttendanceTitle;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}