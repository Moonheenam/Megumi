Public Class Form1

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        flower1.ImageLocation = "..\..\Image\꽃남.jpg"
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        flower1.ImageLocation = "..\..\Image\수줍남.PNG"
    End Sub

    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        flower2.ImageLocation = "..\..\Image\꽃남.jpg"
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        flower2.ImageLocation = "..\..\Image\수줍남.PNG"
    End Sub

    Private Sub Button3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
        flower3.ImageLocation = "..\..\Image\꽃남.jpg"
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        flower3.ImageLocation = "..\..\Image\수줍남.PNG"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    '

End Class
