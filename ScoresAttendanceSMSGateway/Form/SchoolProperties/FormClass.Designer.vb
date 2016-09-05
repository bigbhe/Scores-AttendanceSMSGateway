<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClass))
        Me.DataSetClassProperties = New ScoresAttendanceSMSGateway.DataSetClassProperties()
        Me.MstClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstClassTableAdapter = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.mstClassTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager()
        Me.MstClassBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstClassBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstClassGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClass = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstClassBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstClassBindingNavigator.SuspendLayout()
        CType(Me.MstClassGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetClassProperties
        '
        Me.DataSetClassProperties.DataSetName = "DataSetClassProperties"
        Me.DataSetClassProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstClassBindingSource
        '
        Me.MstClassBindingSource.DataMember = "mstClass"
        Me.MstClassBindingSource.DataSource = Me.DataSetClassProperties
        '
        'MstClassTableAdapter
        '
        Me.MstClassTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstClassTableAdapter = Me.MstClassTableAdapter
        Me.TableAdapterManager.mstExamTableAdapter = Nothing
        Me.TableAdapterManager.mstNationalHolidayTableAdapter = Nothing
        Me.TableAdapterManager.mstSubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstClassBindingNavigator
        '
        Me.MstClassBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstClassBindingNavigator.BindingSource = Me.MstClassBindingSource
        Me.MstClassBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstClassBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstClassBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstClassBindingNavigatorSaveItem})
        Me.MstClassBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstClassBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstClassBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstClassBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstClassBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstClassBindingNavigator.Name = "MstClassBindingNavigator"
        Me.MstClassBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstClassBindingNavigator.Size = New System.Drawing.Size(323, 25)
        Me.MstClassBindingNavigator.TabIndex = 0
        Me.MstClassBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MstClassBindingNavigatorSaveItem
        '
        Me.MstClassBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstClassBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstClassBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstClassBindingNavigatorSaveItem.Name = "MstClassBindingNavigatorSaveItem"
        Me.MstClassBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MstClassBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstClassGridControl
        '
        Me.MstClassGridControl.DataSource = Me.MstClassBindingSource
        Me.MstClassGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstClassGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstClassGridControl.MainView = Me.GridView1
        Me.MstClassGridControl.Name = "MstClassGridControl"
        Me.MstClassGridControl.Size = New System.Drawing.Size(323, 523)
        Me.MstClassGridControl.TabIndex = 1
        Me.MstClassGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colClass})
        Me.GridView1.GridControl = Me.MstClassGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colClass
        '
        Me.colClass.FieldName = "Class"
        Me.colClass.Name = "colClass"
        Me.colClass.Visible = True
        Me.colClass.VisibleIndex = 0
        '
        'FormClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 548)
        Me.Controls.Add(Me.MstClassGridControl)
        Me.Controls.Add(Me.MstClassBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormClass"
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstClassBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstClassBindingNavigator.ResumeLayout(False)
        Me.MstClassBindingNavigator.PerformLayout()
        CType(Me.MstClassGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetClassProperties As DataSetClassProperties
    Friend WithEvents MstClassBindingSource As BindingSource
    Friend WithEvents MstClassTableAdapter As DataSetClassPropertiesTableAdapters.mstClassTableAdapter
    Friend WithEvents TableAdapterManager As DataSetClassPropertiesTableAdapters.TableAdapterManager
    Friend WithEvents MstClassBindingNavigator As BindingNavigator
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
    Friend WithEvents MstClassBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstClassGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colClass As XtraGrid.Columns.GridColumn
End Class
