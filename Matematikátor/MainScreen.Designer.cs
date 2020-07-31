namespace Matematikátor
{
    partial class MainScreen
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Attendance = new System.Windows.Forms.Button();
            this.Výběr = new System.Windows.Forms.GroupBox();
            this.AmountOfStudentsInGroupRB = new System.Windows.Forms.RadioButton();
            this.GroupsAmountRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountOfStudentsInGroupNumUD = new System.Windows.Forms.NumericUpDown();
            this.GroupsAmountNumUD = new System.Windows.Forms.NumericUpDown();
            this.SplitToGroups = new System.Windows.Forms.Button();
            this.StudentsAmountNumUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.záložky = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.Výběr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfStudentsInGroupNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsAmountNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsAmountNumUD)).BeginInit();
            this.záložky.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matematikátor ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Náhodný zařazovač do skupin";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Attendance);
            this.tabPage1.Controls.Add(this.Výběr);
            this.tabPage1.Controls.Add(this.SplitToGroups);
            this.tabPage1.Controls.Add(this.StudentsAmountNumUD);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skupiny";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Attendance
            // 
            this.Attendance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Attendance.Location = new System.Drawing.Point(228, 32);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(148, 35);
            this.Attendance.TabIndex = 14;
            this.Attendance.Text = "Absence";
            this.Attendance.UseVisualStyleBackColor = true;
            this.Attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // Výběr
            // 
            this.Výběr.Controls.Add(this.AmountOfStudentsInGroupRB);
            this.Výběr.Controls.Add(this.GroupsAmountRB);
            this.Výběr.Controls.Add(this.label4);
            this.Výběr.Controls.Add(this.label5);
            this.Výběr.Controls.Add(this.AmountOfStudentsInGroupNumUD);
            this.Výběr.Controls.Add(this.GroupsAmountNumUD);
            this.Výběr.Location = new System.Drawing.Point(12, 69);
            this.Výběr.Name = "Výběr";
            this.Výběr.Size = new System.Drawing.Size(265, 143);
            this.Výběr.TabIndex = 13;
            this.Výběr.TabStop = false;
            // 
            // AmountOfStudentsInGroupRB
            // 
            this.AmountOfStudentsInGroupRB.AutoSize = true;
            this.AmountOfStudentsInGroupRB.Location = new System.Drawing.Point(17, 90);
            this.AmountOfStudentsInGroupRB.Name = "AmountOfStudentsInGroupRB";
            this.AmountOfStudentsInGroupRB.Size = new System.Drawing.Size(14, 13);
            this.AmountOfStudentsInGroupRB.TabIndex = 13;
            this.AmountOfStudentsInGroupRB.TabStop = true;
            this.AmountOfStudentsInGroupRB.UseVisualStyleBackColor = true;
            this.AmountOfStudentsInGroupRB.CheckedChanged += new System.EventHandler(this.AmountOfStudentsInGroupRB_CheckedChanged);
            // 
            // GroupsAmountRB
            // 
            this.GroupsAmountRB.AutoSize = true;
            this.GroupsAmountRB.Location = new System.Drawing.Point(17, 25);
            this.GroupsAmountRB.Name = "GroupsAmountRB";
            this.GroupsAmountRB.Size = new System.Drawing.Size(14, 13);
            this.GroupsAmountRB.TabIndex = 12;
            this.GroupsAmountRB.TabStop = true;
            this.GroupsAmountRB.UseVisualStyleBackColor = true;
            this.GroupsAmountRB.CheckedChanged += new System.EventHandler(this.GroupsAmountRB_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Počet skupin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(38, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Počet členů ve skupině:";
            // 
            // AmountOfStudentsInGroupNumUD
            // 
            this.AmountOfStudentsInGroupNumUD.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AmountOfStudentsInGroupNumUD.Location = new System.Drawing.Point(43, 110);
            this.AmountOfStudentsInGroupNumUD.Name = "AmountOfStudentsInGroupNumUD";
            this.AmountOfStudentsInGroupNumUD.ReadOnly = true;
            this.AmountOfStudentsInGroupNumUD.Size = new System.Drawing.Size(201, 25);
            this.AmountOfStudentsInGroupNumUD.TabIndex = 11;
            this.AmountOfStudentsInGroupNumUD.ValueChanged += new System.EventHandler(this.AmountOfStudentsInGroupNumUD_ValueChanged);
            // 
            // GroupsAmountNumUD
            // 
            this.GroupsAmountNumUD.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupsAmountNumUD.Location = new System.Drawing.Point(43, 45);
            this.GroupsAmountNumUD.Name = "GroupsAmountNumUD";
            this.GroupsAmountNumUD.ReadOnly = true;
            this.GroupsAmountNumUD.Size = new System.Drawing.Size(201, 25);
            this.GroupsAmountNumUD.TabIndex = 10;
            this.GroupsAmountNumUD.ValueChanged += new System.EventHandler(this.GroupsAmountNumUD_ValueChanged);
            // 
            // SplitToGroups
            // 
            this.SplitToGroups.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SplitToGroups.Location = new System.Drawing.Point(12, 218);
            this.SplitToGroups.Name = "SplitToGroups";
            this.SplitToGroups.Size = new System.Drawing.Size(200, 37);
            this.SplitToGroups.TabIndex = 12;
            this.SplitToGroups.Text = "Rozdělit do skupin!";
            this.SplitToGroups.UseVisualStyleBackColor = true;
            this.SplitToGroups.Click += new System.EventHandler(this.SplitToGroups_Click);
            // 
            // StudentsAmountNumUD
            // 
            this.StudentsAmountNumUD.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentsAmountNumUD.Location = new System.Drawing.Point(11, 38);
            this.StudentsAmountNumUD.Name = "StudentsAmountNumUD";
            this.StudentsAmountNumUD.Size = new System.Drawing.Size(201, 25);
            this.StudentsAmountNumUD.TabIndex = 9;
            this.StudentsAmountNumUD.ValueChanged += new System.EventHandler(this.StudentsAmountNumUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Počet žáků:";
            // 
            // záložky
            // 
            this.záložky.Controls.Add(this.tabPage1);
            this.záložky.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.záložky.Location = new System.Drawing.Point(12, 74);
            this.záložky.Name = "záložky";
            this.záložky.SelectedIndex = 0;
            this.záložky.Size = new System.Drawing.Size(390, 310);
            this.záložky.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.záložky);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Matematikátor 1.0";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Výběr.ResumeLayout(false);
            this.Výběr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfStudentsInGroupNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsAmountNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsAmountNumUD)).EndInit();
            this.záložky.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Attendance;
        private System.Windows.Forms.GroupBox Výběr;
        private System.Windows.Forms.RadioButton AmountOfStudentsInGroupRB;
        private System.Windows.Forms.RadioButton GroupsAmountRB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AmountOfStudentsInGroupNumUD;
        private System.Windows.Forms.NumericUpDown GroupsAmountNumUD;
        private System.Windows.Forms.Button SplitToGroups;
        private System.Windows.Forms.NumericUpDown StudentsAmountNumUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl záložky;
    }
}

