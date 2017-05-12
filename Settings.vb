Imports System.IO
Imports System.Text

Public Class Form2

    Dim theme As String = "dark"
    Dim path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
    Dim file As System.IO.StreamWriter

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        file = My.Computer.FileSystem.OpenTextFileWriter(path & "\settings.xml", True)
        file.WriteLine(theme)
        file.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        theme = "light"
        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        theme = "dark"
        Button1.Visible = True
        Button2.Visible = False
    End Sub
End Class
