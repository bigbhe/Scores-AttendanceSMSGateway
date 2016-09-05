<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAttendanceList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAttendanceList))
        Me.DataSetAttendance = New ScoresAttendanceSMSGateway.DataSetAttendance()
        Me.AttendanceHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceHeaderTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.attendanceHeaderTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.TableAdapterManager()
        Me.AttendanceHeaderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AttendanceHeaderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AttendanceHeaderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colidClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colstartTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colendTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idSubjectLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.idClassLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.startTimeDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.endTimeDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidSubject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidClass = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForstartTime = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForendTime = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstSubjectTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.mstSubjectTableAdapter()
        Me.MstClassTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.mstClassTableAdapter()
        CType(Me.DataSetAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendanceHeaderBindingNavigator.SuspendLayout()
        CType(Me.AttendanceHeaderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idSubjectLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idClassLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startTimeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endTimeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForstartTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForendTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetAttendance
        '
        Me.DataSetAttendance.DataSetName = "DataSetAttendance"
        Me.DataSetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceHeaderBindingSource
        '
        Me.AttendanceHeaderBindingSource.DataMember = "attendanceHeader"
        Me.AttendanceHeaderBindingSource.DataSource = Me.DataSetAttendance
        '
        'AttendanceHeaderTableAdapter
        '
        Me.AttendanceHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendanceDetailTableAdapter = Nothing
        Me.TableAdapterManager.attendanceHeaderTableAdapter = Me.AttendanceHeaderTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AttendanceHeaderBindingNavigator
        '
        Me.AttendanceHeaderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AttendanceHeaderBindingNavigator.BindingSource = Me.AttendanceHeaderBindingSource
        Me.AttendanceHeaderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AttendanceHeaderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AttendanceHeaderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AttendanceHeaderBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.AttendanceHeaderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AttendanceHeaderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AttendanceHeaderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AttendanceHeaderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AttendanceHeaderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AttendanceHeaderBindingNavigator.Name = "AttendanceHeaderBindingNavigator"
        Me.AttendanceHeaderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AttendanceHeaderBindingNavigator.Size = New System.Drawing.Size(815, 25)
        Me.AttendanceHeaderBindingNavigator.TabIndex = 0
        Me.AttendanceHeaderBindingNavigator.Text = "BindingNavigator1"
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
        'AttendanceHeaderBindingNavigatorSaveItem
        '
        Me.AttendanceHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AttendanceHeaderBindingNavigatorSaveItem.Image = CType(resources.GetObject("AttendanceHeaderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AttendanceHeaderBindingNavigatorSaveItem.Name = "AttendanceHeaderBindingNavigatorSaveItem"
        Me.AttendanceHeaderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AttendanceHeaderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripButton1.Text = "Fill List Of Attendance"
        '
        'AttendanceHeaderGridControl
        '
        Me.AttendanceHeaderGridControl.DataSource = Me.AttendanceHeaderBindingSource
        Me.AttendanceHeaderGridControl.Location = New System.Drawing.Point(256, 12)
        Me.AttendanceHeaderGridControl.MainView = Me.GridView1
        Me.AttendanceHeaderGridControl.Name = "AttendanceHeaderGridControl"
        Me.AttendanceHeaderGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.AttendanceHeaderGridControl.Size = New System.Drawing.Size(547, 547)
        Me.AttendanceHeaderGridControl.TabIndex = 1
        Me.AttendanceHeaderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidSubject, Me.colidClass, Me.colstartTime, Me.colendTime})
        Me.GridView1.GridControl = Me.AttendanceHeaderGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidSubject
        '
        Me.colidSubject.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidSubject.FieldName = "idSubject"
        Me.colidSubject.Name = "colidSubject"
        Me.colidSubject.Visible = True
        Me.colidSubject.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstSubjectBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "subject"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstSubjectBindingSource
        '
        Me.MstSubjectBindingSource.DataMember = "mstSubject"
        Me.MstSubjectBindingSource.DataSource = Me.DataSetAttendance
        '
        'colidClass
        '
        Me.colidClass.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidClass.FieldName = "idClass"
        Me.colidClass.Name = "colidClass"
        Me.colidClass.Visible = True
        Me.colidClass.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.MstClassBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Class"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'MstClassBindingSource
        '
        Me.MstClassBindingSource.DataMember = "mstClass"
        Me.MstClassBindingSource.DataSource = Me.DataSetAttendance
        '
        'colstartTime
        '
        Me.colstartTime.FieldName = "startTime"
        Me.colstartTime.Name = "colstartTime"
        Me.colstartTime.Visible = True
        Me.colstartTime.VisibleIndex = 2
        '
        'colendTime
        '
        Me.colendTime.FieldName = "endTime"
        Me.colendTime.Name = "colendTime"
        Me.colendTime.Visible = True
        Me.colendTime.VisibleIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.AttendanceHeaderGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idSubjectLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idClassLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.startTimeDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.endTimeDateEdit)
        Me.DataLayoutControl1.DataSource = Me.AttendanceHeaderBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(815, 571)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idSubjectLookUpEdit
        '
        Me.idSubjectLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceHeaderBindingSource, "idSubject", True))
        Me.idSubjectLookUpEdit.Location = New System.Drawing.Point(63, 12)
        Me.idSubjectLookUpEdit.Name = "idSubjectLookUpEdit"
        Me.idSubjectLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSubjectLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSubjectLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSubjectLookUpEdit.Properties.DataSource = Me.MstSubjectBindingSource
        Me.idSubjectLookUpEdit.Properties.DisplayMember = "subject"
        Me.idSubjectLookUpEdit.Properties.NullText = ""
        Me.idSubjectLookUpEdit.Properties.ValueMember = "id"
        Me.idSubjectLookUpEdit.Size = New System.Drawing.Size(189, 20)
        Me.idSubjectLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idSubjectLookUpEdit.TabIndex = 4
        '
        'idClassLookUpEdit
        '
        Me.idClassLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceHeaderBindingSource, "idClass", True))
        Me.idClassLookUpEdit.Location = New System.Drawing.Point(63, 36)
        Me.idClassLookUpEdit.Name = "idClassLookUpEdit"
        Me.idClassLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idClassLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idClassLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idClassLookUpEdit.Properties.DataSource = Me.MstClassBindingSource
        Me.idClassLookUpEdit.Properties.DisplayMember = "Class"
        Me.idClassLookUpEdit.Properties.NullText = ""
        Me.idClassLookUpEdit.Properties.ValueMember = "id"
        Me.idClassLookUpEdit.Size = New System.Drawing.Size(189, 20)
        Me.idClassLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idClassLookUpEdit.TabIndex = 5
        '
        'startTimeDateEdit
        '
        Me.startTimeDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceHeaderBindingSource, "startTime", True))
        Me.startTimeDateEdit.EditValue = Nothing
        Me.startTimeDateEdit.Location = New System.Drawing.Point(63, 60)
        Me.startTimeDateEdit.Name = "startTimeDateEdit"
        Me.startTimeDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.startTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.startTimeDateEdit.Properties.Mask.EditMask = "f"
        Me.startTimeDateEdit.Size = New System.Drawing.Size(189, 20)
        Me.startTimeDateEdit.StyleController = Me.DataLayoutControl1
        Me.startTimeDateEdit.TabIndex = 6
        '
        'endTimeDateEdit
        '
        Me.endTimeDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceHeaderBindingSource, "endTime", True))
        Me.endTimeDateEdit.EditValue = Nothing
        Me.endTimeDateEdit.Location = New System.Drawing.Point(63, 84)
        Me.endTimeDateEdit.Name = "endTimeDateEdit"
        Me.endTimeDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.endTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.endTimeDateEdit.Properties.Mask.EditMask = "f"
        Me.endTimeDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.endTimeDateEdit.Size = New System.Drawing.Size(189, 20)
        Me.endTimeDateEdit.StyleController = Me.DataLayoutControl1
        Me.endTimeDateEdit.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(815, 571)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidSubject, Me.ItemForidClass, Me.ItemForstartTime, Me.ItemForendTime, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(795, 551)
        '
        'ItemForidSubject
        '
        Me.ItemForidSubject.Control = Me.idSubjectLookUpEdit
        Me.ItemForidSubject.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidSubject.Name = "ItemForidSubject"
        Me.ItemForidSubject.Size = New System.Drawing.Size(244, 24)
        Me.ItemForidSubject.Text = "id Subject"
        Me.ItemForidSubject.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForidClass
        '
        Me.ItemForidClass.Control = Me.idClassLookUpEdit
        Me.ItemForidClass.Location = New System.Drawing.Point(0, 24)
        Me.ItemForidClass.Name = "ItemForidClass"
        Me.ItemForidClass.Size = New System.Drawing.Size(244, 24)
        Me.ItemForidClass.Text = "id Class"
        Me.ItemForidClass.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForstartTime
        '
        Me.ItemForstartTime.Control = Me.startTimeDateEdit
        Me.ItemForstartTime.Location = New System.Drawing.Point(0, 48)
        Me.ItemForstartTime.Name = "ItemForstartTime"
        Me.ItemForstartTime.Size = New System.Drawing.Size(244, 24)
        Me.ItemForstartTime.Text = "start Time"
        Me.ItemForstartTime.TextSize = New System.Drawing.Size(48, 13)
        '
        'ItemForendTime
        '
        Me.ItemForendTime.Control = Me.endTimeDateEdit
        Me.ItemForendTime.Location = New System.Drawing.Point(0, 72)
        Me.ItemForendTime.Name = "ItemForendTime"
        Me.ItemForendTime.Size = New System.Drawing.Size(244, 479)
        Me.ItemForendTime.Text = "end Time"
        Me.ItemForendTime.TextSize = New System.Drawing.Size(48, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AttendanceHeaderGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(244, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(551, 551)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'MstSubjectTableAdapter
        '
        Me.MstSubjectTableAdapter.ClearBeforeFill = True
        '
        'MstClassTableAdapter
        '
        Me.MstClassTableAdapter.ClearBeforeFill = True
        '
        'FormAttendanceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 596)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.AttendanceHeaderBindingNavigator)
        Me.Name = "FormAttendanceList"
        Me.Text = "FormAttendanceList"
        CType(Me.DataSetAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendanceHeaderBindingNavigator.ResumeLayout(False)
        Me.AttendanceHeaderBindingNavigator.PerformLayout()
        CType(Me.AttendanceHeaderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idSubjectLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idClassLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startTimeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endTimeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endTimeDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidSubject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForstartTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForendTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetAttendance As DataSetAttendance
    Friend WithEvents AttendanceHeaderBindingSource As BindingSource
    Friend WithEvents AttendanceHeaderTableAdapter As DataSetAttendanceTableAdapters.attendanceHeaderTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAttendanceTableAdapters.TableAdapterManager
    Friend WithEvents AttendanceHeaderBindingNavigator As BindingNavigator
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
    Friend WithEvents AttendanceHeaderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AttendanceHeaderGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidSubject As XtraGrid.Columns.GridColumn
    Friend WithEvents colidClass As XtraGrid.Columns.GridColumn
    Friend WithEvents colstartTime As XtraGrid.Columns.GridColumn
    Friend WithEvents colendTime As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idSubjectLookUpEdit As LookUpEdit
    Friend WithEvents idClassLookUpEdit As LookUpEdit
    Friend WithEvents startTimeDateEdit As DateEdit
    Friend WithEvents endTimeDateEdit As DateEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidSubject As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidClass As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForstartTime As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForendTime As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents MstSubjectBindingSource As BindingSource
    Friend WithEvents MstSubjectTableAdapter As DataSetAttendanceTableAdapters.mstSubjectTableAdapter
    Friend WithEvents MstClassBindingSource As BindingSource
    Friend WithEvents MstClassTableAdapter As DataSetAttendanceTableAdapters.mstClassTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
