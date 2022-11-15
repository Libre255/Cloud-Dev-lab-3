namespace Lab3Winform
{
    partial class AddWordWindow
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
            this.AddAWordLabel = new System.Windows.Forms.Label();
            this.BtnCloseAddAWord = new System.Windows.Forms.Button();
            this.BtnAddWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAWordLabel
            // 
            this.AddAWordLabel.AutoSize = true;
            this.AddAWordLabel.Font = new System.Drawing.Font("Script MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAWordLabel.Location = new System.Drawing.Point(307, 9);
            this.AddAWordLabel.Name = "AddAWordLabel";
            this.AddAWordLabel.Size = new System.Drawing.Size(181, 41);
            this.AddAWordLabel.TabIndex = 0;
            this.AddAWordLabel.Text = "Add a word";
            // 
            // BtnCloseAddAWord
            // 
            this.BtnCloseAddAWord.Location = new System.Drawing.Point(651, 228);
            this.BtnCloseAddAWord.Name = "BtnCloseAddAWord";
            this.BtnCloseAddAWord.Size = new System.Drawing.Size(75, 23);
            this.BtnCloseAddAWord.TabIndex = 1;
            this.BtnCloseAddAWord.Text = "Cansel";
            this.BtnCloseAddAWord.UseVisualStyleBackColor = true;
            this.BtnCloseAddAWord.Click += new System.EventHandler(this.BtnCloseAddAWord_Click);
            // 
            // BtnAddWord
            // 
            this.BtnAddWord.Location = new System.Drawing.Point(651, 189);
            this.BtnAddWord.Name = "BtnAddWord";
            this.BtnAddWord.Size = new System.Drawing.Size(75, 23);
            this.BtnAddWord.TabIndex = 2;
            this.BtnAddWord.Text = "Add word";
            this.BtnAddWord.UseVisualStyleBackColor = true;
            this.BtnAddWord.Click += new System.EventHandler(this.BtnAddWord_Click);
            // 
            // AddWordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddWord);
            this.Controls.Add(this.BtnCloseAddAWord);
            this.Controls.Add(this.AddAWordLabel);
            this.Name = "AddWordWindow";
            this.Text = "AddWordWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddAWordLabel;
        private Button BtnCloseAddAWord;
        private Button BtnAddWord;
    }
}