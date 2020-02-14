Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strFile As String = "personal_info.txt"
        Dim fileExists As Boolean = File.Exists(strFile)
        Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
            Dim str As String = "Name: " + TextBox1.Text + Environment.NewLine + "Age: " + TextBox2.Text + Environment.NewLine + "Address: " + TextBox3.Text
            sw.WriteLine(str)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strFile As String = "personal_info.xml"
        Dim fileExists As Boolean = File.Exists(strFile)
        Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
            Dim str As String = "<Name> " + TextBox1.Text + " </Name>" + Environment.NewLine + "<Age> " + TextBox2.Text + " </Age>" + Environment.NewLine + "<Address> " + TextBox3.Text + " </Address>"
            sw.WriteLine(str)
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strFile As String = "personal_info.json"
        Dim fileExists As Boolean = File.Exists(strFile)
        Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
            Dim str As String = "{""Name"":""" + TextBox1.Text + """, " + """Age"":" + TextBox2.Text + ", ""Address"":""" + TextBox3.Text + """}"
            sw.WriteLine(str)
        End Using
    End Sub
End Class
