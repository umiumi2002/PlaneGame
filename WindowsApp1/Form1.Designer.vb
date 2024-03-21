<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Start = New System.Windows.Forms.Button()
        Me.plane1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Handoff_dep = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.takeoff = New System.Windows.Forms.Button()
        Me.Hold_short_of_runway = New System.Windows.Forms.Button()
        Me.Line_up_and_wait = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(443, 356)
        Me.Start.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(173, 68)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'plane1
        '
        Me.plane1.AutoSize = True
        Me.plane1.BackColor = System.Drawing.Color.Transparent
        Me.plane1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane1.Location = New System.Drawing.Point(124, 531)
        Me.plane1.Margin = New System.Windows.Forms.Padding(0)
        Me.plane1.Name = "plane1"
        Me.plane1.Size = New System.Drawing.Size(68, 15)
        Me.plane1.TabIndex = 1
        Me.plane1.Text = "● plane1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Handoff_dep)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.takeoff)
        Me.Panel1.Controls.Add(Me.Hold_short_of_runway)
        Me.Panel1.Controls.Add(Me.Line_up_and_wait)
        Me.Panel1.Location = New System.Drawing.Point(523, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 347)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'Handoff_dep
        '
        Me.Handoff_dep.Location = New System.Drawing.Point(171, 220)
        Me.Handoff_dep.Name = "Handoff_dep"
        Me.Handoff_dep.Size = New System.Drawing.Size(155, 50)
        Me.Handoff_dep.TabIndex = 6
        Me.Handoff_dep.Text = "DEPハンドオフ"
        Me.Handoff_dep.UseVisualStyleBackColor = True
        Me.Handoff_dep.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(61, 47)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(392, 117)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'takeoff
        '
        Me.takeoff.Location = New System.Drawing.Point(171, 170)
        Me.takeoff.Name = "takeoff"
        Me.takeoff.Size = New System.Drawing.Size(155, 48)
        Me.takeoff.TabIndex = 3
        Me.takeoff.Text = "離陸許可"
        Me.takeoff.UseVisualStyleBackColor = True
        Me.takeoff.Visible = False
        '
        'Hold_short_of_runway
        '
        Me.Hold_short_of_runway.Location = New System.Drawing.Point(171, 276)
        Me.Hold_short_of_runway.Name = "Hold_short_of_runway"
        Me.Hold_short_of_runway.Size = New System.Drawing.Size(155, 46)
        Me.Hold_short_of_runway.TabIndex = 2
        Me.Hold_short_of_runway.Text = "滑走路前待機"
        Me.Hold_short_of_runway.UseVisualStyleBackColor = True
        Me.Hold_short_of_runway.Visible = False
        '
        'Line_up_and_wait
        '
        Me.Line_up_and_wait.Location = New System.Drawing.Point(171, 224)
        Me.Line_up_and_wait.Name = "Line_up_and_wait"
        Me.Line_up_and_wait.Size = New System.Drawing.Size(155, 46)
        Me.Line_up_and_wait.TabIndex = 1
        Me.Line_up_and_wait.Text = "滑走路内待機"
        Me.Line_up_and_wait.UseVisualStyleBackColor = True
        Me.Line_up_and_wait.Visible = False
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1030, 669)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(958, 431)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "●"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(923, 393)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "●"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(625, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 64)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ゲーム説明" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Startボタンを押すとゲーム開始" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "各planeを押すと場合に応じた指示が出せる" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 666)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.plane1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start As Button
    Friend WithEvents plane1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents takeoff As Button
    Friend WithEvents Hold_short_of_runway As Button
    Friend WithEvents Line_up_and_wait As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Handoff_dep As Button
    Friend WithEvents Label4 As Label
End Class
