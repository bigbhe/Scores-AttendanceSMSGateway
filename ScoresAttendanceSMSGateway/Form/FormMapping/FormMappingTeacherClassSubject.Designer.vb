<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMappingTeacherClassSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMappingTeacherClassSubject))
        Me.DataSetMapping = New ScoresAttendanceSMSGateway.DataSetMapping()
        Me.MappingTeacherClassSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MappingTeacherClassSubjectTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mappingTeacherClassSubjectTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.TableAdapterManager()
        Me.MappingTeacherClassSubjectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MappingTeacherClassSubjectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MappingTeacherClassSubjectGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidTeacher = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstClassTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mstClassTableAdapter()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstSubjectTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mstSubjectTableAdapter()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstTeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstTeacherTableAdapter = New ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.mstTeacherTableAdapter()
        CType(Me.DataSetMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MappingTeacherClassSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MappingTeacherClassSubjectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MappingTeacherClassSubjectBindingNavigator.SuspendLayout()
        CType(Me.MappingTeacherClassSubjectGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstTeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMapping
        '
        Me.DataSetMapping.DataSetName = "DataSetMapping"
        Me.DataSetMapping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MappingTeacherClassSubjectBindingSource
        '
        Me.MappingTeacherClassSubjectBindingSource.DataMember = "mappingTeacherClassSubject"
        Me.MappingTeacherClassSubjectBindingSource.DataSource = Me.DataSetMapping
        '
        'MappingTeacherClassSubjectTableAdapter
        '
        Me.MappingTeacherClassSubjectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mappingStudentAndClassTableAdapter = Nothing
        Me.TableAdapterManager.mappingTeacherClassSubjectTableAdapter = Me.MappingTeacherClassSubjectTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetMappingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MappingTeacherClassSubjectBindingNavigator
        '
        Me.MappingTeacherClassSubjectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MappingTeacherClassSubjectBindingNavigator.BindingSource = Me.MappingTeacherClassSubjectBindingSource
        Me.MappingTeacherClassSubjectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MappingTeacherClassSubjectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MappingTeacherClassSubjectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MappingTeacherClassSubjectBindingNavigatorSaveItem})
        Me.MappingTeacherClassSubjectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MappingTeacherClassSubjectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MappingTeacherClassSubjectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MappingTeacherClassSubjectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MappingTeacherClassSubjectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MappingTeacherClassSubjectBindingNavigator.Name = "MappingTeacherClassSubjectBindingNavigator"
        Me.MappingTeacherClassSubjectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MappingTeacherClassSubjectBindingNavigator.Size = New System.Drawing.Size(675, 25)
        Me.MappingTeacherClassSubjectBindingNavigator.TabIndex = 0
        Me.MappingTeacherClassSubjectBindingNavigator.Text = "BindingNavigator1"
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
        'MappingTeacherClassSubjectBindingNavigatorSaveItem
        '
        Me.MappingTeacherClassSubjectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MappingTeacherClassSubjectBindingNavigatorSaveItem.Image = CType(resources.GetObject("MappingTeacherClassSubjectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MappingTeacherClassSubjectBindingNavigatorSaveItem.Name = "MappingTeacherClassSubjectBindingNavigatorSaveItem"
        Me.MappingTeacherClassSubjectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MappingTeacherClassSubjectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MappingTeacherClassSubjectGridControl
        '
        Me.MappingTeacherClassSubjectGridControl.DataSource = Me.MappingTeacherClassSubjectBindingSource
        Me.MappingTeacherClassSubjectGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MappingTeacherClassSubjectGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MappingTeacherClassSubjectGridControl.MainView = Me.GridView1
        Me.MappingTeacherClassSubjectGridControl.Name = "MappingTeacherClassSubjectGridControl"
        Me.MappingTeacherClassSubjectGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.MappingTeacherClassSubjectGridControl.Size = New System.Drawing.Size(675, 497)
        Me.MappingTeacherClassSubjectGridControl.TabIndex = 1
        Me.MappingTeacherClassSubjectGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidClass, Me.colidSubject, Me.colidTeacher})
        Me.GridView1.GridControl = Me.MappingTeacherClassSubjectGridControl
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
        'colidSubject
        '
        Me.colidSubject.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidSubject.FieldName = "idSubject"
        Me.colidSubject.Name = "colidSubject"
        Me.colidSubject.Visible = True
        Me.colidSubject.VisibleIndex = 1
        '
        'colidTeacher
        '
        Me.colidTeacher.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colidTeacher.FieldName = "idTeacher"
        Me.colidTeacher.Name = "colidTeacher"
        Me.colidTeacher.Visible = True
        Me.colidTeacher.VisibleIndex = 2
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
        'MstClassTableAdapter
        '
        Me.MstClassTableAdapter.ClearBeforeFill = True
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.MstSubjectBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "subject"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'MstSubjectBindingSource
        '
        Me.MstSubjectBindingSource.DataMember = "mstSubject"
        Me.MstSubjectBindingSource.DataSource = Me.DataSetMapping
        '
        'MstSubjectTableAdapter
        '
        Me.MstSubjectTableAdapter.ClearBeforeFill = True
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.MstTeacherBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Names"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "id"
        '
        'MstTeacherBindingSource
        '
        Me.MstTeacherBindingSource.DataMember = "mstTeacher"
        Me.MstTeacherBindingSource.DataSource = Me.DataSetMapping
        '
        'MstTeacherTableAdapter
        '
        Me.MstTeacherTableAdapter.ClearBeforeFill = True
        '
        'FormMappingTeacherClassSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 522)
        Me.Controls.Add(Me.MappingTeacherClassSubjectGridControl)
        Me.Controls.Add(Me.MappingTeacherClassSubjectBindingNavigator)
        Me.Name = "FormMappingTeacherClassSubject"
        Me.Text = "FormMappingTeacherClassSubject"
        CType(Me.DataSetMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MappingTeacherClassSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MappingTeacherClassSubjectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MappingTeacherClassSubjectBindingNavigator.ResumeLayout(False)
        Me.MappingTeacherClassSubjectBindingNavigator.PerformLayout()
        CType(Me.MappingTeacherClassSubjectGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstTeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMapping As DataSetMapping
    Friend WithEvents MappingTeacherClassSubjectBindingSource As BindingSource
    Friend WithEvents MappingTeacherClassSubjectTableAdapter As DataSetMappingTableAdapters.mappingTeacherClassSubjectTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMappingTableAdapters.TableAdapterManager
    Friend WithEvents MappingTeacherClassSubjectBindingNavigator As BindingNavigator
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
    Friend WithEvents MappingTeacherClassSubjectBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MappingTeacherClassSubjectGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidClass As XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents colidSubject As XtraGrid.Columns.GridColumn
    Friend WithEvents colidTeacher As XtraGrid.Columns.GridColumn
    Friend WithEvents MstClassBindingSource As BindingSource
    Friend WithEvents MstClassTableAdapter As DataSetMappingTableAdapters.mstClassTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstSubjectBindingSource As BindingSource
    Friend WithEvents MstSubjectTableAdapter As DataSetMappingTableAdapters.mstSubjectTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit3 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstTeacherBindingSource As BindingSource
    Friend WithEvents MstTeacherTableAdapter As DataSetMappingTableAdapters.mstTeacherTableAdapter
End Class
