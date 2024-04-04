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
        Me.Panel0 = New System.Windows.Forms.Panel()
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.Handoff_dep = New System.Windows.Forms.Button()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.takeoff = New System.Windows.Forms.Button()
        Me.Hold_short_of_runway = New System.Windows.Forms.Button()
        Me.Line_up_and_wait = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.plane4 = New System.Windows.Forms.Label()
        Me.plane1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.explain = New System.Windows.Forms.Label()
        Me.show_text = New System.Windows.Forms.Timer(Me.components)
        Me.demo = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Handoff_gnd = New System.Windows.Forms.Button()
        Me.continue_approach = New System.Windows.Forms.Button()
        Me.go_around = New System.Windows.Forms.Button()
        Me.cleared_to_land = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Handoff_gnd_5 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.go_around_5 = New System.Windows.Forms.Button()
        Me.cleared_to_land_5 = New System.Windows.Forms.Button()
        Me.continue_approach_5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Handoff_gnd_6 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cleared_to_land_6 = New System.Windows.Forms.Button()
        Me.continue_approach_6 = New System.Windows.Forms.Button()
        Me.go_around_6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Handoff_dep_1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hold_short_of_runway_1 = New System.Windows.Forms.Button()
        Me.takeoff_1 = New System.Windows.Forms.Button()
        Me.Line_up_and_wait_1 = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.show_text_1 = New System.Windows.Forms.Timer(Me.components)
        Me.show_text_4 = New System.Windows.Forms.Timer(Me.components)
        Me.plane5 = New System.Windows.Forms.Label()
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.show_text_5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        Me.plane6 = New System.Windows.Forms.Label()
        Me.Timer13 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer14 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer15 = New System.Windows.Forms.Timer(Me.components)
        Me.show_text_6 = New System.Windows.Forms.Timer(Me.components)
        Me.plane2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Handoff_dep_2 = New System.Windows.Forms.Button()
        Me.takeoff_2 = New System.Windows.Forms.Button()
        Me.Line_up_and_wait_2 = New System.Windows.Forms.Button()
        Me.Hold_short_of_runway_2 = New System.Windows.Forms.Button()
        Me.Timer16 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer17 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer18 = New System.Windows.Forms.Timer(Me.components)
        Me.show_text_2 = New System.Windows.Forms.Timer(Me.components)
        Me.gameStart = New System.Windows.Forms.Timer(Me.components)
        Me.LabelElapsedTime = New System.Windows.Forms.Label()
        Me.plane_hide_ = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.TextBox()
        Me.point_ = New System.Windows.Forms.Label()
        Me.Panel0.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(535, 379)
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
        Me.plane0.Location = New System.Drawing.Point(150, 500)
        Me.plane0.Margin = New System.Windows.Forms.Padding(0)
        Me.plane0.Name = "plane0"
        Me.plane0.Size = New System.Drawing.Size(69, 44)
        Me.plane0.TabIndex = 1
        Me.plane0.Text = "● " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plane0"
        '
        'Panel0
        '
        Me.Panel0.Controls.Add(Me.TextBox0)
        Me.Panel0.Controls.Add(Me.Handoff_dep)
        Me.Panel0.Controls.Add(Me.Label0)
        Me.Panel0.Controls.Add(Me.takeoff)
        Me.Panel0.Controls.Add(Me.Hold_short_of_runway)
        Me.Panel0.Controls.Add(Me.Line_up_and_wait)
        Me.Panel0.Location = New System.Drawing.Point(730, 27)
        Me.Panel0.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel0.Name = "Panel0"
        Me.Panel0.Size = New System.Drawing.Size(465, 329)
        Me.Panel0.TabIndex = 2
        Me.Panel0.Visible = False
        '
        'TextBox0
        '
        Me.TextBox0.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox0.Location = New System.Drawing.Point(22, 51)
        Me.TextBox0.Multiline = True
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(420, 114)
        Me.TextBox0.TabIndex = 5
        '
        'Handoff_dep
        '
        Me.Handoff_dep.Location = New System.Drawing.Point(178, 223)
        Me.Handoff_dep.Name = "Handoff_dep"
        Me.Handoff_dep.Size = New System.Drawing.Size(155, 50)
        Me.Handoff_dep.TabIndex = 6
        Me.Handoff_dep.Text = "DEPハンドオフ"
        Me.Handoff_dep.UseVisualStyleBackColor = True
        Me.Handoff_dep.Visible = False
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label0.Location = New System.Drawing.Point(18, 17)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(73, 23)
        Me.Label0.TabIndex = 4
        Me.Label0.Text = "Label0"
        '
        'takeoff
        '
        Me.takeoff.Location = New System.Drawing.Point(178, 171)
        Me.takeoff.Name = "takeoff"
        Me.takeoff.Size = New System.Drawing.Size(155, 48)
        Me.takeoff.TabIndex = 3
        Me.takeoff.Text = "離陸許可"
        Me.takeoff.UseVisualStyleBackColor = True
        Me.takeoff.Visible = False
        '
        'Hold_short_of_runway
        '
        Me.Hold_short_of_runway.Location = New System.Drawing.Point(178, 279)
        Me.Hold_short_of_runway.Name = "Hold_short_of_runway"
        Me.Hold_short_of_runway.Size = New System.Drawing.Size(155, 46)
        Me.Hold_short_of_runway.TabIndex = 2
        Me.Hold_short_of_runway.Text = "滑走路前待機"
        Me.Hold_short_of_runway.UseVisualStyleBackColor = True
        Me.Hold_short_of_runway.Visible = False
        '
        'Line_up_and_wait
        '
        Me.Line_up_and_wait.Location = New System.Drawing.Point(178, 225)
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
        'plane4
        '
        Me.plane4.AutoSize = True
        Me.plane4.BackColor = System.Drawing.Color.Transparent
        Me.plane4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane4.Location = New System.Drawing.Point(230, 175)
        Me.plane4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.plane4.Name = "plane4"
        Me.plane4.Size = New System.Drawing.Size(69, 44)
        Me.plane4.TabIndex = 4
        Me.plane4.Text = "● " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plane4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'plane1
        '
        Me.plane1.AutoSize = True
        Me.plane1.BackColor = System.Drawing.Color.Transparent
        Me.plane1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane1.Location = New System.Drawing.Point(150, 560)
        Me.plane1.Margin = New System.Windows.Forms.Padding(0)
        Me.plane1.Name = "plane1"
        Me.plane1.Size = New System.Drawing.Size(69, 44)
        Me.plane1.TabIndex = 5
        Me.plane1.Text = "● " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plane1"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'explain
        '
        Me.explain.AutoSize = True
        Me.explain.BackColor = System.Drawing.Color.Green
        Me.explain.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.explain.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.explain.Location = New System.Drawing.Point(849, 158)
        Me.explain.Name = "explain"
        Me.explain.Size = New System.Drawing.Size(420, 96)
        Me.explain.TabIndex = 7
        Me.explain.Text = "ゲーム説明" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Startボタンを押すとゲーム開始" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "各planeを押すと場合に応じた指示が出せる" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'show_text
        '
        '
        'demo
        '
        Me.demo.AutoSize = True
        Me.demo.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.demo.Location = New System.Drawing.Point(680, 175)
        Me.demo.Name = "demo"
        Me.demo.Size = New System.Drawing.Size(33, 23)
        Me.demo.TabIndex = 8
        Me.demo.Text = "●"
        '
        'Timer4
        '
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Handoff_gnd)
        Me.Panel4.Controls.Add(Me.continue_approach)
        Me.Panel4.Controls.Add(Me.go_around)
        Me.Panel4.Controls.Add(Me.cleared_to_land)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(727, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(465, 329)
        Me.Panel4.TabIndex = 9
        Me.Panel4.Visible = False
        '
        'Handoff_gnd
        '
        Me.Handoff_gnd.Location = New System.Drawing.Point(167, 225)
        Me.Handoff_gnd.Name = "Handoff_gnd"
        Me.Handoff_gnd.Size = New System.Drawing.Size(155, 45)
        Me.Handoff_gnd.TabIndex = 5
        Me.Handoff_gnd.Text = "GNDハンドオフ"
        Me.Handoff_gnd.UseVisualStyleBackColor = True
        Me.Handoff_gnd.Visible = False
        '
        'continue_approach
        '
        Me.continue_approach.Location = New System.Drawing.Point(167, 276)
        Me.continue_approach.Name = "continue_approach"
        Me.continue_approach.Size = New System.Drawing.Size(155, 46)
        Me.continue_approach.TabIndex = 4
        Me.continue_approach.Text = "進入継続"
        Me.continue_approach.UseVisualStyleBackColor = True
        Me.continue_approach.Visible = False
        '
        'go_around
        '
        Me.go_around.Location = New System.Drawing.Point(167, 227)
        Me.go_around.Name = "go_around"
        Me.go_around.Size = New System.Drawing.Size(155, 46)
        Me.go_around.TabIndex = 3
        Me.go_around.Text = "着陸復行"
        Me.go_around.UseVisualStyleBackColor = True
        Me.go_around.Visible = False
        '
        'cleared_to_land
        '
        Me.cleared_to_land.Location = New System.Drawing.Point(167, 171)
        Me.cleared_to_land.Name = "cleared_to_land"
        Me.cleared_to_land.Size = New System.Drawing.Size(155, 48)
        Me.cleared_to_land.TabIndex = 2
        Me.cleared_to_land.Text = "着陸許可"
        Me.cleared_to_land.UseVisualStyleBackColor = True
        Me.cleared_to_land.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(28, 51)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(404, 114)
        Me.TextBox4.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Handoff_gnd_5)
        Me.Panel5.Controls.Add(Me.TextBox5)
        Me.Panel5.Controls.Add(Me.go_around_5)
        Me.Panel5.Controls.Add(Me.cleared_to_land_5)
        Me.Panel5.Controls.Add(Me.continue_approach_5)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(721, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(465, 329)
        Me.Panel5.TabIndex = 12
        Me.Panel5.Visible = False
        '
        'Handoff_gnd_5
        '
        Me.Handoff_gnd_5.Location = New System.Drawing.Point(135, 229)
        Me.Handoff_gnd_5.Name = "Handoff_gnd_5"
        Me.Handoff_gnd_5.Size = New System.Drawing.Size(174, 46)
        Me.Handoff_gnd_5.TabIndex = 5
        Me.Handoff_gnd_5.Text = "GNDハンドオフ"
        Me.Handoff_gnd_5.UseVisualStyleBackColor = True
        Me.Handoff_gnd_5.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(28, 51)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(422, 114)
        Me.TextBox5.TabIndex = 4
        '
        'go_around_5
        '
        Me.go_around_5.Location = New System.Drawing.Point(135, 279)
        Me.go_around_5.Name = "go_around_5"
        Me.go_around_5.Size = New System.Drawing.Size(174, 43)
        Me.go_around_5.TabIndex = 3
        Me.go_around_5.Text = "着陸復行"
        Me.go_around_5.UseVisualStyleBackColor = True
        Me.go_around_5.Visible = False
        '
        'cleared_to_land_5
        '
        Me.cleared_to_land_5.Location = New System.Drawing.Point(135, 228)
        Me.cleared_to_land_5.Name = "cleared_to_land_5"
        Me.cleared_to_land_5.Size = New System.Drawing.Size(174, 47)
        Me.cleared_to_land_5.TabIndex = 2
        Me.cleared_to_land_5.Text = "着陸許可"
        Me.cleared_to_land_5.UseVisualStyleBackColor = True
        Me.cleared_to_land_5.Visible = False
        '
        'continue_approach_5
        '
        Me.continue_approach_5.Location = New System.Drawing.Point(135, 176)
        Me.continue_approach_5.Name = "continue_approach_5"
        Me.continue_approach_5.Size = New System.Drawing.Size(174, 48)
        Me.continue_approach_5.TabIndex = 1
        Me.continue_approach_5.Text = "進入継続"
        Me.continue_approach_5.UseVisualStyleBackColor = True
        Me.continue_approach_5.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Label5"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Handoff_gnd_6)
        Me.Panel6.Controls.Add(Me.TextBox6)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.cleared_to_land_6)
        Me.Panel6.Controls.Add(Me.continue_approach_6)
        Me.Panel6.Controls.Add(Me.go_around_6)
        Me.Panel6.Location = New System.Drawing.Point(730, 21)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(462, 329)
        Me.Panel6.TabIndex = 13
        Me.Panel6.Visible = False
        '
        'Handoff_gnd_6
        '
        Me.Handoff_gnd_6.Location = New System.Drawing.Point(151, 227)
        Me.Handoff_gnd_6.Name = "Handoff_gnd_6"
        Me.Handoff_gnd_6.Size = New System.Drawing.Size(160, 43)
        Me.Handoff_gnd_6.TabIndex = 5
        Me.Handoff_gnd_6.Text = "GNDハンドオフ"
        Me.Handoff_gnd_6.UseVisualStyleBackColor = True
        Me.Handoff_gnd_6.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(35, 51)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(395, 114)
        Me.TextBox6.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Label6"
        '
        'cleared_to_land_6
        '
        Me.cleared_to_land_6.Location = New System.Drawing.Point(151, 279)
        Me.cleared_to_land_6.Name = "cleared_to_land_6"
        Me.cleared_to_land_6.Size = New System.Drawing.Size(160, 40)
        Me.cleared_to_land_6.TabIndex = 2
        Me.cleared_to_land_6.Text = "着陸許可"
        Me.cleared_to_land_6.UseVisualStyleBackColor = True
        Me.cleared_to_land_6.Visible = False
        '
        'continue_approach_6
        '
        Me.continue_approach_6.Location = New System.Drawing.Point(151, 229)
        Me.continue_approach_6.Name = "continue_approach_6"
        Me.continue_approach_6.Size = New System.Drawing.Size(160, 44)
        Me.continue_approach_6.TabIndex = 1
        Me.continue_approach_6.Text = "進入継続"
        Me.continue_approach_6.UseVisualStyleBackColor = True
        Me.continue_approach_6.Visible = False
        '
        'go_around_6
        '
        Me.go_around_6.Location = New System.Drawing.Point(151, 171)
        Me.go_around_6.Name = "go_around_6"
        Me.go_around_6.Size = New System.Drawing.Size(160, 48)
        Me.go_around_6.TabIndex = 0
        Me.go_around_6.Text = "着陸復行"
        Me.go_around_6.UseVisualStyleBackColor = True
        Me.go_around_6.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Handoff_dep_1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Hold_short_of_runway_1)
        Me.Panel1.Controls.Add(Me.takeoff_1)
        Me.Panel1.Controls.Add(Me.Line_up_and_wait_1)
        Me.Panel1.Location = New System.Drawing.Point(724, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 329)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'Handoff_dep_1
        '
        Me.Handoff_dep_1.Location = New System.Drawing.Point(144, 228)
        Me.Handoff_dep_1.Name = "Handoff_dep_1"
        Me.Handoff_dep_1.Size = New System.Drawing.Size(165, 45)
        Me.Handoff_dep_1.TabIndex = 5
        Me.Handoff_dep_1.Text = "ハンドオフDEP"
        Me.Handoff_dep_1.UseVisualStyleBackColor = True
        Me.Handoff_dep_1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(20, 51)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 114)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Hold_short_of_runway_1
        '
        Me.Hold_short_of_runway_1.Location = New System.Drawing.Point(144, 279)
        Me.Hold_short_of_runway_1.Name = "Hold_short_of_runway_1"
        Me.Hold_short_of_runway_1.Size = New System.Drawing.Size(165, 43)
        Me.Hold_short_of_runway_1.TabIndex = 2
        Me.Hold_short_of_runway_1.Text = "滑走路前待機"
        Me.Hold_short_of_runway_1.UseVisualStyleBackColor = True
        Me.Hold_short_of_runway_1.Visible = False
        '
        'takeoff_1
        '
        Me.takeoff_1.Location = New System.Drawing.Point(144, 228)
        Me.takeoff_1.Name = "takeoff_1"
        Me.takeoff_1.Size = New System.Drawing.Size(165, 47)
        Me.takeoff_1.TabIndex = 1
        Me.takeoff_1.Text = "離陸許可"
        Me.takeoff_1.UseVisualStyleBackColor = True
        Me.takeoff_1.Visible = False
        '
        'Line_up_and_wait_1
        '
        Me.Line_up_and_wait_1.Location = New System.Drawing.Point(144, 171)
        Me.Line_up_and_wait_1.Name = "Line_up_and_wait_1"
        Me.Line_up_and_wait_1.Size = New System.Drawing.Size(165, 48)
        Me.Line_up_and_wait_1.TabIndex = 0
        Me.Line_up_and_wait_1.Text = "滑走路内待機"
        Me.Line_up_and_wait_1.UseVisualStyleBackColor = True
        Me.Line_up_and_wait_1.Visible = False
        '
        'Timer5
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1216, 701)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Timer6
        '
        '
        'Timer7
        '
        '
        'Timer8
        '
        '
        'Timer9
        '
        '
        'show_text_1
        '
        '
        'show_text_4
        '
        '
        'plane5
        '
        Me.plane5.AutoSize = True
        Me.plane5.BackColor = System.Drawing.Color.Transparent
        Me.plane5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane5.Location = New System.Drawing.Point(125, 175)
        Me.plane5.Name = "plane5"
        Me.plane5.Size = New System.Drawing.Size(69, 44)
        Me.plane5.TabIndex = 11
        Me.plane5.Text = "●" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plane5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer10
        '
        '
        'show_text_5
        '
        '
        'Timer11
        '
        '
        'Timer12
        '
        '
        'plane6
        '
        Me.plane6.AutoSize = True
        Me.plane6.BackColor = System.Drawing.Color.Transparent
        Me.plane6.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane6.Location = New System.Drawing.Point(20, 175)
        Me.plane6.Name = "plane6"
        Me.plane6.Size = New System.Drawing.Size(69, 44)
        Me.plane6.TabIndex = 12
        Me.plane6.Text = "●" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plane6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer13
        '
        '
        'Timer14
        '
        '
        'Timer15
        '
        '
        'show_text_6
        '
        '
        'plane2
        '
        Me.plane2.AutoSize = True
        Me.plane2.BackColor = System.Drawing.Color.Transparent
        Me.plane2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.plane2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane2.Location = New System.Drawing.Point(150, 620)
        Me.plane2.Name = "plane2"
        Me.plane2.Size = New System.Drawing.Size(69, 44)
        Me.plane2.TabIndex = 14
        Me.plane2.Text = "●" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "plane2"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Handoff_dep_2)
        Me.Panel2.Controls.Add(Me.takeoff_2)
        Me.Panel2.Controls.Add(Me.Line_up_and_wait_2)
        Me.Panel2.Controls.Add(Me.Hold_short_of_runway_2)
        Me.Panel2.Location = New System.Drawing.Point(724, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(471, 329)
        Me.Panel2.TabIndex = 15
        Me.Panel2.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(27, 51)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(419, 114)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Handoff_dep_2
        '
        Me.Handoff_dep_2.Location = New System.Drawing.Point(160, 233)
        Me.Handoff_dep_2.Name = "Handoff_dep_2"
        Me.Handoff_dep_2.Size = New System.Drawing.Size(145, 44)
        Me.Handoff_dep_2.TabIndex = 5
        Me.Handoff_dep_2.Text = "DEPハンドオフ"
        Me.Handoff_dep_2.UseVisualStyleBackColor = True
        Me.Handoff_dep_2.Visible = False
        '
        'takeoff_2
        '
        Me.takeoff_2.Location = New System.Drawing.Point(160, 279)
        Me.takeoff_2.Name = "takeoff_2"
        Me.takeoff_2.Size = New System.Drawing.Size(145, 43)
        Me.takeoff_2.TabIndex = 2
        Me.takeoff_2.Text = "離陸許可"
        Me.takeoff_2.UseVisualStyleBackColor = True
        Me.takeoff_2.Visible = False
        '
        'Line_up_and_wait_2
        '
        Me.Line_up_and_wait_2.Location = New System.Drawing.Point(160, 229)
        Me.Line_up_and_wait_2.Name = "Line_up_and_wait_2"
        Me.Line_up_and_wait_2.Size = New System.Drawing.Size(145, 46)
        Me.Line_up_and_wait_2.TabIndex = 1
        Me.Line_up_and_wait_2.Text = "滑走路内待機"
        Me.Line_up_and_wait_2.UseVisualStyleBackColor = True
        Me.Line_up_and_wait_2.Visible = False
        '
        'Hold_short_of_runway_2
        '
        Me.Hold_short_of_runway_2.Location = New System.Drawing.Point(160, 176)
        Me.Hold_short_of_runway_2.Name = "Hold_short_of_runway_2"
        Me.Hold_short_of_runway_2.Size = New System.Drawing.Size(145, 48)
        Me.Hold_short_of_runway_2.TabIndex = 0
        Me.Hold_short_of_runway_2.Text = "滑走路前待機"
        Me.Hold_short_of_runway_2.UseVisualStyleBackColor = True
        Me.Hold_short_of_runway_2.Visible = False
        '
        'Timer16
        '
        '
        'Timer17
        '
        '
        'Timer18
        '
        '
        'show_text_2
        '
        '
        'gameStart
        '
        '
        'LabelElapsedTime
        '
        Me.LabelElapsedTime.AutoSize = True
        Me.LabelElapsedTime.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelElapsedTime.Location = New System.Drawing.Point(31, 21)
        Me.LabelElapsedTime.Name = "LabelElapsedTime"
        Me.LabelElapsedTime.Size = New System.Drawing.Size(98, 22)
        Me.LabelElapsedTime.TabIndex = 16
        Me.LabelElapsedTime.Text = "経過時間"
        '
        'plane_hide_
        '
        Me.plane_hide_.AutoSize = True
        Me.plane_hide_.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.plane_hide_.Location = New System.Drawing.Point(32, 56)
        Me.plane_hide_.Name = "plane_hide_"
        Me.plane_hide_.Size = New System.Drawing.Size(134, 22)
        Me.plane_hide_.TabIndex = 17
        Me.plane_hide_.Text = "残り操作機体"
        '
        'result
        '
        Me.result.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.result.Location = New System.Drawing.Point(494, 334)
        Me.result.Multiline = True
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(279, 160)
        Me.result.TabIndex = 18
        Me.result.Visible = False
        '
        'point_
        '
        Me.point_.AutoSize = True
        Me.point_.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.point_.Location = New System.Drawing.Point(33, 99)
        Me.point_.Name = "point_"
        Me.point_.Size = New System.Drawing.Size(76, 22)
        Me.point_.TabIndex = 19
        Me.point_.Text = "ポイント"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1216, 701)
        Me.Controls.Add(Me.point_)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.plane_hide_)
        Me.Controls.Add(Me.LabelElapsedTime)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.plane2)
        Me.Controls.Add(Me.Panel0)
        Me.Controls.Add(Me.plane6)
        Me.Controls.Add(Me.plane5)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.demo)
        Me.Controls.Add(Me.plane4)
        Me.Controls.Add(Me.explain)
        Me.Controls.Add(Me.plane1)
        Me.Controls.Add(Me.plane0)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel0.ResumeLayout(False)
        Me.Panel0.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents Panel0 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents takeoff As Button
    Friend WithEvents Hold_short_of_runway As Button
    Friend WithEvents Line_up_and_wait As Button
    Friend WithEvents Label0 As Label
    Friend WithEvents plane4 As Label
    Friend WithEvents plane1 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents TextBox0 As TextBox
    Friend WithEvents Handoff_dep As Button
    Friend WithEvents explain As Label
    Friend WithEvents show_text As Timer
    Friend WithEvents demo As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents continue_approach As Button
    Friend WithEvents go_around As Button
    Friend WithEvents cleared_to_land As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Handoff_gnd As Button
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Hold_short_of_runway_1 As Button
    Friend WithEvents takeoff_1 As Button
    Friend WithEvents Line_up_and_wait_1 As Button
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Handoff_dep_1 As Button
    Friend WithEvents Timer9 As Timer
    Friend WithEvents show_text_1 As Timer
    Friend WithEvents show_text_4 As Timer
    Friend WithEvents plane5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents go_around_5 As Button
    Friend WithEvents cleared_to_land_5 As Button
    Friend WithEvents continue_approach_5 As Button
    Friend WithEvents Handoff_gnd_5 As Button
    Friend WithEvents Timer10 As Timer
    Friend WithEvents show_text_5 As Timer
    Friend WithEvents Timer11 As Timer
    Friend WithEvents Timer12 As Timer
    Friend WithEvents plane6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cleared_to_land_6 As Button
    Friend WithEvents continue_approach_6 As Button
    Friend WithEvents go_around_6 As Button
    Friend WithEvents Handoff_gnd_6 As Button
    Friend WithEvents Timer13 As Timer
    Friend WithEvents Timer14 As Timer
    Friend WithEvents Timer15 As Timer
    Friend WithEvents show_text_6 As Timer
    Friend WithEvents plane2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents takeoff_2 As Button
    Friend WithEvents Line_up_and_wait_2 As Button
    Friend WithEvents Hold_short_of_runway_2 As Button
    Friend WithEvents Handoff_dep_2 As Button
    Friend WithEvents Timer16 As Timer
    Friend WithEvents Timer17 As Timer
    Friend WithEvents Timer18 As Timer
    Friend WithEvents show_text_2 As Timer
    Friend WithEvents gameStart As Timer
    Friend WithEvents LabelElapsedTime As Label
    Friend WithEvents plane_hide_ As Label
    Friend WithEvents result As TextBox
    Friend WithEvents point_ As Label
End Class
