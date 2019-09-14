namespace DonilFreeEl
{
    partial class TextCleaningUserControl
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
            this.stopwordsPanel = new System.Windows.Forms.Panel();
            this.StopwordsDeletebutton = new System.Windows.Forms.Button();
            this.stopwordsDeleteALlButton = new System.Windows.Forms.Button();
            this.stopWordslListBox = new System.Windows.Forms.ListBox();
            this.stopWordsbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ArticlesPanel = new System.Windows.Forms.Panel();
            this.exportFilteredStatementsbutton = new System.Windows.Forms.Button();
            this.exportStopwordsbutton = new System.Windows.Forms.Button();
            this.articlesDeleteALlButton = new System.Windows.Forms.Button();
            this.deleteArticlesButton = new System.Windows.Forms.Button();
            this.articlesCleaningListBox = new System.Windows.Forms.ListBox();
            this.articleCleaningButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cleaningProcessbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogTextCleaning = new System.Windows.Forms.OpenFileDialog();
            this.textCleaningDataGridView = new System.Windows.Forms.DataGridView();
            this.OriginalStatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filteredStatements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialogTextCleaning = new System.Windows.Forms.SaveFileDialog();
            this.stopwordsPanel.SuspendLayout();
            this.ArticlesPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCleaningDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stopwordsPanel
            // 
            this.stopwordsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stopwordsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stopwordsPanel.Controls.Add(this.StopwordsDeletebutton);
            this.stopwordsPanel.Controls.Add(this.stopwordsDeleteALlButton);
            this.stopwordsPanel.Controls.Add(this.stopWordslListBox);
            this.stopwordsPanel.Controls.Add(this.stopWordsbutton);
            this.stopwordsPanel.Controls.Add(this.label1);
            this.stopwordsPanel.Location = new System.Drawing.Point(-1, 0);
            this.stopwordsPanel.Name = "stopwordsPanel";
            this.stopwordsPanel.Size = new System.Drawing.Size(114, 539);
            this.stopwordsPanel.TabIndex = 0;
            // 
            // StopwordsDeletebutton
            // 
            this.StopwordsDeletebutton.BackColor = System.Drawing.Color.Turquoise;
            this.StopwordsDeletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopwordsDeletebutton.Location = new System.Drawing.Point(14, 329);
            this.StopwordsDeletebutton.Name = "StopwordsDeletebutton";
            this.StopwordsDeletebutton.Size = new System.Drawing.Size(86, 30);
            this.StopwordsDeletebutton.TabIndex = 4;
            this.StopwordsDeletebutton.Text = "Delete";
            this.StopwordsDeletebutton.UseVisualStyleBackColor = false;
            this.StopwordsDeletebutton.Click += new System.EventHandler(this.StopwordsDeletebutton_Click);
            // 
            // stopwordsDeleteALlButton
            // 
            this.stopwordsDeleteALlButton.BackColor = System.Drawing.Color.Turquoise;
            this.stopwordsDeleteALlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwordsDeleteALlButton.Location = new System.Drawing.Point(14, 365);
            this.stopwordsDeleteALlButton.Name = "stopwordsDeleteALlButton";
            this.stopwordsDeleteALlButton.Size = new System.Drawing.Size(86, 30);
            this.stopwordsDeleteALlButton.TabIndex = 3;
            this.stopwordsDeleteALlButton.Text = "Delete All";
            this.stopwordsDeleteALlButton.UseVisualStyleBackColor = false;
            this.stopwordsDeleteALlButton.Click += new System.EventHandler(this.stopwordsDeleteALlButton_Click);
            // 
            // stopWordslListBox
            // 
            this.stopWordslListBox.FormattingEnabled = true;
            this.stopWordslListBox.Location = new System.Drawing.Point(0, 72);
            this.stopWordslListBox.Name = "stopWordslListBox";
            this.stopWordslListBox.Size = new System.Drawing.Size(114, 251);
            this.stopWordslListBox.TabIndex = 2;
            // 
            // stopWordsbutton
            // 
            this.stopWordsbutton.BackColor = System.Drawing.Color.Turquoise;
            this.stopWordsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWordsbutton.Location = new System.Drawing.Point(15, 35);
            this.stopWordsbutton.Name = "stopWordsbutton";
            this.stopWordsbutton.Size = new System.Drawing.Size(86, 30);
            this.stopWordsbutton.TabIndex = 1;
            this.stopWordsbutton.Text = "Open Files";
            this.stopWordsbutton.UseVisualStyleBackColor = false;
            this.stopWordsbutton.Click += new System.EventHandler(this.stopWordsbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop Words";
            // 
            // ArticlesPanel
            // 
            this.ArticlesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ArticlesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ArticlesPanel.Controls.Add(this.exportFilteredStatementsbutton);
            this.ArticlesPanel.Controls.Add(this.exportStopwordsbutton);
            this.ArticlesPanel.Controls.Add(this.articlesDeleteALlButton);
            this.ArticlesPanel.Controls.Add(this.deleteArticlesButton);
            this.ArticlesPanel.Controls.Add(this.articlesCleaningListBox);
            this.ArticlesPanel.Controls.Add(this.articleCleaningButton);
            this.ArticlesPanel.Controls.Add(this.label2);
            this.ArticlesPanel.Location = new System.Drawing.Point(114, 0);
            this.ArticlesPanel.Name = "ArticlesPanel";
            this.ArticlesPanel.Size = new System.Drawing.Size(155, 529);
            this.ArticlesPanel.TabIndex = 1;
            // 
            // exportFilteredStatementsbutton
            // 
            this.exportFilteredStatementsbutton.BackColor = System.Drawing.Color.Turquoise;
            this.exportFilteredStatementsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFilteredStatementsbutton.Location = new System.Drawing.Point(26, 448);
            this.exportFilteredStatementsbutton.Name = "exportFilteredStatementsbutton";
            this.exportFilteredStatementsbutton.Size = new System.Drawing.Size(112, 42);
            this.exportFilteredStatementsbutton.TabIndex = 8;
            this.exportFilteredStatementsbutton.Text = "Export Filtered Statements";
            this.exportFilteredStatementsbutton.UseVisualStyleBackColor = false;
            this.exportFilteredStatementsbutton.Click += new System.EventHandler(this.exportFilteredStatementsbutton_Click);
            // 
            // exportStopwordsbutton
            // 
            this.exportStopwordsbutton.BackColor = System.Drawing.Color.Turquoise;
            this.exportStopwordsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportStopwordsbutton.Location = new System.Drawing.Point(26, 401);
            this.exportStopwordsbutton.Name = "exportStopwordsbutton";
            this.exportStopwordsbutton.Size = new System.Drawing.Size(112, 41);
            this.exportStopwordsbutton.TabIndex = 7;
            this.exportStopwordsbutton.Text = "Export Stop Words";
            this.exportStopwordsbutton.UseVisualStyleBackColor = false;
            this.exportStopwordsbutton.Click += new System.EventHandler(this.exportStopwordsbutton_Click);
            // 
            // articlesDeleteALlButton
            // 
            this.articlesDeleteALlButton.BackColor = System.Drawing.Color.Turquoise;
            this.articlesDeleteALlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlesDeleteALlButton.Location = new System.Drawing.Point(38, 365);
            this.articlesDeleteALlButton.Name = "articlesDeleteALlButton";
            this.articlesDeleteALlButton.Size = new System.Drawing.Size(86, 30);
            this.articlesDeleteALlButton.TabIndex = 5;
            this.articlesDeleteALlButton.Text = "Delete All";
            this.articlesDeleteALlButton.UseVisualStyleBackColor = false;
            this.articlesDeleteALlButton.Click += new System.EventHandler(this.articlesDeleteALlButton_Click);
            // 
            // deleteArticlesButton
            // 
            this.deleteArticlesButton.BackColor = System.Drawing.Color.Turquoise;
            this.deleteArticlesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteArticlesButton.Location = new System.Drawing.Point(38, 329);
            this.deleteArticlesButton.Name = "deleteArticlesButton";
            this.deleteArticlesButton.Size = new System.Drawing.Size(86, 30);
            this.deleteArticlesButton.TabIndex = 6;
            this.deleteArticlesButton.Text = "Delete";
            this.deleteArticlesButton.UseVisualStyleBackColor = false;
            this.deleteArticlesButton.Click += new System.EventHandler(this.deleteArticlesButton_Click);
            // 
            // articlesCleaningListBox
            // 
            this.articlesCleaningListBox.FormattingEnabled = true;
            this.articlesCleaningListBox.Location = new System.Drawing.Point(3, 72);
            this.articlesCleaningListBox.Name = "articlesCleaningListBox";
            this.articlesCleaningListBox.Size = new System.Drawing.Size(150, 251);
            this.articlesCleaningListBox.TabIndex = 5;
            // 
            // articleCleaningButton
            // 
            this.articleCleaningButton.BackColor = System.Drawing.Color.Turquoise;
            this.articleCleaningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleCleaningButton.Location = new System.Drawing.Point(52, 35);
            this.articleCleaningButton.Name = "articleCleaningButton";
            this.articleCleaningButton.Size = new System.Drawing.Size(86, 30);
            this.articleCleaningButton.TabIndex = 5;
            this.articleCleaningButton.Text = "Select Files";
            this.articleCleaningButton.UseVisualStyleBackColor = false;
            this.articleCleaningButton.Click += new System.EventHandler(this.articleCleaningButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Articles";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cleaningProcessbutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 32);
            this.panel1.TabIndex = 2;
            // 
            // cleaningProcessbutton
            // 
            this.cleaningProcessbutton.BackColor = System.Drawing.Color.Turquoise;
            this.cleaningProcessbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleaningProcessbutton.Location = new System.Drawing.Point(3, 2);
            this.cleaningProcessbutton.Name = "cleaningProcessbutton";
            this.cleaningProcessbutton.Size = new System.Drawing.Size(86, 30);
            this.cleaningProcessbutton.TabIndex = 7;
            this.cleaningProcessbutton.Text = "Process";
            this.cleaningProcessbutton.UseVisualStyleBackColor = false;
            this.cleaningProcessbutton.Click += new System.EventHandler(this.cleaningProcessbutton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text Cleaning";
            // 
            // openFileDialogTextCleaning
            // 
            this.openFileDialogTextCleaning.FileName = "openFileDialogTextCleaning";
            this.openFileDialogTextCleaning.Multiselect = true;
            // 
            // textCleaningDataGridView
            // 
            this.textCleaningDataGridView.AllowUserToAddRows = false;
            this.textCleaningDataGridView.AllowUserToDeleteRows = false;
            this.textCleaningDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCleaningDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.textCleaningDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.textCleaningDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.textCleaningDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textCleaningDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalStatement,
            this.Classification,
            this.stopWords,
            this.filteredStatements});
            this.textCleaningDataGridView.Location = new System.Drawing.Point(269, 32);
            this.textCleaningDataGridView.Name = "textCleaningDataGridView";
            this.textCleaningDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.textCleaningDataGridView.Size = new System.Drawing.Size(684, 504);
            this.textCleaningDataGridView.TabIndex = 4;
            // 
            // OriginalStatement
            // 
            this.OriginalStatement.FillWeight = 146.3599F;
            this.OriginalStatement.HeaderText = "Original Statement";
            this.OriginalStatement.Name = "OriginalStatement";
            this.OriginalStatement.ReadOnly = true;
            this.OriginalStatement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Classification
            // 
            this.Classification.FillWeight = 38.07943F;
            this.Classification.HeaderText = "Classification";
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            this.Classification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stopWords
            // 
            this.stopWords.FillWeight = 89.3401F;
            this.stopWords.HeaderText = "StopWords";
            this.stopWords.Name = "stopWords";
            this.stopWords.ReadOnly = true;
            this.stopWords.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // filteredStatements
            // 
            this.filteredStatements.FillWeight = 126.2205F;
            this.filteredStatements.HeaderText = "Filtered Statements";
            this.filteredStatements.Name = "filteredStatements";
            this.filteredStatements.ReadOnly = true;
            this.filteredStatements.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TextCleaningUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textCleaningDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ArticlesPanel);
            this.Controls.Add(this.stopwordsPanel);
            this.Name = "TextCleaningUserControl";
            this.Size = new System.Drawing.Size(953, 529);
            this.stopwordsPanel.ResumeLayout(false);
            this.stopwordsPanel.PerformLayout();
            this.ArticlesPanel.ResumeLayout(false);
            this.ArticlesPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textCleaningDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stopwordsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopWordsbutton;
        private System.Windows.Forms.Button StopwordsDeletebutton;
        private System.Windows.Forms.Button stopwordsDeleteALlButton;
        private System.Windows.Forms.ListBox stopWordslListBox;
        private System.Windows.Forms.Panel ArticlesPanel;
        private System.Windows.Forms.Button articlesDeleteALlButton;
        private System.Windows.Forms.Button deleteArticlesButton;
        private System.Windows.Forms.ListBox articlesCleaningListBox;
        private System.Windows.Forms.Button articleCleaningButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cleaningProcessbutton;
        private System.Windows.Forms.Button exportFilteredStatementsbutton;
        private System.Windows.Forms.Button exportStopwordsbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialogTextCleaning;
        private System.Windows.Forms.DataGridView textCleaningDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn filteredStatements;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTextCleaning;

    }
}
