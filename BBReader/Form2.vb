Imports System
Imports System.Windows.Forms

Partial Public Class Form2
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        If Equals(PageNumberTextBox.Text, Nothing) OrElse Equals(PageNumberTextBox.Text, "") Then
            Close()
            Return
        ElseIf Convert.ToInt32(PageNumberTextBox.Text) > 16 Then
            Close()
            Return
        Else
            Form1.PageIndex = Convert.ToInt32(PageNumberTextBox.Text)
            Form1.MovementButtons_Click()

            ' If Else statement that does different actions depending on the settings.
            ' 0 - Read Entire Book
            ' 1 - Read Single Page
            ' 2 - Don't Read the Page
            If My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 0 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionSkip = 0 Then
                Form1.Caine.Play("Read")
                Form1.ReadBook()
            ElseIf My.Settings.UseGlobalSettings = True AndAlso My.Settings.ActionGlobal = 1 OrElse My.Settings.UseGlobalSettings = False AndAlso My.Settings.ActionSkip = 1 Then
                Form1.ReadPage()
            End If

            Close()
        End If
    End Sub

    Private Sub PageNumberTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles PageNumberTextBox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Close()
    End Sub
End Class
