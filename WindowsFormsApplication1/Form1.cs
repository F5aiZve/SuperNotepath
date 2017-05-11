using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsFormsApplication1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tSBtnNew_Click(object sender, EventArgs e)
        {
            DialogResult da;
            
            da = MessageBox.Show("Do you want to save changes to Note?", "SuperNotepath", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (da == DialogResult.Yes)
            {
                tSBtnSave_Click(sender, e);
                rTBMain.Clear();
            }
            if (da == DialogResult.No)
            {
                rTBMain.Clear();
            }
        }

        private void tSBtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            Save.RestoreDirectory = true;
            Save.Filter = ".txt| *.txt| .doc| *.doc";
            if (Save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rTBMain.SaveFile(Save.FileName);
            }
        }

        private void tSBtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = ".doc|*.doc| .txt| *.txt";
            Open.RestoreDirectory = true;
            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rTBMain.LoadFile(Open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void tSCBSize_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 120; i++)
            {
                tSCBSize.Items.Add(i);
            }
            InstalledFontCollection listFont = new InstalledFontCollection();
            int c=0, j = 0;
            foreach (FontFamily font in listFont.Families)
            {
                tSCBFont.Items.Add(font.Name);
            }
        }

        private void load()
        {
            FontStyle stype = FontStyle.Regular;
            if (tSBtnBold.Checked == true)
                stype = FontStyle.Bold;
            if (tSBtnItalic.Checked == true)
                stype = FontStyle.Italic;
            if (tSBtnUnderline.Checked == true)
                stype = FontStyle.Underline;
            FontFamily fa = new FontFamily(tSCBFont.Text);
            Font f = new System.Drawing.Font(fa, float.Parse(tSCBSize.Text), stype);
            if (rTBMain.SelectedText.Length > 0)
                rTBMain.SelectionFont = f; 

        }
        private void tSCBFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }

        private void tSCBSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }

        private void tSBtnBold_Click(object sender, EventArgs e)
        {
            if (rTBMain.SelectedText.Length > 0)
            {
                load();
            }
        }

        private void tSBtnItalic_Click(object sender, EventArgs e)
        {
            if (rTBMain.SelectedText.Length > 0)
            {
                load();
            }
        }

        private void tSBtnUnderline_Click(object sender, EventArgs e)
        {
            if (rTBMain.SelectedText.Length > 0)
            {
                load();
            }
        }
    }
}
