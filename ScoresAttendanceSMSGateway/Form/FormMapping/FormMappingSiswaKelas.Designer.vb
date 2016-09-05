<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMappingStudentClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMappingStudentClass))
        Me.DataSetMapping = New ScoresAttendanceSMSGateway.DataSetMapping()
        Me.MappingStudentAndClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MappingStudentAndClassTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mappingStudentAndClassTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.TableAdapterManager()
        Me.MappingStudentAndClassBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MappingStudentAndClassBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MappingStudentAndClassGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidStudent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstStudentTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mstStudentTableAdapter()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstClassTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mstClassTableAdapter()
        CType(Me.DataSetMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MappingStudentAndClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MappingStudentAndClassBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MappingStudentAndClassBindingNavigator.SuspendLayout()
        CType(Me.MappingStudentAndClassGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMapping
        '
        Me.DataSetMapping.DataSetName = "DataSetMapping"
        Me.DataSetMapping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MappingStudentAndClassBindingSource
        '
        Me.MappingStudentAndClassBindingSource.DataMember = "mappingStudentAndClass"
        Me.MappingStudentAndClassBindingSource.DataSource = Me.DataSetMapping
        '
        'MappingStudentAndClassTableAdapter
        '
        Me.MappingStudentAndClassTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mappingStudentAndClassTableAdapter = Me.MappingStudentAndClassTableAdapter
        Me.TableAdapterManager.mappingTeacherClassSubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MappingStudentAndClassBindingNavigator
        '
        Me.MappingStudentAndClassBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MappingStudentAndClassBindingNavigator.BindingSource = Me.MappingStudentAndClassBindingSource
        Me.MappingStudentAndClassBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MappingStudentAndClassBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MappingStudentAndClassBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MappingStudentAndClassBindingNavigatorSaveItem})
        Me.MappingStudentAndClassBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MappingStudentAndClassBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MappingStudentAndClassBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MappingStudentAndClassBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MappingStudentAndClassBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MappingStudentAndClassBindingNavigator.Name = "MappingStudentAndClassBindingNavigator"
        Me.MappingStudentAndClassBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MappingStudentAndClassBindingNavigator.Size = New System.Drawing.Size(651, 25)
        Me.MappingStudentAndClassBindingNavigator.TabIndex = 0
        Me.MappingStudentAndClassBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'MappingStudentAndClassBindingNavigatorSaveItem
        '
        Me.MappingStudentAndClassBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MappingStudentAndClassBindingNavigatorSaveItem.Image = CType(resources.GetObject("MappingStudentAndClassBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MappingStudentAndClassBindingNavigatorSaveItem.Name = "MappingStudentAndClassBindingNavigatorSaveItem"
        Me.MappingStudentAndClassBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MappingStudentAndClassBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MappingStudentAndClassGridControl
        '
        Me.MappingStudentAndClassGridControl.DataSource = Me.MappingStudentAndClassBindingSource
        Me.MappingStudentAndClassGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MappingStudentAndClassGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MappingStudentAndClassGridControl.MainView = Me.GridView1
        Me.MappingStudentAndClassGridControl.Name = "MappingStudentAndClassGridControl"
        Me.MappingStudentAndClassGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.MappingStudentAndClassGridControl.Size = New System.Drawing.Size(651, 463)
        Me.MappingStudentAndClassGridControl.TabIndex = 1
        Me.MappingStudentAndClassGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidStudent, Me.colidClass})
        Me.GridView1.GridControl = Me.MappingStudentAndClassGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidStudent
        '
        Me.colidStudent.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidStudent.FieldName = "idStudent"
        Me.colidStudent.Name = "colidStudent"
        Me.colidStudent.Visible = True
        Me.colidStudent.VisibleIndex = 0
        '
        'colidClass
        '
        Me.colidClass.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidClass.FieldName = "idClass"
        Me.colidClass.Name = "colidClass"
        Me.colidClass.Visible = True
        Me.colidClass.VisibleIndex = 1
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
        Me.MstStudentBindingSource.DataSource = Me.DataSetMapping
        '
        'MstStudentTableAdapter
        '
        Me.MstStudentTableAdapter.ClearBeforeFill = True
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
        Me.MstClassBindingSource.DataSource = Me.DataSetMapping
        '
        'MstClassTableAdapter
        '
        Me.MstClassTableAdapter.ClearBeforeFill = True
        '
        'FormMappingStudentClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 488)
        Me.Controls.Add(Me.MappingStudentAndClassGridControl)
        Me.Controls.Add(Me.MappingStudentAndClassBindingNavigator)
        Me.Name = "FormMappingStudentClass"
        Me.Text = "FormMappingStudentClasss"
        CType(Me.DataSetMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MappingStudentAndClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MappingStudentAndClassBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MappingStudentAndClassBindingNavigator.ResumeLayout(False)
        Me.MappingStudentAndClassBindingNavigator.PerformLayout()
        CType(Me.MappingStudentAndClassGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMapping As DataSetMapping
    Friend WithEvents MappingStudentAndClassBindingSource As BindingSource
    Friend WithEvents MappingStudentAndClassTableAdapter As DataSetMappingTableAdapters.mappingStudentAndClassTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMappingTableAdapters.TableAdapterManager
    Friend WithEvents MappingStudentAndClassBindingNavigator As BindingNavigator
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
    Friend WithEvents MappingStudentAndClassBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MappingStudentAndClassGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidStudent As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents colidClass As XtraGrid.Columns.GridColumn
    Friend WithEvents MstStudentBindingSource As BindingSource
    Friend WithEvents MstStudentTableAdapter As DataSetMappingTableAdapters.mstStudentTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstClassBindingSource As BindingSource
    Friend WithEvents MstClassTableAdapter As DataSetMappingTableAdapters.mstClassTableAdapter
End Class
