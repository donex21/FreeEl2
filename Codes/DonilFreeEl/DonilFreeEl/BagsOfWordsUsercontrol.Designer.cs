namespace DonilFreeEl
{
    partial class BagsOfWordsUsercontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportBOWDropdownPanel = new System.Windows.Forms.Panel();
            this.AllScoreslabel = new System.Windows.Forms.Label();
            this.ScoresNEULabel = new System.Windows.Forms.Label();
            this.ScoresNEGLabel = new System.Windows.Forms.Label();
            this.ScoresPOSlabel = new System.Windows.Forms.Label();
            this.ExportBOWpanel = new System.Windows.Forms.Panel();
            this.ExportBOWLabel = new System.Windows.Forms.Label();
            this.bagswordsFilesDeleteALLButton = new System.Windows.Forms.Button();
            this.bagswordsFilesDeleteButton = new System.Windows.Forms.Button();
            this.bagswordsFilesListBox = new System.Windows.Forms.ListBox();
            this.bagsWOrdsBrowseFilesbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EstimateScoresButton = new System.Windows.Forms.Button();
            this.frequencyBagsWordsButton = new System.Windows.Forms.Button();
            this.extractFilesBagswordsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CleanStatementsDataGridView = new System.Windows.Forms.DataGridView();
            this.Statements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridView = new System.Windows.Forms.DataGridView();
            this.Words = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Positive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Negative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neutral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatesdataGridView = new System.Windows.Forms.DataGridView();
            this.EstimateWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatePos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateNeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateNeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uniqueWordslabel = new System.Windows.Forms.Label();
            this.TotalPositivelabel = new System.Windows.Forms.Label();
            this.TotalNegativelabel = new System.Windows.Forms.Label();
            this.TotalNeutralLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.ExportBOWDropdownPanel.SuspendLayout();
            this.ExportBOWpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CleanStatementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstimatesdataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.ExportBOWDropdownPanel);
            this.panel1.Controls.Add(this.ExportBOWpanel);
            this.panel1.Controls.Add(this.bagswordsFilesDeleteALLButton);
            this.panel1.Controls.Add(this.bagswordsFilesDeleteButton);
            this.panel1.Controls.Add(this.bagswordsFilesListBox);
            this.panel1.Controls.Add(this.bagsWOrdsBrowseFilesbutton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 566);
            this.panel1.TabIndex = 0;
            // 
            // ExportBOWDropdownPanel
            // 
            this.ExportBOWDropdownPanel.BackColor = System.Drawing.Color.Turquoise;
            this.ExportBOWDropdownPanel.Controls.Add(this.AllScoreslabel);
            this.ExportBOWDropdownPanel.Controls.Add(this.ScoresNEULabel);
            this.ExportBOWDropdownPanel.Controls.Add(this.ScoresNEGLabel);
            this.ExportBOWDropdownPanel.Controls.Add(this.ScoresPOSlabel);
            this.ExportBOWDropdownPanel.Location = new System.Drawing.Point(4, 261);
            this.ExportBOWDropdownPanel.Name = "ExportBOWDropdownPanel";
            this.ExportBOWDropdownPanel.Size = new System.Drawing.Size(146, 0);
            this.ExportBOWDropdownPanel.TabIndex = 8;
            // 
            // AllScoreslabel
            // 
            this.AllScoreslabel.AutoSize = true;
            this.AllScoreslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllScoreslabel.Location = new System.Drawing.Point(17, 110);
            this.AllScoreslabel.Name = "AllScoreslabel";
            this.AllScoreslabel.Size = new System.Drawing.Size(90, 20);
            this.AllScoreslabel.TabIndex = 4;
            this.AllScoreslabel.Text = "All Scores";
            this.AllScoreslabel.Click += new System.EventHandler(this.AllScoreslabel_Click);
            // 
            // ScoresNEULabel
            // 
            this.ScoresNEULabel.AutoSize = true;
            this.ScoresNEULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresNEULabel.Location = new System.Drawing.Point(4, 79);
            this.ScoresNEULabel.Name = "ScoresNEULabel";
            this.ScoresNEULabel.Size = new System.Drawing.Size(128, 20);
            this.ScoresNEULabel.TabIndex = 3;
            this.ScoresNEULabel.Text = "Neutral Scores";
            this.ScoresNEULabel.Click += new System.EventHandler(this.ScoresNEULabel_Click);
            // 
            // ScoresNEGLabel
            // 
            this.ScoresNEGLabel.AutoSize = true;
            this.ScoresNEGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresNEGLabel.Location = new System.Drawing.Point(4, 47);
            this.ScoresNEGLabel.Name = "ScoresNEGLabel";
            this.ScoresNEGLabel.Size = new System.Drawing.Size(140, 20);
            this.ScoresNEGLabel.TabIndex = 2;
            this.ScoresNEGLabel.Text = "Negative Scores";
            this.ScoresNEGLabel.Click += new System.EventHandler(this.ScoresNEGLabel_Click);
            // 
            // ScoresPOSlabel
            // 
            this.ScoresPOSlabel.AutoSize = true;
            this.ScoresPOSlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresPOSlabel.Location = new System.Drawing.Point(5, 16);
            this.ScoresPOSlabel.Name = "ScoresPOSlabel";
            this.ScoresPOSlabel.Size = new System.Drawing.Size(132, 20);
            this.ScoresPOSlabel.TabIndex = 1;
            this.ScoresPOSlabel.Text = "Positive Scores";
            this.ScoresPOSlabel.Click += new System.EventHandler(this.ScoresPOSlabel_Click);
            // 
            // ExportBOWpanel
            // 
            this.ExportBOWpanel.BackColor = System.Drawing.Color.Turquoise;
            this.ExportBOWpanel.Controls.Add(this.ExportBOWLabel);
            this.ExportBOWpanel.Location = new System.Drawing.Point(4, 223);
            this.ExportBOWpanel.Name = "ExportBOWpanel";
            this.ExportBOWpanel.Size = new System.Drawing.Size(146, 39);
            this.ExportBOWpanel.TabIndex = 7;
            // 
            // ExportBOWLabel
            // 
            this.ExportBOWLabel.AutoSize = true;
            this.ExportBOWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportBOWLabel.Location = new System.Drawing.Point(20, 10);
            this.ExportBOWLabel.Name = "ExportBOWLabel";
            this.ExportBOWLabel.Size = new System.Drawing.Size(107, 20);
            this.ExportBOWLabel.TabIndex = 0;
            this.ExportBOWLabel.Text = "Export BOW";
            this.ExportBOWLabel.Click += new System.EventHandler(this.ExportBOWLabel_Click);
            // 
            // bagswordsFilesDeleteALLButton
            // 
            this.bagswordsFilesDeleteALLButton.BackColor = System.Drawing.Color.Turquoise;
            this.bagswordsFilesDeleteALLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagswordsFilesDeleteALLButton.Location = new System.Drawing.Point(95, 185);
            this.bagswordsFilesDeleteALLButton.Name = "bagswordsFilesDeleteALLButton";
            this.bagswordsFilesDeleteALLButton.Size = new System.Drawing.Size(86, 30);
            this.bagswordsFilesDeleteALLButton.TabIndex = 6;
            this.bagswordsFilesDeleteALLButton.Text = "Delete All";
            this.bagswordsFilesDeleteALLButton.UseVisualStyleBackColor = false;
            this.bagswordsFilesDeleteALLButton.Click += new System.EventHandler(this.bagswordsFilesDeleteALLButton_Click);
            // 
            // bagswordsFilesDeleteButton
            // 
            this.bagswordsFilesDeleteButton.BackColor = System.Drawing.Color.Turquoise;
            this.bagswordsFilesDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagswordsFilesDeleteButton.Location = new System.Drawing.Point(0, 185);
            this.bagswordsFilesDeleteButton.Name = "bagswordsFilesDeleteButton";
            this.bagswordsFilesDeleteButton.Size = new System.Drawing.Size(86, 30);
            this.bagswordsFilesDeleteButton.TabIndex = 5;
            this.bagswordsFilesDeleteButton.Text = "Delete";
            this.bagswordsFilesDeleteButton.UseVisualStyleBackColor = false;
            this.bagswordsFilesDeleteButton.Click += new System.EventHandler(this.bagswordsFilesDeleteButton_Click);
            // 
            // bagswordsFilesListBox
            // 
            this.bagswordsFilesListBox.FormattingEnabled = true;
            this.bagswordsFilesListBox.Location = new System.Drawing.Point(0, 45);
            this.bagswordsFilesListBox.Name = "bagswordsFilesListBox";
            this.bagswordsFilesListBox.Size = new System.Drawing.Size(181, 134);
            this.bagswordsFilesListBox.TabIndex = 1;
            // 
            // bagsWOrdsBrowseFilesbutton
            // 
            this.bagsWOrdsBrowseFilesbutton.BackColor = System.Drawing.Color.Turquoise;
            this.bagsWOrdsBrowseFilesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagsWOrdsBrowseFilesbutton.Location = new System.Drawing.Point(33, 13);
            this.bagsWOrdsBrowseFilesbutton.Name = "bagsWOrdsBrowseFilesbutton";
            this.bagsWOrdsBrowseFilesbutton.Size = new System.Drawing.Size(109, 28);
            this.bagsWOrdsBrowseFilesbutton.TabIndex = 0;
            this.bagsWOrdsBrowseFilesbutton.Text = "Browse Files";
            this.bagsWOrdsBrowseFilesbutton.UseVisualStyleBackColor = false;
            this.bagsWOrdsBrowseFilesbutton.Click += new System.EventHandler(this.bagsWOrdsBrowseFilesbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.EstimateScoresButton);
            this.panel2.Controls.Add(this.frequencyBagsWordsButton);
            this.panel2.Controls.Add(this.extractFilesBagswordsButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 39);
            this.panel2.TabIndex = 1;
            // 
            // EstimateScoresButton
            // 
            this.EstimateScoresButton.BackColor = System.Drawing.Color.Turquoise;
            this.EstimateScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimateScoresButton.Location = new System.Drawing.Point(170, 4);
            this.EstimateScoresButton.Name = "EstimateScoresButton";
            this.EstimateScoresButton.Size = new System.Drawing.Size(79, 30);
            this.EstimateScoresButton.TabIndex = 9;
            this.EstimateScoresButton.Text = "Estimate";
            this.EstimateScoresButton.UseVisualStyleBackColor = false;
            this.EstimateScoresButton.Click += new System.EventHandler(this.EstimateScoresButton_Click);
            // 
            // frequencyBagsWordsButton
            // 
            this.frequencyBagsWordsButton.BackColor = System.Drawing.Color.Turquoise;
            this.frequencyBagsWordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyBagsWordsButton.Location = new System.Drawing.Point(83, 4);
            this.frequencyBagsWordsButton.Name = "frequencyBagsWordsButton";
            this.frequencyBagsWordsButton.Size = new System.Drawing.Size(85, 30);
            this.frequencyBagsWordsButton.TabIndex = 8;
            this.frequencyBagsWordsButton.Text = "Frequency";
            this.frequencyBagsWordsButton.UseVisualStyleBackColor = false;
            this.frequencyBagsWordsButton.Click += new System.EventHandler(this.frequencyBagsWordsButton_Click);
            // 
            // extractFilesBagswordsButton
            // 
            this.extractFilesBagswordsButton.BackColor = System.Drawing.Color.Turquoise;
            this.extractFilesBagswordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractFilesBagswordsButton.Location = new System.Drawing.Point(4, 4);
            this.extractFilesBagswordsButton.Name = "extractFilesBagswordsButton";
            this.extractFilesBagswordsButton.Size = new System.Drawing.Size(74, 30);
            this.extractFilesBagswordsButton.TabIndex = 7;
            this.extractFilesBagswordsButton.Text = "Import";
            this.extractFilesBagswordsButton.UseVisualStyleBackColor = false;
            this.extractFilesBagswordsButton.Click += new System.EventHandler(this.extractFilesBagswordsButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bags Of Words";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "OpenCleanSentence";
            this.openFileDialog.Multiselect = true;
            // 
            // CleanStatementsDataGridView
            // 
            this.CleanStatementsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanStatementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CleanStatementsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CleanStatementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CleanStatementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Statements,
            this.Classification});
            this.CleanStatementsDataGridView.Location = new System.Drawing.Point(182, 36);
            this.CleanStatementsDataGridView.Name = "CleanStatementsDataGridView";
            this.CleanStatementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CleanStatementsDataGridView.Size = new System.Drawing.Size(496, 531);
            this.CleanStatementsDataGridView.TabIndex = 2;
            // 
            // Statements
            // 
            this.Statements.FillWeight = 152.2843F;
            this.Statements.HeaderText = "Clean Statements";
            this.Statements.Name = "Statements";
            this.Statements.ReadOnly = true;
            this.Statements.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Classification
            // 
            this.Classification.FillWeight = 47.71573F;
            this.Classification.HeaderText = "Classification";
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            // 
            // frequencyDataGridView
            // 
            this.frequencyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.frequencyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.frequencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frequencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Words,
            this.Positive,
            this.Negative,
            this.Neutral});
            this.frequencyDataGridView.Location = new System.Drawing.Point(677, 62);
            this.frequencyDataGridView.Name = "frequencyDataGridView";
            this.frequencyDataGridView.ReadOnly = true;
            this.frequencyDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.frequencyDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.frequencyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.frequencyDataGridView.Size = new System.Drawing.Size(182, 436);
            this.frequencyDataGridView.TabIndex = 3;
            // 
            // Words
            // 
            this.Words.FillWeight = 203.0457F;
            this.Words.HeaderText = "Words";
            this.Words.Name = "Words";
            this.Words.ReadOnly = true;
            // 
            // Positive
            // 
            this.Positive.FillWeight = 65.65144F;
            this.Positive.HeaderText = "+";
            this.Positive.Name = "Positive";
            this.Positive.ReadOnly = true;
            // 
            // Negative
            // 
            this.Negative.FillWeight = 65.65144F;
            this.Negative.HeaderText = "-";
            this.Negative.Name = "Negative";
            this.Negative.ReadOnly = true;
            // 
            // Neutral
            // 
            this.Neutral.FillWeight = 65.65144F;
            this.Neutral.HeaderText = "=";
            this.Neutral.Name = "Neutral";
            this.Neutral.ReadOnly = true;
            // 
            // EstimatesdataGridView
            // 
            this.EstimatesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstimatesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstimatesdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.EstimatesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstimatesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstimateWords,
            this.EstimatePos,
            this.EstimateNeg,
            this.EstimateNeu});
            this.EstimatesdataGridView.Location = new System.Drawing.Point(854, 62);
            this.EstimatesdataGridView.Name = "EstimatesdataGridView";
            this.EstimatesdataGridView.RowHeadersVisible = false;
            this.EstimatesdataGridView.Size = new System.Drawing.Size(226, 436);
            this.EstimatesdataGridView.TabIndex = 4;
            // 
            // EstimateWords
            // 
            this.EstimateWords.FillWeight = 142.132F;
            this.EstimateWords.HeaderText = "Words";
            this.EstimateWords.Name = "EstimateWords";
            this.EstimateWords.ReadOnly = true;
            // 
            // EstimatePos
            // 
            this.EstimatePos.FillWeight = 87.2396F;
            this.EstimatePos.HeaderText = "+";
            this.EstimatePos.Name = "EstimatePos";
            this.EstimatePos.ReadOnly = true;
            // 
            // EstimateNeg
            // 
            this.EstimateNeg.FillWeight = 87.2396F;
            this.EstimateNeg.HeaderText = "-";
            this.EstimateNeg.Name = "EstimateNeg";
            this.EstimateNeg.ReadOnly = true;
            // 
            // EstimateNeu
            // 
            this.EstimateNeu.FillWeight = 83.38879F;
            this.EstimateNeu.HeaderText = "=";
            this.EstimateNeu.Name = "EstimateNeu";
            this.EstimateNeu.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Frequency";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(900, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estimate Scores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unique Words";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Positive";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Negative";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Neutral";
            // 
            // uniqueWordslabel
            // 
            this.uniqueWordslabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uniqueWordslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueWordslabel.Location = new System.Drawing.Point(75, 28);
            this.uniqueWordslabel.Name = "uniqueWordslabel";
            this.uniqueWordslabel.Size = new System.Drawing.Size(78, 23);
            this.uniqueWordslabel.TabIndex = 12;
            // 
            // TotalPositivelabel
            // 
            this.TotalPositivelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalPositivelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPositivelabel.Location = new System.Drawing.Point(172, 28);
            this.TotalPositivelabel.Name = "TotalPositivelabel";
            this.TotalPositivelabel.Size = new System.Drawing.Size(57, 23);
            this.TotalPositivelabel.TabIndex = 13;
            // 
            // TotalNegativelabel
            // 
            this.TotalNegativelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalNegativelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNegativelabel.Location = new System.Drawing.Point(249, 28);
            this.TotalNegativelabel.Name = "TotalNegativelabel";
            this.TotalNegativelabel.Size = new System.Drawing.Size(57, 23);
            this.TotalNegativelabel.TabIndex = 14;
            // 
            // TotalNeutralLabel
            // 
            this.TotalNeutralLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalNeutralLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNeutralLabel.Location = new System.Drawing.Point(315, 28);
            this.TotalNeutralLabel.Name = "TotalNeutralLabel";
            this.TotalNeutralLabel.Size = new System.Drawing.Size(57, 23);
            this.TotalNeutralLabel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TotalNeutralLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TotalNegativelabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TotalPositivelabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.uniqueWordslabel);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(679, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 80);
            this.panel3.TabIndex = 16;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BagsOfWordsUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EstimatesdataGridView);
            this.Controls.Add(this.frequencyDataGridView);
            this.Controls.Add(this.CleanStatementsDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BagsOfWordsUsercontrol";
            this.Size = new System.Drawing.Size(1080, 566);
            this.panel1.ResumeLayout(false);
            this.ExportBOWDropdownPanel.ResumeLayout(false);
            this.ExportBOWDropdownPanel.PerformLayout();
            this.ExportBOWpanel.ResumeLayout(false);
            this.ExportBOWpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CleanStatementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstimatesdataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bagsWOrdsBrowseFilesbutton;
        private System.Windows.Forms.ListBox bagswordsFilesListBox;
        private System.Windows.Forms.Button bagswordsFilesDeleteALLButton;
        private System.Windows.Forms.Button bagswordsFilesDeleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frequencyBagsWordsButton;
        private System.Windows.Forms.Button extractFilesBagswordsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView CleanStatementsDataGridView;
        private System.Windows.Forms.DataGridView frequencyDataGridView;
        private System.Windows.Forms.DataGridView EstimatesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statements;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Words;
        private System.Windows.Forms.DataGridViewTextBoxColumn Positive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Negative;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neutral;
        private System.Windows.Forms.Button EstimateScoresButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uniqueWordslabel;
        private System.Windows.Forms.Label TotalPositivelabel;
        private System.Windows.Forms.Label TotalNegativelabel;
        private System.Windows.Forms.Label TotalNeutralLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatePos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateNeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateNeu;
        private System.Windows.Forms.Panel ExportBOWpanel;
        private System.Windows.Forms.Label ExportBOWLabel;
        private System.Windows.Forms.Panel ExportBOWDropdownPanel;
        private System.Windows.Forms.Label AllScoreslabel;
        private System.Windows.Forms.Label ScoresNEULabel;
        private System.Windows.Forms.Label ScoresNEGLabel;
        private System.Windows.Forms.Label ScoresPOSlabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}
