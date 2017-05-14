namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.MyMonthCalender = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // MyTimePicker
            // 
            this.MyTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.MyTimePicker.Location = new System.Drawing.Point(13, 22);
            this.MyTimePicker.Name = "MyTimePicker";
            this.MyTimePicker.ShowUpDown = true;
            this.MyTimePicker.Size = new System.Drawing.Size(98, 20);
            this.MyTimePicker.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(147, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MyMonthCalender
            // 
            this.MyMonthCalender.Location = new System.Drawing.Point(13, 75);
            this.MyMonthCalender.Name = "MyMonthCalender";
            this.MyMonthCalender.TabIndex = 2;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MyMonthCalender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DateTimePicker MyTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar MyMonthCalender;
    }
}