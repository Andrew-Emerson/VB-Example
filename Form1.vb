Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'search name button

        'declaring a two dim string array 
        Dim employee_IDs(,) As String = New String(,) {{"Andrew J Emerson", "1055126078"}, {"James D Turner", "9425516785"},
            {"Jessica M Adams", "4142987562"}, {"Not Found", "Not Found"}}
        Dim found As Integer = 3

        For index0 = 0 To employee_IDs.GetUpperBound(0)
            If employee_IDs(index0, 0) = TextBox3.Text Then
                found = index0
                Exit For
            Else
                found = 3
            End If
        Next

        TextBox1.Text = (employee_IDs(found, 1))
        TextBox3.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'declaring a two dim string array 
        Dim employee_IDs(,) As String = New String(,) {{"Andrew J Emerson", "1055126078"}, {"James D Turner", "9425516785"},
            {"Jessica M Adams", "4142987562"}, {"Not Found", "Not Found"}}
        Dim found As Integer = 3

        For index0 = 0 To employee_IDs.GetUpperBound(0)
            If employee_IDs(index0, 1) = TextBox4.Text Then
                found = index0
                Exit For
            Else
                found = 3
            End If
        Next

        TextBox2.Text = (employee_IDs(found, 0))
        TextBox4.Focus()

    End Sub

End Class
