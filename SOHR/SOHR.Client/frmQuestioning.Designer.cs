namespace SOHR.Client
{
    partial class frmQuestioning
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
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.dgvAnswers = new System.Windows.Forms.DataGridView();
            this.btnAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(12, 12);
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.ReadOnly = true;
            this.tbxQuestion.Size = new System.Drawing.Size(652, 20);
            this.tbxQuestion.TabIndex = 0;
            // 
            // dgvAnswers
            // 
            this.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswers.Location = new System.Drawing.Point(12, 38);
            this.dgvAnswers.MultiSelect = false;
            this.dgvAnswers.Name = "dgvAnswers";
            this.dgvAnswers.ReadOnly = true;
            this.dgvAnswers.Size = new System.Drawing.Size(652, 241);
            this.dgvAnswers.TabIndex = 1;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(542, 285);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(122, 23);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Anwort wählen";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // frmQuestioning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 320);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.dgvAnswers);
            this.Controls.Add(this.tbxQuestion);
            this.Name = "frmQuestioning";
            this.Text = "Befragung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.DataGridView dgvAnswers;
        private System.Windows.Forms.Button btnAnswer;
    }
}