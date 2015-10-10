Public Class Form1
    Dim input_angka As Integer
    Dim rumus As String
    Dim hasil As Byte

    Private Sub angka0_Click(sender As Object, e As EventArgs) Handles angka0.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text & "0"
        End If
    End Sub

    Private Sub angka1_Click(sender As Object, e As EventArgs) Handles angka1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = TextBox1.Text & "1"
        End If
    End Sub

    Private Sub angka2_Click(sender As Object, e As EventArgs) Handles angka2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = TextBox1.Text & "2"
        End If
    End Sub

    Private Sub angka3_Click(sender As Object, e As EventArgs) Handles angka3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = TextBox1.Text & "3"
        End If
    End Sub

    Private Sub angka4_Click(sender As Object, e As EventArgs) Handles angka4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = TextBox1.Text & "4"
        End If
    End Sub

    Private Sub angka5_Click(sender As Object, e As EventArgs) Handles angka5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = TextBox1.Text & "5"
        End If
    End Sub

    Private Sub angka6_Click(sender As Object, e As EventArgs) Handles angka6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = TextBox1.Text & "6"
        End If
    End Sub

    Private Sub angka7_Click(sender As Object, e As EventArgs) Handles angka7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = TextBox1.Text & "7"
        End If
    End Sub

    Private Sub angka8_Click(sender As Object, e As EventArgs) Handles angka8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = TextBox1.Text & "8"
        End If
    End Sub

    Private Sub angka9_Click(sender As Object, e As EventArgs) Handles angka9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = TextBox1.Text & "9"
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        input_angka = Val(TextBox1.Text)
        rumus = "-"
        TextBox1.Text = Nothing
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        input_angka = Val(TextBox1.Text)
        rumus = "+"
        TextBox1.Text = Nothing
    End Sub

    Private Sub samadengan_Click(sender As Object, e As EventArgs) Handles samadengan.Click
        Select Case rumus
            Case "-"
                TextBox1.Text = input_angka - Val(TextBox1.Text)
            Case "+"
                TextBox1.Text = input_angka + Val(TextBox1.Text)
        End Select
    End Sub
End Class
