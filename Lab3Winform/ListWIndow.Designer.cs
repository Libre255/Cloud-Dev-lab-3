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
            // 
            // BtnRemoveWord
            // 
            this.BtnRemoveWord.Location = new System.Drawing.Point(555, 356);
            this.BtnRemoveWord.Name = "BtnRemoveWord";
            this.BtnRemoveWord.Size = new System.Drawing.Size(97, 23);
            this.BtnRemoveWord.TabIndex = 1;
            this.BtnRemoveWord.Text = "Remove word";
            this.BtnRemoveWord.UseVisualStyleBackColor = true;
            // 
            // BtnPractice
            // 
            this.BtnPractice.Location = new System.Drawing.Point(658, 356);
            this.BtnPractice.Name = "BtnPractice";
            this.BtnPractice.Size = new System.Drawing.Size(97, 23);
            this.BtnPractice.TabIndex = 1;
            this.BtnPractice.Text = "Practice";
            this.BtnPractice.UseVisualStyleBackColor = true;
            // 
            // ListWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPractice);
            this.Controls.Add(this.BtnRemoveWord);
            this.Controls.Add(this.BtnAddWord);
            this.Controls.Add(this.ListTable);
            this.Name = "ListWIndow";
            this.Text = "ListWIndow";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ListTable;
        private Button BtnAddWord;
        private Button BtnRemoveWord;
        private Button BtnPractice;
    }
}