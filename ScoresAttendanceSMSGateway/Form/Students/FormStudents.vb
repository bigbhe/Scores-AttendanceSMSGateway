Public Class FormStudents
    Public isActive As Boolean

    Private Sub MstStudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstStudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstStudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetStudentRelation)

    End Sub

    Sub LoadData()
        Try
            Me.MstStudentTableAdapter.Fill(Me.DataSetStudentRelation.mstStudent, New System.Nullable(Of Boolean)(CType(isActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetStudentRelation.mstRelation' table. You can move, or remove it, as needed.
        Me.MstRelationTableAdapter.Fill(Me.DataSetStudentRelation.mstRelation)
        isActive = True
        LoadData()
        GridView1.BestFitColumns(True)
    End Sub

    Private Sub checkEditInactive_EditValueChanged(sender As Object, e As EventArgs) Handles checkEditInactive.EditValueChanged
        If checkEditInactive.CheckState = CheckState.Checked Then
            isActive = False
            LoadData()
            lcg6.Text = "List Of Inactive Student"
        Else
            isActive = True
            LoadData()
            lcg6.Text = "List Of Active Student"
        End If
    End Sub
End Class