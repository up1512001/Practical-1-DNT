Public Class Form3
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.Text = "VB is very interesting language.And Dot Net is really good devlopment thing..."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Exit"
        Button1.BackColor = Color.Red
        Me.Dispose()
    End Sub
End Class