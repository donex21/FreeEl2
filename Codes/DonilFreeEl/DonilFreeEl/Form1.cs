using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace DonilFreeEl
{
    public partial class Form1 : Form
    {
        public static string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public Form1()
        {
            InitializeComponent();
        }

        private void articlesClassifierbutton_Click(object sender, EventArgs e)
        {
            if (!UserControlpanel.Controls.Contains(ArticleClassifierUserControl.Instance))
            {
                UserControlpanel.Controls.Add(ArticleClassifierUserControl.Instance);
                ArticleClassifierUserControl.Instance.Dock = DockStyle.Fill;
                ArticleClassifierUserControl.Instance.BringToFront();
            }
            else {
                ArticleClassifierUserControl.Instance.BringToFront();
            }
        }

        private void textCleaningbutton_Click(object sender, EventArgs e)
        {
            if (!UserControlpanel.Controls.Contains(TextCleaningUserControl.Instance))
            {
                UserControlpanel.Controls.Add(TextCleaningUserControl.Instance);
                TextCleaningUserControl.Instance.Dock = DockStyle.Fill;
                TextCleaningUserControl.Instance.BringToFront();
            }
            else {
                TextCleaningUserControl.Instance.BringToFront();
            }
        }

        private void bagsOfWordsButton_Click(object sender, EventArgs e)
        {
            if (!UserControlpanel.Controls.Contains(BagsOfWordsUsercontrol.Instance))
            {
                UserControlpanel.Controls.Add(BagsOfWordsUsercontrol.Instance);
                BagsOfWordsUsercontrol.Instance.Dock = DockStyle.Fill;
                BagsOfWordsUsercontrol.Instance.BringToFront();
            }
            else
            {
                BagsOfWordsUsercontrol.Instance.BringToFront();
            }
        }

        private void ArticlesDeviderbutton_Click(object sender, EventArgs e)
        {
            if (!UserControlpanel.Controls.Contains(FileDividerUserControl.Instance))
            {
                UserControlpanel.Controls.Add(FileDividerUserControl.Instance);
                FileDividerUserControl.Instance.Dock = DockStyle.Fill;
                FileDividerUserControl.Instance.BringToFront();
            }
            else
            {
                FileDividerUserControl.Instance.BringToFront();
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (!UserControlpanel.Controls.Contains(TestdataUserControl1.Instance))
            {
                UserControlpanel.Controls.Add(TestdataUserControl1.Instance);
                TestdataUserControl1.Instance.Dock = DockStyle.Fill;
                TestdataUserControl1.Instance.BringToFront();
            }
            else
            {
                TestdataUserControl1.Instance.BringToFront();
            }
        }

        private void UserInputbutton_Click(object sender, EventArgs e)
        {
            if (!UserControlpanel.Controls.Contains(UserInputText.Instance))
            {
                UserControlpanel.Controls.Add(UserInputText.Instance);
                UserInputText.Instance.Dock = DockStyle.Fill;
                UserInputText.Instance.BringToFront();
            }
            else
            {
                UserInputText.Instance.BringToFront();
            }
        }
    }
}
