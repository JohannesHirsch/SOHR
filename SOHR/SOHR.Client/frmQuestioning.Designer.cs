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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestioning));
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.dgvAnswers = new System.Windows.Forms.DataGridView();
            this.btnAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(16, 15);
            this.tbxQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.ReadOnly = true;
            this.tbxQuestion.Size = new System.Drawing.Size(868, 22);
            this.tbxQuestion.TabIndex = 0;
            // 
            // dgvAnswers
            // 
            this.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswers.Location = new System.Drawing.Point(16, 47);
            this.dgvAnswers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAnswers.MultiSelect = false;
            this.dgvAnswers.Name = "dgvAnswers";
            this.dgvAnswers.ReadOnly = true;
            this.dgvAnswers.Size = new System.Drawing.Size(869, 297);
            this.dgvAnswers.TabIndex = 1;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(723, 351);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(163, 28);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Anwort wählen";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // frmQuestioning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 394);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.dgvAnswers);
            this.Controls.Add(this.tbxQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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