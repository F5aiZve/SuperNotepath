using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace sticky
{
    public partial class Sticky : Form
    {
        private int x = 0;
        private int y = 0;
        public Sticky()
        {
            InitializeComponent();
        }
        public Sticky(int _x, int _y)
        {
            x = _x;
            y = _y;
            InitializeComponent();
        }

        Reminder dlg = new Reminder();
        private DateTime myReminderTime;

    private void LblReminder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                myReminderTime = dlg.MyMonthCalender.SelectionStart.AddHours(dlg.MyTimePicker.Value.Hour).AddMinutes(dlg.MyTimePicker.Value.Minute).AddSeconds(dlg.MyTimePicker.Value.Second);
                this.Visible = false;

            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(myReminderTime.CompareTo(DateTime.Now) < 0)
            {
                this.Visible = true;
            }
        }

        public string getTxtUser
        {
            get
            {
                return this.txtUser.Text;
            }
            set
            {
                txtUser.Text = value;
            }
        }


        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        //public void setPa
        //{
        //    IntPtr pWnd = FindWindow("Progman", null);
        //    pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SHELLDLL_DefVIew", null);
        //    pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SysListView32", null);
        //    IntPtr tWnd = this.Handle;
        //    SetParent(tWnd, pWnd);
        //}
        public void SetFormOnDesktop(IntPtr hwnd)
        {
            IntPtr hwndf = hwnd;
            IntPtr hwndParent = FindWindow("ProgMan", null);
            SetParent(hwndf, hwndParent);
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Top = 0;
            Point set = new Point(Screen.PrimaryScreen.Bounds.Width, y);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - x;
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }
    }
}
