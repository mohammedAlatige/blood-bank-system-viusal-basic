Public Class Donors

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        DonorsBindingSource.AddNew()
    End Sub


    Private Sub Donors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloadbakDataSet.Donors' table. You can move, or remove it, as needed.
        Me.DonorsTableAdapter.Fill(Me.BloadbakDataSet.Donors)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Me.Close()
        patinets.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Me.Show()
        donate.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Me.Show()
        Trasfer.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Me.Show()
        dashbord.Show()
    End Sub

    Private Sub BttnEdite_Click(sender As Object, e As EventArgs) Handles BttnEdite.Click

        If MessageBox.Show("Do You Wont To Save This Now ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Save Anay time now '
            Me.Validate()
            Me.DonorsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BloadbakDataSet)
            MessageBox.Show("Save Was Sucessfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BttnDelete_Click(sender As Object, e As EventArgs) Handles BttnDelete.Click
        If MessageBox.Show("Do You Wont Delete This Now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PatinetsBindingSource.RemoveCurrent()

            Me.Validate()
            Me.DonorsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BloadbakDataSet)
            MessageBox.Show("Delete Was Sucessfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If MessageBox.Show("Do You Wont Close This Now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Ok See you Soon .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Me.Hide()
        End If

    End Sub
End Class