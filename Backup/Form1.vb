Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FileOpen(1, "D:\net\����\8\vbnet-2-8-2\Scores.txt", OpenMode.Append)       ' ��C:\Scores.txt����������ݣ��ļ���Ϊ1
        WriteLine(1, TextBox1.Text, TextBox2.Text, Val(TextBox3.Text))      ' д��һ������
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = ""
        FileClose()     ' �ر�1���ļ�
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FileOpen(1, "D:\net\����\8\vbnet-2-8-2\Scores.txt", OpenMode.Input)        ' ��C:\Scores.txt���ڶ����ݣ��ļ���Ϊ1
        Dim No, Name As String, Score As Integer            ' ���ڴ�Ŷ���������
        Dim Sum, Count As Integer                           ' ����ͳ���ܳɼ���������
        TextBox4.Text = ""
        Do While Not EOF(1)
            Input(1, No)                                    ' ��ѧ��
            Input(1, Name)                                  ' ������
            Input(1, Score)                                 ' ���ɼ�
            Sum = Sum + Score                               ' �ۼӳɼ�
            Count = Count + 1                               ' ͳ������
            TextBox4.Text += No & Space(2) & Name & Space(2) & Score & vbCrLf
        Loop
        TextBox4.Text += "��    �֣�" & Sum & vbCrLf
        TextBox4.Text += "ƽ���ɼ���" & Sum / Count & vbCrLf
        FileClose()
    End Sub
End Class
