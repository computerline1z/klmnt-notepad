Public Class frmFind
    'Khai bao cac bien
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNext.Click
        'Code FindNext
        Dim RTF_OptFind As RichTextBoxFinds

        RTF_OptFind = RichTextBoxFinds.None
        If chkMatchCase.Checked = True Then
            RTF_OptFind = RichTextBoxFinds.MatchCase
        End If
        If RdbUp.Checked = True Then
            RTF_OptFind = RTF_OptFind Or RichTextBoxFinds.Reverse
        End If
        frmNotepad.FindNext(txtFind.Text, RTF_OptFind)

    End Sub

    Private Sub txtFind_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFind.GotFocus
        txtFind.SelectAll()
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        'Code
        'Neu rong thi disable nut Find Next
        btnFindNext.Enabled = txtFind.Text <> ""
    End Sub

    Private Sub frmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Khoi tao cac bien

    End Sub

End Class