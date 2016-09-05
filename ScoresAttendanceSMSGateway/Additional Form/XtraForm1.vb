Public Class XtraForm1
    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetAttendance.attendanceState' table. You can move, or remove it, as needed.
        Me.AttendanceStateTableAdapter.Fill(Me.DataSetAttendance.attendanceState)

    End Sub
End Class