Public Class Form1
    Private Sub Numeric_ValueChanged(sender As Object, e As EventArgs) Handles Numeric.ValueChanged, MyBase.Load
        LabelNumeric.Text = Numeric.Value
    End Sub
End Class
