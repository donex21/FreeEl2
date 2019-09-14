namespace DonilFreeEl
{
    partial class MachineProb
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
            this.MachineProbDataGridView = new System.Windows.Forms.DataGridView();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MachineProbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Probability";
            // 
            // MachineProbDataGridView
            // 
            this.MachineProbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MachineProbDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MachineProbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachineProbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.sen,
            this.pos,
            this.neg,
            this.Neu});
            this.MachineProbDataGridView.Location = new System.Drawing.Point(12, 52);
            this.MachineProbDataGridView.Name = "MachineProbDataGridView";
            this.MachineProbDataGridView.RowHeadersVisible = false;
            this.MachineProbDataGridView.Size = new System.Drawing.Size(906, 480);
            this.MachineProbDataGridView.TabIndex = 1;
            // 
            // count
            // 
            this.count.FillWeight = 20.30457F;
            this.count.HeaderText = "No.";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // sen
            // 
            this.sen.FillWeight = 243.5002F;
            this.sen.HeaderText = "Sentences";
            this.sen.Name = "sen";
            this.sen.ReadOnly = true;
            // 
            // pos
            // 
            this.pos.FillWeight = 78.73174F;
            this.pos.HeaderText = "Positive";
            this.pos.Name = "pos";
            this.pos.ReadOnly = true;
            // 
            // neg
            // 
            this.neg.FillWeight = 78.73174F;
            this.neg.HeaderText = "Negative";
            this.neg.Name = "neg";
            this.neg.ReadOnly = true;
            // 
            // Neu
            // 
            this.Neu.FillWeight = 78.73174F;
            this.Neu.HeaderText = "Neutral";
            this.Neu.Name = "Neu";
            this.Neu.ReadOnly = true;
            // 
            // MachineProb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 544);
            this.ControlBox = false;
            this.Controls.Add(this.MachineProbDataGridView);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(946, 583);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(946, 583);
            this.Name = "MachineProb";
            this.Text = "MachineProb";
            this.Load += new System.EventHandler(this.MachineProb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MachineProbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView MachineProbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn sen;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn neg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neu;
    }
}