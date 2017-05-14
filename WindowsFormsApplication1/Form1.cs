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
        string fileName = "NoName";
        FontStyle style = FontStyle.Regular;
        Font font;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Height = this.Height;
            Properties.Settings.Default.Width = this.Width;
            Properties.Settings.Default.Save();
        }

        private void LoadSetting()
        {
            this.Location = Properties.Settings.Default.Location;
            this.Height = Properties.Settings.Default.Height;
            this.Width = Properties.Settings.Default.Width;
        }

        private void tSCBSize_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Super Notepad - " + fileName;
            LoadSetting();
            for (int i = 1; i <= 120; i++)
            {
                tSCBSize.Items.Add(i);
            }
            InstalledFontCollection listFont = new InstalledFontCollection();
            foreach (FontFamily font in listFont.Families)
            {
                tSCBFont.Items.Add(font.Name);
            }
        }

        private void tSCBFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily fa = new FontFamily(tSCBFont.Text);
            Font f = new System.Drawing.Font(fa, float.Parse(tSCBSize.Text));
            if (rTBMain.SelectedText.Length > 0)
                rTBMain.SelectionFont = f;
        }

        private void tSCBSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily fa = new FontFamily(tSCBFont.Text);
            Font f = new System.Drawing.Font(fa, float.Parse(tSCBSize.Text));
            if (rTBMain.SelectedText.Length > 0)
                rTBMain.SelectionFont = f;
        }

        private void tSBtnBold_Click(object sender, EventArgs e)
        {

                    style = style ^ FontStyle.Bold;
                    font = new System.Drawing.Font(new FontFamily(tSCBFont.Text), float.Parse(tSCBSize.Text), style);
                    rTBMain.SelectionFont = font;
        }

        private void tSBtnItalic_Click(object sender, EventArgs e)
        {

            style = style ^ FontStyle.Italic;
            font = new System.Drawing.Font(new FontFamily(tSCBFont.Text), float.Parse(tSCBSize.Text), style);
            rTBMain.SelectionFont = font;

        }

        private void tSBtnUnderline_Click(object sender, EventArgs e)
        {
            style = style ^ FontStyle.Underline;
            font = new System.Drawing.Font(new FontFamily(tSCBFont.Text), float.Parse(tSCBSize.Text), style);
            rTBMain.SelectionFont = font;
        }

        private void tSBtnTextColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rTBMain.SelectionColor = colorDialog1.Color;
            }

        }

        private void tSBtnBackgroundColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rTBMain.BackColor = colorDialog1.Color;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Redo();
        }

        private void tSBtnUndo_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem.PerformClick();
        }

        private void tSBtnRedo_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem.PerformClick();
        }

       

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult da;

            da = MessageBox.Show("Do you want to save changes to ?" + fileName + " ?", "SuperNotepath", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (da == DialogResult.Yes)
            {
                tSBtnSave_Click(sender, e);
                rTBMain.Clear();
            }
            if (da == DialogResult.No)
            {
                rTBMain.Clear();
                tSCBFont.Font = DefaultFont;
                tSCBSize.Font = DefaultFont;
                tSBtnBold.Checked = false;
                tSBtnItalic.Checked = false;
                tSBtnUnderline.Checked = false;
                rTBMain.BackColor = Color.White;
            }
        }
        private void tSBtnNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult da;
            if(rTBMain.Modified)
            {
                if(MessageBox.Show("Do you want to save changes to " + fileName + " ?", "SuperNotepath", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
           if(oFDOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = oFDOpen.FileName;
                rTBMain.Text = System.IO.File.ReadAllText(fileName);
                this.Text = "Super Notepad - " + fileName;
            }
        }
        private void tSBtnOpen_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        private void tSBtnSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "NoName")
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else
            {
                System.IO.File.WriteAllText(fileName, rTBMain.Text);
                this.Text = "Super Notepad - " + fileName;
            }
}

        private void tSBtnCopy_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        private void tSBtnPaste_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.PerformClick();
        }

        private void tSBtnPinNote_Click(object sender, EventArgs e)
        {

        }

        private void tSBtnCut_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sFDSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = sFDSave.FileName;
                System.IO.File.WriteAllText(fileName, rTBMain.Text);
                this.Text = "Super Notepad - " + fileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDFont.Font = rTBMain.Font;
            if (fDFont.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rTBMain.Font = fDFont.Font;
            }
        }

        private void rrTBMain_TextChanged(object sender, EventArgs e)
        {
            if (rTBMain.Modified)
            {
                this.Text = "Super Notepad - " + fileName + "*";
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
            {
                rTBMain.WordWrap = true;
            }
            else
            {
                rTBMain.WordWrap = false;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }
    }
}
