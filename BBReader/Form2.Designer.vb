<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

#Region "Windows Form Designer generated code"
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.OKButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.SkipHelpLabel = New System.Windows.Forms.Label
        Me.PageNumberTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(290, 10)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(56, 25)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(290, 40)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(56, 25)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Cancel"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SkipHelpLabel
        '
        Me.SkipHelpLabel.AutoSize = True
        Me.SkipHelpLabel.Location = New System.Drawing.Point(10, 11)
        Me.SkipHelpLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SkipHelpLabel.Name = "SkipHelpLabel"
        Me.SkipHelpLabel.Size = New System.Drawing.Size(167, 13)
        Me.SkipHelpLabel.TabIndex = 3
        Me.SkipHelpLabel.Text = "Enter desired page number (0-16)."
        '
        'PageNumberTextBox
        '
        Me.PageNumberTextBox.Location = New System.Drawing.Point(9, 96)
        Me.PageNumberTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PageNumberTextBox.Name = "PageNumberTextBox"
        Me.PageNumberTextBox.Size = New System.Drawing.Size(337, 20)
        Me.PageNumberTextBox.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 124)
        Me.Controls.Add(Me.PageNumberTextBox)
        Me.Controls.Add(Me.SkipHelpLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.OKButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wacky Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents OKButton As Windows.Forms.Button
    Private WithEvents CloseButton As Windows.Forms.Button
    Private WithEvents SkipHelpLabel As Windows.Forms.Label
    Private WithEvents PageNumberTextBox As Windows.Forms.TextBox
End Class
