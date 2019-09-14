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
    public partial class FileDividerUserControl : UserControl
    {
        private static FileDividerUserControl _instance;
        int countpos = 0;
        int countneu = 0;
        int countneg = 0;
        public static FileDividerUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FileDividerUserControl();
                return _instance;
            }
        }
        public FileDividerUserControl()
        {
            InitializeComponent();
        }

        private void dividerBrowseFilebutton_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Form1.directoryPath;
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Form1.directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                foreach (string fileName in openFileDialog.FileNames)
                {
                    DividerFileslistBox.Items.Add(fileName);
                }
            }
        }

        private void DividerDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DividerFileslistBox.Items.Remove(DividerFileslistBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("No files selected");
            }
        }

        private void DeleteAllbutton_Click(object sender, EventArgs e)
        {
            DividerFileslistBox.Items.Clear();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            DividerFilesdataGridView.Rows.Clear();
            foreach (string passage in DividerFileslistBox.Items)
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
                            foreach (char letters in line.ToCharArray())
                            {
                                if ((!Char.IsLetter(letters)) && !(letters == ' '))
                                {
                                    check = true;
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
                                //string[] words = Regex.Split(line, @"\s+");

                                var index = DividerFilesdataGridView.Rows.Add(line);
                                if (column.Length > 1)
                                {
                                    if (column[1] == "positive" || column[1] == "negative" || column[1] == "neutral")
                                        DividerFilesdataGridView.Rows[index].Cells[1].Value = column[1].ToString();
                                    if (column[1] == "positive")
                                        countpos++;
                                    else if (column[1] == "negative")
                                        countneg++;
                                    else if (column[1] == "neutral")
                                        countneu++;
                                }
                            }
                        }
                    }
                }
            }
            countposTextBox.Text = countpos.ToString();
            countNegtextBox.Text = countneg.ToString();
            CountNeutextBox.Text = countneu.ToString();
        }

        private void TrainFilesbutton_Click(object sender, EventArgs e)
        {
            ResultTrainTestdataGridView.Rows.Clear();
            int trainpercentPos = Convert.ToInt32(countpos * .70);
            int trainpercentNeg = Convert.ToInt32(countneg * .70);
            int trainpercentNeu = Convert.ToInt32(countneu * .70);

            int counter = 0;
            for (int i = 0; i < DividerFilesdataGridView.RowCount && counter < trainpercentPos; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("positive"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }

            counter = 0;
            for (int i = 0; i < DividerFilesdataGridView.RowCount && counter < trainpercentNeg; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("negative"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }

            counter = 0;
            for (int i = 0; i < DividerFilesdataGridView.RowCount && counter < trainpercentNeu; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("neutral"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }
        }

        private void TestFileTopbutton_Click(object sender, EventArgs e)
        {

            ResultTrainTestdataGridView.Rows.Clear();
            int trainpercentPos = Convert.ToInt32(countpos * .30);
            int trainpercentNeg = Convert.ToInt32(countneg * .30);
            int trainpercentNeu = Convert.ToInt32(countneu * .30);

            int counter = 0;
            for (int i = 0; i < DividerFilesdataGridView.RowCount && counter < trainpercentPos; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("positive"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }

            counter = 0;
            for (int i = 0; i < DividerFilesdataGridView.RowCount && counter < trainpercentNeg; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("negative"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }

            counter = 0;
            for (int i = 0; i < DividerFilesdataGridView.RowCount && counter < trainpercentNeu; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("neutral"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }
        }

        private void TestFileMiddleButton_Click(object sender, EventArgs e)
        {
            ResultTrainTestdataGridView.Rows.Clear();
            int trainpercentPos = Convert.ToInt32(countpos * .35);
            int trainpercentNeg = Convert.ToInt32(countneg * .35);
            int trainpercentNeu = Convert.ToInt32(countneu * .35);

            int counter = 0;
            int i = 0;
            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("positive"))
                {
                    counter++;
                    if (counter == trainpercentPos)
                        break;
                }
            }

            for (; i < DividerFilesdataGridView.RowCount && counter < Convert.ToInt32(countpos * .65); i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("positive"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }

            counter = 0;
            i = 0;
            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("negative"))
                {
                    counter++;
                    if (counter == trainpercentNeg)
                        break;
                }
            }

            for (; i < DividerFilesdataGridView.RowCount && counter < Convert.ToInt32(countneg * .65); i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("negative"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }

            counter = 0;
            i = 0;
            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("neutral"))
                {
                    counter++;
                    if (counter == trainpercentNeu)
                        break;
                }
            }

            for (; i < DividerFilesdataGridView.RowCount && counter < Convert.ToInt32(countneu * .65); i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("neutral"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                    counter++;
                }
            }
        }

        private void TestFileBottomButton_Click(object sender, EventArgs e)
        {
            
            ResultTrainTestdataGridView.Rows.Clear();
            int trainpercentPos = Convert.ToInt32(countpos * .70);
            int trainpercentNeg = Convert.ToInt32(countneg * .70);
            int trainpercentNeu = Convert.ToInt32(countneu * .70);

            int counter = 0;
            int i = 0;
            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("positive"))
                {
                    counter++;
                    if (counter == trainpercentPos)
                        break;
                }
            }

            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("positive"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                }
            }

            counter = 0;
            i = 0;
            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("negative"))
                {
                    counter++;
                    if (counter == trainpercentNeg)
                        break;
                }
            }

            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("negative"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                }
            }

            counter = 0;
            i = 0;
            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("neutral"))
                {
                    counter++;
                    if (counter == trainpercentNeu)
                        break;
                }
            }

            for (; i < DividerFilesdataGridView.RowCount; i++)
            {
                string grid = (string)DividerFilesdataGridView[1, i].Value;
                if (grid.Equals("neutral"))
                {
                    ResultTrainTestdataGridView.Rows.Add(DividerFilesdataGridView[0, i].Value, DividerFilesdataGridView[1, i].Value);
                }
            }
        }

        private void DividerExportbutton_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in ResultTrainTestdataGridView.Rows)
                {
                    if (output != "")
                        output += "\n";
                    output += row.Cells[0].Value.ToString() + "|" + row.Cells[1].Value.ToString() + Environment.NewLine;
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
