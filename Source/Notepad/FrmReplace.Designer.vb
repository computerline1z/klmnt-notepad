<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplace
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
        Me.btnReplace = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTextFind = New System.Windows.Forms.TextBox
        Me.txtTextReplace = New System.Windows.Forms.TextBox
        Me.btnFNext = New System.Windows.Forms.Button
        Me.btnRplaceAll = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.chkMatchCase = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btnReplace
        '
        Me.btnReplace.Enabled = False
        Me.btnReplace.Location = New System.Drawing.Point(257, 32)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "&Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fi&nd what"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Re&place with"
        '
        'txtTextFind
        '
        Me.txtTextFind.Location = New System.Drawing.Point(84, 9)
        Me.txtTextFind.Name = "txtTextFind"
        Me.txtTextFind.Size = New System.Drawing.Size(167, 20)
        Me.txtTextFind.TabIndex = 1
        '
        'txtTextReplace
        '
        Me.txtTextReplace.Location = New System.Drawing.Point(84, 38)
        Me.txtTextReplace.Name = "txtTextReplace"
        Me.txtTextReplace.Size = New System.Drawing.Size(168, 20)
        Me.txtTextReplace.TabIndex = 3
        '
        'btnFNext
        '
        Me.btnFNext.Enabled = False
        Me.btnFNext.Location = New System.Drawing.Point(257, 5)
        Me.btnFNext.Name = "btnFNext"
        Me.btnFNext.Size = New System.Drawing.Size(75, 23)
        Me.btnFNext.TabIndex = 5
        Me.btnFNext.Text = "&Find Next"
        Me.btnFNext.UseVisualStyleBackColor = True
        '
        'btnRplaceAll
        '
        Me.btnRplaceAll.Enabled = False
        Me.btnRplaceAll.Location = New System.Drawing.Point(257, 59)
        Me.btnRplaceAll.Name = "btnRplaceAll"
        Me.btnRplaceAll.Size = New System.Drawing.Size(75, 23)
        Me.btnRplaceAll.TabIndex = 7
        Me.btnRplaceAll.Text = "Replace &All"
        Me.btnRplaceAll.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(257, 86)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(11, 90)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(82, 17)
        Me.chkMatchCase.TabIndex = 4
        Me.chkMatchCase.Text = "Match &case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'FrmReplace
        '
        Me.AcceptButton = Me.btnFNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(338, 122)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.txtTextReplace)
        Me.Controls.Add(Me.txtTextFind)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRplaceAll)
        Me.Controls.Add(Me.btnReplace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReplace"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTextFind As System.Windows.Forms.TextBox
    Friend WithEvents txtTextReplace As System.Windows.Forms.TextBox
    Friend WithEvents btnFNext As System.Windows.Forms.Button
    Friend WithEvents btnRplaceAll As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkMatchCase As System.Windows.Forms.CheckBox
End Class
