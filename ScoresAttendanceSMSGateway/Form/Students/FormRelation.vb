Public Class FormRelation
    Private Sub MstRelationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstRelationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstRelationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetStudentRelation)

    End Sub

    Private Sub FormRelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetStudentRelation.mstRelation' table. You can move, or remove it, as needed.
        Me.MstRelationTableAdapter.Fill(Me.DataSetStudentRelation.mstRelation)
        Me.Text = "Relationship"
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class