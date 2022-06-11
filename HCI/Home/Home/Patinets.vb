Public Class patinets


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Me.Close()
        Donors.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        Me.Hide()
        donate.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Me.Close()
        Trasfer.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Me.Close()
        dashbord.Show()
    End Sub

    Private Sub patinets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloadbakDataSet.Patinets' table. You can move, or remove it, as needed.
        Me.PatinetsTableAdapter.Fill(Me.BloadbakDataSet.Patinets)

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        PatinetsBindingSource.AddNew()
    End Sub

    Private Sub BttnEdite_Click(sender As Object, e As EventArgs) Handles BttnEdite.Click

        If MessageBox.Show("Do You Wont To Save This Now ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Save Anay time now '
            Me.Validate()
            Me.PatinetsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BloadbakDataSet)
            MessageBox.Show("Save Was Sucessfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BttnDelete_Click(sender As Object, e As EventArgs) Handles BttnDelete.Click
        If MessageBox.Show("Do You Wont Delete This Now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PatinetsBindingSource.RemoveCurrent()

            Me.Validate()
            Me.PatinetsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BloadbakDataSet)
            MessageBox.Show("Delete Was Sucessfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If MessageBox.Show("Do You Wont Close This Now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Ok See you Soon .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Me.Hide()
        End If

    End Sub
End Class