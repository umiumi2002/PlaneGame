Imports System.Reflection.Emit


Public Class Form1
    Public Property Angle As Integer
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' フォームのサイズをPictureBoxのサイズに合わせる
        PictureBox1.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
        plane.BackColor = Color.Transparent

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub MovePlaneUp()
        plane.Top -= 1
    End Sub
    Private Sub MovePlaneRight()
        plane.Left += 1
    End Sub
    Private Sub MovePlaneRunway()
        Timer2.Interval = 30
        ' plane.Left += 10
    End Sub
    Private Sub MovePlaneTakeOff()
        Timer2.Interval = 20
        ' plane.Left += 20
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' planeを上に移動する
        If plane.Top > 430 Then
            ' planeが190より上にある場合、上に移動
            MovePlaneUp()
        End If

        ' planeが252に達した場合、一時停止
        If plane.Top < 495 Then
            Timer1.Enabled = False
            Panel1.Visible = True
            Label1.Text = plane.Name
            TextBox1.Text = "ready to takeoff"

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If plane.Top <= 430 Then
            ' planeが190以下かつ0より上にある場合、右に移動
            MovePlaneRight()
        Else
            MovePlaneUp()
        End If
        If plane.Left >= 250 Then
            MovePlaneRunway()

        ElseIf plane.Left >= 420 Then
            MovePlaneTakeOff()
        End If
        If plane.Left >= 960 Then
            plane.Location = New Point(310, 185)
            MovePlaneRight()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MovePlaneTakeOff()
    End Sub

End Class
