Public Class GamesWindow

    Public Sub GamesWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.circuspals_games, AudioPlayMode.Background)
        Dim num As Integer = MyBase.Location.X - 20
        Dim num2 As Integer = MyBase.Location.Y - 120
        Form1.Caine.MoveTo(CShort(num), CShort(num2))
        Form1.Caine.Play("Announce")
        Form1.Caine.Speak("\Vol=65535\Welcome to the \emp\games menu! Now which one do you wanna play?")
        Form1.Caine.Play("Restpose")
    End Sub

    Private Sub GamesWindow_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Form1.Caine.MoveTo(320, 240)
    End Sub

    Private Sub Game_01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Game_01.Click
        Try
            Dim gather_gloinks As String = String.Format("{0}\\games\\gather_gloinks\\gloinks.exe", Environment.CurrentDirectory)
            Process.Start(gather_gloinks)
        Catch Ex As Exception
            Form1.Caine.Play("Uncertain")
            Form1.Caine.Speak("\Vol=65535\Sorry, but there was an error executing the game.")
            Form1.Caine.Play("Blink")
        End Try
    End Sub

    Public Sub Game_02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Game_02.Click
        Form1.Caine.Play("Uncertain")
        Form1.Caine.Speak("\Vol=65535\Sorry, but that game is unavailable at the moment.")
        Form1.Caine.Play("Blink")
    End Sub

    Public Sub Game_03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Game_03.Click
        Try
            Dim mildenhall As String = "http://web.archive.org/web/20241124195807/http://www.thewackywatch.com/"
            Process.Start(mildenhall)
        Catch Ex As Exception
            Form1.Caine.Play("Uncertain")
            Form1.Caine.Speak("\Vol=65535\Sorry, but there was an error executing the game.")
            Form1.Caine.Play("Blink")
        End Try
    End Sub

    Public Sub Game_04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Game_04.Click
        Form1.Caine.Play("Uncertain")
        Form1.Caine.Speak("\Vol=65535\Sorry, but that game is unavailable at the moment.")
        Form1.Caine.Play("Blink")
    End Sub
End Class