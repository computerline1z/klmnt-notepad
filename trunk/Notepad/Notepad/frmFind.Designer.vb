<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.btnFindNext = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GrpbDirection = New System.Windows.Forms.GroupBox
        Me.RdbDown = New System.Windows.Forms.RadioButton
        Me.RdbUp = New System.Windows.Forms.RadioButton
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GrpbDirection.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find what"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(66, 6)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(210, 20)
        Me.txtFind.TabIndex = 1
        '
        'btnFindNext
        '
        Me.btnFindNext.Location = New System.Drawing.Point(282, 4)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(75, 23)
        Me.btnFindNext.TabIndex = 2
        Me.btnFindNext.Text = "Find Next"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 68)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Match case"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GrpbDirection
        '
        Me.GrpbDirection.Controls.Add(Me.RdbDown)
        Me.GrpbDirection.Controls.Add(Me.RdbUp)
        Me.GrpbDirection.Location = New System.Drawing.Point(167, 39)
        Me.GrpbDirection.Name = "GrpbDirection"
        Me.GrpbDirection.Size = New System.Drawing.Size(109, 46)
        Me.GrpbDirection.TabIndex = 4
        Me.GrpbDirection.TabStop = False
        Me.GrpbDirection.Text = "Direction"
        '
        'RdbDown
        '
        Me.RdbDown.AutoSize = True
        Me.RdbDown.Location = New System.Drawing.Point(50, 20)
        Me.RdbDown.Name = "RdbDown"
        Me.RdbDown.Size = New System.Drawing.Size(53, 17)
        Me.RdbDown.TabIndex = 1
        Me.RdbDown.TabStop = True
        Me.RdbDown.Text = "Down"
        Me.RdbDown.UseVisualStyleBackColor = True
        '
        'RdbUp
        '
        Me.RdbUp.AutoSize = True
        Me.RdbUp.Location = New System.Drawing.Point(8, 20)
        Me.RdbUp.Name = "RdbUp"
        Me.RdbUp.Size = New System.Drawing.Size(39, 17)
        Me.RdbUp.TabIndex = 0
        Me.RdbUp.TabStop = True
        Me.RdbUp.Text = "Up"
        Me.RdbUp.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(282, 33)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 100)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GrpbDirection)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnFindNext)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.Text = "Find"
        Me.GrpbDirection.ResumeLayout(False)
        Me.GrpbDirection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GrpbDirection As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents RdbDown As System.Windows.Forms.RadioButton
    Friend WithEvents RdbUp As System.Windows.Forms.RadioButton
End Class
