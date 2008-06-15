Public Class frmNotepad
    Dim b_EditorChange As Boolean
    Dim s_filename As String
#Region "Cac su kien tren form"
    Private Sub frmNotepad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Khoi tao cac bien
        b_EditorChange = True
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
#End Region
#Region "Cac ham xu ly"

#End Region

    Private Sub mnuFm_Word_Wrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFm_Word_Wrap.Click
        Try
            rtxtEditor.WordWrap = mnuFm_Word_Wrap.CheckState = CheckState.Checked
            'Check/Uncheck
            mnuFm_Word_Wrap.CheckState = (mnuFm_Word_Wrap.CheckState + 1) Mod 2
            'Khong xet la co thay doi noi dung
            b_EditorChange = False
        Catch ex As Exception
            'Khong can quan ly loi
        End Try
        
    End Sub

    Private Sub mnuV_Status_Bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuV_Status_Bar.Click
        Try
            statusbar.Visible = mnuV_Status_Bar.CheckState = CheckState.Checked
            'Check/Uncheck
            mnuV_Status_Bar.CheckState = (mnuV_Status_Bar.CheckState + 1) Mod 2
            'Khong xet la co thay doi noi dung
            b_EditorChange = False
        Catch ex As Exception
            'Khong can quan ly loi
        End Try
    End Sub
End Class
