Imports DevExpress.XtraGrid.Views.Base

Public Class FormAttendanceList
    Private Sub AttendanceHeaderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceHeaderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendanceHeaderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAttendance)

    End Sub

    Private Sub FormAttendanceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetAttendance.mstClass' table. You can move, or remove it, as needed.
        Me.MstClassTableAdapter.Fill(Me.DataSetAttendance.mstClass)
        'TODO: This line of code loads data into the 'DataSetAttendance.mstSubject' table. You can move, or remove it, as needed.
        Me.MstSubjectTableAdapter.Fill(Me.DataSetAttendance.mstSubject)
        'TODO: This line of code loads data into the 'DataSetAttendance.attendanceHeader' table. You can move, or remove it, as needed.
        Me.AttendanceHeaderTableAdapter.Fill(Me.DataSetAttendance.attendanceHeader)

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        oClassAttendance.idClass = CInt(GridView1.GetFocusedRowCellValue(colidClass))
        oClassAttendance.idHeader = CInt(GridView1.GetFocusedRowCellValue(colid))
        oClassAttendance.subjectName = GridView1.GetFocusedRowCellDisplayText(colidSubject)
        oClassAttendance.className = GridView1.GetFocusedRowCellDisplayText(colidClass)
        FormAttendanceDetail.ShowDialog()

    End Sub
End Class