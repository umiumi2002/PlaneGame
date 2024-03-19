Imports System.Reflection.Emit


Public Class Form1
    Public Property Angle As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("C:\Users\miyam\workspace\pygame\WindowsApp1\WindowsApp1\My Project\background.png") ' 画像のパスを指定してください

        ' フォームのサイズを背景画像のサイズに合わせる
        Me.ClientSize = New Size(Me.BackgroundImage.Width, Me.BackgroundImage.Height)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MovePlaneUp()
    End Sub

    Private Sub MovePlaneUp()
        ' label2を10ピクセル上に移動させる
        Timer1.Enabled = True
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        plane.Top -= 3



    End Sub



End Class
