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
        Me.plane0 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Handoff_dep = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.takeoff = New System.Windows.Forms.Button()
        Me.Hold_short_of_runway = New System.Windows.Forms.Button()
        Me.Line_up_and_wait = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.plane4 = New System.Windows.Forms.Label()
        Me.plane1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.show_text = New System.Windows.Forms.Timer(Me.components)
        Me.demo = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.continue_approach = New System.Windows.Forms.Button()
        Me.go_around = New System.Windows.Forms.Button()
        Me.cleared_to_land = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(386, 315)
        Me.Start.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(173, 68)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'plane0
        '
        Me.plane0.AutoSize = True
        Me.plane0.BackColor = System.Drawing.Color.Transparent
        Me.plane0.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane0.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane0.Location = New System.Drawing.Point(100, 500)
        Me.plane0.Margin = New System.Windows.Forms.Padding(0)
        Me.plane0.Name = "plane0"
        Me.plane0.Size = New System.Drawing.Size(68, 15)
        Me.plane0.TabIndex = 1
        Me.plane0.Text = "● plane0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Handoff_dep)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.takeoff)
        Me.Panel1.Controls.Add(Me.Hold_short_of_runway)
        Me.Panel1.Controls.Add(Me.Line_up_and_wait)
        Me.Panel1.Location = New System.Drawing.Point(442, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 312)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'Handoff_dep
        '
        Me.Handoff_dep.Location = New System.Drawing.Point(155, 208)
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
        Me.TextBox1.Location = New System.Drawing.Point(40, 35)
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
        Me.takeoff.Location = New System.Drawing.Point(155, 158)
        Me.takeoff.Name = "takeoff"
        Me.takeoff.Size = New System.Drawing.Size(155, 48)
        Me.takeoff.TabIndex = 3
        Me.takeoff.Text = "離陸許可"
        Me.takeoff.UseVisualStyleBackColor = True
        Me.takeoff.Visible = False
        '
        'Hold_short_of_runway
        '
        Me.Hold_short_of_runway.Location = New System.Drawing.Point(155, 263)
        Me.Hold_short_of_runway.Name = "Hold_short_of_runway"
        Me.Hold_short_of_runway.Size = New System.Drawing.Size(155, 46)
        Me.Hold_short_of_runway.TabIndex = 2
        Me.Hold_short_of_runway.Text = "滑走路前待機"
        Me.Hold_short_of_runway.UseVisualStyleBackColor = True
        Me.Hold_short_of_runway.Visible = False
        '
        'Line_up_and_wait
        '
        Me.Line_up_and_wait.Location = New System.Drawing.Point(155, 212)
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
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(948, 467)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'plane4
        '
        Me.plane4.AutoSize = True
        Me.plane4.BackColor = System.Drawing.Color.Transparent
        Me.plane4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane4.Location = New System.Drawing.Point(30, 158)
        Me.plane4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.plane4.Name = "plane4"
        Me.plane4.Size = New System.Drawing.Size(68, 15)
        Me.plane4.TabIndex = 4
        Me.plane4.Text = "● plane4"
        '
        'plane1
        '
        Me.plane1.AutoSize = True
        Me.plane1.BackColor = System.Drawing.Color.Transparent
        Me.plane1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane1.Location = New System.Drawing.Point(100, 550)
        Me.plane1.Margin = New System.Windows.Forms.Padding(0)
        Me.plane1.Name = "plane1"
        Me.plane1.Size = New System.Drawing.Size(68, 15)
        Me.plane1.TabIndex = 5
        Me.plane1.Text = "● plane1"
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
        Me.Label4.Location = New System.Drawing.Point(514, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 64)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ゲーム説明" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Startボタンを押すとゲーム開始" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "各planeを押すと場合に応じた指示が出せる" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'show_text
        '
        '
        'demo
        '
        Me.demo.AutoSize = True
        Me.demo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.demo.Location = New System.Drawing.Point(187, 158)
        Me.demo.Name = "demo"
        Me.demo.Size = New System.Drawing.Size(22, 15)
        Me.demo.TabIndex = 8
        Me.demo.Text = "●"
        '
        'Timer4
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.continue_approach)
        Me.Panel2.Controls.Add(Me.go_around)
        Me.Panel2.Controls.Add(Me.cleared_to_land)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(442, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 312)
        Me.Panel2.TabIndex = 9
        Me.Panel2.Visible = False
        '
        'continue_approach
        '
        Me.continue_approach.Location = New System.Drawing.Point(155, 263)
        Me.continue_approach.Name = "continue_approach"
        Me.continue_approach.Size = New System.Drawing.Size(129, 46)
        Me.continue_approach.TabIndex = 4
        Me.continue_approach.Text = "進入継続"
        Me.continue_approach.UseVisualStyleBackColor = True
        Me.continue_approach.Visible = False
        '
        'go_around
        '
        Me.go_around.Location = New System.Drawing.Point(155, 212)
        Me.go_around.Name = "go_around"
        Me.go_around.Size = New System.Drawing.Size(129, 46)
        Me.go_around.TabIndex = 3
        Me.go_around.Text = "着陸復行"
        Me.go_around.UseVisualStyleBackColor = True
        Me.go_around.Visible = False
        '
        'cleared_to_land
        '
        Me.cleared_to_land.Location = New System.Drawing.Point(155, 158)
        Me.cleared_to_land.Name = "cleared_to_land"
        Me.cleared_to_land.Size = New System.Drawing.Size(129, 48)
        Me.cleared_to_land.TabIndex = 2
        Me.cleared_to_land.Text = "着陸許可"
        Me.cleared_to_land.UseVisualStyleBackColor = True
        Me.cleared_to_land.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(26, 35)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(404, 117)
        Me.TextBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'Timer5
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 467)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.demo)
        Me.Controls.Add(Me.plane4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.plane1)
        Me.Controls.Add(Me.plane0)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start As Button
    Friend WithEvents plane0 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents takeoff As Button
    Friend WithEvents Hold_short_of_runway As Button
    Friend WithEvents Line_up_and_wait As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents plane4 As Label
    Friend WithEvents plane1 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Handoff_dep As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents show_text As Timer
    Friend WithEvents demo As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents continue_approach As Button
    Friend WithEvents go_around As Button
    Friend WithEvents cleared_to_land As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer5 As Timer
End Class
