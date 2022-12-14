<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelUname = New System.Windows.Forms.Label()
        Me.LabelPW = New System.Windows.Forms.Label()
        Me.TextBoxUname = New System.Windows.Forms.TextBox()
        Me.TextBoxPW = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelUname
        '
        Me.LabelUname.AutoSize = True
        Me.LabelUname.Location = New System.Drawing.Point(124, 97)
        Me.LabelUname.Name = "LabelUname"
        Me.LabelUname.Size = New System.Drawing.Size(91, 25)
        Me.LabelUname.TabIndex = 0
        Me.LabelUname.Text = "Username"
        '
        'LabelPW
        '
        Me.LabelPW.AutoSize = True
        Me.LabelPW.Location = New System.Drawing.Point(124, 163)
        Me.LabelPW.Name = "LabelPW"
        Me.LabelPW.Size = New System.Drawing.Size(87, 25)
        Me.LabelPW.TabIndex = 1
        Me.LabelPW.Text = "Password"
        '
        'TextBoxUname
        '
        Me.TextBoxUname.Location = New System.Drawing.Point(312, 97)
        Me.TextBoxUname.Name = "TextBoxUname"
        Me.TextBoxUname.Size = New System.Drawing.Size(400, 31)
        Me.TextBoxUname.TabIndex = 2
        '
        'TextBoxPW
        '
        Me.TextBoxPW.Location = New System.Drawing.Point(312, 157)
        Me.TextBoxPW.Name = "TextBoxPW"
        Me.TextBoxPW.Size = New System.Drawing.Size(400, 31)
        Me.TextBoxPW.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(600, 246)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(112, 34)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnReg
        '
        Me.BtnReg.Location = New System.Drawing.Point(124, 246)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(112, 34)
        Me.BtnReg.TabIndex = 5
        Me.BtnReg.Text = "Register"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TextBoxPW)
        Me.Controls.Add(Me.TextBoxUname)
        Me.Controls.Add(Me.LabelPW)
        Me.Controls.Add(Me.LabelUname)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUname As Label
    Friend WithEvents LabelPW As Label
    Friend WithEvents TextBoxUname As TextBox
    Friend WithEvents TextBoxPW As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnReg As Button
End Class
