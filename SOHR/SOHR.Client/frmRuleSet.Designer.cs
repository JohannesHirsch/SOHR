namespace SOHR.Client
{
    partial class frmRuleSet
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
            this.tbxRuleSetName = new System.Windows.Forms.TextBox();
            this.lstvwQuestions = new System.Windows.Forms.ListView();
            this.lstvwResults = new System.Windows.Forms.ListView();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRuleSetName
            // 
            this.tbxRuleSetName.Location = new System.Drawing.Point(13, 13);
            this.tbxRuleSetName.Name = "tbxRuleSetName";
            this.tbxRuleSetName.Size = new System.Drawing.Size(748, 20);
            this.tbxRuleSetName.TabIndex = 0;
            // 
            // lstvwQuestions
            // 
            this.lstvwQuestions.Location = new System.Drawing.Point(13, 40);
            this.lstvwQuestions.Name = "lstvwQuestions";
            this.lstvwQuestions.Size = new System.Drawing.Size(748, 229);
            this.lstvwQuestions.TabIndex = 1;
            this.lstvwQuestions.UseCompatibleStateImageBehavior = false;
            // 
            // lstvwResults
            // 
            this.lstvwResults.Location = new System.Drawing.Point(12, 301);
            this.lstvwResults.Name = "lstvwResults";
            this.lstvwResults.Size = new System.Drawing.Size(748, 229);
            this.lstvwResults.TabIndex = 1;
            this.lstvwResults.UseCompatibleStateImageBehavior = false;
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Location = new System.Drawing.Point(767, 39);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(111, 23);
            this.btnNewQuestion.TabIndex = 2;
            this.btnNewQuestion.Text = "Neue Frage";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(767, 68);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(111, 23);
            this.btnEditQuestion.TabIndex = 2;
            this.btnEditQuestion.Text = "Frage bearbeiten";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Neues Ergebnis";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ergebnis bearbeiten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(803, 542);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(722, 542);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmRuleSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 579);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.lstvwResults);
            this.Controls.Add(this.lstvwQuestions);
            this.Controls.Add(this.tbxRuleSetName);
            this.Name = "frmRuleSet";
            this.Text = "Fragensatz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRuleSetName;
        private System.Windows.Forms.ListView lstvwResults;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lstvwQuestions;
    }
}