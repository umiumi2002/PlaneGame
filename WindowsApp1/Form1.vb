Imports System.Reflection.Emit




Public Class Form1
    Dim planes As Label()
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
        Dim labels As New List(Of Label)()



    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ' ボタンが押されていない場合は何もしない


        ' ボタンが押されたら他の機能を有効にする
        Timer1.Enabled = True
        Start.Hide()
    End Sub

    Private Sub MovePlaneUp()
        plane0.Top -= 1
    End Sub
    Private Sub MovePlaneRight()
        ' Timer2.Interval = 100
        plane0.Left += 1
    End Sub
    Private Sub MovePlaneRunway()
        ' Timer2.Interval = 50
        plane0.Left += 10
    End Sub
    Private Sub MovePlaneTakeOff()
        'Timer2.Interval = 1
        plane0.Left += 20
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
        TextBox1.AppendText("TWR >>" & plane0.Name & "RWY 34, cleared to takeoff " & Environment.NewLine)
        takeoff.Hide()
        Line_up_and_wait.Hide()
        Hold_short_of_runway.Hide()
    End Sub

    Private Sub Hold_short_of_runway_Click(sender As Object, e As EventArgs) Handles Hold_short_of_runway.Click
        Hold_short_of_runway_clicked = True
        TextBox1.AppendText("TWR >>" & plane0.Name & " , Hold short of runway 34." & Environment.NewLine)
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
    End Sub
    Private Sub Line_up_and_wait_Click(sender As Object, e As EventArgs) Handles Line_up_and_wait.Click
        Line_up_and_wait_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        Timer3.Enabled = True
        ChangeToBlue()
        TextBox1.AppendText("TWR >>" & plane0.Name & " Line up and wait, Runway 34." & Environment.NewLine)
    End Sub

    Private Sub Handoff_dep_Click(sender As Object, e As EventArgs) Handles Handoff_dep.Click
        Handoff_dep_clicked = True
        show_text.Interval = 2000 ' 2秒間隔
        show_text.Enabled = True
        TextBox1.AppendText(plane0.Name & " >> contact DEP " & Environment.NewLine)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick




        ' planeを上に移動する
        If plane0.Top > 430 Then
            ' planeが190より上にある場合、上に移動
            MovePlaneUp()
        End If

        ' planeが252に達した場合、一時停止
        If plane0.Top < 495 Then
            Timer1.Enabled = False
            ChangeToRed()
            takeoff.Show()
            Line_up_and_wait.Show()
            Hold_short_of_runway.Show()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If plane0.Top <= 430 Then
            ' planeが190以下かつ0より上にある場合、右に移動
            MovePlaneRight()
        Else
            MovePlaneUp()
        End If
        If plane0.Left >= 250 AndAlso plane0.Top >= 430 Then
            MovePlaneRunway()

        ElseIf plane0.Left >= 420 AndAlso plane0.Top >= 430 Then
            MovePlaneTakeOff()
        End If
        If plane0.Left >= 960 Then
            plane0.Location = New Point(310, 185)
            ChangeToRed()
            takeoff.Hide()
            Line_up_and_wait.Hide()
            Hold_short_of_runway.Hide()
            Handoff_dep.Show()
            TextBox1.AppendText("TWR >>" & plane0.Name & " ,contact to DEP " & Environment.NewLine)
            MovePlaneRight()
        End If
        If plane0.Left >= 960 AndAlso plane0.Top <= 390 Then
            plane0.Hide()

        End If
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If plane0.Top >= 430 Then
            MovePlaneUp()
        Else
            ChangeToRed()
            Timer3.Enabled = False
        End If
    End Sub


    Private Sub plane1_Click(sender As Object, e As EventArgs) Handles plane0.Click
        'If Not Timer1.Enabled Then
        'Return
        'End If
        If Panel1.Visible Then
            ' パネルが表示されている場合、非表示にする
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
        ElseIf Hold_short_of_runway_clicked Then
            TextBox1.AppendText(plane0.Name & ">> Hold short of runway 34," & plane0.Name & Environment.NewLine)
        ElseIf takeoff_Clicked Then
            TextBox1.AppendText(plane0.Name & ">>Cleared for take off runway 34, " & plane0.Name & Environment.NewLine)
        ElseIf Line_up_and_wait_clicked Then
            TextBox1.AppendText(plane0.Name & ">>  Line up and wait, Runway 34," & plane0.Name & Environment.NewLine)


        End If
        show_text.Enabled = False

    End Sub
End Class
Public Class Airplane
    ' 飛行機のプロパティ
    Public Property Top As Integer
    Public Property Left As Integer

    ' コンストラクタ
    Public Sub New(top As Integer, left As Integer)
        Me.Top = top
        Me.Left = left
    End Sub

    ' 飛行機を上に移動させるメソッド
    Public Sub MoveUp()
        Me.Top -= 1
    End Sub

    ' 飛行機を右に移動させるメソッド
    Public Sub MoveRight()
        Me.Left += 1
    End Sub

    ' 他のメソッドやイベントハンドラを追加できます
End Class