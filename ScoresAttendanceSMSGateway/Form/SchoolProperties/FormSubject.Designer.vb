<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSubject))
        Me.DataSetClassProperties = New ScoresAttendanceSMSGateway.DataSetClassProperties()
        Me.MstSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstSubjectTableAdapter = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.mstSubjectTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager()
        Me.MstSubjectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstSubjectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstSubjectGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsubject = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstSubjectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstSubjectBindingNavigator.SuspendLayout()
        CType(Me.MstSubjectGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetClassProperties
        '
        Me.DataSetClassProperties.DataSetName = "DataSetClassProperties"
        Me.DataSetClassProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstSubjectBindingSource
        '
        Me.MstSubjectBindingSource.DataMember = "mstSubject"
        Me.MstSubjectBindingSource.DataSource = Me.DataSetClassProperties
        '
        'MstSubjectTableAdapter
        '
        Me.MstSubjectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstClassTableAdapter = Nothing
        Me.TableAdapterManager.mstExamTableAdapter = Nothing
        Me.TableAdapterManager.mstNationalHolidayTableAdapter = Nothing
        Me.TableAdapterManager.mstSubjectTableAdapter = Me.MstSubjectTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetClassPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstSubjectBindingNavigator
        '
        Me.MstSubjectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstSubjectBindingNavigator.BindingSource = Me.MstSubjectBindingSource
        Me.MstSubjectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstSubjectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstSubjectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstSubjectBindingNavigatorSaveItem})
        Me.MstSubjectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstSubjectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstSubjectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstSubjectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstSubjectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstSubjectBindingNavigator.Name = "MstSubjectBindingNavigator"
        Me.MstSubjectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstSubjectBindingNavigator.Size = New System.Drawing.Size(268, 25)
        Me.MstSubjectBindingNavigator.TabIndex = 0
        Me.MstSubjectBindingNavigator.Text = "BindingNavigator1"
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
        'MstSubjectBindingNavigatorSaveItem
        '
        Me.MstSubjectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstSubjectBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstSubjectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstSubjectBindingNavigatorSaveItem.Name = "MstSubjectBindingNavigatorSaveItem"
        Me.MstSubjectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstSubjectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstSubjectGridControl
        '
        Me.MstSubjectGridControl.DataSource = Me.MstSubjectBindingSource
        Me.MstSubjectGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstSubjectGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstSubjectGridControl.MainView = Me.GridView1
        Me.MstSubjectGridControl.Name = "MstSubjectGridControl"
        Me.MstSubjectGridControl.Size = New System.Drawing.Size(268, 490)
        Me.MstSubjectGridControl.TabIndex = 1
        Me.MstSubjectGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colsubject})
        Me.GridView1.GridControl = Me.MstSubjectGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colsubject
        '
        Me.colsubject.FieldName = "subject"
        Me.colsubject.Name = "colsubject"
        Me.colsubject.Visible = True
        Me.colsubject.VisibleIndex = 0
        '
        'FormSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 515)
        Me.Controls.Add(Me.MstSubjectGridControl)
        Me.Controls.Add(Me.MstSubjectBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSubject"
        CType(Me.DataSetClassProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstSubjectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstSubjectBindingNavigator.ResumeLayout(False)
        Me.MstSubjectBindingNavigator.PerformLayout()
        CType(Me.MstSubjectGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetClassProperties As DataSetClassProperties
    Friend WithEvents MstSubjectBindingSource As BindingSource
    Friend WithEvents MstSubjectTableAdapter As DataSetClassPropertiesTableAdapters.mstSubjectTableAdapter
    Friend WithEvents TableAdapterManager As DataSetClassPropertiesTableAdapters.TableAdapterManager
    Friend WithEvents MstSubjectBindingNavigator As BindingNavigator
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
    Friend WithEvents MstSubjectBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstSubjectGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject As XtraGrid.Columns.GridColumn
End Class
