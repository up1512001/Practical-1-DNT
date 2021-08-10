Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btn As Button
        btn = sender
        If (txtDisplay.Text = "0") Then
            txtDisplay.Clear()
        End If
        txtDisplay.Text += btn.Text
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If (txtDisplay.Text IsNot "") Then
            Dim temp = txtDisplay.Text
            Dim tbl = New DataTable()
            txtDisplay.Text = Convert.ToDouble(tbl.Compute(temp, Nothing))
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub

    Private Sub operation_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMul.Click, btnDiv.Click
        Dim btn As Button
        btn = sender
        If (txtDisplay.Text IsNot "") Then
            Dim temp = txtDisplay.Text
            Dim tbl = New DataTable()
            txtDisplay.Text = Convert.ToDouble(tbl.Compute(temp, Nothing))
        End If
        txtDisplay.Text += btn.Text

    End Sub

End Class
