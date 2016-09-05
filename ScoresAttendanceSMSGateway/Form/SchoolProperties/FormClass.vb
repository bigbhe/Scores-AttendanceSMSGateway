Public Class FormClass
    Private Sub MstClassBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstClassBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstClassBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetClassProperties)

    End Sub

    Private Sub FormClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetClassProperties.mstClass' table. You can move, or remove it, as needed.
        Me.MstClassTableAdapter.Fill(Me.DataSetClassProperties.mstClass)

    End Sub
End Class