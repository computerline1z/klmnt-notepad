﻿Imports System.IO
Imports System.Drawing.Printing
Imports System.Windows.Forms
'Imports System.ComponentModel
Imports System.Drawing
Public Class frmNotepad

    Private WithEvents docToPrint As New Printing.PrintDocument
    Private pgs_PageSettings As PageSettings
    Private prs_PrinterSettings As PrinterSettings
    Public i As Integer
    Private canc As Integer

#Region "Hieu ung bong mo"
    Const CS_DROPSHADOW = &H20000
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim parameters As CreateParams = MyBase.CreateParams
            parameters.ClassStyle = parameters.ClassStyle Or CS_DROPSHADOW
            Return parameters
        End Get
    End Property
#End Region
#Region "Cac su kien tren form"

    Private Sub frmNotepad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Khoi tao cac bien
        pgs_PageSettings = New System.Drawing.Printing.PageSettings
        prs_PrinterSettings = New System.Drawing.Printing.PrinterSettings

        'Khoi tao cac trang thai cua control
        mnuFm_Word_Wrap.CheckState = CheckState.Unchecked
        mnuV_Status_Bar.CheckState = CheckState.Checked

        rtxtEditor.WordWrap = mnuFm_Word_Wrap.CheckState = CheckState.Checked
        statusbar.Visible = mnuV_Status_Bar.CheckState = CheckState.Checked

    End Sub

    Private Sub rtxtEditor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtxtEditor.Click
        Dim p As New Point
        p.X = System.Windows.Forms.Cursor.Position.X
        p.Y = System.Windows.Forms.Cursor.Position.Y
        i = rtxtEditor.GetCharIndexFromPosition(p)
    End Sub

    Private Sub rtxtEditor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtxtEditor.TextChanged
        Dim p As New Point
        p.X = System.Windows.Forms.Cursor.Position.X
        p.Y = System.Windows.Forms.Cursor.Position.Y
        i = rtxtEditor.GetCharIndexFromPosition(p)
    End Sub

    Private Sub mainMenu_MenuActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles mainMenu.MenuActivate
        Try
            Dim b_isSelectText As Boolean
            'Xet xem co chon text nao hay khong
            b_isSelectText = rtxtEditor.SelectionLength > 0
            'Neu khong chon thi Disable cac menu Cut,Copy,Delete ... va nguoc lai
            mnuE_Copy.Enabled = b_isSelectText
            mnuE_Cut.Enabled = b_isSelectText
            mnuE_Delete.Enabled = b_isSelectText

            mnuE_Find.Enabled = rtxtEditor.TextLength > 0
            mnuE_Find_Next.Enabled = rtxtEditor.TextLength > 0

            mnuE_Replace.Enabled = rtxtEditor.TextLength > 0

            mnuE_Go_to.Enabled = rtxtEditor.WordWrap

            mnuV_Status_Bar.Enabled = mnuFm_Word_Wrap.CheckState = CheckState.Unchecked
        Catch ex As Exception
            'Khong can quan ly loi
        End Try
    End Sub
    Private Sub frmNotepad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'Kiem tra luu
            If rtxtEditor.Modified Then
                Dim s_msg As String
                Dim i_ans As Integer
                Dim s_filename As String
                If rtxtEditor.Tag Is Nothing Then
                    s_filename = "Untitled"
                Else
                    s_filename = rtxtEditor.Tag.Substring(rtxtEditor.Tag.LastIndexOf("\") + 1).Trim
                End If

                s_msg = "The text in the " & s_filename & " file has changed." & Chr(13) & Chr(13) & _
                        "Do you want to save the changes?"

                i_ans = (MsgBox(s_msg, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNoCancel, Application.ProductName))
                Select Case i_ans
                    Case MsgBoxResult.Cancel
                        e.Cancel = True
                    Case MsgBoxResult.No
                        e.Cancel = False
                    Case MsgBoxResult.Yes
                        e.Cancel = False
                        '(Xu ly luu 
                        'Code 
                        mnuF_Save_Click(sender, e)
                        ')
                End Select
            End If
            coolCloseForm(Me, 1.1)
        Catch ex As Exception
            'Quan ly loi khi ket thuc chuong trinh
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "File"
    Private Sub mnuF_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_New.Click
        'Code New
        If (rtxtEditor.Text <> "") Then
            Dim s_msg As String
            Dim i_ans As Integer
            Dim s_filename As String
            ' Dim Canc As New SaveFileDialog
            If rtxtEditor.Tag Is Nothing Then
                s_filename = "Untitled"
            Else
                s_filename = rtxtEditor.Tag.Substring(rtxtEditor.Tag.LastIndexOf("\") + 1).Trim
            End If
            s_msg = "The text in the " & s_filename & " file has changed." & Chr(13) & Chr(13) & _
                    "Do you want to save the changes?"
            i_ans = (MsgBox(s_msg, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNoCancel, Application.ProductName))
            Select Case i_ans
                Case MsgBoxResult.Cancel
                    Return
                Case MsgBoxResult.No
                    rtxtEditor.Text = ""
                Case MsgBoxResult.Yes

                    '(Xu ly luu 
                    'Code 
                    If (rtxtEditor.Tag Is Nothing) Then
                        mnuF_Save_Click(sender, e)
                        If canc = 1 Then
                            Return
                        Else : rtxtEditor.Text = ""
                        End If
                        ')
                    Else
                        SaveToFile(rtxtEditor.Tag)
                        rtxtEditor.Text = ""
                    End If
            End Select
        End If
        rtxtEditor.Tag = Nothing
    End Sub

    Private Sub mnuF_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_Open.Click
        'Code Open
        Try
            Dim frmOpen As New OpenFileDialog
            'Set cac thuoc tinh
            frmOpen.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*"
            frmOpen.FilterIndex = 1
            frmOpen.RestoreDirectory = True
            frmOpen.SupportMultiDottedExtensions = True

            If frmOpen.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim s_filename As String
                s_filename = frmOpen.FileName
                Dim myStream As New StreamReader(s_filename)

                'Dua noi dung vao
                rtxtEditor.Text = myStream.ReadToEnd
                'Luu file da mo
                rtxtEditor.Tag = s_filename
                'Gan lai title cua form
                Me.Text = s_filename.Substring(s_filename.LastIndexOf("\") + 1) & " - " & Application.ProductName
                'Dong file
                myStream.Close()
            End If

        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuF_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_Save.Click
        'Code Save
        Try
            'Neu chua save lan nao thi cung chinh la Save as
            If rtxtEditor.Tag Is Nothing Then
                mnuF_Save_as_Click(sender, e)
            Else
                SaveToFile(rtxtEditor.Tag)
            End If

        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuF_Save_as_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_Save_as.Click
        'Code Save As        
        Try
            Dim frmSave As New SaveFileDialog
            'Set cac thuoc tinh
            frmSave.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*"
            frmSave.FilterIndex = 1
            If rtxtEditor.Tag Is Nothing Then
                frmSave.FileName = "*.txt"
            Else
                Dim s_filename As String
                s_filename = rtxtEditor.Tag
                frmSave.FileName = s_filename.Substring(s_filename.LastIndexOf("\") + 1)
            End If

            frmSave.OverwritePrompt = True
            frmSave.RestoreDirectory = True
            frmSave.SupportMultiDottedExtensions = True

            If frmSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                SaveToFile(frmSave.FileName)
                ' UPDATE By KHA
            Else : canc = 1
            End If
        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuF_Page_setup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_Page_setup.Click
        'Code Page Setup
        Try
            Dim frmPageSetup As New PageSetupDialog
            'Thiet lap cac tham so hien tai
            frmPageSetup.Document = docToPrint
            frmPageSetup.PrinterSettings = prs_PrinterSettings
            frmPageSetup.PageSettings = pgs_PageSettings
            frmPageSetup.ShowDialog()
            'Luu thiet lap vao bien
            pgs_PageSettings = frmPageSetup.PageSettings
            prs_PrinterSettings = frmPageSetup.PrinterSettings

        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuF_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_Print.Click
        'Code Print
        Try

            Dim frmPrint As New PrintDialog
            frmPrint.AllowSomePages = True
            frmPrint.ShowHelp = True

            frmPrint.Document = docToPrint

            If (frmPrint.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                'Thiet lap may in va kho giay
                docToPrint.PrinterSettings = prs_PrinterSettings
                docToPrint.DefaultPageSettings = pgs_PageSettings
                'IN
                If frmPrint.PrintToFile Then
                    docToPrint.PrinterSettings.PrintToFile = True
                End If

                docToPrint.Print()

            End If

        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuF_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_Exit.Click
        'Code Exit 
        Me.Close()
    End Sub
#End Region
#Region "Edit"
    Private Sub mnuE_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Undo.Click, mnu_ct_Undo.Click
        'Code Undo
        rtxtEditor.ReadOnly = False
        mnUndo()
    End Sub

    Private Sub mnuE_Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Cut.Click, mnu_ct_Cut.Click
        'Code Cut
        rtxtEditor.Cut()
    End Sub

    Private Sub mnuE_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Copy.Click, mnu_ct_Copy.Click
        'Code Copy

    End Sub

    Private Sub mnuE_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Paste.Click, mnu_ct_Paste.Click
        'Code Paste
        Paste()
    End Sub

    Private Sub mnuE_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Delete.Click, mnu_ct_Delete.Click
        'Code Delete

    End Sub

    Private Sub mnuE_Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Find.Click
        'Code Find
        Dim myFind As New frmFind
        myFind.ShowDialog()
    End Sub
    Private Sub mnuE_Find_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Find_Next.Click
        'Code Find Next
        Dim myFindNext As New frmFind
        myFindNext.ShowDialog()
    End Sub

    Private Sub mnuE_Replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Replace.Click
        'Code Replace
        Dim myReplace As New FrmReplace
        myReplace.ShowDialog()

    End Sub

    Private Sub mnuE_Go_to_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Go_to.Click
        'Code Goto
        Dim myGoto As New FrmGoto
        myGoto.ShowDialog()
    End Sub

    Private Sub mnuE_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Select_All.Click, mnu_ct_SelectAll.Click
        'Code Select All
        rtxtEditor.Select(0, rtxtEditor.Text.Length)
    End Sub

    Private Sub mnuE_Time_Date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE_Time_Date.Click
        'Code Date/Time
        Try
            'Khai bao bien de luu gia tri trong clipboard
            Dim s_old_clipboard As String

            'Luu lai gia tri trong clipboard
            s_old_clipboard = Clipboard.GetText

            'Dua gia tri vao Clipboard
            Clipboard.SetText(Now.ToShortTimeString() & " " & Now.ToShortDateString)

            'Paste vao vi tri hien tai
            rtxtEditor.Paste()

            'Lay lai gia tri cu
            Clipboard.SetText(s_old_clipboard)
        Catch ex As Exception
            'Quan ly loi 
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "Format"

    Private Sub mnuFm_Word_Wrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFm_Word_Wrap.Click
        'Code Word Wrap
        Try
            'Check/Uncheck
            mnuFm_Word_Wrap.CheckState = (mnuFm_Word_Wrap.CheckState + 1) Mod 2
            rtxtEditor.WordWrap = mnuFm_Word_Wrap.CheckState = CheckState.Checked

            'Neu co Word wrap thi khong co status bar
            If mnuFm_Word_Wrap.CheckState = CheckState.Checked Then
                statusbar.Visible = False
                mnuV_Status_Bar.CheckState = CheckState.Unchecked
            Else
                statusbar.Visible = statusbar.Tag = CheckState.Checked
                mnuV_Status_Bar.CheckState = statusbar.Tag
            End If

        Catch ex As Exception
            'Khong can quan ly loi
        End Try

    End Sub

    Private Sub mnuFm_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFm_Font.Click
        'Code Font
        Try
            Dim frmFont As New FontDialog
            'Lay font hien tai
            frmFont.Font = rtxtEditor.Font
            'Hien thi hop thoai chon font
            If frmFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Thay doi font chu
                rtxtEditor.Font = frmFont.Font
            End If

        Catch ex As Exception
            'Quan ly loi khi chon font
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "View"

    Private Sub mnuV_Status_Bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuV_Status_Bar.Click
        'Code Status Bar
        Try
            'Check/Uncheck
            mnuV_Status_Bar.CheckState = (mnuV_Status_Bar.CheckState + 1) Mod 2
            statusbar.Visible = mnuV_Status_Bar.CheckState = CheckState.Checked
            statusbar.Tag = mnuV_Status_Bar.CheckState
        Catch ex As Exception
            'Khong can quan ly loi
        End Try
    End Sub
#End Region
#Region "Help"
    Private Sub mnuH_Help_Topics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuH_Help_Topics.Click
        Help.ShowHelp(Label1, "help/notepad.chm")

    End Sub

    Private Sub mnuH_About_Notepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuH_About_Notepad.Click
        Dim f As New frmAbout
        f.ShowDialog()

    End Sub
#End Region
#Region "ContextMenu"
    Private Sub mnu_Context_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnu_Context.Opening
        Try
            Dim b_isSelectText As Boolean
            'Xet xem co chon text nao hay khong
            b_isSelectText = rtxtEditor.SelectionLength > 0
            'Neu khong chon thi Disable cac menu Cut,Copy,Delete va nguoc lai
            mnu_ct_Copy.Enabled = b_isSelectText
            mnu_ct_Cut.Enabled = b_isSelectText
            mnu_ct_Delete.Enabled = b_isSelectText

            mnu_Context.RightToLeft = Windows.Forms.RightToLeft.No
            mnu_Context.DefaultDropDownDirection = ToolStripDropDownDirection.AboveRight

        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnu_ct_Right2Left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ct_Right2Left.Click
        'Code Right to left 
        Try
            'Check/Uncheck
            mnu_ct_Right2Left.CheckState = (mnu_ct_Right2Left.CheckState + 1) Mod 2
            If mnu_ct_Right2Left.CheckState = CheckState.Checked Then
                rtxtEditor.RightToLeft = Windows.Forms.RightToLeft.Yes
            Else
                rtxtEditor.RightToLeft = Windows.Forms.RightToLeft.No
            End If
        Catch ex As Exception
            'Khong can quan ly loi
        End Try

    End Sub

    Private Sub mnu_ct_ShowUnicode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ct_ShowUnicode.Click
        'Code Show Unicode
    End Sub

    Private Sub mnu_ct_InsertUnicode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ct_InsertUnicode.Click
        'Code Insert UniCode

    End Sub
#End Region
#End Region
#Region "Cac ham xu ly"
    Private Sub SaveToFile(ByVal s_filename As String)
        Try
            Dim myStream As New StreamWriter(s_filename)
            'Ghi file
            myStream.Write(rtxtEditor.Text)
            'Dong file
            myStream.Close()
            'Luu lai ten file
            rtxtEditor.Tag = s_filename
            'Gan lai Modified Luu roi thi khong hoi la co luu khi thoat khong
            rtxtEditor.Modified = False
            'Doi title cua form
            Me.Text = s_filename.Substring(s_filename.LastIndexOf("\") + 1) & " - " & Application.ProductName

        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub coolCloseForm(ByVal closeForm As Form, ByVal speed As Single)

        If speed = 0 Then
            MsgBox("Speed cannot zero")
            Exit Sub
        End If

        On Error Resume Next
        'Form mo dan roi dong Cho giong Vista :)
        Do Until closeForm.Opacity < 0.1
            Application.DoEvents()
            closeForm.Opacity = closeForm.Opacity / speed
        Loop
        closeForm.Dispose()
    End Sub
    Private Sub document_PrintPage(ByVal sender As Object, _
         ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
              Handles docToPrint.PrintPage
        'In
        e.Graphics.DrawString(rtxtEditor.Text, rtxtEditor.Font, _
            System.Drawing.Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top)

    End Sub

    Public Sub mnUndo()
        rtxtEditor.Undo()
    End Sub

    Public Sub Paste()
        Dim tmp, tmp1 As String
        Dim tmp2 As String = ""
        tmp = rtxtEditor.Text.Trim()
        tmp1 = tmp.Substring(0, i + 1)
        If tmp.Length > i + 1 Then
            tmp2 = tmp.Substring(i + 2, tmp.Length - i)
        End If
        rtxtEditor.Text = tmp1 & System.Windows.Forms.Clipboard.GetText.ToString & tmp2
    End Sub

#End Region
End Class
