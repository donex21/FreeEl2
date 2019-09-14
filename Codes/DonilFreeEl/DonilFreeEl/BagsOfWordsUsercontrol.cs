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
    public partial class BagsOfWordsUsercontrol : UserControl
    {
        SortedSet<string> uniqueSortedWords = new SortedSet<string>();
        private static BagsOfWordsUsercontrol _instance;
        private int totalpositive;
        private int totalnegative;
        private int totalneutral;
   
        private int[] positiveWords;
        private int[] negativeWords;
        private int[] neutralWords;

        private double[] scorespos;
        private double[] scoresneg;
        private double[] scoresneu;

        public static BagsOfWordsUsercontrol Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BagsOfWordsUsercontrol();
                return _instance;
            }
        }
        public BagsOfWordsUsercontrol()
        {
            InitializeComponent();
            getfrequencyResult();
        }

        private void bagsWOrdsBrowseFilesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = Form1.directoryPath;
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Form1.directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        bagswordsFilesListBox.Items.Add(fileName);
                    }
                }
            }
            catch {
                MessageBox.Show("Invalid Entry of File!!!");
            }
        }

        private void bagswordsFilesDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                bagswordsFilesListBox.Items.Remove(bagswordsFilesListBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("No files selected");
            }
        }

        private void bagswordsFilesDeleteALLButton_Click(object sender, EventArgs e)
        {
            bagswordsFilesListBox.Items.Clear();
        }

        private void extractFilesBagswordsButton_Click(object sender, EventArgs e)
        {
            uniqueSortedWords = new SortedSet<string>();
            EstimatesdataGridView.Rows.Clear();
            frequencyDataGridView.Rows.Clear();
            CleanStatementsDataGridView.Rows.Clear();
            foreach (string passage in bagswordsFilesListBox.Items)
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
                            bool check = false;
                            foreach(char letters in line.ToCharArray())
                            {
                                if((!Char.IsLetter(letters)) && !(letters == ' '))
                                {    
                                    check=true;
                                    break;
                                }
                            }
                            if (check)
                            {
                                MessageBox.Show("Invalid Entry of files!!!");
                                return;
                            }
                            else
                            {
                                string[] words = Regex.Split(line, @"\s+");
   
                                foreach (string word in words)
                                {
                                    uniqueSortedWords.Add(word);
                                }
                                var index = CleanStatementsDataGridView.Rows.Add(line);
                                if (column.Length > 1)
                                {
                                    if (column[1] == "positive" || column[1] == "negative" || column[1] == "neutral")
                                        CleanStatementsDataGridView.Rows[index].Cells[1].Value = column[1].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void frequencyBagsWordsButton_Click(object sender, EventArgs e)
        {
            frequencyDataGridView.Rows.Clear();
            getfrequencyResult();
            frequencyUniqueWords();
            uniqueWordslabel.Text = uniqueSortedWords.Count().ToString();
            TotalPositivelabel.Text = totalpositive.ToString();
            TotalNegativelabel.Text = totalnegative.ToString();
            TotalNeutralLabel.Text = totalneutral.ToString();
        }

        private void frequencyUniqueWords()
        {           
            for (int i = 0; i < uniqueSortedWords.Count();i++ )
            {
                frequencyDataGridView.Rows.Add(uniqueSortedWords.ElementAt(i), positiveWords[i].ToString(), negativeWords[i].ToString(), neutralWords[i].ToString());
            }
        }

        private void getfrequencyResult()
        {
            totalpositive = 0;
            totalnegative = 0;
            totalneutral = 0;
            positiveWords = new int[uniqueSortedWords.Count()];
            negativeWords = new int[uniqueSortedWords.Count()];
            neutralWords = new int[uniqueSortedWords.Count()];

            scorespos = new double[uniqueSortedWords.Count()];
            scoresneg = new double[uniqueSortedWords.Count()];
            scoresneu = new double[uniqueSortedWords.Count()];
            for (int i = 0; i < uniqueSortedWords.Count(); i++)
            {
                positiveWords[i] = 0;
                negativeWords[i] = 0;
                neutralWords[i] = 0;
                scorespos[i] = 0.0;
                scoresneg[i] = 0.0;
                scoresneu[i] = 0.0;
            }
            
            foreach (string passage in bagswordsFilesListBox.Items)
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
        
                            string[] words = Regex.Split(line, @"\s+");
                            for (int i = 0; i < uniqueSortedWords.Count(); i++)
                            {
                                 for (int j = 0; j < words.Length; j++)
                                 {
                                     if (uniqueSortedWords.ElementAt(i).Equals(words[j]))
                                     {
                                            if (column[1] == "positive")
                                            {
                                                positiveWords[i]++;
                                                totalpositive++;
                                            }
                                            else if (column[1] == "negative")
                                            {
                                                negativeWords[i]++;
                                                totalnegative++;
                                            }
                                            else if (column[1] == "neutral")
                                            {
                                                neutralWords[i]++;
                                                totalneutral++;
                                            }
                                            break;
                                    }
                                }
                           }
                        }
                    }
                }
            }
            int totalwords = uniqueSortedWords.Count();
            for (int i = 0; i < uniqueSortedWords.Count(); i++)
            {
                scorespos[i] = (Convert.ToDouble(positiveWords[i]) + 1) / (totalpositive + totalwords);
                scoresneg[i] = (Convert.ToDouble(negativeWords[i]) + 1) / (totalnegative + totalwords);
                scoresneu[i] = (Convert.ToDouble(neutralWords[i]) + 1) / (totalneutral + totalwords);
            }
        }

        private void EstimateScoresButton_Click(object sender, EventArgs e)
        {
            EstimatesdataGridView.Rows.Clear();
            getfrequencyResult();
            EstimatesUniqueWords();
        }

        private void EstimatesUniqueWords()
        {
            for (int i = 0; i < uniqueSortedWords.Count(); i++)
            {
                EstimatesdataGridView.Rows.Add(uniqueSortedWords.ElementAt(i), scorespos[i].ToString(), scoresneg[i].ToString(), scoresneu[i].ToString());
            }
        }

        private void ScoresPOSlabel_Click(object sender, EventArgs e)
        {
            BOWExportFiles("Positive");
        }

        private void ScoresNEGLabel_Click(object sender, EventArgs e)
        {
            BOWExportFiles("Negative");
        }

        private void ScoresNEULabel_Click(object sender, EventArgs e)
        {
            BOWExportFiles("Neutral");
        }

        private void AllScoreslabel_Click(object sender, EventArgs e)
        {
            BOWExportFiles("AllScores");
        }

        bool isDropdownOpen = false;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (isDropdownOpen)
            {
                ExportBOWDropdownPanel.Height -= 20;
                if (ExportBOWDropdownPanel.Height == 0)
                {
                    timer.Stop();
                    isDropdownOpen = false;
                }
            }
            else if (!isDropdownOpen)
            {
                ExportBOWDropdownPanel.Height += 20;
                if (ExportBOWDropdownPanel.Height == 140)
                {
                    timer.Stop();
                    isDropdownOpen = true;
                }
            }
        }

        private void ExportBOWLabel_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void BOWExportFiles(String scoresClass)
        {
            if (EstimatesdataGridView.RowCount > 0)
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
                        foreach (DataGridViewRow row in EstimatesdataGridView.Rows)
                        {
                            if(row != null)
                            {
                                if (scoresClass == "Positive")
                                {
                                    if (output != "")
                                        output += "\n";
                                    output += row.Cells[0].Value + "|" + row.Cells[1].Value + Environment.NewLine;
                                }
                                else if (scoresClass == "Negative")
                                {
                                    if (output != "")
                                        output += "\n";
                                    output += row.Cells[0].Value + "|" + row.Cells[2].Value + Environment.NewLine;
                                }
                                else if (scoresClass == "Neutral")
                                {
                                    if (output != "")
                                        output += "\n";
                                    output += row.Cells[0].Value + "|" + row.Cells[3].Value + Environment.NewLine;
                                }
                                else if (scoresClass == "AllScores")
                                {
                                    if (output != "")
                                        output += "\n";
                                    output += row.Cells[0].Value + "|" + row.Cells[1].Value + "|" + row.Cells[2].Value + "|" + row.Cells[3].Value + Environment.NewLine;
                                }
                            }
                        }
                        using (StreamWriter textwriter = new StreamWriter(saveFileDialog.FileName))
                        {
                            textwriter.Write(output);
                            MessageBox.Show("Successfully Saved!!!");
                        }
                    }             
            }
        }
    }
}
