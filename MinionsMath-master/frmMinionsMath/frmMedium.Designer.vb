<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedium
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
        Me.components = New System.ComponentModel.Container()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Numerator = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Answer = New System.Windows.Forms.Button()
        Me.AnsDen = New System.Windows.Forms.TextBox()
        Me.AnsNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Denominator = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.picBanana6 = New System.Windows.Forms.PictureBox()
        Me.picBanana2 = New System.Windows.Forms.PictureBox()
        Me.picBanana3 = New System.Windows.Forms.PictureBox()
        Me.picBanana4 = New System.Windows.Forms.PictureBox()
        Me.picBanana5 = New System.Windows.Forms.PictureBox()
        Me.picBanana7 = New System.Windows.Forms.PictureBox()
        Me.picBanana8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picBanana1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picBanana6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanana2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanana3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanana4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanana5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanana7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanana8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanana1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.White
        Me.btnQuit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(715, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(173, 46)
        Me.btnQuit.TabIndex = 28
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerScore.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.Location = New System.Drawing.Point(96, 45)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(20, 23)
        Me.lblPlayerScore.TabIndex = 27
        Me.lblPlayerScore.Text = "0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(9, 45)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(81, 23)
        Me.lblScore.TabIndex = 26
        Me.lblScore.Text = "Bananas:"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(80, 13)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(55, 23)
        Me.lblPlayerName.TabIndex = 25
        Me.lblPlayerName.Text = "Name"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(9, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 23)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Numerator)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Answer)
        Me.Panel1.Controls.Add(Me.AnsDen)
        Me.Panel1.Controls.Add(Me.AnsNum)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Denominator)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(9, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 144)
        Me.Panel1.TabIndex = 23
        '
        'Numerator
        '
        Me.Numerator.AutoSize = True
        Me.Numerator.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numerator.Location = New System.Drawing.Point(39, 53)
        Me.Numerator.Name = "Numerator"
        Me.Numerator.Size = New System.Drawing.Size(36, 25)
        Me.Numerator.TabIndex = 14
        Me.Numerator.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "___"
        '
        'Answer
        '
        Me.Answer.Location = New System.Drawing.Point(199, 71)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(75, 23)
        Me.Answer.TabIndex = 21
        Me.Answer.Text = "Answer"
        Me.Answer.UseVisualStyleBackColor = True
        '
        'AnsDen
        '
        Me.AnsDen.Location = New System.Drawing.Point(112, 91)
        Me.AnsDen.Name = "AnsDen"
        Me.AnsDen.Size = New System.Drawing.Size(31, 20)
        Me.AnsDen.TabIndex = 18
        '
        'AnsNum
        '
        Me.AnsNum.Location = New System.Drawing.Point(112, 53)
        Me.AnsNum.Name = "AnsNum"
        Me.AnsNum.Size = New System.Drawing.Size(31, 20)
        Me.AnsNum.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "="
        '
        'Denominator
        '
        Me.Denominator.AutoSize = True
        Me.Denominator.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Denominator.Location = New System.Drawing.Point(39, 86)
        Me.Denominator.Name = "Denominator"
        Me.Denominator.Size = New System.Drawing.Size(36, 25)
        Me.Denominator.TabIndex = 15
        Me.Denominator.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Write the Equivalent Fraction"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "___"
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 10
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 10
        '
        'picBanana6
        '
        Me.picBanana6.BackColor = System.Drawing.Color.Transparent
        Me.picBanana6.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana6.Location = New System.Drawing.Point(3000, 566)
        Me.picBanana6.Name = "picBanana6"
        Me.picBanana6.Size = New System.Drawing.Size(79, 44)
        Me.picBanana6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana6.TabIndex = 35
        Me.picBanana6.TabStop = False
        '
        'picBanana2
        '
        Me.picBanana2.BackColor = System.Drawing.Color.Transparent
        Me.picBanana2.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana2.Location = New System.Drawing.Point(1000, 566)
        Me.picBanana2.Name = "picBanana2"
        Me.picBanana2.Size = New System.Drawing.Size(79, 44)
        Me.picBanana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana2.TabIndex = 34
        Me.picBanana2.TabStop = False
        '
        'picBanana3
        '
        Me.picBanana3.BackColor = System.Drawing.Color.Transparent
        Me.picBanana3.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana3.Location = New System.Drawing.Point(1500, 566)
        Me.picBanana3.Name = "picBanana3"
        Me.picBanana3.Size = New System.Drawing.Size(79, 44)
        Me.picBanana3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana3.TabIndex = 33
        Me.picBanana3.TabStop = False
        '
        'picBanana4
        '
        Me.picBanana4.BackColor = System.Drawing.Color.Transparent
        Me.picBanana4.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana4.Location = New System.Drawing.Point(2000, 566)
        Me.picBanana4.Name = "picBanana4"
        Me.picBanana4.Size = New System.Drawing.Size(79, 44)
        Me.picBanana4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana4.TabIndex = 32
        Me.picBanana4.TabStop = False
        '
        'picBanana5
        '
        Me.picBanana5.BackColor = System.Drawing.Color.Transparent
        Me.picBanana5.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana5.Location = New System.Drawing.Point(2500, 566)
        Me.picBanana5.Name = "picBanana5"
        Me.picBanana5.Size = New System.Drawing.Size(79, 44)
        Me.picBanana5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana5.TabIndex = 31
        Me.picBanana5.TabStop = False
        '
        'picBanana7
        '
        Me.picBanana7.BackColor = System.Drawing.Color.Transparent
        Me.picBanana7.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana7.Location = New System.Drawing.Point(3500, 566)
        Me.picBanana7.Name = "picBanana7"
        Me.picBanana7.Size = New System.Drawing.Size(79, 44)
        Me.picBanana7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana7.TabIndex = 30
        Me.picBanana7.TabStop = False
        '
        'picBanana8
        '
        Me.picBanana8.BackColor = System.Drawing.Color.Transparent
        Me.picBanana8.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana8.Location = New System.Drawing.Point(4000, 566)
        Me.picBanana8.Name = "picBanana8"
        Me.picBanana8.Size = New System.Drawing.Size(79, 44)
        Me.picBanana8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana8.TabIndex = 29
        Me.picBanana8.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.frmMinionsMath.My.Resources.Resources.MinionStill
        Me.PictureBox3.Location = New System.Drawing.Point(28, 460)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(114, 153)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'picBanana1
        '
        Me.picBanana1.BackColor = System.Drawing.Color.Transparent
        Me.picBanana1.Image = Global.frmMinionsMath.My.Resources.Resources.banana
        Me.picBanana1.Location = New System.Drawing.Point(497, 566)
        Me.picBanana1.Name = "picBanana1"
        Me.picBanana1.Size = New System.Drawing.Size(79, 44)
        Me.picBanana1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanana1.TabIndex = 21
        Me.picBanana1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.frmMinionsMath.My.Resources.Resources.Minion_Walk
        Me.PictureBox2.Location = New System.Drawing.Point(28, 460)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 153)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'frmMedium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(897, 625)
        Me.Controls.Add(Me.picBanana6)
        Me.Controls.Add(Me.picBanana2)
        Me.Controls.Add(Me.picBanana3)
        Me.Controls.Add(Me.picBanana4)
        Me.Controls.Add(Me.picBanana5)
        Me.Controls.Add(Me.picBanana7)
        Me.Controls.Add(Me.picBanana8)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.picBanana1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmMedium"
        Me.Text = "frmMedium"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBanana6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanana2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanana3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanana4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanana5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanana7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanana8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanana1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents picBanana1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picBanana8 As PictureBox
    Friend WithEvents picBanana7 As PictureBox
    Friend WithEvents picBanana5 As PictureBox
    Friend WithEvents picBanana4 As PictureBox
    Friend WithEvents picBanana3 As PictureBox
    Friend WithEvents picBanana2 As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents picBanana6 As PictureBox
    Friend WithEvents Numerator As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Answer As Button
    Friend WithEvents AnsDen As TextBox
    Friend WithEvents AnsNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Denominator As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class
