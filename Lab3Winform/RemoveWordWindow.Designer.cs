namespace Lab3Winform
{
    partial class RemoveWordWindow
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
            this.RemoveWordLabel = new System.Windows.Forms.Label();
            this.ComboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.LabelRemoveByLanguage = new System.Windows.Forms.Label();
            this.LabelWriteWord = new System.Windows.Forms.Label();
            this.TextBoxRemoveWord = new System.Windows.Forms.TextBox();
            this.BtnCanselRemoveWindow = new System.Windows.Forms.Button();
            this.BtnRemoveWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveWordLabel
            // 
            this.RemoveWordLabel.AutoSize = true;
            this.RemoveWordLabel.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveWordLabel.Location = new System.Drawing.Point(238, 32);
            this.RemoveWordLabel.Name = "RemoveWordLabel";
            this.RemoveWordLabel.Size = new System.Drawing.Size(266, 38);
            this.RemoveWordLabel.TabIndex = 0;
            this.RemoveWordLabel.Text = "Remove a word";
            // 
            // ComboBoxLanguages
            // 
            this.ComboBoxLanguages.FormattingEnabled = true;
            this.ComboBoxLanguages.Location = new System.Drawing.Point(296, 123);
            this.ComboBoxLanguages.Name = "ComboBoxLanguages";
            this.ComboBoxLanguages.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxLanguages.TabIndex = 1;
            // 
            // LabelRemoveByLanguage
            // 
            this.LabelRemoveByLanguage.AutoSize = true;
            this.LabelRemoveByLanguage.Location = new System.Drawing.Point(310, 105);
            this.LabelRemoveByLanguage.Name = "LabelRemoveByLanguage";
            this.LabelRemoveByLanguage.Size = new System.Drawing.Size(90, 15);
            this.LabelRemoveByLanguage.TabIndex = 2;
            this.LabelRemoveByLanguage.Text = "Select language";
            // 
            // LabelWriteWord
            // 
            this.LabelWriteWord.AutoSize = true;
            this.LabelWriteWord.Location = new System.Drawing.Point(324, 170);
            this.LabelWriteWord.Name = "LabelWriteWord";
            this.LabelWriteWord.Size = new System.Drawing.Size(65, 15);
            this.LabelWriteWord.TabIndex = 2;
            this.LabelWriteWord.Text = "Write word";
            // 
            // TextBoxRemoveWord
            // 
            this.TextBoxRemoveWord.Location = new System.Drawing.Point(296, 202);
            this.TextBoxRemoveWord.Name = "TextBoxRemoveWord";
            this.TextBoxRemoveWord.Size = new System.Drawing.Size(121, 23);
            this.TextBoxRemoveWord.TabIndex = 3;
            // 
            // BtnCanselRemoveWindow
            // 
            this.BtnCanselRemoveWindow.Location = new System.Drawing.Point(278, 244);
            this.BtnCanselRemoveWindow.Name = "BtnCanselRemoveWindow";
            this.BtnCanselRemoveWindow.Size = new System.Drawing.Size(75, 23);
            this.BtnCanselRemoveWindow.TabIndex = 4;
            this.BtnCanselRemoveWindow.Text = "Cansel";
            this.BtnCanselRemoveWindow.UseVisualStyleBackColor = true;
            this.BtnCanselRemoveWindow.Click += new System.EventHandler(this.BtnCanselRemoveWindow_Click);
            // 
            // BtnRemoveWord
            // 
            this.BtnRemoveWord.Location = new System.Drawing.Point(359, 244);
            this.BtnRemoveWord.Name = "BtnRemoveWord";
            this.BtnRemoveWord.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveWord.TabIndex = 4;
            this.BtnRemoveWord.Text = "Remove";
            this.BtnRemoveWord.UseVisualStyleBackColor = true;
            this.BtnRemoveWord.Click += new System.EventHandler(this.BtnRemoveWord_Click);
            // 
            // RemoveWordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRemoveWord);
            this.Controls.Add(this.BtnCanselRemoveWindow);
            this.Controls.Add(this.TextBoxRemoveWord);
            this.Controls.Add(this.LabelWriteWord);
            this.Controls.Add(this.LabelRemoveByLanguage);
            this.Controls.Add(this.ComboBoxLanguages);
            this.Controls.Add(this.RemoveWordLabel);
            this.Name = "RemoveWordWindow";
            this.Text = "RemoveWordWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label RemoveWordLabel;
        private ComboBox ComboBoxLanguages;
        private Label LabelRemoveByLanguage;
        private Label LabelWriteWord;
        private TextBox TextBoxRemoveWord;
        private Button BtnCanselRemoveWindow;
        private Button BtnRemoveWord;
    }
}