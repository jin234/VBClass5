Public Class Form1



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox5.CheckedChanged, CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            NumericUpDown1.Enabled = True
        Else
            NumericUpDown1.Enabled = False
            NumericUpDown1.Value = 0
        End If
        If CheckBox2.Checked Then
            NumericUpDown2.Enabled = True
        Else
            NumericUpDown2.Enabled = False
            NumericUpDown2.Value = 0
        End If
        If CheckBox3.Checked Then
            NumericUpDown3.Enabled = True
        Else
            NumericUpDown3.Enabled = False
            NumericUpDown3.Value = 0
        End If
        If CheckBox4.Checked Then
            NumericUpDown4.Enabled = True
        Else
            NumericUpDown4.Enabled = False
            NumericUpDown4.Value = 0
        End If
        If CheckBox5.Checked Then
            NumericUpDown5.Enabled = True
        Else
            NumericUpDown5.Enabled = False
            NumericUpDown5.Value = 0
        End If
        If CheckBox6.Checked Then
            NumericUpDown6.Enabled = True
        Else
            NumericUpDown6.Enabled = False
            NumericUpDown6.Value = 0
        End If
        If CheckBox7.Checked Then
            NumericUpDown7.Enabled = True
        Else
            NumericUpDown7.Enabled = False
            NumericUpDown7.Value = 0
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False And CheckBox5.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False Then
            If NumericUpDown1.Value > 0 Or NumericUpDown2.Value > 0 Or NumericUpDown3.Value > 0 Or NumericUpDown4.Value > 0 Or NumericUpDown5.Value > 0 Or NumericUpDown6.Value > 0 Or NumericUpDown7.Value > 0 Then
                MessageBox.Show("กรุณาเลือกเมนุ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged, NumericUpDown6.ValueChanged, NumericUpDown5.ValueChanged, NumericUpDown4.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown1.ValueChanged

    End Sub
End Class
