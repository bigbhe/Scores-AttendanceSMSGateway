Public Class FormHoliday
    Private Sub MstNationalHolidayBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstNationalHolidayBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstNationalHolidayBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetClassProperties)

    End Sub

    Private Sub FormHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetClassProperties.mstNationalHoliday' table. You can move, or remove it, as needed.
        Me.MstNationalHolidayTableAdapter.Fill(Me.DataSetClassProperties.mstNationalHoliday)

    End Sub
End Class