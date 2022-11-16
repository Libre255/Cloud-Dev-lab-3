namespace Lab3Winform
{
    partial class ListWIndow
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
            this.ListTable = new System.Windows.Forms.ListView();
            this.BtnAddWord = new System.Windows.Forms.Button();
            this.BtnRemoveWord = new System.Windows.Forms.Button();
            this.BtnPractice = new System.Windows.Forms.Button();
            this.BtnCloseListWindow = new System.Windows.Forms.Button();
            this.ListWindowLabel = new System.Windows.Forms.Label();
            this.ListWindowInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListTable
            // 
            this.ListTable.Location = new System.Drawing.Point(44, 77);
            this.ListTable.Name = "ListTable";
            this.ListTable.Size = new System.Drawing.Size(711, 259);
            this.ListTable.TabIndex = 0;
            this.ListTable.UseCompatibleStateImageBehavior = false;
            this.ListTable.View = System.Windows.Forms.View.Details;
            // 
            // BtnAddWord
            // 
            this.BtnAddWord.Location = new System.Drawing.Point(474, 356);
            this.BtnAddWord.Name = "BtnAddWord";
            this.BtnAddWord.Size = new System.Drawing.Size(75, 23);
            this.BtnAddWord.TabIndex = 1;
            this.BtnAddWord.Text = "Add word";
            this.BtnAddWord.UseVisualStyleBackColor = true;
            this.BtnAddWord.Click += new System.EventHandler(this.BtnAddWord_Click);
            // 
            // BtnRemoveWord
            // 
            this.BtnRemoveWord.Location = new System.Drawing.Point(555, 356);
            this.BtnRemoveWord.Name = "BtnRemoveWord";
            this.BtnRemoveWord.Size = new System.Drawing.Size(97, 23);
            this.BtnRemoveWord.TabIndex = 1;
            this.BtnRemoveWord.Text = "Remove word";
            this.BtnRemoveWord.UseVisualStyleBackColor = true;
            this.BtnRemoveWord.Click += new System.EventHandler(this.BtnRemoveWord_Click);
            // 
            // BtnPractice
            // 
            this.BtnPractice.Location = new System.Drawing.Point(658, 356);
            this.BtnPractice.Name = "BtnPractice";
            this.BtnPractice.Size = new System.Drawing.Size(97, 23);
            this.BtnPractice.TabIndex = 1;
            this.BtnPractice.Text = "Practice";
            this.BtnPractice.UseVisualStyleBackColor = true;
            this.BtnPractice.Click += new System.EventHandler(this.BtnPractice_Click);
            // 
            // BtnCloseListWindow
            // 
            this.BtnCloseListWindow.Location = new System.Drawing.Point(393, 356);
            this.BtnCloseListWindow.Name = "BtnCloseListWindow";
            this.BtnCloseListWindow.Size = new System.Drawing.Size(75, 23);
            this.BtnCloseListWindow.TabIndex = 2;
            this.BtnCloseListWindow.Text = "Cansel";
            this.BtnCloseListWindow.UseVisualStyleBackColor = true;
            this.BtnCloseListWindow.Click += new System.EventHandler(this.BtnCloseListWindow_Click);
            // 
            // ListWindowLabel
            // 
            this.ListWindowLabel.AutoSize = true;
            this.ListWindowLabel.Font = new System.Drawing.Font("Time Machino", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListWindowLabel.Location = new System.Drawing.Point(44, 7);
            this.ListWindowLabel.Name = "ListWindowLabel";
            this.ListWindowLabel.Size = new System.Drawing.Size(218, 67);
            this.ListWindowLabel.TabIndex = 3;
            this.ListWindowLabel.Text = "Words";
            // 
            // ListWindowInstructions
            // 
            this.ListWindowInstructions.AutoSize = true;
            this.ListWindowInstructions.Location = new System.Drawing.Point(602, 59);
            this.ListWindowInstructions.Name = "ListWindowInstructions";
            this.ListWindowInstructions.Size = new System.Drawing.Size(153, 15);
            this.ListWindowInstructions.TabIndex = 4;
            this.ListWindowInstructions.Text = "(click column name to sort)";
            // 
            // ListWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListWindowInstructions);
            this.Controls.Add(this.ListWindowLabel);
            this.Controls.Add(this.BtnCloseListWindow);
            this.Controls.Add(this.BtnPractice);
            this.Controls.Add(this.BtnRemoveWord);
            this.Controls.Add(this.BtnAddWord);
            this.Controls.Add(this.ListTable);
            this.Name = "ListWIndow";
            this.Text = "ListWIndow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView ListTable;
        private Button BtnAddWord;
        private Button BtnRemoveWord;
        private Button BtnPractice;
        private Button BtnCloseListWindow;
        private Label ListWindowLabel;
        private Label ListWindowInstructions;
    }
}