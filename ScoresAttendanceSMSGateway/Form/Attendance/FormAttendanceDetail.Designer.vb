<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAttendanceDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAttendanceDetail))
        Me.DataSetAttendance = New ScoresAttendanceSMSGateway.DataSetAttendance()
        Me.AttendanceDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceDetailTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.attendanceDetailTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.TableAdapterManager()
        Me.AttendanceDetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AttendanceDetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AttendanceDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidAttendanceHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidStudent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colremarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.AttendanceStateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceStateTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.attendanceStateTableAdapter()
        Me.MstStudentTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.mstStudentTableAdapter()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idStudentLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.StudentForAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.remarksLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidStudent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForremarks = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StudentForAttendanceTableAdapter = New ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.studentForAttendanceTableAdapter()
        Me.labelInfo = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceDetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendanceDetailBindingNavigator.SuspendLayout()
        CType(Me.AttendanceDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceStateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idStudentLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentForAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.remarksLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForremarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetAttendance
        '
        Me.DataSetAttendance.DataSetName = "DataSetAttendance"
        Me.DataSetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceDetailBindingSource
        '
        Me.AttendanceDetailBindingSource.DataMember = "attendanceDetail"
        Me.AttendanceDetailBindingSource.DataSource = Me.DataSetAttendance
        '
        'AttendanceDetailTableAdapter
        '
        Me.AttendanceDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendanceDetailTableAdapter = Me.AttendanceDetailTableAdapter
        Me.TableAdapterManager.attendanceHeaderTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetAttendanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AttendanceDetailBindingNavigator
        '
        Me.AttendanceDetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AttendanceDetailBindingNavigator.BindingSource = Me.AttendanceDetailBindingSource
        Me.AttendanceDetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AttendanceDetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AttendanceDetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AttendanceDetailBindingNavigatorSaveItem})
        Me.AttendanceDetailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AttendanceDetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AttendanceDetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AttendanceDetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AttendanceDetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AttendanceDetailBindingNavigator.Name = "AttendanceDetailBindingNavigator"
        Me.AttendanceDetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AttendanceDetailBindingNavigator.Size = New System.Drawing.Size(650, 25)
        Me.AttendanceDetailBindingNavigator.TabIndex = 0
        Me.AttendanceDetailBindingNavigator.Text = "BindingNavigator1"
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
        'AttendanceDetailBindingNavigatorSaveItem
        '
        Me.AttendanceDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AttendanceDetailBindingNavigatorSaveItem.Image = CType(resources.GetObject("AttendanceDetailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AttendanceDetailBindingNavigatorSaveItem.Name = "AttendanceDetailBindingNavigatorSaveItem"
        Me.AttendanceDetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AttendanceDetailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AttendanceDetailGridControl
        '
        Me.AttendanceDetailGridControl.DataSource = Me.AttendanceDetailBindingSource
        Me.AttendanceDetailGridControl.Location = New System.Drawing.Point(12, 81)
        Me.AttendanceDetailGridControl.MainView = Me.GridView1
        Me.AttendanceDetailGridControl.Name = "AttendanceDetailGridControl"
        Me.AttendanceDetailGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.AttendanceDetailGridControl.Size = New System.Drawing.Size(626, 402)
        Me.AttendanceDetailGridControl.TabIndex = 3
        Me.AttendanceDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidAttendanceHeader, Me.colidStudent, Me.colremarks})
        Me.GridView1.GridControl = Me.AttendanceDetailGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidAttendanceHeader
        '
        Me.colidAttendanceHeader.FieldName = "idAttendanceHeader"
        Me.colidAttendanceHeader.Name = "colidAttendanceHeader"
        '
        'colidStudent
        '
        Me.colidStudent.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidStudent.FieldName = "idStudent"
        Me.colidStudent.Name = "colidStudent"
        Me.colidStudent.Visible = True
        Me.colidStudent.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstStudentBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Names"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstStudentBindingSource
        '
        Me.MstStudentBindingSource.DataMember = "mstStudent"
        Me.MstStudentBindingSource.DataSource = Me.DataSetAttendance
        '
        'colremarks
        '
        Me.colremarks.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colremarks.FieldName = "remarks"
        Me.colremarks.Name = "colremarks"
        Me.colremarks.Visible = True
        Me.colremarks.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.AttendanceStateBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "state"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
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
        'MstStudentTableAdapter
        '
        Me.MstStudentTableAdapter.ClearBeforeFill = True
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.labelInfo)
        Me.DataLayoutControl1.Controls.Add(Me.AttendanceDetailGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idStudentLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.remarksLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.AttendanceDetailBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(650, 495)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idStudentLookUpEdit
        '
        Me.idStudentLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceDetailBindingSource, "idStudent", True))
        Me.idStudentLookUpEdit.Location = New System.Drawing.Point(64, 33)
        Me.idStudentLookUpEdit.Name = "idStudentLookUpEdit"
        Me.idStudentLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idStudentLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idStudentLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idStudentLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("registrationNumber", "registration Number", 105, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Names", "Names", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idClass", "id Class", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.idStudentLookUpEdit.Properties.DataSource = Me.StudentForAttendanceBindingSource
        Me.idStudentLookUpEdit.Properties.DisplayMember = "Names"
        Me.idStudentLookUpEdit.Properties.NullText = ""
        Me.idStudentLookUpEdit.Properties.ValueMember = "id"
        Me.idStudentLookUpEdit.Size = New System.Drawing.Size(574, 20)
        Me.idStudentLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idStudentLookUpEdit.TabIndex = 0
        '
        'StudentForAttendanceBindingSource
        '
        Me.StudentForAttendanceBindingSource.DataMember = "studentForAttendance"
        Me.StudentForAttendanceBindingSource.DataSource = Me.DataSetAttendance
        '
        'remarksLookUpEdit
        '
        Me.remarksLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AttendanceDetailBindingSource, "remarks", True))
        Me.remarksLookUpEdit.Location = New System.Drawing.Point(64, 57)
        Me.remarksLookUpEdit.Name = "remarksLookUpEdit"
        Me.remarksLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.remarksLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.remarksLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.remarksLookUpEdit.Properties.DataSource = Me.AttendanceStateBindingSource
        Me.remarksLookUpEdit.Properties.DisplayMember = "state"
        Me.remarksLookUpEdit.Properties.NullText = ""
        Me.remarksLookUpEdit.Properties.ValueMember = "id"
        Me.remarksLookUpEdit.Size = New System.Drawing.Size(574, 20)
        Me.remarksLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.remarksLookUpEdit.TabIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(650, 495)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidStudent, Me.ItemForremarks, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(630, 475)
        '
        'ItemForidStudent
        '
        Me.ItemForidStudent.Control = Me.idStudentLookUpEdit
        Me.ItemForidStudent.Location = New System.Drawing.Point(0, 21)
        Me.ItemForidStudent.Name = "ItemForidStudent"
        Me.ItemForidStudent.Size = New System.Drawing.Size(630, 24)
        Me.ItemForidStudent.Text = "id Student"
        Me.ItemForidStudent.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForremarks
        '
        Me.ItemForremarks.Control = Me.remarksLookUpEdit
        Me.ItemForremarks.Location = New System.Drawing.Point(0, 45)
        Me.ItemForremarks.Name = "ItemForremarks"
        Me.ItemForremarks.Size = New System.Drawing.Size(630, 24)
        Me.ItemForremarks.Text = "remarks"
        Me.ItemForremarks.TextSize = New System.Drawing.Size(49, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AttendanceDetailGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 69)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(630, 406)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'StudentForAttendanceTableAdapter
        '
        Me.StudentForAttendanceTableAdapter.ClearBeforeFill = True
        '
        'labelInfo
        '
        Me.labelInfo.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInfo.Location = New System.Drawing.Point(12, 12)
        Me.labelInfo.Name = "labelInfo"
        Me.labelInfo.Size = New System.Drawing.Size(81, 17)
        Me.labelInfo.StyleController = Me.DataLayoutControl1
        Me.labelInfo.TabIndex = 4
        Me.labelInfo.Text = "LabelControl1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.labelInfo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(630, 21)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormAttendanceDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 520)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.AttendanceDetailBindingNavigator)
        Me.Name = "FormAttendanceDetail"
        Me.Text = "FormAttendanceDetail"
        CType(Me.DataSetAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceDetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendanceDetailBindingNavigator.ResumeLayout(False)
        Me.AttendanceDetailBindingNavigator.PerformLayout()
        CType(Me.AttendanceDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceStateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idStudentLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentForAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.remarksLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForremarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetAttendance As DataSetAttendance
    Friend WithEvents AttendanceDetailBindingSource As BindingSource
    Friend WithEvents AttendanceDetailTableAdapter As DataSetAttendanceTableAdapters.attendanceDetailTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAttendanceTableAdapters.TableAdapterManager
    Friend WithEvents AttendanceDetailBindingNavigator As BindingNavigator
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
    Friend WithEvents AttendanceDetailBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AttendanceDetailGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidAttendanceHeader As XtraGrid.Columns.GridColumn
    Friend WithEvents colidStudent As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents colremarks As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents AttendanceStateBindingSource As BindingSource
    Friend WithEvents AttendanceStateTableAdapter As DataSetAttendanceTableAdapters.attendanceStateTableAdapter
    Friend WithEvents MstStudentBindingSource As BindingSource
    Friend WithEvents MstStudentTableAdapter As DataSetAttendanceTableAdapters.mstStudentTableAdapter
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idStudentLookUpEdit As LookUpEdit
    Friend WithEvents StudentForAttendanceBindingSource As BindingSource
    Friend WithEvents remarksLookUpEdit As LookUpEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidStudent As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForremarks As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents StudentForAttendanceTableAdapter As DataSetAttendanceTableAdapters.studentForAttendanceTableAdapter
    Friend WithEvents labelInfo As LabelControl
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
End Class
