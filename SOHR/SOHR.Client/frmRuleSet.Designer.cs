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
            this.components = new System.ComponentModel.Container();
            this.tbxRuleSetName = new System.Windows.Forms.TextBox();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.srcQuestions = new System.Windows.Forms.BindingSource(this.components);
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.srcResult = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRuleSetName
            // 
            this.tbxRuleSetName.Location = new System.Drawing.Point(104, 15);
            this.tbxRuleSetName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRuleSetName.Name = "tbxRuleSetName";
            this.tbxRuleSetName.Size = new System.Drawing.Size(909, 22);
            this.tbxRuleSetName.TabIndex = 0;
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Location = new System.Drawing.Point(1023, 108);
            this.btnNewQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(148, 28);
            this.btnNewQuestion.TabIndex = 2;
            this.btnNewQuestion.Text = "Neue Frage";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(1023, 144);
            this.btnEditQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(148, 28);
            this.btnEditQuestion.TabIndex = 2;
            this.btnEditQuestion.Text = "Frage bearbeiten";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1023, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Neues Ergebnis";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1023, 466);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ergebnis bearbeiten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(1071, 727);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(963, 727);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(104, 48);
            this.tbxComment.Margin = new System.Windows.Forms.Padding(4);
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.Size = new System.Drawing.Size(908, 22);
            this.tbxComment.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(16, 18);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(16, 52);
            this.lbComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(80, 17);
            this.lbComment.TabIndex = 4;
            this.lbComment.Text = "Kommentar";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AutoGenerateColumns = false;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.DataSource = this.srcQuestions;
            this.dgvQuestions.Location = new System.Drawing.Point(17, 108);
            this.dgvQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.Size = new System.Drawing.Size(996, 293);
            this.dgvQuestions.TabIndex = 5;
            // 
            // dgvResults
            // 
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.DataSource = this.srcResult;
            this.dgvResults.Location = new System.Drawing.Point(17, 431);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(996, 281);
            this.dgvResults.TabIndex = 5;
            // 
            // frmRuleSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 772);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.tbxComment);
            this.Controls.Add(this.tbxRuleSetName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRuleSet";
            this.Text = "Fragensatz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRuleSetName;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.BindingSource srcQuestions;
        private System.Windows.Forms.BindingSource srcResult;
    }
}