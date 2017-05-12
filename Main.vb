Imports System.IO
Imports System.IO.StreamReader

Public Class Form1
#Region "Solvers"
#Region "Adding 0"
    Public Sub SolveFor0()

    End Sub
#End Region
#Region "Adding 1"
    Public Sub SolveFor1()

    End Sub
#End Region
#Region "Adding 2"
    Public Sub SolveFor2()

    End Sub
#End Region
#Region "Adding 3"
    Public Sub SolveFor3()

    End Sub
#End Region
#Region "Adding 4"
    Public Sub SolveFor4()

    End Sub
#End Region
#Region "Adding 5"
    Public Sub SolveFor5()

    End Sub
#End Region
#Region "Adding 6"
    Public Sub SolveFor6()

    End Sub
#End Region
#Region "Adding 7"
    Public Sub SolveFor7()

    End Sub
#End Region
#Region "Adding 8"
    Public Sub SolveFor8()

    End Sub
#End Region
#Region "Adding 9"
    Public Sub SolveFor9()

    End Sub
#End Region
#Region "Adding Decimal"
    Public Sub SolveForDecimal()

    End Sub
#End Region
#Region "Solve"
    Public Sub Solve()
        TextBox1.Text = currentAnswer
    End Sub
#End Region
#End Region
    Dim theme As String = "dark"
    Dim currentAnswer As Integer

#Region "Application Close/Minimize"
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Settings Reader"
        Dim path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(path & "\settings.xml")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
#End Region
        ThemeManager()
    End Sub
#Region "Theme Manager"
    Private Sub ThemeManager()
        If theme = "dark" Then
            Me.BackColor = Color.DimGray
            Me.ForeColor = Color.White
        ElseIf theme = "light" Then
            Me.BackColor = Color.Gainsboro
            Me.ForeColor = Color.Black
        End If
    End Sub
#End Region
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If TextBox1.Text = "0" Then
            Throw New NotImplementedException()
        ElseIf TextBox1.Text >= 0 Then
            SolveFor0()
        End If
    End Sub
End Class
