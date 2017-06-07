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
using sticky;
using Google.Cloud.Speech.V1;
using SharpUpdate;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class FrmMain : Form, ISharpUpdatable
    {
        #region khởi tạo các biến toàn cục
        string fileName = "NoName"; //chuỗi chứa tên file
        FontStyle style = FontStyle.Regular; //fontstyle của text
        Font font; //font của text
        public List<Sticky> aStickyNote = new List<Sticky>(); //list chứa các sticky notes
        private bool IsShutdownable = true; //biến bool cho biến có thể tắt form hay không
        #endregion
        #region phần biến liên quan đến chức năng update
        private SharpUpdater updater;

        public string ApplicationName
        {
            get
            {
                return "Super Notepad";
            }
        }

        public string ApplicationID
        {
            get
            {
               return "Super Notepad";
            }
        }

        public Assembly ApplicationAssembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public Icon ApplicationIcon
        {
            get
            {
                return this.Icon;
            }
        }

        public Uri UpdateXmlLocation
        {
            get
            {
               return new Uri("https://rawgit.com/Effecerit/SuperNotepath/master/update.xml");
            }
        }

        public Form Context
        {
            get
            {
                return this;
            }
        }
        #endregion
        public FrmMain()
        {
            InitializeComponent();
            this.lblversion.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);
        }

        //hai hàm save và load là để lưu cài đặt và load cài đặt về độ cao, chiều dài, vị trí của form
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

        //hàm xử lý sự kiện khi form được khởi tạo
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //đặt các giá trị mặc định của một số item trên form
            this.IsAccessible = true;
            tSCBFont.Font = DefaultFont;
            tSCBSize.Font = DefaultFont;
            tSBtnBold.Checked = false;
            tSBtnItalic.Checked = false;
            tSBtnUnderline.Checked = false;
            rTBMain.BackColor = Color.White;
            style = FontStyle.Regular;
            fileName = "NoName";
            rTBMain.Clear();

            this.Text = "Super Notepad - " + fileName; //tạo tên form là Super Notepad + tên file
            LoadSetting(); //load thông tin về độ cao, chiều dài, vị trí form

            //dòng for này khởi tạo các giá trị cho toolstripcombobox font size cho việc điều chỉnh size của text
            for (int i = 1; i <= 120; i++)
            {
                tSCBSize.Items.Add(i);
            }

            //dòng for tiếp theo tạo một list font families cho toolstripcombobox font
            InstalledFontCollection listFont = new InstalledFontCollection();
            foreach (FontFamily font in listFont.Families)
            {
                tSCBFont.Items.Add(font.Name);
            }

            //3 dòng này để thêm 355k từ tiếng anh vào control autocomplete
            IEnumerable<string> a = System.IO.File.ReadLines("english word.txt");
            foreach (string alone in a)
            {
                autocompleteMenu1.AddItem(alone);
            }

        }

        #region các event handler của toolbar format
        /// <summary>
        /// xử lý các sự kiện khi đổi font, đổi font size, tô đậm, in nghiêng text, .....
        /// ps: Thái viết
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSCBFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tạo font family từ text của toolstripcombo font
            FontFamily fa = new FontFamily(tSCBFont.Text);
            //tạo font với fontfamily và size đã định
            Font f = new System.Drawing.Font(fa, float.Parse(tSCBSize.Text));
            //thay đổi kiểu font của text hiện tại và sau này
            rTBMain.SelectionFont = f;
            //cho focus vào textbox 
            //(ngưng trường hợp chọn xong thì gõ phím tiếp thì lại gõ vào toolstripcombobox)
            rTBMain.Focus();
        }
        //hàm tiếp theo tương tự như trên
        private void tSCBSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily fa = new FontFamily(tSCBFont.Text);
            Font f = new System.Drawing.Font(fa, float.Parse(tSCBSize.Text));
            rTBMain.SelectionFont = f;
            rTBMain.Focus();
        }

        //3 hàm tiếp theo là eventhandler của các nút in đậm, in nghiêng, gạch chân
        //cấu trúc là tương tự nhau
        private void tSBtnBold_Click(object sender, EventArgs e)
        {
            //cho biến style (biến toàn cục lưu kiểu của text) xor với kiểu in đậm
            //ý nghĩa là nếu nó đã in đậm rồi thì ngừng in đậm và ngược lại
            style = style ^ FontStyle.Bold;
            //hai dòng lệnh dưới cập nhật lại kiểu font cho textbox
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

        //hai event handler này khá đơn giản
        //hiện color dialog nếu Ok thì đổi màu của text/background
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
        #endregion

        #region các event handler cho context menustrip (khi người dùng nhấn chuột phải)
        /// <summary>
        /// ps: Thái viết
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tSBtnUndo_Click(sender, e);
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tSBtnRedo_Click(sender, e);
        }

        private void cutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            tSBtnCut_Click(sender, e);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tSBtnCopy_Click(sender, e);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tSBtnPaste_Click(sender, e);
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.rTBMain.SelectAll();
        }
        #endregion

        #region các event handler cho các toolstripmenu item File, Format, Edit, View và About
        /// <summary>
        /// PS: chủ yếu là Nhựt viết, Thắng thêm và Thái sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //4 event handler này gọi hàm undo/redo của textbox
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

        //event handler của File->New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult da; //biến lưu kết quả ok hay là no

            //hỏi người ta có muốn lưu lại không
            da = MessageBox.Show("Do you want to save changes to ?" + fileName + " ?", "SuperNotepath", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            //nếu yes
            if (da == DialogResult.Yes)
            {
                //thực thi event handler của nút lưu
                tSBtnSave_Click(sender, e);
                //khởi tạo lại form
                FrmMain_Load(sender, e);
            }

            //nếu không thì chỉ khởi tạo lại form thôi
            if (da == DialogResult.No)
            {
                FrmMain_Load(sender, e);
            }
        }

        //event handler của button New
        private void tSBtnNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        //event handler của File->Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rTBMain.Modified) //nếu có thay đổi
            {
                //và đồng ý lưu thì gọi event handler của nút save
                if (MessageBox.Show("Do you want to save changes to " + fileName + " ?", "SuperNotepath", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            //mở dialog open file và xử lý
            if (oFDOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = oFDOpen.FileName;
                rTBMain.Text = System.IO.File.ReadAllText(fileName);
                this.Text = "Super Notepad - " + fileName;
            }
        }

        //event handler của button Open
        private void tSBtnOpen_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        //event handler của File->Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "NoName") //nếu tên nó là NoName (mặc định) thì gọi event handler saveAs
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else //không thì lưu lại
            {
                System.IO.File.WriteAllText(fileName, rTBMain.Text);
                this.Text = "Super Notepad - " + fileName;
            }
        }

        //event handler của button Save
        private void tSBtnSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.PerformClick();
        }

        //event handler của button Cut
        private void tSBtnCut_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        //event handler của button Copy
        private void tSBtnCopy_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        //event handler của button Paste
        private void tSBtnPaste_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.PerformClick();
        }

        //event handler của File->Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sFDSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = sFDSave.FileName;
                System.IO.File.WriteAllText(fileName, rTBMain.Text);
                this.Text = "Super Notepad - " + fileName;
            }
        }

        //event handler của File->Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //event handler của Format->Font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDFont.Font = rTBMain.Font;
            if (fDFont.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rTBMain.Font = fDFont.Font;
            }
        }

        //event handler khi textbox thay đổi
        private void rrTBMain_TextChanged(object sender, EventArgs e)
        {
            if (rTBMain.Modified)
            {
                this.Text = "Super Notepad - " + fileName + "*";
            }
        }

        //event handler của Edit->Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Cut();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        //event handler của Edit->Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Copy();
        }

        //event handler của Edit->Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.Paste();
        }

        //event handler của Edit->Select All
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBMain.SelectAll();
        }


        //event handler của Format->WordWrap
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

        //event handler của View->File Toolbar
        private void fileToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolbarToolStripMenuItem.Checked = !fileToolbarToolStripMenuItem.Checked;
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        //event handler của View->Format Toolbar
        private void formatToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formatToolbarToolStripMenuItem.Checked = !formatToolbarToolStripMenuItem.Checked;
            toolStrip2.Visible = !toolStrip2.Visible;
        }
        #endregion

        #region các hàm xử lý và làm việc với sticky notes
        //hàm xử lý khi nút pin note được nhấn
        private void tSBtnPinNote_Click(object sender, EventArgs e)
        {
            try
            {


                //tạo một sticky tạm thời để lấy độ dài, rộng của sticky
                Sticky temp = new Sticky();
                //cập nhật giá trị của hai biến x, y, hai biến này sẽ là quyết định vị trí của sticky trên màn hình
                int x = (aStickyNote.Count + 1) * temp.Width;
                int y = (aStickyNote.Count + 1) * temp.Height;
                //thêm sticky mới vào list
                aStickyNote.Add(new Sticky(x, y));
                //copy nội dung từ RichTextBox qua Sticky
                aStickyNote.Last().getTxtUser = rTBMain.Text;
                //giải phóng temp Sticky
                temp.Dispose();
                //bật timer1
                if (timer1.Enabled != true)
                {
                    timer1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //event handler khi form bị đóng, khá quan trọng
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveSetting();
                //nếu không được tắt
                if (!IsShutdownable)
                {
                    e.Cancel = true; //hủy event tắt
                    this.Hide(); //giấu form
                    this.IsAccessible = false; //đặt IsAccessible là false
                }
                else //nếu tắt được
                {
                    //thì tắt form
                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //hàm liên tục kiểm tra sự tồn tại của sticky notes
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // nếu số lượng stickynote lớn hơn 0
                if (aStickyNote.Count > 0)
                {
                    for (int i = 0; i < aStickyNote.Count; i++)
                    {
                        if (aStickyNote[i].IsDisposed == true) //sticky nào đã tắt
                        {
                            aStickyNote.RemoveAt(i); //thì loại khỏi list

                        }
                    }
                }
                if (aStickyNote.Count == 0) //nếu tắt cả sticky đều bị tắt
                {
                    IsShutdownable = true; //thì có thể tắt form
                    timer1.Stop(); //dừng timer
                    if (this.IsAccessible == false) //nếu form đã được giấu từ trước
                        this.Close(); //thì tắt
                }
                else //nếu vẫn còn sticky đang chạy
                {
                    IsShutdownable = false; //không được tắt form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        #endregion

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
    }
}
