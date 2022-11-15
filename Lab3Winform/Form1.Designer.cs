namespace Lab3Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ListViewWordLists = new System.Windows.Forms.ListView();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnWordCount = new System.Windows.Forms.ColumnHeader();
            this.LabelMainTitel = new System.Windows.Forms.Label();
            this.ListOfLanguages = new System.Windows.Forms.ListView();
            this.columnLanguage = new System.Windows.Forms.ColumnHeader();
            this.labelWordList = new System.Windows.Forms.Label();
            this.BtnNewList = new System.Windows.Forms.Button();
            this.BtnCansel = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnRefreshWordsList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewWordLists
            // 
            this.ListViewWordLists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnWordCount});
            this.ListViewWordLists.Location = new System.Drawing.Point(141, 152);
            this.ListViewWordLists.Name = "ListViewWordLists";
            this.ListViewWordLists.Size = new System.Drawing.Size(260, 203);
            this.ListViewWordLists.TabIndex = 0;
            this.ListViewWordLists.UseCompatibleStateImageBehavior = false;
            this.ListViewWordLists.View = System.Windows.Forms.View.Details;
            this.ListViewWordLists.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 160;
            // 
            // ColumnWordCount
            // 
            this.ColumnWordCount.Text = "Word count";
            this.ColumnWordCount.Width = 90;
            // 
            // LabelMainTitel
            // 
            this.LabelMainTitel.AutoSize = true;
            this.LabelMainTitel.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMainTitel.Location = new System.Drawing.Point(292, 9);
            this.LabelMainTitel.Name = "LabelMainTitel";
            this.LabelMainTitel.Size = new System.Drawing.Size(327, 43);
            this.LabelMainTitel.TabIndex = 1;
            this.LabelMainTitel.Text = "Select word list";
            // 
            // ListOfLanguages
            // 
            this.ListOfLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLanguage});
            this.ListOfLanguages.Location = new System.Drawing.Point(436, 152);
            this.ListOfLanguages.Name = "ListOfLanguages";
            this.ListOfLanguages.Size = new System.Drawing.Size(258, 203);
            this.ListOfLanguages.TabIndex = 0;
            this.ListOfLanguages.UseCompatibleStateImageBehavior = false;
            this.ListOfLanguages.View = System.Windows.Forms.View.Details;
            // 
            // columnLanguage
            // 
            this.columnLanguage.Text = "Languages";
            this.columnLanguage.Width = 180;
            // 
            // labelWordList
            // 
            this.labelWordList.AutoSize = true;
            this.labelWordList.Location = new System.Drawing.Point(141, 134);
            this.labelWordList.Name = "labelWordList";
            this.labelWordList.Size = new System.Drawing.Size(64, 15);
            this.labelWordList.TabIndex = 2;
            this.labelWordList.Text = "Words lists";
            // 
            // BtnNewList
            // 
            this.BtnNewList.Location = new System.Drawing.Point(141, 375);
            this.BtnNewList.Name = "BtnNewList";
            this.BtnNewList.Size = new System.Drawing.Size(75, 23);
            this.BtnNewList.TabIndex = 3;
            this.BtnNewList.Text = "New list";
            this.BtnNewList.UseVisualStyleBackColor = true;
            this.BtnNewList.Click += new System.EventHandler(this.BtnNewList_Click);
            // 
            // BtnCansel
            // 
            this.BtnCansel.Location = new System.Drawing.Point(436, 375);
            this.BtnCansel.Name = "BtnCansel";
            this.BtnCansel.Size = new System.Drawing.Size(75, 23);
            this.BtnCansel.TabIndex = 3;
            this.BtnCansel.Text = "Cancel";
            this.BtnCansel.UseVisualStyleBackColor = true;
            this.BtnCansel.Click += new System.EventHandler(this.BtnCansel_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(619, 375);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 3;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnRefreshWordsList
            // 
            this.BtnRefreshWordsList.Location = new System.Drawing.Point(326, 123);
            this.BtnRefreshWordsList.Name = "BtnRefreshWordsList";
            this.BtnRefreshWordsList.Size = new System.Drawing.Size(75, 23);
            this.BtnRefreshWordsList.TabIndex = 4;
            this.BtnRefreshWordsList.Text = "Refresh";
            this.BtnRefreshWordsList.UseVisualStyleBackColor = true;
            this.BtnRefreshWordsList.Click += new System.EventHandler(this.BtnRefreshWordsList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRefreshWordsList);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnCansel);
            this.Controls.Add(this.BtnNewList);
            this.Controls.Add(this.labelWordList);
            this.Controls.Add(this.LabelMainTitel);
            this.Controls.Add(this.ListOfLanguages);
            this.Controls.Add(this.ListViewWordLists);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bindingSource1;
        private ListView ListViewWordLists;
        private Label LabelMainTitel;
        private ListView ListOfLanguages;
        private Label labelWordList;
        private Label LabelWordCount;
        private Label LabelNrWordCount;
        private Button BtnNewList;
        private Button BtnCansel;
        private Button BtnSelect;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnWordCount;
        private ColumnHeader columnLanguage;
        private Button BtnRefreshWordsList;
    }
}