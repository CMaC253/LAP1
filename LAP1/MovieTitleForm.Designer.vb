<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieTitleForm
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.movieTitleLable = New System.Windows.Forms.Label()
        Me.movieTitleTextBox = New System.Windows.Forms.TextBox()
        Me.hideMovieTitleButton = New System.Windows.Forms.Button()
        Me.displayMovieTitleButton = New System.Windows.Forms.Button()
        Me.copyMovieTitleButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.copiedTitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'movieTitleLable
        '
        Me.movieTitleLable.AutoSize = True
        Me.movieTitleLable.Location = New System.Drawing.Point(46, 64)
        Me.movieTitleLable.Name = "movieTitleLable"
        Me.movieTitleLable.Size = New System.Drawing.Size(104, 17)
        Me.movieTitleLable.TabIndex = 0
        Me.movieTitleLable.Text = "Movie Title:"
        '
        'movieTitleTextBox
        '
        Me.movieTitleTextBox.Location = New System.Drawing.Point(237, 64)
        Me.movieTitleTextBox.Name = "movieTitleTextBox"
        Me.movieTitleTextBox.Size = New System.Drawing.Size(174, 23)
        Me.movieTitleTextBox.TabIndex = 1
        Me.movieTitleTextBox.Text = "Movie Title?"
        '
        'hideMovieTitleButton
        '
        Me.hideMovieTitleButton.BackColor = System.Drawing.Color.Lime
        Me.hideMovieTitleButton.Location = New System.Drawing.Point(49, 128)
        Me.hideMovieTitleButton.Name = "hideMovieTitleButton"
        Me.hideMovieTitleButton.Size = New System.Drawing.Size(243, 45)
        Me.hideMovieTitleButton.TabIndex = 2
        Me.hideMovieTitleButton.Text = "Hide movie title"
        Me.hideMovieTitleButton.UseVisualStyleBackColor = False
        '
        'displayMovieTitleButton
        '
        Me.displayMovieTitleButton.BackColor = System.Drawing.Color.Lime
        Me.displayMovieTitleButton.Location = New System.Drawing.Point(49, 179)
        Me.displayMovieTitleButton.Name = "displayMovieTitleButton"
        Me.displayMovieTitleButton.Size = New System.Drawing.Size(243, 45)
        Me.displayMovieTitleButton.TabIndex = 3
        Me.displayMovieTitleButton.Text = "Display movie title"
        Me.displayMovieTitleButton.UseVisualStyleBackColor = False
        '
        'copyMovieTitleButton
        '
        Me.copyMovieTitleButton.BackColor = System.Drawing.Color.Lime
        Me.copyMovieTitleButton.Location = New System.Drawing.Point(49, 256)
        Me.copyMovieTitleButton.Name = "copyMovieTitleButton"
        Me.copyMovieTitleButton.Size = New System.Drawing.Size(91, 142)
        Me.copyMovieTitleButton.TabIndex = 4
        Me.copyMovieTitleButton.Text = "Copy movie title"
        Me.copyMovieTitleButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.Lime
        Me.clearButton.Location = New System.Drawing.Point(49, 467)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(148, 45)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Lime
        Me.exitButton.Location = New System.Drawing.Point(307, 467)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(148, 45)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'copiedTitleLabel
        '
        Me.copiedTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.copiedTitleLabel.Location = New System.Drawing.Point(164, 319)
        Me.copiedTitleLabel.Name = "copiedTitleLabel"
        Me.copiedTitleLabel.Size = New System.Drawing.Size(247, 26)
        Me.copiedTitleLabel.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 578)
        Me.Controls.Add(Me.copiedTitleLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.copyMovieTitleButton)
        Me.Controls.Add(Me.displayMovieTitleButton)
        Me.Controls.Add(Me.hideMovieTitleButton)
        Me.Controls.Add(Me.movieTitleTextBox)
        Me.Controls.Add(Me.movieTitleLable)
        Me.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAP 1 Movie Title"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents movieTitleLable As Label
    Friend WithEvents movieTitleTextBox As TextBox
    Friend WithEvents hideMovieTitleButton As Button
    Friend WithEvents displayMovieTitleButton As Button
    Friend WithEvents copyMovieTitleButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents copiedTitleLabel As Label
End Class
