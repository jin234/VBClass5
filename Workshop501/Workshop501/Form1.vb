Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength < 13 Then
            TextBox1.BackColor = Color.Red
        Else
            For i = 0 To TextBox1.TextLength() - 1 Step 1
                If IsNumeric(TextBox1.Text(i)) = False Then
                    TextBox1.BackColor = Color.Red
                    Exit Sub
                End If
            Next
            TextBox1.BackColor = Color.White
        End If

    End Sub

    Private Sub ButtonAdd(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckedListBox1.CheckedItems.Count < 1 Then
            MessageBox.Show("กรุณาเลือกคอสเรียน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For Each item In CheckedListBox1.CheckedItems
            CheckedListBox2.Items.Add(item)
        Next
        For i = CheckedListBox1.Items.Count - 1 To 0 Step -1
            If CheckedListBox1.GetItemChecked(i) Then
                CheckedListBox1.Items.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub ButtonRemove(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckedListBox2.CheckedItems.Count < 1 Then
            MessageBox.Show("กรุณาเลือกคอสเรียน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For Each item In CheckedListBox2.CheckedItems
            CheckedListBox1.Items.Add(item)
        Next
        For i = CheckedListBox2.Items.Count - 1 To 0 Step -1
            If CheckedListBox2.GetItemChecked(i) Then
                CheckedListBox2.Items.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub ButtonEnroll(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.TextLength > 0 And TextBox1.BackColor = Color.White And CheckedListBox2.Items.Count > 0 Then
            Label4.Text = String.Format("{0:n}", CheckedListBox2.Items.Count * 2500) & " Baht."
        Else
            MessageBox.Show("กรุณาเลือกคอสเรียน และ/หรือ ป้อนเลขบัตรประชาชนให้ถูกต้อง", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonCancel(sender As Object, e As EventArgs) Handles Button4.Click
        Form_Load(sender, e)
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Courses() As String = {"English For Speaking", "English For Reading", "English For Writing", "English For listening", "Gramma Courses", "Vocabulary Courses"}
        TextBox1.Clear()
        TextBox1.BackColor = Color.White
        CheckedListBox1.Items.Clear()
        CheckedListBox1.Items.AddRange(Courses)
        CheckedListBox2.Items.Clear()
        Label4.Text = "0.00 Baht."
    End Sub
End Class
