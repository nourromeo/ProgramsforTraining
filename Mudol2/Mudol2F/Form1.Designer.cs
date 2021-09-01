
namespace Mudol2F
{
    partial class Form1
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
            this.ClickMEButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ClickMEButton
            // 
            this.ClickMEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickMEButton.Location = new System.Drawing.Point(372, 447);
            this.ClickMEButton.Name = "ClickMEButton";
            this.ClickMEButton.Size = new System.Drawing.Size(217, 55);
            this.ClickMEButton.TabIndex = 0;
            this.ClickMEButton.Text = "Click Me";
            this.ClickMEButton.UseVisualStyleBackColor = true;
            this.ClickMEButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideButton.Location = new System.Drawing.Point(139, 447);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(217, 55);
            this.HideButton.TabIndex = 0;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(322, 81);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 96);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 514);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ClickMEButton);
            this.MinimumSize = new System.Drawing.Size(438, 331);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClickMEButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

