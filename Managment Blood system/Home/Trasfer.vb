Public Class Trasfer


    Private Sub DonorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.DonorsTableAdapter.FillBy(Me.BloadbakDataSet.Donors, DonorNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.DonorsTableAdapter.FillBy(Me.BloadbakDataSet.Donors, TextBox1.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MessageBox.Show("Do you wont close this now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("see you soon .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Me.Close()
        End If

    End Sub

  
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        donate.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        patinets.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Donors.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        dashbord.Show()
    End Sub

End Class