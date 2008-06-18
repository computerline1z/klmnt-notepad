Public Class FrmGoto

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Di chuyen den dong tuong ung
        Try
            Dim i_line As Long = Val(txtLine.Text) - 1
            If i_line >= frmNotepad.rtxtEditor.Lines.LongLength Then
                MsgBox("Line number out of range", MsgBoxStyle.Critical, Application.ProductName & " - ")
                'Lay lai gia tri cu
                txtLine.Undo()
                txtLine.SelectAll()
            Else
                frmNotepad.GoToLine(i_line)
                Me.Close()
            End If
        Catch ex As Exception
            'Quan ly loi
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtLine_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLine.KeyPress
        If IsNumeric(e.KeyChar) <> True Then e.KeyChar = ""
    End Sub

End Class