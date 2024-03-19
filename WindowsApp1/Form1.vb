Imports System.Reflection.Emit


Public Class Form1
    Public Property Angle As Integer
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' フォームのサイズをPictureBoxのサイズに合わせる
        PictureBox1.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If plane.Top <= 252 Then
            Timer1.Enabled = False
            Panel1.Visible = True
            Label1.Text = plane.Name
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub MovePlaneUp()
        plane.Top -= 3

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MovePlaneUp()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MovePlaneRight()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer3.Enabled = True


    End Sub

    Private Sub MovePlaneRight()
        plane.Left += 3
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MovePlaneUp()
    End Sub
End Class
