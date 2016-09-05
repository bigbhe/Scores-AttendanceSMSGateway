Imports DevExpress.XtraGrid.Views.Grid

Public Class FormExamDetail
    Private Sub ExamDetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ExamDetailBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ExamDetailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetExam)

    End Sub
    Sub LoadDataHeader()
        Try
            Me.ExamDetailTableAdapter.Fill(Me.DataSetExam.examDetail, CType(oClassExam.idHeader, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LoadStudentForExam()
        Try
            Me.StudentForExamTableAdapter.Fill(Me.DataSetExam.studentForExam, CType(oClassExam.idClass, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormExamDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSetExam.mstStudent' table. You can move, or remove it, as needed.
        Me.MstStudentTableAdapter.Fill(Me.DataSetExam.mstStudent)
        LoadDataHeader()
        LoadStudentForExam()
        labelNote.Text = "Class: " & oClassExam.className & vbNewLine & "Subject: " & oClassExam.subject & vbNewLine & "Exam Name: " & oClassExam.examName
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidHeader, oClassExam.idHeader)
    End Sub
End Class