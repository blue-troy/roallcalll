Public Class Form1
    Dim i, j, p As Integer
    Dim No, Name, t, l, dizhi, classes As String           ' 用于存放读出的数据
    Dim Sum, Count As Integer
    Sub xianshi()
        FileOpen(1, "D:\student\s.txt", OpenMode.Input)        ' 打开C:\Scores.txt用于读数据，文件号为1
        ' 用于统计总成绩、总人数
        For i = 0 To j - 1
            Input(1, No)                                    ' 读学号
            Input(1, Name)                                  ' 读姓名
            Input(1, classes)                               ' 读取班级 
        Next i
        TextBox1.Text = No
        TextBox2.Text = Name
        TextBox3.Text = classes
        dizhi = "D:\student\picture\" & Name & ".jpg"
        'TextBox4.Text += "总    分：" & Sum & vbCrLf
        'TextBox4.Text += "平均成绩：" & Sum / Count & vbCrLf
        ' TextBox4.Text += "人数=" & Count
        Call picture()
        FileClose()
    End Sub
    Sub suiji()
        FileOpen(1, "D:\student\s.txt", OpenMode.Input)        ' 打开C:\Scores.txt用于读数据，文件号为1
        Dim Count As Integer                           ' 用于统计总成绩、总人数
        Count = 0
        Do While Not EOF(1)
            Input(1, No)                                    ' 读学号
            Input(1, Name)                                  ' 读姓名
            Input(1, classes)                                 ' 读成绩
            'Sum = Sum + Score                               ' 累加成绩
            Count = Count + 1                               ' 统计人数
            'TextBox4.Text += No & Space(2) & Name & Space(2) & Score & vbCrLf
        Loop
        'TextBox4.Text += "总    分：" & Sum & vbCrLf
        'TextBox4.Text += "平均成绩：" & Sum / Count & vbCrLf
        FileClose()
        'count为行数
        'suiji randon quzhi j        j = 2
        Randomize()
        '防止每次生出随机数一样 
        j = (Int(Rnd() * Count) + 1)
        'rnd()生成[0，1）的随机数，int（）是取整 
        Call xianshi()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call suiji()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        t = 30
        Label4.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label4.Text = "倒计时: " & t \ 10
        t = t - 1
        If t < 0 Then
            Timer2.Enabled = False
            Label4.Visible = False
        Else : Call suiji()
        End If
    End Sub
    Sub picture()
        PictureBox1.Image = Image.FromFile(dizhi)
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Call picture()
    End Sub
End Class

