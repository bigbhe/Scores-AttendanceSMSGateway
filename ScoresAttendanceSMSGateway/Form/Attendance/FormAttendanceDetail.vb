Imports DevExpress.XtraGrid.Views.Grid

Public Class FormAttendanceDetail
    Private Sub AttendanceDetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceDetailBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.AttendanceDetailBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetAttendance)
        Catch ex As Exception
            uniqueAlert(Me, ex.ToString)

        End Try


    End Sub

    Private Sub LoadData()
        Try
            Me.AttendanceDetailTableAdapter.Fill(Me.DataSetAttendance.attendanceDetail, CType(oClassAttendance.idHeader, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormAttendanceDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetAttendance.mstStudent' table. You can move, or remove it, as needed.
        Me.MstStudentTableAdapter.Fill(Me.DataSetAttendance.mstStudent)
        'TODO: This line of code loads data into the 'DataSetAttendance.attendanceState' table. You can move, or remove it, as needed.
        Me.AttendanceStateTableAdapter.Fill(Me.DataSetAttendance.attendanceState)
        LoadAttendanceStudent()
        LoadData()
        Me.AttendanceStateTableAdapter.Fill(Me.DataSetAttendance.attendanceState)
        labelInfo.Text = "Fill Attendance Detail For Subject: " & oClassAttendance.subjectName & vbNewLine & "And Class: " & oClassAttendance.className
    End Sub
    Private Sub LoadAttendanceStudent()

        Try
            Me.StudentForAttendanceTableAdapter.Fill(Me.DataSetAttendance.studentForAttendance, CType(oClassAttendance.idClass, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidAttendanceHeader, oClassAttendance.idHeader)
    End Sub
End Class