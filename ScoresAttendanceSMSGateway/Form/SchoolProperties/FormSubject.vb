Public Class FormSubject
    Private Sub MstSubjectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstSubjectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstSubjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetClassProperties)

    End Sub

    Private Sub FormSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetClassProperties.mstSubject' table. You can move, or remove it, as needed.
        Me.MstSubjectTableAdapter.Fill(Me.DataSetClassProperties.mstSubject)

    End Sub
End Class