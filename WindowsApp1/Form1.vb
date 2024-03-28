Imports System.Reflection.Emit
Imports System.Runtime.Versioning




Public Class Form1
    Dim planes As Label()
    Private Hold_short_of_runway_clicked As Boolean
    Private takeoff_Clicked As Boolean
    Private Line_up_and_wait_clicked As Boolean
    Private Handoff_dep_clicked As Boolean
    Private cleared_to_land_clicked As Boolean
    Public Property Angle As Integer


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' フォームのサイズをPictureBoxのサイズに合わせる
        PictureBox1.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1の親コントロールをPictureBox1とする
        PictureBox1.Controls.Add(plane0)
        PictureBox1.Controls.Add(plane1)
        PictureBox1.Controls.Add(plane4)
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ' ボタンが押されたら他の機能を有効にする
        Timer1.Enabled = True
        Timer4.Enabled = True
        TextBox2.AppendText(plane4.Name & ">> Tower," & plane4.Name & " , on final RWY 32 " & Environment.NewLine)
        Start.Hide()
    End Sub

    Private Sub MovePlaneUp()
        plane0.Top -= 1
    End Sub
    Private Sub MovePlaneRight()
        ' Timer2.Interval = 100
        plane0.Left += 2

    End Sub
    Private Sub MovePlaneRunway()
        ' Timer2.Interval = 50
        plane0.Left += 10
    End Sub
    Private Sub MovePlaneTakeOff()
        'Timer2.Interval = 1
        plane0.Left += 30
    End Sub
    Private Sub ChangeToRed()
        ' 青から赤への色の変更の処理をここに記述する
        plane0.ForeColor = Color.Red
    End Sub

    Private Sub ChangeToBlue()
        ' 赤から青への色の変更の処理をここに記述する
        plane0.ForeColor = SystemColors.Highlight
    End Sub



    Private Sub takeoff_Click(sender As Object, e As EventArgs) Handles takeoff.Click
        takeoff_Clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        Timer2.Enabled = True
        TextBox1.AppendText("TWR >>" & plane0.Name & "RWY 32, cleared to takeoff " & Environment.NewLine)
        takeoff.Hide()
        Line_up_and_wait.Hide()
        Hold_short_of_runway.Hide()
    End Sub

    Private Sub Hold_short_of_runway_Click(sender As Object, e As EventArgs) Handles Hold_short_of_runway.Click
        Hold_short_of_runway_clicked = True
        TextBox1.AppendText("TWR >>" & plane0.Name & " , Hold short of runway 32." & Environment.NewLine)
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
    End Sub
    Private Sub Line_up_and_wait_Click(sender As Object, e As EventArgs) Handles Line_up_and_wait.Click
        Line_up_and_wait_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        Timer3.Enabled = True
        ChangeToBlue()
        TextBox1.AppendText("TWR >>" & plane0.Name & " Line up and wait, Runway 32." & Environment.NewLine)
    End Sub

    Private Sub Handoff_dep_Click(sender As Object, e As EventArgs) Handles Handoff_dep.Click
        Handoff_dep_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        TextBox1.AppendText(plane0.Name & " >> contact DEP " & Environment.NewLine)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        ' plane0を上に移動する
        If plane0.Top > 365 Then
            ' plane0が190より上にある場合、上に移動
            MovePlaneUp()
        End If

        ' plane0が252に達した場合、一時停止
        If plane0.Top < 425 Then
            Timer1.Enabled = False
            ChangeToRed()
            takeoff.Show()
            Line_up_and_wait.Show()
            Hold_short_of_runway.Show()
            TextBox1.AppendText(plane0.Name & " >> Tower," & plane0.Name & " ,on your frequency. " & Environment.NewLine)
        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If plane0.Top <= 365 Then
            ' plane0が190以下かつ0より上にある場合、右に移動
            MovePlaneRight()
        Else
            MovePlaneUp()
        End If
        If plane0.Left >= 180 AndAlso plane0.Top >= 365 Then
            MovePlaneRunway()

        ElseIf plane0.Left >= 300 AndAlso plane0.Top >= 365 Then
            MovePlaneTakeOff()
        End If
        If plane0.Left >= 840 Then
            plane0.Location = New Point(240, 155)
            ChangeToRed()
            takeoff.Hide()
            Line_up_and_wait.Hide()
            Hold_short_of_runway.Hide()
            Handoff_dep.Show()
            TextBox1.AppendText("TWR >>" & plane0.Name & " ,contact to DEP " & Environment.NewLine)
            MovePlaneRight()
        End If
        If plane0.Left >= 700 AndAlso plane0.Top <= 320 Then
            plane0.Hide()
        End If
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If plane0.Top >= 365 Then
            MovePlaneUp()
        Else
            ChangeToRed()
            Timer3.Enabled = False
        End If
    End Sub


    Private Sub plane0_Click(sender As Object, e As EventArgs) Handles plane0.Click
        'If Not Timer1.Enabled Then
        'Return
        'End If
        If Panel2.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel2.Hide()
            Panel1.Show()
            Label1.Text = plane0.Name
        ElseIf Panel1.Visible Then
            Panel1.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel1.Show()
            Label1.Text = plane0.Name
        End If

    End Sub

    Private Sub show_text_Tick(sender As Object, e As EventArgs) Handles show_text.Tick
        If Handoff_dep_clicked Then
            TextBox1.AppendText(plane0.Name & ">>  Contact departure ," & plane0.Name & Environment.NewLine)
            ChangeToBlue()
        ElseIf takeoff_clicked Then
            TextBox1.AppendText(plane0.Name & ">> Cleared for take off runway 32, " & plane0.Name & Environment.NewLine)
        ElseIf Hold_short_of_runway_clicked Then
            TextBox1.AppendText(plane0.Name & ">> Hold short of runway 32," & plane0.Name & Environment.NewLine)

        ElseIf Line_up_and_wait_clicked Then
            TextBox1.AppendText(plane0.Name & ">>  Line up and wait, Runway 32," & plane0.Name & Environment.NewLine)
        End If
        If cleared_to_land_clicked Then
            TextBox2.AppendText(plane4.Name & ">>  Cleared to land, Runway 32," & plane4.Name & Environment.NewLine)
        End If
        show_text.Enabled = False

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        plane4.Left += 1
        plane4.ForeColor = Color.Red
        cleared_to_land.Show()
        go_around.Show()
        continue_approach.Show()





    End Sub

    Private Sub plane5_Click(sender As Object, e As EventArgs) Handles plane4.Click
        If Panel1.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel1.Hide()
            Panel2.Show()
            Label2.Text = plane4.Name
        ElseIf Panel2.Visible Then
            Panel2.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel2.Show()
            Label2.Text = plane4.Name
        End If
    End Sub


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        plane4.ForeColor = SystemColors.Highlight
        If plane4.Left >= 190 AndAlso plane4.Top <= 300 Then
            plane4.Location = New Point(120, 365)
            plane4.Left += 50
        ElseIf plane4.Left >= 370 Then
            plane4.Left += 10
        End If
    End Sub

    Private Sub cleared_to_land_Click_1(sender As Object, e As EventArgs) Handles cleared_to_land.Click
        Timer5.Enabled = True

        TextBox2.AppendText("TWR >>" & plane4.Name & " RWY 32, cleared to land " & Environment.NewLine)
        cleared_to_land_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
    End Sub
End Class
