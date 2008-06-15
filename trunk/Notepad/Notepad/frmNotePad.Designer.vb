<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotepad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotepad))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuFIle = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuF_New = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuF_Open = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuF_Save = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuF_Save_as = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuF_Page_setup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuF_Print = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuF_Exit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Undo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuE_Cut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Paste = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Delete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuE_Find = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Find_Next = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Replace = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Go_to = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuE_Select_All = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuE_Time_Date = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFormat = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuF_Word_Wrap = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuF_Font = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuV_Status_Bar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuH_Help_Topics = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuH_About_Notepad = New System.Windows.Forms.ToolStripMenuItem
        Me.rtxtEditor = New System.Windows.Forms.RichTextBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFIle, Me.mnuEdit, Me.mnuFormat, Me.mnuView, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(522, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFIle
        '
        Me.mnuFIle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuF_New, Me.mnuF_Open, Me.mnuF_Save, Me.mnuF_Save_as, Me.ToolStripMenuItem1, Me.mnuF_Page_setup, Me.mnuF_Print, Me.ToolStripMenuItem2, Me.mnuF_Exit})
        Me.mnuFIle.Name = "mnuFIle"
        Me.mnuFIle.Size = New System.Drawing.Size(35, 20)
        Me.mnuFIle.Text = "&File"
        '
        'mnuF_New
        '
        Me.mnuF_New.Name = "mnuF_New"
        Me.mnuF_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuF_New.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_New.Text = "&New"
        '
        'mnuF_Open
        '
        Me.mnuF_Open.Name = "mnuF_Open"
        Me.mnuF_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuF_Open.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Open.Text = "&Open..."
        '
        'mnuF_Save
        '
        Me.mnuF_Save.Name = "mnuF_Save"
        Me.mnuF_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuF_Save.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Save.Text = "&Save"
        '
        'mnuF_Save_as
        '
        Me.mnuF_Save_as.Name = "mnuF_Save_as"
        Me.mnuF_Save_as.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Save_as.Text = "Save &As..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuF_Page_setup
        '
        Me.mnuF_Page_setup.Name = "mnuF_Page_setup"
        Me.mnuF_Page_setup.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Page_setup.Text = "Page Set&up..."
        '
        'mnuF_Print
        '
        Me.mnuF_Print.Name = "mnuF_Print"
        Me.mnuF_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuF_Print.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Print.Text = "&Print..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'mnuF_Exit
        '
        Me.mnuF_Exit.Name = "mnuF_Exit"
        Me.mnuF_Exit.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Exit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuE_Undo, Me.ToolStripMenuItem3, Me.mnuE_Cut, Me.mnuE_Copy, Me.mnuE_Paste, Me.mnuE_Delete, Me.ToolStripMenuItem4, Me.mnuE_Find, Me.mnuE_Find_Next, Me.mnuE_Replace, Me.mnuE_Go_to, Me.ToolStripMenuItem5, Me.mnuE_Select_All, Me.mnuE_Time_Date})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(37, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuE_Undo
        '
        Me.mnuE_Undo.Name = "mnuE_Undo"
        Me.mnuE_Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuE_Undo.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Undo.Text = "&Undo"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(160, 6)
        '
        'mnuE_Cut
        '
        Me.mnuE_Cut.Name = "mnuE_Cut"
        Me.mnuE_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuE_Cut.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Cut.Text = "Cu&t"
        '
        'mnuE_Copy
        '
        Me.mnuE_Copy.Name = "mnuE_Copy"
        Me.mnuE_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuE_Copy.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Copy.Text = "&Copy"
        '
        'mnuE_Paste
        '
        Me.mnuE_Paste.Name = "mnuE_Paste"
        Me.mnuE_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuE_Paste.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Paste.Text = "&Paste"
        '
        'mnuE_Delete
        '
        Me.mnuE_Delete.Name = "mnuE_Delete"
        Me.mnuE_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnuE_Delete.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Delete.Text = "De&lete"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(160, 6)
        '
        'mnuE_Find
        '
        Me.mnuE_Find.Name = "mnuE_Find"
        Me.mnuE_Find.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuE_Find.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Find.Text = "&Find..."
        '
        'mnuE_Find_Next
        '
        Me.mnuE_Find_Next.Name = "mnuE_Find_Next"
        Me.mnuE_Find_Next.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuE_Find_Next.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Find_Next.Text = "Find &Next"
        '
        'mnuE_Replace
        '
        Me.mnuE_Replace.Name = "mnuE_Replace"
        Me.mnuE_Replace.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuE_Replace.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Replace.Text = "&Replace..."
        '
        'mnuE_Go_to
        '
        Me.mnuE_Go_to.Name = "mnuE_Go_to"
        Me.mnuE_Go_to.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuE_Go_to.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Go_to.Text = "&Go To..."
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(160, 6)
        '
        'mnuE_Select_All
        '
        Me.mnuE_Select_All.Name = "mnuE_Select_All"
        Me.mnuE_Select_All.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuE_Select_All.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Select_All.Text = "Select &All"
        '
        'mnuE_Time_Date
        '
        Me.mnuE_Time_Date.Name = "mnuE_Time_Date"
        Me.mnuE_Time_Date.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuE_Time_Date.Size = New System.Drawing.Size(163, 22)
        Me.mnuE_Time_Date.Text = "Time/&Date"
        '
        'mnuFormat
        '
        Me.mnuFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuF_Word_Wrap, Me.mnuF_Font})
        Me.mnuFormat.Name = "mnuFormat"
        Me.mnuFormat.Size = New System.Drawing.Size(53, 20)
        Me.mnuFormat.Text = "F&ormat"
        '
        'mnuF_Word_Wrap
        '
        Me.mnuF_Word_Wrap.Checked = True
        Me.mnuF_Word_Wrap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuF_Word_Wrap.Name = "mnuF_Word_Wrap"
        Me.mnuF_Word_Wrap.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Word_Wrap.Text = "&Word  Wrap"
        '
        'mnuF_Font
        '
        Me.mnuF_Font.Name = "mnuF_Font"
        Me.mnuF_Font.Size = New System.Drawing.Size(152, 22)
        Me.mnuF_Font.Text = "&Font..."
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuV_Status_Bar})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(41, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuV_Status_Bar
        '
        Me.mnuV_Status_Bar.Name = "mnuV_Status_Bar"
        Me.mnuV_Status_Bar.Size = New System.Drawing.Size(152, 22)
        Me.mnuV_Status_Bar.Text = "&Status Bar"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuH_Help_Topics, Me.mnuH_About_Notepad})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuH_Help_Topics
        '
        Me.mnuH_Help_Topics.Name = "mnuH_Help_Topics"
        Me.mnuH_Help_Topics.Size = New System.Drawing.Size(147, 22)
        Me.mnuH_Help_Topics.Text = "&Help Topics"
        '
        'mnuH_About_Notepad
        '
        Me.mnuH_About_Notepad.Name = "mnuH_About_Notepad"
        Me.mnuH_About_Notepad.Size = New System.Drawing.Size(147, 22)
        Me.mnuH_About_Notepad.Text = "&Abuot Notepad"
        '
        'rtxtEditor
        '
        Me.rtxtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtEditor.Location = New System.Drawing.Point(0, 24)
        Me.rtxtEditor.Name = "rtxtEditor"
        Me.rtxtEditor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.rtxtEditor.Size = New System.Drawing.Size(522, 348)
        Me.rtxtEditor.TabIndex = 2
        Me.rtxtEditor.Text = ""
        Me.rtxtEditor.WordWrap = False
        '
        'frmNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 372)
        Me.Controls.Add(Me.rtxtEditor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNotepad"
        Me.Text = "Unititled - Notepad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFIle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuF_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuF_Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuF_Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuF_Save_as As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuF_Page_setup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuF_Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuF_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Undo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuE_Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuE_Find As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Find_Next As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Replace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Go_to As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuE_Select_All As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuE_Time_Date As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuF_Word_Wrap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuF_Font As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuV_Status_Bar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuH_Help_Topics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuH_About_Notepad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtxtEditor As System.Windows.Forms.RichTextBox

End Class
