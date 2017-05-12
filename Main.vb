Imports System.IO
Imports System.IO.StreamReader

Public Class Form1

    Dim theme As String = "dark"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(path & "\settings.xml")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()

        ThemeManager()
    End Sub

    Private Sub ThemeManager()
        If theme = "dark" Then
            Me.BackColor = Color.DimGray
            Me.ForeColor = Color.White
        ElseIf theme = "light" Then
            Me.BackColor = Color.Gainsboro
            Me.ForeColor = Color.Black
        End If
    End Sub
End Class
