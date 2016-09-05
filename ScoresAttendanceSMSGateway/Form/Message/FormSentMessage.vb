Public Class FormSentMessage
    Private Sub FormSentMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMessage.ozekimessageoutSent' table. You can move, or remove it, as needed.
        Me.OzekimessageoutSentTableAdapter.Fill(Me.DataSetMessage.ozekimessageoutSent)
        GridView1.BestFitColumns(True)
    End Sub
End Class