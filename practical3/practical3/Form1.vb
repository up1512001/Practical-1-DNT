Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        Me.Text = "Utsav"

    End Sub

    Private Sub FeedBackFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedBackFormToolStripMenuItem.Click
        Dim frm2 As New Form2
        frm2.MdiParent = Me
        frm2.Show()
    End Sub

    Private Sub VBNETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VBNETToolStripMenuItem.Click
        Dim frm3 As New Form3
        frm3.MdiParent = Me
        frm3.Show()
    End Sub
End Class
