Public Class FormMessageSending
    Private Sub FormMessageSending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMessage.ozekimessageoutSending' table. You can move, or remove it, as needed.
        Me.OzekimessageoutSendingTableAdapter.Fill(Me.DataSetMessage.ozekimessageoutSending)
        GridView1.BestFitColumns(True)
    End Sub
End Class