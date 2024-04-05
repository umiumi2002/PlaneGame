Imports System.Reflection.Emit
Imports System.Runtime.Versioning

Imports System.Runtime.InteropServices

Public Class Form1
    Private gameStartTime As DateTime
    Private Hold_short_of_runway_clicked As Boolean
    Private takeoff_clicked As Boolean
    Private Line_up_and_wait_clicked As Boolean
    Private Handoff_dep_clicked As Boolean
    Public Property Angle As Integer
    Private Handoff_gnd_clicked As Boolean
    ' 音源リソースを取り込む
    'Dim mediaStream As System.IO.Stream = My.Resources.background_voice
    'Dim takeoff_voice As System.IO.Stream = My.Resources.takeoff
    Private gameSoundPlaying As Boolean = False
    Private flag As Boolean = True
    Private flag5 As Boolean = True
    Private flag6 As Boolean = True
    Private planeMoving As Boolean = True
    Private cleared_to_land_clicked_4 As Boolean
    Private continue_approach_clicked_4 As Boolean
    Private go_around_clicked_4 As Boolean
    Private cleared_to_land_clicked_5 As Boolean
    Private continue_approach_clicked_5 As Boolean
    Private go_around_clicked_5 As Boolean
    Private cleared_to_land_clicked_6 As Boolean
    Private continue_approach_clicked_6 As Boolean
    Private go_around_clicked_6 As Boolean
    Private plane_hide As Integer
    Private point As Integer

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' フォームのサイズをPictureBoxのサイズに合わせる
        PictureBox1.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)

    End Sub





    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
        (ByVal LpstrCommand As String, ByVal LpstrReturnString As String,
         ByVal uReturnLength As Integer, ByVal HWndCallback As Integer) As Integer

    Public Sub Play_main()

        ' 再生するファイルを「sound1」「sound2」というエイリアス（別名）で開く。 
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\airport_voice.wav" & " alias sound1", Nothing, 0, 0)
        mciSendString("set sound1 repeat", Nothing, 0, 0)
        mciSendString("play sound1", Nothing, 0, 0)
    End Sub
    Public Sub Play_takeoff()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\takeoff.wav" & " alias sound2", Nothing, 0, 0)
        mciSendString("play sound2", Nothing, 0, 0)
    End Sub
    Public Sub Play_takeoff_1()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\takeoff.wav" & " alias sound3", Nothing, 0, 0)
        mciSendString("play sound3", Nothing, 0, 0)
    End Sub
    Public Sub Play_takeoff_2()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\takeoff.wav" & " alias sound4", Nothing, 0, 0)
        mciSendString("play sound4", Nothing, 0, 0)
    End Sub
    Public Sub Play_LineUpAndWait()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\lineupandwait.wav" & " alias sound5", Nothing, 0, 0)
        mciSendString("play sound5", Nothing, 0, 0)
    End Sub
    Public Sub Play_LineUpAndWait_1()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\lineupandwait.wav" & " alias sound6", Nothing, 0, 0)
        mciSendString("play sound6", Nothing, 0, 0)
    End Sub
    Public Sub Play_LineUpAndWait_2()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\lineupandwait.wav" & " alias sound7", Nothing, 0, 0)
        mciSendString("play sound7", Nothing, 0, 0)
    End Sub
    Public Sub Play_continueApproach_4()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\continueapproach.wav" & " alias sound8", Nothing, 0, 0)
        mciSendString("play sound8", Nothing, 0, 0)
    End Sub
    Public Sub Play_continueApproach_5()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\continueapproach.wav" & " alias sound9", Nothing, 0, 0)
        mciSendString("play sound9", Nothing, 0, 0)
    End Sub
    Public Sub Play_continueApproach_6()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\continueapproach.wav" & " alias sound10", Nothing, 0, 0)
        mciSendString("play sound10", Nothing, 0, 0)
    End Sub
    Public Sub Play_clearedtoland_4()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\clearedtoland.wav" & " alias sound11", Nothing, 0, 0)
        mciSendString("play sound11", Nothing, 0, 0)
    End Sub
    Public Sub Play_clearedtoland_5()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\clearedtoland.wav" & " alias sound12", Nothing, 0, 0)
        mciSendString("play sound12", Nothing, 0, 0)
    End Sub
    Public Sub Play_clearedtoland_6()
        mciSendString("open " & "C:\Users\miyam\source\repos\umiumi2002\PlaneGame\WindowsApp1\Resources\clearedtoland.wav" & " alias sound13", Nothing, 0, 0)
        mciSendString("play sound13", Nothing, 0, 0)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1の親コントロールをPictureBox1とする
        PictureBox1.Controls.Add(plane0)
        PictureBox1.Controls.Add(plane1)
        PictureBox1.Controls.Add(plane2)
        PictureBox1.Controls.Add(plane4)
        PictureBox1.Controls.Add(plane5)
        PictureBox1.Controls.Add(plane6)

    End Sub


    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ' 離陸
        Timer1.Enabled = True
        ' Timer7.Enabled = True
        ' Timer16.Enabled = True
        '着陸
        Timer4.Interval = 700
        Timer4.Enabled = True
        TextBox4.AppendText(plane4.Name & ">> Tower," & plane4.Name & " , on final RWY 32 " & Environment.NewLine)
        Timer10.Interval = 700
        Timer10.Enabled = True
        TextBox6.AppendText(plane6.Name & ">> Tower," & plane6.Name & " , on final RWY 32 " & Environment.NewLine)
        Timer13.Interval = 700
        Timer13.Enabled = True
        TextBox5.AppendText(plane5.Name & ">> Tower," & plane5.Name & " , on final RWY 32 " & Environment.NewLine)

        Start.Hide()


        plane_hide = 0
        point = 0
        ' ゲーム開始時刻を現在時刻で初期化
        gameStartTime = DateTime.Now
        ' タイマーを開始
        gameStart.Enabled = True

        ' PlayMusic(ContinuousMusicFileName, ContinuousMusicAlias, True)

        Play_main()

    End Sub

    Private Sub MovePlaneUp()
        plane0.Top -= 1
    End Sub
    Private Sub MovePlaneRight()
        plane0.Left += 1

    End Sub
    Private Sub MovePlaneRunway()
        plane0.Left += 3
    End Sub
    Private Sub MovePlaneTakeOff()
        plane0.Left += 7
    End Sub
    Private Sub ChangeToRed()
        ' 青から赤への色の変更の処理をここに記述する
        plane0.ForeColor = Color.Red
    End Sub

    Private Sub ChangeToBlue()
        ' 赤から青への色の変更の処理をここに記述する
        plane0.ForeColor = SystemColors.Highlight
    End Sub


    'plane0離陸
    Private Sub takeoff_Click(sender As Object, e As EventArgs) Handles takeoff.Click
        takeoff_clicked = True
        Timer2.Enabled = True
        TextBox0.AppendText("TWR >> " & plane0.Name & " RWY 32, cleared to takeoff " & Environment.NewLine)
        takeoff.Hide()
        Line_up_and_wait.Hide()
        Hold_short_of_runway.Hide()
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        ChangeToBlue()
        planeMoving = True
        Timer7.Enabled = True
        point += 500
        'My.Computer.Audio.Play(takeoff_voice, AudioPlayMode.Background)
        gameStart.Enabled = False
        Play_takeoff()
    End Sub


    Private Sub Hold_short_of_runway_Click(sender As Object, e As EventArgs) Handles Hold_short_of_runway.Click
        TextBox0.AppendText("TWR >>" & plane0.Name & " , Hold short of runway 32." & Environment.NewLine)
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        Hold_short_of_runway_clicked = True
    End Sub
    Private Sub Line_up_and_wait_Click(sender As Object, e As EventArgs) Handles Line_up_and_wait.Click
        Line_up_and_wait_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        Timer3.Enabled = True
        ChangeToBlue()
        TextBox0.AppendText("TWR >>" & plane0.Name & "Runway 32 ,Line up and wait." & Environment.NewLine)
        planeMoving = True
        Hold_short_of_runway.Hide()
        takeoff.Hide()
        Play_LineUpAndWait()
    End Sub

    Private Sub Handoff_dep_Click(sender As Object, e As EventArgs) Handles Handoff_dep.Click
        Handoff_dep_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        TextBox0.AppendText(plane0.Name & ">>  Contact departure ," & plane0.Name & Environment.NewLine)
        Handoff_dep.Hide()
        point += 50
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If planeMoving Then
            ' plane0を上に移動する
            If plane0.Top > 400 Then
                ' plane0が190より上にある場合、上に移動
                MovePlaneUp()
            End If

            ' plane0が252に達した場合、一時停止
            If plane0.Top < 460 Then
                Timer1.Enabled = False
                ChangeToRed()
                takeoff.Show()
                Line_up_and_wait.Show()
                Hold_short_of_runway.Show()
                TextBox0.AppendText(plane0.Name & " >> Tower, " & plane0.Name & " ,on your frequency. " & Environment.NewLine)
                planeMoving = False
            End If
        End If
        If planeMoving Then
            plane1.Top -= 1
            plane2.Top -= 1

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'If planeMoving Then
        If plane0.Top >= 400 Then
            ' plane0が190以下かつ0より上にある場合、右に移動
            MovePlaneUp()
            ChangeToBlue()
        Else
            MovePlaneRight()
        End If
        If plane0.Left >= 260 And plane0.Top >= 350 Then
            MovePlaneRunway()
        End If
        If plane0.Left >= 500 And plane0.Top >= 350 Then
            MovePlaneTakeOff()
        End If
        If plane0.Left >= 1110 Then
            plane0.Location = New Point(375, 175)
            Timer2.Interval = 500
            ChangeToRed()
            takeoff.Hide()
            Line_up_and_wait.Hide()
            Hold_short_of_runway.Hide()
            Handoff_dep.Show()
            TextBox0.AppendText("TWR >>" & plane0.Name & " ,contact to departure " & Environment.NewLine)
            MovePlaneRight()
        End If
        If plane0.Left >= 680 AndAlso plane0.Top <= 350 Then
            plane0.Hide()
            Timer2.Enabled = False
        End If
        'End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If planeMoving Then
            If plane0.Top >= 400 Then
                MovePlaneUp()

            Else
                ChangeToRed()
                takeoff.Show()
                Timer3.Enabled = False
                planeMoving = False
            End If
        End If
        If planeMoving Then
            plane1.Top -= 1
            plane2.Top -= 1

        End If
    End Sub


    Private Sub plane0_Click(sender As Object, e As EventArgs) Handles plane0.Click
        If Panel4.Visible Or Panel1.Visible Or Panel5.Visible Or Panel6.Visible Or Panel2.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel5.Hide()
            Panel1.Hide()
            Panel2.Hide()
            Panel4.Hide()
            Panel6.Hide()
            Panel0.Show()
            Label0.Text = plane0.Name
        ElseIf Panel0.Visible Then
            Panel0.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel0.Show()
            Label0.Text = plane0.Name
        End If

    End Sub

    Private Sub show_text_Tick(sender As Object, e As EventArgs) Handles show_text.Tick
        If Handoff_dep_clicked Then
            ChangeToBlue()
            TextBox0.AppendText(plane0.Name & " Nice!!!" & Environment.NewLine)
            plane_hide += 1
        ElseIf takeoff_clicked Then
            TextBox0.AppendText(plane0.Name & ">> Cleared for take off runway 32, " & plane0.Name & Environment.NewLine)
        ElseIf Hold_short_of_runway_clicked Then
            TextBox0.AppendText(plane0.Name & ">> Hold short of runway 32," & plane0.Name & Environment.NewLine)
        ElseIf Line_up_and_wait_clicked Then
            TextBox0.AppendText(plane0.Name & ">>  Line up and wait, runway 32," & plane0.Name & Environment.NewLine)
        End If
        show_text.Enabled = False
        Handoff_dep_clicked = False
        takeoff_clicked = False
        Hold_short_of_runway_clicked = False
        Line_up_and_wait_clicked = False

    End Sub


    'plane1離陸
    Private Sub plane1_Click(sender As Object, e As EventArgs) Handles plane1.Click
        If Panel4.Visible Or Panel0.Visible Or Panel5.Visible Or Panel6.Visible Or Panel2.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel0.Hide()
            Panel2.Hide()
            Panel5.Hide()
            Panel4.Hide()
            Panel6.Hide()
            Panel1.Show()
            Label1.Text = plane1.Name
        ElseIf Panel1.Visible Then
            Panel1.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel1.Show()
            Label1.Text = plane1.Name
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If planeMoving Then
            ' plane0を上に移動する
            If plane1.Top > 400 Then
                ' plane0が190より上にある場合、上に移動
                plane1.Top -= 1
            End If

            ' plane0が252に達した場合、一時停止
            If plane1.Top < 460 Then
                Timer7.Enabled = False
                plane1.ForeColor = Color.Red
                takeoff_1.Show()
                Line_up_and_wait_1.Show()
                Hold_short_of_runway_1.Show()
                TextBox1.AppendText(plane1.Name & " >> Tower, " & plane1.Name & " ,on your frequency. " & Environment.NewLine)
                planeMoving = False
            End If
        End If
        If planeMoving Then
            plane2.Top -= 1
        End If

    End Sub

    Private Sub takeoff_1_Click(sender As Object, e As EventArgs) Handles takeoff_1.Click
        takeoff_clicked = True
        Timer8.Enabled = True
        TextBox1.AppendText("TWR >> " & plane1.Name & " RWY 32, cleared to takeoff " & Environment.NewLine)
        takeoff_1.Hide()
        Line_up_and_wait_1.Hide()
        Hold_short_of_runway_1.Hide()
        show_text_1.Interval = 2000 ' 2秒間隔
        show_text_1.Enabled = True
        plane1.ForeColor = SystemColors.Highlight
        planeMoving = True
        Timer16.Enabled = True
        point += 500
        Play_takeoff_1()
    End Sub

    Private Sub Line_up_and_wait_1_Click_1(sender As Object, e As EventArgs) Handles Line_up_and_wait_1.Click
        Line_up_and_wait_clicked = True
        show_text_1.Interval = 2000 ' 2秒間隔
        show_text_1.Enabled = True
        Timer9.Enabled = True
        plane1.ForeColor = SystemColors.Highlight
        TextBox1.AppendText("TWR >>" & plane1.Name & " , Runway 32, Line up and wait." & Environment.NewLine)
        planeMoving = True
        Hold_short_of_runway_1.Hide()
        takeoff_1.Hide()
        Play_LineUpAndWait_1()
    End Sub

    Private Sub Hold_short_of_runway_1_Click_1(sender As Object, e As EventArgs) Handles Hold_short_of_runway_1.Click
        TextBox1.AppendText("TWR >>" & plane1.Name & " , Hold short of runway 32." & Environment.NewLine)
        show_text_1.Interval = 2000 ' 2秒間隔
        show_text_1.Enabled = True
        Hold_short_of_runway_clicked = True
    End Sub

    Private Sub Handoff_dep_1_Click_1(sender As Object, e As EventArgs) Handles Handoff_dep_1.Click
        Handoff_dep_clicked = True
        show_text_1.Interval = 2000 ' 2秒間隔
        show_text_1.Enabled = True
        TextBox1.AppendText(plane0.Name & ">>  Contact departure ," & plane0.Name & Environment.NewLine)
        Handoff_dep_1.Hide()
        point += 50
    End Sub


    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If plane1.Top > 400 Then
            ' plane0が190以下かつ0より上にある場合、右に移動
            plane1.Top -= 1
            plane1.ForeColor = SystemColors.Highlight
        Else
            plane1.Left += 1
        End If
        If plane1.Left >= 260 And plane1.Top >= 350 Then
            plane1.Left += 3
        End If

        If plane1.Left >= 500 And plane1.Top >= 350 Then
            plane1.Left += 7
        End If
        If plane1.Left >= 1110 Then
            plane1.Location = New Point(375, 175)
            Timer8.Interval = 500
            plane1.ForeColor = Color.Red
            takeoff_1.Hide()
            Line_up_and_wait_1.Hide()
            Hold_short_of_runway_1.Hide()
            Handoff_dep_1.Show()
            TextBox1.AppendText("TWR >>" & plane1.Name & " ,contact to departure " & Environment.NewLine)
            plane1.Left += 1
        End If
        If plane1.Left >= 680 AndAlso plane1.Top <= 350 Then
            plane1.Hide()
            Timer8.Enabled = False
        End If

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If planeMoving Then
            If plane1.Top >= 400 Then
                plane1.Top -= 1
            Else
                plane1.ForeColor = Color.Red
                takeoff_1.Show()
                Timer9.Enabled = False
                planeMoving = False
            End If
        End If
        If planeMoving Then
            plane2.Top -= 1
        End If
    End Sub

    Private Sub show_text_1_Tick(sender As Object, e As EventArgs) Handles show_text_1.Tick

        If takeoff_clicked Then
            TextBox1.AppendText(plane1.Name & ">> Cleared for take off runway 32, " & plane1.Name & Environment.NewLine)
        ElseIf Hold_short_of_runway_clicked Then
            TextBox1.AppendText(plane1.Name & ">> Hold short of runway 32," & plane1.Name & Environment.NewLine)
        ElseIf Line_up_and_wait_clicked Then
            TextBox1.AppendText(plane1.Name & ">>  Line up and wait, runway 32," & plane1.Name & Environment.NewLine)
        ElseIf Handoff_dep_clicked Then
            plane1.ForeColor = SystemColors.Highlight
            TextBox1.AppendText(plane1.Name & " Nice!!!" & Environment.NewLine)
            plane_hide += 1
        End If

        show_text_1.Enabled = False
        Handoff_dep_clicked = False
        takeoff_clicked = False
        Hold_short_of_runway_clicked = False
        Line_up_and_wait_clicked = False

    End Sub

    'plane2離陸
    Private Sub plane2_Click(sender As Object, e As EventArgs) Handles plane2.Click
        If Panel4.Visible Or Panel0.Visible Or Panel5.Visible Or Panel6.Visible Or Panel1.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel0.Hide()
            Panel5.Hide()
            Panel4.Hide()
            Panel6.Hide()
            Panel1.Hide()
            Panel2.Show()
            Label2.Text = plane2.Name
        ElseIf Panel2.Visible Then
            Panel2.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel2.Show()
            Label2.Text = plane2.Name
        End If
    End Sub

    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick
        If planeMoving Then
            ' plane2を上に移動する
            If plane2.Top > 400 Then
                ' plane0が190より上にある場合、上に移動
                plane2.Top -= 1
            End If

            ' plane0が252に達した場合、一時停止
            If plane2.Top < 460 Then
                Timer16.Enabled = False
                plane2.ForeColor = Color.Red
                takeoff_2.Show()
                Line_up_and_wait_2.Show()
                Hold_short_of_runway_2.Show()
                TextBox2.AppendText(plane2.Name & " >> Tower, " & plane2.Name & " ,on your frequency. " & Environment.NewLine)
                planeMoving = False
            End If
        End If
    End Sub

    Private Sub takeoff_2_Click(sender As Object, e As EventArgs) Handles takeoff_2.Click
        takeoff_clicked = True
        Timer17.Enabled = True
        TextBox2.AppendText("TWR >> " & plane2.Name & " RWY 32, cleared to takeoff " & Environment.NewLine)
        takeoff_2.Hide()
        Line_up_and_wait_2.Hide()
        Hold_short_of_runway_2.Hide()
        show_text_2.Interval = 2000 ' 2秒間隔
        show_text_2.Enabled = True
        plane2.ForeColor = SystemColors.Highlight
        point += 500
        Play_takeoff_2()
    End Sub

    Private Sub Line_up_and_wait_2_Click(sender As Object, e As EventArgs) Handles Line_up_and_wait_2.Click
        Line_up_and_wait_clicked = True
        show_text_2.Interval = 2000 ' 2秒間隔
        show_text_2.Enabled = True
        Timer18.Enabled = True
        plane2.ForeColor = SystemColors.Highlight
        TextBox2.AppendText("TWR >>" & plane2.Name & ", Runway 32  Line up and wait." & Environment.NewLine)
        planeMoving = True
        Hold_short_of_runway_2.Hide()
        takeoff_2.Hide()
        Play_LineUpAndWait_2()
    End Sub

    Private Sub Hold_short_of_runway_2_Click(sender As Object, e As EventArgs) Handles Hold_short_of_runway_2.Click
        TextBox2.AppendText("TWR >>" & plane2.Name & " , Hold short of runway 32." & Environment.NewLine)
        show_text_2.Interval = 2000 ' 2秒間隔
        show_text_2.Enabled = True
        Hold_short_of_runway_clicked = True
    End Sub

    Private Sub Handoff_dep_2_Click(sender As Object, e As EventArgs) Handles Handoff_dep_2.Click
        Handoff_dep_clicked = True
        show_text_2.Interval = 2000 ' 2秒間隔
        show_text_2.Enabled = True
        TextBox2.AppendText(plane0.Name & ">>  Contact departure ," & plane0.Name & Environment.NewLine)
        Handoff_dep_2.Hide()
        point += 50
    End Sub


    Private Sub Timer17_Tick(sender As Object, e As EventArgs) Handles Timer17.Tick
        If plane2.Top > 400 Then
            ' plane0が190以下かつ0より上にある場合、右に移動
            plane2.Top -= 1
            plane2.ForeColor = SystemColors.Highlight
        Else
            plane2.Left += 1
        End If
        If plane2.Left >= 260 And plane2.Top >= 350 Then
            plane2.Left += 3
        End If

        If plane2.Left >= 500 And plane2.Top >= 350 Then
            plane2.Left += 7
        End If
        If plane2.Left >= 1110 Then
            plane2.Location = New Point(375, 175)
            Timer17.Interval = 500
            plane2.ForeColor = Color.Red
            takeoff_2.Hide()
            Line_up_and_wait_2.Hide()
            Hold_short_of_runway_2.Hide()
            Handoff_dep_2.Show()
            TextBox2.AppendText("TWR >>" & plane2.Name & " ,contact to departure " & Environment.NewLine)
            plane2.Left += 1
        End If
        If plane2.Left >= 680 AndAlso plane2.Top <= 350 Then
            plane2.Hide()
            Timer17.Enabled = False
        End If

    End Sub

    Private Sub Timer18_Tick(sender As Object, e As EventArgs) Handles Timer18.Tick
        If planeMoving Then
            If plane2.Top >= 400 Then
                plane2.Top -= 1
            Else
                plane2.ForeColor = Color.Red
                takeoff_2.Hide()
                Timer9.Enabled = False
                planeMoving = False
            End If
        End If
    End Sub

    Private Sub show_text_2_Tick(sender As Object, e As EventArgs) Handles show_text_2.Tick

        If takeoff_clicked Then
            TextBox2.AppendText(plane2.Name & ">> Cleared for take off runway 32, " & plane2.Name & Environment.NewLine)
        ElseIf Hold_short_of_runway_clicked Then
            TextBox2.AppendText(plane2.Name & ">> Hold short of runway 32," & plane2.Name & Environment.NewLine)
        ElseIf Line_up_and_wait_clicked Then
            TextBox2.AppendText(plane2.Name & ">>  Line up and wait, runway 32," & plane2.Name & Environment.NewLine)
        ElseIf Handoff_dep_clicked Then
            plane2.ForeColor = SystemColors.Highlight
            TextBox2.AppendText(plane2.Name & " Nice!!!" & Environment.NewLine)
            plane_hide += 1
        End If

        show_text_2.Enabled = False
        Handoff_dep_clicked = False
        takeoff_clicked = False
        Hold_short_of_runway_clicked = False
        Line_up_and_wait_clicked = False

    End Sub


    'plane4着陸
    Private Sub plane4_Click(sender As Object, e As EventArgs) Handles plane4.Click
        If Panel0.Visible Or Panel2.Visible Or Panel5.Visible Or Panel6.Visible Or Panel2.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel0.Hide()
            Panel1.Hide()
            Panel2.Hide()
            Panel5.Hide()
            Panel6.Hide()
            Panel4.Show()
            Label4.Text = plane4.Name
        ElseIf Panel4.Visible Then
            Panel4.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel4.Show()
            Label4.Text = plane4.Name
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        plane4.Left += 1
        plane4.ForeColor = Color.Red
        cleared_to_land.Show()
        go_around.Show()
        continue_approach.Show()
    End Sub
    Private Sub cleared_to_land_Click(sender As Object, e As EventArgs) Handles cleared_to_land.Click
        flag = True
        Timer4.Enabled = False
        Timer5.Enabled = True
        TextBox4.AppendText("TWR >>" & plane4.Name & " RWY 32, cleared to land, wind 200 at 6 " & Environment.NewLine)
        cleared_to_land_clicked_4 = True
        show_text_4.Interval = 2000 ' 2秒間隔
        show_text_4.Enabled = True
        cleared_to_land.Hide()
        continue_approach.Hide()
        point += 500
        Play_clearedtoland_4()
    End Sub

    Private Sub Handoff_gnd_Click(sender As Object, e As EventArgs) Handles Handoff_gnd.Click

        TextBox4.AppendText(plane4.Name & " >> Contact ground , " & plane4.Name & ". " & Environment.NewLine)
        Handoff_gnd.Hide()
        show_text_4.Interval = 2000
        show_text_4.Enabled = True
        Handoff_gnd_clicked = True
        point += 50
    End Sub

    Private Sub continue_approach_Click(sender As Object, e As EventArgs) Handles continue_approach.Click
        TextBox4.AppendText("TWR >>" & plane4.Name & " , RWY 32 continue approach." & Environment.NewLine)
        show_text_4.Interval = 2000 ' 2秒間隔
        show_text_4.Enabled = True
        continue_approach_clicked_4 = True
        Play_continueApproach_4()
    End Sub

    Private Sub go_around_Click(sender As Object, e As EventArgs) Handles go_around.Click
        flag = False
        TextBox4.AppendText("TWR >>" & plane4.Name & " , go around, execute missed approach." & Environment.NewLine)
        show_text_4.Interval = 2000 ' 2秒間隔
        show_text_4.Enabled = True
        go_around_clicked_4 = True
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        plane4.ForeColor = SystemColors.Highlight


        If plane4.Top <= 350 Then
            Timer5.Interval = 700
        Else Timer5.Interval = 100
        End If
        If flag = True Then
            If plane4.Left >= 335 And plane4.Top <= 350 Then
                plane4.Location = New Point(210, 400)
                'TextBox4.AppendText("TWR >>" & plane4.Name & " , turn right available taxiway.  " & Environment.NewLine)
                go_around.Hide()
            ElseIf plane4.Left <= 500 And plane4.Top > 350 Then
                plane4.Left += 7
            ElseIf plane4.Left <= 700 And plane4.Top > 350 Then
                plane4.Left += 5
            ElseIf plane4.Left <= 1080 And plane4.Top > 350 Then

                plane4.Left += 3
            Else plane4.Left += 1
            End If
        Else plane4.Left += 1
            plane4.ForeColor = Color.Red
            If plane4.Left > 500 And plane4.Top <= 300 Then
                plane4.Location = New Point(150, 175)
                cleared_to_land.Show()
                plane4.ForeColor = SystemColors.Highlight
            End If
        End If
        If plane4.Left >= 1080 Then
            plane4.ForeColor = Color.Red
            Handoff_gnd.Show()
            TextBox4.AppendText("TWR >>" & plane4.Name & " , contact ground  " & Environment.NewLine)
            Timer5.Enabled = False
            Timer6.Enabled = True
        End If
    End Sub
    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        plane4.Top += 1
        If plane4.Left >= 1080 AndAlso plane4.Top >= 625 Then
            plane4.Hide()
            Timer6.Enabled = False
        End If

    End Sub


    Private Sub show_text_4_Tick_1(sender As Object, e As EventArgs) Handles show_text_4.Tick


        If Handoff_gnd_clicked Then
            plane4.ForeColor = SystemColors.Highlight
            TextBox4.AppendText(plane4.Name & "Nice!!!!" & Environment.NewLine)
            plane_hide += 1

        ElseIf cleared_to_land_clicked_4 Then
            TextBox4.AppendText(plane4.Name & ">>  Cleared to land, runway 32," & plane4.Name & Environment.NewLine)
        ElseIf continue_approach_clicked_4 Then
            TextBox4.AppendText(plane4.Name & ">>  RWY 32 continue approach " & plane4.Name & Environment.NewLine)
        ElseIf go_around_clicked_4 Then
            TextBox4.AppendText(plane4.Name & ">>  Roger " & plane4.Name & Environment.NewLine)

        End If
        show_text_4.Enabled = False
        Handoff_gnd_clicked = False
        cleared_to_land_clicked_4 = False
        continue_approach_clicked_4 = False
        go_around_clicked_4 = False

    End Sub


    'plane5着陸
    Private Sub plane5_Click(sender As Object, e As EventArgs) Handles plane5.Click
        If Panel0.Visible Or Panel1.Visible Or Panel4.Visible Or Panel6.Visible Or Panel2.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel0.Hide()
            Panel1.Hide()
            Panel2.Hide()
            Panel4.Hide()
            Panel6.Hide()
            Panel5.Show()
            Label5.Text = plane5.Name
        ElseIf Panel5.Visible Then
            Panel5.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel5.Show()
            Label5.Text = plane5.Name
        End If
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        plane5.Left += 1
        If cleared_to_land_clicked_4 Or go_around_clicked_4 Or continue_approach_clicked_4 Then
            plane5.ForeColor = Color.Red
            cleared_to_land_5.Show()
            go_around_5.Show()
            continue_approach_5.Show()
        End If
    End Sub


    Private Sub continue_approach_5_Click_1(sender As Object, e As EventArgs) Handles continue_approach_5.Click
        TextBox5.AppendText("TWR >>" & plane5.Name & " , RWY 32 continue approach." & Environment.NewLine)
        show_text_5.Interval = 2000 ' 2秒間隔
        show_text_5.Enabled = True
        continue_approach_clicked_5 = True
        Play_continueApproach_5()
    End Sub

    Private Sub Handoff_gnd_5_Click_1(sender As Object, e As EventArgs) Handles Handoff_gnd_5.Click
        TextBox5.AppendText(plane5.Name & " >> Contact ground , " & plane5.Name & ". " & Environment.NewLine)
        Handoff_gnd_5.Hide()
        show_text_5.Interval = 2000
        show_text_5.Enabled = True
        Handoff_gnd_clicked = True
        point += 50
    End Sub

    Private Sub go_around_5_Click_1(sender As Object, e As EventArgs) Handles go_around_5.Click
        flag5 = False
        TextBox5.AppendText("TWR >>" & plane5.Name & " , go around, execute missed approach." & Environment.NewLine)
        show_text_5.Interval = 2000
        show_text_5.Enabled = True
        go_around_clicked_5 = True
    End Sub

    Private Sub cleared_to_land_5_Click_1(sender As Object, e As EventArgs) Handles cleared_to_land_5.Click
        flag5 = True
        Timer10.Enabled = False
        Timer11.Enabled = True
        TextBox5.AppendText("TWR >>" & plane5.Name & " RWY 32, cleared to land, wind 200 at 6 " & Environment.NewLine)
        cleared_to_land_clicked_5 = True
        show_text_5.Interval = 2000 ' 2秒間隔
        show_text_5.Enabled = True
        cleared_to_land_5.Hide()
        continue_approach_5.Hide()
        point += 500
        Play_clearedtoland_5()
    End Sub


    Private Sub show_text_5_Tick(sender As Object, e As EventArgs) Handles show_text_5.Tick

        If Handoff_gnd_clicked Then
            plane5.ForeColor = SystemColors.Highlight
            TextBox5.AppendText(plane5.Name & "Nice!!!!" & Environment.NewLine)
            plane_hide += 1
        ElseIf cleared_to_land_clicked_5 Then
            TextBox5.AppendText(plane5.Name & ">>  Cleared to land, runway 32," & plane5.Name & Environment.NewLine)
        ElseIf continue_approach_clicked_5 Then
            TextBox5.AppendText(plane5.Name & ">>  RWY 32 continue approach " & plane5.Name & Environment.NewLine)
        ElseIf go_around_clicked_5 Then
            TextBox5.AppendText(plane5.Name & ">>  Roger " & plane5.Name & Environment.NewLine)
        End If
        show_text_5.Enabled = False
        Handoff_gnd_clicked = False
        cleared_to_land_clicked_5 = False
        continue_approach_clicked_5 = False
        go_around_clicked_5 = False

    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        plane5.ForeColor = SystemColors.Highlight


        If plane5.Top <= 350 Then
            Timer11.Interval = 700
        Else Timer11.Interval = 100
        End If
        If flag5 = True Then
            If plane5.Left >= 335 And plane5.Top <= 350 Then
                plane5.Location = New Point(210, 400)
                TextBox5.AppendText("TWR >>" & plane5.Name & " , turn right available taxiway.  " & Environment.NewLine)
                go_around_5.Hide()
            ElseIf plane5.Left <= 500 And plane5.Top > 350 Then
                plane5.Left += 7
            ElseIf plane5.Left <= 700 And plane5.Top > 350 Then
                plane5.Left += 5
            ElseIf plane5.Left <= 1080 And plane5.Top > 350 Then
                plane5.Left += 1
            Else plane5.Left += 1
            End If
        Else plane5.Left += 1
            plane5.ForeColor = Color.Red
            If plane5.Left > 500 And plane5.Top <= 300 Then
                plane5.Location = New Point(150, 175)
                cleared_to_land_5.Show()
                plane5.ForeColor = SystemColors.Highlight
            End If
        End If
        If plane5.Left >= 890 Then
            plane5.ForeColor = Color.Red
            Handoff_gnd_5.Show()
            TextBox5.AppendText("TWR >>" & plane5.Name & " , contact ground  " & Environment.NewLine)
            Timer11.Enabled = False
            Timer12.Enabled = True
        End If

    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        plane5.Top += 1
        If plane5.Left >= 890 AndAlso plane5.Top >= 625 Then
            plane5.Hide()
            Timer12.Enabled = False
        End If

    End Sub


    'plane6着陸
    Private Sub plane6_Click(sender As Object, e As EventArgs) Handles plane6.Click
        If Panel0.Visible Or Panel1.Visible Or Panel4.Visible Or Panel5.Visible Or Panel2.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel0.Hide()
            Panel1.Hide()
            Panel2.Hide()
            Panel4.Hide()
            Panel5.Hide()
            Panel6.Show()
            Label6.Text = plane6.Name
        ElseIf Panel6.Visible Then
            Panel6.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel6.Show()
            Label6.Text = plane6.Name
        End If
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        plane6.Left += 1
        If cleared_to_land_clicked_5 Or go_around_clicked_5 Or continue_approach_clicked_5 Then
            plane6.ForeColor = Color.Red
            cleared_to_land_6.Show()
            go_around_6.Show()
            continue_approach_6.Show()
        End If
    End Sub


    Private Sub continue_approach_6_Click_1(sender As Object, e As EventArgs) Handles continue_approach_6.Click
        TextBox6.AppendText("TWR >>" & plane6.Name & " , RWY 32 continue approach." & Environment.NewLine)
        show_text_6.Interval = 2000 ' 2秒間隔
        show_text_6.Enabled = True
        continue_approach_clicked_6 = True
        Play_continueApproach_6()
    End Sub

    Private Sub Handoff_gnd_6_Click_1(sender As Object, e As EventArgs) Handles Handoff_gnd_6.Click
        TextBox6.AppendText(plane6.Name & " >> Contact ground , " & plane6.Name & ". " & Environment.NewLine)
        Handoff_gnd_6.Hide()
        show_text_6.Interval = 2000
        show_text_6.Enabled = True
        Handoff_gnd_clicked = True
        point += 50
    End Sub

    Private Sub go_around_6_Click_1(sender As Object, e As EventArgs) Handles go_around_6.Click
        flag6 = False
        TextBox6.AppendText("TWR >>" & plane6.Name & " , go around, execute missed approach." & Environment.NewLine)
        show_text_6.Interval = 2000
        show_text_6.Enabled = True
        go_around_clicked_6 = True
    End Sub

    Private Sub cleared_to_land_6_Click_1(sender As Object, e As EventArgs) Handles cleared_to_land_6.Click
        flag6 = True
        Timer13.Enabled = False
        Timer14.Enabled = True
        TextBox6.AppendText("TWR >>" & plane6.Name & " RWY 32, cleared to land, wind 200 at 6 " & Environment.NewLine)
        cleared_to_land_clicked_6 = True
        show_text_6.Interval = 2000 ' 2秒間隔
        show_text_6.Enabled = True
        cleared_to_land_6.Hide()
        continue_approach_6.Hide()
        point += 500
        Play_clearedtoland_6()
    End Sub


    Private Sub show_text_6_Tick(sender As Object, e As EventArgs) Handles show_text_6.Tick

        If Handoff_gnd_clicked Then
            plane6.ForeColor = SystemColors.Highlight
            TextBox6.AppendText(plane6.Name & "Nice!!!!" & Environment.NewLine)
            plane_hide += 1
        ElseIf cleared_to_land_clicked_6 Then
            TextBox6.AppendText(plane6.Name & ">>  Cleared to land, runway 32," & plane6.Name & Environment.NewLine)
        ElseIf continue_approach_clicked_6 Then
            TextBox6.AppendText(plane6.Name & ">>  RWY 32 continue approach " & plane6.Name & Environment.NewLine)
        ElseIf go_around_clicked_6 Then
            TextBox6.AppendText(plane6.Name & ">>  Roger  " & plane6.Name & Environment.NewLine)

        End If
        show_text_6.Enabled = False
        Handoff_gnd_clicked = False
        cleared_to_land_clicked_6 = False
        continue_approach_clicked_6 = False
        go_around_clicked_6 = False

    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        plane6.ForeColor = SystemColors.Highlight

        If plane6.Top <= 350 Then
            Timer14.Interval = 700
        Else Timer14.Interval = 100
        End If
        If flag6 = True Then
            If plane6.Left >= 335 And plane6.Top <= 350 Then
                plane6.Location = New Point(210, 400)
                go_around_6.Hide()
            ElseIf plane6.Left <= 500 And plane6.Top > 350 Then
                plane6.Left += 7
            ElseIf plane6.Left <= 700 And plane6.Top > 350 Then
                plane6.Left += 5
            ElseIf plane6.Left <= 1080 And plane6.Top > 350 Then
                plane6.Left += 1
            Else plane6.Left += 1
            End If
        Else plane6.Left += 1
            plane6.ForeColor = Color.Red
            If plane6.Left > 500 And plane6.Top <= 300 Then
                plane6.Location = New Point(150, 175)
                cleared_to_land_6.Show()
                plane6.ForeColor = SystemColors.Highlight
            End If
        End If
        If plane6.Left >= 890 Then
            plane6.ForeColor = Color.Red
            Handoff_gnd_6.Show()
            TextBox6.AppendText("TWR >>" & plane6.Name & " , contact ground  " & Environment.NewLine)
            Timer14.Enabled = False
            Timer15.Enabled = True
        End If

    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        plane6.Top += 1
        If plane6.Left >= 890 AndAlso plane6.Top >= 625 Then
            plane6.Hide()
            Timer15.Enabled = False
        End If

    End Sub

    Private Sub gameStart_Tick(sender As Object, e As EventArgs) Handles gameStart.Tick
        ' ゲーム開始からの経過時間を計算
        Dim elapsedTime As TimeSpan = DateTime.Now - gameStartTime
        ' ラベルに経過時間を表示（例: "経過時間: 00:01:23"）
        LabelElapsedTime.Text = "経過時間: " & elapsedTime.ToString("hh\:mm\:ss")
        plane_hide_.Text = "残り操作機体: " & 6 - plane_hide
        point_.Text = "得点: " & point
        If plane_hide >= 6 Then
            StopGame()
        End If



        CheckGameOver()
    End Sub

    Private Sub CheckGameOver()
        Dim buttonClicked As Boolean = CheckButtonsClicked()
        If Not buttonClicked Then
            Gameover()
        End If
    End Sub

    Private Function CheckButtonsClicked() As Boolean
        ' 各ボタンの状態を確認し、すべてのボタンがクリックされているかどうかを判定するコードをここに記述
        ' ボタンがクリックされている場合はTrueを返し、それ以外の場合はFalseを返します
        If plane4.Left > 335 AndAlso plane4.Top <= 350 Then
            ' どれかひとつでもクリックされていない場合はFalseを返す
            If Not go_around_clicked_4 AndAlso Not continue_approach_clicked_4 AndAlso Not cleared_to_land_clicked_4 Then
                Return False
            End If
        End If
        If plane5.Left > 335 AndAlso plane5.Top <= 350 Then
            ' どれかひとつでもクリックされていない場合はFalseを返す
            If Not go_around_clicked_5 AndAlso Not continue_approach_clicked_5 AndAlso Not cleared_to_land_clicked_5 Then
                Return False
            End If
        End If
        If plane6.Left > 335 AndAlso plane6.Top <= 350 Then
            ' どれかひとつでもクリックされていない場合はFalseを返す
            If Not go_around_clicked_6 AndAlso Not continue_approach_clicked_6 AndAlso Not cleared_to_land_clicked_6 Then
                Return False
            End If
        End If

        ' 上記の条件に該当しない場合はTrueを返す
        Return True
    End Function

    Private Sub Gameover()
        gameStart.Enabled = False
        result.AppendText("ゲームオーバー" & Environment.NewLine)
        result.AppendText("着陸機に指示を出さぬまま滑走路を通過しました" & Environment.NewLine)
        result.Show()
    End Sub

    ' ゲームを停止し、結果を表示するメソッド
    Private Sub StopGame()

        ' ゲームを停止するためにタイマーを無効にする
        gameStart.Enabled = False

        ' ゲーム結果を表示
        ShowGameResults()
    End Sub

    Private Sub ShowGameResults()
        ' ゲーム時間を計算
        Dim gameTime As TimeSpan = DateTime.Now - gameStartTime

        ' ゲーム時間を表示
        result.AppendText(" ゲーム成功！！ " & Environment.NewLine)
        result.AppendText("ゲーム時間: " & gameTime.ToString("hh\:mm\:ss"))
        result.AppendText("得点: " & point)
        result.Show()

        ' ここで記録などの処理を行う
        ' 例: TextBoxResults.Text = "記録: 何かの値"
    End Sub


End Class
