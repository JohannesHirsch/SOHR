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
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxRuleSetName
            // 
            this.tbxRuleSetName.Location = new System.Drawing.Point(78, 12);
            this.tbxRuleSetName.Name = "tbxRuleSetName";
            this.tbxRuleSetName.Size = new System.Drawing.Size(683, 20);
            this.tbxRuleSetName.TabIndex = 0;
            // 
            // lstvwQuestions
            // 
            this.lstvwQuestions.AutoArrange = false;
            this.lstvwQuestions.FullRowSelect = true;
            this.lstvwQuestions.GridLines = true;
            this.lstvwQuestions.LabelWrap = false;
            this.lstvwQuestions.Location = new System.Drawing.Point(13, 89);
            this.lstvwQuestions.MultiSelect = false;
            this.lstvwQuestions.Name = "lstvwQuestions";
            this.lstvwQuestions.Size = new System.Drawing.Size(748, 229);
            this.lstvwQuestions.TabIndex = 1;
            this.lstvwQuestions.UseCompatibleStateImageBehavior = false;
            this.lstvwQuestions.View = System.Windows.Forms.View.List;
            // 
            // lstvwResults
            // 
            this.lstvwResults.Location = new System.Drawing.Point(12, 350);
            this.lstvwResults.Name = "lstvwResults";
            this.lstvwResults.Size = new System.Drawing.Size(748, 229);
            this.lstvwResults.TabIndex = 1;
            this.lstvwResults.UseCompatibleStateImageBehavior = false;
            this.lstvwResults.View = System.Windows.Forms.View.List;
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Location = new System.Drawing.Point(767, 88);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(111, 23);
            this.btnNewQuestion.TabIndex = 2;
            this.btnNewQuestion.Text = "Neue Frage";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(767, 117);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(111, 23);
            this.btnEditQuestion.TabIndex = 2;
            this.btnEditQuestion.Text = "Frage bearbeiten";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Neues Ergebnis";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ergebnis bearbeiten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(803, 591);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(722, 591);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(78, 39);
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.Size = new System.Drawing.Size(682, 20);
            this.tbxComment.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(12, 42);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(60, 13);
            this.lbComment.TabIndex = 4;
            this.lbComment.Text = "Kommentar";
            // 
            // frmRuleSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 627);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.lstvwResults);
            this.Controls.Add(this.lstvwQuestions);
            this.Controls.Add(this.tbxComment);
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
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbComment;
    }
}