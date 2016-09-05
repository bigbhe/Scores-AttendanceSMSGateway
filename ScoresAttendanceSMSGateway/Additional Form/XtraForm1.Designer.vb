<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraForm1
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraForm1))
        Me.DataSetAttendance = New ScoresAttendanceSMSGateway.DataSetAttendance()
        Me.AttendanceStateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceStateTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.attendanceStateTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.TableAdapterManager()
        Me.AttendanceStateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AttendanceStateGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.AttendanceStateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceStateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceStateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendanceStateBindingNavigator.SuspendLayout()
        CType(Me.AttendanceStateGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetAttendance
        '
        Me.DataSetAttendance.DataSetName = "DataSetAttendance"
        Me.DataSetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceStateBindingSource
        '
        Me.AttendanceStateBindingSource.DataMember = "attendanceState"
        Me.AttendanceStateBindingSource.DataSource = Me.DataSetAttendance
        '
        'AttendanceStateTableAdapter
        '
        Me.AttendanceStateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendanceDetailTableAdapter = Nothing
        Me.TableAdapterManager.attendanceHeaderTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AttendanceStateBindingNavigator
        '
        Me.AttendanceStateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AttendanceStateBindingNavigator.BindingSource = Me.AttendanceStateBindingSource
        Me.AttendanceStateBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AttendanceStateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AttendanceStateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AttendanceStateBindingNavigatorSaveItem})
        Me.AttendanceStateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AttendanceStateBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AttendanceStateBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AttendanceStateBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AttendanceStateBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AttendanceStateBindingNavigator.Name = "AttendanceStateBindingNavigator"
        Me.AttendanceStateBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AttendanceStateBindingNavigator.Size = New System.Drawing.Size(423, 25)
        Me.AttendanceStateBindingNavigator.TabIndex = 0
        Me.AttendanceStateBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AttendanceStateGridControl
        '
        Me.AttendanceStateGridControl.DataSource = Me.AttendanceStateBindingSource
        Me.AttendanceStateGridControl.Location = New System.Drawing.Point(103, 72)
        Me.AttendanceStateGridControl.MainView = Me.GridView1
        Me.AttendanceStateGridControl.Name = "AttendanceStateGridControl"
        Me.AttendanceStateGridControl.Size = New System.Drawing.Size(300, 220)
        Me.AttendanceStateGridControl.TabIndex = 1
        Me.AttendanceStateGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colstate})
        Me.GridView1.GridControl = Me.AttendanceStateGridControl
        Me.GridView1.Name = "GridView1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'AttendanceStateBindingNavigatorSaveItem
        '
        Me.AttendanceStateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AttendanceStateBindingNavigatorSaveItem.Enabled = False
        Me.AttendanceStateBindingNavigatorSaveItem.Image = CType(resources.GetObject("AttendanceStateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AttendanceStateBindingNavigatorSaveItem.Name = "AttendanceStateBindingNavigatorSaveItem"
        Me.AttendanceStateBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AttendanceStateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colstate
        '
        Me.colstate.FieldName = "state"
        Me.colstate.Name = "colstate"
        Me.colstate.Visible = True
        Me.colstate.VisibleIndex = 1
        '
        'XtraForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 312)
        Me.Controls.Add(Me.AttendanceStateGridControl)
        Me.Controls.Add(Me.AttendanceStateBindingNavigator)
        Me.Name = "XtraForm1"
        Me.Text = "XtraForm1"
        CType(Me.DataSetAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceStateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceStateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendanceStateBindingNavigator.ResumeLayout(False)
        Me.AttendanceStateBindingNavigator.PerformLayout()
        CType(Me.AttendanceStateGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetAttendance As DataSetAttendance
    Friend WithEvents AttendanceStateBindingSource As BindingSource
    Friend WithEvents AttendanceStateTableAdapter As DataSetAttendanceTableAdapters.attendanceStateTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAttendanceTableAdapters.TableAdapterManager
    Friend WithEvents AttendanceStateBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AttendanceStateBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AttendanceStateGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colstate As XtraGrid.Columns.GridColumn
End Class
