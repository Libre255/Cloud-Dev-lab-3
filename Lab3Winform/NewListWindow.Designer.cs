namespace Lab3Winform
{
    partial class NewListWindow
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
            this.BtnAddLanguage = new System.Windows.Forms.Button();
            this.BtnCreateList = new System.Windows.Forms.Button();
            this.NewListLanguages = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.LabelListName = new System.Windows.Forms.Label();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.btnNewListCansel = new System.Windows.Forms.Button();
            this.textBoxLanguageInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddLanguage
            // 
            this.BtnAddLanguage.Location = new System.Drawing.Point(521, 140);
            this.BtnAddLanguage.Name = "BtnAddLanguage";
            this.BtnAddLanguage.Size = new System.Drawing.Size(120, 23);
            this.BtnAddLanguage.TabIndex = 2;
            this.BtnAddLanguage.Text = "Add language";
            this.BtnAddLanguage.UseVisualStyleBackColor = true;
            this.BtnAddLanguage.Click += new System.EventHandler(this.BtnAddLanguage_Click);
            // 
            // BtnCreateList
            // 
            this.BtnCreateList.Location = new System.Drawing.Point(308, 376);
            this.BtnCreateList.Name = "BtnCreateList";
            this.BtnCreateList.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateList.TabIndex = 2;
            this.BtnCreateList.Text = "Create list";
            this.BtnCreateList.UseVisualStyleBackColor = true;
            this.BtnCreateList.Click += new System.EventHandler(this.BtnCreateList_Click);
            // 
            // NewListLanguages
            // 
            this.NewListLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.NewListLanguages.Location = new System.Drawing.Point(119, 170);
            this.NewListLanguages.Name = "NewListLanguages";
            this.NewListLanguages.Size = new System.Drawing.Size(522, 200);
            this.NewListLanguages.TabIndex = 3;
            this.NewListLanguages.UseCompatibleStateImageBehavior = false;
            this.NewListLanguages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Languages";
            this.columnHeader1.Width = 200;
            // 
            // LabelListName
            // 
            this.LabelListName.AutoSize = true;
            this.LabelListName.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelListName.Location = new System.Drawing.Point(71, 102);
            this.LabelListName.Name = "LabelListName";
            this.LabelListName.Size = new System.Drawing.Size(198, 36);
            this.LabelListName.TabIndex = 4;
            this.LabelListName.Text = "List name";
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(119, 141);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(100, 23);
            this.textBoxListName.TabIndex = 5;
            this.textBoxListName.TextChanged += new System.EventHandler(this.textBoxListName_TextChanged);
            // 
            // btnNewListCansel
            // 
            this.btnNewListCansel.Location = new System.Drawing.Point(389, 376);
            this.btnNewListCansel.Name = "btnNewListCansel";
            this.btnNewListCansel.Size = new System.Drawing.Size(75, 23);
            this.btnNewListCansel.TabIndex = 6;
            this.btnNewListCansel.Text = "Cansel";
            this.btnNewListCansel.UseVisualStyleBackColor = true;
            this.btnNewListCansel.Click += new System.EventHandler(this.btnNewListCansel_Click);
            // 
            // textBoxLanguageInput
            // 
            this.textBoxLanguageInput.Location = new System.Drawing.Point(415, 140);
            this.textBoxLanguageInput.Name = "textBoxLanguageInput";
            this.textBoxLanguageInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxLanguageInput.TabIndex = 5;
            this.textBoxLanguageInput.TextChanged += new System.EventHandler(this.textBoxListName_TextChanged);
            // 
            // NewListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewListCansel);
            this.Controls.Add(this.textBoxLanguageInput);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.LabelListName);
            this.Controls.Add(this.NewListLanguages);
            this.Controls.Add(this.BtnCreateList);
            this.Controls.Add(this.BtnAddLanguage);
            this.Name = "NewListWindow";
            this.Text = "NewListWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddLanguage;
        private Button BtnCreateList;
        private ListView NewListLanguages;
        private ColumnHeader columnHeader1;
        private Label LabelListName;
        private TextBox textBoxListName;
        private Button btnNewListCansel;
        private TextBox textBoxLanguageInput;
    }
}