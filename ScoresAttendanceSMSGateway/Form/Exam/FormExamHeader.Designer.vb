<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExamHeader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExamHeader))
        Me.DataSetExam = New ScoresAttendanceSMSGateway.DataSetExam()
        Me.ExamHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamHeaderTableAdapter = New ScoresAttendanceSMSGateway.DataSetExamTableAdapters.examHeaderTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetExamTableAdapters.TableAdapterManager()
        Me.ExamHeaderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ExamHeaderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.buttonFill = New System.Windows.Forms.ToolStripButton()
        Me.ExamHeaderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetMapping = New ScoresAttendanceSMSGateway.DataSetMapping()
        Me.colidExam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstExamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetClassProperties = New ScoresAttendanceSMSGateway.DataSetClassProperties()
        Me.colidSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.coldateOfExam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colminimalRequirement = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idClassLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.idExamLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.idSubjectLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.dateOfExamDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.minimalRequirementSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidClass = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidExam = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidSubject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFordateOfExam = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForminimalRequirement = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstClassTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mstClassTableAdapter()
        Me.MstExamTableAdapter = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.mstExamTableAdapter()
        Me.MstSubjectTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mstSubjectTableAdapter()
        CType(Me.DataSetExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExamHeaderBindingNavigator.SuspendLayout()
        CType(Me.ExamHeaderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstExamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idClassLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idExamLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idSubjectLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfExamDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfExamDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimalRequirementSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFordateOfExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForminimalRequirement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetExam
        '
        Me.DataSetExam.DataSetName = "DataSetExam"
        Me.DataSetExam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamHeaderBindingSource
        '
        Me.ExamHeaderBindingSource.DataMember = "examHeader"
        Me.ExamHeaderBindingSource.DataSource = Me.DataSetExam
        '
        'ExamHeaderTableAdapter
        '
        Me.ExamHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.examDetailTableAdapter = Nothing
        Me.TableAdapterManager.examHeaderTableAdapter = Me.ExamHeaderTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetExamTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ExamHeaderBindingNavigator
        '
        Me.ExamHeaderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExamHeaderBindingNavigator.BindingSource = Me.ExamHeaderBindingSource
        Me.ExamHeaderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExamHeaderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExamHeaderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ExamHeaderBindingNavigatorSaveItem, Me.buttonFill})
        Me.ExamHeaderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExamHeaderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExamHeaderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExamHeaderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExamHeaderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExamHeaderBindingNavigator.Name = "ExamHeaderBindingNavigator"
        Me.ExamHeaderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExamHeaderBindingNavigator.Size = New System.Drawing.Size(891, 25)
        Me.ExamHeaderBindingNavigator.TabIndex = 0
        Me.ExamHeaderBindingNavigator.Text = "BindingNavigator1"
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
        'ExamHeaderBindingNavigatorSaveItem
        '
        Me.ExamHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExamHeaderBindingNavigatorSaveItem.Image = CType(resources.GetObject("ExamHeaderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ExamHeaderBindingNavigatorSaveItem.Name = "ExamHeaderBindingNavigatorSaveItem"
        Me.ExamHeaderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ExamHeaderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'buttonFill
        '
        Me.buttonFill.Image = CType(resources.GetObject("buttonFill.Image"), System.Drawing.Image)
        Me.buttonFill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFill.Name = "buttonFill"
        Me.buttonFill.Size = New System.Drawing.Size(116, 22)
        Me.buttonFill.Text = "ToolStripButton1"
        '
        'ExamHeaderGridControl
        '
        Me.ExamHeaderGridControl.DataSource = Me.ExamHeaderBindingSource
        Me.ExamHeaderGridControl.Location = New System.Drawing.Point(340, 12)
        Me.ExamHeaderGridControl.MainView = Me.GridView1
        Me.ExamHeaderGridControl.Name = "ExamHeaderGridControl"
        Me.ExamHeaderGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.ExamHeaderGridControl.Size = New System.Drawing.Size(539, 547)
        Me.ExamHeaderGridControl.TabIndex = 1
        Me.ExamHeaderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidClass, Me.colidExam, Me.colidSubject, Me.coldateOfExam, Me.colminimalRequirement})
        Me.GridView1.GridControl = Me.ExamHeaderGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidClass
        '
        Me.colidClass.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidClass.FieldName = "idClass"
        Me.colidClass.Name = "colidClass"
        Me.colidClass.Visible = True
        Me.colidClass.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.MstClassBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Class"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'MstClassBindingSource
        '
        Me.MstClassBindingSource.DataMember = "mstClass"
        Me.MstClassBindingSource.DataSource = Me.DataSetMapping
        '
        'DataSetMapping
        '
        Me.DataSetMapping.DataSetName = "DataSetMapping"
        Me.DataSetMapping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colidExam
        '
        Me.colidExam.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidExam.FieldName = "idExam"
        Me.colidExam.Name = "colidExam"
        Me.colidExam.Visible = True
        Me.colidExam.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.MstExamBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "exam"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'MstExamBindingSource
        '
        Me.MstExamBindingSource.DataMember = "mstExam"
        Me.MstExamBindingSource.DataSource = Me.DataSetClassProperties
        '
        'DataSetClassProperties
        '
        Me.DataSetClassProperties.DataSetName = "DataSetClassProperties"
        Me.DataSetClassProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colidSubject
        '
        Me.colidSubject.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colidSubject.FieldName = "idSubject"
        Me.colidSubject.Name = "colidSubject"
        Me.colidSubject.Visible = True
        Me.colidSubject.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.MstSubjectBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "subject"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "id"
        '
        'MstSubjectBindingSource
        '
        Me.MstSubjectBindingSource.DataMember = "mstSubject"
        Me.MstSubjectBindingSource.DataSource = Me.DataSetMapping
        '
        'coldateOfExam
        '
        Me.coldateOfExam.FieldName = "dateOfExam"
        Me.coldateOfExam.Name = "coldateOfExam"
        Me.coldateOfExam.Visible = True
        Me.coldateOfExam.VisibleIndex = 3
        '
        'colminimalRequirement
        '
        Me.colminimalRequirement.FieldName = "minimalRequirement"
        Me.colminimalRequirement.Name = "colminimalRequirement"
        Me.colminimalRequirement.Visible = True
        Me.colminimalRequirement.VisibleIndex = 4
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.ExamHeaderGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idClassLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idExamLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idSubjectLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.dateOfExamDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.minimalRequirementSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.ExamHeaderBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(584, 117, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(891, 571)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idClassLookUpEdit
        '
        Me.idClassLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ExamHeaderBindingSource, "idClass", True))
        Me.idClassLookUpEdit.Location = New System.Drawing.Point(119, 12)
        Me.idClassLookUpEdit.Name = "idClassLookUpEdit"
        Me.idClassLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idClassLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idClassLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idClassLookUpEdit.Properties.DataSource = Me.MstClassBindingSource
        Me.idClassLookUpEdit.Properties.DisplayMember = "Class"
        Me.idClassLookUpEdit.Properties.NullText = ""
        Me.idClassLookUpEdit.Properties.ValueMember = "id"
        Me.idClassLookUpEdit.Size = New System.Drawing.Size(217, 20)
        Me.idClassLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idClassLookUpEdit.TabIndex = 4
        '
        'idExamLookUpEdit
        '
        Me.idExamLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ExamHeaderBindingSource, "idExam", True))
        Me.idExamLookUpEdit.Location = New System.Drawing.Point(119, 36)
        Me.idExamLookUpEdit.Name = "idExamLookUpEdit"
        Me.idExamLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idExamLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idExamLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idExamLookUpEdit.Properties.DataSource = Me.MstExamBindingSource
        Me.idExamLookUpEdit.Properties.DisplayMember = "exam"
        Me.idExamLookUpEdit.Properties.NullText = ""
        Me.idExamLookUpEdit.Properties.ValueMember = "id"
        Me.idExamLookUpEdit.Size = New System.Drawing.Size(217, 20)
        Me.idExamLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idExamLookUpEdit.TabIndex = 5
        '
        'idSubjectLookUpEdit
        '
        Me.idSubjectLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ExamHeaderBindingSource, "idSubject", True))
        Me.idSubjectLookUpEdit.Location = New System.Drawing.Point(119, 60)
        Me.idSubjectLookUpEdit.Name = "idSubjectLookUpEdit"
        Me.idSubjectLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSubjectLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSubjectLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSubjectLookUpEdit.Properties.DataSource = Me.MstSubjectBindingSource
        Me.idSubjectLookUpEdit.Properties.DisplayMember = "subject"
        Me.idSubjectLookUpEdit.Properties.NullText = ""
        Me.idSubjectLookUpEdit.Properties.ValueMember = "id"
        Me.idSubjectLookUpEdit.Size = New System.Drawing.Size(217, 20)
        Me.idSubjectLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idSubjectLookUpEdit.TabIndex = 6
        '
        'dateOfExamDateEdit
        '
        Me.dateOfExamDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ExamHeaderBindingSource, "dateOfExam", True))
        Me.dateOfExamDateEdit.EditValue = Nothing
        Me.dateOfExamDateEdit.Location = New System.Drawing.Point(119, 84)
        Me.dateOfExamDateEdit.Name = "dateOfExamDateEdit"
        Me.dateOfExamDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfExamDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfExamDateEdit.Size = New System.Drawing.Size(217, 20)
        Me.dateOfExamDateEdit.StyleController = Me.DataLayoutControl1
        Me.dateOfExamDateEdit.TabIndex = 7
        '
        'minimalRequirementSpinEdit
        '
        Me.minimalRequirementSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ExamHeaderBindingSource, "minimalRequirement", True))
        Me.minimalRequirementSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.minimalRequirementSpinEdit.Location = New System.Drawing.Point(119, 108)
        Me.minimalRequirementSpinEdit.Name = "minimalRequirementSpinEdit"
        Me.minimalRequirementSpinEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.minimalRequirementSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.minimalRequirementSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.minimalRequirementSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.minimalRequirementSpinEdit.Properties.Mask.EditMask = "N0"
        Me.minimalRequirementSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.minimalRequirementSpinEdit.Size = New System.Drawing.Size(217, 20)
        Me.minimalRequirementSpinEdit.StyleController = Me.DataLayoutControl1
        Me.minimalRequirementSpinEdit.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(891, 571)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidClass, Me.ItemForidExam, Me.ItemForidSubject, Me.ItemFordateOfExam, Me.ItemForminimalRequirement, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(871, 551)
        '
        'ItemForidClass
        '
        Me.ItemForidClass.Control = Me.idClassLookUpEdit
        Me.ItemForidClass.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidClass.Name = "ItemForidClass"
        Me.ItemForidClass.Size = New System.Drawing.Size(328, 24)
        Me.ItemForidClass.Text = "Class"
        Me.ItemForidClass.TextSize = New System.Drawing.Size(104, 13)
        '
        'ItemForidExam
        '
        Me.ItemForidExam.Control = Me.idExamLookUpEdit
        Me.ItemForidExam.Location = New System.Drawing.Point(0, 24)
        Me.ItemForidExam.Name = "ItemForidExam"
        Me.ItemForidExam.Size = New System.Drawing.Size(328, 24)
        Me.ItemForidExam.Text = "Exam"
        Me.ItemForidExam.TextSize = New System.Drawing.Size(104, 13)
        '
        'ItemForidSubject
        '
        Me.ItemForidSubject.Control = Me.idSubjectLookUpEdit
        Me.ItemForidSubject.Location = New System.Drawing.Point(0, 48)
        Me.ItemForidSubject.Name = "ItemForidSubject"
        Me.ItemForidSubject.Size = New System.Drawing.Size(328, 24)
        Me.ItemForidSubject.Text = "Subject"
        Me.ItemForidSubject.TextSize = New System.Drawing.Size(104, 13)
        '
        'ItemFordateOfExam
        '
        Me.ItemFordateOfExam.Control = Me.dateOfExamDateEdit
        Me.ItemFordateOfExam.Location = New System.Drawing.Point(0, 72)
        Me.ItemFordateOfExam.Name = "ItemFordateOfExam"
        Me.ItemFordateOfExam.Size = New System.Drawing.Size(328, 24)
        Me.ItemFordateOfExam.Text = "Date"
        Me.ItemFordateOfExam.TextSize = New System.Drawing.Size(104, 13)
        '
        'ItemForminimalRequirement
        '
        Me.ItemForminimalRequirement.Control = Me.minimalRequirementSpinEdit
        Me.ItemForminimalRequirement.Location = New System.Drawing.Point(0, 96)
        Me.ItemForminimalRequirement.Name = "ItemForminimalRequirement"
        Me.ItemForminimalRequirement.Size = New System.Drawing.Size(328, 455)
        Me.ItemForminimalRequirement.Text = "Minimal Score To Pass"
        Me.ItemForminimalRequirement.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ExamHeaderGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(328, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(543, 551)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'MstClassTableAdapter
        '
        Me.MstClassTableAdapter.ClearBeforeFill = True
        '
        'MstExamTableAdapter
        '
        Me.MstExamTableAdapter.ClearBeforeFill = True
        '
        'MstSubjectTableAdapter
        '
        Me.MstSubjectTableAdapter.ClearBeforeFill = True
        '
        'FormExamHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 596)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.ExamHeaderBindingNavigator)
        Me.Name = "FormExamHeader"
        Me.Text = "FormExamHeader"
        CType(Me.DataSetExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExamHeaderBindingNavigator.ResumeLayout(False)
        Me.ExamHeaderBindingNavigator.PerformLayout()
        CType(Me.ExamHeaderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstExamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idClassLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idExamLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idSubjectLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfExamDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfExamDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimalRequirementSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidSubject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFordateOfExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForminimalRequirement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetExam As DataSetExam
    Friend WithEvents ExamHeaderBindingSource As BindingSource
    Friend WithEvents ExamHeaderTableAdapter As DataSetExamTableAdapters.examHeaderTableAdapter
    Friend WithEvents TableAdapterManager As DataSetExamTableAdapters.TableAdapterManager
    Friend WithEvents ExamHeaderBindingNavigator As BindingNavigator
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
    Friend WithEvents ExamHeaderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ExamHeaderGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidClass As XtraGrid.Columns.GridColumn
    Friend WithEvents colidExam As XtraGrid.Columns.GridColumn
    Friend WithEvents colidSubject As XtraGrid.Columns.GridColumn
    Friend WithEvents coldateOfExam As XtraGrid.Columns.GridColumn
    Friend WithEvents colminimalRequirement As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idClassLookUpEdit As LookUpEdit
    Friend WithEvents idExamLookUpEdit As LookUpEdit
    Friend WithEvents idSubjectLookUpEdit As LookUpEdit
    Friend WithEvents dateOfExamDateEdit As DateEdit
    Friend WithEvents minimalRequirementSpinEdit As SpinEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidClass As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidExam As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidSubject As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFordateOfExam As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForminimalRequirement As XtraLayout.LayoutControlItem
    Friend WithEvents DataSetMapping As DataSetMapping
    Friend WithEvents MstClassBindingSource As BindingSource
    Friend WithEvents MstClassTableAdapter As DataSetMappingTableAdapters.mstClassTableAdapter
    Friend WithEvents DataSetClassProperties As DataSetClassProperties
    Friend WithEvents MstExamBindingSource As BindingSource
    Friend WithEvents MstExamTableAdapter As DataSetClassPropertiesTableAdapters.mstExamTableAdapter
    Friend WithEvents MstSubjectBindingSource As BindingSource
    Friend WithEvents MstSubjectTableAdapter As DataSetMappingTableAdapters.mstSubjectTableAdapter
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents buttonFill As ToolStripButton
End Class
