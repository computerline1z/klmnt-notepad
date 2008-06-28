Public Class FrmReplace

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnFNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFNext.Click
        'Code FindNext
        Dim RTF_OptFind As RichTextBoxFinds

        RTF_OptFind = RichTextBoxFinds.None
        If chkMatchCase.Checked = True Then
            RTF_OptFind = RichTextBoxFinds.MatchCase
        End If
        'If RdbUp.Checked = True Then
        '    RTF_OptFind = RTF_OptFind Or RichTextBoxFinds.Reverse
        'End If
        frmNotepad.FindNext(txtTextFind.Text, RTF_OptFind)
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        'Bien luu tuy chon tim kiem
        Dim i_Compare As Integer
        If chkMatchCase.Checked Then
            i_Compare = CompareMethod.Binary
        Else
            i_Compare = CompareMethod.Text
        End If
        'Thuc hien tim kiem va thay the
        frmNotepad.FindNReplace(txtTextFind.Text, txtTextReplace.Text, i_Compare)
    End Sub

    Private Sub txtTextFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTextFind.TextChanged
        'Code
        'Neu rong thi disable nut Find Next, Replace, Replace All
        Dim b_val As Boolean = txtTextFind.Text <> ""
        btnFNext.Enabled = b_val
        btnReplace.Enabled = b_val
        btnRplaceAll.Enabled = b_val
    End Sub

    Private Sub btnRplaceAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRplaceAll.Click
        'Bien luu tuy chon tim kiem
        Dim RTF_OptFind As RichTextBoxFinds

        If chkMatchCase.Checked Then
            RTF_OptFind = RichTextBoxFinds.MatchCase
        Else
            RTF_OptFind = RichTextBoxFinds.None
        End If

        'Thuc hien tim kiem va thay the
        frmNotepad.ReplaceAll(txtTextFind.Text, txtTextReplace.Text, RTF_OptFind)
    End Sub
End Class