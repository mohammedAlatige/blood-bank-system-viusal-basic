Public Class donate

   


    Private Sub DonorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DonorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloadbakDataSet)

    End Sub


    Private Sub DonorsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DonorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloadbakDataSet)

    End Sub


    Private Sub donate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloadbakDataSet.Donors' table. You can move, or remove it, as needed.
        Me.DonorsTableAdapter.Fill(Me.BloadbakDataSet.Donors)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.DonorsTableAdapter.FillBy1(Me.BloadbakDataSet.Donors, DonorNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DonorsTableAdapter.FillBy1(Me.BloadbakDataSet.Donors, blood_group.Text)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        patinets.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Donors.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Trasfer.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        dashbord.Show()

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MessageBox.Show("Do you wont close this now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Ok see you as soon .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Me.Hide()
        End If
    End Sub
  
End Class