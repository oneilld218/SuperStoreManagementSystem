<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.uname = New System.Windows.Forms.Label()
        Me.pwd = New System.Windows.Forms.Label()
        Me.unameTextBox = New System.Windows.Forms.TextBox()
        Me.pwdTextBox = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.AutoSize = True
        Me.uname.BackColor = System.Drawing.Color.Transparent
        Me.uname.Font = New System.Drawing.Font("Swis721 BlkEx BT", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname.ForeColor = System.Drawing.Color.White
        Me.uname.Location = New System.Drawing.Point(105, 32)
        Me.uname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(214, 29)
        Me.uname.TabIndex = 0
        Me.uname.Text = "USER NAME"
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.BackColor = System.Drawing.Color.Transparent
        Me.pwd.Font = New System.Drawing.Font("Swis721 BlkEx BT", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.ForeColor = System.Drawing.Color.White
        Me.pwd.Location = New System.Drawing.Point(109, 170)
        Me.pwd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(207, 29)
        Me.pwd.TabIndex = 1
        Me.pwd.Text = "PASSWORD"
        '
        'unameTextBox
        '
        Me.unameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.unameTextBox.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.unameTextBox.Location = New System.Drawing.Point(41, 65)
        Me.unameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.unameTextBox.Multiline = True
        Me.unameTextBox.Name = "unameTextBox"
        Me.unameTextBox.Size = New System.Drawing.Size(342, 48)
        Me.unameTextBox.TabIndex = 2
        Me.unameTextBox.WordWrap = False
        '
        'pwdTextBox
        '
        Me.pwdTextBox.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdTextBox.Location = New System.Drawing.Point(41, 203)
        Me.pwdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.pwdTextBox.Multiline = True
        Me.pwdTextBox.Name = "pwdTextBox"
        Me.pwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwdTextBox.Size = New System.Drawing.Size(342, 46)
        Me.pwdTextBox.TabIndex = 3
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.submit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.submit.Font = New System.Drawing.Font("Swis721 BlkEx BT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.White
        Me.submit.Location = New System.Drawing.Point(41, 312)
        Me.submit.Margin = New System.Windows.Forms.Padding(4)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(342, 69)
        Me.submit.TabIndex = 4
        Me.submit.Text = "LOGIN"
        Me.submit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.uname)
        Me.GroupBox1.Controls.Add(Me.submit)
        Me.GroupBox1.Controls.Add(Me.pwd)
        Me.GroupBox1.Controls.Add(Me.pwdTextBox)
        Me.GroupBox1.Controls.Add(Me.unameTextBox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(407, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 484)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SuperStoreManagementSystem.My.Resources.Resources.closee
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(393, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Super Store Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uname As Label
    Friend WithEvents pwd As Label
    Friend WithEvents unameTextBox As TextBox
    Friend WithEvents pwdTextBox As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
