
namespace registrationApp
{
    partial class View
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
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.MemberListLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.RemoveMemberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberListBox
            // 
            this.memberListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.ItemHeight = 20;
            this.memberListBox.Location = new System.Drawing.Point(12, 58);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(445, 404);
            this.memberListBox.TabIndex = 0;
            // 
            // MemberListLabel
            // 
            this.MemberListLabel.AutoSize = true;
            this.MemberListLabel.Location = new System.Drawing.Point(12, 26);
            this.MemberListLabel.Name = "MemberListLabel";
            this.MemberListLabel.Size = new System.Drawing.Size(90, 20);
            this.MemberListLabel.TabIndex = 1;
            this.MemberListLabel.Text = "Member list";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddMemberButton.Location = new System.Drawing.Point(12, 477);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(208, 36);
            this.AddMemberButton.TabIndex = 2;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // RemoveMemberButton
            // 
            this.RemoveMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveMemberButton.Location = new System.Drawing.Point(243, 477);
            this.RemoveMemberButton.Name = "RemoveMemberButton";
            this.RemoveMemberButton.Size = new System.Drawing.Size(216, 36);
            this.RemoveMemberButton.TabIndex = 3;
            this.RemoveMemberButton.Text = "Remove Member";
            this.RemoveMemberButton.UseVisualStyleBackColor = true;
            this.RemoveMemberButton.Click += new System.EventHandler(this.RemoveMemberButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 525);
            this.Controls.Add(this.RemoveMemberButton);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.MemberListLabel);
            this.Controls.Add(this.memberListBox);
            this.MinimumSize = new System.Drawing.Size(489, 581);
            this.Name = "Form1";
            this.Text = "Member Registeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Label MemberListLabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Button RemoveMemberButton;
    }
}

