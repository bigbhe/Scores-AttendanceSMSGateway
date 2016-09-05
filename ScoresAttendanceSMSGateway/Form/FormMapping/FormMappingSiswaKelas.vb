Public Class FormMappingStudentClass
    Private Sub MappingStudentAndClassBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MappingStudentAndClassBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MappingStudentAndClassBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetMapping)

    End Sub

    Private Sub FormMappingSiswaKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMapping.mstClass' table. You can move, or remove it, as needed.
        Me.MstClassTableAdapter.Fill(Me.DataSetMapping.mstClass)
        'TODO: This line of code loads data into the 'DataSetMapping.mstStudent' table. You can move, or remove it, as needed.
        Me.MstStudentTableAdapter.Fill(Me.DataSetMapping.mstStudent)
        'TODO: This line of code loads data into the 'DataSetMapping.mappingStudentAndClass' table. You can move, or remove it, as needed.
        Me.MappingStudentAndClassTableAdapter.Fill(Me.DataSetMapping.mappingStudentAndClass)

    End Sub
End Class