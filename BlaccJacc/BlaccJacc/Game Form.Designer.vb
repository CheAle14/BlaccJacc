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
        Me.PileOfCards = New System.Windows.Forms.PictureBox()
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
        Me.PayIn = New System.Windows.Forms.TrackBar()
        Me.PayInNum = New System.Windows.Forms.Label()
        Me.PlaceBet = New System.Windows.Forms.Button()
        Me.BtnHit = New System.Windows.Forms.Button()
        Me.BtnStand = New System.Windows.Forms.Button()
        CType(Me.PileOfCards, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.PayIn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PileOfCards
        '
        Me.PileOfCards.BackColor = System.Drawing.Color.Transparent
        Me.PileOfCards.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.PileOfCards.Location = New System.Drawing.Point(1675, 23)
        Me.PileOfCards.Name = "PileOfCards"
        Me.PileOfCards.Size = New System.Drawing.Size(217, 333)
        Me.PileOfCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PileOfCards.TabIndex = 1
        Me.PileOfCards.TabStop = False
        '
        'UserCard2
        '
        Me.UserCard2.BackColor = System.Drawing.Color.Transparent
        Me.UserCard2.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.UserCard2.Location = New System.Drawing.Point(868, 735)
        Me.UserCard2.Name = "UserCard2"
        Me.UserCard2.Size = New System.Drawing.Size(212, 301)
        Me.UserCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard2.TabIndex = 2
        Me.UserCard2.TabStop = False
        Me.UserCard2.Visible = False
        '
        'UserCard1
        '
        Me.UserCard1.BackColor = System.Drawing.Color.Transparent
        Me.UserCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserCard1.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.UserCard1.Location = New System.Drawing.Point(645, 735)
        Me.UserCard1.Name = "UserCard1"
        Me.UserCard1.Size = New System.Drawing.Size(212, 301)
        Me.UserCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard1.TabIndex = 3
        Me.UserCard1.TabStop = False
        Me.UserCard1.Visible = False
        '
        'Player2Card2
        '
        Me.Player2Card2.BackColor = System.Drawing.Color.Transparent
        Me.Player2Card2.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player2Card2.Location = New System.Drawing.Point(164, 454)
        Me.Player2Card2.Name = "Player2Card2"
        Me.Player2Card2.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card2.TabIndex = 5
        Me.Player2Card2.TabStop = False
        Me.Player2Card2.Visible = False
        '
        'Player2Card1
        '
        Me.Player2Card1.BackColor = System.Drawing.Color.Transparent
        Me.Player2Card1.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player2Card1.Location = New System.Drawing.Point(7, 454)
        Me.Player2Card1.Name = "Player2Card1"
        Me.Player2Card1.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card1.TabIndex = 4
        Me.Player2Card1.TabStop = False
        Me.Player2Card1.Visible = False
        '
        'Player1Card2
        '
        Me.Player1Card2.BackColor = System.Drawing.Color.Transparent
        Me.Player1Card2.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player1Card2.Location = New System.Drawing.Point(164, 215)
        Me.Player1Card2.Name = "Player1Card2"
        Me.Player1Card2.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card2.TabIndex = 7
        Me.Player1Card2.TabStop = False
        Me.Player1Card2.Visible = False
        '
        'Player1Card1
        '
        Me.Player1Card1.BackColor = System.Drawing.Color.Transparent
        Me.Player1Card1.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player1Card1.Location = New System.Drawing.Point(7, 215)
        Me.Player1Card1.Name = "Player1Card1"
        Me.Player1Card1.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card1.TabIndex = 6
        Me.Player1Card1.TabStop = False
        Me.Player1Card1.Visible = False
        '
        'DealerCard1
        '
        Me.DealerCard1.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard1.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.DealerCard1.Location = New System.Drawing.Point(807, 23)
        Me.DealerCard1.Name = "DealerCard1"
        Me.DealerCard1.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard1.TabIndex = 9
        Me.DealerCard1.TabStop = False
        Me.DealerCard1.Visible = False
        '
        'DealerCard2
        '
        Me.DealerCard2.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard2.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.DealerCard2.Location = New System.Drawing.Point(964, 23)
        Me.DealerCard2.Name = "DealerCard2"
        Me.DealerCard2.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard2.TabIndex = 8
        Me.DealerCard2.TabStop = False
        Me.DealerCard2.Visible = False
        '
        'DealerCard3
        '
        Me.DealerCard3.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard3.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.DealerCard3.Location = New System.Drawing.Point(1122, 23)
        Me.DealerCard3.Name = "DealerCard3"
        Me.DealerCard3.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard3.TabIndex = 11
        Me.DealerCard3.TabStop = False
        Me.DealerCard3.Visible = False
        '
        'DealerCard4
        '
        Me.DealerCard4.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard4.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.DealerCard4.Location = New System.Drawing.Point(1279, 23)
        Me.DealerCard4.Name = "DealerCard4"
        Me.DealerCard4.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard4.TabIndex = 10
        Me.DealerCard4.TabStop = False
        Me.DealerCard4.Visible = False
        '
        'DealerCard5
        '
        Me.DealerCard5.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard5.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.DealerCard5.Location = New System.Drawing.Point(1436, 23)
        Me.DealerCard5.Name = "DealerCard5"
        Me.DealerCard5.Size = New System.Drawing.Size(151, 223)
        Me.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard5.TabIndex = 12
        Me.DealerCard5.TabStop = False
        Me.DealerCard5.Visible = False
        '
        'UserCard3
        '
        Me.UserCard3.BackColor = System.Drawing.Color.Transparent
        Me.UserCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserCard3.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.UserCard3.Location = New System.Drawing.Point(1089, 735)
        Me.UserCard3.Name = "UserCard3"
        Me.UserCard3.Size = New System.Drawing.Size(212, 301)
        Me.UserCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard3.TabIndex = 14
        Me.UserCard3.TabStop = False
        Me.UserCard3.Visible = False
        '
        'UserCard4
        '
        Me.UserCard4.BackColor = System.Drawing.Color.Transparent
        Me.UserCard4.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.UserCard4.Location = New System.Drawing.Point(1312, 735)
        Me.UserCard4.Name = "UserCard4"
        Me.UserCard4.Size = New System.Drawing.Size(212, 301)
        Me.UserCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard4.TabIndex = 13
        Me.UserCard4.TabStop = False
        Me.UserCard4.Visible = False
        '
        'UserCard5
        '
        Me.UserCard5.BackColor = System.Drawing.Color.Transparent
        Me.UserCard5.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.UserCard5.Location = New System.Drawing.Point(1530, 735)
        Me.UserCard5.Name = "UserCard5"
        Me.UserCard5.Size = New System.Drawing.Size(212, 301)
        Me.UserCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserCard5.TabIndex = 15
        Me.UserCard5.TabStop = False
        Me.UserCard5.Visible = False
        '
        'Player1Card4
        '
        Me.Player1Card4.BackColor = System.Drawing.Color.Transparent
        Me.Player1Card4.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player1Card4.Location = New System.Drawing.Point(478, 215)
        Me.Player1Card4.Name = "Player1Card4"
        Me.Player1Card4.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card4.TabIndex = 19
        Me.Player1Card4.TabStop = False
        Me.Player1Card4.Visible = False
        '
        'Player1Card3
        '
        Me.Player1Card3.BackColor = System.Drawing.Color.Transparent
        Me.Player1Card3.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player1Card3.Location = New System.Drawing.Point(321, 215)
        Me.Player1Card3.Name = "Player1Card3"
        Me.Player1Card3.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card3.TabIndex = 18
        Me.Player1Card3.TabStop = False
        Me.Player1Card3.Visible = False
        '
        'Player2Card4
        '
        Me.Player2Card4.BackColor = System.Drawing.Color.Transparent
        Me.Player2Card4.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player2Card4.Location = New System.Drawing.Point(478, 454)
        Me.Player2Card4.Name = "Player2Card4"
        Me.Player2Card4.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card4.TabIndex = 17
        Me.Player2Card4.TabStop = False
        Me.Player2Card4.Visible = False
        '
        'Player2Card3
        '
        Me.Player2Card3.BackColor = System.Drawing.Color.Transparent
        Me.Player2Card3.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player2Card3.Location = New System.Drawing.Point(321, 454)
        Me.Player2Card3.Name = "Player2Card3"
        Me.Player2Card3.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card3.TabIndex = 16
        Me.Player2Card3.TabStop = False
        Me.Player2Card3.Visible = False
        '
        'Player1Card5
        '
        Me.Player1Card5.BackColor = System.Drawing.Color.Transparent
        Me.Player1Card5.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player1Card5.Location = New System.Drawing.Point(635, 215)
        Me.Player1Card5.Name = "Player1Card5"
        Me.Player1Card5.Size = New System.Drawing.Size(151, 233)
        Me.Player1Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Card5.TabIndex = 21
        Me.Player1Card5.TabStop = False
        Me.Player1Card5.Visible = False
        '
        'Player2Card5
        '
        Me.Player2Card5.BackColor = System.Drawing.Color.Transparent
        Me.Player2Card5.Image = Global.BlaccJacc.My.Resources.Resources.Card_back
        Me.Player2Card5.Location = New System.Drawing.Point(635, 454)
        Me.Player2Card5.Name = "Player2Card5"
        Me.Player2Card5.Size = New System.Drawing.Size(151, 233)
        Me.Player2Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Card5.TabIndex = 20
        Me.Player2Card5.TabStop = False
        Me.Player2Card5.Visible = False
        '
        'PayIn
        '
        Me.PayIn.AutoSize = False
        Me.PayIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PayIn.LargeChange = 10
        Me.PayIn.Location = New System.Drawing.Point(645, 426)
        Me.PayIn.Maximum = 100
        Me.PayIn.Name = "PayIn"
        Me.PayIn.Size = New System.Drawing.Size(664, 39)
        Me.PayIn.SmallChange = 5
        Me.PayIn.TabIndex = 22
        Me.PayIn.TickFrequency = 10
        Me.PayIn.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'PayInNum
        '
        Me.PayInNum.AutoSize = True
        Me.PayInNum.BackColor = System.Drawing.Color.Transparent
        Me.PayInNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayInNum.ForeColor = System.Drawing.Color.Gold
        Me.PayInNum.Location = New System.Drawing.Point(859, 399)
        Me.PayInNum.Name = "PayInNum"
        Me.PayInNum.Size = New System.Drawing.Size(105, 24)
        Me.PayInNum.TabIndex = 23
        Me.PayInNum.Text = "Bet amount"
        '
        'PlaceBet
        '
        Me.PlaceBet.BackColor = System.Drawing.Color.Transparent
        Me.PlaceBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlaceBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceBet.ForeColor = System.Drawing.Color.Gold
        Me.PlaceBet.Location = New System.Drawing.Point(909, 471)
        Me.PlaceBet.Name = "PlaceBet"
        Me.PlaceBet.Size = New System.Drawing.Size(135, 59)
        Me.PlaceBet.TabIndex = 24
        Me.PlaceBet.Text = "Place your bet"
        Me.PlaceBet.UseVisualStyleBackColor = False
        '
        'BtnHit
        '
        Me.BtnHit.BackColor = System.Drawing.Color.Transparent
        Me.BtnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHit.ForeColor = System.Drawing.Color.Gold
        Me.BtnHit.Location = New System.Drawing.Point(883, 490)
        Me.BtnHit.Name = "BtnHit"
        Me.BtnHit.Size = New System.Drawing.Size(174, 87)
        Me.BtnHit.TabIndex = 25
        Me.BtnHit.Text = "Hit!"
        Me.BtnHit.UseVisualStyleBackColor = False
        Me.BtnHit.Visible = False
        '
        'BtnStand
        '
        Me.BtnStand.BackColor = System.Drawing.Color.Transparent
        Me.BtnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStand.ForeColor = System.Drawing.Color.Gold
        Me.BtnStand.Location = New System.Drawing.Point(1099, 490)
        Me.BtnStand.Name = "BtnStand"
        Me.BtnStand.Size = New System.Drawing.Size(174, 87)
        Me.BtnStand.TabIndex = 26
        Me.BtnStand.Text = "Stand!"
        Me.BtnStand.UseVisualStyleBackColor = False
        Me.BtnStand.Visible = False
        '
        'Game_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.BtnStand)
        Me.Controls.Add(Me.BtnHit)
        Me.Controls.Add(Me.PlaceBet)
        Me.Controls.Add(Me.PayInNum)
        Me.Controls.Add(Me.PayIn)
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
        Me.Controls.Add(Me.PileOfCards)
        Me.Controls.Add(Me.CmdQuit)
        Me.MaximizeBox = False
        Me.Name = "Game_Form"
        Me.Text = "Game_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PileOfCards, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PayIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdQuit As Button
    Friend WithEvents PileOfCards As PictureBox
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
    Friend WithEvents PayIn As TrackBar
    Friend WithEvents PayInNum As Label
    Friend WithEvents PlaceBet As Button
    Friend WithEvents BtnHit As Button
    Friend WithEvents BtnStand As Button
End Class
