<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTeacher))
        Me.DataSetClassProperties = New ScoresAttendanceSMSGateway.DataSetClassProperties()
        Me.MstTeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstTeacherTableAdapter = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.mstTeacherTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager()
        Me.MstTeacherBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstTeacherBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstTeacherGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.civilServantNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NamesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.dateOfBirthDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.dateOfJoinDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.photographPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForcivilServantNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNames = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFordateOfBirth = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFordateOfJoin = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForphotograph = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colregistrationNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcivilServantNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNames = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateOfBirth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateOfJoin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphotograph = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstTeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstTeacherBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstTeacherBindingNavigator.SuspendLayout()
        CType(Me.MstTeacherGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.civilServantNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfBirthDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfJoinDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfJoinDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photographPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForcivilServantNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFordateOfBirth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFordateOfJoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphotograph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetClassProperties
        '
        Me.DataSetClassProperties.DataSetName = "DataSetClassProperties"
        Me.DataSetClassProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstTeacherBindingSource
        '
        Me.MstTeacherBindingSource.DataMember = "mstTeacher"
        Me.MstTeacherBindingSource.DataSource = Me.DataSetClassProperties
        '
        'MstTeacherTableAdapter
        '
        Me.MstTeacherTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstClassTableAdapter = Nothing
        Me.TableAdapterManager.mstExamTableAdapter = Nothing
        Me.TableAdapterManager.mstNationalHolidayTableAdapter = Nothing
        Me.TableAdapterManager.mstSubjectTableAdapter = Nothing
        Me.TableAdapterManager.mstTeacherTableAdapter = Me.MstTeacherTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstTeacherBindingNavigator
        '
        Me.MstTeacherBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstTeacherBindingNavigator.BindingSource = Me.MstTeacherBindingSource
        Me.MstTeacherBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstTeacherBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstTeacherBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstTeacherBindingNavigatorSaveItem})
        Me.MstTeacherBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstTeacherBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstTeacherBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstTeacherBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstTeacherBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstTeacherBindingNavigator.Name = "MstTeacherBindingNavigator"
        Me.MstTeacherBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstTeacherBindingNavigator.Size = New System.Drawing.Size(713, 25)
        Me.MstTeacherBindingNavigator.TabIndex = 0
        Me.MstTeacherBindingNavigator.Text = "BindingNavigator1"
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
        'MstTeacherBindingNavigatorSaveItem
        '
        Me.MstTeacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstTeacherBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstTeacherBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstTeacherBindingNavigatorSaveItem.Name = "MstTeacherBindingNavigatorSaveItem"
        Me.MstTeacherBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstTeacherBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstTeacherGridControl
        '
        Me.MstTeacherGridControl.DataSource = Me.MstTeacherBindingSource
        Me.MstTeacherGridControl.Location = New System.Drawing.Point(316, 12)
        Me.MstTeacherGridControl.MainView = Me.GridView1
        Me.MstTeacherGridControl.Name = "MstTeacherGridControl"
        Me.MstTeacherGridControl.Size = New System.Drawing.Size(385, 521)
        Me.MstTeacherGridControl.TabIndex = 1
        Me.MstTeacherGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colregistrationNumber, Me.colcivilServantNumber, Me.colNames, Me.coldateOfBirth, Me.coldateOfJoin, Me.colphotograph})
        Me.GridView1.GridControl = Me.MstTeacherGridControl
        Me.GridView1.Name = "GridView1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.MstTeacherGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.civilServantNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NamesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.dateOfBirthDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.dateOfJoinDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.photographPictureEdit)
        Me.DataLayoutControl1.DataSource = Me.MstTeacherBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(624, 143, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(713, 545)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'civilServantNumberTextEdit
        '
        Me.civilServantNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstTeacherBindingSource, "civilServantNumber", True))
        Me.civilServantNumberTextEdit.Location = New System.Drawing.Point(113, 12)
        Me.civilServantNumberTextEdit.Name = "civilServantNumberTextEdit"
        Me.civilServantNumberTextEdit.Size = New System.Drawing.Size(199, 20)
        Me.civilServantNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.civilServantNumberTextEdit.TabIndex = 4
        '
        'NamesTextEdit
        '
        Me.NamesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstTeacherBindingSource, "Names", True))
        Me.NamesTextEdit.Location = New System.Drawing.Point(113, 36)
        Me.NamesTextEdit.Name = "NamesTextEdit"
        Me.NamesTextEdit.Size = New System.Drawing.Size(199, 20)
        Me.NamesTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamesTextEdit.TabIndex = 5
        '
        'dateOfBirthDateEdit
        '
        Me.dateOfBirthDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstTeacherBindingSource, "dateOfBirth", True))
        Me.dateOfBirthDateEdit.EditValue = Nothing
        Me.dateOfBirthDateEdit.Location = New System.Drawing.Point(113, 60)
        Me.dateOfBirthDateEdit.Name = "dateOfBirthDateEdit"
        Me.dateOfBirthDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfBirthDateEdit.Size = New System.Drawing.Size(199, 20)
        Me.dateOfBirthDateEdit.StyleController = Me.DataLayoutControl1
        Me.dateOfBirthDateEdit.TabIndex = 6
        '
        'dateOfJoinDateEdit
        '
        Me.dateOfJoinDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstTeacherBindingSource, "dateOfJoin", True))
        Me.dateOfJoinDateEdit.EditValue = Nothing
        Me.dateOfJoinDateEdit.Location = New System.Drawing.Point(113, 84)
        Me.dateOfJoinDateEdit.Name = "dateOfJoinDateEdit"
        Me.dateOfJoinDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfJoinDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfJoinDateEdit.Size = New System.Drawing.Size(199, 20)
        Me.dateOfJoinDateEdit.StyleController = Me.DataLayoutControl1
        Me.dateOfJoinDateEdit.TabIndex = 7
        '
        'photographPictureEdit
        '
        Me.photographPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.photographPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstTeacherBindingSource, "photograph", True))
        Me.photographPictureEdit.Location = New System.Drawing.Point(113, 108)
        Me.photographPictureEdit.Name = "photographPictureEdit"
        Me.photographPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.photographPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photographPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.photographPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.photographPictureEdit.Size = New System.Drawing.Size(199, 210)
        Me.photographPictureEdit.StyleController = Me.DataLayoutControl1
        Me.photographPictureEdit.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(713, 545)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForcivilServantNumber, Me.ItemForNames, Me.ItemFordateOfBirth, Me.ItemFordateOfJoin, Me.ItemForphotograph, Me.LayoutControlItem1, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(693, 525)
        '
        'ItemForcivilServantNumber
        '
        Me.ItemForcivilServantNumber.Control = Me.civilServantNumberTextEdit
        Me.ItemForcivilServantNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForcivilServantNumber.Name = "ItemForcivilServantNumber"
        Me.ItemForcivilServantNumber.Size = New System.Drawing.Size(304, 24)
        Me.ItemForcivilServantNumber.Text = "civil Servant Number"
        Me.ItemForcivilServantNumber.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemForNames
        '
        Me.ItemForNames.Control = Me.NamesTextEdit
        Me.ItemForNames.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNames.Name = "ItemForNames"
        Me.ItemForNames.Size = New System.Drawing.Size(304, 24)
        Me.ItemForNames.Text = "Names"
        Me.ItemForNames.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemFordateOfBirth
        '
        Me.ItemFordateOfBirth.Control = Me.dateOfBirthDateEdit
        Me.ItemFordateOfBirth.Location = New System.Drawing.Point(0, 48)
        Me.ItemFordateOfBirth.Name = "ItemFordateOfBirth"
        Me.ItemFordateOfBirth.Size = New System.Drawing.Size(304, 24)
        Me.ItemFordateOfBirth.Text = "date Of Birth"
        Me.ItemFordateOfBirth.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemFordateOfJoin
        '
        Me.ItemFordateOfJoin.Control = Me.dateOfJoinDateEdit
        Me.ItemFordateOfJoin.Location = New System.Drawing.Point(0, 72)
        Me.ItemFordateOfJoin.Name = "ItemFordateOfJoin"
        Me.ItemFordateOfJoin.Size = New System.Drawing.Size(304, 24)
        Me.ItemFordateOfJoin.Text = "date Of Join"
        Me.ItemFordateOfJoin.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemForphotograph
        '
        Me.ItemForphotograph.Control = Me.photographPictureEdit
        Me.ItemForphotograph.Location = New System.Drawing.Point(0, 96)
        Me.ItemForphotograph.Name = "ItemForphotograph"
        Me.ItemForphotograph.Size = New System.Drawing.Size(304, 214)
        Me.ItemForphotograph.StartNewLine = True
        Me.ItemForphotograph.Text = "photograph"
        Me.ItemForphotograph.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MstTeacherGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(304, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(389, 525)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 310)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(304, 215)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colregistrationNumber
        '
        Me.colregistrationNumber.FieldName = "registrationNumber"
        Me.colregistrationNumber.Name = "colregistrationNumber"
        Me.colregistrationNumber.Visible = True
        Me.colregistrationNumber.VisibleIndex = 0
        '
        'colcivilServantNumber
        '
        Me.colcivilServantNumber.FieldName = "civilServantNumber"
        Me.colcivilServantNumber.Name = "colcivilServantNumber"
        Me.colcivilServantNumber.Visible = True
        Me.colcivilServantNumber.VisibleIndex = 1
        '
        'colNames
        '
        Me.colNames.FieldName = "Names"
        Me.colNames.Name = "colNames"
        Me.colNames.Visible = True
        Me.colNames.VisibleIndex = 2
        '
        'coldateOfBirth
        '
        Me.coldateOfBirth.FieldName = "dateOfBirth"
        Me.coldateOfBirth.Name = "coldateOfBirth"
        Me.coldateOfBirth.Visible = True
        Me.coldateOfBirth.VisibleIndex = 3
        '
        'coldateOfJoin
        '
        Me.coldateOfJoin.FieldName = "dateOfJoin"
        Me.coldateOfJoin.Name = "coldateOfJoin"
        Me.coldateOfJoin.Visible = True
        Me.coldateOfJoin.VisibleIndex = 4
        '
        'colphotograph
        '
        Me.colphotograph.FieldName = "photograph"
        Me.colphotograph.Name = "colphotograph"
        Me.colphotograph.Visible = True
        Me.colphotograph.VisibleIndex = 5
        '
        'FormTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 570)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstTeacherBindingNavigator)
        Me.Name = "FormTeacher"
        Me.Text = "FormTeacher"
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstTeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstTeacherBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstTeacherBindingNavigator.ResumeLayout(False)
        Me.MstTeacherBindingNavigator.PerformLayout()
        CType(Me.MstTeacherGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.civilServantNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfBirthDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfJoinDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfJoinDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photographPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForcivilServantNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFordateOfBirth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFordateOfJoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphotograph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetClassProperties As DataSetClassProperties
    Friend WithEvents MstTeacherBindingSource As BindingSource
    Friend WithEvents MstTeacherTableAdapter As DataSetClassPropertiesTableAdapters.mstTeacherTableAdapter
    Friend WithEvents TableAdapterManager As DataSetClassPropertiesTableAdapters.TableAdapterManager
    Friend WithEvents MstTeacherBindingNavigator As BindingNavigator
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
    Friend WithEvents MstTeacherBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstTeacherGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents civilServantNumberTextEdit As TextEdit
    Friend WithEvents NamesTextEdit As TextEdit
    Friend WithEvents dateOfBirthDateEdit As DateEdit
    Friend WithEvents dateOfJoinDateEdit As DateEdit
    Friend WithEvents photographPictureEdit As PictureEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForcivilServantNumber As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNames As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFordateOfBirth As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFordateOfJoin As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForphotograph As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As XtraLayout.EmptySpaceItem
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colregistrationNumber As XtraGrid.Columns.GridColumn
    Friend WithEvents colcivilServantNumber As XtraGrid.Columns.GridColumn
    Friend WithEvents colNames As XtraGrid.Columns.GridColumn
    Friend WithEvents coldateOfBirth As XtraGrid.Columns.GridColumn
    Friend WithEvents coldateOfJoin As XtraGrid.Columns.GridColumn
    Friend WithEvents colphotograph As XtraGrid.Columns.GridColumn
End Class
