using Microsoft.Build.BuildEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikátor
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (MainScreen.StudentsAmount == MainScreen.used.Count)
            {
                for (int i = 0; i < MainScreen.used.Count; i++)
                {
                    AttendanceList.Items.Add(MainScreen.used[i], true);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < AttendanceList.Items.Count; j++)
            {
                if (!AttendanceList.GetItemChecked(j))
                {
                    MainScreen.used.Remove(j + 1);
                    MainScreen.StudentsAmount--;
                }
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
