Public Class frmNotepad
    Dim b_EditorChange As Boolean
    Dim s_filename As String
#Region "Cac su kien tren form"
    Private Sub frmNotepad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Khoi tao cac bien
        b_EditorChange = False

        'Khoi tao cac trang thai cua control
        rtxtEditor.WordWrap = mnuFm_Word_Wrap.CheckState = CheckState.Checked
        statusbar.Visible = mnuV_Status_Bar.CheckState = CheckState.Checked
    End Sub

    Private Sub mnuF_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuF_Exit.Click
        End
    End Sub

    Private Sub rtxtEditor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtxtEditor.TextChanged
        b_EditorChange = True
    End Sub

    Private Sub frmNotepad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'Kiem tra luu
            If b_EditorChange Then
                Dim s_msg As String
                Dim i_ans As Integer
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
                        ')
                End Select
            End If
        Catch ex As Exception
            'Quan ly loi khi ket thuc chuong trinh

        End Try
    End Sub

    Private Sub mnuFm_Word_Wrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFm_Word_Wrap.Click
        Try
            'Check/Uncheck
            mnuFm_Word_Wrap.CheckState = (mnuFm_Word_Wrap.CheckState + 1) Mod 2
            rtxtEditor.WordWrap = mnuFm_Word_Wrap.CheckState = CheckState.Checked
        Catch ex As Exception
            'Khong can quan ly loi
        End Try

    End Sub

    Private Sub mnuV_Status_Bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuV_Status_Bar.Click
        Try
            'Check/Uncheck
            mnuV_Status_Bar.CheckState = (mnuV_Status_Bar.CheckState + 1) Mod 2
            statusbar.Visible = mnuV_Status_Bar.CheckState = CheckState.Checked
        Catch ex As Exception
            'Khong can quan ly loi
        End Try
    End Sub

    Private Sub mnuFm_Font_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFm_Font.Click
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
#Region "Cac ham xu ly"

#End Region

End Class
