namespace WindowsFormsApplication1
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tSBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tSBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tSBtnCut = new System.Windows.Forms.ToolStripButton();
            this.tSBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tSBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tSBtnUndo = new System.Windows.Forms.ToolStripButton();
            this.tSBtnRedo = new System.Windows.Forms.ToolStripButton();
            this.tSBtnPinNote = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSCBFont = new System.Windows.Forms.ToolStripComboBox();
            this.tSCBSize = new System.Windows.Forms.ToolStripComboBox();
            this.tSBtnBold = new System.Windows.Forms.ToolStripButton();
            this.tSBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tSBtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.tSBtnTextColor = new System.Windows.Forms.ToolStripButton();
            this.tSBtnBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.rTBMain = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fDFont = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Fonts...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolbarToolStripMenuItem,
            this.formatToolbarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fileToolbarToolStripMenuItem
            // 
            this.fileToolbarToolStripMenuItem.Name = "fileToolbarToolStripMenuItem";
            this.fileToolbarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fileToolbarToolStripMenuItem.Text = "File Toolbar";
            // 
            // formatToolbarToolStripMenuItem
            // 
            this.formatToolbarToolStripMenuItem.Name = "formatToolbarToolStripMenuItem";
            this.formatToolbarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.formatToolbarToolStripMenuItem.Text = "Format Toolbar";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnNew,
            this.tSBtnOpen,
            this.tSBtnSave,
            this.tSBtnCut,
            this.tSBtnCopy,
            this.tSBtnPaste,
            this.tSBtnUndo,
            this.tSBtnRedo,
            this.tSBtnPinNote});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnNew
            // 
            this.tSBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnNew.Image")));
            this.tSBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnNew.Name = "tSBtnNew";
            this.tSBtnNew.Size = new System.Drawing.Size(24, 24);
            this.tSBtnNew.Text = "New";
            this.tSBtnNew.Click += new System.EventHandler(this.tSBtnNew_Click);
            // 
            // tSBtnOpen
            // 
            this.tSBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnOpen.Image")));
            this.tSBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnOpen.Name = "tSBtnOpen";
            this.tSBtnOpen.Size = new System.Drawing.Size(24, 24);
            this.tSBtnOpen.Text = "Open";
            this.tSBtnOpen.Click += new System.EventHandler(this.tSBtnOpen_Click);
            // 
            // tSBtnSave
            // 
            this.tSBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnSave.Image")));
            this.tSBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnSave.Name = "tSBtnSave";
            this.tSBtnSave.Size = new System.Drawing.Size(24, 24);
            this.tSBtnSave.Text = "Save";
            this.tSBtnSave.Click += new System.EventHandler(this.tSBtnSave_Click);
            // 
            // tSBtnCut
            // 
            this.tSBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnCut.Image")));
            this.tSBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnCut.Name = "tSBtnCut";
            this.tSBtnCut.Size = new System.Drawing.Size(24, 24);
            this.tSBtnCut.Text = "Cut";
            this.tSBtnCut.Click += new System.EventHandler(this.tSBtnCut_Click);
            // 
            // tSBtnCopy
            // 
            this.tSBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnCopy.Image")));
            this.tSBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnCopy.Name = "tSBtnCopy";
            this.tSBtnCopy.Size = new System.Drawing.Size(24, 24);
            this.tSBtnCopy.Text = "Copy";
            this.tSBtnCopy.Click += new System.EventHandler(this.tSBtnCopy_Click);
            // 
            // tSBtnPaste
            // 
            this.tSBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnPaste.Image")));
            this.tSBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnPaste.Name = "tSBtnPaste";
            this.tSBtnPaste.Size = new System.Drawing.Size(24, 24);
            this.tSBtnPaste.Text = "Paste";
            this.tSBtnPaste.Click += new System.EventHandler(this.tSBtnPaste_Click);
            // 
            // tSBtnUndo
            // 
            this.tSBtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnUndo.Image")));
            this.tSBtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnUndo.Name = "tSBtnUndo";
            this.tSBtnUndo.Size = new System.Drawing.Size(24, 24);
            this.tSBtnUndo.Text = "Undo";
            this.tSBtnUndo.Click += new System.EventHandler(this.tSBtnUndo_Click);
            // 
            // tSBtnRedo
            // 
            this.tSBtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnRedo.Image")));
            this.tSBtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnRedo.Name = "tSBtnRedo";
            this.tSBtnRedo.Size = new System.Drawing.Size(24, 24);
            this.tSBtnRedo.Text = "ReDo";
            this.tSBtnRedo.Click += new System.EventHandler(this.tSBtnRedo_Click);
            // 
            // tSBtnPinNote
            // 
            this.tSBtnPinNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnPinNote.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnPinNote.Image")));
            this.tSBtnPinNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnPinNote.Name = "tSBtnPinNote";
            this.tSBtnPinNote.Size = new System.Drawing.Size(24, 24);
            this.tSBtnPinNote.Text = "Pin Note";
            this.tSBtnPinNote.Click += new System.EventHandler(this.tSBtnPinNote_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCBFont,
            this.tSCBSize,
            this.tSBtnBold,
            this.tSBtnItalic,
            this.tSBtnUnderline,
            this.tSBtnTextColor,
            this.tSBtnBackgroundColor});
            this.toolStrip2.Location = new System.Drawing.Point(241, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(358, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSCBFont
            // 
            this.tSCBFont.Name = "tSCBFont";
            this.tSCBFont.Size = new System.Drawing.Size(121, 25);
            this.tSCBFont.Text = "Times New Roman";
            this.tSCBFont.SelectedIndexChanged += new System.EventHandler(this.tSCBFont_SelectedIndexChanged);
            // 
            // tSCBSize
            // 
            this.tSCBSize.Name = "tSCBSize";
            this.tSCBSize.Size = new System.Drawing.Size(75, 25);
            this.tSCBSize.Text = "12";
            this.tSCBSize.SelectedIndexChanged += new System.EventHandler(this.tSCBSize_SelectedIndexChanged);
            this.tSCBSize.Click += new System.EventHandler(this.tSCBSize_Click);
            // 
            // tSBtnBold
            // 
            this.tSBtnBold.CheckOnClick = true;
            this.tSBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnBold.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnBold.Image")));
            this.tSBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnBold.Name = "tSBtnBold";
            this.tSBtnBold.Size = new System.Drawing.Size(23, 22);
            this.tSBtnBold.Text = "Bold";
            this.tSBtnBold.Click += new System.EventHandler(this.tSBtnBold_Click);
            // 
            // tSBtnItalic
            // 
            this.tSBtnItalic.CheckOnClick = true;
            this.tSBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnItalic.Image")));
            this.tSBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnItalic.Name = "tSBtnItalic";
            this.tSBtnItalic.Size = new System.Drawing.Size(23, 22);
            this.tSBtnItalic.Text = "Italic";
            this.tSBtnItalic.Click += new System.EventHandler(this.tSBtnItalic_Click);
            // 
            // tSBtnUnderline
            // 
            this.tSBtnUnderline.CheckOnClick = true;
            this.tSBtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnUnderline.Image")));
            this.tSBtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnUnderline.Name = "tSBtnUnderline";
            this.tSBtnUnderline.Size = new System.Drawing.Size(23, 22);
            this.tSBtnUnderline.Text = "Underline";
            this.tSBtnUnderline.Click += new System.EventHandler(this.tSBtnUnderline_Click);
            // 
            // tSBtnTextColor
            // 
            this.tSBtnTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnTextColor.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnTextColor.Image")));
            this.tSBtnTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnTextColor.Name = "tSBtnTextColor";
            this.tSBtnTextColor.Size = new System.Drawing.Size(23, 22);
            this.tSBtnTextColor.Text = "Text Color";
            this.tSBtnTextColor.Click += new System.EventHandler(this.tSBtnTextColor_Click);
            // 
            // tSBtnBackgroundColor
            // 
            this.tSBtnBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtnBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnBackgroundColor.Image")));
            this.tSBtnBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnBackgroundColor.Name = "tSBtnBackgroundColor";
            this.tSBtnBackgroundColor.Size = new System.Drawing.Size(23, 22);
            this.tSBtnBackgroundColor.Text = "Background Color";
            this.tSBtnBackgroundColor.Click += new System.EventHandler(this.tSBtnBackgroundColor_Click);
            // 
            // rTBMain
            // 
            this.rTBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBMain.Location = new System.Drawing.Point(0, 51);
            this.rTBMain.Name = "rTBMain";
            this.rTBMain.Size = new System.Drawing.Size(777, 351);
            this.rTBMain.TabIndex = 3;
            this.rTBMain.Text = "This is text string";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 402);
            this.Controls.Add(this.rTBMain);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Super Notepath";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBtnOpen;
        private System.Windows.Forms.ToolStripButton tSBtnSave;
        private System.Windows.Forms.ToolStripButton tSBtnCut;
        private System.Windows.Forms.ToolStripButton tSBtnUndo;
        private System.Windows.Forms.ToolStripButton tSBtnPinNote;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox tSCBFont;
        private System.Windows.Forms.ToolStripComboBox tSCBSize;
        private System.Windows.Forms.ToolStripButton tSBtnRedo;
        private System.Windows.Forms.ToolStripButton tSBtnNew;
        private System.Windows.Forms.ToolStripButton tSBtnPaste;
        private System.Windows.Forms.ToolStripButton tSBtnTextColor;
        private System.Windows.Forms.ToolStripButton tSBtnBackgroundColor;
        private System.Windows.Forms.RichTextBox rTBMain;
        private System.Windows.Forms.ToolStripButton tSBtnCopy;
        private System.Windows.Forms.ToolStripButton tSBtnBold;
        private System.Windows.Forms.ToolStripButton tSBtnItalic;
        private System.Windows.Forms.ToolStripButton tSBtnUnderline;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fDFont;
    }
}

