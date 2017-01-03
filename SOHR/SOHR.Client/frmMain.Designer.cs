namespace SOHR.Client
{
    partial class frmMain
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStartQuestioning = new System.Windows.Forms.Button();
            this.btnNewRuleSet = new System.Windows.Forms.Button();
            this.btnEditRuleSet = new System.Windows.Forms.Button();
            this.btnDeleteRuleSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnStartQuestioning
            // 
            this.btnStartQuestioning.Location = new System.Drawing.Point(235, 10);
            this.btnStartQuestioning.Name = "btnStartQuestioning";
            this.btnStartQuestioning.Size = new System.Drawing.Size(143, 23);
            this.btnStartQuestioning.TabIndex = 1;
            this.btnStartQuestioning.Text = "Befragung starten";
            this.btnStartQuestioning.UseVisualStyleBackColor = true;
            // 
            // btnNewRuleSet
            // 
            this.btnNewRuleSet.Location = new System.Drawing.Point(235, 39);
            this.btnNewRuleSet.Name = "btnNewRuleSet";
            this.btnNewRuleSet.Size = new System.Drawing.Size(143, 23);
            this.btnNewRuleSet.TabIndex = 1;
            this.btnNewRuleSet.Text = "Neuer Fragensatz";
            this.btnNewRuleSet.UseVisualStyleBackColor = true;
            // 
            // btnEditRuleSet
            // 
            this.btnEditRuleSet.Location = new System.Drawing.Point(235, 68);
            this.btnEditRuleSet.Name = "btnEditRuleSet";
            this.btnEditRuleSet.Size = new System.Drawing.Size(143, 23);
            this.btnEditRuleSet.TabIndex = 1;
            this.btnEditRuleSet.Text = "Fragensatz bearbeiten";
            this.btnEditRuleSet.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRuleSet
            // 
            this.btnDeleteRuleSet.Location = new System.Drawing.Point(235, 97);
            this.btnDeleteRuleSet.Name = "btnDeleteRuleSet";
            this.btnDeleteRuleSet.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteRuleSet.TabIndex = 1;
            this.btnDeleteRuleSet.Text = "Fragensatz löschen";
            this.btnDeleteRuleSet.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 134);
            this.Controls.Add(this.btnDeleteRuleSet);
            this.Controls.Add(this.btnEditRuleSet);
            this.Controls.Add(this.btnNewRuleSet);
            this.Controls.Add(this.btnStartQuestioning);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmMain";
            this.Text = "SOHR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStartQuestioning;
        private System.Windows.Forms.Button btnNewRuleSet;
        private System.Windows.Forms.Button btnEditRuleSet;
        private System.Windows.Forms.Button btnDeleteRuleSet;
    }
}

