Public Class FormAttendanceState
    Private Sub AttendanceStateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceStateBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendanceStateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetClassProperties)

    End Sub

    Private Sub FormAttendanceState_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetClassProperties.attendanceState' table. You can move, or remove it, as needed.
        Me.AttendanceStateTableAdapter.Fill(Me.DataSetClassProperties.attendanceState)

    End Sub
End Class