<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form3
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
        Me.SameButtonsGroupBox = New System.Windows.Forms.GroupBox
        Me.NeverReadPagesRadioButton = New System.Windows.Forms.RadioButton
        Me.ReadCurrentPageRadioButton = New System.Windows.Forms.RadioButton
        Me.ReadEntireBookRadioButton = New System.Windows.Forms.RadioButton
        Me.SeperateButtonsGroupBox = New System.Windows.Forms.GroupBox
        Me.ActionNextLabel = New System.Windows.Forms.Label
        Me.ActionReadLabel = New System.Windows.Forms.Label
        Me.ActionSkipLabek = New System.Windows.Forms.Label
        Me.ActionBackLabel = New System.Windows.Forms.Label
        Me.ActionOpenLabel = New System.Windows.Forms.Label
        Me.ActionNextCombobox = New System.Windows.Forms.ComboBox
        Me.ActionReadCombobox = New System.Windows.Forms.ComboBox
        Me.ActionSkipCombobox = New System.Windows.Forms.ComboBox
        Me.ActionBackCombobox = New System.Windows.Forms.ComboBox
        Me.ActionOpenCombobox = New System.Windows.Forms.ComboBox
        Me.SameButtonsRadioButton = New System.Windows.Forms.RadioButton
        Me.SeperateButtonsRadioButton = New System.Windows.Forms.RadioButton
        Me.AdvancedButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.OKButton = New System.Windows.Forms.Button
        Me.SameButtonsGroupBox.SuspendLayout()
        Me.SeperateButtonsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SameButtonsGroupBox
        '
        Me.SameButtonsGroupBox.Controls.Add(Me.NeverReadPagesRadioButton)
        Me.SameButtonsGroupBox.Controls.Add(Me.ReadCurrentPageRadioButton)
        Me.SameButtonsGroupBox.Controls.Add(Me.ReadEntireBookRadioButton)
        Me.SameButtonsGroupBox.Location = New System.Drawing.Point(9, 10)
        Me.SameButtonsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SameButtonsGroupBox.Name = "SameButtonsGroupBox"
        Me.SameButtonsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.SameButtonsGroupBox.Size = New System.Drawing.Size(406, 102)
        Me.SameButtonsGroupBox.TabIndex = 0
        Me.SameButtonsGroupBox.TabStop = False
        '
        'NeverReadPagesRadioButton
        '
        Me.NeverReadPagesRadioButton.AutoSize = True
        Me.NeverReadPagesRadioButton.Location = New System.Drawing.Point(28, 71)
        Me.NeverReadPagesRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NeverReadPagesRadioButton.Name = "NeverReadPagesRadioButton"
        Me.NeverReadPagesRadioButton.Size = New System.Drawing.Size(244, 17)
        Me.NeverReadPagesRadioButton.TabIndex = 4
        Me.NeverReadPagesRadioButton.TabStop = True
        Me.NeverReadPagesRadioButton.Text = "Never Read Pages (Recommend for Zoobles.)"
        Me.NeverReadPagesRadioButton.UseVisualStyleBackColor = True
        '
        'ReadCurrentPageRadioButton
        '
        Me.ReadCurrentPageRadioButton.AutoSize = True
        Me.ReadCurrentPageRadioButton.Location = New System.Drawing.Point(28, 46)
        Me.ReadCurrentPageRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ReadCurrentPageRadioButton.Name = "ReadCurrentPageRadioButton"
        Me.ReadCurrentPageRadioButton.Size = New System.Drawing.Size(296, 17)
        Me.ReadCurrentPageRadioButton.TabIndex = 3
        Me.ReadCurrentPageRadioButton.TabStop = True
        Me.ReadCurrentPageRadioButton.Text = "Read Current Page Only (Recommend for everyone else.)"
        Me.ReadCurrentPageRadioButton.UseVisualStyleBackColor = True
        '
        'ReadEntireBookRadioButton
        '
        Me.ReadEntireBookRadioButton.AutoSize = True
        Me.ReadEntireBookRadioButton.Location = New System.Drawing.Point(28, 21)
        Me.ReadEntireBookRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ReadEntireBookRadioButton.Name = "ReadEntireBookRadioButton"
        Me.ReadEntireBookRadioButton.Size = New System.Drawing.Size(336, 17)
        Me.ReadEntireBookRadioButton.TabIndex = 2
        Me.ReadEntireBookRadioButton.TabStop = True
        Me.ReadEntireBookRadioButton.Text = "Read Entire Book From Current Page (Recommended for Pomnis.)"
        Me.ReadEntireBookRadioButton.UseVisualStyleBackColor = True
        '
        'SeperateButtonsGroupBox
        '
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionNextLabel)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionReadLabel)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionSkipLabek)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionBackLabel)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionOpenLabel)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionNextCombobox)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionReadCombobox)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionSkipCombobox)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionBackCombobox)
        Me.SeperateButtonsGroupBox.Controls.Add(Me.ActionOpenCombobox)
        Me.SeperateButtonsGroupBox.Location = New System.Drawing.Point(9, 117)
        Me.SeperateButtonsGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SeperateButtonsGroupBox.Name = "SeperateButtonsGroupBox"
        Me.SeperateButtonsGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.SeperateButtonsGroupBox.Size = New System.Drawing.Size(406, 201)
        Me.SeperateButtonsGroupBox.TabIndex = 1
        Me.SeperateButtonsGroupBox.TabStop = False
        '
        'ActionNextLabel
        '
        Me.ActionNextLabel.AutoSize = True
        Me.ActionNextLabel.Location = New System.Drawing.Point(34, 159)
        Me.ActionNextLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActionNextLabel.Name = "ActionNextLabel"
        Me.ActionNextLabel.Size = New System.Drawing.Size(104, 13)
        Me.ActionNextLabel.TabIndex = 9
        Me.ActionNextLabel.Text = "When Clicking Next:"
        '
        'ActionReadLabel
        '
        Me.ActionReadLabel.AutoSize = True
        Me.ActionReadLabel.Location = New System.Drawing.Point(28, 128)
        Me.ActionReadLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActionReadLabel.Name = "ActionReadLabel"
        Me.ActionReadLabel.Size = New System.Drawing.Size(108, 13)
        Me.ActionReadLabel.TabIndex = 8
        Me.ActionReadLabel.Text = "When Clicking Read:"
        '
        'ActionSkipLabek
        '
        Me.ActionSkipLabek.AutoSize = True
        Me.ActionSkipLabek.Location = New System.Drawing.Point(34, 96)
        Me.ActionSkipLabek.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActionSkipLabek.Name = "ActionSkipLabek"
        Me.ActionSkipLabek.Size = New System.Drawing.Size(103, 13)
        Me.ActionSkipLabek.TabIndex = 7
        Me.ActionSkipLabek.Text = "When Clicking Skip:"
        '
        'ActionBackLabel
        '
        Me.ActionBackLabel.AutoSize = True
        Me.ActionBackLabel.Location = New System.Drawing.Point(31, 63)
        Me.ActionBackLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActionBackLabel.Name = "ActionBackLabel"
        Me.ActionBackLabel.Size = New System.Drawing.Size(107, 13)
        Me.ActionBackLabel.TabIndex = 6
        Me.ActionBackLabel.Text = "When Clicking Back:"
        '
        'ActionOpenLabel
        '
        Me.ActionOpenLabel.AutoSize = True
        Me.ActionOpenLabel.Location = New System.Drawing.Point(18, 31)
        Me.ActionOpenLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ActionOpenLabel.Name = "ActionOpenLabel"
        Me.ActionOpenLabel.Size = New System.Drawing.Size(120, 13)
        Me.ActionOpenLabel.TabIndex = 5
        Me.ActionOpenLabel.Text = "When Opening A Book:"
        '
        'ActionNextCombobox
        '
        Me.ActionNextCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActionNextCombobox.FormattingEnabled = True
        Me.ActionNextCombobox.Items.AddRange(New Object() {"Read Entire Book", "Read One Page", "Don't Read"})
        Me.ActionNextCombobox.Location = New System.Drawing.Point(146, 157)
        Me.ActionNextCombobox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActionNextCombobox.Name = "ActionNextCombobox"
        Me.ActionNextCombobox.Size = New System.Drawing.Size(190, 21)
        Me.ActionNextCombobox.TabIndex = 4
        '
        'ActionReadCombobox
        '
        Me.ActionReadCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActionReadCombobox.FormattingEnabled = True
        Me.ActionReadCombobox.Items.AddRange(New Object() {"Read Entire Book", "Read One Page", "Don't Read"})
        Me.ActionReadCombobox.Location = New System.Drawing.Point(146, 125)
        Me.ActionReadCombobox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActionReadCombobox.Name = "ActionReadCombobox"
        Me.ActionReadCombobox.Size = New System.Drawing.Size(190, 21)
        Me.ActionReadCombobox.TabIndex = 3
        '
        'ActionSkipCombobox
        '
        Me.ActionSkipCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActionSkipCombobox.FormattingEnabled = True
        Me.ActionSkipCombobox.Items.AddRange(New Object() {"Read Entire Book", "Read One Page", "Don't Read"})
        Me.ActionSkipCombobox.Location = New System.Drawing.Point(146, 93)
        Me.ActionSkipCombobox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActionSkipCombobox.Name = "ActionSkipCombobox"
        Me.ActionSkipCombobox.Size = New System.Drawing.Size(190, 21)
        Me.ActionSkipCombobox.TabIndex = 2
        '
        'ActionBackCombobox
        '
        Me.ActionBackCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActionBackCombobox.FormattingEnabled = True
        Me.ActionBackCombobox.Items.AddRange(New Object() {"Read Entire Book", "Read One Page", "Don't Read"})
        Me.ActionBackCombobox.Location = New System.Drawing.Point(146, 60)
        Me.ActionBackCombobox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActionBackCombobox.Name = "ActionBackCombobox"
        Me.ActionBackCombobox.Size = New System.Drawing.Size(190, 21)
        Me.ActionBackCombobox.TabIndex = 1
        '
        'ActionOpenCombobox
        '
        Me.ActionOpenCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActionOpenCombobox.FormattingEnabled = True
        Me.ActionOpenCombobox.Items.AddRange(New Object() {"Read Entire Book", "Read One Page", "Don't Read"})
        Me.ActionOpenCombobox.Location = New System.Drawing.Point(146, 28)
        Me.ActionOpenCombobox.Margin = New System.Windows.Forms.Padding(2)
        Me.ActionOpenCombobox.Name = "ActionOpenCombobox"
        Me.ActionOpenCombobox.Size = New System.Drawing.Size(190, 21)
        Me.ActionOpenCombobox.TabIndex = 0
        '
        'SameButtonsRadioButton
        '
        Me.SameButtonsRadioButton.AutoSize = True
        Me.SameButtonsRadioButton.Location = New System.Drawing.Point(29, 8)
        Me.SameButtonsRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SameButtonsRadioButton.Name = "SameButtonsRadioButton"
        Me.SameButtonsRadioButton.Size = New System.Drawing.Size(178, 17)
        Me.SameButtonsRadioButton.TabIndex = 0
        Me.SameButtonsRadioButton.TabStop = True
        Me.SameButtonsRadioButton.Text = "Use same options for all buttons."
        Me.SameButtonsRadioButton.UseVisualStyleBackColor = True
        '
        'SeperateButtonsRadioButton
        '
        Me.SeperateButtonsRadioButton.AutoSize = True
        Me.SeperateButtonsRadioButton.Location = New System.Drawing.Point(29, 115)
        Me.SeperateButtonsRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SeperateButtonsRadioButton.Name = "SeperateButtonsRadioButton"
        Me.SeperateButtonsRadioButton.Size = New System.Drawing.Size(184, 17)
        Me.SeperateButtonsRadioButton.TabIndex = 1
        Me.SeperateButtonsRadioButton.TabStop = True
        Me.SeperateButtonsRadioButton.Text = "Configure each button seperately."
        Me.SeperateButtonsRadioButton.UseVisualStyleBackColor = True
        '
        'AdvancedButton
        '
        Me.AdvancedButton.Location = New System.Drawing.Point(9, 323)
        Me.AdvancedButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AdvancedButton.Name = "AdvancedButton"
        Me.AdvancedButton.Size = New System.Drawing.Size(80, 32)
        Me.AdvancedButton.TabIndex = 2
        Me.AdvancedButton.Text = "Advanced"
        Me.AdvancedButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(335, 323)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(80, 32)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Cancel"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(230, 323)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(80, 32)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.AdvancedButton)
        Me.Controls.Add(Me.SeperateButtonsRadioButton)
        Me.Controls.Add(Me.SameButtonsRadioButton)
        Me.Controls.Add(Me.SeperateButtonsGroupBox)
        Me.Controls.Add(Me.SameButtonsGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wacky Book - Control Panel"
        Me.SameButtonsGroupBox.ResumeLayout(False)
        Me.SameButtonsGroupBox.PerformLayout()
        Me.SeperateButtonsGroupBox.ResumeLayout(False)
        Me.SeperateButtonsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents SameButtonsGroupBox As Windows.Forms.GroupBox
    Private WithEvents SeperateButtonsGroupBox As Windows.Forms.GroupBox
    Private WithEvents SameButtonsRadioButton As Windows.Forms.RadioButton
    Private WithEvents SeperateButtonsRadioButton As Windows.Forms.RadioButton
    Private WithEvents ReadEntireBookRadioButton As Windows.Forms.RadioButton
    Private WithEvents NeverReadPagesRadioButton As Windows.Forms.RadioButton
    Private WithEvents ReadCurrentPageRadioButton As Windows.Forms.RadioButton
    Private WithEvents ActionOpenCombobox As Windows.Forms.ComboBox
    Private WithEvents ActionNextCombobox As Windows.Forms.ComboBox
    Private WithEvents ActionReadCombobox As Windows.Forms.ComboBox
    Private WithEvents ActionSkipCombobox As Windows.Forms.ComboBox
    Private WithEvents ActionBackCombobox As Windows.Forms.ComboBox
    Private WithEvents ActionSkipLabek As Windows.Forms.Label
    Private WithEvents ActionBackLabel As Windows.Forms.Label
    Private WithEvents ActionOpenLabel As Windows.Forms.Label
    Private WithEvents ActionNextLabel As Windows.Forms.Label
    Private WithEvents ActionReadLabel As Windows.Forms.Label
    Private WithEvents AdvancedButton As Windows.Forms.Button
    Private WithEvents CloseButton As Windows.Forms.Button
    Private WithEvents OKButton As Windows.Forms.Button
End Class
