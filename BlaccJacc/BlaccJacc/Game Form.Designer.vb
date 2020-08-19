<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_Form))
        Me.CmdQuit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UserCard2 = New System.Windows.Forms.PictureBox()
        Me.UserCard1 = New System.Windows.Forms.PictureBox()
        Me.Player2Card2 = New System.Windows.Forms.PictureBox()
        Me.Player2Card1 = New System.Windows.Forms.PictureBox()
        Me.Player1Card2 = New System.Windows.Forms.PictureBox()
        Me.Player1Card1 = New System.Windows.Forms.PictureBox()
        Me.DealerCard1 = New System.Windows.Forms.PictureBox()
        Me.DealerCard2 = New System.Windows.Forms.PictureBox()
        Me.DealerCard3 = New System.Windows.Forms.PictureBox()
        Me.DealerCard4 = New System.Windows.Forms.PictureBox()
        Me.DealerCard5 = New System.Windows.Forms.PictureBox()
        Me.UserCard3 = New System.Windows.Forms.PictureBox()
        Me.UserCard4 = New System.Windows.Forms.PictureBox()
        Me.UserCard5 = New System.Windows.Forms.PictureBox()
        Me.Player1Card4 = New System.Windows.Forms.PictureBox()
        Me.Player1Card3 = New System.Windows.Forms.PictureBox()
        Me.Player2Card4 = New System.Windows.Forms.PictureBox()
        Me.Player2Card3 = New System.Windows.Forms.PictureBox()
        Me.Player1Card5 = New System.Windows.Forms.PictureBox()
        Me.Player2Card5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdQuit
        '
        Me.CmdQuit.BackColor = System.Drawing.Color.Transparent
        Me.CmdQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdQuit.ForeColor = System.Drawing.Color.Gold
        Me.CmdQuit.Location = New System.Drawing.Point(1771, 1003)
        Me.CmdQuit.Name = "CmdQuit"
        Me.CmdQuit.Size = New System.Drawing.Size(141, 46)
        Me.CmdQuit.TabIndex = 0
        Me.CmdQuit.Text = "Quit"
        Me.CmdQuit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.PictureBox1.Location = New System.Drawing.Point(1675, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 333)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'UserCard2
        '
        Me.UserCard2.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.UserCard2.Location = New System.Drawing.Point(868, 735)
        Me.UserCard2.Name = "UserCard2"
        Me.UserCard2.Size = New System.Drawing.Size(212, 301)
        Me.UserCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard2.TabIndex = 2
        Me.UserCard2.TabStop = False
        '
        'UserCard1
        '
        Me.UserCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserCard1.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.UserCard1.Location = New System.Drawing.Point(645, 735)
        Me.UserCard1.Name = "UserCard1"
        Me.UserCard1.Size = New System.Drawing.Size(212, 301)
        Me.UserCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard1.TabIndex = 3
        Me.UserCard1.TabStop = False
        '
        'Player2Card2
        '
        Me.Player2Card2.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player2Card2.Location = New System.Drawing.Point(164, 454)
        Me.Player2Card2.Name = "Player2Card2"
        Me.Player2Card2.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card2.TabIndex = 5
        Me.Player2Card2.TabStop = False
        '
        'Player2Card1
        '
        Me.Player2Card1.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player2Card1.Location = New System.Drawing.Point(7, 454)
        Me.Player2Card1.Name = "Player2Card1"
        Me.Player2Card1.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card1.TabIndex = 4
        Me.Player2Card1.TabStop = False
        '
        'Player1Card2
        '
        Me.Player1Card2.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player1Card2.Location = New System.Drawing.Point(164, 215)
        Me.Player1Card2.Name = "Player1Card2"
        Me.Player1Card2.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card2.TabIndex = 7
        Me.Player1Card2.TabStop = False
        '
        'Player1Card1
        '
        Me.Player1Card1.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player1Card1.Location = New System.Drawing.Point(7, 215)
        Me.Player1Card1.Name = "Player1Card1"
        Me.Player1Card1.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card1.TabIndex = 6
        Me.Player1Card1.TabStop = False
        '
        'DealerCard1
        '
        Me.DealerCard1.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.DealerCard1.Location = New System.Drawing.Point(807, 23)
        Me.DealerCard1.Name = "DealerCard1"
        Me.DealerCard1.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard1.TabIndex = 9
        Me.DealerCard1.TabStop = False
        '
        'DealerCard2
        '
        Me.DealerCard2.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.DealerCard2.Location = New System.Drawing.Point(964, 23)
        Me.DealerCard2.Name = "DealerCard2"
        Me.DealerCard2.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard2.TabIndex = 8
        Me.DealerCard2.TabStop = False
        '
        'DealerCard3
        '
        Me.DealerCard3.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.DealerCard3.Location = New System.Drawing.Point(1122, 23)
        Me.DealerCard3.Name = "DealerCard3"
        Me.DealerCard3.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard3.TabIndex = 11
        Me.DealerCard3.TabStop = False
        '
        'DealerCard4
        '
        Me.DealerCard4.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.DealerCard4.Location = New System.Drawing.Point(1279, 23)
        Me.DealerCard4.Name = "DealerCard4"
        Me.DealerCard4.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard4.TabIndex = 10
        Me.DealerCard4.TabStop = False
        '
        'DealerCard5
        '
        Me.DealerCard5.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.DealerCard5.Location = New System.Drawing.Point(1436, 23)
        Me.DealerCard5.Name = "DealerCard5"
        Me.DealerCard5.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard5.TabIndex = 12
        Me.DealerCard5.TabStop = False
        '
        'UserCard3
        '
        Me.UserCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserCard3.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.UserCard3.Location = New System.Drawing.Point(1089, 735)
        Me.UserCard3.Name = "UserCard3"
        Me.UserCard3.Size = New System.Drawing.Size(212, 301)
        Me.UserCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard3.TabIndex = 14
        Me.UserCard3.TabStop = False
        '
        'UserCard4
        '
        Me.UserCard4.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.UserCard4.Location = New System.Drawing.Point(1312, 735)
        Me.UserCard4.Name = "UserCard4"
        Me.UserCard4.Size = New System.Drawing.Size(212, 301)
        Me.UserCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard4.TabIndex = 13
        Me.UserCard4.TabStop = False
        '
        'UserCard5
        '
        Me.UserCard5.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.UserCard5.Location = New System.Drawing.Point(1530, 735)
        Me.UserCard5.Name = "UserCard5"
        Me.UserCard5.Size = New System.Drawing.Size(212, 301)
        Me.UserCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard5.TabIndex = 15
        Me.UserCard5.TabStop = False
        '
        'Player1Card4
        '
        Me.Player1Card4.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player1Card4.Location = New System.Drawing.Point(478, 215)
        Me.Player1Card4.Name = "Player1Card4"
        Me.Player1Card4.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card4.TabIndex = 19
        Me.Player1Card4.TabStop = False
        '
        'Player1Card3
        '
        Me.Player1Card3.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player1Card3.Location = New System.Drawing.Point(321, 215)
        Me.Player1Card3.Name = "Player1Card3"
        Me.Player1Card3.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card3.TabIndex = 18
        Me.Player1Card3.TabStop = False
        '
        'Player2Card4
        '
        Me.Player2Card4.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player2Card4.Location = New System.Drawing.Point(478, 454)
        Me.Player2Card4.Name = "Player2Card4"
        Me.Player2Card4.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card4.TabIndex = 17
        Me.Player2Card4.TabStop = False
        '
        'Player2Card3
        '
        Me.Player2Card3.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player2Card3.Location = New System.Drawing.Point(321, 454)
        Me.Player2Card3.Name = "Player2Card3"
        Me.Player2Card3.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card3.TabIndex = 16
        Me.Player2Card3.TabStop = False
        '
        'Player1Card5
        '
        Me.Player1Card5.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player1Card5.Location = New System.Drawing.Point(635, 215)
        Me.Player1Card5.Name = "Player1Card5"
        Me.Player1Card5.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card5.TabIndex = 21
        Me.Player1Card5.TabStop = False
        '
        'Player2Card5
        '
        Me.Player2Card5.Image = Global.BlaccJacc.My.Resources.Resources.back_of_cards
        Me.Player2Card5.Location = New System.Drawing.Point(635, 454)
        Me.Player2Card5.Name = "Player2Card5"
        Me.Player2Card5.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card5.TabIndex = 20
        Me.Player2Card5.TabStop = False
        '
        'Game_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.Player1Card5)
        Me.Controls.Add(Me.Player2Card5)
        Me.Controls.Add(Me.Player1Card4)
        Me.Controls.Add(Me.Player1Card3)
        Me.Controls.Add(Me.Player2Card4)
        Me.Controls.Add(Me.Player2Card3)
        Me.Controls.Add(Me.UserCard5)
        Me.Controls.Add(Me.UserCard3)
        Me.Controls.Add(Me.UserCard4)
        Me.Controls.Add(Me.DealerCard5)
        Me.Controls.Add(Me.DealerCard3)
        Me.Controls.Add(Me.DealerCard4)
        Me.Controls.Add(Me.DealerCard1)
        Me.Controls.Add(Me.DealerCard2)
        Me.Controls.Add(Me.Player1Card2)
        Me.Controls.Add(Me.Player1Card1)
        Me.Controls.Add(Me.Player2Card2)
        Me.Controls.Add(Me.Player2Card1)
        Me.Controls.Add(Me.UserCard1)
        Me.Controls.Add(Me.UserCard2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CmdQuit)
        Me.MaximizeBox = False
        Me.Name = "Game_Form"
        Me.Text = "Game_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2Card5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdQuit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UserCard2 As PictureBox
    Friend WithEvents UserCard1 As PictureBox
    Friend WithEvents Player2Card2 As PictureBox
    Friend WithEvents Player2Card1 As PictureBox
    Friend WithEvents Player1Card2 As PictureBox
    Friend WithEvents Player1Card1 As PictureBox
    Friend WithEvents DealerCard1 As PictureBox
    Friend WithEvents DealerCard2 As PictureBox
    Friend WithEvents DealerCard3 As PictureBox
    Friend WithEvents DealerCard4 As PictureBox
    Friend WithEvents DealerCard5 As PictureBox
    Friend WithEvents UserCard3 As PictureBox
    Friend WithEvents UserCard4 As PictureBox
    Friend WithEvents UserCard5 As PictureBox
    Friend WithEvents Player1Card4 As PictureBox
    Friend WithEvents Player1Card3 As PictureBox
    Friend WithEvents Player2Card4 As PictureBox
    Friend WithEvents Player2Card3 As PictureBox
    Friend WithEvents Player1Card5 As PictureBox
    Friend WithEvents Player2Card5 As PictureBox
End Class
