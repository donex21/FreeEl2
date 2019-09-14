namespace DonilFreeEl
{
    partial class BOW
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
            this.label1 = new System.Windows.Forms.Label();
            this.BOWdataGridView = new System.Windows.Forms.DataGridView();
            this.WORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEGATIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEUTRAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BOWdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTIMATES SCORES";
            // 
            // BOWdataGridView
            // 
            this.BOWdataGridView.AllowUserToAddRows = false;
            this.BOWdataGridView.AllowUserToDeleteRows = false;
            this.BOWdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BOWdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BOWdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BOWdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WORD,
            this.POSITIVE,
            this.NEGATIVE,
            this.NEUTRAL});
            this.BOWdataGridView.Location = new System.Drawing.Point(12, 47);
            this.BOWdataGridView.Name = "BOWdataGridView";
            this.BOWdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BOWdataGridView.Size = new System.Drawing.Size(908, 454);
            this.BOWdataGridView.TabIndex = 1;
            // 
            // WORD
            // 
            this.WORD.HeaderText = "WORD";
            this.WORD.Name = "WORD";
            this.WORD.ReadOnly = true;
            // 
            // POSITIVE
            // 
            this.POSITIVE.HeaderText = "POSITIVE";
            this.POSITIVE.Name = "POSITIVE";
            this.POSITIVE.ReadOnly = true;
            // 
            // NEGATIVE
            // 
            this.NEGATIVE.HeaderText = "NEGATIVE";
            this.NEGATIVE.Name = "NEGATIVE";
            this.NEGATIVE.ReadOnly = true;
            // 
            // NEUTRAL
            // 
            this.NEUTRAL.HeaderText = "NEUTRAL";
            this.NEUTRAL.Name = "NEUTRAL";
            this.NEUTRAL.ReadOnly = true;
            // 
            // BOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 501);
            this.ControlBox = false;
            this.Controls.Add(this.BOWdataGridView);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(948, 540);
            this.MinimumSize = new System.Drawing.Size(948, 540);
            this.Name = "BOW";
            this.Text = "BOW";
            ((System.ComponentModel.ISupportInitialize)(this.BOWdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView BOWdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEGATIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEUTRAL;
    }
}