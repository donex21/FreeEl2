using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace DonilFreeEl
{
    public partial class TestdataUserControl1 : UserControl
    {
        BOW bow = new BOW();
        MachineProb machineProb = new MachineProb();
        private static TestdataUserControl1 _instance;
        int countpos, countneg, countneu;
        double truepos =0, trueneg = 0, falsepos = 0, falseneg = 0, attempt = 1;
        double[] totalpospro, totalnegprob, totalneuprob;
        double test1 = 0.0, test2 = 0.0, test3 = 0.0, accuracy = 0.0;

        public static TestdataUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TestdataUserControl1();
                return _instance;
            }
        }
        public TestdataUserControl1()
        {
            InitializeComponent();
        }

        public void BOWFilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = Form1.directoryPath;
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Form1.directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string nextLine = streamReader.ReadLine();
                            if (!string.IsNullOrWhiteSpace(nextLine))
                            {
                                string[] column = nextLine.Split('|');
                                bool check = false;
                                foreach (char digit in column[1].ToCharArray())
                                {
                                    if (!Char.IsDigit(digit) && digit != '.')
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
                                    bow.BOWdataGridView.Rows.Add(column[0].ToString(), column[1].ToString(), column[2].ToString(), column[3].ToString());
                                }
                            }
                        }
                    }
                }
                bow.Show();
            }
            catch {
                MessageBox.Show("Invalid Entry of files!!!");
            }
        }

        private void TestAttempt1Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (attempt < 4)
                {
                    truepos = 0; trueneg = 0; falsepos = 0; falseneg = 0;
                    ImportTest();
                    TestResultdata();
                    test1 = ((truepos + trueneg) / (truepos + trueneg + falsepos + falseneg)) * 100;
                    TESTATTEMPT1textBox.Text = test1.ToString("#.##") + "%";
                    accuracy = (test1 + test2 + test3) / attempt;
                    attempt++;
                    AVEACCURACYtextBox.Text = accuracy.ToString("#.##") + "%";
                    TRUEPOStextBox.Text = truepos.ToString();
                    FALSEPOStextBox.Text = falsepos.ToString();
                    TRUENEGtextBox.Text = trueneg.ToString();
                    FALSENEGtextBox.Text = falseneg.ToString();
                    //machineProb.Show();
                }else
                    MessageBox.Show("You try already the 3 attempt of Test");
            }
            catch {
                MessageBox.Show("Invalid Entry of files!!!");
            }
        }

        private void testAttempt2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (attempt < 4)
                {
                    truepos = 0; trueneg = 0; falsepos = 0; falseneg = 0;
                    ImportTest();
                    TestResultdata();
                    test2 = ((truepos + trueneg) / (truepos + trueneg + falsepos + falseneg)) * 100;
                    TESTATTEMPT2textBox.Text = test2.ToString("#.##") + "%";
                    accuracy = (test1 + test2 + test3) / attempt;
                    attempt++;
                    AVEACCURACYtextBox.Text = accuracy.ToString("#.##") + "%";
                    TRUEPOStextBox.Text = truepos.ToString();
                    FALSEPOStextBox.Text = falsepos.ToString();
                    TRUENEGtextBox.Text = trueneg.ToString();
                    FALSENEGtextBox.Text = falseneg.ToString();
                    //machineProb.Show();
                }
                else
                    MessageBox.Show("You try already the 3 attempt of Test");
            }
            catch
            {
                MessageBox.Show("Invalid Entry of files!!!");
            }
        }

        private void TestAttempt3Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (attempt < 4)
                {
                    truepos = 0; trueneg = 0; falsepos = 0; falseneg = 0;
                    ImportTest();
                    TestResultdata();
                    test3 = ((truepos + trueneg) / (truepos + trueneg + falsepos + falseneg)) * 100;
                    TESTATTEMPT3textBox.Text = test3.ToString("#.##") + "%";
                    accuracy = (test1 + test2 + test3) / attempt;
                    attempt++;
                    AVEACCURACYtextBox.Text = accuracy.ToString("#.##") + "%";
                    TRUEPOStextBox.Text = truepos.ToString();
                    FALSEPOStextBox.Text = falsepos.ToString();
                    TRUENEGtextBox.Text = trueneg.ToString();
                    FALSENEGtextBox.Text = falseneg.ToString();
                    //machineProb.Show();
                }else
                    MessageBox.Show("You try already the 3 attempt of Test");
            }
            catch
            {
                MessageBox.Show("Invalid Entry of files!!!");
            }
        }

        private void ImportTest()
        {
            int i = 1;
            machineProb.MachineProbDataGridView.Rows.Clear();
            TestDATAdataGridView.Rows.Clear();
            TESTDATARESULTdataGridView.Rows.Clear();
            countpos = 0; countneg = 0; countneu = 0;
            
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Form1.directoryPath;
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Form1.directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
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
                                var index = TestDATAdataGridView.Rows.Add(i++, line);
                                if (column.Length > 1)
                                {
                                    if (column[1] == "positive" || column[1] == "negative" || column[1] == "neutral")
                                        TestDATAdataGridView.Rows[index].Cells[2].Value = column[1].ToString();
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
            TOTALPOStextBox.Text = countpos.ToString();
            TOTALNEGtextBox.Text = countneg.ToString();
            TOTALNEUtextBox.Text = countneu.ToString();
            TotalSentencetextBox.Text = TestDATAdataGridView.RowCount.ToString();
        }

        private void TestResultdata()
        {
            totalpospro = new double[TestDATAdataGridView.RowCount];
            totalnegprob = new double[TestDATAdataGridView.RowCount];
            totalneuprob = new double[TestDATAdataGridView.RowCount];
           
            string[] MACHINE = new string[TestDATAdataGridView.RowCount];
            string[] WORDUSED = new string[TestDATAdataGridView.RowCount];
            string[] RESULTACC = new string[TestDATAdataGridView.RowCount];

            double pPlus = Convert.ToDouble(countpos) / TestDATAdataGridView.RowCount;
            double pMinus = Convert.ToDouble(countneg) / TestDATAdataGridView.RowCount;
            double pEquals = Convert.ToDouble(countneu) / TestDATAdataGridView.RowCount;

            MessageBox.Show("Prior Positive = " + pPlus.ToString() + "\nPrior Negative = " + pMinus.ToString() + "\nPrior Neutral = " + pEquals.ToString());
            for (int i = 0; i < TestDATAdataGridView.RowCount; i++)
            {
                double posprob = 0, negprob = 0, neuprob = 0;
                WORDUSED[i] = "";
                MACHINE[i] = "";
                RESULTACC[i] = "";
                totalpospro[i] = 0;
                totalnegprob[i] = 0;
                totalneuprob[i] = 0;
                           
                string[] word = TestDATAdataGridView[1, i].Value.ToString().ToLower().Split(' ');
                if (TestDATAdataGridView[1, i].Value.ToString() != "")
                {
                    for (int x = 0; x < word.Length; x++)
                    {
                        for (int j = 0; j < bow.BOWdataGridView.RowCount; j++)
                        {
                            if (word[x].Equals((string)bow.BOWdataGridView[0, j].Value))
                            {
                                WORDUSED[i] += " " + word[x];
                                posprob += Convert.ToDouble(bow.BOWdataGridView[1, j].Value.ToString());
                                negprob += Convert.ToDouble(bow.BOWdataGridView[2, j].Value.ToString());
                                neuprob += Convert.ToDouble(bow.BOWdataGridView[3, j].Value.ToString());
                            }
                        }
                    }
                }

                totalpospro[i] = posprob;// + pPlus;
                totalnegprob[i] = negprob;// +pMinus;
                totalneuprob[i] = neuprob;// +pEquals;
               
                //MessageBox.Show(TestDATAdataGridView[1, i].Value.ToString() + " pos: " + totalpospro[i] + " neg: " + totalnegprob[i] + "neu: " + totalneuprob[i] + "\n");
                //Machine
                if (totalpospro[i] > totalnegprob[i] && totalpospro[i] > totalneuprob[i])
                    MACHINE[i] = "positive";
                else if(totalnegprob[i] > totalpospro[i] && totalnegprob[i] > totalneuprob[i])
                    MACHINE[i] = "negative";
                else
                    MACHINE[i] = "neutral";

                //Result for accuracy;;;
                if (MACHINE[i].Equals("positive") && TestDATAdataGridView[2, i].Value.ToString().Equals("positive"))
                {
                    RESULTACC[i] = "truepositive";
                    truepos++;
                }
                else if (MACHINE[i].Equals("positive") && TestDATAdataGridView[2, i].Value.ToString().Equals("negative"))
                {
                    RESULTACC[i] = "falsepositive";
                    falsepos++;
                }
                else if (MACHINE[i].Equals("negative") && TestDATAdataGridView[2, i].Value.ToString().Equals("negative"))
                {
                    RESULTACC[i] = "truenegative";
                    trueneg++;
                }
                else if (MACHINE[i].Equals("negative") && TestDATAdataGridView[2, i].Value.ToString().Equals("positive"))
                {
                    RESULTACC[i] = "falsenegative";
                    falseneg++;
                }
                else
                    RESULTACC[i] = "none";

                //Display in datagridview TESTDATARESULTdataGridView
                TESTDATARESULTdataGridView.Rows.Add(i+1, MACHINE[i], WORDUSED[i], RESULTACC[i]);
                machineProb.MachineProbDataGridView.Rows.Add(i+1, TestDATAdataGridView[1, i].Value.ToString(), totalpospro[i], totalnegprob[i], totalneuprob[i]);
            }
        }

        bool flag = true;
        private void ListResultbutton_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                machineProb.Show();
                flag = false;
            }else{
                machineProb.Hide();
                flag = true;
            }
        }

        public void ShowBOWbutton_Click(object sender, EventArgs e)
        {
            if (bow.Visible == true)
            {
                bow.Hide();
            }
            else {
                bow.Show();
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            test1 = 0.0; test2 = 0.0; test3 = 0.0; accuracy = 0.0; attempt = 1;
            machineProb.MachineProbDataGridView.Rows.Clear();
            TestDATAdataGridView.Rows.Clear();
            TESTDATARESULTdataGridView.Rows.Clear();
            AVEACCURACYtextBox.Text = "";
            TESTATTEMPT1textBox.Text = "";
            TESTATTEMPT2textBox.Text = "";
            TESTATTEMPT3textBox.Text = "";
        }

    }
}
