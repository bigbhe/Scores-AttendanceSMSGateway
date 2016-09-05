<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudents))
        Me.DataSetStudentRelation = New ScoresAttendanceSMSGateway.DataSetStudentRelation()
        Me.MstStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstStudentTableAdapter = New ScoresAttendanceSMSGateway.DataSetStudentRelationTableAdapters.mstStudentTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetStudentRelationTableAdapters.TableAdapterManager()
        Me.MstStudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstStudentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstStudentGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colregistrationNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNames = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateOfBirth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnationality = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphotograph = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersonInCharge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrelation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpersonInChargePhoneNumbers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.checkEditInactive = New DevExpress.XtraEditors.CheckEdit()
        Me.registrationNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NamesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.dateOfBirthDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.nationalityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.photographPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.personInChargeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.relationLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.MstRelationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.personInChargePhoneNumbersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.isActiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AddressTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.genderCheckEdit = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForregistrationNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNames = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFordateOfBirth = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFornationality = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForgender = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForpersonInCharge = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForrelation = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForpersonInChargePhoneNumbers = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForphotograph = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisActive = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcg6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstRelationTableAdapter = New ScoresAttendanceSMSGateway.DataSetStudentRelationTableAdapters.mstRelationTableAdapter()
        CType(Me.DataSetStudentRelation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstStudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstStudentBindingNavigator.SuspendLayout()
        CType(Me.MstStudentGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.checkEditInactive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.registrationNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateOfBirthDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nationalityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photographPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personInChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstRelationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personInChargePhoneNumbersTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.genderCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForregistrationNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFordateOfBirth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFornationality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForgender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpersonInCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForrelation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpersonInChargePhoneNumbers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphotograph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcg6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetStudentRelation
        '
        Me.DataSetStudentRelation.DataSetName = "DataSetStudentRelation"
        Me.DataSetStudentRelation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstStudentBindingSource
        '
        Me.MstStudentBindingSource.DataMember = "mstStudent"
        Me.MstStudentBindingSource.DataSource = Me.DataSetStudentRelation
        '
        'MstStudentTableAdapter
        '
        Me.MstStudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstRelationTableAdapter = Nothing
        Me.TableAdapterManager.mstStudentTableAdapter = Me.MstStudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetStudentRelationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstStudentBindingNavigator
        '
        Me.MstStudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstStudentBindingNavigator.BindingSource = Me.MstStudentBindingSource
        Me.MstStudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstStudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstStudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstStudentBindingNavigatorSaveItem})
        Me.MstStudentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstStudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstStudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstStudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstStudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstStudentBindingNavigator.Name = "MstStudentBindingNavigator"
        Me.MstStudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstStudentBindingNavigator.Size = New System.Drawing.Size(904, 25)
        Me.MstStudentBindingNavigator.TabIndex = 0
        Me.MstStudentBindingNavigator.Text = "BindingNavigator1"
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
        'MstStudentBindingNavigatorSaveItem
        '
        Me.MstStudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstStudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstStudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstStudentBindingNavigatorSaveItem.Name = "MstStudentBindingNavigatorSaveItem"
        Me.MstStudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstStudentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstStudentGridControl
        '
        Me.MstStudentGridControl.DataSource = Me.MstStudentBindingSource
        Me.MstStudentGridControl.Location = New System.Drawing.Point(24, 306)
        Me.MstStudentGridControl.MainView = Me.GridView1
        Me.MstStudentGridControl.Name = "MstStudentGridControl"
        Me.MstStudentGridControl.Size = New System.Drawing.Size(856, 235)
        Me.MstStudentGridControl.TabIndex = 2
        Me.MstStudentGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colregistrationNumber, Me.colNames, Me.coldateOfBirth, Me.colAddress, Me.colnationality, Me.colgender, Me.colphotograph, Me.colpersonInCharge, Me.colrelation, Me.colpersonInChargePhoneNumbers, Me.colisActive})
        Me.GridView1.GridControl = Me.MstStudentGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colregistrationNumber
        '
        Me.colregistrationNumber.Caption = "Registration Number"
        Me.colregistrationNumber.FieldName = "registrationNumber"
        Me.colregistrationNumber.Name = "colregistrationNumber"
        Me.colregistrationNumber.Visible = True
        Me.colregistrationNumber.VisibleIndex = 0
        '
        'colNames
        '
        Me.colNames.Caption = "Fullname"
        Me.colNames.FieldName = "Names"
        Me.colNames.Name = "colNames"
        Me.colNames.Visible = True
        Me.colNames.VisibleIndex = 1
        '
        'coldateOfBirth
        '
        Me.coldateOfBirth.Caption = "Date Of Birth"
        Me.coldateOfBirth.FieldName = "dateOfBirth"
        Me.coldateOfBirth.Name = "coldateOfBirth"
        Me.coldateOfBirth.Visible = True
        Me.coldateOfBirth.VisibleIndex = 2
        '
        'colAddress
        '
        Me.colAddress.Caption = "Address"
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 3
        '
        'colnationality
        '
        Me.colnationality.Caption = "Nationality"
        Me.colnationality.FieldName = "nationality"
        Me.colnationality.Name = "colnationality"
        Me.colnationality.Visible = True
        Me.colnationality.VisibleIndex = 4
        '
        'colgender
        '
        Me.colgender.FieldName = "gender"
        Me.colgender.Name = "colgender"
        '
        'colphotograph
        '
        Me.colphotograph.FieldName = "photograph"
        Me.colphotograph.Name = "colphotograph"
        '
        'colpersonInCharge
        '
        Me.colpersonInCharge.FieldName = "personInCharge"
        Me.colpersonInCharge.Name = "colpersonInCharge"
        Me.colpersonInCharge.Visible = True
        Me.colpersonInCharge.VisibleIndex = 5
        '
        'colrelation
        '
        Me.colrelation.FieldName = "relation"
        Me.colrelation.Name = "colrelation"
        '
        'colpersonInChargePhoneNumbers
        '
        Me.colpersonInChargePhoneNumbers.Caption = "Phone Number"
        Me.colpersonInChargePhoneNumbers.FieldName = "personInChargePhoneNumbers"
        Me.colpersonInChargePhoneNumbers.Name = "colpersonInChargePhoneNumbers"
        Me.colpersonInChargePhoneNumbers.Visible = True
        Me.colpersonInChargePhoneNumbers.VisibleIndex = 6
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.checkEditInactive)
        Me.DataLayoutControl1.Controls.Add(Me.MstStudentGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.registrationNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NamesTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.dateOfBirthDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nationalityTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.photographPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.personInChargeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.relationLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.personInChargePhoneNumbersTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isActiveCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AddressTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.genderCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MstStudentBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(190, 553, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(904, 565)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'checkEditInactive
        '
        Me.checkEditInactive.Location = New System.Drawing.Point(24, 283)
        Me.checkEditInactive.Name = "checkEditInactive"
        Me.checkEditInactive.Properties.Caption = "Show Inactive Student"
        Me.checkEditInactive.Size = New System.Drawing.Size(856, 19)
        Me.checkEditInactive.StyleController = Me.DataLayoutControl1
        Me.checkEditInactive.TabIndex = 15
        '
        'registrationNumberTextEdit
        '
        Me.registrationNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "registrationNumber", True))
        Me.registrationNumberTextEdit.Location = New System.Drawing.Point(125, 42)
        Me.registrationNumberTextEdit.Name = "registrationNumberTextEdit"
        Me.registrationNumberTextEdit.Size = New System.Drawing.Size(257, 20)
        Me.registrationNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.registrationNumberTextEdit.TabIndex = 4
        '
        'NamesTextEdit
        '
        Me.NamesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "Names", True))
        Me.NamesTextEdit.Location = New System.Drawing.Point(125, 66)
        Me.NamesTextEdit.Name = "NamesTextEdit"
        Me.NamesTextEdit.Size = New System.Drawing.Size(257, 20)
        Me.NamesTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamesTextEdit.TabIndex = 5
        '
        'dateOfBirthDateEdit
        '
        Me.dateOfBirthDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "dateOfBirth", True))
        Me.dateOfBirthDateEdit.EditValue = Nothing
        Me.dateOfBirthDateEdit.Location = New System.Drawing.Point(125, 90)
        Me.dateOfBirthDateEdit.Name = "dateOfBirthDateEdit"
        Me.dateOfBirthDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateOfBirthDateEdit.Size = New System.Drawing.Size(257, 20)
        Me.dateOfBirthDateEdit.StyleController = Me.DataLayoutControl1
        Me.dateOfBirthDateEdit.TabIndex = 6
        '
        'nationalityTextEdit
        '
        Me.nationalityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "nationality", True))
        Me.nationalityTextEdit.Location = New System.Drawing.Point(125, 186)
        Me.nationalityTextEdit.Name = "nationalityTextEdit"
        Me.nationalityTextEdit.Size = New System.Drawing.Size(257, 20)
        Me.nationalityTextEdit.StyleController = Me.DataLayoutControl1
        Me.nationalityTextEdit.TabIndex = 8
        '
        'photographPictureEdit
        '
        Me.photographPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.photographPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "photograph", True))
        Me.photographPictureEdit.Location = New System.Drawing.Point(410, 42)
        Me.photographPictureEdit.Name = "photographPictureEdit"
        Me.photographPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.photographPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.photographPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.photographPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.photographPictureEdit.Size = New System.Drawing.Size(131, 172)
        Me.photographPictureEdit.StyleController = Me.DataLayoutControl1
        Me.photographPictureEdit.TabIndex = 10
        '
        'personInChargeTextEdit
        '
        Me.personInChargeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "personInCharge", True))
        Me.personInChargeTextEdit.Location = New System.Drawing.Point(670, 42)
        Me.personInChargeTextEdit.Name = "personInChargeTextEdit"
        Me.personInChargeTextEdit.Size = New System.Drawing.Size(210, 20)
        Me.personInChargeTextEdit.StyleController = Me.DataLayoutControl1
        Me.personInChargeTextEdit.TabIndex = 11
        '
        'relationLookUpEdit
        '
        Me.relationLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "relation", True))
        Me.relationLookUpEdit.Location = New System.Drawing.Point(670, 66)
        Me.relationLookUpEdit.Name = "relationLookUpEdit"
        Me.relationLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.relationLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.relationLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.relationLookUpEdit.Properties.DataSource = Me.MstRelationBindingSource
        Me.relationLookUpEdit.Properties.DisplayMember = "relation"
        Me.relationLookUpEdit.Properties.NullText = ""
        Me.relationLookUpEdit.Properties.ValueMember = "id"
        Me.relationLookUpEdit.Size = New System.Drawing.Size(210, 20)
        Me.relationLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.relationLookUpEdit.TabIndex = 12
        '
        'MstRelationBindingSource
        '
        Me.MstRelationBindingSource.DataMember = "mstRelation"
        Me.MstRelationBindingSource.DataSource = Me.DataSetStudentRelation
        '
        'personInChargePhoneNumbersTextEdit
        '
        Me.personInChargePhoneNumbersTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "personInChargePhoneNumbers", True))
        Me.personInChargePhoneNumbersTextEdit.Location = New System.Drawing.Point(670, 90)
        Me.personInChargePhoneNumbersTextEdit.Name = "personInChargePhoneNumbersTextEdit"
        Me.personInChargePhoneNumbersTextEdit.Properties.Mask.BeepOnError = True
        Me.personInChargePhoneNumbersTextEdit.Properties.Mask.EditMask = "\+62[1-9]{1}[0-9]{3,10}"
        Me.personInChargePhoneNumbersTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.personInChargePhoneNumbersTextEdit.Properties.Mask.SaveLiteral = False
        Me.personInChargePhoneNumbersTextEdit.Size = New System.Drawing.Size(210, 20)
        Me.personInChargePhoneNumbersTextEdit.StyleController = Me.DataLayoutControl1
        Me.personInChargePhoneNumbersTextEdit.TabIndex = 13
        '
        'isActiveCheckEdit
        '
        Me.isActiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "isActive", True))
        Me.isActiveCheckEdit.Location = New System.Drawing.Point(511, 218)
        Me.isActiveCheckEdit.Name = "isActiveCheckEdit"
        Me.isActiveCheckEdit.Properties.Caption = "is Active"
        Me.isActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isActiveCheckEdit.Size = New System.Drawing.Size(30, 19)
        Me.isActiveCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isActiveCheckEdit.TabIndex = 14
        Me.isActiveCheckEdit.ToolTip = "Uncheck If Student already graduate or no longer in school"
        '
        'AddressTextEdit
        '
        Me.AddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "Address", True))
        Me.AddressTextEdit.Location = New System.Drawing.Point(125, 114)
        Me.AddressTextEdit.Name = "AddressTextEdit"
        Me.AddressTextEdit.Size = New System.Drawing.Size(257, 68)
        Me.AddressTextEdit.StyleController = Me.DataLayoutControl1
        Me.AddressTextEdit.TabIndex = 7
        '
        'genderCheckEdit
        '
        Me.genderCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstStudentBindingSource, "gender", True))
        Me.genderCheckEdit.EditValue = False
        Me.genderCheckEdit.Location = New System.Drawing.Point(125, 210)
        Me.genderCheckEdit.Name = "genderCheckEdit"
        Me.genderCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.genderCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.genderCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.genderCheckEdit.Properties.Columns = 2
        Me.genderCheckEdit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Male"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Female")})
        Me.genderCheckEdit.Size = New System.Drawing.Size(257, 27)
        Me.genderCheckEdit.StyleController = Me.DataLayoutControl1
        Me.genderCheckEdit.TabIndex = 9
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(904, 565)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.lcg6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(884, 545)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForregistrationNumber, Me.ItemForNames, Me.ItemFordateOfBirth, Me.ItemForAddress, Me.ItemFornationality, Me.ItemForgender})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(386, 241)
        Me.LayoutControlGroup3.Text = "Student Details"
        '
        'ItemForregistrationNumber
        '
        Me.ItemForregistrationNumber.Control = Me.registrationNumberTextEdit
        Me.ItemForregistrationNumber.Location = New System.Drawing.Point(0, 0)
        Me.ItemForregistrationNumber.Name = "ItemForregistrationNumber"
        Me.ItemForregistrationNumber.Size = New System.Drawing.Size(362, 24)
        Me.ItemForregistrationNumber.Text = "Registration Number"
        Me.ItemForregistrationNumber.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemForNames
        '
        Me.ItemForNames.Control = Me.NamesTextEdit
        Me.ItemForNames.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNames.Name = "ItemForNames"
        Me.ItemForNames.Size = New System.Drawing.Size(362, 24)
        Me.ItemForNames.Text = "Name"
        Me.ItemForNames.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemFordateOfBirth
        '
        Me.ItemFordateOfBirth.Control = Me.dateOfBirthDateEdit
        Me.ItemFordateOfBirth.Location = New System.Drawing.Point(0, 48)
        Me.ItemFordateOfBirth.Name = "ItemFordateOfBirth"
        Me.ItemFordateOfBirth.Size = New System.Drawing.Size(362, 24)
        Me.ItemFordateOfBirth.Text = "date Of Birth"
        Me.ItemFordateOfBirth.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemForAddress
        '
        Me.ItemForAddress.Control = Me.AddressTextEdit
        Me.ItemForAddress.Location = New System.Drawing.Point(0, 72)
        Me.ItemForAddress.Name = "ItemForAddress"
        Me.ItemForAddress.Size = New System.Drawing.Size(362, 72)
        Me.ItemForAddress.Text = "Address"
        Me.ItemForAddress.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemFornationality
        '
        Me.ItemFornationality.Control = Me.nationalityTextEdit
        Me.ItemFornationality.Location = New System.Drawing.Point(0, 144)
        Me.ItemFornationality.Name = "ItemFornationality"
        Me.ItemFornationality.Size = New System.Drawing.Size(362, 24)
        Me.ItemFornationality.Text = "nationality"
        Me.ItemFornationality.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemForgender
        '
        Me.ItemForgender.Control = Me.genderCheckEdit
        Me.ItemForgender.Location = New System.Drawing.Point(0, 168)
        Me.ItemForgender.Name = "ItemForgender"
        Me.ItemForgender.Size = New System.Drawing.Size(362, 31)
        Me.ItemForgender.Text = "gender"
        Me.ItemForgender.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForpersonInCharge, Me.ItemForrelation, Me.ItemForpersonInChargePhoneNumbers})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(545, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(339, 241)
        Me.LayoutControlGroup4.Text = "Person In Charge"
        '
        'ItemForpersonInCharge
        '
        Me.ItemForpersonInCharge.Control = Me.personInChargeTextEdit
        Me.ItemForpersonInCharge.Location = New System.Drawing.Point(0, 0)
        Me.ItemForpersonInCharge.Name = "ItemForpersonInCharge"
        Me.ItemForpersonInCharge.Size = New System.Drawing.Size(315, 24)
        Me.ItemForpersonInCharge.Text = "Person In Charge"
        Me.ItemForpersonInCharge.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemForrelation
        '
        Me.ItemForrelation.Control = Me.relationLookUpEdit
        Me.ItemForrelation.Location = New System.Drawing.Point(0, 24)
        Me.ItemForrelation.Name = "ItemForrelation"
        Me.ItemForrelation.Size = New System.Drawing.Size(315, 24)
        Me.ItemForrelation.Text = "Relation"
        Me.ItemForrelation.TextSize = New System.Drawing.Size(98, 13)
        '
        'ItemForpersonInChargePhoneNumbers
        '
        Me.ItemForpersonInChargePhoneNumbers.Control = Me.personInChargePhoneNumbersTextEdit
        Me.ItemForpersonInChargePhoneNumbers.Location = New System.Drawing.Point(0, 48)
        Me.ItemForpersonInChargePhoneNumbers.Name = "ItemForpersonInChargePhoneNumbers"
        Me.ItemForpersonInChargePhoneNumbers.Size = New System.Drawing.Size(315, 151)
        Me.ItemForpersonInChargePhoneNumbers.Text = "Phone Number"
        Me.ItemForpersonInChargePhoneNumbers.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForphotograph, Me.ItemForisActive})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(386, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(159, 241)
        Me.LayoutControlGroup5.Text = "Student Additional State"
        '
        'ItemForphotograph
        '
        Me.ItemForphotograph.Control = Me.photographPictureEdit
        Me.ItemForphotograph.Location = New System.Drawing.Point(0, 0)
        Me.ItemForphotograph.MaxSize = New System.Drawing.Size(135, 176)
        Me.ItemForphotograph.MinSize = New System.Drawing.Size(135, 176)
        Me.ItemForphotograph.Name = "ItemForphotograph"
        Me.ItemForphotograph.Size = New System.Drawing.Size(135, 176)
        Me.ItemForphotograph.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForphotograph.StartNewLine = True
        Me.ItemForphotograph.Text = "photograph"
        Me.ItemForphotograph.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForphotograph.TextVisible = False
        '
        'ItemForisActive
        '
        Me.ItemForisActive.Control = Me.isActiveCheckEdit
        Me.ItemForisActive.Location = New System.Drawing.Point(0, 176)
        Me.ItemForisActive.Name = "ItemForisActive"
        Me.ItemForisActive.Size = New System.Drawing.Size(135, 23)
        Me.ItemForisActive.Text = "Active"
        Me.ItemForisActive.TextSize = New System.Drawing.Size(98, 13)
        '
        'lcg6
        '
        Me.lcg6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.lcg6.Location = New System.Drawing.Point(0, 241)
        Me.lcg6.Name = "lcg6"
        Me.lcg6.Size = New System.Drawing.Size(884, 304)
        Me.lcg6.Text = "Student List"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MstStudentGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(860, 239)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.checkEditInactive
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(860, 23)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'MstRelationTableAdapter
        '
        Me.MstRelationTableAdapter.ClearBeforeFill = True
        '
        'FormStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 590)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.MstStudentBindingNavigator)
        Me.Name = "FormStudents"
        Me.Text = "FormStudents"
        CType(Me.DataSetStudentRelation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstStudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstStudentBindingNavigator.ResumeLayout(False)
        Me.MstStudentBindingNavigator.PerformLayout()
        CType(Me.MstStudentGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.checkEditInactive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.registrationNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfBirthDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateOfBirthDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nationalityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photographPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personInChargeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstRelationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personInChargePhoneNumbersTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.genderCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForregistrationNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFordateOfBirth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFornationality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForgender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpersonInCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForrelation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpersonInChargePhoneNumbers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphotograph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcg6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetStudentRelation As DataSetStudentRelation
    Friend WithEvents MstStudentBindingSource As BindingSource
    Friend WithEvents MstStudentTableAdapter As DataSetStudentRelationTableAdapters.mstStudentTableAdapter
    Friend WithEvents TableAdapterManager As DataSetStudentRelationTableAdapters.TableAdapterManager
    Friend WithEvents MstStudentBindingNavigator As BindingNavigator
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
    Friend WithEvents MstStudentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstStudentGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colregistrationNumber As XtraGrid.Columns.GridColumn
    Friend WithEvents colNames As XtraGrid.Columns.GridColumn
    Friend WithEvents coldateOfBirth As XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As XtraGrid.Columns.GridColumn
    Friend WithEvents colnationality As XtraGrid.Columns.GridColumn
    Friend WithEvents colgender As XtraGrid.Columns.GridColumn
    Friend WithEvents colphotograph As XtraGrid.Columns.GridColumn
    Friend WithEvents colpersonInCharge As XtraGrid.Columns.GridColumn
    Friend WithEvents colrelation As XtraGrid.Columns.GridColumn
    Friend WithEvents colpersonInChargePhoneNumbers As XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents registrationNumberTextEdit As TextEdit
    Friend WithEvents NamesTextEdit As TextEdit
    Friend WithEvents dateOfBirthDateEdit As DateEdit
    Friend WithEvents nationalityTextEdit As TextEdit
    Friend WithEvents photographPictureEdit As PictureEdit
    Friend WithEvents personInChargeTextEdit As TextEdit
    Friend WithEvents relationLookUpEdit As LookUpEdit
    Friend WithEvents personInChargePhoneNumbersTextEdit As TextEdit
    Friend WithEvents isActiveCheckEdit As CheckEdit
    Friend WithEvents AddressTextEdit As MemoEdit
    Friend WithEvents genderCheckEdit As RadioGroup
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForregistrationNumber As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNames As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFordateOfBirth As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAddress As XtraLayout.LayoutControlItem
    Friend WithEvents ItemFornationality As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForgender As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForpersonInCharge As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForrelation As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForpersonInChargePhoneNumbers As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForphotograph As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisActive As XtraLayout.LayoutControlItem
    Friend WithEvents MstRelationBindingSource As BindingSource
    Friend WithEvents MstRelationTableAdapter As DataSetStudentRelationTableAdapters.mstRelationTableAdapter
    Friend WithEvents checkEditInactive As CheckEdit
    Friend WithEvents lcg6 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
End Class
