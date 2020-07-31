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
    public partial class GroupsScreen : Form
    {
        public GroupsScreen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            switch (MainScreen.Group)
            {
                case true:
                    Randomize(MainScreen.GroupsAmount, MainScreen.StudentsAmount);
                    break;
                case false:
                    Randomize((MainScreen.StudentsAmount / MainScreen.AmountOfStudentsInGroup), MainScreen.StudentsAmount, true);
                    break;
            }
        }

        void Randomize(double ConditionOne, double ConditionTwo)
        {
            Randomize(ConditionOne, ConditionTwo, false);
        }

        void Randomize(double conditionOne, double conditionTwo, Boolean getTogether)
        {
            String randomNumbersString = String.Empty;
            Random RandomNum = new Random();
            var usedRandomized = Enumerable.Range(0, MainScreen.used.Count).OrderBy(x => RandomNum.Next()).Take(MainScreen.used.Count).ToList();
            int k = 0;
            int c2c1 = Convert.ToInt32(Math.Floor(conditionTwo / conditionOne));
            for (; k < conditionOne; k++)
            {
                for (int j = 0; j < c2c1; j++)
                {
                    randomNumbersString += MainScreen.used[(usedRandomized[((c2c1)*k)+j])] + " ";
                }
                listView1.Items.Add(new ListViewItem(new string[] { (k + 1).ToString(), randomNumbersString }));
                randomNumbersString = String.Empty;
            }
            if(conditionTwo % conditionOne != 0)
            {
                int StartingPointItem = Convert.ToInt32(conditionOne - (conditionTwo % conditionOne));
                int StartingIndex = Convert.ToInt32(conditionTwo - (conditionTwo % conditionOne));
                while (StartingIndex < conditionTwo)
                {
                    switch(getTogether)
                    {
                        case true:
                            randomNumbersString += MainScreen.used[(usedRandomized[StartingIndex])-1] + " ";
                            break;
                        case false:
                            listView1.Items[StartingPointItem].SubItems[1].Text += MainScreen.used[(usedRandomized[StartingIndex])];
                            break;
                    }
                    StartingIndex++;
                    if (!getTogether)
                    {
                        StartingPointItem++;
                    }
                }
                if(getTogether)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { (k + 1).ToString(), randomNumbersString }));
                }
                }
            }

        private void GroupsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainScreen NewForm = new MainScreen();
            NewForm.Show();
            this.Hide();
        }
    }
}

