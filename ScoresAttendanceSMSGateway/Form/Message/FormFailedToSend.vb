Public Class FormFailedToSend
    Private Sub OzekimessageoutFailedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OzekimessageoutFailedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetMessage)

    End Sub

    Private Sub FormFailedToSend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMessage.ozekimessageoutFailed' table. You can move, or remove it, as needed.
        Me.OzekimessageoutFailedTableAdapter.Fill(Me.DataSetMessage.ozekimessageoutFailed)
        GridView1.BestFitColumns(True)
    End Sub
End Class