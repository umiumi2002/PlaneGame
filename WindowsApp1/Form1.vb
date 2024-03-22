Imports System.Reflection.Emit


Public Class Form1
    Private Hold_short_of_runway_clicked As Boolean
    Private takeoff_Clicked As Boolean
    Private Line_up_and_wait_clicked As Boolean
    Private Handoff_dep_clicked As Boolean
    Public Property Angle As Integer
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' フォームのサイズをPictureBoxのサイズに合わせる
        PictureBox1.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ' ボタンが押されていない場合は何もしない


        ' ボタンが押されたら他の機能を有効にする
        Timer1.Enabled = True
        Start.Hide()
    End Sub

    Private Sub MovePlaneUp()
        plane1.Top -= 1
    End Sub
    Private Sub MovePlaneRight()
        Timer2.Interval = 100
        plane1.Left += 1
    End Sub
    Private Sub MovePlaneRunway()
        Timer2.Interval = 50
        ' plane.Left += 10
    End Sub
    Private Sub MovePlaneTakeOff()
        Timer2.Interval = 1
        plane1.Left += 20
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' planeを上に移動する
        If plane1.Top > 430 Then
            ' planeが190より上にある場合、上に移動
            MovePlaneUp()
        End If

        ' planeが252に達した場合、一時停止
        If plane1.Top < 495 Then
            Timer1.Enabled = False
            plane1.ForeColor = Color.Red
            takeoff.Show()
            Line_up_and_wait.Show()
            Hold_short_of_runway.Show()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If plane1.Top <= 430 Then
            ' planeが190以下かつ0より上にある場合、右に移動
            MovePlaneRight()
        Else
            MovePlaneUp()
        End If
        If plane1.Left >= 250 AndAlso plane1.Top >= 430 Then
            MovePlaneRunway()

        ElseIf plane1.Left >= 420 AndAlso plane1.Top >= 430 Then
            MovePlaneTakeOff()
        End If
        If plane1.Left >= 960 Then
            plane1.Location = New Point(310, 185)
            takeoff.Hide()
            Line_up_and_wait.Hide()
            Hold_short_of_runway.Hide()
            Handoff_dep.Show()
            TextBox1.AppendText("TWR >>" & plane1.Name & " ,contact to DEP " & Environment.NewLine)
            MovePlaneRight()
        End If
        If plane1.Left >= 960 AndAlso plane1.Top <= 390 Then
            plane1.Hide()

        End If
    End Sub

    Private Sub takeoff_Click(sender As Object, e As EventArgs) Handles takeoff.Click
        takeoff_Clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        Timer2.Enabled = True
        plane1.ForeColor = SystemColors.Highlight
        TextBox1.AppendText("TWR >>" & plane1.Name & "RWY 34, cleared to takeoff " & Environment.NewLine)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If plane1.Top >= 430 Then
            MovePlaneUp()
        Else
            plane1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Hold_short_of_runway_Click(sender As Object, e As EventArgs) Handles Hold_short_of_runway.Click
        Hold_short_of_runway_clicked = True
        TextBox1.AppendText("TWR >>" & plane1.Name & " , Hold short of runway 34." & Environment.NewLine)
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
    End Sub

    Private Sub Handoff_dep_Click(sender As Object, e As EventArgs) Handles Handoff_dep.Click
        Handoff_dep_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        TextBox1.AppendText(plane1.Name & " >> contact DEP " & Environment.NewLine)
        plane1.Hide()
    End Sub

    Private Sub plane1_Click(sender As Object, e As EventArgs) Handles plane1.Click
        'If Not Timer1.Enabled Then
        'Return
        'End If
        If Panel1.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel1.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel1.Show()
            Label1.Text = plane1.Name
        End If

    End Sub

    Private Sub Line_up_and_wait_Click(sender As Object, e As EventArgs) Handles Line_up_and_wait.Click
        Line_up_and_wait_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        Timer3.Enabled = True
        plane1.ForeColor = SystemColors.Highlight
        TextBox1.AppendText("TWR >>" & plane1.Name & " Line up and wait, Runway 34." & Environment.NewLine)
    End Sub

    Private Sub show_text_Tick(sender As Object, e As EventArgs) Handles show_text.Tick
        If Hold_short_of_runway_clicked Then
            TextBox1.AppendText(plane1.Name & ">> Hold short of runway 34," & plane1.Name & Environment.NewLine)
        ElseIf takeoff_Clicked Then
            TextBox1.AppendText(plane1.Name & ">>Cleared for take off runway 34, " & plane1.Name & Environment.NewLine)
        ElseIf Line_up_and_wait_clicked Then
            TextBox1.AppendText(plane1.Name & ">>  Line up and wait, Runway 34," & plane1.Name & Environment.NewLine)
        ElseIf Handoff_dep_clicked Then
            TextBox1.AppendText(plane1.Name & ">>  Contact departure ," & plane1.Name & Environment.NewLine)

        End If
        show_text.Enabled = False

    End Sub
End Class
