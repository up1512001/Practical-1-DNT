Public Class Form1

    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Utsav menu app"
        BackColor = Color.AliceBlue

    End Sub

    Private Sub ExitToolStripe(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()

    End Sub


End Class
