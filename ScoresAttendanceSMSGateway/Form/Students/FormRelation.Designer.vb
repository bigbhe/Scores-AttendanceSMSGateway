<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRelation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelation))
        Me.DataSetStudentRelation = New ScoresAttendanceSMSGateway.DataSetStudentRelation()
        Me.MstRelationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstRelationTableAdapter = New ScoresAttendanceSMSGateway.DataSetStudentRelationTableAdapters.mstRelationTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetStudentRelationTableAdapters.TableAdapterManager()
        Me.MstRelationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstRelationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstRelationGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrelation = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetStudentRelation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstRelationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstRelationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstRelationBindingNavigator.SuspendLayout()
        CType(Me.MstRelationGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetStudentRelation
        '
        Me.DataSetStudentRelation.DataSetName = "DataSetStudentRelation"
        Me.DataSetStudentRelation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstRelationBindingSource
        '
        Me.MstRelationBindingSource.DataMember = "mstRelation"
        Me.MstRelationBindingSource.DataSource = Me.DataSetStudentRelation
        '
        'MstRelationTableAdapter
        '
        Me.MstRelationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstRelationTableAdapter = Me.MstRelationTableAdapter
        Me.TableAdapterManager.mstStudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetStudentRelationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstRelationBindingNavigator
        '
        Me.MstRelationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstRelationBindingNavigator.BindingSource = Me.MstRelationBindingSource
        Me.MstRelationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstRelationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstRelationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstRelationBindingNavigatorSaveItem})
        Me.MstRelationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstRelationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstRelationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstRelationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstRelationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstRelationBindingNavigator.Name = "MstRelationBindingNavigator"
        Me.MstRelationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstRelationBindingNavigator.Size = New System.Drawing.Size(320, 25)
        Me.MstRelationBindingNavigator.TabIndex = 0
        Me.MstRelationBindingNavigator.Text = "BindingNavigator1"
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
        'MstRelationBindingNavigatorSaveItem
        '
        Me.MstRelationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstRelationBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstRelationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstRelationBindingNavigatorSaveItem.Name = "MstRelationBindingNavigatorSaveItem"
        Me.MstRelationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstRelationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstRelationGridControl
        '
        Me.MstRelationGridControl.DataSource = Me.MstRelationBindingSource
        Me.MstRelationGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstRelationGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstRelationGridControl.MainView = Me.GridView1
        Me.MstRelationGridControl.Name = "MstRelationGridControl"
        Me.MstRelationGridControl.Size = New System.Drawing.Size(320, 537)
        Me.MstRelationGridControl.TabIndex = 1
        Me.MstRelationGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colrelation})
        Me.GridView1.GridControl = Me.MstRelationGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colrelation
        '
        Me.colrelation.FieldName = "relation"
        Me.colrelation.Name = "colrelation"
        Me.colrelation.Visible = True
        Me.colrelation.VisibleIndex = 0
        '
        'FormRelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 562)
        Me.Controls.Add(Me.MstRelationGridControl)
        Me.Controls.Add(Me.MstRelationBindingNavigator)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormRelation"
        Me.Text = "FormRelation"
        CType(Me.DataSetStudentRelation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstRelationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstRelationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstRelationBindingNavigator.ResumeLayout(False)
        Me.MstRelationBindingNavigator.PerformLayout()
        CType(Me.MstRelationGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetStudentRelation As DataSetStudentRelation
    Friend WithEvents MstRelationBindingSource As BindingSource
    Friend WithEvents MstRelationTableAdapter As DataSetStudentRelationTableAdapters.mstRelationTableAdapter
    Friend WithEvents TableAdapterManager As DataSetStudentRelationTableAdapters.TableAdapterManager
    Friend WithEvents MstRelationBindingNavigator As BindingNavigator
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
    Friend WithEvents MstRelationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstRelationGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colrelation As XtraGrid.Columns.GridColumn
End Class
