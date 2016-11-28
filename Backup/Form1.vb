Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FileOpen(1, "D:\net\例子\8\vbnet-2-8-2\Scores.txt", OpenMode.Append)       ' 打开C:\Scores.txt用于添加数据，文件号为1
        WriteLine(1, TextBox1.Text, TextBox2.Text, Val(TextBox3.Text))      ' 写入一行数据
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = ""
        FileClose()     ' 关闭1号文件
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FileOpen(1, "D:\net\例子\8\vbnet-2-8-2\Scores.txt", OpenMode.Input)        ' 打开C:\Scores.txt用于读数据，文件号为1
        Dim No, Name As String, Score As Integer            ' 用于存放读出的数据
        Dim Sum, Count As Integer                           ' 用于统计总成绩、总人数
        TextBox4.Text = ""
        Do While Not EOF(1)
            Input(1, No)                                    ' 读学号
            Input(1, Name)                                  ' 读姓名
            Input(1, Score)                                 ' 读成绩
            Sum = Sum + Score                               ' 累加成绩
            Count = Count + 1                               ' 统计人数
            TextBox4.Text += No & Space(2) & Name & Space(2) & Score & vbCrLf
        Loop
        TextBox4.Text += "总    分：" & Sum & vbCrLf
        TextBox4.Text += "平均成绩：" & Sum / Count & vbCrLf
        FileClose()
    End Sub
End Class
