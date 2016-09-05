Public Class FormSendMessage
    Private Sub FormSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMessage.ozekimessageout' table. You can move, or remove it, as needed.
        Me.OzekimessageoutTableAdapter.Fill(Me.DataSetMessage.ozekimessageout)
        GridView1.BestFitColumns(True)
    End Sub
End Class