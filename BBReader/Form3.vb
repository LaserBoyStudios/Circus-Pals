Imports System
Imports System.Windows.Forms

Partial Public Class Form3
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Checks if the "UseGlobalSettings" is set to True.
        If My.Settings.UseGlobalSettings = True Then
            SameButtonsRadioButton.Checked = True
            SeperateButtonsGroupBox.Enabled = False
        Else
            SeperateButtonsRadioButton.Checked = True
            SameButtonsGroupBox.Enabled = False
        End If

        ' When Book is opened, or when Back, Skip, Read, or Next is clicked.
        ' Only works if "UseGlobalSettings" is set to True.
        If My.Settings.ActionGlobal = 0 Then
            ReadEntireBookRadioButton.Checked = True
        ElseIf My.Settings.ActionGlobal = 1 Then
            ReadCurrentPageRadioButton.Checked = True
        ElseIf My.Settings.ActionGlobal = 2 Then
            NeverReadPagesRadioButton.Checked = True
        End If
        ' When Book is opened
        If My.Settings.ActionOpen = 0 Then
            ActionOpenCombobox.Text = "Read Entire Book"
        ElseIf My.Settings.ActionOpen = 1 Then
            ActionOpenCombobox.Text = "Read One Page"
        ElseIf My.Settings.ActionOpen = 2 Then
            ActionOpenCombobox.Text = "Don't Read"
        End If
        ' When Back is clicked
        If My.Settings.ActionBack = 0 Then
            ActionBackCombobox.Text = "Read Entire Book"
        ElseIf My.Settings.ActionBack = 1 Then
            ActionBackCombobox.Text = "Read One Page"
        ElseIf My.Settings.ActionBack = 2 Then
            ActionBackCombobox.Text = "Don't Read"
        End If
        ' When Skip is clicked
        If My.Settings.ActionSkip = 0 Then
            ActionSkipCombobox.Text = "Read Entire Book"
        ElseIf My.Settings.ActionSkip = 1 Then
            ActionSkipCombobox.Text = "Read One Page"
        ElseIf My.Settings.ActionSkip = 2 Then
            ActionSkipCombobox.Text = "Don't Read"
        End If
        ' When Read is clicked
        If My.Settings.ActionRead = 0 Then
            ActionReadCombobox.Text = "Read Entire Book"
        ElseIf My.Settings.ActionRead = 1 Then
            ActionReadCombobox.Text = "Read One Page"
        ElseIf My.Settings.ActionRead = 2 Then
            ActionReadCombobox.Text = "Don't Read"
        End If
        ' When Next is clicked
        If My.Settings.ActionNext = 0 Then
            ActionNextCombobox.Text = "Read Entire Book"
        ElseIf My.Settings.ActionNext = 1 Then
            ActionNextCombobox.Text = "Read One Page"
        ElseIf My.Settings.ActionNext = 2 Then
            ActionNextCombobox.Text = "Don't Read"
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub AdvancedButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AdvancedButton.Click
        Form1.newAgent.PropertySheet.Visible = True
    End Sub

    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        My.Settings.UseGlobalSettings = SameButtonsRadioButton.Checked

        ' When Book is opened, or when Back, Skip, Read, or Next is clicked.
        ' Only works if "UseGlobalSettings" is set to True.
        If ReadEntireBookRadioButton.Checked = True Then
            My.Settings.ActionGlobal = 0
        ElseIf ReadCurrentPageRadioButton.Checked = True Then
            My.Settings.ActionGlobal = 1
        ElseIf NeverReadPagesRadioButton.Checked = True Then
            My.Settings.ActionGlobal = 2
        End If
        ' When Book is opened
        If Equals(ActionOpenCombobox.Text, "Read Entire Book") Then
            My.Settings.ActionOpen = 0
        ElseIf Equals(ActionOpenCombobox.Text, "Read One Page") Then
            My.Settings.ActionOpen = 1
        ElseIf Equals(ActionOpenCombobox.Text, "Don't Read") Then
            My.Settings.ActionOpen = 2
        End If
        ' When Back is clicked
        If Equals(ActionBackCombobox.Text, "Read Entire Book") Then
            My.Settings.ActionBack = 0
        ElseIf Equals(ActionBackCombobox.Text, "Read One Page") Then
            My.Settings.ActionBack = 1
        ElseIf Equals(ActionBackCombobox.Text, "Don't Read") Then
            My.Settings.ActionBack = 2
        End If
        ' When Skip is clicked
        If Equals(ActionSkipCombobox.Text, "Read Entire Book") Then
            My.Settings.ActionSkip = 0
        ElseIf Equals(ActionSkipCombobox.Text, "Read One Page") Then
            My.Settings.ActionSkip = 1
        ElseIf Equals(ActionSkipCombobox.Text, "Don't Read") Then
            My.Settings.ActionSkip = 2
        End If
        ' When Read is clicked
        If Equals(ActionReadCombobox.Text, "Read Entire Book") Then
            My.Settings.ActionRead = 0
        ElseIf Equals(ActionReadCombobox.Text, "Read One Page") Then
            My.Settings.ActionRead = 1
        ElseIf Equals(ActionReadCombobox.Text, "Don't Read") Then
            My.Settings.ActionRead = 2
        End If
        ' When Next is clicked
        If Equals(ActionNextCombobox.Text, "Read Entire Book") Then
            My.Settings.ActionNext = 0
        ElseIf Equals(ActionNextCombobox.Text, "Read One Page") Then
            My.Settings.ActionNext = 1
        ElseIf Equals(ActionNextCombobox.Text, "Don't Read") Then
            My.Settings.ActionNext = 2
        End If

        My.Settings.Save()
        Close()
    End Sub

    Private Sub SameButtonsRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SameButtonsRadioButton.CheckedChanged
        SameButtonsGroupBox.Enabled = SameButtonsRadioButton.Checked
    End Sub

    Private Sub SeperateButtonsRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SeperateButtonsRadioButton.CheckedChanged
        SeperateButtonsGroupBox.Enabled = SeperateButtonsRadioButton.Checked
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Close()
    End Sub
End Class
