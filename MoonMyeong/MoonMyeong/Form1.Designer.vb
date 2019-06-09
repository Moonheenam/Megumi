<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Love = New System.Windows.Forms.PictureBox()
        Me.flower1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.flower2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.flower3 = New System.Windows.Forms.PictureBox()
        CType(Me.Love, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flower1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flower2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flower3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Love
        '
        Me.Love.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Love.Image = CType(resources.GetObject("Love.Image"), System.Drawing.Image)
        Me.Love.Location = New System.Drawing.Point(88, 107)
        Me.Love.Name = "Love"
        Me.Love.Size = New System.Drawing.Size(353, 464)
        Me.Love.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Love.TabIndex = 0
        Me.Love.TabStop = False
        '
        'flower1
        '
        Me.flower1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.flower1.Image = CType(resources.GetObject("flower1.Image"), System.Drawing.Image)
        Me.flower1.Location = New System.Drawing.Point(503, 131)
        Me.flower1.Name = "flower1"
        Me.flower1.Size = New System.Drawing.Size(96, 101)
        Me.flower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.flower1.TabIndex = 1
        Me.flower1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(605, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 101)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(605, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 101)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'flower2
        '
        Me.flower2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.flower2.Image = CType(resources.GetObject("flower2.Image"), System.Drawing.Image)
        Me.flower2.Location = New System.Drawing.Point(503, 277)
        Me.flower2.Name = "flower2"
        Me.flower2.Size = New System.Drawing.Size(96, 101)
        Me.flower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.flower2.TabIndex = 3
        Me.flower2.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(605, 423)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(211, 101)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'flower3
        '
        Me.flower3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.flower3.Image = CType(resources.GetObject("flower3.Image"), System.Drawing.Image)
        Me.flower3.Location = New System.Drawing.Point(503, 423)
        Me.flower3.Name = "flower3"
        Me.flower3.Size = New System.Drawing.Size(96, 101)
        Me.flower3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.flower3.TabIndex = 5
        Me.flower3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(873, 572)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.flower3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.flower2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.flower1)
        Me.Controls.Add(Me.Love)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Love, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flower1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flower2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flower3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Love As PictureBox
    Friend WithEvents flower1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents flower2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents flower3 As PictureBox
End Class
