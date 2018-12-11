Public Class Form1




    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim Text As String = TextBoxItem.Text
        If Text.Length <> 0 Then
            CheckedListBox.Items.Add(Text)
        End If
        TextBoxItem.Clear()

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim Count_item As Integer = CheckedListBox.Items.Count - 1

        For i = Count_item To 0 Step -1
            If CheckedListBox.GetItemChecked(i) Then
                CheckedListBox.Items.RemoveAt(i)
            End If
        Next



    End Sub



End Class
