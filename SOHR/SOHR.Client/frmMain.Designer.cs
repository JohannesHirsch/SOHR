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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbxHeaders = new System.Windows.Forms.ComboBox();
            this.btnStartQuestioning = new System.Windows.Forms.Button();
            this.btnNewRuleSet = new System.Windows.Forms.Button();
            this.btnEditRuleSet = new System.Windows.Forms.Button();
            this.btnDeleteRuleSet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxHeaders
            // 
            this.cbxHeaders.FormattingEnabled = true;
            this.cbxHeaders.Location = new System.Drawing.Point(17, 16);
            this.cbxHeaders.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHeaders.Name = "cbxHeaders";
            this.cbxHeaders.Size = new System.Drawing.Size(256, 24);
            this.cbxHeaders.TabIndex = 0;
            this.cbxHeaders.TextChanged += new System.EventHandler(this.cbxHeaders_TextChanged);
            // 
            // btnStartQuestioning
            // 
            this.btnStartQuestioning.Location = new System.Drawing.Point(313, 50);
            this.btnStartQuestioning.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartQuestioning.Name = "btnStartQuestioning";
            this.btnStartQuestioning.Size = new System.Drawing.Size(191, 28);
            this.btnStartQuestioning.TabIndex = 1;
            this.btnStartQuestioning.Text = "Befragung starten";
            this.btnStartQuestioning.UseVisualStyleBackColor = true;
            this.btnStartQuestioning.Click += new System.EventHandler(this.btnStartQuestioning_Click);
            // 
            // btnNewRuleSet
            // 
            this.btnNewRuleSet.Location = new System.Drawing.Point(313, 86);
            this.btnNewRuleSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewRuleSet.Name = "btnNewRuleSet";
            this.btnNewRuleSet.Size = new System.Drawing.Size(191, 28);
            this.btnNewRuleSet.TabIndex = 1;
            this.btnNewRuleSet.Text = "Neuer Fragensatz";
            this.btnNewRuleSet.UseVisualStyleBackColor = true;
            this.btnNewRuleSet.Click += new System.EventHandler(this.btnNewRuleSet_Click);
            // 
            // btnEditRuleSet
            // 
            this.btnEditRuleSet.Location = new System.Drawing.Point(313, 122);
            this.btnEditRuleSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRuleSet.Name = "btnEditRuleSet";
            this.btnEditRuleSet.Size = new System.Drawing.Size(191, 28);
            this.btnEditRuleSet.TabIndex = 1;
            this.btnEditRuleSet.Text = "Fragensatz bearbeiten";
            this.btnEditRuleSet.UseVisualStyleBackColor = true;
            this.btnEditRuleSet.Click += new System.EventHandler(this.btnEditRuleSet_Click);
            // 
            // btnDeleteRuleSet
            // 
            this.btnDeleteRuleSet.Location = new System.Drawing.Point(313, 158);
            this.btnDeleteRuleSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRuleSet.Name = "btnDeleteRuleSet";
            this.btnDeleteRuleSet.Size = new System.Drawing.Size(191, 28);
            this.btnDeleteRuleSet.TabIndex = 1;
            this.btnDeleteRuleSet.Text = "Fragensatz löschen";
            this.btnDeleteRuleSet.UseVisualStyleBackColor = true;
            this.btnDeleteRuleSet.Click += new System.EventHandler(this.btnDeleteRuleSet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(313, 16);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 28);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteRuleSet);
            this.Controls.Add(this.btnEditRuleSet);
            this.Controls.Add(this.btnNewRuleSet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStartQuestioning);
            this.Controls.Add(this.cbxHeaders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "SOHR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxHeaders;
        private System.Windows.Forms.Button btnStartQuestioning;
        private System.Windows.Forms.Button btnNewRuleSet;
        private System.Windows.Forms.Button btnEditRuleSet;
        private System.Windows.Forms.Button btnDeleteRuleSet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

