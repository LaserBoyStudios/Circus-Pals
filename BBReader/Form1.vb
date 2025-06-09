Imports System
Imports System.IO
Imports System.Drawing
Imports System.Media
Imports System.Windows.Forms
Imports System.Xml
Imports AgentObjects
Imports AxAgentObjects

Partial Public Class Form1
    Inherits Form

    Public Shared PageIndex As Integer
    Public Shared CurrentAction As Integer = 1
    Public Shared OpenedStoryBook As Boolean = False
    Private hoversound As SoundPlayer = New SoundPlayer()
    Public WithEvents newAgent As AxAgent = New AxAgent()
    Public Shared Caine As IAgentCtlCharacterEx
    Public Shared xmlDoc = New XmlDocument()
    Public Shared pageNode As XmlNode
    Public Shared CmdArgs As String = Command()
    Public Shared StoryPath As String
    Public Shared FileSelected As Boolean = Not String.IsNullOrEmpty(CmdArgs) AndAlso File.Exists(CmdArgs.Substring(CmdArgs.Length - (CmdArgs.Length - 1), CmdArgs.Length - 2))

    Public Sub New()
        InitializeComponent()
        hoversound.SoundLocation = Application.StartupPath & "\CHORD.WAV"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        newAgent.CreateControl()
        newAgent.Characters.Load("Caine", "Caine.acs")
        Caine = newAgent.Characters("Caine")
        Caine.MoveTo(320, 240)

        ' Shows Caine if he isn't already visible.
        If Not Caine.Visible Then
            Caine.Show()
        End If

        PageIndex = 0

        ' Checks if a storybook is selected.
        If FileSelected Then
            StoryPath = CmdArgs.Substring(CmdArgs.Length - (CmdArgs.Length - 1), CmdArgs.Length - 2)
            xmlDoc.Load(StoryPath)
        Else
            MessageBox.Show("error0")
        End If

        StopLeafButton.Hide()
        MovementButtons_Click()
    End Sub

    Private Sub NewAgent_BalloonShow(ByVal sender As Object, ByVal e As _AgentEvents_BalloonShowEvent) Handles newAgent.BalloonShow
        StopLeafButton.Show()
    End Sub

    Private Sub NewAgent_BalloonHide(ByVal sender As Object, ByVal e As _AgentEvents_BalloonHideEvent) Handles newAgent.BalloonHide
        StopLeafButton.Hide()

        ' If the last action had the value of "Read Entire Book"
        If CurrentAction = 0 Then
            Caine.Play("ReadContinued")
            PageIndex = PageIndex + 1
            MovementButtons_Click()
            ReadBook()
        End If

        ' If the storybook was opened for the first time
        If OpenedStoryBook = False Then
            If My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 0 AndAlso PageIndex < 16 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionOpen = 0 AndAlso PageIndex < 16 Then
                Caine.Play("Read")
                ReadBook()
            ElseIf My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 1 AndAlso PageIndex < 16 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionOpen = 1 AndAlso PageIndex < 16 Then
                ReadPage()
            End If

            OpenedStoryBook = True
        End If
    End Sub

    Public Shared Sub ReadBook()
        ' Reads the entire book
        If FileSelected Then
            CurrentAction = 0
            Dim PageID As String = "page" & PageIndex.ToString()
            Dim pageNode = xmlDoc.SelectSingleNode("/book/bookPages/" & PageID)
            Caine.Speak(pageNode.InnerText)
        End If
    End Sub

    Public Shared Sub ReadPage()
        ' Reads Single Page
        Caine.Play("Read")

        If FileSelected Then
            CurrentAction = 1
            Dim PageID As String = "page" & PageIndex.ToString()
            Dim pageNode = xmlDoc.SelectSingleNode("/book/bookPages/" & PageID)
            Caine.Speak(pageNode.InnerText)
        End If
    End Sub

    Public Shared Sub ThinkPage()
        ' Reads Single Page, but doesn't say it out loud.
        Caine.Play("Read")

        If FileSelected Then
            CurrentAction = 1
            Dim PageID As String = "page" & PageIndex.ToString()
            Dim pageNode = xmlDoc.SelectSingleNode("/book/bookPages/" & PageID)
            Caine.Think(pageNode.InnerText)
        End If
    End Sub

    Private Sub CloseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub MinimizeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MinimizeButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OptionsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OptionsButton.Click
        Form3.Show()
    End Sub

    Private Sub SkipLeafButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SkipLeafButton.Click
        Form2.Show()
    End Sub

    Private Sub BackLeafButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BackLeafButton.Click
        PageIndex = PageIndex - 1
        MovementButtons_Click()
        Call Caine.Stop()

        If My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 0 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionBack = 0 Then
            Caine.Play("Read")
            Call ReadBook()
        ElseIf My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 1 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionBack = 1 Then
            Call ReadPage()
        End If
    End Sub

    Private Sub NextLeafButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NextLeafButton.Click
        PageIndex = PageIndex + 1
        MovementButtons_Click()
        Call Caine.Stop()

        If My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 0 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionNext = 0 Then
            Caine.Play("Read")
            Call ReadBook()
        ElseIf My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 1 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionNext = 1 Then
            Call ReadPage()
        End If
    End Sub

    Private Sub ReadLeafButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReadLeafButton.Click
        Call Caine.Stop()

        ' If Else statement that does different actions depending on the settings.
        ' 0 - Read Entire Book
        ' 1 - Read Single Page
        ' 2 - Don't Read the Page
        If My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 0 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionRead = 0 Then
            Caine.Play("Read")
            Call ReadBook()
        ElseIf My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 1 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionRead = 1 Then
            Call ReadPage()
        ElseIf My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 2 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionRead = 2 Then
            Call ThinkPage()
        End If
    End Sub

    Public Sub MovementButtons_Click()
        ' Loads next or previous image of the StoryBook.
        If FileSelected Then
            xmlDoc.Load(StoryPath)
            Dim formatNode = xmlDoc.SelectSingleNode("/book/fileFormat")
            StoryBookPNG.Image = Image.FromFile(StoryPath.Substring(0, StoryPath.Length - 4) & "page" & PageIndex & formatNode.InnerText)
        End If

        ' Shows or Hides the "Back" button depending if it's on the first page
        If PageIndex <= 0 Then
            BackLeafButton.Hide()
        Else
            BackLeafButton.Show()
        End If

        ' Shows or Hides the "Next" button depending if it's on the last page
        If PageIndex >= 16 Then
            NextLeafButton.Hide()
        Else
            NextLeafButton.Show()
        End If
    End Sub

    Private Sub StopLeafButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StopLeafButton.Click
        CurrentAction = 1
        Call Caine.Stop()
        StopLeafButton.Hide()
    End Sub

    ' Hover and Leave actions to make Buttons glow when hovered over, or not glow when not hovered over.
    ' Also plays the Hover sound when the buttons are hovered over.

    Private Sub NextLeafButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles NextLeafButton.MouseHover
        NextLeafButton.Image = My.Resources.nexthover
        hoversound.Play()
    End Sub

    Private Sub NextLeafButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles NextLeafButton.MouseLeave
        NextLeafButton.Image = My.Resources._next
    End Sub

    Private Sub StopLeafButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles StopLeafButton.MouseHover
        StopLeafButton.Image = My.Resources.stopreadinghover
        hoversound.Play()
    End Sub

    Private Sub StopLeafButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles StopLeafButton.MouseLeave
        StopLeafButton.Image = My.Resources.stopreading
    End Sub

    Private Sub ReadLeafButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles ReadLeafButton.MouseHover
        ReadLeafButton.Image = My.Resources.readhover
        hoversound.Play()
    End Sub

    Private Sub ReadLeafButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles ReadLeafButton.MouseLeave
        ReadLeafButton.Image = My.Resources.read
        hoversound.Play()
    End Sub

    Private Sub SkipLeafButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles SkipLeafButton.MouseHover
        SkipLeafButton.Image = My.Resources.skiphover
        hoversound.Play()
    End Sub

    Private Sub SkipLeafButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles SkipLeafButton.MouseLeave
        SkipLeafButton.Image = My.Resources.skip
    End Sub

    Private Sub BackLeafButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles BackLeafButton.MouseHover
        BackLeafButton.Image = My.Resources.backhover
        hoversound.Play()
    End Sub

    Private Sub BackLeafButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles BackLeafButton.MouseLeave
        BackLeafButton.Image = My.Resources.back
        hoversound.Play()
    End Sub

    Private Sub OptionsButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles OptionsButton.MouseHover
        OptionsButton.Image = My.Resources.book_options_hover
        hoversound.Play()
    End Sub

    Private Sub OptionsButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles OptionsButton.MouseLeave
        OptionsButton.Image = My.Resources.book_options
    End Sub

    Private Sub MinimizeButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles MinimizeButton.MouseHover
        MinimizeButton.Image = My.Resources.minimize_book_hover
        hoversound.Play()
    End Sub

    Private Sub MinimizeButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles MinimizeButton.MouseLeave
        MinimizeButton.Image = My.Resources.minimize_book
    End Sub

    Private Sub CloseButton_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.MouseHover
        CloseButton.Image = My.Resources.close_book_hover
        hoversound.Play()
    End Sub

    Private Sub CloseButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.MouseLeave
        CloseButton.Image = My.Resources.close_book
    End Sub
End Class