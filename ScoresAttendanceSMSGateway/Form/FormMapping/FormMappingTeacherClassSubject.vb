Public Class FormMappingTeacherClassSubject
    Private Sub MappingTeacherClassSubjectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MappingTeacherClassSubjectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MappingTeacherClassSubjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetMapping)

    End Sub

    Private Sub FormMappingTeacherClassSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMapping.mstTeacher' table. You can move, or remove it, as needed.
        Me.MstTeacherTableAdapter.Fill(Me.DataSetMapping.mstTeacher)
        'TODO: This line of code loads data into the 'DataSetMapping.mstSubject' table. You can move, or remove it, as needed.
        Me.MstSubjectTableAdapter.Fill(Me.DataSetMapping.mstSubject)
        'TODO: This line of code loads data into the 'DataSetMapping.mstClass' table. You can move, or remove it, as needed.
        Me.MstClassTableAdapter.Fill(Me.DataSetMapping.mstClass)
        'TODO: This line of code loads data into the 'DataSetMapping.mappingTeacherClassSubject' table. You can move, or remove it, as needed.
        Me.MappingTeacherClassSubjectTableAdapter.Fill(Me.DataSetMapping.mappingTeacherClassSubject)

    End Sub
End Class