namespace Lab3Winform
{
    partial class PracticeWindow
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
            this.labelPracticeWindow = new System.Windows.Forms.Label();
            this.labelPractInstructions = new System.Windows.Forms.Label();
            this.textBoxPractice = new System.Windows.Forms.TextBox();
            this.btnPracticeCansel = new System.Windows.Forms.Button();
            this.BtnPracticeSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPracticeWindow
            // 
            this.labelPracticeWindow.AutoSize = true;
            this.labelPracticeWindow.Font = new System.Drawing.Font("Trajan Pro 3", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPracticeWindow.Location = new System.Drawing.Point(223, 9);
            this.labelPracticeWindow.Name = "labelPracticeWindow";
            this.labelPracticeWindow.Size = new System.Drawing.Size(322, 54);
            this.labelPracticeWindow.TabIndex = 0;
            this.labelPracticeWindow.Text = "Practice time!";
            // 
            // labelPractInstructions
            // 
            this.labelPractInstructions.AutoSize = true;
            this.labelPractInstructions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPractInstructions.Location = new System.Drawing.Point(65, 110);
            this.labelPractInstructions.Name = "labelPractInstructions";
            this.labelPractInstructions.Size = new System.Drawing.Size(310, 30);
            this.labelPractInstructions.TabIndex = 1;
            this.labelPractInstructions.Text = "Translate the following word to :";
            // 
            // textBoxPractice
            // 
            this.textBoxPractice.Location = new System.Drawing.Point(281, 176);
            this.textBoxPractice.Name = "textBoxPractice";
            this.textBoxPractice.Size = new System.Drawing.Size(209, 23);
            this.textBoxPractice.TabIndex = 2;
            this.textBoxPractice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPracticeCansel
            // 
            this.btnPracticeCansel.Location = new System.Drawing.Point(223, 246);
            this.btnPracticeCansel.Name = "btnPracticeCansel";
            this.btnPracticeCansel.Size = new System.Drawing.Size(75, 23);
            this.btnPracticeCansel.TabIndex = 3;
            this.btnPracticeCansel.Text = "Cancel";
            this.btnPracticeCansel.UseVisualStyleBackColor = true;
            this.btnPracticeCansel.Click += new System.EventHandler(this.btnPracticeCansel_Click);
            // 
            // BtnPracticeSubmit
            // 
            this.BtnPracticeSubmit.Location = new System.Drawing.Point(470, 246);
            this.BtnPracticeSubmit.Name = "BtnPracticeSubmit";
            this.BtnPracticeSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnPracticeSubmit.TabIndex = 3;
            this.BtnPracticeSubmit.Text = "Submit";
            this.BtnPracticeSubmit.UseVisualStyleBackColor = true;
            this.BtnPracticeSubmit.Click += new System.EventHandler(this.BtnPracticeSubmit_Click);
            // 
            // PracticeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPracticeSubmit);
            this.Controls.Add(this.btnPracticeCansel);
            this.Controls.Add(this.textBoxPractice);
            this.Controls.Add(this.labelPractInstructions);
            this.Controls.Add(this.labelPracticeWindow);
            this.Name = "PracticeWindow";
            this.Text = "PracticeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPracticeWindow;
        private Label labelPractInstructions;
        private TextBox textBoxPractice;
        private Button btnPracticeCansel;
        private Button BtnPracticeSubmit;
    }
}