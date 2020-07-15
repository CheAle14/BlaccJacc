<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.LBLWelcome = New System.Windows.Forms.Label()
        Me.LBLTitle = New System.Windows.Forms.Label()
        Me.CMDPlay = New System.Windows.Forms.Button()
        Me.CMDQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLWelcome
        '
        Me.LBLWelcome.AutoSize = True
        Me.LBLWelcome.BackColor = System.Drawing.Color.Transparent
        Me.LBLWelcome.ForeColor = System.Drawing.Color.Gold
        Me.LBLWelcome.Location = New System.Drawing.Point(64, 9)
        Me.LBLWelcome.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLWelcome.Name = "LBLWelcome"
        Me.LBLWelcome.Size = New System.Drawing.Size(67, 25)
        Me.LBLWelcome.TabIndex = 0
        Me.LBLWelcome.Text = "Hello "
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.BackColor = System.Drawing.Color.Transparent
        Me.LBLTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.ForeColor = System.Drawing.Color.Gold
        Me.LBLTitle.Location = New System.Drawing.Point(174, 78)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(348, 73)
        Me.LBLTitle.TabIndex = 1
        Me.LBLTitle.Text = "Black Jack"
        '
        'CMDPlay
        '
        Me.CMDPlay.BackColor = System.Drawing.Color.Transparent
        Me.CMDPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDPlay.ForeColor = System.Drawing.Color.Gold
        Me.CMDPlay.Location = New System.Drawing.Point(12, 390)
        Me.CMDPlay.Name = "CMDPlay"
        Me.CMDPlay.Size = New System.Drawing.Size(648, 119)
        Me.CMDPlay.TabIndex = 2
        Me.CMDPlay.Text = "Play Game!"
        Me.CMDPlay.UseVisualStyleBackColor = False
        '
        'CMDQuit
        '
        Me.CMDQuit.BackColor = System.Drawing.Color.Transparent
        Me.CMDQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDQuit.ForeColor = System.Drawing.Color.Gold
        Me.CMDQuit.Location = New System.Drawing.Point(165, 534)
        Me.CMDQuit.Name = "CMDQuit"
        Me.CMDQuit.Size = New System.Drawing.Size(325, 119)
        Me.CMDQuit.TabIndex = 3
        Me.CMDQuit.Text = "Quit"
        Me.CMDQuit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BlaccJacc.My.Resources.Resources.mian_menu_cards
        Me.PictureBox1.Location = New System.Drawing.Point(69, -55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(531, 545)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(672, 676)
        Me.Controls.Add(Me.CMDQuit)
        Me.Controls.Add(Me.CMDPlay)
        Me.Controls.Add(Me.LBLTitle)
        Me.Controls.Add(Me.LBLWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLWelcome As Label
    Friend WithEvents LBLTitle As Label
    Friend WithEvents CMDPlay As Button
    Friend WithEvents CMDQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
