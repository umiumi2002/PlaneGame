Imports System.Reflection.Emit


Public Class Form1
    Public Property Angle As Integer
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' フォームのサイズをPictureBoxのサイズに合わせる
        PictureBox1.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
        plane1.BackColor = Color.Transparent

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        plane1.BackColor = Color.Transparent
        If Not Start.Enabled Then
            Return
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Start.Click
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
        Timer2.Interval = 10
        ' plane.Left += 20
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles takeoff.Click
        Timer2.Enabled = True
        TextBox1.AppendText("TWR >>RWY 34, cleared to takeoff " & Environment.NewLine)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MovePlaneTakeOff()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Hold_short_of_runway.Click


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Handoff_dep.Click
        TextBox1.AppendText(plane1.Name & " >> contact DEP " & Environment.NewLine)

    End Sub

    Private Sub plane1_Click(sender As Object, e As EventArgs) Handles plane1.Click
        If Not Timer1.Enabled Then
            Return
        End If
        If Panel1.Visible Then
            ' パネルが表示されている場合、非表示にする
            Panel1.Hide()
        Else
            ' パネルが非表示の場合、表示する
            Panel1.Show()
            Label1.Text = plane1.Name
        End If

    End Sub


End Class
