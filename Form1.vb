Imports System.Media

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As New Random

        For i As Integer = 0 To 50
            Dim bad = New Form
            bad.Name = "hiiiiii"
            Dim x = rand.Next(My.Computer.Screen.Bounds.Width)
            Dim y = rand.Next(My.Computer.Screen.Bounds.Height)
            bad.BackgroundImage = My.Resources.gnarpy_improved
            bad.BackgroundImageLayout = ImageLayout.Zoom
            bad.Location = New Point(x, y)
            bad.StartPosition = FormStartPosition.Manual
            bad.Show()
        Next

        My.Computer.Audio.Play("C:\Windows\Media\Alarm01.wav")
    End Sub
End Class
