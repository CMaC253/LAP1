'MIS 322
'Colin McDonald 
'LAP 1
'04/11/19

Public Class MovieTitleForm

    Private Sub hideMovieTitleButton_Click(sender As Object, e As EventArgs) Handles hideMovieTitleButton.Click
        'This button hides the movie title textbox becomes invisible
        movieTitleTextBox.Visible() = False
    End Sub '--------------------------------------------------------------------------------------------------


    Private Sub displayMovieTitleButton_Click(sender As Object, e As EventArgs) Handles displayMovieTitleButton.Click
        'This button shows the hidden movie title textbox
        movieTitleTextBox.Visible() = True
    End Sub '--------------------------------------------------------------------------------------------------


    Private Sub copyMovieTitleButton_Click(sender As Object, e As EventArgs) Handles copyMovieTitleButton.Click
        'This button Copies the text from the movie title text box into the copied title label
        copiedTitleLabel.Text = movieTitleTextBox.Text

    End Sub '--------------------------------------------------------------------------------------------------


    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'this button clears the movie title text box and puts an empty string into the copied title label
        movieTitleTextBox.Clear()
        copiedTitleLabel.Text = ""
    End Sub '--------------------------------------------------------------------------------------------------


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'This is how we close the form on click.
        Me.Close()
    End Sub '--------------------------------------------------------------------------------------------------


End Class
