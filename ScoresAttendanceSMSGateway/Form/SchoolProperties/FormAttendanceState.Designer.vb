<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAttendanceState
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAttendanceState))
        Me.DataSetClassProperties = New ScoresAttendanceSMSGateway.DataSetClassProperties()
        Me.AttendanceStateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceStateTableAdapter = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.attendanceStateTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager()
        Me.AttendanceStateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AttendanceStateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AttendanceStateGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmessageFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisMessageSend = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.stateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForstate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.messageFormatTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemFormessageFormat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.isMessageSendCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForisMessageSend = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceStateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceStateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendanceStateBindingNavigator.SuspendLayout()
        CType(Me.AttendanceStateGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForstate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.messageFormatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFormessageFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isMessageSendCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisMessageSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetClassProperties
        '
        Me.DataSetClassProperties.DataSetName = "DataSetClassProperties"
        Me.DataSetClassProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceStateBindingSource
        '
        Me.AttendanceStateBindingSource.DataMember = "attendanceState"
        Me.AttendanceStateBindingSource.DataSource = Me.DataSetClassProperties
        '
        'AttendanceStateTableAdapter
        '
        Me.AttendanceStateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendanceStateTableAdapter = Me.AttendanceStateTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstClassTableAdapter = Nothing
        Me.TableAdapterManager.mstExamTableAdapter = Nothing
        Me.TableAdapterManager.mstNationalHolidayTableAdapter = Nothing
        Me.TableAdapterManager.mstSubjectTableAdapter = Nothing
        Me.TableAdapterManager.mstTeacherTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.AttendanceStateBindingNavigator.Size = New System.Drawing.Size(546, 25)
        Me.AttendanceStateBindingNavigator.TabIndex = 0
        Me.AttendanceStateBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AttendanceStateBindingNavigatorSaveItem
        '
        Me.AttendanceStateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AttendanceStateBindingNavigatorSaveItem.Image = CType(resources.GetObject("AttendanceStateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AttendanceStateBindingNavigatorSaveItem.Name = "AttendanceStateBindingNavigatorSaveItem"
        Me.AttendanceStateBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AttendanceStateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AttendanceStateGridControl
        '
        Me.AttendanceStateGridControl.DataSource = Me.AttendanceStateBindingSource
        Me.AttendanceStateGridControl.Location = New System.Drawing.Point(12, 83)
        Me.AttendanceStateGridControl.MainView = Me.GridView1
        Me.AttendanceStateGridControl.Name = "AttendanceStateGridControl"
        Me.AttendanceStateGridControl.Size = New System.Drawing.Size(522, 448)
        Me.AttendanceStateGridControl.TabIndex = 4
        Me.AttendanceStateGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colstate, Me.colmessageFormat, Me.colisMessageSend})
        Me.GridView1.GridControl = Me.AttendanceStateGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colstate
        '
        Me.colstate.FieldName = "state"
        Me.colstate.Name = "colstate"
        Me.colstate.Visible = True
        Me.colstate.VisibleIndex = 0
        '
        'colmessageFormat
        '
        Me.colmessageFormat.FieldName = "messageFormat"
        Me.colmessageFormat.Name = "colmessageFormat"
        Me.colmessageFormat.Visible = True
        Me.colmessageFormat.VisibleIndex = 1
        '
        'colisMessageSend
        '
        Me.colisMessageSend.FieldName = "isMessageSend"
        Me.colisMessageSend.Name = "colisMessageSend"
        Me.colisMessageSend.Visible = True
        Me.colisMessageSend.VisibleIndex = 2
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.AttendanceStateGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.stateTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.messageFormatTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isMessageSendCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.AttendanceStateBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(546, 543)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(546, 543)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForstate, Me.ItemFormessageFormat, Me.ItemForisMessageSend, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(526, 523)
        '
        'stateTextEdit
        '
        Me.stateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceStateBindingSource, "state", True))
        Me.stateTextEdit.Location = New System.Drawing.Point(95, 12)
        Me.stateTextEdit.Name = "stateTextEdit"
        Me.stateTextEdit.Size = New System.Drawing.Size(439, 20)
        Me.stateTextEdit.StyleController = Me.DataLayoutControl1
        Me.stateTextEdit.TabIndex = 0
        '
        'ItemForstate
        '
        Me.ItemForstate.Control = Me.stateTextEdit
        Me.ItemForstate.Location = New System.Drawing.Point(0, 0)
        Me.ItemForstate.Name = "ItemForstate"
        Me.ItemForstate.Size = New System.Drawing.Size(526, 24)
        Me.ItemForstate.Text = "state"
        Me.ItemForstate.TextSize = New System.Drawing.Size(79, 13)
        '
        'messageFormatTextEdit
        '
        Me.messageFormatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceStateBindingSource, "messageFormat", True))
        Me.messageFormatTextEdit.Location = New System.Drawing.Point(95, 36)
        Me.messageFormatTextEdit.Name = "messageFormatTextEdit"
        Me.messageFormatTextEdit.Size = New System.Drawing.Size(439, 20)
        Me.messageFormatTextEdit.StyleController = Me.DataLayoutControl1
        Me.messageFormatTextEdit.TabIndex = 2
        '
        'ItemFormessageFormat
        '
        Me.ItemFormessageFormat.Control = Me.messageFormatTextEdit
        Me.ItemFormessageFormat.Location = New System.Drawing.Point(0, 24)
        Me.ItemFormessageFormat.Name = "ItemFormessageFormat"
        Me.ItemFormessageFormat.Size = New System.Drawing.Size(526, 24)
        Me.ItemFormessageFormat.Text = "message Format"
        Me.ItemFormessageFormat.TextSize = New System.Drawing.Size(79, 13)
        '
        'isMessageSendCheckEdit
        '
        Me.isMessageSendCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceStateBindingSource, "isMessageSend", True))
        Me.isMessageSendCheckEdit.Location = New System.Drawing.Point(95, 60)
        Me.isMessageSendCheckEdit.Name = "isMessageSendCheckEdit"
        Me.isMessageSendCheckEdit.Properties.Caption = "is Message Send"
        Me.isMessageSendCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isMessageSendCheckEdit.Size = New System.Drawing.Size(439, 19)
        Me.isMessageSendCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isMessageSendCheckEdit.TabIndex = 3
        '
        'ItemForisMessageSend
        '
        Me.ItemForisMessageSend.Control = Me.isMessageSendCheckEdit
        Me.ItemForisMessageSend.Location = New System.Drawing.Point(0, 48)
        Me.ItemForisMessageSend.Name = "ItemForisMessageSend"
        Me.ItemForisMessageSend.Size = New System.Drawing.Size(526, 23)
        Me.ItemForisMessageSend.Text = "is Message Send"
        Me.ItemForisMessageSend.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AttendanceStateGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 71)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(526, 452)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FormAttendanceState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 568)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.AttendanceStateBindingNavigator)
        Me.Name = "FormAttendanceState"
        Me.Text = "FormAttendanceState"
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceStateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceStateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendanceStateBindingNavigator.ResumeLayout(False)
        Me.AttendanceStateBindingNavigator.PerformLayout()
        CType(Me.AttendanceStateGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForstate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.messageFormatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFormessageFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isMessageSendCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisMessageSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetClassProperties As DataSetClassProperties
    Friend WithEvents AttendanceStateBindingSource As BindingSource
    Friend WithEvents AttendanceStateTableAdapter As DataSetClassPropertiesTableAdapters.attendanceStateTableAdapter
    Friend WithEvents TableAdapterManager As DataSetClassPropertiesTableAdapters.TableAdapterManager
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
    Friend WithEvents colmessageFormat As XtraGrid.Columns.GridColumn
    Friend WithEvents colisMessageSend As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents stateTextEdit As TextEdit
    Friend WithEvents messageFormatTextEdit As TextEdit
    Friend WithEvents isMessageSendCheckEdit As CheckEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForstate As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFormessageFormat As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisMessageSend As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
End Class
