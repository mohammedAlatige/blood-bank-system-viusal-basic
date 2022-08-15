Public Class dashbord


    Private Sub AliToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub DonorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DonorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloadbakDataSet)

    End Sub

    Private Sub dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloadbakDataSet.Patinets' table. You can move, or remove it, as needed.
        Me.PatinetsTableAdapter.Fill(Me.BloadbakDataSet.Patinets)
        'TODO: This line of code loads data into the 'BloadbakDataSet.Donors' table. You can move, or remove it, as needed.
        Me.DonorsTableAdapter.Fill(Me.BloadbakDataSet.Donors)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Donors.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Trasfer.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        donate.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        patinets.Show()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If MessageBox.Show("Do You Wont Close This Now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Ok See you Soon .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Me.Close()

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MessageBox.Show("Do You Wont Close This Now ?", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Ok See you Soon .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Me.Close()

        End If

    End Sub
End Class
