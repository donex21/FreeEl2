namespace DonilFreeEl
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.ArticlesDeviderbutton = new System.Windows.Forms.Button();
            this.TestdataButton = new System.Windows.Forms.Button();
            this.bagsOfWordsButton = new System.Windows.Forms.Button();
            this.textCleaningbutton = new System.Windows.Forms.Button();
            this.articlesClassifierbutton = new System.Windows.Forms.Button();
            this.UserControlpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UserInputbutton = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.UserControlpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonsPanel.Controls.Add(this.UserInputbutton);
            this.buttonsPanel.Controls.Add(this.ArticlesDeviderbutton);
            this.buttonsPanel.Controls.Add(this.TestdataButton);
            this.buttonsPanel.Controls.Add(this.bagsOfWordsButton);
            this.buttonsPanel.Controls.Add(this.textCleaningbutton);
            this.buttonsPanel.Controls.Add(this.articlesClassifierbutton);
            this.buttonsPanel.Location = new System.Drawing.Point(1, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(116, 649);
            this.buttonsPanel.TabIndex = 0;
            // 
            // ArticlesDeviderbutton
            // 
            this.ArticlesDeviderbutton.BackColor = System.Drawing.Color.Turquoise;
            this.ArticlesDeviderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticlesDeviderbutton.Location = new System.Drawing.Point(1, 122);
            this.ArticlesDeviderbutton.Name = "ArticlesDeviderbutton";
            this.ArticlesDeviderbutton.Size = new System.Drawing.Size(115, 42);
            this.ArticlesDeviderbutton.TabIndex = 4;
            this.ArticlesDeviderbutton.Text = "File Divider";
            this.ArticlesDeviderbutton.UseVisualStyleBackColor = false;
            this.ArticlesDeviderbutton.Click += new System.EventHandler(this.ArticlesDeviderbutton_Click);
            // 
            // TestdataButton
            // 
            this.TestdataButton.BackColor = System.Drawing.Color.Turquoise;
            this.TestdataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestdataButton.Location = new System.Drawing.Point(0, 221);
            this.TestdataButton.Name = "TestdataButton";
            this.TestdataButton.Size = new System.Drawing.Size(115, 42);
            this.TestdataButton.TabIndex = 3;
            this.TestdataButton.Text = "Test Data";
            this.TestdataButton.UseVisualStyleBackColor = false;
            this.TestdataButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // bagsOfWordsButton
            // 
            this.bagsOfWordsButton.BackColor = System.Drawing.Color.Turquoise;
            this.bagsOfWordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagsOfWordsButton.Location = new System.Drawing.Point(1, 172);
            this.bagsOfWordsButton.Name = "bagsOfWordsButton";
            this.bagsOfWordsButton.Size = new System.Drawing.Size(115, 42);
            this.bagsOfWordsButton.TabIndex = 2;
            this.bagsOfWordsButton.Text = "Bags Of Words";
            this.bagsOfWordsButton.UseVisualStyleBackColor = false;
            this.bagsOfWordsButton.Click += new System.EventHandler(this.bagsOfWordsButton_Click);
            // 
            // textCleaningbutton
            // 
            this.textCleaningbutton.BackColor = System.Drawing.Color.Turquoise;
            this.textCleaningbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCleaningbutton.Location = new System.Drawing.Point(1, 73);
            this.textCleaningbutton.Name = "textCleaningbutton";
            this.textCleaningbutton.Size = new System.Drawing.Size(115, 42);
            this.textCleaningbutton.TabIndex = 1;
            this.textCleaningbutton.Text = "Text Cleaning";
            this.textCleaningbutton.UseVisualStyleBackColor = false;
            this.textCleaningbutton.Click += new System.EventHandler(this.textCleaningbutton_Click);
            // 
            // articlesClassifierbutton
            // 
            this.articlesClassifierbutton.BackColor = System.Drawing.Color.Turquoise;
            this.articlesClassifierbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlesClassifierbutton.Location = new System.Drawing.Point(0, 25);
            this.articlesClassifierbutton.Name = "articlesClassifierbutton";
            this.articlesClassifierbutton.Size = new System.Drawing.Size(115, 42);
            this.articlesClassifierbutton.TabIndex = 0;
            this.articlesClassifierbutton.Text = "Articles Classifier";
            this.articlesClassifierbutton.UseVisualStyleBackColor = false;
            this.articlesClassifierbutton.Click += new System.EventHandler(this.articlesClassifierbutton_Click);
            // 
            // UserControlpanel
            // 
            this.UserControlpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserControlpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserControlpanel.BackgroundImage")));
            this.UserControlpanel.Controls.Add(this.panel1);
            this.UserControlpanel.Location = new System.Drawing.Point(120, 0);
            this.UserControlpanel.Name = "UserControlpanel";
            this.UserControlpanel.Size = new System.Drawing.Size(867, 649);
            this.UserControlpanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(411, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 286);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "John Micheal Permison";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Julius Fabrique";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Donil Ponce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Researcher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(160, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mr. Eric P. Ortega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(196, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adviser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(113, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Text Classification)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(113, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA MINING";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // UserInputbutton
            // 
            this.UserInputbutton.BackColor = System.Drawing.Color.Turquoise;
            this.UserInputbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputbutton.Location = new System.Drawing.Point(1, 272);
            this.UserInputbutton.Name = "UserInputbutton";
            this.UserInputbutton.Size = new System.Drawing.Size(115, 42);
            this.UserInputbutton.TabIndex = 5;
            this.UserInputbutton.Text = "User Input Text";
            this.UserInputbutton.UseVisualStyleBackColor = false;
            this.UserInputbutton.Click += new System.EventHandler(this.UserInputbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 650);
            this.Controls.Add(this.UserControlpanel);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "Form1";
            this.Text = "Free Elective 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.buttonsPanel.ResumeLayout(false);
            this.UserControlpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button articlesClassifierbutton;
        private System.Windows.Forms.Button textCleaningbutton;
        private System.Windows.Forms.Panel UserControlpanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button bagsOfWordsButton;
        private System.Windows.Forms.Button TestdataButton;
        private System.Windows.Forms.Button ArticlesDeviderbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserInputbutton;
    }
}

