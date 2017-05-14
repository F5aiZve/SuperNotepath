namespace WindowsFormsApplication1
{
    partial class Sticky
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.LblReminder = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = true;
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.SystemColors.Info;
            this.txtUser.Location = new System.Drawing.Point(2, 2);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(281, 258);
            this.txtUser.TabIndex = 0;
            // 
            // LblReminder
            // 
            this.LblReminder.AutoSize = true;
            this.LblReminder.Location = new System.Drawing.Point(171, 236);
            this.LblReminder.Name = "LblReminder";
            this.LblReminder.Size = new System.Drawing.Size(97, 13);
            this.LblReminder.TabIndex = 1;
            this.LblReminder.TabStop = true;
            this.LblReminder.Text = "Reminder Me Later";
            this.LblReminder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LblReminder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblReminder_LinkClicked);
            // 
            // Sticky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblReminder);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Sticky";
            this.Opacity = 0.8D;
            this.Text = "Sticky";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.LinkLabel LblReminder;
    }
}