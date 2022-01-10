Public Class Form1
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If Guna2TextBox1.Text = "admin" And Guna2TextBox2.Text = "admin" Then
            Form2.Show()
            Me.Hide()
        Else
            Guna2HtmlLabel1.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2HtmlLabel1.Visible = False
    End Sub
End Class
