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
    public partial class TextCleaningUserControl : UserControl
    {
        private static TextCleaningUserControl _instance;
        public static TextCleaningUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TextCleaningUserControl();
                return _instance;
            }
        }
        public TextCleaningUserControl()
        {
            InitializeComponent();
        }

        private void stopWordsbutton_Click(object sender, EventArgs e)
        {
            openFileDialogTextCleaning.Multiselect = true;
            openFileDialogTextCleaning.InitialDirectory = Form1.directoryPath;
            openFileDialogTextCleaning.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialogTextCleaning.ShowDialog(this) == DialogResult.OK)
            {
                Form1.directoryPath = Path.GetDirectoryName(openFileDialogTextCleaning.FileName);
                foreach (string fileName in openFileDialogTextCleaning.FileNames)
                {
                    using (StreamReader streamReader = new StreamReader(fileName))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            stopWordslListBox.Items.Add(streamReader.ReadLine());
                        }
                    }
                }
            }
        }

        private void articleCleaningButton_Click(object sender, EventArgs e)
        {
            openFileDialogTextCleaning.Multiselect = true;
            openFileDialogTextCleaning.InitialDirectory = Form1.directoryPath;
            openFileDialogTextCleaning.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialogTextCleaning.ShowDialog(this) == DialogResult.OK)
            {
                Form1.directoryPath = Path.GetDirectoryName(openFileDialogTextCleaning.FileName);
                foreach (string fileName in openFileDialogTextCleaning.FileNames)
                {
                    articlesCleaningListBox.Items.Add(fileName);
                }
            }
        }

        private void StopwordsDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                stopWordslListBox.Items.Remove(stopWordslListBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("No files selected");
            }
        }

        private void stopwordsDeleteALlButton_Click(object sender, EventArgs e)
        {
            stopWordslListBox.Items.Clear();
        }

        private void deleteArticlesButton_Click(object sender, EventArgs e)
        {
            try
            {
                articlesCleaningListBox.Items.Remove(articlesCleaningListBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("No files selected");
            }
        }

        private void articlesDeleteALlButton_Click(object sender, EventArgs e)
        {
            articlesCleaningListBox.Items.Clear();
        }

        private void cleaningProcessbutton_Click(object sender, EventArgs e)
        {
            textCleaningDataGridView.Rows.Clear();
            foreach (string passage in articlesCleaningListBox.Items)
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
                            var index = textCleaningDataGridView.Rows.Add(line);
                            if (column.Length > 1)
                            {
                                if (column[1] == "positive" || column[1] == "negative" || column[1] == "neutral")
                                    textCleaningDataGridView.Rows[index].Cells[1].Value = column[1].ToString();
                            }
                        }
                    }
                }
            }
            TextCleaning();
        }
         
        private void TextCleaning()
        {
            foreach (DataGridViewRow row in textCleaningDataGridView.Rows)
            {
                string statements = punctuation(row.Cells[0].Value.ToString()).ToLower();
                string[] perwords = Regex.Split(statements, @"\s+");
                statements = "";
                string stopwords = "";
                for (int i = 0; i < perwords.Length; i++)
                {
                    if (!Regex.IsMatch(perwords[i], @"\d"))
                    {
                        int index = stopWordslListBox.Items.IndexOf(perwords[i]);
                        if (index == -1)
                        {
                            statements += perwords[i].Replace("o", "u").Replace("e", "i") + " ";
                        }
                        else
                        {
                            stopwords += perwords[i] + " ";
                        }
                    }
                }
                row.Cells[2].Value = stopwords;
                row.Cells[3].Value = Regex.Replace(statements, "\\s+", " ").Trim();
            }
        }

        private string punctuation(string statements)
        {
            string newStatements = "";
            for (int i = 0; i < statements.Length; i++)
            {
                if (Regex.IsMatch(statements[i] + "", @"[A-zñ0-9\s]"))
                {
                    newStatements += statements[i];
                }
            }
            return newStatements.Trim(); 
        }

        private void exportStopwordsbutton_Click(object sender, EventArgs e)
        {
            saveFileDialogTextCleaning.InitialDirectory = Form1.directoryPath;
            saveFileDialogTextCleaning.Title = "Browse Text Files";
            saveFileDialogTextCleaning.DefaultExt = "txt";
            saveFileDialogTextCleaning.CheckPathExists = true;
            saveFileDialogTextCleaning.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialogTextCleaning.ShowDialog() == DialogResult.OK)
            {
                Form1.directoryPath = Path.GetDirectoryName(saveFileDialogTextCleaning.FileName);
                string output = "";
                foreach (DataGridViewRow row in textCleaningDataGridView.Rows)
                {
                      if (output != "")
                            output += "\n";
                      output += row.Cells[2].Value.ToString() + Environment.NewLine;
                }
                using (StreamWriter textwriter = new StreamWriter(saveFileDialogTextCleaning.FileName))
                {
                    textwriter.Write(output);
                    MessageBox.Show("Successfully Saved!!!");
                }
            }
        }

        private void exportFilteredStatementsbutton_Click(object sender, EventArgs e)
        {
            if (cellNotEqualNull())
            {
                saveFileDialogTextCleaning.InitialDirectory = Form1.directoryPath;
                saveFileDialogTextCleaning.Title = "Browse Text Files";
                saveFileDialogTextCleaning.DefaultExt = "txt";
                saveFileDialogTextCleaning.CheckPathExists = true;
                saveFileDialogTextCleaning.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialogTextCleaning.ShowDialog() == DialogResult.OK)
                {
                    Form1.directoryPath = Path.GetDirectoryName(saveFileDialogTextCleaning.FileName);
                    string output = "";
                    foreach (DataGridViewRow row in textCleaningDataGridView.Rows)
                    {
                         if (output != "")
                            output += "\n";
                        output += row.Cells[3].Value.ToString() + "|" + row.Cells[1].Value.ToString() + Environment.NewLine;
                    }
                    using (StreamWriter textwriter = new StreamWriter(saveFileDialogTextCleaning.FileName))
                    {
                        textwriter.Write(output);
                        MessageBox.Show("Successfully Saved!!!");
                    }
                }
            }
            else {
                MessageBox.Show("Pls fill up all classification");
            }
        }


        private bool cellNotEqualNull()
        {
            foreach (DataGridViewRow row in textCleaningDataGridView.Rows)
            {
                if (row.Cells[1].Value == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
