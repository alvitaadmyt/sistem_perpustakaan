<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.LblUname = New System.Windows.Forms.Label()
        Me.LblPW = New System.Windows.Forms.Label()
        Me.TxtBoxUname = New System.Windows.Forms.TextBox()
        Me.TxtBoxPW = New System.Windows.Forms.TextBox()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogReg = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUname
        '
        Me.LblUname.AutoSize = True
        Me.LblUname.Location = New System.Drawing.Point(114, 89)
        Me.LblUname.Name = "LblUname"
        Me.LblUname.Size = New System.Drawing.Size(91, 25)
        Me.LblUname.TabIndex = 0
        Me.LblUname.Text = "Username"
        '
        'LblPW
        '
        Me.LblPW.AutoSize = True
        Me.LblPW.Location = New System.Drawing.Point(114, 176)
        Me.LblPW.Name = "LblPW"
        Me.LblPW.Size = New System.Drawing.Size(87, 25)
        Me.LblPW.TabIndex = 1
        Me.LblPW.Text = "Password"
        '
        'TxtBoxUname
        '
        Me.TxtBoxUname.Location = New System.Drawing.Point(273, 83)
        Me.TxtBoxUname.Name = "TxtBoxUname"
        Me.TxtBoxUname.Size = New System.Drawing.Size(436, 31)
        Me.TxtBoxUname.TabIndex = 2
        '
        'TxtBoxPW
        '
        Me.TxtBoxPW.Location = New System.Drawing.Point(273, 176)
        Me.TxtBoxPW.Name = "TxtBoxPW"
        Me.TxtBoxPW.Size = New System.Drawing.Size(436, 31)
        Me.TxtBoxPW.TabIndex = 3
        '
        'BtnReg
        '
        Me.BtnReg.Location = New System.Drawing.Point(597, 301)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(112, 34)
        Me.BtnReg.TabIndex = 4
        Me.BtnReg.Text = "Register"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sudah punya akun?"
        '
        'BtnLogReg
        '
        Me.BtnLogReg.Location = New System.Drawing.Point(287, 271)
        Me.BtnLogReg.Name = "BtnLogReg"
        Me.BtnLogReg.Size = New System.Drawing.Size(112, 34)
        Me.BtnLogReg.TabIndex = 6
        Me.BtnLogReg.Text = "Login"
        Me.BtnLogReg.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "disini"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLogReg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.TxtBoxPW)
        Me.Controls.Add(Me.TxtBoxUname)
        Me.Controls.Add(Me.LblPW)
        Me.Controls.Add(Me.LblUname)
        Me.Name = "register"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUname As Label
    Friend WithEvents LblPW As Label
    Friend WithEvents TxtBoxUname As TextBox
    Friend WithEvents TxtBoxPW As TextBox
    Friend WithEvents BtnReg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLogReg As Button

    Private Sub BtnLoginReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click

    End Sub

    Friend WithEvents Label2 As Label
End Class
