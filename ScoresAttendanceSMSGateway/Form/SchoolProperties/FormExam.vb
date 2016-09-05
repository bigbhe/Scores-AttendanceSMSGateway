Public Class FormExam
    Private Sub MstExamBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstExamBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstExamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetClassProperties)

    End Sub

    Private Sub FormExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetClassProperties.mstExam' table. You can move, or remove it, as needed.
        Me.MstExamTableAdapter.Fill(Me.DataSetClassProperties.mstExam)

    End Sub
End Class