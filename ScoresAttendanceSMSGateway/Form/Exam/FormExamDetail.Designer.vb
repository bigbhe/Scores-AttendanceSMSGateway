<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExamDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExamDetail))
        Me.DataSetExam = New ScoresAttendanceSMSGateway.DataSetExam()
        Me.ExamDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamDetailTableAdapter = New ScoresAttendanceSMSGateway.DataSetExamTableAdapters.examDetailTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetExamTableAdapters.TableAdapterManager()
        Me.ExamDetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ExamDetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ExamDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidStudent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colscores = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.labelNote = New DevExpress.XtraEditors.LabelControl()
        Me.idStudentLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.StudentForExamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.scoresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidStudent = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForscores = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StudentForExamTableAdapter = New ScoresAttendanceSMSGateway.DataSetExamTableAdapters.studentForExamTableAdapter()
        Me.MstStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstStudentTableAdapter = New ScoresAttendanceSMSGateway.DataSetExamTableAdapters.mstStudentTableAdapter()
        CType(Me.DataSetExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamDetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExamDetailBindingNavigator.SuspendLayout()
        CType(Me.ExamDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idStudentLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentForExamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scoresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForscores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetExam
        '
        Me.DataSetExam.DataSetName = "DataSetExam"
        Me.DataSetExam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamDetailBindingSource
        '
        Me.ExamDetailBindingSource.DataMember = "examDetail"
        Me.ExamDetailBindingSource.DataSource = Me.DataSetExam
        '
        'ExamDetailTableAdapter
        '
        Me.ExamDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.examDetailTableAdapter = Me.ExamDetailTableAdapter
        Me.TableAdapterManager.examHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetExamTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ExamDetailBindingNavigator
        '
        Me.ExamDetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExamDetailBindingNavigator.BindingSource = Me.ExamDetailBindingSource
        Me.ExamDetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExamDetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExamDetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ExamDetailBindingNavigatorSaveItem})
        Me.ExamDetailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExamDetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExamDetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExamDetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExamDetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExamDetailBindingNavigator.Name = "ExamDetailBindingNavigator"
        Me.ExamDetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExamDetailBindingNavigator.Size = New System.Drawing.Size(600, 25)
        Me.ExamDetailBindingNavigator.TabIndex = 0
        Me.ExamDetailBindingNavigator.Text = "BindingNavigator1"
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
        'ExamDetailBindingNavigatorSaveItem
        '
        Me.ExamDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExamDetailBindingNavigatorSaveItem.Image = CType(resources.GetObject("ExamDetailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ExamDetailBindingNavigatorSaveItem.Name = "ExamDetailBindingNavigatorSaveItem"
        Me.ExamDetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ExamDetailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ExamDetailGridControl
        '
        Me.ExamDetailGridControl.DataSource = Me.ExamDetailBindingSource
        Me.ExamDetailGridControl.Location = New System.Drawing.Point(12, 81)
        Me.ExamDetailGridControl.MainView = Me.GridView1
        Me.ExamDetailGridControl.Name = "ExamDetailGridControl"
        Me.ExamDetailGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.ExamDetailGridControl.Size = New System.Drawing.Size(576, 507)
        Me.ExamDetailGridControl.TabIndex = 2
        Me.ExamDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidHeader, Me.colidStudent, Me.colscores})
        Me.GridView1.GridControl = Me.ExamDetailGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidHeader
        '
        Me.colidHeader.FieldName = "idHeader"
        Me.colidHeader.Name = "colidHeader"
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
        'colscores
        '
        Me.colscores.FieldName = "scores"
        Me.colscores.Name = "colscores"
        Me.colscores.Visible = True
        Me.colscores.VisibleIndex = 1
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.labelNote)
        Me.DataLayoutControl1.Controls.Add(Me.ExamDetailGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idStudentLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.scoresTextEdit)
        Me.DataLayoutControl1.DataSource = Me.ExamDetailBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(600, 600)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'labelNote
        '
        Me.labelNote.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNote.Location = New System.Drawing.Point(12, 12)
        Me.labelNote.Name = "labelNote"
        Me.labelNote.Size = New System.Drawing.Size(81, 17)
        Me.labelNote.StyleController = Me.DataLayoutControl1
        Me.labelNote.TabIndex = 6
        Me.labelNote.Text = "LabelControl1"
        '
        'idStudentLookUpEdit
        '
        Me.idStudentLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ExamDetailBindingSource, "idStudent", True))
        Me.idStudentLookUpEdit.Location = New System.Drawing.Point(64, 33)
        Me.idStudentLookUpEdit.Name = "idStudentLookUpEdit"
        Me.idStudentLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idStudentLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idStudentLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idStudentLookUpEdit.Properties.DataSource = Me.StudentForExamBindingSource
        Me.idStudentLookUpEdit.Properties.DisplayMember = "Names"
        Me.idStudentLookUpEdit.Properties.NullText = ""
        Me.idStudentLookUpEdit.Properties.ValueMember = "id"
        Me.idStudentLookUpEdit.Size = New System.Drawing.Size(524, 20)
        Me.idStudentLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idStudentLookUpEdit.TabIndex = 4
        '
        'StudentForExamBindingSource
        '
        Me.StudentForExamBindingSource.DataMember = "studentForExam"
        Me.StudentForExamBindingSource.DataSource = Me.DataSetExam
        '
        'scoresTextEdit
        '
        Me.scoresTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ExamDetailBindingSource, "scores", True))
        Me.scoresTextEdit.Location = New System.Drawing.Point(64, 57)
        Me.scoresTextEdit.Name = "scoresTextEdit"
        Me.scoresTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.scoresTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.scoresTextEdit.Properties.Mask.EditMask = "N0"
        Me.scoresTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.scoresTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.scoresTextEdit.Size = New System.Drawing.Size(524, 20)
        Me.scoresTextEdit.StyleController = Me.DataLayoutControl1
        Me.scoresTextEdit.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(600, 600)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidStudent, Me.ItemForscores, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(580, 580)
        '
        'ItemForidStudent
        '
        Me.ItemForidStudent.Control = Me.idStudentLookUpEdit
        Me.ItemForidStudent.Location = New System.Drawing.Point(0, 21)
        Me.ItemForidStudent.Name = "ItemForidStudent"
        Me.ItemForidStudent.Size = New System.Drawing.Size(580, 24)
        Me.ItemForidStudent.Text = "id Student"
        Me.ItemForidStudent.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForscores
        '
        Me.ItemForscores.Control = Me.scoresTextEdit
        Me.ItemForscores.Location = New System.Drawing.Point(0, 45)
        Me.ItemForscores.Name = "ItemForscores"
        Me.ItemForscores.Size = New System.Drawing.Size(580, 24)
        Me.ItemForscores.Text = "scores"
        Me.ItemForscores.TextSize = New System.Drawing.Size(49, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ExamDetailGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 69)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(580, 511)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.labelNote
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(580, 21)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'StudentForExamTableAdapter
        '
        Me.StudentForExamTableAdapter.ClearBeforeFill = True
        '
        'MstStudentBindingSource
        '
        Me.MstStudentBindingSource.DataMember = "mstStudent"
        Me.MstStudentBindingSource.DataSource = Me.DataSetExam
        '
        'MstStudentTableAdapter
        '
        Me.MstStudentTableAdapter.ClearBeforeFill = True
        '
        'FormExamDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 625)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.ExamDetailBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormExamDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormExamDetail"
        CType(Me.DataSetExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamDetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExamDetailBindingNavigator.ResumeLayout(False)
        Me.ExamDetailBindingNavigator.PerformLayout()
        CType(Me.ExamDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idStudentLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentForExamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scoresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForscores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetExam As DataSetExam
    Friend WithEvents ExamDetailBindingSource As BindingSource
    Friend WithEvents ExamDetailTableAdapter As DataSetExamTableAdapters.examDetailTableAdapter
    Friend WithEvents TableAdapterManager As DataSetExamTableAdapters.TableAdapterManager
    Friend WithEvents ExamDetailBindingNavigator As BindingNavigator
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
    Friend WithEvents ExamDetailBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ExamDetailGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colidHeader As XtraGrid.Columns.GridColumn
    Friend WithEvents colidStudent As XtraGrid.Columns.GridColumn
    Friend WithEvents colscores As XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idStudentLookUpEdit As LookUpEdit
    Friend WithEvents StudentForExamBindingSource As BindingSource
    Friend WithEvents scoresTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidStudent As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForscores As XtraLayout.LayoutControlItem
    Friend WithEvents StudentForExamTableAdapter As DataSetExamTableAdapters.studentForExamTableAdapter
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents labelNote As LabelControl
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemLookUpEdit1 As Repository.RepositoryItemLookUpEdit
    Friend WithEvents MstStudentBindingSource As BindingSource
    Friend WithEvents MstStudentTableAdapter As DataSetExamTableAdapters.mstStudentTableAdapter
End Class
