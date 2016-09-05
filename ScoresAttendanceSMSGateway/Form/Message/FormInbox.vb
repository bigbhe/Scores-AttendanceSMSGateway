Public Class FormInbox
    Private Sub FormInbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMessage.ozekimessagein' table. You can move, or remove it, as needed.
        Me.OzekimessageinTableAdapter.Fill(Me.DataSetMessage.ozekimessagein)
        GridView1.BestFitColumns(True)

    End Sub
End Class