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
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRuleSetName
            // 
            this.tbxRuleSetName.Location = new System.Drawing.Point(78, 12);
            this.tbxRuleSetName.Name = "tbxRuleSetName";
            this.tbxRuleSetName.Size = new System.Drawing.Size(683, 20);
            this.tbxRuleSetName.TabIndex = 0;
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
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(803, 591);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(13, 88);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.Size = new System.Drawing.Size(747, 238);
            this.dgvQuestions.TabIndex = 5;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(13, 350);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(747, 228);
            this.dgvResults.TabIndex = 5;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(767, 146);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "Frage löschen";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(767, 366);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.ReadOnly = true;
            this.tbxMin.Size = new System.Drawing.Size(100, 20);
            this.tbxMin.TabIndex = 6;
            // 
            // tbxMax
            // 
            this.tbxMax.Location = new System.Drawing.Point(769, 405);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.ReadOnly = true;
            this.tbxMax.Size = new System.Drawing.Size(100, 20);
            this.tbxMax.TabIndex = 6;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(766, 350);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(99, 13);
            this.lbMin.TabIndex = 7;
            this.lbMin.Text = "Mögliches Minimum";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(766, 389);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(102, 13);
            this.lbMax.TabIndex = 7;
            this.lbMax.Text = "Mägliches Maximum";
            // 
            // frmRuleSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 627);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.tbxMax);
            this.Controls.Add(this.tbxMin);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.tbxComment);
            this.Controls.Add(this.tbxRuleSetName);
            this.Name = "frmRuleSet";
            this.Text = "Fragensatz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRuleSetName;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
    }
}