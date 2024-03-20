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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.plane = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 54)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'plane
        '
        Me.plane.AutoSize = True
        Me.plane.BackColor = System.Drawing.Color.Transparent
        Me.plane.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plane.ForeColor = System.Drawing.SystemColors.Highlight
        Me.plane.Location = New System.Drawing.Point(124, 531)
        Me.plane.Margin = New System.Windows.Forms.Padding(0)
        Me.plane.Name = "plane"
        Me.plane.Size = New System.Drawing.Size(55, 15)
        Me.plane.TabIndex = 1
        Me.plane.Text = "● ANA"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(527, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 344)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(61, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 23)
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(171, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 48)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "離陸許可"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(171, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 46)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "滑走路前待機"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(171, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 46)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "滑走路内待機"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1030, 669)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(958, 431)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "●"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(310, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "●"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 666)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.plane)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents plane As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
