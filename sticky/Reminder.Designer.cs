namespace sticky
{
    partial class Reminder
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
            this.MyTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyMonthCalender = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyTimePicker
            // 
            this.MyTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.MyTimePicker.Location = new System.Drawing.Point(13, 13);
            this.MyTimePicker.Name = "MyTimePicker";
            this.MyTimePicker.ShowUpDown = true;
            this.MyTimePicker.Size = new System.Drawing.Size(155, 20);
            this.MyTimePicker.TabIndex = 0;
            // 
            // MyMonthCalender
            // 
            this.MyMonthCalender.Location = new System.Drawing.Point(13, 60);
            this.MyMonthCalender.Name = "MyMonthCalender";
            this.MyMonthCalender.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(174, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyMonthCalender);
            this.Controls.Add(this.MyTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DateTimePicker MyTimePicker;
        public System.Windows.Forms.MonthCalendar MyMonthCalender;
        private System.Windows.Forms.Button button1;
    }
}