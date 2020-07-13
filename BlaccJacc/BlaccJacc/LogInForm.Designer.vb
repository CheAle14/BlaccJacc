<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.CMDNewUser = New System.Windows.Forms.Button()
        Me.LBLUserList = New System.Windows.Forms.ListBox()
        Me.CMDQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDNewUser
        '
        Me.CMDNewUser.Location = New System.Drawing.Point(159, 296)
        Me.CMDNewUser.Name = "CMDNewUser"
        Me.CMDNewUser.Size = New System.Drawing.Size(140, 51)
        Me.CMDNewUser.TabIndex = 0
        Me.CMDNewUser.Text = "New User"
        Me.CMDNewUser.UseVisualStyleBackColor = True
        '
        'LBLUserList
        '
        Me.LBLUserList.FormattingEnabled = True
        Me.LBLUserList.Location = New System.Drawing.Point(12, 12)
        Me.LBLUserList.Name = "LBLUserList"
        Me.LBLUserList.Size = New System.Drawing.Size(286, 264)
        Me.LBLUserList.TabIndex = 1
        '
        'CMDQuit
        '
        Me.CMDQuit.Location = New System.Drawing.Point(12, 296)
        Me.CMDQuit.Name = "CMDQuit"
        Me.CMDQuit.Size = New System.Drawing.Size(141, 51)
        Me.CMDQuit.TabIndex = 2
        Me.CMDQuit.Text = "Quit"
        Me.CMDQuit.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(311, 359)
        Me.Controls.Add(Me.CMDQuit)
        Me.Controls.Add(Me.LBLUserList)
        Me.Controls.Add(Me.CMDNewUser)
        Me.MaximizeBox = False
        Me.Name = "LogIn"
        Me.Text = "Select a User"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CMDNewUser As Button
    Friend WithEvents LBLUserList As ListBox
    Friend WithEvents CMDQuit As Button
End Class
