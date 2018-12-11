Public Class Form1
    Private Sub DayUpDown_SelectedItemChanged(sender As Object, e As EventArgs) Handles DayUpDown.SelectedItemChanged
        Dim day() As String = {"Monday", "Tuesday", "Wednesday", "Thusday", "Friday", "Saturday", "Sunday"}
        Dim Count As Integer = DayUpDown.Items.Count - 1
        For i = 0 To Count
            If DayUpDown.SelectedIndex = i Then
                LabelDay.Text = day(i)
            End If
        Next

    End Sub
End Class
