 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace DonilFreeEl
{
    public partial class ArticleClassifierUserControl : UserControl
    {
        private static ArticleClassifierUserControl _instance;
        public static ArticleClassifierUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ArticleClassifierUserControl();
                return _instance;
            }
        }
        public ArticleClassifierUserControl()
        {
            InitializeComponent();
        }

        private void Openfilesbutton_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Form1.directoryPath;
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Form1.directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                foreach (string fileName in openFileDialog.FileNames)
                {
                    articlesListBox.Items.Add(fileName);
                }         
            }
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            ArticlesClassifierdataGridView.Rows.Clear();
            foreach (string passage in articlesListBox.Items)
            {
                using (StreamReader streamReader = new StreamReader(passage))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string nextLine = streamReader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(nextLine))
                        {
                            string[] column = nextLine.Split('|');
                            string line = column[0];
                            var index = ArticlesClassifierdataGridView.Rows.Add(line);
                            if (column.Length > 1)
                            {
                                if (column[1] == "positive" || column[1] == "negative" || column[1] == "neutral")
                                {
                                    ArticlesClassifierdataGridView.Rows[index].Cells[1].Value = column[1].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            articlesListBox.Items.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                articlesListBox.Items.Remove(articlesListBox.SelectedItem.ToString());
            }
            catch {
                MessageBox.Show("No files selected");
            }
        }

        bool isDropdownOpen = false;
        private void exportLabel_Click(object sender, EventArgs e)
        {
            exportTimer.Start();
        }

        private void exportTimer_Tick(object sender, EventArgs e)
        {
            if(isDropdownOpen)
            {
                dropDownPanel.Height -= 20;
                if(dropDownPanel.Height == 0)
                {
                    exportTimer.Stop();
                    isDropdownOpen = false;
                }
            }
            else if (!isDropdownOpen)
            {
                dropDownPanel.Height += 20;
                if (dropDownPanel.Height == 100)
                {
                    exportTimer.Stop();
                    isDropdownOpen = true;
                }
            }
        }


        private void exportFiles(string feedback)
        {
            if (ArticlesClassifierdataGridView.RowCount > 0)
            {
                if (cellNotEqualNull())
                {
                    saveFileDialog.InitialDirectory = Form1.directoryPath;
                    saveFileDialog.Title = "Browse Text Files";
                    saveFileDialog.DefaultExt = "txt";
                    saveFileDialog.CheckPathExists = true;
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Form1.directoryPath = Path.GetDirectoryName(saveFileDialog.FileName);
                        string output = "";
                        foreach (DataGridViewRow row in ArticlesClassifierdataGridView.Rows)
                        {
                            if (feedback == row.Cells[1].Value.ToString())
                            {
                                if (output != "")
                                     output += "\n";
                                output += row.Cells[0].Value.ToString() + "|" + row.Cells[1].Value.ToString() + Environment.NewLine;         
                            }
                        }
                        using (StreamWriter textwriter = new StreamWriter(saveFileDialog.FileName))
                        {
                            textwriter.Write(output);
                            MessageBox.Show("Successfully Saved!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("lacking of feedback classification");
                }
            }
        }

        //check all the classification if all the statements have feedback. 
        private bool cellNotEqualNull()
        {
            foreach (DataGridViewRow row in ArticlesClassifierdataGridView.Rows)
            {
                if (row.Cells[1].Value == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void positiveLabel_Click(object sender, EventArgs e)
        {
             exportFiles("positive");
        }

        private void negativeLabel_Click(object sender, EventArgs e)
        {
            exportFiles("negative");
        }

        private void neutralLabel_Click(object sender, EventArgs e)
        {
            exportFiles("neutral");
        }

       
    }
}
