Imports DevExpress.XtraGrid.Views.Grid

Public Class FormTeacher
    Private Sub MstTeacherBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstTeacherBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstTeacherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetClassProperties)

    End Sub

    Private Sub FormTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetClassProperties.mstTeacher' table. You can move, or remove it, as needed.
        Me.MstTeacherTableAdapter.Fill(Me.DataSetClassProperties.mstTeacher)

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colregistrationNumber, getDateString() & GetUniqueKey(3))
    End Sub
End Class