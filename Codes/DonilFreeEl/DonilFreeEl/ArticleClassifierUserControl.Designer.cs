namespace DonilFreeEl
{
    partial class ArticleClassifierUserControl
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
            this.Articlepanel = new System.Windows.Forms.Panel();
            this.dropDownPanel = new System.Windows.Forms.Panel();
            this.neutralLabel = new System.Windows.Forms.Label();
            this.negativeLabel = new System.Windows.Forms.Label();
            this.positiveLabel = new System.Windows.Forms.Label();
            this.exportPanel = new System.Windows.Forms.Panel();
            this.exportLabel = new System.Windows.Forms.Label();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.articlesListBox = new System.Windows.Forms.ListBox();
            this.Openfilesbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.articleClassifierHeaderlabel = new System.Windows.Forms.Label();
            this.ArticlesClassifierdataGridView = new System.Windows.Forms.DataGridView();
            this.OriginalStatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportTimer = new System.Windows.Forms.Timer(this.components);
            this.Articlepanel.SuspendLayout();
            this.dropDownPanel.SuspendLayout();
            this.exportPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesClassifierdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Articlepanel
            // 
            this.Articlepanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Articlepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Articlepanel.Controls.Add(this.dropDownPanel);
            this.Articlepanel.Controls.Add(this.exportPanel);
            this.Articlepanel.Controls.Add(this.ExtractButton);
            this.Articlepanel.Controls.Add(this.deleteAllButton);
            this.Articlepanel.Controls.Add(this.deleteButton);
            this.Articlepanel.Controls.Add(this.articlesListBox);
            this.Articlepanel.Controls.Add(this.Openfilesbutton);
            this.Articlepanel.Controls.Add(this.label1);
            this.Articlepanel.Location = new System.Drawing.Point(0, 0);
            this.Articlepanel.Name = "Articlepanel";
            this.Articlepanel.Size = new System.Drawing.Size(266, 801);
            this.Articlepanel.TabIndex = 0;
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackColor = System.Drawing.Color.Turquoise;
            this.dropDownPanel.Controls.Add(this.neutralLabel);
            this.dropDownPanel.Controls.Add(this.negativeLabel);
            this.dropDownPanel.Controls.Add(this.positiveLabel);
            this.dropDownPanel.Location = new System.Drawing.Point(39, 452);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Size = new System.Drawing.Size(91, 0);
            this.dropDownPanel.TabIndex = 7;
            // 
            // neutralLabel
            // 
            this.neutralLabel.AutoSize = true;
            this.neutralLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neutralLabel.Location = new System.Drawing.Point(17, 65);
            this.neutralLabel.Name = "neutralLabel";
            this.neutralLabel.Size = new System.Drawing.Size(58, 16);
            this.neutralLabel.TabIndex = 2;
            this.neutralLabel.Text = "Neutral";
            this.neutralLabel.Click += new System.EventHandler(this.neutralLabel_Click);
            // 
            // negativeLabel
            // 
            this.negativeLabel.AutoSize = true;
            this.negativeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeLabel.Location = new System.Drawing.Point(9, 39);
            this.negativeLabel.Name = "negativeLabel";
            this.negativeLabel.Size = new System.Drawing.Size(71, 16);
            this.negativeLabel.TabIndex = 1;
            this.negativeLabel.Text = "Negative";
            this.negativeLabel.Click += new System.EventHandler(this.negativeLabel_Click);
            // 
            // positiveLabel
            // 
            this.positiveLabel.AutoSize = true;
            this.positiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveLabel.Location = new System.Drawing.Point(16, 13);
            this.positiveLabel.Name = "positiveLabel";
            this.positiveLabel.Size = new System.Drawing.Size(64, 16);
            this.positiveLabel.TabIndex = 0;
            this.positiveLabel.Text = "Positive";
            this.positiveLabel.Click += new System.EventHandler(this.positiveLabel_Click);
            // 
            // exportPanel
            // 
            this.exportPanel.BackColor = System.Drawing.Color.Turquoise;
            this.exportPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportPanel.Controls.Add(this.exportLabel);
            this.exportPanel.Location = new System.Drawing.Point(39, 415);
            this.exportPanel.Name = "exportPanel";
            this.exportPanel.Size = new System.Drawing.Size(170, 38);
            this.exportPanel.TabIndex = 6;
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportLabel.Location = new System.Drawing.Point(39, 10);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(90, 16);
            this.exportLabel.TabIndex = 0;
            this.exportLabel.Text = "Export Files";
            this.exportLabel.Click += new System.EventHandler(this.exportLabel_Click);
            // 
            // ExtractButton
            // 
            this.ExtractButton.BackColor = System.Drawing.Color.Turquoise;
            this.ExtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractButton.Location = new System.Drawing.Point(39, 363);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(170, 37);
            this.ExtractButton.TabIndex = 5;
            this.ExtractButton.Text = "Import Files";
            this.ExtractButton.UseVisualStyleBackColor = false;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.Turquoise;
            this.deleteAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllButton.Location = new System.Drawing.Point(145, 321);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(103, 37);
            this.deleteAllButton.TabIndex = 4;
            this.deleteAllButton.Text = "Delete All ";
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Turquoise;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(3, 320);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 37);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // articlesListBox
            // 
            this.articlesListBox.FormattingEnabled = true;
            this.articlesListBox.Location = new System.Drawing.Point(3, 85);
            this.articlesListBox.Name = "articlesListBox";
            this.articlesListBox.Size = new System.Drawing.Size(245, 225);
            this.articlesListBox.TabIndex = 2;
            // 
            // Openfilesbutton
            // 
            this.Openfilesbutton.BackColor = System.Drawing.Color.Turquoise;
            this.Openfilesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Openfilesbutton.Location = new System.Drawing.Point(120, 24);
            this.Openfilesbutton.Name = "Openfilesbutton";
            this.Openfilesbutton.Size = new System.Drawing.Size(103, 37);
            this.Openfilesbutton.TabIndex = 1;
            this.Openfilesbutton.Text = "Open Files";
            this.Openfilesbutton.UseVisualStyleBackColor = false;
            this.Openfilesbutton.Click += new System.EventHandler(this.Openfilesbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse Files : ";
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.articleClassifierHeaderlabel);
            this.headerPanel.Location = new System.Drawing.Point(267, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(770, 50);
            this.headerPanel.TabIndex = 1;
            // 
            // articleClassifierHeaderlabel
            // 
            this.articleClassifierHeaderlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.articleClassifierHeaderlabel.AutoSize = true;
            this.articleClassifierHeaderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleClassifierHeaderlabel.Location = new System.Drawing.Point(248, 13);
            this.articleClassifierHeaderlabel.Name = "articleClassifierHeaderlabel";
            this.articleClassifierHeaderlabel.Size = new System.Drawing.Size(274, 24);
            this.articleClassifierHeaderlabel.TabIndex = 0;
            this.articleClassifierHeaderlabel.Text = "Articles Classification Report";
            // 
            // ArticlesClassifierdataGridView
            // 
            this.ArticlesClassifierdataGridView.AllowUserToAddRows = false;
            this.ArticlesClassifierdataGridView.AllowUserToDeleteRows = false;
            this.ArticlesClassifierdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticlesClassifierdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArticlesClassifierdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ArticlesClassifierdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ArticlesClassifierdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticlesClassifierdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalStatement,
            this.Classification});
            this.ArticlesClassifierdataGridView.Location = new System.Drawing.Point(267, 53);
            this.ArticlesClassifierdataGridView.Name = "ArticlesClassifierdataGridView";
            this.ArticlesClassifierdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArticlesClassifierdataGridView.Size = new System.Drawing.Size(770, 748);
            this.ArticlesClassifierdataGridView.TabIndex = 2;
            // 
            // OriginalStatement
            // 
            this.OriginalStatement.FillWeight = 152.2843F;
            this.OriginalStatement.HeaderText = "Original Statement";
            this.OriginalStatement.Name = "OriginalStatement";
            this.OriginalStatement.ReadOnly = true;
            this.OriginalStatement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Classification
            // 
            this.Classification.FillWeight = 47.71573F;
            this.Classification.HeaderText = "Classification";
            this.Classification.Name = "Classification";
            this.Classification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // exportTimer
            // 
            this.exportTimer.Interval = 20;
            this.exportTimer.Tick += new System.EventHandler(this.exportTimer_Tick);
            // 
            // ArticleClassifierUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ArticlesClassifierdataGridView);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.Articlepanel);
            this.Name = "ArticleClassifierUserControl";
            this.Size = new System.Drawing.Size(1037, 801);
            this.Articlepanel.ResumeLayout(false);
            this.Articlepanel.PerformLayout();
            this.dropDownPanel.ResumeLayout(false);
            this.dropDownPanel.PerformLayout();
            this.exportPanel.ResumeLayout(false);
            this.exportPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesClassifierdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Articlepanel;
        private System.Windows.Forms.Button Openfilesbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox articlesListBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label articleClassifierHeaderlabel;
        private System.Windows.Forms.DataGridView ArticlesClassifierdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel dropDownPanel;
        private System.Windows.Forms.Label neutralLabel;
        private System.Windows.Forms.Label negativeLabel;
        private System.Windows.Forms.Label positiveLabel;
        private System.Windows.Forms.Panel exportPanel;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.Timer exportTimer;

    }
}
