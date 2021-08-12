Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked Or RadioButton2.Checked) Then
            TextBox1.Text = "Thanks For Your Valuable FeedBack..."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "FeedBack Form"
        Label1.Text = "Fill The FeedBack Form"
        Button1.Text = "Submit"
        Button1.BackColor = Color.Aquamarine
        Button2.Text = "Cancel"
        Button2.BackColor = Color.Red
    End Sub
End Class