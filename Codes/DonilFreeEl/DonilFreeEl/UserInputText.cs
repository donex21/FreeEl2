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
    public partial class UserInputText : UserControl
    {
        private static UserInputText _instance;
        TestdataUserControl1 testdata = new TestdataUserControl1();
        BOW bowuser = new BOW();
        public static UserInputText Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserInputText();
                return _instance;
            }
        }
        public UserInputText()
        {
            InitializeComponent();
        }

        private void BOWFilebutton_Click(object sender, EventArgs e)
        {
            try{
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
                                    bowuser.BOWdataGridView.Rows.Add(column[0].ToString(), column[1].ToString(), column[2].ToString(), column[3].ToString());
                                }
                            }
                        }
                    }
                }
                bowuser.Show();
            }
            catch
            {
                MessageBox.Show("Invalid Entry of files!!!");
            }
        }

        private void ShowBOWbutton_Click(object sender, EventArgs e)
        {
            if (bowuser.Visible == true)
            {
                bowuser.Hide();
            }
            else
            {
                bowuser.Show();
            }
        }

        private void UserInputtextBox_Enter(object sender, EventArgs e)
        {
            if (UserInputtextBox.Text == "INPUT TEXT")
            {
                UserInputtextBox.Text = "";
                UserInputtextBox.ForeColor = Color.Black;
            }
        }

        private void ClearTextbutton_Click(object sender, EventArgs e)
        {
            UserInputtextBox.Text = "INPUT TEXT";
            UserInputtextBox.ForeColor = Color.Silver;
            MachineResulttextBox.Text = "";
        }

        private void UserInputtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MachineResult();
            }
        }

        private void Enterbutton_Click(object sender, EventArgs e)
        {
            MachineResult();
        }

        private void MachineResult()
        {
            double posprob = 0, negprob = 0, neuprob = 0;
            string wordused = "";
            string newword = "";
            string nword = "";

            if (UserInputtextBox.Text != "INPUT TEXT")
            {
                for (int x = 0; x < UserInputtextBox.Text.ToString().Length; x++)
                {
                    if (Regex.IsMatch(UserInputtextBox.Text.ToString().ToLower()[x] + "", @"[A-zñ0-9\s]"))
                    {
                        newword += UserInputtextBox.Text.ToString()[x];
                    }
                }

                string[] word = Regex.Split(newword.Trim(), @"\s+");
         
                for (int i = 0; i < word.Length;i++)
                {
                    if (!Regex.IsMatch(word[i], @"\d"))
                    {
                        nword = word[i].Replace('o', 'u').Replace('e', 'i');
                    }
                                       
                    for (int j = 0; j < bowuser.BOWdataGridView.RowCount; j++)
                    {
                        if (nword.Equals((string)bowuser.BOWdataGridView[0, j].Value.ToString()))
                        {
                            wordused += " " + nword;
                            posprob += Convert.ToDouble(bowuser.BOWdataGridView[1, j].Value.ToString());
                            negprob += Convert.ToDouble(bowuser.BOWdataGridView[2, j].Value.ToString());
                            neuprob += Convert.ToDouble(bowuser.BOWdataGridView[3, j].Value.ToString());
                        }
                    }
                }
              
                MessageBox.Show(" pos: " + posprob + "\n neg: " + negprob + "\n neu: " + neuprob + "\n Wordused: " + wordused);
                if (posprob > negprob && posprob > neuprob)
                    MachineResulttextBox.Text = "POSITIVE";
                else if (negprob > posprob && negprob > neuprob)
                    MachineResulttextBox.Text = "NEGATIVE";
                else
                    MachineResulttextBox.Text = "NEUTRAL";
            }
        }
    }
}
