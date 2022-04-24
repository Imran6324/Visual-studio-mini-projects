Public Class Form1
    Dim a As Long
    Dim s As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        a = CInt(TextBox1.Text)
        s = "+"
        TextBox1.Text = ""
    End Sub
    Private Sub ButtonS_Click(sender As Object, e As EventArgs) Handles ButtonS.Click
        a = CInt(TextBox1.Text)
        s = "-"
        TextBox1.Text = ""
    End Sub
    Private Sub ButtonM_Click(sender As Object, e As EventArgs) Handles ButtonM.Click
        a = CInt(TextBox1.Text)
        s = "*"
        TextBox1.Text = ""
    End Sub
    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click
        a = CInt(TextBox1.Text)
        s = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button_Equal_Click(sender As Object, e As EventArgs) Handles Button_Equal.Click
        If s = "/" Then
            TextBox1.Text = CInt(a) / CInt(TextBox1.Text)
        ElseIf s = "-" Then
            TextBox1.Text = CInt(a) - CInt(TextBox1.Text)
        ElseIf s = "+" Then
            TextBox1.Text = CInt(a) + CInt(TextBox1.Text)
        ElseIf s = "*" Then
            TextBox1.Text = CInt(a) * CInt(TextBox1.Text)
        End If
    End Sub

    Private Sub Button_Del_Click(sender As Object, e As EventArgs) Handles Button_Del.Click
        Dim z As Long
        a = TextBox1.Text
        z = TextBox1.Text \ 10
        TextBox1.Text = z
    End Sub
End Class
