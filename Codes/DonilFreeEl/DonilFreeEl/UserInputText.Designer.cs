namespace DonilFreeEl
{
    partial class UserInputText
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
            this.BOWFilebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowBOWbutton = new System.Windows.Forms.Button();
            this.UserInputtextBox = new System.Windows.Forms.TextBox();
            this.MachineResulttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearTextbutton = new System.Windows.Forms.Button();
            this.Enterbutton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BOWFilebutton
            // 
            this.BOWFilebutton.BackColor = System.Drawing.Color.Turquoise;
            this.BOWFilebutton.CausesValidation = false;
            this.BOWFilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOWFilebutton.Location = new System.Drawing.Point(3, 59);
            this.BOWFilebutton.Name = "BOWFilebutton";
            this.BOWFilebutton.Size = new System.Drawing.Size(143, 44);
            this.BOWFilebutton.TabIndex = 2;
            this.BOWFilebutton.Text = "Open BOW Model Files";
            this.BOWFilebutton.UseVisualStyleBackColor = false;
            this.BOWFilebutton.Click += new System.EventHandler(this.BOWFilebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 53);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "User\'s Input Text";
            // 
            // ShowBOWbutton
            // 
            this.ShowBOWbutton.BackColor = System.Drawing.Color.Turquoise;
            this.ShowBOWbutton.CausesValidation = false;
            this.ShowBOWbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBOWbutton.Location = new System.Drawing.Point(3, 109);
            this.ShowBOWbutton.Name = "ShowBOWbutton";
            this.ShowBOWbutton.Size = new System.Drawing.Size(143, 40);
            this.ShowBOWbutton.TabIndex = 20;
            this.ShowBOWbutton.Text = "Estimates Scores";
            this.ShowBOWbutton.UseVisualStyleBackColor = false;
            this.ShowBOWbutton.Click += new System.EventHandler(this.ShowBOWbutton_Click);
            // 
            // UserInputtextBox
            // 
            this.UserInputtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputtextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserInputtextBox.Location = new System.Drawing.Point(286, 167);
            this.UserInputtextBox.Name = "UserInputtextBox";
            this.UserInputtextBox.Size = new System.Drawing.Size(654, 38);
            this.UserInputtextBox.TabIndex = 21;
            this.UserInputtextBox.Text = "INPUT TEXT";
            this.UserInputtextBox.Enter += new System.EventHandler(this.UserInputtextBox_Enter);
            this.UserInputtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInputtextBox_KeyPress);
            // 
            // MachineResulttextBox
            // 
            this.MachineResulttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineResulttextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MachineResulttextBox.Location = new System.Drawing.Point(525, 358);
            this.MachineResulttextBox.Name = "MachineResulttextBox";
            this.MachineResulttextBox.Size = new System.Drawing.Size(216, 38);
            this.MachineResulttextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result: ";
            // 
            // ClearTextbutton
            // 
            this.ClearTextbutton.BackColor = System.Drawing.Color.Turquoise;
            this.ClearTextbutton.CausesValidation = false;
            this.ClearTextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTextbutton.Location = new System.Drawing.Point(550, 220);
            this.ClearTextbutton.Name = "ClearTextbutton";
            this.ClearTextbutton.Size = new System.Drawing.Size(143, 40);
            this.ClearTextbutton.TabIndex = 23;
            this.ClearTextbutton.Text = "Clear Text";
            this.ClearTextbutton.UseVisualStyleBackColor = false;
            this.ClearTextbutton.Click += new System.EventHandler(this.ClearTextbutton_Click);
            // 
            // Enterbutton
            // 
            this.Enterbutton.BackColor = System.Drawing.Color.Turquoise;
            this.Enterbutton.CausesValidation = false;
            this.Enterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterbutton.Location = new System.Drawing.Point(957, 165);
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Size = new System.Drawing.Size(72, 40);
            this.Enterbutton.TabIndex = 24;
            this.Enterbutton.Text = "Enter";
            this.Enterbutton.UseVisualStyleBackColor = false;
            this.Enterbutton.Click += new System.EventHandler(this.Enterbutton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // UserInputText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Enterbutton);
            this.Controls.Add(this.ClearTextbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MachineResulttextBox);
            this.Controls.Add(this.UserInputtextBox);
            this.Controls.Add(this.ShowBOWbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BOWFilebutton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UserInputText";
            this.Size = new System.Drawing.Size(1032, 529);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BOWFilebutton;
        public System.Windows.Forms.Button ShowBOWbutton;
        private System.Windows.Forms.TextBox UserInputtextBox;
        private System.Windows.Forms.TextBox MachineResulttextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button ClearTextbutton;
        public System.Windows.Forms.Button Enterbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
