<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFailedToSend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFailedToSend))
        Me.DataSetMessage = New ScoresAttendanceSMSGateway.DataSetMessage()
        Me.OzekimessageoutFailedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OzekimessageoutFailedTableAdapter = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.ozekimessageoutFailedTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager()
        Me.OzekimessageoutFailedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OzekimessageoutFailedGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreceiver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmsg = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageoutFailedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageoutFailedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OzekimessageoutFailedBindingNavigator.SuspendLayout()
        CType(Me.OzekimessageoutFailedGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMessage
        '
        Me.DataSetMessage.DataSetName = "DataSetMessage"
        Me.DataSetMessage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OzekimessageoutFailedBindingSource
        '
        Me.OzekimessageoutFailedBindingSource.DataMember = "ozekimessageoutFailed"
        Me.OzekimessageoutFailedBindingSource.DataSource = Me.DataSetMessage
        '
        'OzekimessageoutFailedTableAdapter
        '
        Me.OzekimessageoutFailedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ozekimessageoutFailedTableAdapter = Me.OzekimessageoutFailedTableAdapter
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OzekimessageoutFailedBindingNavigator
        '
        Me.OzekimessageoutFailedBindingNavigator.AddNewItem = Nothing
        Me.OzekimessageoutFailedBindingNavigator.BindingSource = Me.OzekimessageoutFailedBindingSource
        Me.OzekimessageoutFailedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OzekimessageoutFailedBindingNavigator.DeleteItem = Nothing
        Me.OzekimessageoutFailedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.OzekimessageoutFailedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OzekimessageoutFailedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OzekimessageoutFailedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OzekimessageoutFailedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OzekimessageoutFailedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OzekimessageoutFailedBindingNavigator.Name = "OzekimessageoutFailedBindingNavigator"
        Me.OzekimessageoutFailedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OzekimessageoutFailedBindingNavigator.Size = New System.Drawing.Size(611, 25)
        Me.OzekimessageoutFailedBindingNavigator.TabIndex = 0
        Me.OzekimessageoutFailedBindingNavigator.Text = "BindingNavigator1"
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
        'OzekimessageoutFailedGridControl
        '
        Me.OzekimessageoutFailedGridControl.DataSource = Me.OzekimessageoutFailedBindingSource
        Me.OzekimessageoutFailedGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OzekimessageoutFailedGridControl.Location = New System.Drawing.Point(0, 25)
        Me.OzekimessageoutFailedGridControl.MainView = Me.GridView1
        Me.OzekimessageoutFailedGridControl.Name = "OzekimessageoutFailedGridControl"
        Me.OzekimessageoutFailedGridControl.Size = New System.Drawing.Size(611, 432)
        Me.OzekimessageoutFailedGridControl.TabIndex = 1
        Me.OzekimessageoutFailedGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsender, Me.colreceiver, Me.colmsg})
        Me.GridView1.GridControl = Me.OzekimessageoutFailedGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colsender
        '
        Me.colsender.FieldName = "sender"
        Me.colsender.Name = "colsender"
        Me.colsender.Visible = True
        Me.colsender.VisibleIndex = 0
        '
        'colreceiver
        '
        Me.colreceiver.FieldName = "receiver"
        Me.colreceiver.Name = "colreceiver"
        Me.colreceiver.Visible = True
        Me.colreceiver.VisibleIndex = 1
        '
        'colmsg
        '
        Me.colmsg.FieldName = "msg"
        Me.colmsg.Name = "colmsg"
        Me.colmsg.Visible = True
        Me.colmsg.VisibleIndex = 2
        '
        'FormFailedToSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 457)
        Me.Controls.Add(Me.OzekimessageoutFailedGridControl)
        Me.Controls.Add(Me.OzekimessageoutFailedBindingNavigator)
        Me.Name = "FormFailedToSend"
        Me.Text = "FormFailedToSend"
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageoutFailedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageoutFailedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OzekimessageoutFailedBindingNavigator.ResumeLayout(False)
        Me.OzekimessageoutFailedBindingNavigator.PerformLayout()
        CType(Me.OzekimessageoutFailedGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMessage As DataSetMessage
    Friend WithEvents OzekimessageoutFailedBindingSource As BindingSource
    Friend WithEvents OzekimessageoutFailedTableAdapter As DataSetMessageTableAdapters.ozekimessageoutFailedTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMessageTableAdapters.TableAdapterManager
    Friend WithEvents OzekimessageoutFailedBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OzekimessageoutFailedGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colsender As XtraGrid.Columns.GridColumn
    Friend WithEvents colreceiver As XtraGrid.Columns.GridColumn
    Friend WithEvents colmsg As XtraGrid.Columns.GridColumn
End Class
