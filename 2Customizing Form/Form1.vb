Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My First App in 2023"
        Me.BackColor = Color.Crimson
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Size = New Size(600, 600)
        Me.Opacity = 0.8
        Me.CenterToParent()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MsgBox("This is Edith")
    End Sub

    Private Sub EventHandlerBtn_Click(sender As Object, e As EventArgs) Handles EventHandlerBtn.Click
        MsgBox("This is Edith",, "Greetings")
    End Sub
End Class
