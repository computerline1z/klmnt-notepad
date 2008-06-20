Imports System.Net.Mail
Public NotInheritable Class frmAbout

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' title
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Me.Text = Space(10) & "KLMNT Notepad."

        TextBox2.Text = ""
        Me.Button1.Width = 0
        Me.Button1.Height = 0
        Me.CancelButton = Button1
        nCount = 1
        nRatio = 1

    End Sub

    Private nCount As Integer = 1
    Private nRatio As Integer = 1


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = Strings.Right(Me.Text, Me.Text.Length - 1)
        If Me.Text = "" Then
            Me.Text = Space(100) & "KLMNT Notepad."
        End If

        Dim sSpace = "     "
        Dim sValue As String = ""
        With TextBox2
            Select Case nCount
                Case 1
                    sValue = " Trường Đại học khoa hoc tự nhiên"
                    If nRatio = 1 Then
                        .Text = sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 2
                    sValue = " Khoa Công nghệ thông tin"
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 3
                    sValue = " Lớp 06HCB. "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 4
                    sValue = " ------------------------------------- "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If

                Case 5
                    sValue = " Đồ án môn Quản lý cấu hình phần mềm "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If

                Case 6
                    sValue = " K L M N T  -  N O T E P A D "

                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If

                Case 7
                    sValue = " Version 1.0.0 "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 8
                    sValue = " -------------------------------- "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If

                Case 9
                    sValue = " < PHỤ TRÁCH SẢN PHẨM >"
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If

                Case 10
                    sValue = " - Cao Lê Hồng Lĩnh. "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 11
                    sValue = " -  Đoàn Thị Huỳnh Mai. "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 12
                    sValue = " - Nguyễn Thị Kim Trúc. "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 13
                    sValue = " - Lê Thị Ngà. "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case 14
                    sValue = " - Đồng Nhật Kha. "
                    If nRatio = 1 Then
                        .Text += vbCrLf.ToString & sValue
                    Else
                        .Text = Replace(.Text, sValue, "")
                    End If
                Case Else
                    nCount = 0
                    nRatio = (nRatio Mod 2) + 1
            End Select
            nCount += 1
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
    End Sub
End Class
