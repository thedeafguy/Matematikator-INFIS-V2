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
    public partial class MainScreen : Form
    {
        public static int StudentsAmount;
        public static int GroupsAmount;
        public static int AmountOfStudentsInGroup;
        public static Boolean Group;
        public static Boolean Members;
        public static List<int> used = new List<int>();
        public static int OriginalAmount;
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void GroupsAmountRB_CheckedChanged(object sender, EventArgs e)
        {
            GroupsAmountNumUD.ReadOnly = !GroupsAmountRB.Checked;
        }

        private void AmountOfStudentsInGroupRB_CheckedChanged(object sender, EventArgs e)
        {
            AmountOfStudentsInGroupNumUD.ReadOnly = !AmountOfStudentsInGroupRB.Checked;
        }
        public void Checker()
        {
            Group = GroupsAmountRB.Checked;
            Members = AmountOfStudentsInGroupRB.Checked;
        }

        public static void NumbersAdd()
        {
            if (used.Count == 0)
            {
                for (int l = 1; l <= MainScreen.StudentsAmount; l++)
                {
                    used.Add(l);
                }
            }
        }

        private void StudentsAmountNumUD_ValueChanged(object sender, EventArgs e)
        {
            StudentsAmount = (int)StudentsAmountNumUD.Value;
        }

        private void GroupsAmountNumUD_ValueChanged(object sender, EventArgs e)
        {
            GroupsAmount = (int)GroupsAmountNumUD.Value;
        }

        private void AmountOfStudentsInGroupNumUD_ValueChanged(object sender, EventArgs e)
        {
            AmountOfStudentsInGroup = (int)AmountOfStudentsInGroupNumUD.Value;
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            if (MainScreen.StudentsAmount != MainScreen.used.Count && MainScreen.StudentsAmount > 0)
            {
                MainScreen.used.Clear();
            }
            MainScreen.NumbersAdd();
            switch (MainScreen.StudentsAmount > 0)
            {
                case true:
                    Form thirdForm = new Attendance();
                    thirdForm.Show();
                    break;
                case false:
                    MessageBox.Show("Zkontrolujte pole Počet žáků!", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            OriginalAmount = (int)StudentsAmountNumUD.Value;
        }

        private void SplitToGroups_Click(object sender, EventArgs e)
        {
            switch (((StudentsAmount >= GroupsAmount && GroupsAmountRB.Checked && GroupsAmount > 0) || (StudentsAmount >= AmountOfStudentsInGroup && AmountOfStudentsInGroupRB.Checked && AmountOfStudentsInGroup > 0)))
            {
                case true:
                    Checker();
                    NumbersAdd();
                    GroupsScreen open = new GroupsScreen();
                    open.Show();
                    this.Hide();
                    break;
                case false:
                    MessageBox.Show("Zkontrolujte správnost všech polí!", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
