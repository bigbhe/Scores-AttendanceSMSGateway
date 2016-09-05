Imports DevExpress.XtraGrid.Views.Base

Public Class FormExamHeader
    Private Sub ExamHeaderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ExamHeaderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ExamHeaderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetExam)

    End Sub

    Private Sub FormExamHeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMapping.mstSubject' table. You can move, or remove it, as needed.
        Me.MstSubjectTableAdapter.Fill(Me.DataSetMapping.mstSubject)
        'TODO: This line of code loads data into the 'DataSetClassProperties.mstExam' table. You can move, or remove it, as needed.
        Me.MstExamTableAdapter.Fill(Me.DataSetClassProperties.mstExam)
        'TODO: This line of code loads data into the 'DataSetMapping.mstClass' table. You can move, or remove it, as needed.
        Me.MstClassTableAdapter.Fill(Me.DataSetMapping.mstClass)
        'TODO: This line of code loads data into the 'DataSetExam.examHeader' table. You can move, or remove it, as needed.
        Me.ExamHeaderTableAdapter.Fill(Me.DataSetExam.examHeader)
        buttonFill.Text = "Fill Exam Detail Data"
    End Sub


    Private Sub buttonFill_Click(sender As Object, e As EventArgs) Handles buttonFill.Click
        oClassExam.idClass = CInt(GridView1.GetFocusedRowCellValue(colidClass))
        oClassExam.idHeader = CInt(GridView1.GetFocusedRowCellValue(colid))
        oClassExam.className = GridView1.GetFocusedRowCellDisplayText(colidClass)
        oClassExam.subject = GridView1.GetFocusedRowCellDisplayText(colidSubject)
        oClassExam.examName = GridView1.GetFocusedRowCellDisplayText(colidExam)
        FormExamDetail.ShowDialog()

    End Sub
End Class